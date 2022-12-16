using System.Numerics;

namespace LTWindows.Core
{
    internal class PhanSo
    {
        private int Mau;

        public PhanSo()
        {
            TuSo = 0;
            Mau = 1;
        }

        public PhanSo(int Tu, int Mau)
        {
            if (Mau == 0)
            {
                throw new Exception("Mẫu số không thể bằng 0!");
            }
            TuSo = Tu;
            this.Mau = Mau;
        }

        public int MauSo
        {
            get => Mau;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Mẫu số không thể bằng 0!");
                }
                Mau = value;
            }
        }

        public int TuSo { get; set; }

        public static PhanSo RutGon(PhanSo a)
        {
            int _gcd = (int)BigInteger.GreatestCommonDivisor(a.TuSo, a.MauSo);
            a.TuSo /= _gcd;
            a.MauSo /= _gcd;
            return a;
        }

        public static PhanSo Tong(PhanSo a, PhanSo b)
        {
            PhanSo result = new();

            if (a.MauSo == b.MauSo)
            {
                result.TuSo = a.TuSo + b.TuSo;
                result.MauSo = a.MauSo;
                return RutGon(result);
            }

            result.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            result.MauSo = a.MauSo * b.MauSo;
            return RutGon(result);
        }

        public static PhanSo Hieu(PhanSo a, PhanSo b)
        {
            PhanSo result = new();

            if (a.MauSo == b.MauSo)
            {
                result.TuSo = a.TuSo + -b.TuSo;
                result.MauSo = a.MauSo;
                return RutGon(result);
            }

            result.TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            result.MauSo = a.MauSo * b.MauSo;
            return RutGon(result);
        }

        public static PhanSo Tich(PhanSo a, PhanSo b)
        {
            PhanSo result = new();
            result.TuSo = a.TuSo * b.TuSo;
            result.MauSo = a.MauSo * b.MauSo;
            return RutGon(result);
        }

        public static PhanSo Thuong(PhanSo a, PhanSo b)
        {
            PhanSo result = new();
            result.TuSo = a.TuSo * b.MauSo;
            result.MauSo = a.MauSo * b.TuSo;
            return RutGon(result);
        }

        public static bool CheckValid(PhanSo a)
        {
            if (a.MauSo == 0)
            {
                return false;
            }
            return true;
        }
    }
}
