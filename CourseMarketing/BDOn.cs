using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMarketing
{
    internal class BDOn
    {
        private static Entities2 contxt;
        public static Entities2 Contxt()
        {
            if (contxt == null)
                contxt = new Entities2();
            return contxt;
        }
    }
}
