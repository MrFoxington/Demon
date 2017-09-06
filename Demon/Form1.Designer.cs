namespace Demon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Seed = new System.Windows.Forms.TextBox();
            this.txt_Gens = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Rules = new System.Windows.Forms.ComboBox();
            this.cmb_Colors = new System.Windows.Forms.ComboBox();
            this.lbl_Gen_Count = new System.Windows.Forms.Label();
            this.lbl_Hash_Value = new System.Windows.Forms.Label();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.pnl_Controls.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(365, 3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(76, 23);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(365, 38);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(76, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gens";
            // 
            // txt_Seed
            // 
            this.txt_Seed.Location = new System.Drawing.Point(49, 13);
            this.txt_Seed.Name = "txt_Seed";
            this.txt_Seed.Size = new System.Drawing.Size(81, 20);
            this.txt_Seed.TabIndex = 4;
            this.txt_Seed.Text = "0";
            this.txt_Seed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Gens
            // 
            this.txt_Gens.Location = new System.Drawing.Point(49, 40);
            this.txt_Gens.Name = "txt_Gens";
            this.txt_Gens.Size = new System.Drawing.Size(81, 20);
            this.txt_Gens.TabIndex = 5;
            this.txt_Gens.Text = "100";
            this.txt_Gens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rules";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Colors";
            // 
            // cmb_Rules
            // 
            this.cmb_Rules.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Rules.FormattingEnabled = true;
            this.cmb_Rules.Location = new System.Drawing.Point(199, 10);
            this.cmb_Rules.Name = "cmb_Rules";
            this.cmb_Rules.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Rules.Size = new System.Drawing.Size(111, 21);
            this.cmb_Rules.TabIndex = 8;
            // 
            // cmb_Colors
            // 
            this.cmb_Colors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_Colors.FormattingEnabled = true;
            this.cmb_Colors.Location = new System.Drawing.Point(199, 40);
            this.cmb_Colors.Name = "cmb_Colors";
            this.cmb_Colors.Size = new System.Drawing.Size(111, 21);
            this.cmb_Colors.TabIndex = 9;
            this.cmb_Colors.SelectedIndexChanged += new System.EventHandler(this.cmb_Colors_SelectedIndexChanged);
            // 
            // lbl_Gen_Count
            // 
            this.lbl_Gen_Count.AutoSize = true;
            this.lbl_Gen_Count.Location = new System.Drawing.Point(4, 8);
            this.lbl_Gen_Count.Name = "lbl_Gen_Count";
            this.lbl_Gen_Count.Size = new System.Drawing.Size(13, 13);
            this.lbl_Gen_Count.TabIndex = 10;
            this.lbl_Gen_Count.Text = "0";
            // 
            // lbl_Hash_Value
            // 
            this.lbl_Hash_Value.AutoSize = true;
            this.lbl_Hash_Value.Location = new System.Drawing.Point(44, 8);
            this.lbl_Hash_Value.Name = "lbl_Hash_Value";
            this.lbl_Hash_Value.Size = new System.Drawing.Size(25, 13);
            this.lbl_Hash_Value.TabIndex = 11;
            this.lbl_Hash_Value.Text = "000";
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.cmb_Colors);
            this.pnl_Controls.Controls.Add(this.btn_Reset);
            this.pnl_Controls.Controls.Add(this.btn_Start);
            this.pnl_Controls.Controls.Add(this.label1);
            this.pnl_Controls.Controls.Add(this.cmb_Rules);
            this.pnl_Controls.Controls.Add(this.label2);
            this.pnl_Controls.Controls.Add(this.label4);
            this.pnl_Controls.Controls.Add(this.txt_Seed);
            this.pnl_Controls.Controls.Add(this.label3);
            this.pnl_Controls.Controls.Add(this.txt_Gens);
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(640, 70);
            this.pnl_Controls.TabIndex = 12;
            // 
            // pnl_Display
            // 
            this.pnl_Display.Location = new System.Drawing.Point(0, 76);
            this.pnl_Display.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(640, 480);
            this.pnl_Display.TabIndex = 13;
            this.pnl_Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Cells_Paint);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Controls.Add(this.lbl_Hash_Value);
            this.pnl_Footer.Controls.Add(this.lbl_Gen_Count);
            this.pnl_Footer.Location = new System.Drawing.Point(0, 562);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(640, 25);
            this.pnl_Footer.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 589);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Display);
            this.Controls.Add(this.pnl_Controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Demon - aka \"Trippy Demon\"";
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Seed;
        private System.Windows.Forms.TextBox txt_Gens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Rules;
        private System.Windows.Forms.ComboBox cmb_Colors;
        private System.Windows.Forms.Label lbl_Gen_Count;
        private System.Windows.Forms.Label lbl_Hash_Value;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.Panel pnl_Footer;
    }
}

