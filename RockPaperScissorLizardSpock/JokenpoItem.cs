using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public abstract class JokenpoItem : IJokenpoItem
    {
        private string ItemName;
        public int CompareTo(IJokenpoItem item)
        {
            if (LosesTo.Contains(item))
            {
                return -1;
            }

            return 1;
        }

        protected List<IJokenpoItem> LosesTo { get; set; }


        public string Name
        {
            get { return ItemName; }
            set { ItemName = value; }
        }
    }
}
