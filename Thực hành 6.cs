using System;

namespace b1
{
    abstract class Nhanvien
    {
        protected string hoten, diachi;
        protected DateTime ngaysinh;
        public Nhanvien()
        {
            hoten = diachi = "";

            ngaysinh = DateTime.Now;
        }
        public Nhanvien(string hoten, string diachi, DateTime ngaysinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;

        }
        public virtual void nhap()
        {
            Console.WriteLine("xin mời nhập họ tên");
            hoten = Console.ReadLine();
            Console.WriteLine("xin mời nhập địa chỉ");
            diachi = Console.ReadLine();
            Console.WriteLine(" xin mời nhập ngày sinh");
            ngaysinh = DateTime.Parse(Console.ReadLine());

        }
        public virtual void Hien()
        {
            Console.WriteLine("{0}\t1}\t{2}", hoten, diachi, ngaysinh);

        }
        public abstract double Tinhluong();
    }

}
public class NVSX : Nhanvien
{
    private int ssp;
    public NVSX() : base()
    { ssp = 0; }
    public NVSX(string hoten, string diachi, DateTime ngaysinh, int spp) :
        base(hoten, diachi, ngaysinh)
    { this.ssp = ssp; }
    public override void nhap()
    {
        Console.WriteLine("nhap thong tin cho nhan vien san xuat");
        base.nhap();
        Console.WriteLine("nhap so san pham:");
        ssp = int.Parse(Console.ReadLine());
        base.Hien();
        Console.WriteLine("so san pham" + ssp);
        Console.WriteLine("luong:" + Tinhluong());
    }
    public override double Tinhluong()
    {
        return ssp * 20;
    }
}
public class NVCN : Nhanvien
{
    private int snc;
    public NVCN() : base()
    {
        snc = 0;
    }
    public NVCN(string hoten, string diachi, DateTime ngaysinh, int snc) :
        base(hoten, diachi, ngaysinh)
    { this.snc = snc; }
    public override void nhap()
    {
        Console.WriteLine("nhap thong tin cho nhan cong cong nhat:");

        base.nhap();
        Console.WriteLine("nhap so ngay cong:");
        snc = int.Parse(Console.ReadLine());
    }
    public override void Hien()
    {
        Console.WriteLine("thong tin luong cua nhan cong nhat:");
        base.Hien();
        Console.WriteLine(" so nagy cong" + snc);
        Console.WriteLine("luong" + Tinhluong());
    }
    public override double Tinhluong()
    {
        return snc * 50;
    }
}
public class NVQL : Nhanvien
{
    private double hsl;
    private static int luongcoban = 1050;
    public NVQL() : base()
    {
        hsl = 2.34;
    }
    public NVQL(string hoten, string diachi, DateTime ngaysinh, int hsl);
    :base.nhap(hoten, diachi, ngaysinh)
    {
        this.hsl = hsl;
    }
    public static int Luongcoban()
    {
        get { return luongcoban; }
        set
        {
            if (value > 1050) luongcoban = value;
        }
    }

    public override void nhap()
    {
        Console.WriteLine("Nhap thong tin cho nhan vien quan ly");
        base.nhap();
        Console.Write("Nhap he so luong:");
        hsl = double.Parse(Console.ReadLine());
    }
    public override void Hien()
    {
        Console.WriteLine("Thong tin luong cua nhan vien quan ly");
        base.Hien();
        Console.WriteLine("He so luong" + hsl);
        Console.WriteLine("Luong:" + Tinhluong());
    }
    public override double Tinhluong()
    {
        return hsl * luongcoban;
    }
}
class QuanLy
{
    private Nhanvien[] ds;
    private int snv;
    public void Nhap()
    {
        Console.Write("Nhap so nhan vien:");
        snv = int.Parse(Console.ReadLine());
        ds = new Nhanvien[snv];
        for (int i = 0; i < snv; ++i)
        {
            Console.Write("Ban muon nhap thong tin cho nhan vien quan ly(Q), cong nhat(C), san xuat(S)");
            char ch = char.Parse(Console.ReadLine());
            switch (char.ToUpper(ch))
            {
                case 'Q': ds[i] = new NVQL(); ds[i].Nhap(); break;
                case 'C': ds[i] = new NVCN(); ds[i].Nhap(); break;
                case 'S': ds[i] = new NVSX(); ds[i].Nhap(); break;
            }
        }
    }
    public void Hien()
    {
        for (int i = 0; i < snv; ++i)
            ds[i].Hien();
    }
}
class App
{
    static void Main()
    {
        QuanLy t = new QuanLy();
        t.Nhap();
        t.Hien();
        Console.ReadKey();
    }
}
// b2
class Person
{

