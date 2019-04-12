using QC_Automation_TeamWork.Core;

namespace QC_Automation_TeamWork.Pages
{
    public class StoreCamerasPage : BasePage<StoreCamerasPageElementMap, StoreCamerasPageValidator>
    {
        internal string LocateCamerasPageHeader()
        {
            return Map.CamerasHeader.Text;
        }
    }
}
