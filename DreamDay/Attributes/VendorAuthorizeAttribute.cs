using DreamDay.Database.Core.Enum;
using Microsoft.AspNetCore.Authorization;

namespace DreamDay.Attributes
{
    public class VendorAuthorizeAttribute : AuthorizeAttribute
    {
        public VendorAuthorizeAttribute()
        {
            Roles = UserType.Vendor.ToString();
        }
    }
}
