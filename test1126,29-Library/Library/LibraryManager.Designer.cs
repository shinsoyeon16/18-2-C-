namespace Library
{
    partial class LibraryManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBookCount_Overdue2 = new System.Windows.Forms.Label();
            this.lblBookCount_Borrowed2 = new System.Windows.Forms.Label();
            this.lblUserCount2 = new System.Windows.Forms.Label();
            this.lblBookCount_Total2 = new System.Windows.Forms.Label();
            this.lblBookCount_Overdue = new System.Windows.Forms.Label();
            this.lblBookCount_Borrowed = new System.Windows.Forms.Label();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.lblBookCount_Total = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxUserId = new System.Windows.Forms.TextBox();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBookCount_Overdue2);
            this.groupBox1.Controls.Add(this.lblBookCount_Borrowed2);
            this.groupBox1.Controls.Add(this.lblUserCount2);
            this.groupBox1.Controls.Add(this.lblBookCount_Total2);
            this.groupBox1.Controls.Add(this.lblBookCount_Overdue);
            this.groupBox1.Controls.Add(this.lblBookCount_Borrowed);
            this.groupBox1.Controls.Add(this.lblUserCount);
            this.groupBox1.Controls.Add(this.lblBookCount_Total);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관 현황";
            // 
            // lblBookCount_Overdue2
            // 
            this.lblBookCount_Overdue2.AutoSize = true;
            this.lblBookCount_Overdue2.Location = new System.Drawing.Point(142, 98);
            this.lblBookCount_Overdue2.Name = "lblBookCount_Overdue2";
            this.lblBookCount_Overdue2.Size = new System.Drawing.Size(0, 12);
            this.lblBookCount_Overdue2.TabIndex = 7;
            // 
            // lblBookCount_Borrowed2
            // 
            this.lblBookCount_Borrowed2.AutoSize = true;
            this.lblBookCount_Borrowed2.Location = new System.Drawing.Point(142, 72);
            this.lblBookCount_Borrowed2.Name = "lblBookCount_Borrowed2";
            this.lblBookCount_Borrowed2.Size = new System.Drawing.Size(0, 12);
            this.lblBookCount_Borrowed2.TabIndex = 6;
            // 
            // lblUserCount2
            // 
            this.lblUserCount2.AutoSize = true;
            this.lblUserCount2.Location = new System.Drawing.Point(85, 44);
            this.lblUserCount2.Name = "lblUserCount2";
            this.lblUserCount2.Size = new System.Drawing.Size(0, 12);
            this.lblUserCount2.TabIndex = 5;
            // 
            // lblBookCount_Total2
            // 
            this.lblBookCount_Total2.AutoSize = true;
            this.lblBookCount_Total2.Location = new System.Drawing.Point(102, 20);
            this.lblBookCount_Total2.Name = "lblBookCount_Total2";
            this.lblBookCount_Total2.Size = new System.Drawing.Size(0, 12);
            this.lblBookCount_Total2.TabIndex = 4;
            // 
            // lblBookCount_Overdue
            // 
            this.lblBookCount_Overdue.AutoSize = true;
            this.lblBookCount_Overdue.Location = new System.Drawing.Point(11, 98);
            this.lblBookCount_Overdue.Name = "lblBookCount_Overdue";
            this.lblBookCount_Overdue.Size = new System.Drawing.Size(125, 12);
            this.lblBookCount_Overdue.TabIndex = 3;
            this.lblBookCount_Overdue.Text = "연체 중인 도서의 수 : ";
            // 
            // lblBookCount_Borrowed
            // 
            this.lblBookCount_Borrowed.AutoSize = true;
            this.lblBookCount_Borrowed.Location = new System.Drawing.Point(11, 72);
            this.lblBookCount_Borrowed.Name = "lblBookCount_Borrowed";
            this.lblBookCount_Borrowed.Size = new System.Drawing.Size(125, 12);
            this.lblBookCount_Borrowed.TabIndex = 2;
            this.lblBookCount_Borrowed.Text = "대출 중인 도서의 수 : ";
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Location = new System.Drawing.Point(10, 44);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(69, 12);
            this.lblUserCount.TabIndex = 1;
            this.lblUserCount.Text = "사용자 수 : ";
            // 
            // lblBookCount_Total
            // 
            this.lblBookCount_Total.AutoSize = true;
            this.lblBookCount_Total.Location = new System.Drawing.Point(11, 20);
            this.lblBookCount_Total.Name = "lblBookCount_Total";
            this.lblBookCount_Total.Size = new System.Drawing.Size(85, 12);
            this.lblBookCount_Total.TabIndex = 0;
            this.lblBookCount_Total.Text = "전체 도서 수 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.tbxBookName);
            this.groupBox2.Controls.Add(this.tbxUserId);
            this.groupBox2.Controls.Add(this.tbxIsbn);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Controls.Add(this.lblUserId);
            this.groupBox2.Controls.Add(this.lblIsbn);
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnBorrow);
            this.groupBox2.Location = new System.Drawing.Point(427, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여/반납";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(260, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 26);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "모두 지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(82, 60);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(158, 21);
            this.tbxBookName.TabIndex = 6;
            // 
            // tbxUserId
            // 
            this.tbxUserId.Location = new System.Drawing.Point(82, 95);
            this.tbxUserId.Name = "tbxUserId";
            this.tbxUserId.Size = new System.Drawing.Size(158, 21);
            this.tbxUserId.TabIndex = 7;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(82, 26);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(158, 21);
            this.tbxIsbn.TabIndex = 5;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(12, 63);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(69, 12);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "도서 이름 : ";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 98);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(68, 12);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "사용자 ID : ";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(12, 31);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(45, 12);
            this.lblIsbn.TabIndex = 2;
            this.lblIsbn.Text = "ISBN : ";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(260, 55);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 26);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(260, 24);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(99, 25);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "대여";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewBook);
            this.groupBox3.Location = new System.Drawing.Point(18, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(821, 257);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowTemplate.Height = 23;
            this.dataGridViewBook.Size = new System.Drawing.Size(796, 148);
            this.dataGridViewBook.TabIndex = 0;
            this.dataGridViewBook.CurrentCellChanged += new System.EventHandler(this.DataGridViewBook_CurrentCellChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewUser);
            this.groupBox4.Location = new System.Drawing.Point(18, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(821, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 20);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowTemplate.Height = 23;
            this.dataGridViewUser.Size = new System.Drawing.Size(793, 120);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CurrentCellChanged += new System.EventHandler(this.DataGridViewUser_CurrentCellChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.도서관리ToolStripMenuItem.Text = "도서 관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // LibraryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 642);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryManager";
            this.Text = "도서관 관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBookCount_Overdue;
        private System.Windows.Forms.Label lblBookCount_Borrowed;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label lblBookCount_Total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxUserId;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.Label lblBookCount_Overdue2;
        private System.Windows.Forms.Label lblBookCount_Borrowed2;
        private System.Windows.Forms.Label lblUserCount2;
        private System.Windows.Forms.Label lblBookCount_Total2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
    }
}