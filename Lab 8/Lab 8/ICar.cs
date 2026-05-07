using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal interface ICar
    {
        int SoChoNgoi { get; set; }

        void DongCua();
        void MoCua();
    }
}
