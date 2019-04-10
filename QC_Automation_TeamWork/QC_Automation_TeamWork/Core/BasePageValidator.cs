using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Core
{
    public class BasePageValidator<TM> where TM : BasePageElementMap, new()
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