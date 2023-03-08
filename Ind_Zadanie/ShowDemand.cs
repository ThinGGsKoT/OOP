using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class ShowDemand : Form
    {
        public ShowDemand()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Admin m11 = new Menu_Admin();
            m11.ShowDialog();
        }
        List<Demands> dm = new List<Demands>();
        List<Reader> rd = new List<Reader>();
        List<Book> bk = new List<Book>();
        private void Showalld_button_Click(object sender, EventArgs e)  //метод выводит в форму список всех заявок
        {
            dm.Clear();
            listBox1.Items.Clear();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            
                try
                {
                    using (FileStream fileStream_object = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
                  {
                    List<Demands> demands = (List<Demands>)binaryFormatter.Deserialize(fileStream_object);
                    dm.AddRange(demands);
                  }
                }
                catch
                {
                    MessageBox.Show("База данных пуста. Создайте и сохраните записи перед просмотром", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    listBox1.Items.AddRange(dm.ToArray());
                }
                           
            
            
        }

        private void Searchd_button_Click(object sender, EventArgs e)
        {
            dm.Clear();
            rd.Clear();
            bk.Clear();
            listBox1.Items.Clear();
            int DID = Convert.ToInt32(DID_textBox.Text);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                using (FileStream fileStream_object = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
                {
                    List<Demands> demands = (List<Demands>)binaryFormatter.Deserialize(fileStream_object);
                    dm.AddRange(demands);
                }
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
            
            foreach (Demands demands1 in dm)
            {
                if (DID == demands1.GetDID())
                {
                    listBox1.Items.Add(demands1);
                    int RID = demands1.RIDreturn();
                    int BID = demands1.BIDreturn();
                    foreach (Reader reader in rd)
                    {
                        if (reader.GetID() == RID)
                        {
                            listBox1.Items.Add($"Заявитель: {reader}");
                        }
                    }
                    if (demands1.Getname() == null)
                    {
                        foreach(Book book in bk)
                        {
                            if (book.getbookid() == BID)
                            {
                                listBox1.Items.Add($"Книга: {book}");
                            }
                        }
                    }
                }
            }
        }
    }
}
