using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }
        Reader read;
        private void Label2_Click(object sender, EventArgs e)
        {

        } //missclick((

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //List<Reader> listreader = new List<Reader>();
        //listre
        private void AddReader_button_Click(object sender, EventArgs e)  //данный метод только создает экземпляры читателя. После его выполнения нужно нажать "Сохранить".
        {
            if(textBox_sName.Text != "" && textBox_fName.Text != "" && textBox_tName.Text != "" && textBox_Number.Text != "")
            {
                read = new Reader(textBox_sName.Text, textBox_fName.Text, textBox_tName.Text, dateTimePicker1.Text , textBox_Number.Text);
                textBox_ID.Text = read.GetID().ToString();
                rd.Add(read);
            }
            else if (textBox_sName.Text != "" && textBox_fName.Text != "" && textBox_tName.Text == "" && textBox_Number.Text != "")
            {
                read = new Reader(textBox_sName.Text, textBox_fName.Text, dateTimePicker1.Text, textBox_Number.Text);
                textBox_ID.Text = read.GetID().ToString();
                rd.Add(read);
            }
            else
            {
                MessageBox.Show("Некорректно введенные данные");
            }
            textBox_sName.Clear();
            textBox_fName.Clear();
            textBox_tName.Clear();
            textBox_Number.Clear();
        }
        List<Reader> rd = new List<Reader>();
        List<Book> bk = new List<Book>();

        private void ChangeReader_button_Click(object sender, EventArgs e) //Данный метод только вносит изменения в экземпляр читателя.  
        {
            foreach (Reader r2d2 in rd)                                     //Перед его использованием нужно нажать Загрузить
            {                                                               //После его использования нужно нажать Сохранить
                int id = r2d2.GetID();
                if (id == Convert.ToInt32(textBox_ID.Text))
                {
                    if (textBox_sName.Text != "")
                    {
                        r2d2.ChangeSname(textBox_sName.Text);
                    }
                    if (textBox_fName.Text != "")
                    {
                        r2d2.ChangeFname(textBox_fName.Text);
                    }
                    if (textBox_tName.Text != "")
                    {
                        r2d2.ChangeTname(textBox_tName.Text);
                    }   
                    if (textBox_Number.Text != "" )
                    {
                        r2d2.ChangeTnum(textBox_Number.Text);
                    }                  
                }
                listBox1.Items.Clear();
                listBox1.Items.AddRange(rd.ToArray());
            }
        }
        int[] keepbook;
        int[] sdbook;
        private void ReaderStatus_button_Click(object sender, EventArgs e) 
        {
            listBox1.Items.Clear(); //Метод выводит статус читателя: Строку с его информацией, а также список книг на руках и сданных, при наличии таковых.
            bk.Clear();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object3 = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    List<Book> bks = (List<Book>)binaryFormatter.Deserialize(fileStream_object3);
                    bk.AddRange(bks);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных, вероятно база пуста.", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Reader r2d2 in rd)
            {
                int id = r2d2.GetID();
                if (id == Convert.ToInt32(textBox_ID.Text))
                {
                    listBox1.Items.Add(r2d2);
                    keepbook = r2d2.ShowKbooks();
                    sdbook = r2d2.ShowSbooks();
                    if(keepbook != null)
                    {
                        listBox1.Items.Add("Книги на руках:");
                        foreach (int intk in keepbook)
                        {
                            foreach (Book book in bk)
                            {
                                if (intk == book.getbookid())
                                {
                                    listBox1.Items.Add(book);
                                }
                            }                                
                        }                                                                            
                    }
                    if (sdbook != null)
                    {
                        listBox1.Items.Add("Книги сданы:");
                        foreach (int ints in sdbook)
                        {
                            foreach (Book book in bk)
                            {
                                if (ints == book.getbookid())
                                {
                                    listBox1.Items.Add(book);
                                }
                            }
                        }
                            
                    }
                }
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            rd.Clear();
            listBox1.Items.Clear();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListRead.txt", FileMode.OpenOrCreate))
                {
                    List<Reader> r2d2 = (List<Reader>)binaryFormatter.Deserialize(fileStream_object);
                    rd.AddRange(r2d2);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных, вероятно база пуста.", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            listBox1.Items.AddRange(rd.ToArray());
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("ListRead.txt", FileMode.OpenOrCreate)) 
            {
                    binaryFormatter.Serialize(fileStream, rd);              
            }
            listBox1.Items.Clear();
        }


        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Admin f2 = new Menu_Admin();
            f2.ShowDialog();
        }
    }
}
