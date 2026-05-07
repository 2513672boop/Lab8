using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class DanhSachPhuongTien
    {
        List<IVehicle> collection=new List<IVehicle>();
        public void Them(IVehicle a)
        {
            collection.Add(a);
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in collection)
            {
                str += "\n" + item;
            }
            return str;
        }
        private IVehicle PhanTichDong(string dong)
        {
            string[] part = dong.Split(',');
            string loai = part[0].Trim();
            string ten = part[1].Trim();
            int tocDo = int.Parse(part[2].Trim());
            if (loai == "Car")
            { 
                int soChoNgoi = int.Parse(part[3].Trim());
                return new Car (ten, tocDo, soChoNgoi);
            }
            return new Motorcycle(ten, tocDo);

        }
        public void NhapTuFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"[ERROR] khong tim thay file:{filePath}");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            { 
                if (!string.IsNullOrEmpty(line))
                    collection.Add(PhanTichDong (line));
            }
            Console.WriteLine($"Da doc {collection.Count} phuong tien tu file");
        }
        public int DemSoluongCar()
        {
            return collection.OfType<Car>().Count();
        }
        public int DemSoLuongMotorcycle()
        {
            return collection.OfType<Motorcycle>().Count();
        }
    }
}
