using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Events;
using PFMS.Domain.Repositories.Events;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System;
using System.Threading.Tasks;

namespace PFMS.Views
{
    public partial class FrmCalendar : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IEventRepository _eventRepository;
        private bool initialLoaded;

        public FrmCalendar(
            IEventRepository eventRepository,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _eventRepository = eventRepository;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);
        }

        private async Task LoadData()
        {
            SetSpinnerSpinning(true);

            EventLayoutPanel.Controls.Clear();

            var events = await _eventRepository.FindAsync(
                    e => e.UserId == _authenticationService.LoggedInUser.Id &&
                         e.DateTime.Date == CmbDate.Value.Date &&
                         !e.Deleted);

            foreach (var @event in events)
            {
                var ctrlEventItem = new CtrlEventItem(
                    StyleManager,
                    @event);

                ctrlEventItem.Saved += CtrlEventItem_Saved;
                ctrlEventItem.Deleted += CtrlEventItem_Deleted;

                EventLayoutPanel.Controls.Add(ctrlEventItem);
            }

            SetSpinnerSpinning(false);
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Spinner.BringToFront();
        }

        private void NewEvent_Click(object sender, EventArgs e)
        {
            var eventDateTime = new DateTime(
                CmbDate.Value.Year,
                CmbDate.Value.Month,
                CmbDate.Value.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                0);

            var ctrlEventItem = new CtrlEventItem(
                StyleManager,
                new Event(_authenticationService.LoggedInUser.Id, string.Empty, eventDateTime)
                {
                    Duration = 60
                })
            {
                EditMode = true
            };

            ctrlEventItem.Saved += CtrlEventItem_Saved;
            ctrlEventItem.Deleted += CtrlEventItem_Deleted;

            EventLayoutPanel.Controls.Add(ctrlEventItem);
        }

        private async void CmbDate_ValueChanged(object sender, EventArgs e)
        {
            if (initialLoaded)
                await LoadData();
        }

        private async void FrmCalendar_Shown(object sender, EventArgs e)
        {
            await LoadData();
            initialLoaded = true;
        }

        private async void CtrlEventItem_Deleted(CtrlEventItem ctrlEventItem)
        {
            SetSpinnerSpinning(true);

            ctrlEventItem.Saved -= CtrlEventItem_Saved;
            ctrlEventItem.Deleted -= CtrlEventItem_Deleted;

            EventLayoutPanel.Controls.Remove(ctrlEventItem);

            var delete = await _eventRepository.AnyAsync(e => e.Id == ctrlEventItem.Event.Id);

            if (delete)
            {
                ctrlEventItem.Event.Delete();
                _eventRepository.Update(ctrlEventItem.Event);
                await _eventRepository.SaveChangesAsync();
            }

            SetSpinnerSpinning(false);
        }

        private async void CtrlEventItem_Saved(CtrlEventItem ctrlEventItem)
        {
            SetSpinnerSpinning(true);

            var update = await _eventRepository.AnyAsync(e => e.Id == ctrlEventItem.Event.Id);

            if (update)
            {
                _eventRepository.Update(ctrlEventItem.Event);
            }
            else
            {
                _eventRepository.Add(ctrlEventItem.Event);
            }

            await _eventRepository.SaveChangesAsync();

            SetSpinnerSpinning(false);
        }
    }
}
