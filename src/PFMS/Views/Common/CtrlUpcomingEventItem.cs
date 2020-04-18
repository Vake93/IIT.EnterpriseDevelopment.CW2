using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.Events;

namespace PFMS.Views.Common
{
    public partial class CtrlUpcomingEventItem : MetroUserControl
    {
        public CtrlUpcomingEventItem(
            MetroStyleManager styleManager,
            Event @event)
        {
            InitializeComponent();

            StyleManager = styleManager;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            EventTitle.Text = @event.Title;
            EventDate.Text = $"{@event.DateTime.ToLongDateString()} {@event.DateTime.ToLongTimeString()}";
            EventLocation.Text = $"Location: {@event.Location}";
        }
    }
}
