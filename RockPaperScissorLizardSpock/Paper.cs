using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Paper : JokenpoItem
    {
        private static Paper paper;

        protected Paper() { }

        public static Paper GetInstance()
        {
            if (paper == null)
            {
                paper = new Paper();
                paper.Name = "Paper";
                paper.LosesTo = new List<IJokenpoItem>()
                {
                    Scissor.GetInstance(),
                    Lizard.GetInstance()
                };
            }
            return paper;
        }
    }
}
