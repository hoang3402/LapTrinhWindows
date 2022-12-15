namespace LTWindows
{
    public class HinhVuong
    {
        private double Canh;
        public double canh { get => Canh; set { Canh = value; } }

        public HinhVuong()
        {
            Canh = 0;
        }

        public HinhVuong(double canh)
        {
            this.Canh = canh;
        }

        public double LayDienTich()
        {
            return Canh * Canh;
        }

        public double LayChuVi()
        {
            return Canh * 4;
        }

        public string Xuat()
        {
            return "Hình vuông có cạnh: " + Canh.ToString()
                + "\nChu vi: " + LayChuVi().ToString()
                + "\nDiện tích: " + LayDienTich().ToString();
        }
    }
}