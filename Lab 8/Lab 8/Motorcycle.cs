using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Motorcycle : Vehicle,IMotorcycle
    {
        public void GiamToc()
        {
            Console.WriteLine("Slowing down");
            TocDo -= 5;
        }
        public void TangToc()
        {
            Console.WriteLine("Speeding up");
            TocDo += 5;
        }
        public Motorcycle(string ten, int tocDo)
        {
            Ten = ten;
            TocDo = tocDo;
        }
        public override string ToString()
        {
            return $"Ten: {Ten} ,Toc Do: {TocDo} ";
        }
    }
}
