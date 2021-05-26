namespace GesB
{
    partial class CreditDebit
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.btnDebiter = new System.Windows.Forms.Button();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.txtMontantCrediterDebite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFremer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créditer ou Débiter un compte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroCompte);
            this.groupBox1.Controls.Add(this.btnDebiter);
            this.groupBox1.Controls.Add(this.btnCrediter);
            this.groupBox1.Controls.Add(this.txtMontantCrediterDebite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(183, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(649, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(237, 32);
            this.txtNumeroCompte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(265, 22);
            this.txtNumeroCompte.TabIndex = 1;
            // 
            // btnDebiter
            // 
            this.btnDebiter.Location = new System.Drawing.Point(332, 165);
            this.btnDebiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(220, 28);
            this.btnDebiter.TabIndex = 4;
            this.btnDebiter.Text = "Débiter";
            this.btnDebiter.UseVisualStyleBackColor = true;
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // btnCrediter
            // 
            this.btnCrediter.Location = new System.Drawing.Point(29, 165);
            this.btnCrediter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(220, 28);
            this.btnCrediter.TabIndex = 3;
            this.btnCrediter.Text = "Créditer";
            this.btnCrediter.UseVisualStyleBackColor = true;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // txtMontantCrediterDebite
            // 
            this.txtMontantCrediterDebite.Location = new System.Drawing.Point(237, 95);
            this.txtMontantCrediterDebite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontantCrediterDebite.Name = "txtMontantCrediterDebite";
            this.txtMontantCrediterDebite.Size = new System.Drawing.Size(265, 22);
            this.txtMontantCrediterDebite.TabIndex = 2;
            this.txtMontantCrediterDebite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Montant à créditer / débiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numéro de compte";
            // 
            // btnFremer
            // 
            this.btnFremer.Location = new System.Drawing.Point(612, 432);
            this.btnFremer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFremer.Name = "btnFremer";
            this.btnFremer.Size = new System.Drawing.Size(220, 28);
            this.btnFremer.TabIndex = 5;
            this.btnFremer.Text = "Fermer";
            this.btnFremer.UseVisualStyleBackColor = true;
            this.btnFremer.Click += new System.EventHandler(this.btnFremer_Click);
            // 
            // CreditDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 608);
            this.Controls.Add(this.btnFremer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreditDebit";
            this.Text = "GesB >> Credit / Debit";
            this.Load += new System.EventHandler(this.CreditDebit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontantCrediterDebite;
        private System.Windows.Forms.Button btnDebiter;
        private System.Windows.Forms.Button btnCrediter;
        private System.Windows.Forms.Button btnFremer;
        private System.Windows.Forms.TextBox txtNumeroCompte;
    }
}