namespace AtividadeAppMP
{
    partial class frmlanche
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
            this.lbltiplan = new System.Windows.Forms.Label();
            this.lblcqn = new System.Windows.Forms.Label();
            this.lblbauru = new System.Windows.Forms.Label();
            this.lblburguer = new System.Windows.Forms.Label();
            this.lbltrpbrg = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltiplan
            // 
            this.lbltiplan.AutoSize = true;
            this.lbltiplan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiplan.Location = new System.Drawing.Point(369, 61);
            this.lbltiplan.Name = "lbltiplan";
            this.lbltiplan.Size = new System.Drawing.Size(237, 23);
            this.lbltiplan.TabIndex = 0;
            this.lbltiplan.Text = "Digite o código do lanche:";
            // 
            // lblcqn
            // 
            this.lblcqn.AutoSize = true;
            this.lblcqn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcqn.Location = new System.Drawing.Point(104, 62);
            this.lblcqn.Name = "lblcqn";
            this.lblcqn.Size = new System.Drawing.Size(201, 23);
            this.lblcqn.TabIndex = 1;
            this.lblcqn.Text = "Cachorro quente: 100";
            // 
            // lblbauru
            // 
            this.lblbauru.AutoSize = true;
            this.lblbauru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbauru.Location = new System.Drawing.Point(104, 88);
            this.lblbauru.Name = "lblbauru";
            this.lblbauru.Size = new System.Drawing.Size(106, 23);
            this.lblbauru.TabIndex = 2;
            this.lblbauru.Text = "Bauru: 101";
            // 
            // lblburguer
            // 
            this.lblburguer.AutoSize = true;
            this.lblburguer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblburguer.Location = new System.Drawing.Point(104, 116);
            this.lblburguer.Name = "lblburguer";
            this.lblburguer.Size = new System.Drawing.Size(144, 23);
            this.lblburguer.TabIndex = 3;
            this.lblburguer.Text = "X-Burguer: 102";
            // 
            // lbltrpbrg
            // 
            this.lbltrpbrg.AutoSize = true;
            this.lbltrpbrg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrpbrg.Location = new System.Drawing.Point(104, 145);
            this.lbltrpbrg.Name = "lbltrpbrg";
            this.lbltrpbrg.Size = new System.Drawing.Size(198, 23);
            this.lbltrpbrg.TabIndex = 4;
            this.lbltrpbrg.Text = "Triplo X-Burguer: 103";
            this.lbltrpbrg.Click += new System.EventHandler(this.lbltrpbrg_Click);
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(393, 109);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(122, 30);
            this.txtcod.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 6;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(216, 260);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(230, 30);
            this.txtresult.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "O seu lanche está custando (em R$):";
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncalc.Location = new System.Drawing.Point(124, 371);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(108, 36);
            this.btncalc.TabIndex = 9;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreset.Location = new System.Drawing.Point(269, 371);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(108, 36);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvolt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvolt.Location = new System.Drawing.Point(428, 371);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(108, 36);
            this.btnvolt.TabIndex = 11;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = false;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // frmlanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbltrpbrg);
            this.Controls.Add(this.lblburguer);
            this.Controls.Add(this.lblbauru);
            this.Controls.Add(this.lblcqn);
            this.Controls.Add(this.lbltiplan);
            this.Name = "frmlanche";
            this.Text = "Lanches";
            this.Load += new System.EventHandler(this.frmlanche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltiplan;
        private System.Windows.Forms.Label lblcqn;
        private System.Windows.Forms.Label lblbauru;
        private System.Windows.Forms.Label lblburguer;
        private System.Windows.Forms.Label lbltrpbrg;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnvolt;
    }
}