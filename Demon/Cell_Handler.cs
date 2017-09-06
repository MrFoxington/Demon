using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{

    enum CellState
    {
        State_0,
        State_1,
        State_2,
        State_3,
        State_4,
        State_5,
        State_6,
        State_7
    }

    enum Rules
    {
        Rule_Orthagonal,
        Rule_Diagonal,
        Rule_Alternating
    }

    class Cell_Handler

    {

        //private const int CELL_SIZE;
        private Cells_Array cells;

        public Cell_Handler(int width, int height, int seed)
        {
            cells = new Cells_Array(width, height);

            // Generate first generation based on Seed
            Random r = new Random(seed);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                    // Populate array with cell states
                    //TODO: Change restriction variable. (NumStates)
                    cells[col, row] = (CellState)r.Next(8);
            }
        }

        //Generate new Generation
        public void Next_Generation(Rules rule)
        {
            //Temporary storage for new generation
            Cells_Array next_Gen = new Cells_Array(cells.NumCols, cells.NumRows);

            //Calculate & Build new generation
            for (int row = 0; row < cells.NumRows; row++)
            {
                for (int col = 0; col < cells.NumCols; col++)
                {
                    next_Gen[col,row] = Calculate_Next_Cell(rule, row, col);
                }
            }
            // Apply new generation
            cells = next_Gen;
        }


        private CellState Calculate_Next_Cell(Rules rule, int row, int col)
        {
            //Determin which Rule to apply and calculate next state for cell location
            if (rule == Rules.Rule_Orthagonal)
                return Apply_Othagonal_Rule(col, row);
            else
                return Apply_Diagonal_Rule(col, row);
            

        }
        private CellState Apply_Othagonal_Rule(int col, int row)
        {
            
            CellState current = cells[col, row];
            CellState next = Get_Next_State(current);

            // Access orthagonaly adjcent cells for comparison
            CellState up = cells[col, row - 1];
            CellState down = cells[col, row + 1];
            CellState left = cells[col - 1, row];
            CellState right = cells[col + 1, row];

            if (up == next || down == next || left == next || right == next)
            {
                //Rule is applicable, return next state.
                return next;
            }
            else
            {
                //Rule not applicable.
                return current;
            }

        }

        private CellState Apply_Diagonal_Rule(int col, int row)
        {
            CellState current = cells[col, row];
            CellState next = Get_Next_State(current);


            // Access orthagonaly adjcent cells for comparison
            CellState up_left = cells[col - 1, row - 1];
            CellState up_right = cells[col + 1, row - 1];
            CellState down_left = cells[col - 1, row + 1];
            CellState down_right = cells[col + 1, row + 1];

            if (up_left == next || up_right == next || down_left == next || down_right == next)
            {
                //Rule is applicable, return next state.
                return next;
            }
            else
            {
                //Rule not applicable.
                return current;
            }

        }

        // Calculate the Hash value for the current array.
        public uint Hash()
        {
            int state, hash = 0;
            for (int col = 0; col < cells.NumCols; col++)
            {
                for (int row = 0; row < cells.NumRows; row++)
                {
                    state = (int)cells[col,row];
                    hash ^= ((row * col + 1) * (state + 1));
                }
            }
            return (uint)hash;
        }

        //Return Next state from given state
        private CellState Get_Next_State(CellState state)
        {
            //If Last state, return first state, (Loops around)
            if (state == CellState.State_7)
                return CellState.State_0;
            else
                return state + 1;
        }
        
        public Cells_Array _Cells
        {
            get { return cells; }
        }


        }
    }

