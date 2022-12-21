namespace LTWindows.Core
{
    internal class SinhVien
    {
        string _MSSV;
        string _HoTen;
        string _Phai;
        string _Sdt;

        public string MSSV { get => _MSSV; set => _MSSV = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string Phai { get => _Phai; set => _Phai = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }

        public SinhVien(string mssv, string hoten, string sdt, string phai)
        {
            _MSSV = mssv;
            _HoTen = hoten;
            _Sdt = sdt;
            _Phai = phai;
        }
    }
}
