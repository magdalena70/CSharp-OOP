namespace _04_StaticClass
{
    using System;
    public static class EmailValidator
    {
        public static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
