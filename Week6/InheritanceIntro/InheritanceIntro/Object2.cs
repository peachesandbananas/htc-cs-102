using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class Object2
    {
        private object value;

        public Object2(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }
}
