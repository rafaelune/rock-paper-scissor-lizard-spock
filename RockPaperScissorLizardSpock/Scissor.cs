using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Scissor : JokenpoItem
    {
        private static Scissor scissor;

        protected Scissor() { }

        public static Scissor GetInstance()
        {
            if (scissor == null)
            {
                scissor = new Scissor();
                scissor.Name = "Scissor";
                scissor.LosesTo = new List<IJokenpoItem>()
                {
                    Rock.GetInstance(),
                    Spock.GetInstance()
                };
            }
            return scissor;
        }
    }
}
