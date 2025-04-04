using DreamDay.Database.Core.Enum;
using Microsoft.AspNetCore.Authorization;

namespace DreamDay.Attributes
{
    public class CoupleAuthorizeAttribute : AuthorizeAttribute
    {
        public CoupleAuthorizeAttribute()
        {
            Roles = UserType.Couple.ToString().ToUpper();
        }
    }
}
