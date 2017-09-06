using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    class Cells_Array
    {
            private CellState[,] cells;
             

            public Cells_Array(int width, int height)
            {
                cells = new CellState[width,height];
            }

            public int NumCols
            {
                get { return cells.GetLength(0); }
            }
            public int NumRows
            {
                get { return cells.GetLength(1); }
            }

        public CellState this[int col, int row]
            {
                get
                {
                    // Determin if col value is required to wrap around
                    if (col >= cells.GetLength(0) )
                        col = 0;
                    else if (col < 0)
                        col = cells.GetLength(0) - 1;

                    // Determin if row value is required to wrap around
                    if (row >= cells.GetLength(1) )
                        row = 0;
                    else if (row < 0)
                        row = cells.GetLength(1) - 1;


                    return cells[col,row];
                }
                set
                {
                    // Verify value a valid variable type.
                    if (value.GetType() == typeof(CellState))
                        cells[col,row] = value;
                }
            }
        }

    }

