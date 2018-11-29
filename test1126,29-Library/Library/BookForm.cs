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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            //데이터 그리드 설정
            dataGridViewBook.DataSource = DataManager.Books;
            dataGridViewBook.CurrentCellChanged += DataGridViewBook_CurrentCellChanged;
        }
        private void DataGridViewBook_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridViewBook.CurrentRow.DataBoundItem as Book;
                tbxIsbn.Text = book.Isbn;
                tbxBookName.Text = book.Name;
                tbxPublisher.Text = book.Publisher;
                tbxPage.Text = book.Page.ToString();
            }
            catch (Exception exception) { }
        }
    }
}
