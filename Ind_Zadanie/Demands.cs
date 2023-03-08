using System;

namespace Ind_Zadanie
{
    class Demands
    {
        private int DemandID;  //идентификатор заявок
        private int DemandbookID;  //id книги из заявки
        private int DemandreadID;  //id читателя из заявки
        private string bName;  //Название книги
        private string bAuth;  // Автор книги
        private string bDesc;  // Примечание к заявку
        private static int NextID = 1; //переменная для генерации id
        private string dStatus; //Статус заявки

        private static void NIDstep()
        {
            NextID += 1;
        }

        public Demands(int DemandbookID, int DemandreadID) //Конструктор для книги из базы.
        {
            this.DemandID = NextID;
            NIDstep();
            this.DemandbookID = DemandbookID;
            this.DemandreadID = DemandreadID;
            this.bName = null;
            this.bAuth = null;
            this.bDesc = null;
            this.dStatus = "На книгу в библиотеке: активна";
        }
        public Demands(int DemandreadID, string bName, string bAuth) //Конструктор для новой книги, без примечания
        {
            this.DemandID = NextID;
            NIDstep();
            this.DemandreadID = DemandreadID;
            this.DemandbookID = 0;
            this.bName = bName;
            this.bAuth = bAuth;
            this.bDesc = null;
            this.dStatus = "На новую книгу: активна";

        }
        public Demands(int DemandreadID, string bName, string bAuth, string desc)  //Конструктор полный для новой книги
        {
            this.DemandID = NextID;
            NIDstep();
            this.DemandreadID = DemandreadID;
            this.DemandbookID = 0;
            this.bName = bName;
            this.bAuth = bAuth;
            this.bDesc = desc;
            this.dStatus = "На новую книгу: активна";
        }

        public int GetDID()
        {
            return this.DemandID;
        }
        public int RIDreturn()
        {
            return this.DemandreadID;
        }
        public int BIDreturn()
        {
            return this.DemandbookID;
        }
        public void Dstatdown()
        {
            this.dStatus = "закрыта";
        }
        public string Getname()
        {
            return this.bName;
        }
        public string Getauth()
        {
            return this.bAuth;
        }
        public string Getdesc()
        {
            return this.bDesc;
        }
        public string Getstat()
        {
            return this.dStatus;
        }
        override
        public String ToString() //переопределение ToString для вывода экземпляра на форму
        {
            if(this.bName == null)
            {
                return $"dID:{this.DemandID}, {this.dStatus}, Номер читателя: {this.DemandreadID}, номер книги: {this.DemandbookID}";
            }
            else if(this.bDesc == null)
            {
                return $"dID:{this.DemandID}, {this.dStatus}, Номер читателя: {this.DemandreadID}, Заявка на новую книгу: {this.bName}, автор: {this.bAuth}";
            }
            else
            {
                return $"dID:{this.DemandID}, {this.dStatus}, Номер читателя: {this.DemandreadID}, Заявка на новую книгу: {this.bName}, автор: {this.bAuth}, Примечание: {this.bDesc}";
            }
            
        }
    }
}
