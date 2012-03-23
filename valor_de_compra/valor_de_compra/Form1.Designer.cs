namespace valor_de_compra
{
    partial class Form1
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
            this.lblValor_compra = new System.Windows.Forms.Label();
            this.lblValor_desconto = new System.Windows.Forms.Label();
            this.txtValor_compra = new System.Windows.Forms.TextBox();
            this.txtValor_desconto = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor_compra
            // 
            this.lblValor_compra.AutoSize = true;
            this.lblValor_compra.Location = new System.Drawing.Point(39, 21);
            this.lblValor_compra.Name = "lblValor_compra";
            this.lblValor_compra.Size = new System.Drawing.Size(85, 13);
            this.lblValor_compra.TabIndex = 0;
            this.lblValor_compra.Text = "Valor da Compra";
            // 
            // lblValor_desconto
            // 
            this.lblValor_desconto.AutoSize = true;
            this.lblValor_desconto.Location = new System.Drawing.Point(39, 51);
            this.lblValor_desconto.Name = "lblValor_desconto";
            this.lblValor_desconto.Size = new System.Drawing.Size(95, 13);
            this.lblValor_desconto.TabIndex = 1;
            this.lblValor_desconto.Text = "Valor de Desconto";
            // 
            // txtValor_compra
            // 
            this.txtValor_compra.Location = new System.Drawing.Point(130, 18);
            this.txtValor_compra.Name = "txtValor_compra";
            this.txtValor_compra.Size = new System.Drawing.Size(100, 20);
            this.txtValor_compra.TabIndex = 2;
            // 
            // txtValor_desconto
            // 
            this.txtValor_desconto.Location = new System.Drawing.Point(140, 44);
            this.txtValor_desconto.Name = "txtValor_desconto";
            this.txtValor_desconto.Size = new System.Drawing.Size(100, 20);
            this.txtValor_desconto.TabIndex = 3;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(276, 21);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(61, 43);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(39, 120);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(42, 13);
            this.lblTot.TabIndex = 5;
            this.lblTot.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(118, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtValor_desconto);
            this.Controls.Add(this.txtValor_compra);
            this.Controls.Add(this.lblValor_desconto);
            this.Controls.Add(this.lblValor_compra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor_compra;
        private System.Windows.Forms.Label lblValor_desconto;
        private System.Windows.Forms.TextBox txtValor_compra;
        private System.Windows.Forms.TextBox txtValor_desconto;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblTotal;
    }
}

