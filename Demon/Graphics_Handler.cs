using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    class Graphics_Handler
    {

        private Bitmap buffer = null;
        private Graphics panelGraphics = null;
        private Graphics bufferGraphics = null;
        private Label lbl_gen = null;
        private Label lbl_hash = null;

        private Pallet_Handler pallet_List = null;
        private Pallet current_Pallet = null;
        private int height;
        private int width;

        public Graphics_Handler(Graphics panel_graphics, int width, int height)
        {
            this.height = height;
            this.width = width;

            buffer = new Bitmap(width, height);

            panelGraphics = panel_graphics;
            bufferGraphics = Graphics.FromImage(buffer);

            pallet_List = new Pallet_Handler();
            current_Pallet = pallet_List[0];
        }

        public void change_Pallet(int pallet_Val)
        {
            current_Pallet = pallet_List[pallet_Val];
        }

        public int Height
        {
            get { return height; }
        }

        public int Width
        {
            get { return width; }
        }

        public void Set_Gen_Count_Lable(Label label)
        {
            lbl_gen = label;
        }

        public void Set_Hash_Lable(Label label)
        {
            lbl_hash = label;
        }

        public uint Hash
        {
            set { lbl_hash.Text = value.ToString(); }
        }

        public int Gen
        {
            set
            {
                lbl_gen.Text = value.ToString();
                lbl_gen.Update();
            }
        }

        public void draw(Cells_Array _cells)
        {
            Rectangle r;

            int SCALE = 2;

            for (int row = 0; row < height / 2; row++)
            {
                for (int col = 0; col < width / 2; col++)
                {
                    r = new Rectangle(col * SCALE, row * SCALE, SCALE, SCALE);
                    CellState cell = _cells[col, row];
                    Brush b = current_Pallet[(int)cell];

                    bufferGraphics.FillRectangle(b, r);
                }
            }

            update();
        }

        public void update()
        {
            panelGraphics.DrawImageUnscaled(buffer, 0, 0);
        }

    }

}