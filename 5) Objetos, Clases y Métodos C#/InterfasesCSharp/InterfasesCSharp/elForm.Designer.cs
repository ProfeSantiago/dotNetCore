namespace InterfasesCSharp
{
    partial class elForm
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
            this.MustraBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MustraBtn
            // 
            this.MustraBtn.Location = new System.Drawing.Point(45, 12);
            this.MustraBtn.Name = "MustraBtn";
            this.MustraBtn.Size = new System.Drawing.Size(109, 23);
            this.MustraBtn.TabIndex = 0;
            this.MustraBtn.Text = "Mostrar Datos";
            this.MustraBtn.UseVisualStyleBackColor = true;
            this.MustraBtn.Click += new System.EventHandler(this.MustraBtn_Click);
            // 
            // elForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 49);
            this.Controls.Add(this.MustraBtn);
            this.Name = "elForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.elForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MustraBtn;
    }
}

