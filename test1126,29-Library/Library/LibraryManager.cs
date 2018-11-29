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
    public partial class LibraryManager : Form
    {
        public LibraryManager()
        {
            InitializeComponent();
            Text = "도서관 관리";

            //라벨 설정
            lblBookCount_Total2.Text = DataManager.Books.Count.ToString();
            lblUserCount2.Text = DataManager.Users.Count.ToString();
            lblBookCount_Borrowed2.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            lblBookCount_Overdue2.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now && x.BorrowedAt!=new DateTime(0000-00-00);
            }).Count().ToString();
            //데이터 그리드 설정
            dataGridViewBook.DataSource = DataManager.Books;
            dataGridViewUser.DataSource = DataManager.Users;
            dataGridViewBook.CurrentCellChanged += DataGridViewBook_CurrentCellChanged;
            dataGridViewUser.CurrentCellChanged += DataGridViewUser_CurrentCellChanged;
        }
        private void DataGridViewBook_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridViewBook.CurrentRow.DataBoundItem as Book;
                tbxIsbn.Text = book.Isbn;
                tbxBookName.Text = book.Name;
            }
            catch (Exception exception) { }
        }

        private void DataGridViewUser_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                User user = dataGridViewUser.CurrentRow.DataBoundItem as User;
                tbxUserId.Text = user.Id.ToString();
            }
            catch (Exception exception) { }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookForm().ShowDialog();
            dataGridViewBook.DataSource = DataManager.Books;
            lblBookCount_Total2.Text = DataManager.Books.Count.ToString();
            lblBookCount_Borrowed2.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            lblBookCount_Overdue2.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now && x.BorrowedAt != new DateTime(0000 - 00 - 00);
            }).Count().ToString();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
            dataGridViewUser.DataSource = DataManager.Users;
            lblUserCount2.Text = DataManager.Users.Count.ToString();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            if (tbxIsbn.Text.Trim() == "")
            {
                MessageBox.Show("ISBN을 입력해주세요");
            }
            else if (tbxUserId.Text.Trim() == "")
            {
                MessageBox.Show("사용자 ID를 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == tbxIsbn.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == tbxUserId.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Today;

                        dataGridViewBook.DataSource = null;
                        dataGridViewBook.DataSource = DataManager.Books;
                        DataManager.Save();
                        MessageBox.Show("\"" + book.Name + "\"이/가 \"" + user.Name + "\"님께 대여되었습니다.");
                        lblBookCount_Borrowed2.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자 입니다.");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (tbxIsbn.Text.Trim() == "")
            {
                MessageBox.Show("ISBN을 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == tbxIsbn.Text);
                    if (book.isBorrowed)
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        DateTime dt = book.BorrowedAt;
                        book.BorrowedAt = new DateTime();
                        dataGridViewBook.DataSource = null;
                        dataGridViewBook.DataSource = DataManager.Books;
                        DataManager.Save();

                        if ( dt.AddDays(7) < DateTime.Now)
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                        }
                        lblBookCount_Borrowed2.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
                        lblBookCount_Overdue2.Text = DataManager.Books.Where((x) =>
                        {
                            return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now && x.BorrowedAt != new DateTime(0000 - 00 - 00);
                        }).Count().ToString();
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxIsbn.Text = "";
            tbxBookName.Text = "";
            tbxUserId.Text = "";
        }
    }
}
