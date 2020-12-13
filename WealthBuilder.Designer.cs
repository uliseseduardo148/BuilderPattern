namespace BuilderPattern
{
    partial class WealthBuilder
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
            this.pnl = new System.Windows.Forms.Panel();
            this.lsEquities = new System.Windows.Forms.ListBox();
            this.btPlot = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lsEquities);
            this.pnl.Location = new System.Drawing.Point(40, 45);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 293);
            this.pnl.TabIndex = 0;
            // 
            // lsEquities
            // 
            this.lsEquities.FormattingEnabled = true;
            this.lsEquities.Location = new System.Drawing.Point(0, 3);
            this.lsEquities.Name = "lsEquities";
            this.lsEquities.Size = new System.Drawing.Size(200, 290);
            this.lsEquities.TabIndex = 0;
            this.lsEquities.SelectedIndexChanged += new System.EventHandler(this.LsEquities_SelectedIndexChanged);
            // 
            // btPlot
            // 
            this.btPlot.Location = new System.Drawing.Point(275, 392);
            this.btPlot.Name = "btPlot";
            this.btPlot.Size = new System.Drawing.Size(75, 23);
            this.btPlot.TabIndex = 1;
            this.btPlot.Text = "Plot";
            this.btPlot.UseVisualStyleBackColor = true;
            this.btPlot.Click += new System.EventHandler(this.BtPlot_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Location = new System.Drawing.Point(355, 48);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(262, 290);
            this.pnlDatos.TabIndex = 2;
            // 
            // WealthBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btPlot);
            this.Controls.Add(this.pnl);
            this.Name = "WealthBuilder";
            this.Text = "WealthBuilder";
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btPlot;
        private System.Windows.Forms.ListBox lsEquities;
        private System.Windows.Forms.Panel pnlDatos;
    }
}