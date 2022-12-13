namespace LTWindows
{
    public class HinhTron
    {
        private double R;

        public HinhTron()
        {
            R = 0;
        }

        public HinhTron(double R)
        {
            this.R = R;
        }

        public double BanKinh { get => R; set { R = value; } }

        public double LayChuVi()
        {
            return 2 * Math.PI * R;
        }

        public double LayDienTich()
        {
            return Math.PI * R * R;
        }

        public String Xuat()
        {
            return "Hình tròn bán kính: " + R.ToString()
                 + "\nChu vi: " + LayChuVi().ToString()
                 + "\nDiện tích: " + LayDienTich().ToString();
        }
    }
}