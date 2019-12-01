using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLW9
{
    class Img
    {
        protected int Elements = 0;
        public Img()
        {
            List<ColCon> shapes = new List<ColCon>();
        }
        public Img(int lendth)
        {
            List<ColCon> shapes = new List<ColCon>(lendth);
        }

    }
}
