using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreateImplementor : Implementor
    {
        public override string Implementaion()
        {
            return "Run   ConcreateImplementor.Implementaion()....";
        }
    }
}
