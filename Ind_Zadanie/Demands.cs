using System;

namespace Ind_Zadanie
{
    class Demands
    {
        private int DemandID;
        private int DemandbookID;
        private int DemandreadID;
        private string bName;
        private string bAuth;
        private string bDesc;
        private static int NextID = 1;
        private string dStatus;

        private static void NIDstep()
        {
            NextID += 1;
        }

        public Demands(int DemandbookID, int DemandreadID)
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
        public Demands(int DemandreadID, string bName, string bAuth)
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
        public Demands(int DemandreadID, string bName, string bAuth, string desc)
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
        public String ToString()
        {
            if(this.bName == null)
            {
                return $"dID:{this.DemandID}, Заявка на книгу из каталога. Номер читателя: {this.DemandreadID}, номер книги: {this.DemandbookID}";
            }
            else if(this.bDesc == null)
            {
                return $"dID:{this.DemandID}, Номер читателя: {this.DemandreadID}, Заявка на новую книгу: {this.bName}, автор: {this.bAuth}";
            }
            else
            {
                return $"dID:{this.DemandID}, Номер читателя: {this.DemandreadID}, Заявка на новую книгу: {this.bName}, автор: {this.bAuth}, Примечание: {this.bDesc}";
            }
            
        }
    }
}
