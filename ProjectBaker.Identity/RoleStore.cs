﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBaker.Identity
{
	public class RoleStore : Microsoft.AspNetCore.Identity.IRoleStore<AppRole>
	{
		private DAL.UnitOfWork _uof;
		public Task<IdentityResult> CreateAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<IdentityResult> DeleteAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public Task<AppRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<AppRole> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<string> GetNormalizedRoleNameAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<string> GetRoleIdAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<string> GetRoleNameAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task SetNormalizedRoleNameAsync(AppRole role, string normalizedName, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task SetRoleNameAsync(AppRole role, string roleName, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public Task<IdentityResult> UpdateAsync(AppRole role, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}