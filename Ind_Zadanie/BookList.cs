using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)  //переход обратно в меню читателя/сотрудника, в зависимости кто был авторизован
        {
            if (Starter.admin == true)
            {
                this.Hide();
                Menu_Admin f11 = new Menu_Admin();
                f11.ShowDialog();
            }
            else
            {
                this.Hide();
                Menu_Reader f12 = new Menu_Reader();
                f12.ShowDialog();
            }
        }

        private void BookList_Load(object sender, EventArgs e)   //missclick((
        {

        }   
        List<Book> bk = new List<Book>();
        List<Reader> rd = new List<Reader>();
        private bool doner;  //поле, отслеживающее успешность выполнения поиска
        private void Namesearch_button_Click(object sender, EventArgs e) //метод производит поиск книг по названию
        {
            bk.Clear();
            rd.Clear();
            doner = false;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    List<Book> bks = (List<Book>)binaryFormatter.Deserialize(fileStream_object);
                    bk.AddRange(bks);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            foreach(Book book in bk)
            {
                string Name = book.getbookname();
                if (Name == Name_textBox.Text) //поиск пока примитивен, и требует полного соответствия названия при запросе
                {
                    listBox1.Items.Add(book);
                    doner = true;
                }
            }
            if (doner != true)
            {
                MessageBox.Show("Книг с данным названием не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Author_button_Click(object sender, EventArgs e) //метод производит поиск книг по автору
        {
            bk.Clear();
            rd.Clear();
            doner = false;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    List<Book> bks = (List<Book>)binaryFormatter.Deserialize(fileStream_object);
                    bk.AddRange(bks);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            foreach (Book book in bk)
            {
                string Auth = book.getbookauth();
                if (Auth == Author_textBox.Text)  //поиск пока примитивен, и требует полного соответствия автора при запросе
                {
                    listBox1.Items.Add(book);
                    doner = true;
                }
            }
            if (doner != true)
            {
                MessageBox.Show("Книг с данным автором не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BookID_button_Click(object sender, EventArgs e)  //метод производит поиск книги по ее id, а также показывает ее описание и очередь читателей на нее, при наличии
        {
            bk.Clear();
            rd.Clear();
            doner = false;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    List<Book> bks = (List<Book>)binaryFormatter.Deserialize(fileStream_object);
                    bk.AddRange(bks);
                }
                using (FileStream fileStream_object2 = new FileStream("ListRead.txt", FileMode.OpenOrCreate))
                {
                    List<Reader> r2d2 = (List<Reader>)binaryFormatter.Deserialize(fileStream_object2);
                    rd.AddRange(r2d2);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            foreach (Book book in bk)
            {
                int bid = book.getbookid();
                int[] queueid;
                if (bid == Convert.ToInt32(bookID_textBox.Text))
                {
                    listBox1.Items.Add(book);
                    listBox1.Items.Add("Описание книги:");
                    listBox1.Items.Add(book.getdesc());
                    doner = true;
                    queueid = book.Getqueue();
                    if (queueid != null)
                    {
                        listBox1.Items.Add($"В очереди на книгу {book.queuecount()} человек(а):");
                        foreach (int rdr in queueid)
                        {
                            foreach (Reader reader in rd)
                            {
                                if (rdr == reader.GetID())
                                {
                                    listBox1.Items.Add(reader);
                                }
                            }
                        }
                    }
                }
            }
            if (doner != true)
            {
                MessageBox.Show("Книг с данным id не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Showall_button_Click(object sender, EventArgs e)
        {
            bk.Clear();
            listBox1.Items.Clear();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    List<Book> bks = (List<Book>)binaryFormatter.Deserialize(fileStream_object);
                    bk.AddRange(bks);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных, вероятно база пуста.", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listBox1.Items.AddRange(bk.ToArray());
        }
    }
}
