Dictionary<string, string> nhanvien = new Dictionary<string, string>();
bool menu = true;
while (menu == true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nQUAN LY NHAN VIEN");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("------------------------------");
    Console.WriteLine("1: Them nhan vien moi");
    Console.WriteLine("2: Cap nhat ten nhan vien theo ma");
    Console.WriteLine("3: Xoa nhan vien theo ma so duoc nhap tu ban phim");
    Console.WriteLine("4: Hien thi danh sach nhan vien");
    Console.WriteLine("5: Thoat chuong trinh");
    Console.Write("\nChon menu: ");
    string chonmenu = Console.ReadLine();
    if (chonmenu == "1") themnhanvienmoi(nhanvien);
    else if (chonmenu == "2") capnhattennhanvien(nhanvien);
    else if (chonmenu == "3") xoanhanvientheoma(nhanvien);
    else if (chonmenu == "4") hienthidanhsachnhanvien(nhanvien);
    else if (chonmenu == "5") loading("Thoat");
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

static void themnhanvienmoi(Dictionary<string, string> nhanvien)
{
    Console.Write("Nhap ma nhan vien: ");
    string manv = Console.ReadLine();
    if (nhanvien.ContainsKey(manv))
    {
        loi($"Ma {manv} da ton tai trong he thong !");
    }
    else
    {
        Console.Write("Nhap ten nhan vien: ");
        string tennv = Console.ReadLine();
        nhanvien.Add(manv, tennv);
        thanhcong("Them nhan vien thanh cong !");
    }
}

static void capnhattennhanvien(Dictionary<string, string> nhanvien)
{
    Console.Write("Nhap ma nhan vien can cap nhat: ");
    string manv = Console.ReadLine();
    if (nhanvien.ContainsKey(manv))
    {
        Console.Write("Nhap ten nhan vien moi: ");
        string tennvmoi = Console.ReadLine();
        nhanvien[manv] = tennvmoi;
        thanhcong($"Cap nhat ten nhan vien thanh cong !");
    }
    else
    {
        loi($"Ma {manv} khong ton tai trong he thong !");
    }
}

static void xoanhanvientheoma(Dictionary<string, string> nhanvien)
{
    Console.Write("Nhap ma nhan vien can xoa: ");
    string manv = Console.ReadLine();
    if (nhanvien.ContainsKey(manv))
    {
        nhanvien.Remove(manv);
        thanhcong($"Xoa thanh cong nhan vien co ma {manv} !");
    }
    else
    {
        loi($"Ma {manv} khong ton tai trong he thong !");
    }
}

static void hienthidanhsachnhanvien(Dictionary<string, string> nhanvien)
{
    if (nhanvien.Count == 0) loi($"Khong co nhan vien nao trong he thong !");
    else
    {
        foreach (var i in nhanvien) 
            Console.WriteLine($"Ma nhan vien: {i.Key} | Ten nhan vien {i.Value}");
        thanhcong("Xoa nhan vien thanh cong");
    }
        
}
