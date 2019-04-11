using QC_Automation_TeamWork.Core;


namespace QC_Automation_TeamWork.Pages
{
    public class RequestNewPasswordPage : BasePage<RequestNewPasswordPageElementMap, RequestNewPasswordPageValidator>
    {
        public void RequestNewPassword(string emailelement)
        {
            var requestNewPassword = Map.EmailElement;
            requestNewPassword.Clear();
            requestNewPassword.SendKeys(emailelement);

            Map.SubmitElement.Click();
        }
    }
}
