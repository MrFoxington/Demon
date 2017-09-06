using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    class Automata_Engine
    {
        Cell_Handler handler;
        Graphics_Handler graphics;
        private int current_Gen;
        private int height, width;

        public Automata_Engine(Graphics_Handler gh, int seed, int width, int height)
        {
            this.width = width;
            this.height = height;
            graphics = gh;
            Reset(seed);
        }

        public void Run(int generations, Rules rule)
        {
            // Calculate and Print next generations with applied rule set.
            for (int i = 0; i < generations; i++)
            {
                run_Rule(rule);
                current_Gen++;
                Print_Generation();
            }

            graphics.Hash = handler.Hash();
        }

        private void run_Rule(Rules rule)
        {
            //Handle multiple 
            if (rule == Rules.Rule_Orthagonal || rule == Rules.Rule_Diagonal)
                handler.Next_Generation(rule);
            else
            {
                handler.Next_Generation(Rules.Rule_Orthagonal);
                handler.Next_Generation(Rules.Rule_Diagonal);
            }
        }

        // Print the current generation.
        private void Print_Generation()
        {
            graphics.draw(handler._Cells);
            graphics.Gen = current_Gen;
        }

        public void Reset(int seed)
        {
            handler = new Cell_Handler(width, height, seed);
            current_Gen = 0;

            Print_Generation();
            graphics.Hash = handler.Hash();
        }

        public void pallet_Change(int color)
        {
            graphics.change_Pallet(color);
            Print_Generation();
        }

        public void update()
        {
            graphics.update();
        }

    }
}
