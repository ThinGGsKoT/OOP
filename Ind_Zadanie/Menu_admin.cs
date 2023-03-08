using System;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void Add_Reader_button_Click(object sender, EventArgs e)  //переход к форме добавления/изменения читателя
        {
            this.Hide();
            AddReader f4 = new AddReader();
            f4.ShowDialog();
        }

        private void Add_book_button_Click(object sender, EventArgs e) //переход к форме добавления/изменения книги
        {
            this.Hide();
            AddBook f5 = new AddBook();
            f5.ShowDialog();
        }

        private void Issuance_button_Click(object sender, EventArgs e)  //переход к форме выдаче/приему книг.
        {
            this.Hide();
            Issuance f8 = new Issuance();
            f8.ShowDialog();
        }

        private void BookList_button_Click(object sender, EventArgs e) //переход к просмотру списка книг и поиску.
        {
            this.Hide();
            BookList f6 = new BookList();
            f6.ShowDialog();
        }

        private void Search_button_Click(object sender, EventArgs e) //было решено отказаться от отдельной формы поиска, и совместить функционал с формой списка книг.
        {  //Данный метод не удалялся, дабы не "поломать" код в конструкторе форм.


        }

        private void ShowDemand_button_Click(object sender, EventArgs e) //переход к форме просмотра заявок на книги.
        {
            this.Hide();
            ShowDemand f9 = new ShowDemand();
            f9.ShowDialog();
        }
    }
}
