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

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
    }
}

