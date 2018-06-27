using Abitasharp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Abitasharp.Identity
{
    public class RoleStore : IRoleStore<Ruolo>
    {
        private readonly ApplicationContext _context;

        public RoleStore(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IdentityResult> CreateAsync(Ruolo role, CancellationToken cancellationToken)
        {
            _context.Add(role);
            await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(IdentityResult.Success);
        }

        public async Task<IdentityResult> DeleteAsync(Ruolo role, CancellationToken cancellationToken)
        {
            _context.Remove(role);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return await Task.FromResult(result == 1 ? IdentityResult.Success : IdentityResult.Failed());
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Task<Ruolo> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Ruolo> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedRoleNameAsync(Ruolo role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(Ruolo role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleNameAsync(Ruolo role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync(Ruolo role, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetRoleNameAsync(Ruolo role, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(Ruolo role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
