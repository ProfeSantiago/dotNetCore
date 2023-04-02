namespace Condicional_If_Else
{
    partial class Condicionales_Frm
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
            this.Ingresa_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_Txt = new System.Windows.Forms.TextBox();
            this.Edad_Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ingresa_Btn
            // 
            this.Ingresa_Btn.Location = new System.Drawing.Point(144, 160);
            this.Ingresa_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ingresa_Btn.Name = "Ingresa_Btn";
            this.Ingresa_Btn.Size = new System.Drawing.Size(100, 28);
            this.Ingresa_Btn.TabIndex = 0;
            this.Ingresa_Btn.Text = "Ingresar";
            this.Ingresa_Btn.UseVisualStyleBackColor = true;
            this.Ingresa_Btn.Click += new System.EventHandler(this.Ingresa_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // Nombre_Txt
            // 
            this.Nombre_Txt.Location = new System.Drawing.Point(16, 46);
            this.Nombre_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre_Txt.Name = "Nombre_Txt";
            this.Nombre_Txt.Size = new System.Drawing.Size(229, 22);
            this.Nombre_Txt.TabIndex = 3;
            // 
            // Edad_Txt
            // 
            this.Edad_Txt.Location = new System.Drawing.Point(16, 110);
            this.Edad_Txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edad_Txt.Name = "Edad_Txt";
            this.Edad_Txt.Size = new System.Drawing.Size(227, 22);
            this.Edad_Txt.TabIndex = 4;
            // 
            // Condicionales_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 201);
            this.Controls.Add(this.Edad_Txt);
            this.Controls.Add(this.Nombre_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ingresa_Btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Condicionales_Frm";
            this.Text = "Condicionales";
            this.Load += new System.EventHandler(this.Condicionales_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresa_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre_Txt;
        private System.Windows.Forms.TextBox Edad_Txt;
    }
}

