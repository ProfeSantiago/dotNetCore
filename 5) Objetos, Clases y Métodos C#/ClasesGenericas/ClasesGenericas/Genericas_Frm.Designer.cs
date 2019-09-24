namespace ClasesGenericas
{
    partial class Genericas_Frm
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
            this.Guarda_Btn = new System.Windows.Forms.Button();
            this.Tel_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nom_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaPersonas_Grid = new System.Windows.Forms.DataGridView();
            this.RadioBtn_Alumno = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Profe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPersonas_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Guarda_Btn
            // 
            this.Guarda_Btn.Location = new System.Drawing.Point(243, 129);
            this.Guarda_Btn.Name = "Guarda_Btn";
            this.Guarda_Btn.Size = new System.Drawing.Size(75, 23);
            this.Guarda_Btn.TabIndex = 15;
            this.Guarda_Btn.Text = "Guardar";
            this.Guarda_Btn.UseVisualStyleBackColor = true;
            this.Guarda_Btn.Click += new System.EventHandler(this.Guarda_Btn_Click);
            // 
            // Tel_Txt
            // 
            this.Tel_Txt.Location = new System.Drawing.Point(110, 92);
            this.Tel_Txt.Name = "Tel_Txt";
            this.Tel_Txt.Size = new System.Drawing.Size(208, 20);
            this.Tel_Txt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Profesión / Carrera:";
            // 
            // Nom_Txt
            // 
            this.Nom_Txt.Location = new System.Drawing.Point(110, 52);
            this.Nom_Txt.Name = "Nom_Txt";
            this.Nom_Txt.Size = new System.Drawing.Size(208, 20);
            this.Nom_Txt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // Id_Txt
            // 
            this.Id_Txt.Location = new System.Drawing.Point(110, 12);
            this.Id_Txt.Name = "Id_Txt";
            this.Id_Txt.Size = new System.Drawing.Size(208, 20);
            this.Id_Txt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cedula / Carnet:";
            // 
            // ConsultaPersonas_Grid
            // 
            this.ConsultaPersonas_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaPersonas_Grid.Location = new System.Drawing.Point(11, 174);
            this.ConsultaPersonas_Grid.Name = "ConsultaPersonas_Grid";
            this.ConsultaPersonas_Grid.Size = new System.Drawing.Size(307, 150);
            this.ConsultaPersonas_Grid.TabIndex = 8;
            // 
            // RadioBtn_Alumno
            // 
            this.RadioBtn_Alumno.AutoSize = true;
            this.RadioBtn_Alumno.Location = new System.Drawing.Point(11, 129);
            this.RadioBtn_Alumno.Name = "RadioBtn_Alumno";
            this.RadioBtn_Alumno.Size = new System.Drawing.Size(60, 17);
            this.RadioBtn_Alumno.TabIndex = 16;
            this.RadioBtn_Alumno.TabStop = true;
            this.RadioBtn_Alumno.Text = "Alumno";
            this.RadioBtn_Alumno.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Profe
            // 
            this.RadioBtn_Profe.AutoSize = true;
            this.RadioBtn_Profe.Location = new System.Drawing.Point(110, 132);
            this.RadioBtn_Profe.Name = "RadioBtn_Profe";
            this.RadioBtn_Profe.Size = new System.Drawing.Size(64, 17);
            this.RadioBtn_Profe.TabIndex = 17;
            this.RadioBtn_Profe.TabStop = true;
            this.RadioBtn_Profe.Text = "Profesor";
            this.RadioBtn_Profe.UseVisualStyleBackColor = true;
            // 
            // Genericas_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.RadioBtn_Profe);
            this.Controls.Add(this.RadioBtn_Alumno);
            this.Controls.Add(this.Guarda_Btn);
            this.Controls.Add(this.Tel_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaPersonas_Grid);
            this.Name = "Genericas_Frm";
            this.Text = "Clases Genericas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPersonas_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guarda_Btn;
        private System.Windows.Forms.TextBox Tel_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nom_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultaPersonas_Grid;
        private System.Windows.Forms.RadioButton RadioBtn_Alumno;
        private System.Windows.Forms.RadioButton RadioBtn_Profe;
    }
}

