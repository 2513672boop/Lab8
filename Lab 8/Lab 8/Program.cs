using Lab_8;
using System.Threading.Channels;
internal class Program
{

    enum Menu
    {
        Thoat = 0,
        NhapTuFile = 1,
        ThemPhuongTien = 2,
        HienThiDanhSach = 3,
        DemSoLuong = 4,
        TimPhuongTienTheoLoai = 5,
        SapXepDanhSach = 6,
        LuuKetQuaXuongFile = 7
    }

    static void Main(string[] args)
    {
       
        DanhSachPhuongTien ds= new DanhSachPhuongTien();
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("====MENU====");
            Console.WriteLine($"{(int)Menu.NhapTuFile}/ Nhap tu file");
            Console.WriteLine($"{(int)Menu.ThemPhuongTien}/ Them");
            Console.WriteLine($"{(int)Menu.HienThiDanhSach}/ Hien thi danh sach");
            Console.WriteLine($"{(int)Menu.DemSoLuong}/ Dem so luong xe");
            Console.WriteLine($"{(int)Menu.TimPhuongTienTheoLoai}/ Tim Phuong tien theo loai ket hop");
            Console.WriteLine($"{(int)Menu.SapXepDanhSach}/ Sap xep danh sach");
            Console.WriteLine($"{(int)Menu.LuuKetQuaXuongFile}/ luu ket qua xuong file");

            Console.WriteLine($"{(int)Menu.Thoat}/ Thoat");

            Console.Write("\nChon chuc nang:");
            string? luaChonInput = Console.ReadLine();
            if (!int.TryParse(luaChonInput, out int luaChonValue) || !Enum.IsDefined(typeof(Menu), luaChonValue))
            {
                Console.WriteLine("Khong co lua chon nay");
                Console.ReadKey();
                continue;
            }

            Menu LuaChon = (Menu)luaChonValue;
            switch (LuaChon)
            {
                case Menu.NhapTuFile:
                    ds.NhapTuFile("data.txt");
                    Console.WriteLine("Da nhap tu file.");
                    break;
                case Menu.ThemPhuongTien:
                    break;
                case Menu.HienThiDanhSach:
                    Console.WriteLine(ds.ToString());
                    break;
                case Menu.DemSoLuong:
                    Console.WriteLine($"Chon: Car(1)|Motorcycle(2)");
                    string? chonInput = Console.ReadLine();
                    if (!int.TryParse(chonInput, out int chon))
                    {
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                    }
                    if (chon == 1)
                    {
                        Console.WriteLine($"Car: {ds.DemSoluongCar()}");
                    }
                    else if (chon == 2)
                    {
                        Console.WriteLine($"Motorcycle: {ds.DemSoLuongMotorcycle()}");
                    }
                    else
                    {
                        Console.WriteLine("Lua chon khong hop le.");
                    }
                    break;
                case Menu.TimPhuongTienTheoLoai:
                    break;
                case Menu.SapXepDanhSach:
                    break;
                case Menu.LuuKetQuaXuongFile:
                    break;
                case Menu.Thoat:
                    Console.WriteLine("Dang thoat chuong trinh...");
                    exit = true;
                    return;
                default:
                    Console.Write("Khong co lua chon nay");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }

}
