namespace Algoritmos_Ordenamiento
{
    partial class Ordenamientos_Frm
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
            this.Agrega_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaNums_ListBox = new System.Windows.Forms.ListBox();
            this.Numero_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Burbuja_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agrega_Btn
            // 
            this.Agrega_Btn.Location = new System.Drawing.Point(123, 32);
            this.Agrega_Btn.Name = "Agrega_Btn";
            this.Agrega_Btn.Size = new System.Drawing.Size(75, 23);
            this.Agrega_Btn.TabIndex = 9;
            this.Agrega_Btn.Text = "Agregar >>";
            this.Agrega_Btn.UseVisualStyleBackColor = true;
            this.Agrega_Btn.Click += new System.EventHandler(this.Agrega_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de números:";
            // 
            // ListaNums_ListBox
            // 
            this.ListaNums_ListBox.FormattingEnabled = true;
            this.ListaNums_ListBox.Location = new System.Drawing.Point(220, 35);
            this.ListaNums_ListBox.Name = "ListaNums_ListBox";
            this.ListaNums_ListBox.Size = new System.Drawing.Size(120, 173);
            this.ListaNums_ListBox.TabIndex = 7;
            // 
            // Numero_Txt
            // 
            this.Numero_Txt.Location = new System.Drawing.Point(17, 35);
            this.Numero_Txt.Name = "Numero_Txt";
            this.Numero_Txt.Size = new System.Drawing.Size(100, 20);
            this.Numero_Txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite un número:";
            // 
            // Burbuja_Btn
            // 
            this.Burbuja_Btn.Location = new System.Drawing.Point(17, 70);
            this.Burbuja_Btn.Name = "Burbuja_Btn";
            this.Burbuja_Btn.Size = new System.Drawing.Size(181, 23);
            this.Burbuja_Btn.TabIndex = 10;
            this.Burbuja_Btn.Text = "Ordenamiento Burbuja";
            this.Burbuja_Btn.UseVisualStyleBackColor = true;
            this.Burbuja_Btn.Click += new System.EventHandler(this.Burbuja_Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ordenamiento QuickSort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ordenamientos_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Burbuja_Btn);
            this.Controls.Add(this.Agrega_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaNums_ListBox);
            this.Controls.Add(this.Numero_Txt);
            this.Controls.Add(this.label1);
            this.Name = "Ordenamientos_Frm";
            this.Text = "Algoritmos de Ordenamiento";
            this.Load += new System.EventHandler(this.Ordenamientos_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agrega_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListaNums_ListBox;
        private System.Windows.Forms.TextBox Numero_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Burbuja_Btn;
        private System.Windows.Forms.Button button1;
    }
}

