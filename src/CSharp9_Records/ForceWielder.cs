using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9_Records
{
    public record ForceWielder
    {
        // Init accessors can only be called during initialization 
        // and allow with-expression
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
