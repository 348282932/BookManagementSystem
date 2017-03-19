using System;
using Abp.Authorization.Users;
using Abp.Extensions;
using Microsoft.AspNet.Identity;
using System.ComponentModel;

namespace BookManagementSystem.Users
{
    public class User : AbpUser<User>
    {
        [DefaultValue(false)]
        public bool IsVip { get; set; }

        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string password)
        {
            return new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = new PasswordHasher().HashPassword(password)
            };
        }
    }
}