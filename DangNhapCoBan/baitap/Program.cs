Dictionary<string, string> accounts = new Dictionary<string, string>();
bool menu = true;
while (menu == true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nDANG NHAP CO BAN");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1. Dang ky tai khoan moi");
    Console.WriteLine("2. Dang nhap");
    Console.WriteLine("3. Hien thi danh sach tai khoan");
    Console.WriteLine("4. Xoa 1 tai khoan");
    Console.WriteLine("5. Xoa het tai khoan");
    Console.WriteLine("6. Sua tai khoan");
    Console.WriteLine("7. Thoat");
    Console.Write("\nChon: ");
    string chonmenu = Console.ReadLine();
    switch (chonmenu)
    {
        case "1":
            dangky(accounts);
            break;
        case "2":
            dangnhap(accounts);
            break;
        case "3":
            hienthi(accounts);
            break;
        case "4":
            xoataikhoan(accounts);
            break;
        case "5":
            xoahettaikhoan(accounts);
            break;
        case "6":
            suagiatri(accounts);
            break;
        case "7":
            thoatchuongtrinh();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sai cu phap !");
            break;
    }

}

 static void dangky(Dictionary<string, string> accounts)
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Nhap username: ");
        string username = Console.ReadLine();
        if (accounts.ContainsKey(username))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Username bi trung \nVui long nhap lai\n");
        }
        else
        {
            Console.Write("Nhap password: ");
            string password = Console.ReadLine();
            Console.Write("Xac nhan lai password: ");
            string password2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            accounts.Add(username, password);
            Console.WriteLine("Them thanh cong !");
            return;
        }
    }
}

static void dangnhap(Dictionary<string, string> accounts)
{
        Console.Write("nhap username: ");
        string username = Console.ReadLine();
        if (accounts.TryGetValue(username, out string password2))
        {
            Console.Write("nhap password: ");
            string password = Console.ReadLine();
            if (password2 == password)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Dang nhap thanh cong !");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sai password !");
                return;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Username khong ton tai");
            return;
        }
}
static void hienthi(Dictionary<string, string> accounts)
{
    if (accounts.Keys.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Chua co tai khoan nao trong he thong\nVui long dang ky tai khoan !");
    }
    else
    {
        foreach (var i in accounts)
        {
            Console.WriteLine($"Account: {i.Key}\nPassword: {i.Value}");
        }
    }
}

static void xoataikhoan(Dictionary<string, string> accounts)
{

        Console.Write("nhap username can xoa: ");
        string username = Console.ReadLine();
        if (accounts.TryGetValue(username, out string password2))
        {
            Console.Write("nhap password de xac nhan xoa: ");
            string password = Console.ReadLine();
            if (password2 == password)
            {
                accounts.Remove(username);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Xoa thanh cong tai khoan '{username}' !");
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sai password !");
                return;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Username khong ton tai");
            return;
        }
}

static void xoahettaikhoan(Dictionary<string, string> accounts)
{
    accounts.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Xoa thanh cong tat ca tai khoan !");
}

static void suagiatri(Dictionary<string, string> accounts)
{
    Console.Write("nhap username can thay doi: ");
    string username = Console.ReadLine();
    if (accounts.TryGetValue(username, out string password2))
    {
        Console.Write("nhap password de xac nhan: ");
        string password = Console.ReadLine();
        if (password2 == password)
        {
            Console.Write("nhap password moi: ");
            string passwordmoi = Console.ReadLine();
            accounts[username] = passwordmoi;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thay doi password thanh cong !");
            return;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sai password !");
            return;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Username khong ton tai");
        return;
    }
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



