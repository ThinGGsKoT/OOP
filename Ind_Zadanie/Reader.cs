using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ind_Zadanie
{
    [Serializable]    //запись обьектов класса в файл будет производиться с помощью сериализации
    class Reader
    {
        private string sName;     //фамилия
        private string fName;     //имя
        private string tName;     //отчество
        private string Date;     //дата рождения
        private string TelNum;     //номер телефона
        private static int NextID = 1;     //статическая переменная, использующаяся для присвоения ID читателя
        private int ReadID;     //ID читателя
        private int[] KeepBooks;  //Книги, нахадящиеся на руках у читателя(id)
        private int[] SdBooks;    //Книги, которые читатель вернул(id)
        public Reader(string sName, string fName, string tName, string Date, string TelNum) //полный конструктор
        {
            this.sName = sName;
            this.fName = fName;
            this.tName = tName;
            this.Date = Date;
            this.TelNum = TelNum;
            this.ReadID = NextID;
            this.KeepBooks = null;
            this.SdBooks = null;
            NIdStep();
        }
        public Reader(string sName, string fName, string Date, string TelNum)  //конструктор без отчества, учитывая, что остальные поля обязательны для заполнения
        {
            this.sName = sName;
            this.fName = fName;
            this.tName = null;
            this.Date = Date;
            this.TelNum = TelNum;
            this.ReadID = NextID;
            this.KeepBooks = null;
            this.SdBooks = null;
            NIdStep();
        }
        public int[] ShowKbooks()  //метод возвращает массив ID тех книг, которые находятся у читателя.
        { 
                return this.KeepBooks;  
        }
        public int[] ShowSbooks()   //метод возвращает массив ID тех книг, которые читатель вернул.
        {
            return this.SdBooks;
        }
        public void AddKbook(int kb) //метод добавляет указанный id в массив ID тех книг, которые находятся у читателя, 
        {
            this.KeepBooks.Append(kb);
        }
        public void AddSbook(int sb) //метод добавляет указанный id в массив ID тех книг, которые читатель вернул, 
        {
            this.SdBooks.Append(sb);
        }
        public void DelKbook(int kb)  //метод удаляет указанный id из массива ID тех книг, которые находятся у читателя
        {
            this.KeepBooks = Array.FindAll(this.KeepBooks, i => i != kb);
        }
        public void DelSbook(int sb)  //метод удаляет указанный id из массива ID тех книг, которые читатель вернул,
        {
            this.SdBooks = Array.FindAll(this.SdBooks, i => i != sb);
        }
        public void ChangeSname(string chsn)  //метод редактирует фамилию
        {
            this.sName = chsn;
        }
        public void ChangeFname(string chfn)  //метод редактирует имя
        {
            this.fName = chfn;
        }
        public void ChangeTname(string chtn)  //метод редактирует отчество
        {
            this.fName = chtn;
        }
        public void ChangeTnum(string chtel) //метод редактирует номер телефона
        {
            this.TelNum = chtel;
        }
        private static void NIdStep()   //статический метод увеличивает величину статической переменной на 1
        {
            NextID += 1;
        }
        public int GetID() //метод возвращает присвоенный ID
        {
            return this.ReadID;
        }

        public void SetiD(int setid)  //метод меняет ID на заданный
        {
            this.ReadID = setid;
        }
        override 
        public String ToString()  //переопределен метод ToString для вывода обьектов класса на форму
        {
            return $"ID: {this.ReadID}, {this.sName}  {this.fName} {this.tName}, дата рождения: {this.Date}, телефон: {this.TelNum} ";
        }
    }
}
