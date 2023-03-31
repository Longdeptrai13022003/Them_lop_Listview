namespace Them_lop_hoc
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstvInfor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(286, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm lớp học";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(79, 188);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 26);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Tên lớp:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(79, 243);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(193, 26);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Số lượng sinh viên:";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(190, 180);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(384, 34);
            this.txtClass.TabIndex = 3;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(293, 235);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(281, 34);
            this.txtCount.TabIndex = 4;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(616, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 89);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstvInfor
            // 
            this.lstvInfor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvInfor.GridLines = true;
            this.lstvInfor.HideSelection = false;
            this.lstvInfor.Location = new System.Drawing.Point(84, 281);
            this.lstvInfor.Name = "lstvInfor";
            this.lstvInfor.Size = new System.Drawing.Size(635, 274);
            this.lstvInfor.TabIndex = 6;
            this.lstvInfor.UseCompatibleStateImageBehavior = false;
            this.lstvInfor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Lớp";
            this.columnHeader1.Width = 292;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng sinh viên";
            this.columnHeader2.Width = 571;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 567);
            this.Controls.Add(this.lstvInfor);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lstvInfor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

