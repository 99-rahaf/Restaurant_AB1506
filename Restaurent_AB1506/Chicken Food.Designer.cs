
namespace Restaurant_AB1506
{
    partial class frmChickenFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChickenFood));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnShowTheOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.lblOrder = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShowTheOrder,
            this.tsbtnClear,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnShowTheOrder
            // 
            this.tsbtnShowTheOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowTheOrder.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtnShowTheOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowTheOrder.Image")));
            this.tsbtnShowTheOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowTheOrder.Name = "tsbtnShowTheOrder";
            this.tsbtnShowTheOrder.Size = new System.Drawing.Size(116, 22);
            this.tsbtnShowTheOrder.Text = "Show The Order";
            this.tsbtnShowTheOrder.Click += new System.EventHandler(this.tsbtnShowTheOrder_Click);
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnClear.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClear.Image")));
            this.tsbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(45, 22);
            this.tsbtnClear.Text = "Clear";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnExit.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(35, 22);
            this.tsbtnExit.Text = "Exit";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(15, 55);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(53, 18);
            this.lblOrder.TabIndex = 14;
            this.lblOrder.Text = "Order";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(210, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 26);
            this.comboBox1.TabIndex = 13;
            // 
            // lbOrder
            // 
            this.lbOrder.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 18;
            this.lbOrder.Items.AddRange(new object[] {
            "Chicken on coal",
            "Roasted chicken",
            "smoked chicken"});
            this.lbOrder.Location = new System.Drawing.Point(15, 75);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(130, 94);
            this.lbOrder.TabIndex = 18;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAnswer.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAnswer.Location = new System.Drawing.Point(194, 125);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 18);
            this.lblAnswer.TabIndex = 17;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.Location = new System.Drawing.Point(210, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 18);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // frmChickenFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuantity);
            this.Name = "frmChickenFood";
            this.Text = "Chicken Food";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnShowTheOrder;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuantity;
    }
}