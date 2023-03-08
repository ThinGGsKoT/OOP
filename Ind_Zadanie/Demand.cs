using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class Demand : Form
    {
        public Demand()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demand_Load(object sender, EventArgs e)
        {

        }
        private bool doner;
        List<Demands> dm = new List<Demands>();
        List<Book> bk = new List<Book>();
        private void Button1_Click(object sender, EventArgs e)  //Данный метод позволяет оставить заявку на существующую книгу, внося соответствующие изменения в поля книги.
        {
            //doner = false;  
            dm.Clear();
            bk.Clear();
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
                MessageBox.Show("Ошибка загрузки данных, возможно база пуста", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(RID_textBox.Text != "" && BID_textBox.Text != "")
            {
                int RID = Convert.ToInt32(RID_textBox.Text);
                int BID = Convert.ToInt32(BID_textBox.Text);
                Demands dema = new Demands(BID, RID);
                dm.Add(dema);
                foreach(Book book in bk)
                {
                    if(BID == book.getbookid())
                    {
                        book.Queueadd(RID);
                    }
                }
                using (FileStream fileStream = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, bk);
                }
                using (FileStream fileStream = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, dm);
                }
                //doner = true;
                RID_textBox.Clear();
                BID_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void Button2_Click(object sender, EventArgs e)  //данный метод записывает заявку на новую книгу, внося изменения в базу данных заявок.
        {
            dm.Clear();
            doner = false;
            if (RID_textBox.Text != "" && Name_textBox.Text != "" && Auth_textBox.Text != "" && Desc_textBox.Text == "")
            {
                int RID = Convert.ToInt32(RID_textBox.Text);
                string NM = Name_textBox.Text;
                string AT = Auth_textBox.Text;
                Demands dema = new Demands(RID, NM, AT);
                dm.Add(dema);
                doner = true;
            }
            else if (RID_textBox.Text != "" && Name_textBox.Text != "" && Auth_textBox.Text != "" && Desc_textBox.Text != "")
            {
                int RID = Convert.ToInt32(RID_textBox.Text);
                string NM = Name_textBox.Text;
                string AT = Auth_textBox.Text;
                string DC = Desc_textBox.Text;
                Demands dema = new Demands(RID, NM, AT, DC);
                dm.Add(dema);
                doner = true;
            }
            if (doner == true)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, dm);
                }
                RID_textBox.Clear();
                BID_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back_button_Click(object sender, EventArgs e)  //возврат в меню читателя
        {
            this.Hide();
            Menu_Reader r18 = new Menu_Reader();
            r18.ShowDialog();
        }
    }
}
