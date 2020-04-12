using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Users;
using PFMS.Domain.Repositories.Users;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PFMS.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserQuery _userQuery;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(
            IUserQuery userQuery,
            IUserRepository userRepository)
        {
            _userQuery = userQuery;
            _userRepository = userRepository;
        }

        public User LoggedInUser { get; private set; }

        public async Task<bool> LoginUserAsync(
            string userName,
            string password,
            CancellationToken cancellationToken = default)
        {
            var user = await _userQuery.FindUserAsync(userName, cancellationToken);

            if (user is User)
            {
                if (ValidatePassword(password, user.SecurityStamp, user.PasswordHash))
                {
                    LoggedInUser = user;
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> SetPasswordAsync(
            string userName,
            string password,
            CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.FindUserAsync(userName, cancellationToken);

            if (user is User)
            {
                user.SecurityStamp = CreateSecurityStamp();
                user.PasswordHash = CreatePasswordHash(password, user.SecurityStamp);
                await _userRepository.SaveChangesAsync(cancellationToken);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdatePasswordAsync(
            string userName,
            string oldPassword,
            string newPassword,
            CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.FindUserAsync(userName, cancellationToken);

            if (user is User && ValidatePassword(oldPassword, user.SecurityStamp, user.PasswordHash))
            {
                user.SecurityStamp = CreateSecurityStamp();
                user.PasswordHash = CreatePasswordHash(newPassword, user.SecurityStamp);
                await _userRepository.SaveChangesAsync(cancellationToken);

                return true;
            }

            return false;
        }

        private static bool ValidatePassword(string password, string securityStamp, string passwordHash)
        {
            var hash = CreatePasswordHash(password, securityStamp);

            return passwordHash == hash;
        }

        private static string CreatePasswordHash(string password, string securityStamp)
        {
            using (var algorithm = SHA256.Create())
            {
                var hashBytes = algorithm.ComputeHash(
                        Encoding.UTF8.GetBytes(password + securityStamp));

                return BitConverter.ToString(hashBytes);
            }
        }

        private static string CreateSecurityStamp()
        {
            using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var securityStampBytes = new byte[32];
                cryptoServiceProvider.GetBytes(securityStampBytes);

                return BitConverter.ToString(securityStampBytes);
            }
        }
    }
}
