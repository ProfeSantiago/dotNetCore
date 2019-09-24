namespace Hola_Mundo_Forms
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
            this.Saluda_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saluda_Btn
            // 
            this.Saluda_Btn.Location = new System.Drawing.Point(77, 36);
            this.Saluda_Btn.Name = "Saluda_Btn";
            this.Saluda_Btn.Size = new System.Drawing.Size(75, 23);
            this.Saluda_Btn.TabIndex = 0;
            this.Saluda_Btn.Text = "Saludar";
            this.Saluda_Btn.UseVisualStyleBackColor = true;
            this.Saluda_Btn.Click += new System.EventHandler(this.Saluda_Btn_Click);
            // 
            // Hola_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 98);
            this.Controls.Add(this.Saluda_Btn);
            this.Name = "Hola_Frm";
            this.Text = "Hola Mundo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Saluda_Btn;
    }
}

