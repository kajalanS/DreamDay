using DreamDay.Database.Core.Enum;
using Microsoft.AspNetCore.Authorization;

namespace DreamDay.Attributes
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        public AdminAuthorizeAttribute()
        {
            Roles = UserType.Admin.ToString();
        }
    }
}
