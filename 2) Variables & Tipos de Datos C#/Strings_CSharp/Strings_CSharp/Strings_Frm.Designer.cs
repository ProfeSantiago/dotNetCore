namespace Strings_CSharp
{
    partial class Strings_Frm
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
            this.Palabra_Txt = new System.Windows.Forms.TextBox();
            this.Procesar_Btn = new System.Windows.Forms.Button();
            this.Primera_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ultima_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite una palabra:";
            // 
            // Palabra_Txt
            // 
            this.Palabra_Txt.Location = new System.Drawing.Point(16, 30);
            this.Palabra_Txt.Name = "Palabra_Txt";
            this.Palabra_Txt.Size = new System.Drawing.Size(276, 20);
            this.Palabra_Txt.TabIndex = 1;
            // 
            // Procesar_Btn
            // 
            this.Procesar_Btn.Location = new System.Drawing.Point(217, 67);
            this.Procesar_Btn.Name = "Procesar_Btn";
            this.Procesar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Procesar_Btn.TabIndex = 2;
            this.Procesar_Btn.Text = "Procesar";
            this.Procesar_Btn.UseVisualStyleBackColor = true;
            this.Procesar_Btn.Click += new System.EventHandler(this.Procesar_Btn_Click);
            // 
            // Primera_Txt
            // 
            this.Primera_Txt.Location = new System.Drawing.Point(94, 67);
            this.Primera_Txt.Name = "Primera_Txt";
            this.Primera_Txt.Size = new System.Drawing.Size(59, 20);
            this.Primera_Txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primera Letra:";
            // 
            // Ultima_Txt
            // 
            this.Ultima_Txt.Location = new System.Drawing.Point(94, 102);
            this.Ultima_Txt.Name = "Ultima_Txt";
            this.Ultima_Txt.Size = new System.Drawing.Size(59, 20);
            this.Ultima_Txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Última Letra:";
            // 
            // Cantidad_Txt
            // 
            this.Cantidad_Txt.Location = new System.Drawing.Point(94, 137);
            this.Cantidad_Txt.Name = "Cantidad_Txt";
            this.Cantidad_Txt.Size = new System.Drawing.Size(59, 20);
            this.Cantidad_Txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cant. Letras:";
            // 
            // Strings_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 185);
            this.Controls.Add(this.Cantidad_Txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ultima_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Primera_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Procesar_Btn);
            this.Controls.Add(this.Palabra_Txt);
            this.Controls.Add(this.label1);
            this.Name = "Strings_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Palabra_Txt;
        private System.Windows.Forms.Button Procesar_Btn;
        private System.Windows.Forms.TextBox Primera_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ultima_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cantidad_Txt;
        private System.Windows.Forms.Label label4;
    }
}

