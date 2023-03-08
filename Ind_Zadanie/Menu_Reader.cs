using System;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class Menu_Reader : Form
    {
        public Menu_Reader()
        {
            InitializeComponent();
        }

        private void BookList_button_Click(object sender, EventArgs e) //переход к просмотру списка книг и поиску.
        {
            this.Hide();
            BookList f6 = new BookList();
            f6.ShowDialog();
        }

        private void Seach_button_Click(object sender, EventArgs e) //было решено отказаться от отдельной формы поиска, и совместить функционал с формой списка книг.
        {      //Данный метод не удалялся, дабы не "поломать" код в конструкторе форм. 
           
        }

        private void Book_demand_button_Click(object sender, EventArgs e) //переход к форме оставления заявки на книгу.
        {
            this.Hide();
            Demand f10 = new Demand();
            f10.ShowDialog();
        }

        private void Menu_Reader_Load(object sender, EventArgs e)
        {

        }
    }
}