    private string hoten, quequan;
    private DateTime ngaysinh;
    public Person()
    {
        hoten = quequan = " ";
        ngaysinh = DateTime.Now;
    }
    public Person(string hoten, string quequan, DateTime ngaysinh)
    {
        this.hoten = hoten;
        this.quequan = quequan;
        this.ngaysinh = ngaysinh;
    }
    public virtual void Nhap()
    {
        Console.Write("Nhap ho va ten:");
        hoten = Console.ReadLine();
        Console.Write("Nhap que quan:");
        quequan = Console.ReadLine();
        Console.Write("Nhap ngay sinh:");
        ngaysinh = DateTime.Parse(Console.ReadLine());
    }
    public virtual void Hien()
    {
        Console.WriteLine("Ho ten:{0}\tNgay sinh:{1}\tQue quan:{2}", hoten, quequan, ngaysinh);
    }
}

//----Bài 2---------------------------------------------------------------------------------------------------------------
class Sinhvien : Person
{
    private string masv, lop;
    public Sinhvien() : base()
    {
        masv = lop = " ";
    }
    public Sinhvien(string hoten, string diachi, DateTime ngaysinh, string masv, string lop) : base(hoten, diachi, ngaysinh)
    {
        this.masv = masv;
        this.lop = lop;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ma sinh vien:");
        masv = Console.ReadLine();
        Console.Write("Nhap lop:");
        lop = Console.ReadLine();
    }
    public override void Hien()
    {
        base.Hien();
        Console.WriteLine("Ma sinh vien:{0}\t Lop:{1}", masv, lop);
    }

}

//--------- Bài 3
//abstract class Nhanvien
//{
//    protected string hoten;
//    protected string diachi;
//    protected DateTime ngaysinh;
//    public Nhanvien()
//    {
//        hoten = diachi = "";
//        ngaysinh = DateTime.Now;
//    }
//    public Nhanvien(string hoten, string diachi, DateTime ngaysinh)
//    {
//        this.hoten = hoten;
//        this.diachi = diachi;
//        this.ngaysinh = ngaysinh;
//    }
//    public virtual void Nhap()
//    {
//        Console.Write("Nhap ho ten:");
//        hoten = Console.ReadLine();
//        Console.Write("Nhap dia chi:");
//        diachi = Console.ReadLine();
//        ngaysinh = DateTime.Parse(Console.ReadLine());
//    }
//    public virtual void Hien()
//    {
//        Console.WriteLine("{0}\t{1}\t{2}", hoten, diachi, ngaysinh);
//    }
//    public abstract double Tinhluong();
//}
//public class NVSX : Nhanvien
//{
//    private int ssp;
//    public NVSX() : base() { ssp = 0; }
//    public NVSX(string hoten, string diachi, DateTime ngaysinh, int ssp)
//        : base(hoten, diachi, ngaysinh) { this.ssp = ssp; }
//    public override void Nhap()
//    {
//        Console.WriteLine("Nhap thong tin cho nhan vien san xuat");
//        base.Nhap();
//        Console.Write("Nhap so san pham:");
//        ssp = int.Parse(Console.ReadLine());
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Thong tin luong cua nhan vien san xuat");
//        base.Hien();
//        Console.WriteLine("So san pham" + ssp);
//        Console.WriteLine("Luong:" + Tinhluong());
//    }
//    public override double Tinhluong()
//    {
//        return ssp * 20;
//    }
//}
//public class NVCN : Nhanvien
//{
//    private int snc;
//    public NVCN() : base() { snc = 0; }
//    public NVCN(string hoten, string diachi, DateTime ngaysinh, int snc)
//        : base(hoten, diachi, ngaysinh) { this.snc = snc; }
//    public override void Nhap()
//    {
//        Console.WriteLine("Nhap thong tin cho nhan vien cong nhat");
//        base.Nhap();
//        Console.Write("Nhap so ngay cong:");
//        snc = int.Parse(Console.ReadLine());
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Thong tin luong cua nhan vien cong nhat");
//        base.Hien();
//        Console.WriteLine("So ngay cong" + snc);
//        Console.WriteLine("Luong:" + Tinhluong());
//    }
//    public override double Tinhluong()
//    {
//        return snc * 50;
//    }
//}
//public class NVQL : Nhanvien
//{
//    private double hsl;
//    private static int luongcoban = 1050;
//    public NVQL() : base() { hsl = 2.34; }
//    public NVQL(string hoten, string diachi, DateTime ngaysinh, int hsl)
//        : base(hoten, diachi, ngaysinh) { this.hsl = hsl; }
//    public static int Luongcoban
//    {
//        get { return luongcoban; }
//        set
//        {
//            if (value > 1050) luongcoban = value;
//        }
//    }

