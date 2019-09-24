namespace Variables_Enteras
{
    partial class VarEnt_Frm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num1_Txt = new System.Windows.Forms.TextBox();
            this.Num2_Txt = new System.Windows.Forms.TextBox();
            this.Suma_Btn = new System.Windows.Forms.Button();
            this.Resultado_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Número:";
            // 
            // Num1_Txt
            // 
            this.Num1_Txt.Location = new System.Drawing.Point(113, 32);
            this.Num1_Txt.Name = "Num1_Txt";
            this.Num1_Txt.Size = new System.Drawing.Size(100, 20);
            this.Num1_Txt.TabIndex = 2;
            // 
            // Num2_Txt
            // 
            this.Num2_Txt.Location = new System.Drawing.Point(113, 71);
            this.Num2_Txt.Name = "Num2_Txt";
            this.Num2_Txt.Size = new System.Drawing.Size(100, 20);
            this.Num2_Txt.TabIndex = 3;
            // 
            // Suma_Btn
            // 
            this.Suma_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma_Btn.Location = new System.Drawing.Point(85, 105);
            this.Suma_Btn.Name = "Suma_Btn";
            this.Suma_Btn.Size = new System.Drawing.Size(24, 27);
            this.Suma_Btn.TabIndex = 4;
            this.Suma_Btn.Text = "+";
            this.Suma_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Suma_Btn.UseVisualStyleBackColor = true;
            this.Suma_Btn.Click += new System.EventHandler(this.Suma_Btn_Click);
            // 
            // Resultado_Txt
            // 
            this.Resultado_Txt.Location = new System.Drawing.Point(113, 110);
            this.Resultado_Txt.Name = "Resultado_Txt";
            this.Resultado_Txt.Size = new System.Drawing.Size(100, 20);
            this.Resultado_Txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // VarEnt_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 178);
            this.Controls.Add(this.Resultado_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Suma_Btn);
            this.Controls.Add(this.Num2_Txt);
            this.Controls.Add(this.Num1_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VarEnt_Frm";
            this.Text = "Variables Enteras";
            this.Load += new System.EventHandler(this.VarEnt_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num1_Txt;
        private System.Windows.Forms.TextBox Num2_Txt;
        private System.Windows.Forms.Button Suma_Btn;
        private System.Windows.Forms.TextBox Resultado_Txt;
        private System.Windows.Forms.Label label3;
    }
}

