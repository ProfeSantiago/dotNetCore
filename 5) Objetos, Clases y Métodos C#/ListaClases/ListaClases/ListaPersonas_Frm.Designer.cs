namespace ListaClases
{
    partial class ListaPersonas_Frm
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
            this.ConsultaPersonas_Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Txt = new System.Windows.Forms.TextBox();
            this.Nom_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tel_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Guarda_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPersonas_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaPersonas_Grid
            // 
            this.ConsultaPersonas_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaPersonas_Grid.Location = new System.Drawing.Point(12, 184);
            this.ConsultaPersonas_Grid.Name = "ConsultaPersonas_Grid";
            this.ConsultaPersonas_Grid.Size = new System.Drawing.Size(346, 150);
            this.ConsultaPersonas_Grid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "#ID:";
            // 
            // Id_Txt
            // 
            this.Id_Txt.Location = new System.Drawing.Point(72, 22);
            this.Id_Txt.Name = "Id_Txt";
            this.Id_Txt.Size = new System.Drawing.Size(286, 20);
            this.Id_Txt.TabIndex = 2;
            // 
            // Nom_Txt
            // 
            this.Nom_Txt.Location = new System.Drawing.Point(72, 62);
            this.Nom_Txt.Name = "Nom_Txt";
            this.Nom_Txt.Size = new System.Drawing.Size(286, 20);
            this.Nom_Txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // Tel_Txt
            // 
            this.Tel_Txt.Location = new System.Drawing.Point(72, 102);
            this.Tel_Txt.Name = "Tel_Txt";
            this.Tel_Txt.Size = new System.Drawing.Size(286, 20);
            this.Tel_Txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teléfono:";
            // 
            // Guarda_Btn
            // 
            this.Guarda_Btn.Location = new System.Drawing.Point(282, 138);
            this.Guarda_Btn.Name = "Guarda_Btn";
            this.Guarda_Btn.Size = new System.Drawing.Size(75, 23);
            this.Guarda_Btn.TabIndex = 7;
            this.Guarda_Btn.Text = "Guardar";
            this.Guarda_Btn.UseVisualStyleBackColor = true;
            this.Guarda_Btn.Click += new System.EventHandler(this.Guarda_Btn_Click);
            // 
            // ListaPersonas_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 346);
            this.Controls.Add(this.Guarda_Btn);
            this.Controls.Add(this.Tel_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultaPersonas_Grid);
            this.Name = "ListaPersonas_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas de Personas";
            this.Load += new System.EventHandler(this.ListaPersonas_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaPersonas_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaPersonas_Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_Txt;
        private System.Windows.Forms.TextBox Nom_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tel_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guarda_Btn;
    }
}

