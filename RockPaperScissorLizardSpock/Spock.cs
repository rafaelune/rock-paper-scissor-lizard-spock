using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Spock: JokenpoItem
    {
        private static Spock spock;

        protected Spock(){}

        public static Spock GetInstance()
        {
            if (spock == null)
            {
                spock = new Spock();
                spock.Name = "Spock";
                spock.LosesTo = new List<IJokenpoItem> {
                    Lizard.GetInstance(),
                    Paper.GetInstance()
                };
            }
            
            return spock;
        }
        
    }
}
