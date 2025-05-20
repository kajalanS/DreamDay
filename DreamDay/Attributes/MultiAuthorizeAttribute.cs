using DreamDay.Database.Core.Enum;
using Microsoft.AspNetCore.Authorization;

namespace DreamDay.Attributes
{
    public class MultiAuthorizeAttribute : AuthorizeAttribute
    {
        public MultiAuthorizeAttribute(UserType[] userType)
        {
            Roles = userType.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y);
        }
    }
}
