using DreamDay.Database.Core.Enum;

namespace DreamDay.Models.View
{
    public class BaseViewModel
    {
        public bool Authenticated { get; set; }
        public UserType? UserRole { get; set; }
        public User? CurrentUser { get; set; }
        public string? RequestId { get; set; }
        public string? ErrorMessage { get; set; }
        public string? SuccessMessage { get; set; }
    }
}
