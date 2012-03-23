namespace media_de_idade
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnCalcule = new System.Windows.Forms.Button();
            this.lblResultado_vida_dias = new System.Windows.Forms.Label();
            this.lblResultado_vida_horas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(12, 9);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(52, 6);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 39);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(69, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias de vida:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(12, 61);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(76, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas de vida:";
            // 
            // btnCalcule
            // 
            this.btnCalcule.Location = new System.Drawing.Point(168, 7);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(62, 19);
            this.btnCalcule.TabIndex = 4;
            this.btnCalcule.Text = "Calcule";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcule_Click);
            // 
            // lblResultado_vida_dias
            // 
            this.lblResultado_vida_dias.AutoSize = true;
            this.lblResultado_vida_dias.Location = new System.Drawing.Point(87, 39);
            this.lblResultado_vida_dias.Name = "lblResultado_vida_dias";
            this.lblResultado_vida_dias.Size = new System.Drawing.Size(0, 13);
            this.lblResultado_vida_dias.TabIndex = 5;
            // 
            // lblResultado_vida_horas
            // 
            this.lblResultado_vida_horas.AutoSize = true;
            this.lblResultado_vida_horas.Location = new System.Drawing.Point(87, 61);
            this.lblResultado_vida_horas.Name = "lblResultado_vida_horas";
            this.lblResultado_vida_horas.Size = new System.Drawing.Size(0, 13);
            this.lblResultado_vida_horas.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResultado_vida_horas);
            this.Controls.Add(this.lblResultado_vida_dias);
            this.Controls.Add(this.btnCalcule);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.Label lblResultado_vida_dias;
        private System.Windows.Forms.Label lblResultado_vida_horas;
    }
}

