namespace EducationPlans.Model.DataBase
{
    public static class UserSession 
    {
        public static bool IsLoggedIn { get; set; }
        public static string CurrentUserLogin { get; set; }
        public static string typeUser { get; set; }
    }
}
