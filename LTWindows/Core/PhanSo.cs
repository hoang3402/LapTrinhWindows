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
            TuSo = Tu;
            this.Mau = Mau;
        }

        public int MauSo
        {
            get => Mau;
            set => Mau = value;
        }

        public int TuSo { get; set; }

        public PhanSo RutGon(PhanSo a)
        {
            int _gcd = (int)BigInteger.GreatestCommonDivisor(a.TuSo, a.MauSo);
            a.TuSo /= _gcd;
            a.MauSo /= _gcd;
            return a;
        }

        public PhanSo Tong(PhanSo a, PhanSo b)
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

        public PhanSo Hieu(PhanSo a, PhanSo b)
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

        public PhanSo Tich(PhanSo a, PhanSo b)
        {
            PhanSo result = new();
            result.TuSo = a.TuSo * b.TuSo;
            result.MauSo = a.MauSo * b.MauSo;
            return RutGon(result);
        }

        public PhanSo Thuong(PhanSo a, PhanSo b)
        {
            PhanSo result = new();
            result.TuSo = a.TuSo * b.MauSo;
            result.MauSo = a.MauSo * b.TuSo;
            return RutGon(result);
        }
    }
}
