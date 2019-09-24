namespace Arreglos
{
    partial class Arreglos_Frm
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
            this.Numero_Txt = new System.Windows.Forms.TextBox();
            this.ListaNums_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Agrega_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite un número:";
            // 
            // Numero_Txt
            // 
            this.Numero_Txt.Location = new System.Drawing.Point(18, 35);
            this.Numero_Txt.Name = "Numero_Txt";
            this.Numero_Txt.Size = new System.Drawing.Size(100, 20);
            this.Numero_Txt.TabIndex = 1;
            // 
            // ListaNums_ListBox
            // 
            this.ListaNums_ListBox.FormattingEnabled = true;
            this.ListaNums_ListBox.Location = new System.Drawing.Point(232, 35);
            this.ListaNums_ListBox.Name = "ListaNums_ListBox";
            this.ListaNums_ListBox.Size = new System.Drawing.Size(120, 108);
            this.ListaNums_ListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de números:";
            // 
            // Agrega_Btn
            // 
            this.Agrega_Btn.Location = new System.Drawing.Point(130, 35);
            this.Agrega_Btn.Name = "Agrega_Btn";
            this.Agrega_Btn.Size = new System.Drawing.Size(75, 23);
            this.Agrega_Btn.TabIndex = 4;
            this.Agrega_Btn.Text = "Agregar >>";
            this.Agrega_Btn.UseVisualStyleBackColor = true;
            this.Agrega_Btn.Click += new System.EventHandler(this.Agrega_Btn_Click);
            // 
            // Arreglos_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 172);
            this.Controls.Add(this.Agrega_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaNums_ListBox);
            this.Controls.Add(this.Numero_Txt);
            this.Controls.Add(this.label1);
            this.Name = "Arreglos_Frm";
            this.Text = "Arreglos";
            this.Load += new System.EventHandler(this.Arreglos_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero_Txt;
        private System.Windows.Forms.ListBox ListaNums_ListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agrega_Btn;
    }
}

