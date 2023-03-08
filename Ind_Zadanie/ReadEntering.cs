using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class ReadEntering : Form
    {
        public ReadEntering()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e) //переход обратно в начальное меню выбора читателя или сотрудника
        {
            this.Hide();
            Starter s1 = new Starter();
            s1.ShowDialog();

        }
        List<Reader> rd = new List<Reader>(); //коллекция представляет собой локальное хранилище экземпляров класса читателя
        Reader reader;
        private bool doner = false; //поле отслеживает успешность процесса регистрации, для последующего сохрания записи в базу
        private void Registation_button_Click(object sender, EventArgs e) //метод для регистрации читателя и внесения информации о нем в базу
        {
            if (textBox_sName.Text != "" && textBox_fName.Text != "" && textBox_tName.Text != "" && textBox_Number.Text != "")
            {
                reader = new Reader(textBox_sName.Text, textBox_fName.Text, textBox_tName.Text, dateTimePicker1.Text, textBox_Number.Text);
                rd.Add(reader);
                MessageBox.Show($"Регистрация прошла успешно. Ваш ID: {reader.GetID()}");
                doner = true;
            }
            else if (textBox_sName.Text != "" && textBox_fName.Text != "" && textBox_tName.Text == "" && textBox_Number.Text != "")
            {
                reader = new Reader(textBox_sName.Text, textBox_fName.Text, dateTimePicker1.Text, textBox_Number.Text);
                rd.Add(reader);
                MessageBox.Show($"Регистрация прошла успешно. Ваш ID: {reader.GetID()}");
                doner = true;
            }
            else
            {
                MessageBox.Show("Некорректно введенные данные");
            }
            if (doner == true)
            {
                textBox_sName.Clear();
                textBox_fName.Clear();
                textBox_tName.Clear();
                textBox_Number.Clear();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("ListRead.txt", FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, rd);
                }
                Enter_button.Enabled = true;
            }
            

        }

        private void Enter_button_Click(object sender, EventArgs e) //переход в меню читателя, активируется только после успешной регистрации пользователя
        {
            this.Hide();
            Menu_Reader r1 = new Menu_Reader();
            r1.ShowDialog();

        }

        private void ReadEntering_Load(object sender, EventArgs e)
        {

        } //missclick((
    }
}
