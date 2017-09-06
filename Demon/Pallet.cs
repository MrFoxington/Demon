using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{

    class Pallet
    {
        Brush[] colors = null;

        public Pallet(params Color[] color_Values)
        {
            int size = color_Values.Length;
            colors = new Brush[size];

            for(int i = 0; i < size; i++)
            {
                Color tmp_col = color_Values[i];
                colors[i] = new SolidBrush(tmp_col);
            }
        }

        public Brush this[int val]
        {
            get
            {
                return colors[val];
            }
        }
    }
}
