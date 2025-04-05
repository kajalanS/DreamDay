using DreamDay.Database.Core.Enum;

namespace DreamDay.Attributes
{
  public class FullUserAuthorizeAttribute : MultiAuthorizeAttribute
  {
    public FullUserAuthorizeAttribute() : base([UserType.Admin, UserType.Couple, UserType.Vendor])
    {
    }
  }
}
