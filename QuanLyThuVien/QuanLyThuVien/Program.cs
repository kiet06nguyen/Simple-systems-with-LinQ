using System.Data;

Dictionary<string, List<string>> thuvien = new Dictionary<string, List<string>>();
bool menu = true;
while (menu == true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nQUAN LY THU VIEN");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("---------------------------");
    Console.WriteLine("1: Them hoc sinh va sach");
    Console.WriteLine("2: Hien thi ma hoc sinh va sach da muon");
    Console.WriteLine("3: Hien thi hoc sinh da muon tu 3 sach tro len");
    Console.WriteLine("4: Thoat chuong trinh");
    Console.Write("\nChon menu: ");
    string chonmenu = Console.ReadLine();

    if (chonmenu == "1") themhocsinh(thuvien);
    else if (chonmenu == "2") hienthisach(thuvien);
    else if (chonmenu == "3") sachtren3(thuvien);
    else if (chonmenu == "4") thoatchuongtrinh();
    else saicuphap();
}
void thoatchuongtrinh()
{
    Console.WriteLine("Dang thoat.");
    Thread.Sleep(500);
    Console.WriteLine("Dang thoat..");
    Thread.Sleep(500);
    Console.WriteLine("Dang thoat...");
    Thread.Sleep(500);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Thoat thanh cong !");
    Console.Clear();
    menu = false;
}
static void saicuphap()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Sai cu phap !\n Nhan phim bat ky de quay ve");
    Console.ReadKey();
}

static void loading()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\nNhan phim bat ky de quay ve");
    Console.ReadKey();
}
static List<string> danhsachsach()
{
    Console.Clear();
    List<string> tensach = new List<string>();
    bool menusach = true;
    while (menusach == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nDANH SACH THU VIEN");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("---------------------------");
        Console.WriteLine("1: Sach lap trinh C#");
        Console.WriteLine("2: Sach co so du lieu");
        Console.WriteLine("3: Sach giai thuat");
        Console.WriteLine("4: Sach tin hoc");
        Console.WriteLine("5: Them sach va thoat");
        #region danh sach da them
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("--> Danh sach da them: ");
        foreach (var i in tensach) Console.Write(i+ ", ");
        Console.ForegroundColor = ConsoleColor.White;
        #endregion
        Console.Write("\nChon menu: ");
        string chonmenu = Console.ReadLine();
        if (chonmenu == "1") tensach.Add("Sach lap trinh C#");
        else if (chonmenu == "2") tensach.Add("Sach co so du lieu");
        else if (chonmenu == "3") tensach.Add("Sach giai thuat");
        else if (chonmenu == "4") tensach.Add("Sach tin hoc");
        else if (chonmenu == "5") menusach = false;
        else saicuphap();
        Console.Clear();
    }

    return tensach;
}
static void themhocsinh(Dictionary<string, List<string>> thuvien)
{
    Console.Write("Nhap ma hoc sinh: ");
    string mahocsinh = Console.ReadLine();
    if (thuvien.ContainsKey(mahocsinh))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Ma hoc sinh da ton tai trong he thong !");
    }
    else
    {
        List<string> listsach = danhsachsach();
        thuvien.Add(mahocsinh, listsach);    
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Them hoc sinh va sach da muon thanh cong !");
        loading();
    }     
}

static void hienthisach(Dictionary<string, List<string>> thuvien)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nDANH SÁCH HỌC SINH ĐÃ MƯỢN SÁCH");
    Console.ForegroundColor = ConsoleColor.White;

    foreach (var i in thuvien)
    {
        string danhsach = string.Join(", ", i.Value);
        Console.WriteLine($"Ma hoc sinh: {i.Key} | Sach da muon: {danhsach}");
    }
    Console.ResetColor(); 
    loading();
}


static void sachtren3(Dictionary<string, List<string>> thuvien)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nDANH SACH HOC SINH DA MUON TREN 3 SACH");
    Console.ForegroundColor = ConsoleColor.White;
    var hocsinhtren3 = thuvien.Where(i => i.Value.Count >= 3);
    foreach (var i in hocsinhtren3)
    {
        Console.WriteLine($"Ma hoc sinh: {i.Key}");
    }
    Console.ResetColor();
    loading();
}