//    public override void Nhap()
//    {
//        Console.WriteLine("Nhap thong tin cho nhan vien quan ly");
//        base.Nhap();
//        Console.Write("Nhap he so luong:");
//        hsl = double.Parse(Console.ReadLine());
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Thong tin luong cua nhan vien quan ly");
//        base.Hien();
//        Console.WriteLine("He so luong" + hsl);
//        Console.WriteLine("Luong:" + Tinhluong());
//    }
//    public override double Tinhluong()
//    {
//        return hsl * luongcoban;
//    }
//}
//class QuanLy
//{
//    private Nhanvien[] ds;
//    private int snv;
//    public void Nhap()
//    {
//        Console.Write("Nhap so nhan vien:");
//        snv = int.Parse(Console.ReadLine());
//        ds = new Nhanvien[snv];
//        for (int i = 0; i < snv; ++i)
//        {
//            Console.Write("Ban muon nhap thong tin cho nhan vien quan ly(Q), cong nhat(C), san xuat(S)");
//            char ch = char.Parse(Console.ReadLine());
//            switch (char.ToUpper(ch))
//            {
//                case 'Q': ds[i] = new NVQL(); ds[i].Nhap(); break;
//                case 'C': ds[i] = new NVCN(); ds[i].Nhap(); break;
//                case 'S': ds[i] = new NVSX(); ds[i].Nhap(); break;
//            }
//        }
//    }
//    public void Hien()
//    {
//        for (int i = 0; i < snv; ++i)
//            ds[i].Hien();
//    }
//}
//class test
//{
//    static void Main1()
//    {
//        QuanLy t = new QuanLy();
//        t.Nhap();
//        t.Hien();
//        Console.ReadKey();
//    }
//}


// BÀI 4
//abstract class Xe
//{
//    protected double sogio;
//    public Xe(double sogio)
//    {
//        this.sogio = sogio;
//    }
//    public abstract double TinhTien();
//    public abstract void Hien();
//}
//class XeDL : Xe
//{
//    public XeDL(double sogio) : base(sogio) { }
//    public override double TinhTien()
//    {
//        if (sogio <= 1) return 250;
//        else
//            return 250 + (sogio - 1) * 75;
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Xe du lich");
//    }
//}
//class XeTai : Xe
//{
//    public XeTai(double sogio) : base(sogio) { }
//    public override double TinhTien()
//    {
//        if (sogio <= 1) return 220;
//        else
//            return 220 + (sogio - 1) * 85;
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Xu xe tai");
//    }
//}
//class Khach
//{
//    private string hoten, quequan;
//    private DateTime ngaysinh;
//    private double sogio;
//    private Xe loaixe;
//    public void Nhap()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.WriteLine("Thông tin khách thuê xe:");
//        Console.Write("Ho ten:"); hoten = Console.ReadLine();
//        Console.Write("Que quan:"); quequan = Console.ReadLine();
//        Console.Write("Ngay sinh:"); ngaysinh = DateTime.Parse(Console.ReadLine());
//        Console.Write("So gio:"); sogio = double.Parse(Console.ReadLine());
//        Console.Write("Khach hang muon thue loai xe nao XeDL(L) hay XeTai(T)?");
//        char ch = char.Parse(Console.ReadLine());
//        switch (char.ToUpper(ch))
//        {
//            case 'L':
//                loaixe = new XeDL(sogio);
//                Console.WriteLine("Khách vừa thuê xe:"); loaixe.Hien();
//                break;
//            case 'T':
//                loaixe = new XeTai(sogio);
//                Console.WriteLine("Khách hàng vừa thuê xe:"); loaixe.Hien();
//                break;
//        }
//    }
//    public void Hien()
//    {
//        Console.WriteLine("Thong tin khach hang thue xe");
//        Console.WriteLine("Ho ten:" + hoten);
//        Console.WriteLine("Que quan:" + quequan);
//        Console.WriteLine("Ngay sinh:" + ngaysinh.ToString("dd/MM/yyyy"));
//        Console.WriteLine("So gio thue:" + sogio);
//        Console.WriteLine("Dich vu xe khach hang da thue:");
//        loaixe.Hien();
//        Console.WriteLine("Tien thue xe:" + loaixe.TinhTien());
//    }
//}
//class QL
//{
//    private Khach[] ds;
//    private int sck;
//    public void Nhap()
//    {
//        Console.Write("so khach hang:"); sck = int.Parse(Console.ReadLine());
//        ds = new Khach[sck];
//        for (int i = 0; i < sck; ++i)
//        {
//            ds[i] = new Khach();
//            ds[i].Nhap();
//        }
//    }

