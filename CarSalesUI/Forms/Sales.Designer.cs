﻿
namespace CarSalesUI.Forms
{
    partial class Sales
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
            this.dgCars = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchBrand = new System.Windows.Forms.Label();
            this.lblSearchModel = new System.Windows.Forms.Label();
            this.lblSearchPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpSelectedCar = new System.Windows.Forms.GroupBox();
            this.btnExportSales = new System.Windows.Forms.Button();
            this.btnRemoveFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpSelectedCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCars
            // 
            this.dgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCars.Location = new System.Drawing.Point(438, 169);
            this.dgCars.Name = "dgCars";
            this.dgCars.ReadOnly = true;
            this.dgCars.Size = new System.Drawing.Size(273, 305);
            this.dgCars.TabIndex = 0;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(83, 39);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(186, 23);
            this.txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(82, 102);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(186, 23);
            this.txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(82, 169);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(186, 23);
            this.txtYear.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(82, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(186, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(11, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 23);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(195, 50);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(127, 23);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(378, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(127, 23);
            this.textBox7.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(591, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchBrand
            // 
            this.lblSearchBrand.AutoSize = true;
            this.lblSearchBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchBrand.Location = new System.Drawing.Point(9, 25);
            this.lblSearchBrand.Name = "lblSearchBrand";
            this.lblSearchBrand.Size = new System.Drawing.Size(45, 16);
            this.lblSearchBrand.TabIndex = 9;
            this.lblSearchBrand.Text = "Brand";
            // 
            // lblSearchModel
            // 
            this.lblSearchModel.AutoSize = true;
            this.lblSearchModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchModel.Location = new System.Drawing.Point(193, 25);
            this.lblSearchModel.Name = "lblSearchModel";
            this.lblSearchModel.Size = new System.Drawing.Size(46, 16);
            this.lblSearchModel.TabIndex = 10;
            this.lblSearchModel.Text = "Model";
            // 
            // lblSearchPrice
            // 
            this.lblSearchPrice.AutoSize = true;
            this.lblSearchPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchPrice.Location = new System.Drawing.Point(381, 25);
            this.lblSearchPrice.Name = "lblSearchPrice";
            this.lblSearchPrice.Size = new System.Drawing.Size(40, 16);
            this.lblSearchPrice.TabIndex = 11;
            this.lblSearchPrice.Tag = "";
            this.lblSearchPrice.Text = "Price";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(19, 42);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 16);
            this.lblBrand.TabIndex = 12;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModel.Location = new System.Drawing.Point(19, 105);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 13;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYear.Location = new System.Drawing.Point(19, 172);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 16);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(19, 243);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(28, 491);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(88, 37);
            this.btnSell.TabIndex = 16;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvailableCars.Location = new System.Drawing.Point(435, 141);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(100, 16);
            this.lblAvailableCars.TabIndex = 17;
            this.lblAvailableCars.Text = "Available Cars";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnRemoveFilters);
            this.grpSearch.Controls.Add(this.textBox7);
            this.grpSearch.Controls.Add(this.textBox5);
            this.grpSearch.Controls.Add(this.textBox6);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSearchBrand);
            this.grpSearch.Controls.Add(this.lblSearchModel);
            this.grpSearch.Controls.Add(this.lblSearchPrice);
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSearch.Location = new System.Drawing.Point(28, 37);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(702, 90);
            this.grpSearch.TabIndex = 18;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Cars";
            // 
            // grpSelectedCar
            // 
            this.grpSelectedCar.Controls.Add(this.txtYear);
            this.grpSelectedCar.Controls.Add(this.txtBrand);
            this.grpSelectedCar.Controls.Add(this.txtModel);
            this.grpSelectedCar.Controls.Add(this.txtPrice);
            this.grpSelectedCar.Controls.Add(this.lblPrice);
            this.grpSelectedCar.Controls.Add(this.lblBrand);
            this.grpSelectedCar.Controls.Add(this.lblYear);
            this.grpSelectedCar.Controls.Add(this.lblModel);
            this.grpSelectedCar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSelectedCar.Location = new System.Drawing.Point(28, 155);
            this.grpSelectedCar.Name = "grpSelectedCar";
            this.grpSelectedCar.Size = new System.Drawing.Size(312, 305);
            this.grpSelectedCar.TabIndex = 19;
            this.grpSelectedCar.TabStop = false;
            this.grpSelectedCar.Text = "Selected Car";
            // 
            // btnExportSales
            // 
            this.btnExportSales.Location = new System.Drawing.Point(619, 491);
            this.btnExportSales.Name = "btnExportSales";
            this.btnExportSales.Size = new System.Drawing.Size(122, 37);
            this.btnExportSales.TabIndex = 20;
            this.btnExportSales.Text = "Export Sales";
            this.btnExportSales.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFilters
            // 
            this.btnRemoveFilters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveFilters.Location = new System.Drawing.Point(545, 20);
            this.btnRemoveFilters.Name = "btnRemoveFilters";
            this.btnRemoveFilters.Size = new System.Drawing.Size(138, 24);
            this.btnRemoveFilters.TabIndex = 21;
            this.btnRemoveFilters.Text = "Remove Filters";
            this.btnRemoveFilters.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(753, 573);
            this.Controls.Add(this.btnExportSales);
            this.Controls.Add(this.grpSelectedCar);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblAvailableCars);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.dgCars);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dgCars)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSelectedCar.ResumeLayout(false);
            this.grpSelectedCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCars;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.Label lblSearchModel;
        private System.Windows.Forms.Label lblSearchPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpSelectedCar;
        private System.Windows.Forms.Button btnExportSales;
        private System.Windows.Forms.Button btnRemoveFilters;
    }
}