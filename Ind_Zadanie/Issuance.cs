using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class Issuance : Form
    {
        public Issuance()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e) //возврат в меню сотрудника.
        {
            this.Hide();
            Menu_Admin r17 = new Menu_Admin();
            r17.ShowDialog();
        }
        List<Reader> rd = new List<Reader>();
        List<Book> bk = new List<Book>();
        List<Demands> dm = new List<Demands>();
        private void VbID_button_Click(object sender, EventArgs e)
        { // метод осуществляет выдачу книги читателю, изменяя статус книги, а также внесения изменений в соответствующие поля экземпляров класса книги и читателя.
            rd.Clear();
            bk.Clear();
            dm.Clear();
            int BID = Convert.ToInt32(Bookid_textBox.Text);
            int RID = Convert.ToInt32(readid_textBox.Text);
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
                using (FileStream fileStream_object = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
                {
                    List<Demands> demands = (List<Demands>)binaryFormatter.Deserialize(fileStream_object);
                    dm.AddRange(demands);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки данных, вероятно база пуста.", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach(Reader reader in rd)
            {
                if (reader.GetID() == RID)
                {
                    reader.AddKbook(BID);
                }
            }
            foreach (Book book in bk)  //в записи книги изменяется статус держателя, а также, если книгу получает читатель, стоявший на нее в очереди, то он удаляется из этой очереди.
            {
                if (book.getbookid() == BID)
                {
                    book.KeepChange(RID);
                    if (book.Getqueue() != null && book.Getqueue().Any(i => i == RID))
                    {
                        book.queuedel(RID);
                    }
                }
            }
            foreach(Demands demands1 in dm)
            {
                if (demands1.BIDreturn() == BID && demands1.RIDreturn() == RID && demands1.Getstat() != "закрыта")
                {
                    demands1.Dstatdown();
                }
            }
            using (FileStream fileStream = new FileStream("ListRead.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, rd);
            }
            using (FileStream fileStream = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, bk);
            }
            using (FileStream fileStream = new FileStream("ListDemand.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, dm);
            }
            Bookid_textBox.Clear();
            readid_textBox.Clear();
        }

        private void Vozvr_button_Click(object sender, EventArgs e)
        { // метод осуществляет возврат книги в библиотеку, изменяя статус книги, а также внесения изменений в соответствующие поля экземпляров класса книги и читателя.
            rd.Clear();
            bk.Clear();
            int BID = Convert.ToInt32(Bookid_textBox.Text);
            int RID = Convert.ToInt32(readid_textBox.Text);
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
                MessageBox.Show("Ошибка загрузки данных, вероятно база пуста.", "Возникло исключение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            foreach (Reader reader in rd)
            {
                if (reader.GetID() == RID)
                {
                    reader.DelKbook(BID);
                    reader.AddSbook(BID);
                }
            }
            foreach (Book book in bk)
            {
                if (book.getbookid() == BID)
                {
                    book.KeepBack();         
                    if (book.Getqueue() != null) //при возврате и наличии заявки или очереди на книгу выводится оповещение. 
                    {    //Заявка на существующую книгу в базе сразу предполагает добавление читателя в очередь.
                       MessageBox.Show($"На данную книгу есть заявка/очередь. ID читателя:{book.Getqueue().First()}");
                    }
                }
            }
            using (FileStream fileStream = new FileStream("ListRead.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, rd);
            }
            using (FileStream fileStream = new FileStream("ListBook.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, bk);
            }
            Bookid_textBox.Clear();
            readid_textBox.Clear();
        }
    }
}
