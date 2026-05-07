using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Vehicle : IVehicle
    {
        public string Ten { get; set; } = string.Empty;
        public int TocDo { get; set; }
        public virtual void Chay()
        {
            Console.WriteLine($"{Ten} dang chay voi toc do {TocDo} km/h.");
        }

        public virtual void Dung()
        {
            Console.WriteLine($"{Ten} da dung lai.");
        }
        public override string ToString()
        {
            return $"Ten: {Ten} ,Toc Do: {TocDo}";

        }
      
           
      
    }
}
