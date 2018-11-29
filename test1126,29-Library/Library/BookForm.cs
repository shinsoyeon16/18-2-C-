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

        private bool isValidIsbn(Book book) //중복 ISBN 생성을 방지하기위한 함수
        {
            int a = -1; //-1은 없는 Isbn이라고 가정..
            a = DataManager.Books.FindIndex(x => x.Isbn == book.Isbn);
            return a == -1;
            throw new NotImplementedException();
        }
        private void Add(Book book)
        {
            if (isValidIsbn(book))
            {
                DataManager.Books.Add(book);
                DataManager.Save();
            }
            else MessageBox.Show("중복된 ISBN 코드가 있습니다.");
        }
        private void Update(Book book, string defaultIsbn)
        {
            if (isValidIsbn(book)||book.Isbn==defaultIsbn)
            {
                DataManager.Books[DataManager.Books.FindIndex(x => x.Isbn == defaultIsbn)] = book;
                DataManager.Save();
            }
            else MessageBox.Show("중복된 ISBN 코드가 있습니다.");
        }
        private void Delete(string isbn)
        {
            DataManager.Books.RemoveAt(DataManager.Books.FindIndex(x => x.Isbn == isbn));
            DataManager.Save();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Isbn = tbxIsbn.Text;
                book.Name = tbxBookName.Text;
                book.Publisher = tbxPublisher.Text;
                book.Page = int.Parse(tbxPage.Text.ToString());
                Add(book);
                dataGridViewBook.DataSource = DataManager.Books;
            }
            catch (Exception exception)
            {
                MessageBox.Show("도서 추가에 실패하였습니다.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Isbn = tbxIsbn.Text;
                book.Name = tbxBookName.Text;
                book.Publisher = tbxPublisher.Text;
                book.Page = int.Parse(tbxPage.Text.ToString());
                Book defaultBook = dataGridViewBook.CurrentRow.DataBoundItem as Book;
                Update(book, defaultBook.Isbn);
                dataGridViewBook.DataSource = DataManager.Books;
            }
            catch (Exception exception)
            {
                MessageBox.Show("도서 수정에 실패하였습니다.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete(tbxIsbn.Text);
                dataGridViewBook.DataSource = DataManager.Books;
            }
            catch (Exception exception)
            {
                MessageBox.Show("도서 삭제에 실패하였습니다.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxIsbn.Text = "";
            tbxBookName.Text = "";
            tbxPublisher.Text = "";
            tbxPage.Text = "";
        }
    }
}
