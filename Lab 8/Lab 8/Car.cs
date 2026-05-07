using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Car : Vehicle, ICar
    {
        public int SoChoNgoi { get; set; }
        public Car(string ten, int tocDo, int soChoNgoi)
        {
            Ten = ten;
            TocDo = tocDo;
            SoChoNgoi = soChoNgoi;
        }
        public void DongCua()
        {
            Console.WriteLine("Door closed");
            if (SoChoNgoi > 7) SoChoNgoi = 7;
        }
        public void MoCua()
        {
            Console.WriteLine("Door opened");
            SoChoNgoi = 0;
        }
        public override string ToString()
        {
            return $"Ten: {Ten} ,Toc Do: {TocDo} ,SoChoNgoi: {SoChoNgoi}";
        }
    }
}
