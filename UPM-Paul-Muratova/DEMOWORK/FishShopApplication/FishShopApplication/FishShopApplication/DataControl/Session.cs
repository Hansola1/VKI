using FishShopApplication.Models;

namespace FishShopApplication.DataControl
{
    public static class Session
    {
        public static User? CurrentUser { get; set; }
        public static bool Visit { get; set; }
    }
}
