
namespace CarSalesUI.Forms
{
    partial class Settings
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
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.btnClearDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.FlatAppearance.BorderSize = 0;
            this.btnImportCSV.Location = new System.Drawing.Point(120, 119);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(101, 38);
            this.btnImportCSV.TabIndex = 0;
            this.btnImportCSV.Text = "Import CSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);
            // 
            // btnClearDb
            // 
            this.btnClearDb.FlatAppearance.BorderSize = 0;
            this.btnClearDb.Location = new System.Drawing.Point(317, 119);
            this.btnClearDb.Name = "btnClearDb";
            this.btnClearDb.Size = new System.Drawing.Size(144, 38);
            this.btnClearDb.TabIndex = 1;
            this.btnClearDb.Text = "Clear Database";
            this.btnClearDb.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(568, 267);
            this.Controls.Add(this.btnClearDb);
            this.Controls.Add(this.btnImportCSV);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.Button btnClearDb;
    }
}