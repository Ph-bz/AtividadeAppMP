namespace AtividadeAppMP
{
    partial class frmimc
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
            this.lbltxt = new System.Windows.Forms.Label();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblimc = new System.Windows.Forms.Label();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.Location = new System.Drawing.Point(265, 50);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(258, 23);
            this.lbltxt.TabIndex = 0;
            this.lbltxt.Text = "Digite sua altura em metros:";
            // 
            // txtalt
            // 
            this.txtalt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalt.Location = new System.Drawing.Point(334, 94);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(100, 30);
            this.txtalt.TabIndex = 1;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(253, 144);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(297, 23);
            this.lblpeso.TabIndex = 2;
            this.lblpeso.Text = "Digite seu peso em quilogramas:";
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(334, 190);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 30);
            this.txtpeso.TabIndex = 3;
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.Location = new System.Drawing.Point(306, 247);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(161, 23);
            this.lblimc.TabIndex = 4;
            this.lblimc.Text = "Seu IMC diz que:";
            // 
            // txtimc
            // 
            this.txtimc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimc.Location = new System.Drawing.Point(192, 291);
            this.txtimc.Name = "txtimc";
            this.txtimc.ReadOnly = true;
            this.txtimc.Size = new System.Drawing.Size(376, 30);
            this.txtimc.TabIndex = 5;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalc.Location = new System.Drawing.Point(160, 372);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(121, 45);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnreset.Location = new System.Drawing.Point(325, 372);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(121, 45);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvolt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvolt.Location = new System.Drawing.Point(488, 372);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(121, 45);
            this.btnvolt.TabIndex = 8;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = false;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // frmimc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.lbltxt);
            this.Name = "frmimc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.frmimc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnvolt;
    }
}