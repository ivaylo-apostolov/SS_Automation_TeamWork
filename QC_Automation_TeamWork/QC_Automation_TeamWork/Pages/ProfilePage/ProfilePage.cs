using QC_Automation_TeamWork.Core;
using QC_Automation_TeamWork.Data.Models;

namespace QC_Automation_TeamWork.Pages
{
    public class ProfilePage : BasePage<ProfilePageElementMap, ProfilePageValidator>
    {
        public ProfilePage() : base(new Header())
        {

        }
        internal void InsertFirstName(string username)
        {
            var firstNameField = Map.FirstNameField;
            firstNameField.Clear();
            firstNameField.SendKeys(username);
        }
        internal void InsertLastName(string password)
        {
            var lastNameField = Map.LastNameField;
            lastNameField.Clear();
            lastNameField.SendKeys(password);
        }
        internal void ClickSaveButton()
        {
            var button = Map.ProfileSaveButton;
            button.Click();
        }

        public ProfilePage ChangeName(User user)
        {
            InsertFirstName(user.Username);
            InsertLastName(user.Password);
            ClickSaveButton();

            return new ProfilePage();
        }
    }
}