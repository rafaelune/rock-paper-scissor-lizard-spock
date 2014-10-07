using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Lizard : JokenpoItem
    {
        private static Lizard lizard;

        protected Lizard() { }

        public static Lizard GetInstance()
        {
            if (lizard == null)
            {
                lizard = new Lizard();
                lizard.Name = "Lizard";
                lizard.LosesTo = new List<IJokenpoItem>()
                {
                    Rock.GetInstance(), Scissor.GetInstance()
                };
            }
            return lizard;
        }
    }
}
