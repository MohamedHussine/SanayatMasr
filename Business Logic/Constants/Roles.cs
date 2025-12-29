namespace BusinessLogic.Constants
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";
        public const string Craftsman = "Craftsman";

        // Roles المسموح التسجيل بيها فقط
        public static readonly string[] AllowedRegisterRoles =
        {
            Customer,
            Craftsman
        };
    }
}
