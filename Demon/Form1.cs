using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demon
{
    public partial class Form1 : Form
    {
        Automata_Engine automata = null;
        public Form1()
        {
            InitializeComponent();


            int pnl_width = pnl_Display.Width;
            int pnl_height = pnl_Display.Height;
            const int width = 320;
            const int height = 240;
            int seed = 0;

            
            Graphics_Handler gh = new Graphics_Handler(pnl_Display.CreateGraphics(), pnl_width, pnl_height);
            gh.Set_Hash_Lable(lbl_Hash_Value);
            gh.Set_Gen_Count_Lable(lbl_Gen_Count);

            automata = new Automata_Engine(gh, seed, width, height);

            cmb_Colors.Items.Add("Black and White");
            cmb_Colors.Items.Add("Orange Fiesta");
            cmb_Colors.Items.Add("Crimson Sea");
            cmb_Colors.SelectedIndex = 0;

            cmb_Rules.Items.Add("Orthagonal");
            cmb_Rules.Items.Add("Diagonal");
            cmb_Rules.Items.Add("Alternating");
            cmb_Rules.SelectedIndex = 0;


        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            int gen = get_Gen();

            if (gen != -1)
            {
                pnl_Controls.Enabled = false;

                Rules rule = (Rules)cmb_Rules.SelectedIndex;
                automata.Run(gen, rule);

                pnl_Controls.Enabled = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            int? seed = get_Seed();

            if (seed != null)
                automata.Reset((int)seed);

        }

        private void Panel_Cells_Paint(object sender, PaintEventArgs e)
        {
            automata.update();
        }

        private void cmb_Colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pallet_Val = cmb_Colors.SelectedIndex;
            automata.pallet_Change(pallet_Val);
        }

        private int? get_Seed()
        {
            string input = txt_Seed.Text;

            // Verify input is valid seed.
            int seed;
            bool success = Int32.TryParse(input, out seed);

            // Seed must be Positive Integer.
            if (success)
                // Seed is Valid.
                return seed;
            else
                // Invalid Seed
                System.Windows.Forms.MessageBox.Show("Reset failed with the following error\nInvalid seed value");

            return null;
        }

        private int get_Gen()
        {
            string input = txt_Gens.Text;

            int gen;
            bool success = Int32.TryParse(input, out gen);

            if (success && gen > 0)
            {
                return gen;
            }
            else
                // Invalid Gen Number
                System.Windows.Forms.MessageBox.Show("Unable to start Demonr with following error\nGenerations to run must be greater than 0");

            return -1;
        }
    }
}
