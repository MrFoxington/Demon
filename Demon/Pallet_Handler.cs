using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    class Pallet_Handler
    {
        private Pallet[] pallets = null;
        const int PALLET_MAX = 3;

        public Pallet_Handler()
        {

            pallets = new Pallet[PALLET_MAX];

            //Black and White
            pallets[0] = new Pallet(
                Color.White, 
                Color.Black, 
                Color.White, 
                Color.Black,
                Color.White, 
                Color.Black,
                Color.White, 
                Color.Black 
                );

            //Green Shades
            pallets[1] = new Pallet(
                Color.Orange,
                Color.Maroon,
                Color.Purple,
                Color.Green,
                Color.Yellow,
                Color.Blue,
                Color.Red,
                Color.Pink
                );

            //Double Rainbow.
            pallets[2] = new Pallet(
                Color.Cyan,
                Color.Cyan,
                Color.DarkCyan,
                Color.DarkCyan,
                Color.Crimson,
                Color.Crimson,
                Color.Red,
                Color.Red
                );


        }

        public Pallet this[int val]
        {
            get
            {
                return pallets[val];
            }
        }

    }
}
