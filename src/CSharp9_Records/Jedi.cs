using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9_Records
{
    // Records can be inherited
    public record Jedi : ForceWielder
    {
        public int MidiChlorians => this.GetHashCode();
    }
}
