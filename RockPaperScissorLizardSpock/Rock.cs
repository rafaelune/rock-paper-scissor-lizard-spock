using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Rock : JokenpoItem
    {
        private static Rock rock;

        protected Rock() { }

        public static Rock GetInstance()
        {
            if (rock == null)
            {
                rock = new Rock();
                rock.Name = "Rock";
                rock.LosesTo = new List<IJokenpoItem>()
                {
                    Paper.GetInstance(),
                    Spock.GetInstance()
                };
            }
            return rock;
        }
    }
}
