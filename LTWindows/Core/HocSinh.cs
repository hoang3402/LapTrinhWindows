namespace LTWindows.Core
{
    internal class HocSinh : Diem
    {
        private string maHV;
        private string hoTen;
        private string phai;
        private string soDT;

        public HocSinh(string maHV, string hoTen, string phai, string soDT, double toan, double hoa, double ly) : base(toan, hoa, ly)
        {
            this.maHV = maHV;
            this.hoTen = hoTen;
            this.phai = phai;
            this.soDT = soDT;
        }

        public string MaHV
        {
            get { return maHV; }
            set { maHV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
    }
}
