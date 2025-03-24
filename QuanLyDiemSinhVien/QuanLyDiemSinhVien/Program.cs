using QuanLyDiemSinhVien;

Dictionary<string, Diemmonhoc> diemsinhvien = new Dictionary<string, Diemmonhoc>();
bool menu = true;
while (menu == true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nQUAN LY DIEM SINH VIEN");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------------------");
    Console.WriteLine("1: Them sinh vien va diem mon hoc cua cac sinh vien");
    Console.WriteLine("2: Lay danh sach tat ca sinh vien va diem");
    Console.WriteLine("3: Hien thi sinh vien co diem trung binh >= 7");
    Console.WriteLine("4: Thoat chuong trinh");
    Console.Write("\nChon menu: ");
    string chonmenu = Console.ReadLine();
    if (chonmenu == "1") themsinhvienvadiem(diemsinhvien);
    else if (chonmenu == "2") danhsachsinhvien(diemsinhvien);
    else if (chonmenu == "3") hocsinhdiemtrungbinhtren7(diemsinhvien);
    else if (chonmenu == "4") loading("Thoat");
    else loi("Sai cu phap ");
    Console.Clear();
}



#region chuc nang phu
void loading(string noidung)
{
    Console.WriteLine($"Dang {noidung}.");
    Thread.Sleep(500);
    Console.WriteLine($"Dang {noidung}..");
    Thread.Sleep(500);
    Console.WriteLine($"Dang {noidung}...");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{noidung} Thanh Cong !");
    Console.Clear();
    menu = false;
}


static void thanhcong(string noidung)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("\n" + noidung + "\nNhan phim bat ky de quay ve");
    Console.ReadKey();
}

static void loi(string noidungloi)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\n" + noidungloi + "\nNhan phim bat ky de quay ve");
    Console.ReadKey();
}

#endregion



static void themsinhvienvadiem(Dictionary<string, Diemmonhoc> diemsinhvien)
{
    Console.Clear();
    Console.Write("Nhap ma sinh vien: ");
    string masv = Console.ReadLine();
    if (diemsinhvien.ContainsKey(masv))
    {
        loi($"Ma sinh vien '{masv}' da ton tai trong he thong !");
    }
    else
    {
        Diemmonhoc diemmh = new Diemmonhoc();
        diemmh.nhapdiem();
        diemsinhvien.Add(masv, diemmh);
        thanhcong("Them sinh vien va diem thanh cong !");
    }
}

static void danhsachsinhvien(Dictionary<string, Diemmonhoc> diemsinhvien)
{
    Console.Clear();
    Console.WriteLine("DANH SACH DIEM SINH VIEN\n----------------------");
    foreach (var i in diemsinhvien)
    {
        Diemmonhoc diem = i.Value;
        Console.WriteLine($"\nMasv: {i.Key}\nDiem lap trinh: {diem.diemlaptrinh}\nDiem csdl: {diem.diemcosodulieu}\nDiem lap rap: {diem.diemlaprap}\nDiem giai thuat: {diem.diemgiaithuat}");
    }
    thanhcong("Hien thi danh sach sinh vien thanh cong !");
}

static void hocsinhdiemtrungbinhtren7(Dictionary<string, Diemmonhoc> diemsinhvien)
{
    Console.Clear();
    Console.WriteLine("DANH SACH SINH VIEN CO DIEM TRUNG BINH TREN 7\n----------------------");
    foreach (var i in diemsinhvien)
    {
        Diemmonhoc diem = i.Value;
        double dtb = (diem.diemlaptrinh + diem.diemcosodulieu + diem.diemlaprap + diem.diemgiaithuat) / 4;
        if (dtb >= 7)
            Console.WriteLine($"\nMasv: {i.Key}\nDiem lap trinh: {diem.diemlaptrinh}\nDiem csdl: {diem.diemcosodulieu}\nDiem lap rap: {diem.diemlaprap}\nDiem giai thuat: {diem.diemgiaithuat}\nDiem trung binh {dtb}");
    
    }
    thanhcong("Hien thi danh sach sinh vien thanh cong !");
}
