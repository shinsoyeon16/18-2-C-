using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            dataGridViewUser.DataSource = DataManager.Users;
            dataGridViewUser.CurrentCellChanged += DataGridViewUser_CurrentCellChanged;
        }
        private void DataGridViewUser_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                User user = dataGridViewUser.CurrentRow.DataBoundItem as User;
                tbxUserId.Text = user.Id.ToString();
                tbxUserName.Text = user.Name.ToString();
            }
            catch (Exception exception) { }
        }


        private void Add(User user)
        {
            DataManager.Users.Add(user);
            DataManager.Save();
            MessageBox.Show("사용자 추가에 성공!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Id = int.Parse(tbxUserId.Text);
                user.Name = tbxUserName.Text;
                Add(user);
            }
            catch (Exception exception)
            {
                MessageBox.Show("사용자 추가에 실패하였습니다.");
            }
        }
    }
}
