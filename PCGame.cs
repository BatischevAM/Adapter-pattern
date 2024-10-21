using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public interface PCGame
    {
        string Title();
        int PegiAllowedAge();
        bool isTripleAGame();
        Requirements Requirements();
    }
}
