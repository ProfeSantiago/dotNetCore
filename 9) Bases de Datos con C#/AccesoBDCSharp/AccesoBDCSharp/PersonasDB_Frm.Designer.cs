﻿namespace AccesoBDCSharp
{
    partial class PersonasDB_Frm
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
            this.elGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.elGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // elGrid
            // 
            this.elGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elGrid.Location = new System.Drawing.Point(17, 15);
            this.elGrid.Margin = new System.Windows.Forms.Padding(4);
            this.elGrid.Name = "elGrid";
            this.elGrid.RowHeadersWidth = 51;
            this.elGrid.Size = new System.Drawing.Size(725, 209);
            this.elGrid.TabIndex = 1;
            // 
            // PersonasDB_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 239);
            this.Controls.Add(this.elGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonasDB_Frm";
            this.Text = "Acceso a BD con SQL Server";
            this.Load += new System.EventHandler(this.PersonasDB_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView elGrid;
    }
}

