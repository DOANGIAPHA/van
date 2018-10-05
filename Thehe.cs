using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nhapthongtinmotnguoi;

namespace THEHE
{
    //hello hello
    class Thehe
    {
        private string sTenTheHe;
        private List<Thongtin> lDSTV;
        public string Tenthehe
        {
            get { return this.sTenTheHe; }
            set { this.sTenTheHe = value; }
        }
        public List<Thongtin> DSTV
        {
            get { return this.lDSTV; }
            set { this.lDSTV = value; }
        }
        public Thehe()
        {
            this.lDSTV = new List<Thongtin>();
        }
        public void Nhap()
        {
            int soTV = 0;
            Console.Write(" Nhap vao so thanh vien trong the he: ");
            soTV = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < soTV; i++)
            {
                Console.WriteLine(" Nhap thong tin thanh vien thu "+i+": ");
                
                Thongtin tv = new Thongtin();
                tv.Nhap();
                this.lDSTV.Add(tv);
            }

        }
        public void Xuat()
        {
 
            for (int i = 0; i < this.lDSTV.Count; i++)
            {
                Console.WriteLine(" Thong tin thanh vien thu "+i+": ");
                this.lDSTV[i].Xuat();
            }
        }
    }
}
