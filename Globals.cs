namespace ValidateUser
{
    public static class Globals
    {
        public static bool ValidatedUser { get; set; } = false;
        public static string Username { get; set; } = "";
        public static string EmailAddress { get; set; } = "";

        public static void ResetValues()
        {
            ValidatedUser = false;
            Username = "";
            EmailAddress = "";
                    }
    }

}
