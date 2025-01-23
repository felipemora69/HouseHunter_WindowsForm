namespace HouseHunterLesson2
{
    partial class Form1
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
            this.MainList = new System.Windows.Forms.ListView();
            this.h1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_GetData = new System.Windows.Forms.Button();
            this.text_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_FilterTyper = new System.Windows.Forms.ComboBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainList
            // 
            this.MainList.BackColor = System.Drawing.Color.Peru;
            this.MainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.h1,
            this.h2,
            this.h3,
            this.h4});
            this.MainList.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainList.GridLines = true;
            this.MainList.HideSelection = false;
            this.MainList.Location = new System.Drawing.Point(34, 15);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(563, 275);
            this.MainList.TabIndex = 0;
            this.MainList.UseCompatibleStateImageBehavior = false;
            this.MainList.View = System.Windows.Forms.View.Details;
            this.MainList.Click += new System.EventHandler(this.MainList_Click);
            // 
            // h1
            // 
            this.h1.Text = "Id";
            // 
            // h2
            // 
            this.h2.Text = "Address";
            this.h2.Width = 122;
            // 
            // h3
            // 
            this.h3.Text = "Postal Code";
            this.h3.Width = 160;
            // 
            // h4
            // 
            this.h4.Text = "List Price";
            this.h4.Width = 89;
            // 
            // btn_GetData
            // 
            this.btn_GetData.BackColor = System.Drawing.Color.Peru;
            this.btn_GetData.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetData.ForeColor = System.Drawing.Color.White;
            this.btn_GetData.Location = new System.Drawing.Point(603, 15);
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Size = new System.Drawing.Size(87, 45);
            this.btn_GetData.TabIndex = 1;
            this.btn_GetData.Text = "Get Data";
            this.btn_GetData.UseVisualStyleBackColor = false;
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_Click);
            // 
            // text_Input
            // 
            this.text_Input.Location = new System.Drawing.Point(66, 316);
            this.text_Input.Name = "text_Input";
            this.text_Input.Size = new System.Drawing.Size(100, 22);
            this.text_Input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // cb_FilterTyper
            // 
            this.cb_FilterTyper.BackColor = System.Drawing.Color.Peru;
            this.cb_FilterTyper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterTyper.FormattingEnabled = true;
            this.cb_FilterTyper.Items.AddRange(new object[] {
            "Id",
            "Address",
            "Postal Code",
            "List Price"});
            this.cb_FilterTyper.Location = new System.Drawing.Point(172, 316);
            this.cb_FilterTyper.Name = "cb_FilterTyper";
            this.cb_FilterTyper.Size = new System.Drawing.Size(121, 22);
            this.cb_FilterTyper.TabIndex = 4;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.Peru;
            this.btn_Filter.Location = new System.Drawing.Point(299, 314);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 25);
            this.btn_Filter.TabIndex = 5;
            this.btn_Filter.Text = "OK";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.cb_FilterTyper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Input);
            this.Controls.Add(this.btn_GetData);
            this.Controls.Add(this.MainList);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MainList;
        private System.Windows.Forms.ColumnHeader h1;
        private System.Windows.Forms.ColumnHeader h2;
        private System.Windows.Forms.ColumnHeader h3;
        private System.Windows.Forms.ColumnHeader h4;
        private System.Windows.Forms.Button btn_GetData;
        private System.Windows.Forms.TextBox text_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_FilterTyper;
        private System.Windows.Forms.Button btn_Filter;
    }
}

