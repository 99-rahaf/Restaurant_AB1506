
namespace Restaurant_AB1506
{
    partial class frmRiceFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRiceFood));
            this.lblOrder = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnShowTheOrder = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.dmOrder = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrder.Location = new System.Drawing.Point(13, 48);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(53, 18);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnShowTheOrder,
            this.tsbtnClear,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(346, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnShowTheOrder
            // 
            this.tsbtnShowTheOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnShowTheOrder.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.tsbtnClear.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.tsbtnExit.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(35, 22);
            this.tsbtnExit.Text = "Exit";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(180, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 18);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAnswer.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAnswer.Location = new System.Drawing.Point(171, 116);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 18);
            this.lblAnswer.TabIndex = 5;
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(16, 81);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 8;
            // 
            // dmOrder
            // 
            this.dmOrder.Location = new System.Drawing.Point(192, 82);
            this.dmOrder.Name = "dmOrder";
            this.dmOrder.Size = new System.Drawing.Size(46, 20);
            this.dmOrder.TabIndex = 9;
            // 
            // frmRiceFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(346, 270);
            this.Controls.Add(this.dmOrder);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblOrder);
            this.Name = "frmRiceFood";
            this.Text = "Rice Food";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnShowTheOrder;
        private System.Windows.Forms.ToolStripButton tsbtnClear;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.NumericUpDown dmOrder;
    }
}