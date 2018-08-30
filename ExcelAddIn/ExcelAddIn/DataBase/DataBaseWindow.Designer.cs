﻿namespace ExcelAddIn.DataBase
{
    partial class DataBaseWindow
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
            this.CbDataBaseName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTableName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbDataBaseName
            // 
            this.CbDataBaseName.FormattingEnabled = true;
            this.CbDataBaseName.Location = new System.Drawing.Point(12, 43);
            this.CbDataBaseName.Name = "CbDataBaseName";
            this.CbDataBaseName.Size = new System.Drawing.Size(163, 21);
            this.CbDataBaseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Base ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table";
            // 
            // cbTableName
            // 
            this.cbTableName.FormattingEnabled = true;
            this.cbTableName.Location = new System.Drawing.Point(12, 102);
            this.cbTableName.Name = "cbTableName";
            this.cbTableName.Size = new System.Drawing.Size(163, 21);
            this.cbTableName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Column";
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Location = new System.Drawing.Point(12, 163);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(163, 21);
            this.cbColumn.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(205, 161);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(123, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Add";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // DataBaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 206);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDataBaseName);
            this.Name = "DataBaseWindow";
            this.Text = "DataBaseWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDataBaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Button btnQuery;
    }
}