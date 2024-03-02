using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp02AppDesktop
{
    class MediaAritimetica
    {
        public string p1 { get; set; }

        public string p2 { get; set; }

        public string p3 { get; set; }

        public string p4 { get; set; }

        public float getMedia()
        {

            return (float.Parse(p1) + float.Parse(p2) + float.Parse(p3) + float.Parse(p4)) / 4;

        }



    }
}



