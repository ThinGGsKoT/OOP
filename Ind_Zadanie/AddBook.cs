using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        } //missclick((

        private void AddBook_Load(object sender, EventArgs e)
        {

        } //missclick((

        private void Back_button_Click(object sender, EventArgs e) //переход обратно в меню читателя/сотрудника, в зависимости кто был авторизован
        {
            this.Hide();
            Menu_Admin f2 = new Menu_Admin();
            f2.ShowDialog();
        }
        Book book = null;
        List<Book> bk = null; //коллекция представляет собой локальное хранилище экземпляров класса книг
        List<Reader> rd = null;  //коллекция представляет собой локальное хранилище экземпляров класса читателя
        private bool doner; //поле, отслеживающее успешность выполнения поиска
        private void AddBook_button_Click(object sender, EventArgs e)  //метод добавляет книгу в базу
        {
            doner = false;
            if (NameBooktextBox.Text != "" && Author_textBox.Text != "" && PublicCode_textBox.Text != "" && Description_textBox.Text != "")
            {
                book = new Book(NameBooktextBox.Text, Author_textBox.Text, PublicCode_textBox.Text, Description_textBox.Text);
                BookID_textBox.Text = book.getbookid().ToString();
                bk.Add(book);
                doner = true;
                
            }
            else if (NameBooktextBox.Text != "" && Author_textBox.Text != "" && PublicCode_textBox.Text != "")
            {
                book = new Book(NameBooktextBox.Text, Author_textBox.Text, PublicCode_textBox.Text);
                BookID_textBox.Text = book.getbookid().ToString();
                bk.Add(book);
                doner = true;
            }
            else
            {
                MessageBox.Show("Некорректно введенные данные");
            }
            if (doner == true)
            {
                NameBooktextBox.Clear();
                Author_textBox.Clear();
                PublicCode_textBox.Clear();
                Description_textBox.Clear();
            }
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, bk);
                MessageBox.Show($"Книга успешно добавлена. ID книги: {book.getbookid()}");
            }
        }

        private void ChangeBook_button_Click(object sender, EventArgs e) //метод редактирует поля книги по ее id, причем только те поля, которые были заполнены в форме.
        {
            bk.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
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
                int id = book.getbookid();
                if (id == Convert.ToInt32(BookID_textBox))
                {
                    if (NameBooktextBox.Text != "")
                    {
                        book.booknamechange(NameBooktextBox.Text);
                    }
                    if (Author_textBox.Text != "")
                    {
                        book.bookauthchange((Author_textBox.Text));
                    }
                    if (PublicCode_textBox.Text != "")
                    {
                        book.bookcodechange(PublicCode_textBox.Text);
                    }
                    if (Description_textBox.Text != "")
                    {
                        book.bookdescchange(Description_textBox.Text);
                    }
                    listBox1.Items.Add(book);
                }
                
            }
            using (FileStream fileStream = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, bk);
            }
            NameBooktextBox.Clear();
            Author_textBox.Clear();
            PublicCode_textBox.Clear();
            Description_textBox.Clear();
        }
        private int[] queueid;  //локальная последовательность очереди читателей
        private void Status_Button_Click(object sender, EventArgs e)  //метод выводит статус книги, ее описание и спикок очереди на нее в отдельное поле
        {
            bk.Clear(); rd.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
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
                int id = book.getbookid();
                if (id == Convert.ToInt32(BookID_textBox))
                {
                    listBox1.Items.Add(book);
                    listBox2.Items.Add("Описание книги:");
                    listBox2.Items.Add(book.getdesc());
                    queueid = book.Getqueue();
                    if (queueid != null)
                    {
                        listBox1.Items.Add($"В очереди на книгу {book.queuecount()} человек(а):");
                        foreach (int rdr in queueid)
                        {
                            foreach (Reader reader in rd)
                            {
                                if(rdr == reader.GetID())
                                {
                                    listBox2.Items.Add(reader);
                                }
                            }
                        }
                    }
                    
                }
            }
                
        }
    }
}
