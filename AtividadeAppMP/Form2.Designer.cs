namespace AtividadeAppMP
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiprograma = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilivro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiestadio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmifunc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprograma,
            this.tsmiexit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprograma
            // 
            this.tsmiprograma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmilivro,
            this.tsmiestadio,
            this.tsmifunc});
            this.tsmiprograma.Name = "tsmiprograma";
            this.tsmiprograma.Size = new System.Drawing.Size(94, 24);
            this.tsmiprograma.Text = "Programas";
            // 
            // tsmilivro
            // 
            this.tsmilivro.Name = "tsmilivro";
            this.tsmilivro.Size = new System.Drawing.Size(224, 26);
            this.tsmilivro.Text = "Livraria";
            this.tsmilivro.Click += new System.EventHandler(this.tsmilivro_Click);
            // 
            // tsmiestadio
            // 
            this.tsmiestadio.Name = "tsmiestadio";
            this.tsmiestadio.Size = new System.Drawing.Size(224, 26);
            this.tsmiestadio.Text = "Estádio";
            this.tsmiestadio.Click += new System.EventHandler(this.tsmiestadio_Click);
            // 
            // tsmifunc
            // 
            this.tsmifunc.Name = "tsmifunc";
            this.tsmifunc.Size = new System.Drawing.Size(224, 26);
            this.tsmifunc.Text = "Funcionários";
            this.tsmifunc.Click += new System.EventHandler(this.tsmifunc_Click);
            // 
            // tsmiexit
            // 
            this.tsmiexit.Name = "tsmiexit";
            this.tsmiexit.Size = new System.Drawing.Size(48, 24);
            this.tsmiexit.Text = "Sair";
            this.tsmiexit.Click += new System.EventHandler(this.tsmiexit_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 624);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprograma;
        private System.Windows.Forms.ToolStripMenuItem tsmilivro;
        private System.Windows.Forms.ToolStripMenuItem tsmiestadio;
        private System.Windows.Forms.ToolStripMenuItem tsmifunc;
        private System.Windows.Forms.ToolStripMenuItem tsmiexit;
    }
}