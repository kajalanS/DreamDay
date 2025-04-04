using DreamDay.Database.Core.Enum;
using DreamDay.Models;

namespace DreamDay.Models.View
{
    public class HomePageModel
    {
        public bool Authenticated { get; set; }
        public UserType? UserRole { get; set; }
        public string? RequestId { get; set; }
        public string? ErrorMessage { get; set; }
        public User? CurrentUser { get; set; }
    }
}
