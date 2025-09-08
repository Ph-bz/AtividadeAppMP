namespace AtividadeAppMP
{
    partial class frmfunc
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
            this.btncalc = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.lblgen = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.txtgen = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.lblnome2 = new System.Windows.Forms.Label();
            this.txtnomeresult = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtsalresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalc.Location = new System.Drawing.Point(217, 429);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(124, 50);
            this.btncalc.TabIndex = 0;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(445, 429);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(124, 50);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvolt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolt.Location = new System.Drawing.Point(689, 429);
            this.btnvolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(124, 50);
            this.btnvolt.TabIndex = 2;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = false;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(284, 42);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(157, 23);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Digite seu nome:";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(284, 196);
            this.lblidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(157, 23);
            this.lblidade.TabIndex = 4;
            this.lblidade.Text = "Digite sua idade:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(288, 121);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(124, 30);
            this.txtnome.TabIndex = 5;
            // 
            // txtidade
            // 
            this.txtidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade.Location = new System.Drawing.Point(288, 260);
            this.txtidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(124, 30);
            this.txtidade.TabIndex = 6;
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgen.Location = new System.Drawing.Point(512, 42);
            this.lblgen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(258, 23);
            this.lblgen.TabIndex = 7;
            this.lblgen.Text = "Digite seu gênero (F ou M) :";
            this.lblgen.Click += new System.EventHandler(this.lblgen_Click);
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.Location = new System.Drawing.Point(564, 196);
            this.lblsal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(167, 23);
            this.lblsal.TabIndex = 8;
            this.lblsal.Text = "Digite seu salário:";
            // 
            // txtgen
            // 
            this.txtgen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgen.Location = new System.Drawing.Point(582, 121);
            this.txtgen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgen.Name = "txtgen";
            this.txtgen.Size = new System.Drawing.Size(124, 30);
            this.txtgen.TabIndex = 9;
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(591, 260);
            this.txtsal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(124, 30);
            this.txtsal.TabIndex = 10;
            // 
            // lblnome2
            // 
            this.lblnome2.AutoSize = true;
            this.lblnome2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome2.Location = new System.Drawing.Point(59, 346);
            this.lblnome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome2.Name = "lblnome2";
            this.lblnome2.Size = new System.Drawing.Size(176, 23);
            this.lblnome2.TabIndex = 11;
            this.lblnome2.Text = "O(a) funcionário(a)";
            // 
            // txtnomeresult
            // 
            this.txtnomeresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeresult.Location = new System.Drawing.Point(259, 342);
            this.txtnomeresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnomeresult.Name = "txtnomeresult";
            this.txtnomeresult.ReadOnly = true;
            this.txtnomeresult.Size = new System.Drawing.Size(163, 30);
            this.txtnomeresult.TabIndex = 12;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(512, 349);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(203, 23);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "receberá um valor de:";
            // 
            // txtsalresult
            // 
            this.txtsalresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalresult.Location = new System.Drawing.Point(745, 346);
            this.txtsalresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsalresult.Name = "txtsalresult";
            this.txtsalresult.ReadOnly = true;
            this.txtsalresult.Size = new System.Drawing.Size(166, 30);
            this.txtsalresult.TabIndex = 14;
            // 
            // frmfunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 524);
            this.ControlBox = false;
            this.Controls.Add(this.txtsalresult);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtnomeresult);
            this.Controls.Add(this.lblnome2);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtgen);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lblgen);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmfunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmfunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.TextBox txtgen;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Label lblnome2;
        private System.Windows.Forms.TextBox txtnomeresult;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtsalresult;
    }
}