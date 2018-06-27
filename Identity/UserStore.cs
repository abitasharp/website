using Abitasharp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abitasharp.Identity
{
    public class UserStore : IUserStore<Utente>, IUserPasswordStore<Utente>, IUserEmailStore<Utente>
    {
        private readonly ApplicationContext _context;

        public UserStore(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IdentityResult> CreateAsync(Utente user, CancellationToken cancellationToken)
        {
            _context.Add(user);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        public async Task<IdentityResult> DeleteAsync(Utente user, CancellationToken cancellationToken)
        {
            _context.Remove(user);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(result == 1 ? IdentityResult.Success : IdentityResult.Failed());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
        }

        public async Task<Utente> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            if (int.TryParse(userId, out int id))
            {
                return await _context.Utenti.FindAsync(id);
            }
            else
            {
                return await Task.FromResult((Utente)null);
            }
        }

        public Utente FindByName(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(Utente user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetUserIdAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task<bool> HasPasswordAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrWhiteSpace(user.PasswordHash));
        }

        public Task SetNormalizedUserNameAsync(Utente user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(Utente user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;

            return Task.FromResult((object)null);
        }

        public Task SetUserNameAsync(Utente user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> UpdateAsync(Utente user, CancellationToken cancellationToken)
        {
            _context.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<Utente> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return null;
        }

        async Task<IdentityResult> SetEmailAsync(Utente user, string email, CancellationToken cancellationToken)
        {
            user.Email = email;
            _context.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<string> GetEmailAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.EmailConfirmed);
        }

        public async Task<IdentityResult> SetEmailConfirmedAsync(Utente user, bool confirmed, CancellationToken cancellationToken)
        {
            user.EmailConfirmed = confirmed;
            _context.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<Utente> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            Utente utente =  _context.Utenti.Where(u => u.Email == normalizedEmail).First<Utente>();
            return Task.FromResult(utente);
        }

        public Task<string> GetNormalizedEmailAsync(Utente user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.NormalizedEmail);
        }

        public async Task<IdentityResult> SetNormalizedEmailAsync(Utente user, string normalizedEmail, CancellationToken cancellationToken)
        {
            user.NormalizedEmail = normalizedEmail;
            _context.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        Task IUserEmailStore<Utente>.SetEmailAsync(Utente user, string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task IUserEmailStore<Utente>.SetEmailConfirmedAsync(Utente user, bool confirmed, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task IUserEmailStore<Utente>.SetNormalizedEmailAsync(Utente user, string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
