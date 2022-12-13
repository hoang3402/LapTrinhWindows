namespace LTWindows.Core
{

    internal class HCN
    {
        protected double Canh1, Canh2;
        public HCN(double x, double y) // hàm constructor có tham số 
        {
            Canh1 = x;
            Canh2 = y;
        }

        public double ChieuDai
        {
            get => Canh1;
            set
            {
                Canh1 = value;
            }
        }

        public double ChieuRong
        {
            get => Canh2;
            set
            {
                Canh2 = value;
            }
        }

        public void NhapKT(double x, double y)
        {
            Canh1 = x;
            Canh2 = y;
        }
        public double ChuVi()
        {
            return (Canh1 + Canh2) * 2;
        }
        public double DienTich()
        {
            return Canh1 * Canh2;
        }

        public string Xuat()
        {
            return "Hình chữ nhật có cạnh lần lượt là: " + Canh1.ToString() + " " + Canh2.ToString()
                 + "\nChu vi: " + ChuVi().ToString()
                 + "\nDiện tích: " + DienTich().ToString();
        }
    }
}
