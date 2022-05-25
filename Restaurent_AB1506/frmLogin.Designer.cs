
namespace Restaurant_AB1506
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsandwiches = new System.Windows.Forms.Button();
            this.btnchickenfood = new System.Windows.Forms.Button();
            this.btnMeatfood = new System.Windows.Forms.Button();
            this.btnricefood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDataBase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(172, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(62, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDataBase);
            this.panel2.Controls.Add(this.btnsandwiches);
            this.panel2.Controls.Add(this.btnchickenfood);
            this.panel2.Controls.Add(this.btnMeatfood);
            this.panel2.Controls.Add(this.btnricefood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 264);
            this.panel2.TabIndex = 1;
            // 
            // btnsandwiches
            // 
            this.btnsandwiches.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.btnsandwiches.Location = new System.Drawing.Point(9, 159);
            this.btnsandwiches.Name = "btnsandwiches";
            this.btnsandwiches.Size = new System.Drawing.Size(107, 26);
            this.btnsandwiches.TabIndex = 3;
            this.btnsandwiches.Text = "Sandwiches";
            this.btnsandwiches.UseVisualStyleBackColor = true;
            this.btnsandwiches.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // btnchickenfood
            // 
            this.btnchickenfood.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.btnchickenfood.Location = new System.Drawing.Point(9, 116);
            this.btnchickenfood.Name = "btnchickenfood";
            this.btnchickenfood.Size = new System.Drawing.Size(107, 26);
            this.btnchickenfood.TabIndex = 2;
            this.btnchickenfood.Text = "Chicken Food";
            this.btnchickenfood.UseVisualStyleBackColor = true;
            this.btnchickenfood.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // btnMeatfood
            // 
            this.btnMeatfood.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.btnMeatfood.Location = new System.Drawing.Point(9, 74);
            this.btnMeatfood.Name = "btnMeatfood";
            this.btnMeatfood.Size = new System.Drawing.Size(107, 26);
            this.btnMeatfood.TabIndex = 1;
            this.btnMeatfood.Text = "Meat Food";
            this.btnMeatfood.UseVisualStyleBackColor = true;
            this.btnMeatfood.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnricefood
            // 
            this.btnricefood.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.btnricefood.Location = new System.Drawing.Point(9, 29);
            this.btnricefood.Name = "btnricefood";
            this.btnricefood.Size = new System.Drawing.Size(107, 26);
            this.btnricefood.TabIndex = 0;
            this.btnricefood.Text = "Rice Food";
            this.btnricefood.UseVisualStyleBackColor = true;
            this.btnricefood.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Violet;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(123, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 264);
            this.panel3.TabIndex = 2;
            // 
            // btnDataBase
            // 
            this.btnDataBase.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.btnDataBase.Location = new System.Drawing.Point(9, 203);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(107, 26);
            this.btnDataBase.TabIndex = 4;
            this.btnDataBase.Text = "DataBase";
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 338);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsandwiches;
        private System.Windows.Forms.Button btnchickenfood;
        private System.Windows.Forms.Button btnMeatfood;
        private System.Windows.Forms.Button btnricefood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDataBase;
    }
}