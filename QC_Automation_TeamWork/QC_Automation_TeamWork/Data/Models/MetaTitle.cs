using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_Automation_TeamWork.Data.Models
{
    public class MetaTitle
    {
        public MetaTitle(string metatitlename)
        {
            Metatitlename = metatitlename;
        }

        public string Metatitlename { get; set; }
    }
}

