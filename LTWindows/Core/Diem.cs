namespace LTWindows.Core
{
    internal class Diem
    {
        private double _Toan;
        private double _Ly;
        private double _Hoa;
        private double _Tb;

        public Diem(double toan, double ly, double hoa)
        {
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
            _Tb = (_Toan + _Ly + _Hoa) / 3;
        }

        public double Toan
        {
            get { return _Toan; }
            set { _Toan = value; _Tb = (_Toan + _Ly + _Hoa) / 3; }
        }

        public double Ly
        {
            get { return _Ly; }
            set { _Ly = value; _Tb = (_Toan + _Ly + _Hoa) / 3; }
        }

        public double Hoa
        {
            get { return _Hoa; }
            set { _Hoa = value; _Tb = (_Toan + _Ly + _Hoa) / 3; }
        }

        public double Tb
        {
            get { return _Tb; }
        }

        public static double getTB(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}
