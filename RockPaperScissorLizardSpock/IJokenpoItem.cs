using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public interface IJokenpoItem
    {
        int CompareTo(IJokenpoItem item);
        string Name { get; set; }
    }
}
