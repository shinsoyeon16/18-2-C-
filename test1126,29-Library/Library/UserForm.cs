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
            //데이터 그리드 설정
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

        private bool isValidId(User user) //중복 ID 생성을 방지하기위한 함수
        { // 저는 아무리해도 필드만 검색하는 내장함수를 못찾겠어요ㅠㅠ
            int a = -1; //-1은 없는 ID라고 가정.. 
            a = DataManager.Users.FindIndex(x => x.Id == user.Id);
            return a == -1;
            throw new NotImplementedException();
        }

        private void Add(User user)
        {
            if (isValidId(user))
            {
                DataManager.Users.Add(user);
                DataManager.Save();
            }
            else MessageBox.Show("중복된 ID가 있습니다.");
        }

        private void Update(User user, int defaultId)
        {
            if (isValidId(user)||user.Id==defaultId)
            {
                DataManager.Users[DataManager.Users.FindIndex(x => x.Id == defaultId)].Name = user.Name;
                DataManager.Users[DataManager.Users.FindIndex(x => x.Id == defaultId)].Id = user.Id;
                DataManager.Save();
            }
            else MessageBox.Show("중복된 ID가 있습니다.");
        }
        private void Delete(int a)
        {
            DataManager.Users.RemoveAt(DataManager.Users.FindIndex(x => x.Id == a));
            DataManager.Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Id = int.Parse(tbxUserId.Text);
                user.Name = tbxUserName.Text;
                Add(user);
                dataGridViewUser.DataSource = DataManager.Users;
            }
            catch (Exception exception)
            {
                MessageBox.Show("사용자 추가에 실패하였습니다.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Id = int.Parse(tbxUserId.Text);
                user.Name = tbxUserName.Text;
                User defaultUser = dataGridViewUser.CurrentRow.DataBoundItem as User;
                Update(user, defaultUser.Id);
                dataGridViewUser.DataSource = DataManager.Users;
            }
            catch (Exception exception)
            {
                MessageBox.Show("사용자 수정에 실패하였습니다.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete(int.Parse(tbxUserId.Text));
                dataGridViewUser.DataSource = DataManager.Users;
            }
            catch (Exception exception)
            {
                MessageBox.Show("사용자 삭제에 실패하였습니다.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxUserId.Text = "";
            tbxUserName.Text = "";
        }
    }
}
