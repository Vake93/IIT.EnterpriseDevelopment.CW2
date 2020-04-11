using PFMS.Domain.Models.Users;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Services.Authentication
{
    public interface IAuthenticationService
    {
        User LoggedInUser { get; }

        Task<bool> LoginUserAsync(
            string userName,
            string password,
            CancellationToken cancellationToken = default);

        Task<bool> SetPasswordAsync(
            string userName,
            string password,
            CancellationToken cancellationToken = default);

        Task<bool> UpdatePasswordAsync(
            string userName,
            string oldPassword,
            string newPassword,
            CancellationToken cancellationToken = default);
    }
}