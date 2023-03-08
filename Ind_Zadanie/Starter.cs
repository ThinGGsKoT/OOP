using System;
using System.Windows.Forms;

namespace Ind_Zadanie
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }
        public static bool admin;  //данное поле помогает отслеживать, кто входит в систему, читатель иди сотрудник библиотеки, и избегать к несанкционированного доступа читателя к некоторым формам.
        //ref bool refadm = Starter.Getadm();
        private void AdminEnter_button_Click(object sender, EventArgs e) //метод позволяет зайти в систему в качестве сотрудника библиотеки
        {
            admin = true;            //Также здесь предполагается введение формы авторизации для сотрудника библиотеки, дабы избежать несанкцианированного доступа.
            this.Hide();  //Однако в рамка данного индивидуального задания его не стали реализовывать.
            Menu_Admin f2 = new Menu_Admin();
            f2.ShowDialog();
            
        }

        private void ReaderEnter_button_Click(object sender, EventArgs e) //вход в систему в качестве читателя, с последующей регистрацией или входом по номеру читательского билета
        {
            DialogResult result = MessageBox.Show("У Вас имеется номер читательского билета?", "Вход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                admin = false;          //здесь предполагается также форма авторизации для читателя по его читательскому билету.
                this.Hide();
                Menu_Reader r1 = new Menu_Reader();
                r1.ShowDialog();
                
            }
            if (result == DialogResult.No)
            {
                
                {
                    this.Hide();
                    ReadEntering r2 = new ReadEntering();
                    r2.ShowDialog();
                    admin = false;
                }
            }
            

        }
        public bool Getadm() //метод возвращает значения поля проверки admin
        {
            return admin;
        }
    }
}
