namespace QC_Automation_TeamWork.Data.Models
{
    public class LoginWithEmail
    {
        public LoginWithEmail(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
