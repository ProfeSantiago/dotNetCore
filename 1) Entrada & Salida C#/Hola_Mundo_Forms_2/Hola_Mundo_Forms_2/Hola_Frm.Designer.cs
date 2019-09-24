namespace Hola_Mundo_Forms_2
{
    partial class Hola_Frm
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
            this.Nombre_Txt = new System.Windows.Forms.TextBox();
            this.Saluda_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite su Nombre:";
            // 
            // Nombre_Txt
            // 
            this.Nombre_Txt.Location = new System.Drawing.Point(21, 28);
            this.Nombre_Txt.Name = "Nombre_Txt";
            this.Nombre_Txt.Size = new System.Drawing.Size(176, 20);
            this.Nombre_Txt.TabIndex = 1;
            // 
            // Saluda_Btn
            // 
            this.Saluda_Btn.Location = new System.Drawing.Point(209, 26);
            this.Saluda_Btn.Name = "Saluda_Btn";
            this.Saluda_Btn.Size = new System.Drawing.Size(75, 23);
            this.Saluda_Btn.TabIndex = 2;
            this.Saluda_Btn.Text = "Saludar";
            this.Saluda_Btn.UseVisualStyleBackColor = true;
            this.Saluda_Btn.Click += new System.EventHandler(this.Saluda_Btn_Click);
            // 
            // Hola_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 92);
            this.Controls.Add(this.Saluda_Btn);
            this.Controls.Add(this.Nombre_Txt);
            this.Controls.Add(this.label1);
            this.Name = "Hola_Frm";
            this.Text = "Hola Mundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_Txt;
        private System.Windows.Forms.Button Saluda_Btn;
    }
}

