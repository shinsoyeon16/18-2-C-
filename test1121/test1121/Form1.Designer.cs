namespace test1121
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstTxt = new System.Windows.Forms.TextBox();
            this.LastTxt = new System.Windows.Forms.TextBox();
            this.LastLable = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLable = new System.Windows.Forms.Label();
            this.HomeTxt = new System.Windows.Forms.TextBox();
            this.WorkTxt = new System.Windows.Forms.TextBox();
            this.WorkLable = new System.Windows.Forms.Label();
            this.FirstLable = new System.Windows.Forms.Label();
            this.HomeLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(660, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(680, 95);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(55, 27);
            this.select.TabIndex = 1;
            this.select.Text = "조회";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(739, 95);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(49, 27);
            this.insert.TabIndex = 2;
            this.insert.Text = "추가";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 3;
            // 
            // FirstTxt
            // 
            this.FirstTxt.Location = new System.Drawing.Point(96, 5);
            this.FirstTxt.Name = "FirstTxt";
            this.FirstTxt.Size = new System.Drawing.Size(145, 21);
            this.FirstTxt.TabIndex = 4;
            // 
            // LastTxt
            // 
            this.LastTxt.Location = new System.Drawing.Point(96, 31);
            this.LastTxt.Name = "LastTxt";
            this.LastTxt.Size = new System.Drawing.Size(145, 21);
            this.LastTxt.TabIndex = 6;
            // 
            // LastLable
            // 
            this.LastLable.AutoSize = true;
            this.LastLable.Location = new System.Drawing.Point(23, 36);
            this.LastLable.Name = "LastLable";
            this.LastLable.Size = new System.Drawing.Size(67, 12);
            this.LastLable.TabIndex = 5;
            this.LastLable.Text = "Last Name";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(96, 58);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(204, 21);
            this.EmailTxt.TabIndex = 8;
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(23, 63);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(37, 12);
            this.EmailLable.TabIndex = 7;
            this.EmailLable.Text = "Email";
            // 
            // HomeTxt
            // 
            this.HomeTxt.Location = new System.Drawing.Point(460, 6);
            this.HomeTxt.Name = "HomeTxt";
            this.HomeTxt.Size = new System.Drawing.Size(286, 21);
            this.HomeTxt.TabIndex = 10;
            // 
            // WorkTxt
            // 
            this.WorkTxt.Location = new System.Drawing.Point(460, 31);
            this.WorkTxt.Name = "WorkTxt";
            this.WorkTxt.Size = new System.Drawing.Size(286, 21);
            this.WorkTxt.TabIndex = 12;
            // 
            // WorkLable
            // 
            this.WorkLable.AutoSize = true;
            this.WorkLable.Location = new System.Drawing.Point(366, 32);
            this.WorkLable.Name = "WorkLable";
            this.WorkLable.Size = new System.Drawing.Size(83, 12);
            this.WorkLable.TabIndex = 11;
            this.WorkLable.Text = "Work Address";
            this.WorkLable.Click += new System.EventHandler(this.WorkLable_Click);
            // 
            // FirstLable
            // 
            this.FirstLable.AutoSize = true;
            this.FirstLable.Location = new System.Drawing.Point(23, 9);
            this.FirstLable.Name = "FirstLable";
            this.FirstLable.Size = new System.Drawing.Size(67, 12);
            this.FirstLable.TabIndex = 13;
            this.FirstLable.Text = "First Name";
            // 
            // HomeLable
            // 
            this.HomeLable.AutoSize = true;
            this.HomeLable.Location = new System.Drawing.Point(365, 10);
            this.HomeLable.Name = "HomeLable";
            this.HomeLable.Size = new System.Drawing.Size(89, 12);
            this.HomeLable.TabIndex = 14;
            this.HomeLable.Text = "Home Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeLable);
            this.Controls.Add(this.FirstLable);
            this.Controls.Add(this.WorkTxt);
            this.Controls.Add(this.WorkLable);
            this.Controls.Add(this.HomeTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.LastTxt);
            this.Controls.Add(this.LastLable);
            this.Controls.Add(this.FirstTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.select);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstTxt;
        private System.Windows.Forms.TextBox LastTxt;
        private System.Windows.Forms.Label LastLable;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.TextBox HomeTxt;
        private System.Windows.Forms.TextBox WorkTxt;
        private System.Windows.Forms.Label WorkLable;
        private System.Windows.Forms.Label FirstLable;
        private System.Windows.Forms.Label HomeLable;
    }
}

