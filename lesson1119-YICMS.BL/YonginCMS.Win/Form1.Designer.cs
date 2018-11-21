namespace YonginCMS.Win
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
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.GetCustomerListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(12, 12);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.RowTemplate.Height = 23;
            this.CustomerGrid.Size = new System.Drawing.Size(342, 393);
            this.CustomerGrid.TabIndex = 0;
            this.CustomerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GetCustomerListButton
            // 
            this.GetCustomerListButton.Location = new System.Drawing.Point(366, 14);
            this.GetCustomerListButton.Name = "GetCustomerListButton";
            this.GetCustomerListButton.Size = new System.Drawing.Size(111, 150);
            this.GetCustomerListButton.TabIndex = 1;
            this.GetCustomerListButton.Text = "Get Customer";
            this.GetCustomerListButton.UseVisualStyleBackColor = true;
            this.GetCustomerListButton.Click += new System.EventHandler(this.GetCustomerListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetCustomerListButton);
            this.Controls.Add(this.CustomerGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Button GetCustomerListButton;
    }
}

