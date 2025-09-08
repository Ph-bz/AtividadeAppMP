namespace AtividadeAppMP
{
    partial class frmlivros
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
            this.lbllivros = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtlivro = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllivros
            // 
            this.lbllivros.AutoSize = true;
            this.lbllivros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllivros.Location = new System.Drawing.Point(375, 82);
            this.lbllivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllivros.Name = "lbllivros";
            this.lbllivros.Size = new System.Drawing.Size(362, 23);
            this.lbllivros.TabIndex = 0;
            this.lbllivros.Text = "Digite a quantidade de livros comprados";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(423, 271);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(279, 23);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "O valor total da compra foi de:";
            // 
            // txtlivro
            // 
            this.txtlivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlivro.Location = new System.Drawing.Point(447, 143);
            this.txtlivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(205, 30);
            this.txtlivro.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(447, 318);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(205, 30);
            this.txtresult.TabIndex = 3;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncalc.Location = new System.Drawing.Point(245, 421);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(148, 47);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnreset.Location = new System.Drawing.Point(481, 421);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(148, 47);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnexit.Location = new System.Drawing.Point(727, 421);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(148, 47);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Voltar";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmlivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 634);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtlivro);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbllivros);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmlivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllivros;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtlivro;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnexit;
    }
}

