using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ind_Zadanie
{
    [Serializable]
    class Book
    {
        private string nameBook;  //название книги
        private string publicCode;  // код издания книги
        private string Author;      //автор книги
        private string description; //описание книги
        private int statusKeeperID; //id держателя книги, библиотека = 0
        private int bookID; // id книги
        private static int NextID = 1; // переменная для генерации ID новой книги
        private int[] Queue; //последовательность содержит id читателей из очереди на книгу
        private static void NIdStep()   //статический метод увеличивает величину статической переменной на 1
        {
            NextID += 1;
        }
        public Book(string nameBook, string Author, string publicCode, string description) //полный конструктор, с описанием
        {
            this.nameBook = nameBook;
            this.Author = Author;
            this.publicCode = publicCode;
            this.description = description;
            this.statusKeeperID = 0;
            this.bookID = NextID;
            this.Queue = null;
            NIdStep();
            //0 = library;
        }
        public Book(string nameBook, string Author, string publicCode)  //конструктор без описания, остальные поля обязательны.
        {
            this.nameBook = nameBook;
            this.Author = Author;
            this.publicCode = publicCode;
            this.description = null;
            this.statusKeeperID = 0;
            this.bookID = NextID;
            this.Queue = null;
            NIdStep();
            //0 = library;
        }
        public void KeepChange(int keeper)  //метод присваивает id держателя книги
        {
            this.statusKeeperID = keeper;
        }
        public void KeepBack() // метод "возвращает в библиотеку" книгу
        {
            this.statusKeeperID = 0;
        }
        public int getbookid() //метод возвращает ID книги
        {
            return this.bookID;
        }
        public string getbookname() //метод возвращает название книги
        {
            return this.nameBook;
        }
        public string getbookauth() //метод возвращает описание книги
        {
            return this.Author;
        }
        public void booknamechange(string bkr) //метод изменяет поле названия книги
        {
            this.nameBook = bkr;
        }
        public void bookauthchange(string ath) //метод изменяет поле автора книги
        {
            this.Author = ath;
        }
        public void bookcodechange(string cdc) //метод изменяет поле кода издательства книги
        {
            this.publicCode = cdc;
        }
        public void bookdescchange(string dsc)  //метод изменяет поле описания книги
        {
            this.description = dsc;
        }
        public string getbookcode() //метод возвращает код издания книги
        {
            return this.publicCode;
        }
        public string getdesc() //метод возвращает описание книги
        {
            return this.description;
        }
        public int [] Getqueue() //метод возвращает последовательность id очереди читателей на книгу
        {
            return this.Queue;
        }
        public int [] Queueadd(int add)
        {
            return this.Queue.Append(add).ToArray(); //метод добавляет id в конец последовательности очереди читателей на книгу.
        }
        public void queuedel(int dlt)  //метод удаляет указанный id из последовательности очереди читателей на книгу.
        {
            this.Queue = Array.FindAll(this.Queue, i => i != dlt);
        }
        public int queuecount()  //метод возвращает число читателей в очереди на книгу
        {
            if(this.Queue != null)
            {
                return this.Queue.Count();
            }
            else
            {
                return 0;
            }
        }
        public int keepstatus()  //метод возвращает ID держателя книги (0 = библиотека)
        {
            return this.statusKeeperID;
        }
        public string getstatus() //метод возвращает строковое значения статуса книги
        {
            if (this.keepstatus() == 0)
            {
                return "в библиотеке";
            }
            else
            {
                return $"на руках, rid: {this.keepstatus()}, очередь: {this.queuecount()} человек.";
            }
        }
        override
        public String ToString()  //переопределен метод ToString для вывода экземпляра класса на форму
        {
            return $"ID: {this.bookID} Название: {this.nameBook}, Автор: {this.Author}, Код издания:{this.publicCode}, статус: {this.getstatus()} ";
        }
    }
}
