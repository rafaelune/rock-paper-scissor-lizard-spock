using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class GameMatch
    {

        public string Decide(IJokenpoItem item1, IJokenpoItem item2)
        {
            if (item1.Equals(item2))
            {
                return "Draw";
            }

            int result = item1.CompareTo(item2);
            if (result < 0)
            {
                return item2.Name;
            }

            return item1.Name;
        }
    }
}
