namespace LTWindows
{
    public class HinhTamGiac
    {
        private int Canh1;
        private int Canh2;
        private int Canh3;

        public int canh1
        {
            get => Canh1;
            set
            {
                Canh1 = value;
            }
        }

        public int canh2
        {
            get => Canh2;
            set
            {
                Canh2 = value;
            }
        }

        public int canh3
        {
            get => Canh3;
            set
            {
                Canh3 = value;
            }
        }

        public HinhTamGiac()
        {
            Canh1 = 0;
            Canh2 = 0;
            Canh3 = 0;
        }

        public HinhTamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }

        public double LayChuVi()
        {
            return Canh1 + Canh2 + Canh3;
        }

        public double LayDienTich()
        {
            double p = (Canh1 * 1.0 + Canh2 + Canh3) / 2;
            return Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
        }

        public void Loi()
        {
            throw new System.NotImplementedException();
        }

        public string PhanLoaiTamGiac()
        {
            if (Canh1 < Canh2 + Canh3 && Canh2 < Canh1 + Canh3 && Canh3 < Canh1 + Canh2)
            {
                if (Canh1 * Canh1 == Canh2 * Canh2 + Canh3 * Canh3 || Canh2 * Canh2 == Canh1 * Canh1 + Canh3 * Canh3 || Canh3 * Canh3 == Canh1 * Canh1 + Canh2 * Canh2)
                {
                    return "Tam giác vuông";
                }
                else if (Canh1 == Canh2 && Canh2 == Canh3)
                {
                    return "Tam giác đều";
                }
                else if (Canh1 == Canh2 || Canh1 == Canh3 || Canh2 == Canh3)
                {
                    return "Tam giác cân";
                }
                else if ((Canh1 * Canh1 > Canh2 * Canh2 + Canh3 * Canh3) || (Canh2 * Canh2 > Canh1 * Canh1 + Canh3 * Canh3) || (Canh3 * Canh3 > Canh1 * Canh1 + Canh2 * Canh2))
                    return "Tam giác tù";
                else
                    return "Tam giác nhọn";
            }
            else
            {
                return "Không phải tam giác";
            }
        }

        public string Xuat()
        {
            if (PhanLoaiTamGiac() == "Không phải tam giác")
            {
                return "3 cạnh bạn vừa nhập không thể tạo thành 1 tam giác!";
            }

            return "Hình tam giác có 3 cạnh lần lượt là: " + Canh1.ToString() + " " + Canh2.ToString() + " " + Canh3.ToString()
                 + "\nTam giác này thuộc loại: " + PhanLoaiTamGiac()
                 + "\nChu vi: " + LayChuVi().ToString()
                 + "\nDiện tích: " + LayDienTich().ToString();
        }
    }
}