//    public void Hien()
//    {
//        Console.WriteLine("Thong tin cac khach hang da thue xe ");
//        for (int i = 0; i < sck; ++i)
//        {
//            Console.WriteLine("-----------------------");
//            ds[i].Hien();
//        }
//    }
//}


//class test1
//{
//    static void Main()
//    {
//        QL t = new QL();
//        t.Nhap();
//        Console.Clear();
//        t.Hien();
//        Console.ReadKey();
//    }
//} 

// BÀI 5
//abstract class Phong
//{
//    protected int songay;
//    public Phong(int songay)
//    {
//        this.songay = songay;
//    }
//    public abstract double TinhTien();
//    public abstract void Hien();
//}
//class PhongA : Phong
//{
//    protected int tiendv;
//    public PhongA(int songay)
//        : base(songay)
//    {
//        Console.Write("Nhap tien dv:"); tiendv = int.Parse(Console.ReadLine());
//    }

//    public override double TinhTien()
//    {
//        if (songay < 5) return songay * 80 + tiendv;
//        else return 5 * 80 * +(songay - 5) * 80 * 0.9 + tiendv;
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Dich vu phong A");
//        Console.WriteLine("Tien dich vu:" + tiendv);
//        Console.WriteLine("Tien phong:" + TinhTien());
//    }
//}
//class PhongB : Phong
//{
//    public PhongB(int songay)
//        : base(songay) { }
//    public override double TinhTien()
//    {
//        if (songay < 5) return songay * 60;
//        else return 5 * 60 * +(songay - 5) * 60 * 0.9;
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Dich vu phong B");
//        Console.WriteLine("Tien phong:" + TinhTien());
//    }
//}
//class PhongC : Phong
//{
//    public PhongC(int songay)
//        : base(songay) { }
//    public override double TinhTien()
//    {
//        return songay * 40;
//    }
//    public override void Hien()
//    {
//        Console.WriteLine("Dich vu phong C");
//        Console.WriteLine("Tien phong:" + TinhTien());
//    }
//}
//class HoaDoanKhach
//{
//    private string tenkhach;
//    private int songay;
//    private Phong loaiphong;
//    public void Nhap()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.WriteLine("Nhập thông tin hóa đơn khách hàng");
//        Console.Write("Họ tên:"); tenkhach = Console.ReadLine();
//        Console.Write("Số ngày ở:"); songay = int.Parse(Console.ReadLine());
//        Console.WriteLine("Cho biết loại phòng ở A, B, C?");
//        char ch = char.Parse(Console.ReadLine());
//        switch (char.ToUpper(ch))
//        {
//            case 'A': loaiphong = new PhongA(songay); break;
//            case 'B': loaiphong = new PhongB(songay); break;
//            case 'C': loaiphong = new PhongB(songay); break;
//        }
//    }
//    public void Hien()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.WriteLine("Thông tin hóa đơn khách hàng");
//        Console.WriteLine("Họ tên khách hàng:" + tenkhach);
//        Console.WriteLine("Số ngày:" + songay);
//        Console.WriteLine("Khách hàng dự định:");
//        loaiphong.Hien();
//    }
//}
//class Tets
//{
//    static void Main5()
//    {
//        HoaDoanKhach t = new HoaDoanKhach();
//        t.Nhap();
//        Console.Clear();
//        t.Hien();
//        Console.ReadLine();
//        Console.ReadKey();
//    }
//}