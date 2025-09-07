namespace AtividadeAppMP
{
    partial class frmestadio
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
            this.lbling = new System.Windows.Forms.Label();
            this.lblgrl = new System.Windows.Forms.Label();
            this.lblpop = new System.Windows.Forms.Label();
            this.lblarq = new System.Windows.Forms.Label();
            this.lblcad = new System.Windows.Forms.Label();
            this.lblqtdp = new System.Windows.Forms.Label();
            this.txting = new System.Windows.Forms.TextBox();
            this.txtqtdp = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbling
            // 
            this.lbling.AutoSize = true;
            this.lbling.CausesValidation = false;
            this.lbling.Location = new System.Drawing.Point(449, 38);
            this.lbling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbling.Name = "lbling";
            this.lbling.Size = new System.Drawing.Size(152, 16);
            this.lbling.TabIndex = 0;
            this.lbling.Text = "Digite o tipo de ingresso";
            // 
            // lblgrl
            // 
            this.lblgrl.AutoSize = true;
            this.lblgrl.Location = new System.Drawing.Point(427, 76);
            this.lblgrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgrl.Name = "lblgrl";
            this.lblgrl.Size = new System.Drawing.Size(60, 16);
            this.lblgrl.TabIndex = 1;
            this.lblgrl.Text = "Geral = 1";
            // 
            // lblpop
            // 
            this.lblpop.AutoSize = true;
            this.lblpop.Location = new System.Drawing.Point(553, 76);
            this.lblpop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpop.Name = "lblpop";
            this.lblpop.Size = new System.Drawing.Size(74, 16);
            this.lblpop.TabIndex = 2;
            this.lblpop.Text = "Popular = 2";
            // 
            // lblarq
            // 
            this.lblarq.AutoSize = true;
            this.lblarq.Location = new System.Drawing.Point(404, 108);
            this.lblarq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarq.Name = "lblarq";
            this.lblarq.Size = new System.Drawing.Size(112, 16);
            this.lblarq.TabIndex = 3;
            this.lblarq.Text = "Arquibancada = 3";
            // 
            // lblcad
            // 
            this.lblcad.AutoSize = true;
            this.lblcad.Location = new System.Drawing.Point(553, 108);
            this.lblcad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcad.Name = "lblcad";
            this.lblcad.Size = new System.Drawing.Size(82, 16);
            this.lblcad.TabIndex = 4;
            this.lblcad.Text = "Cadeiras = 4";
            // 
            // lblqtdp
            // 
            this.lblqtdp.AutoSize = true;
            this.lblqtdp.Location = new System.Drawing.Point(335, 198);
            this.lblqtdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqtdp.Name = "lblqtdp";
            this.lblqtdp.Size = new System.Drawing.Size(411, 16);
            this.lblqtdp.TabIndex = 5;
            this.lblqtdp.Text = "Digite a quantidade de pessoas que compraram o mesmo ingresso";
            // 
            // txting
            // 
            this.txting.Location = new System.Drawing.Point(453, 150);
            this.txting.Margin = new System.Windows.Forms.Padding(4);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(155, 22);
            this.txting.TabIndex = 6;
            // 
            // txtqtdp
            // 
            this.txtqtdp.Location = new System.Drawing.Point(453, 250);
            this.txtqtdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtdp.Name = "txtqtdp";
            this.txtqtdp.Size = new System.Drawing.Size(155, 22);
            this.txtqtdp.TabIndex = 7;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(348, 293);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(345, 16);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "A renda total das pessoas no seu tipo de ingresso foi de:";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(453, 341);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(155, 22);
            this.txtresult.TabIndex = 9;
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalc.Location = new System.Drawing.Point(305, 432);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(133, 43);
            this.btncalc.TabIndex = 10;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(464, 432);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(133, 43);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Resetar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvolt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolt.Location = new System.Drawing.Point(627, 432);
            this.btnvolt.Margin = new System.Windows.Forms.Padding(4);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(133, 43);
            this.btnvolt.TabIndex = 12;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = false;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // frmestadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtqtdp);
            this.Controls.Add(this.txting);
            this.Controls.Add(this.lblqtdp);
            this.Controls.Add(this.lblcad);
            this.Controls.Add(this.lblarq);
            this.Controls.Add(this.lblpop);
            this.Controls.Add(this.lblgrl);
            this.Controls.Add(this.lbling);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmestadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estádio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbling;
        private System.Windows.Forms.Label lblgrl;
        private System.Windows.Forms.Label lblpop;
        private System.Windows.Forms.Label lblarq;
        private System.Windows.Forms.Label lblcad;
        private System.Windows.Forms.Label lblqtdp;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.TextBox txtqtdp;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnvolt;
    }
}