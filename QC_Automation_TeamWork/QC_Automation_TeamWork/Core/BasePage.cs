namespace QC_Automation_TeamWork.Core
{
    public class BasePage<TM> where TM : BasePageElementMap, new()
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }
}

