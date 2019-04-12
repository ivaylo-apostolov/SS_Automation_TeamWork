using Microsoft.VisualStudio.TestTools.UnitTesting;
using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class OpenCartLoginPageValidator : BasePageValidator<OpenCartLoginPageElementMap>
    {
        public void LoginForm()
        {
            //Assert.IsTrue(Map.UsernameElement.Displayed, "Username input is not displayed!");
            //Assert.IsTrue(Map.PasswordElement.Displayed, "Password input is not displayed!");
            //Assert.IsTrue(Map.LoginButton.Displayed, "Login button is not displayed!");
        }

        public void ResetPasswordMessage()
        {
            Assert.IsTrue(Map.ResetPasswordMessage.Text.Contains("Success: An email with a reset link has been sent your email address!"));
        }
    }
}