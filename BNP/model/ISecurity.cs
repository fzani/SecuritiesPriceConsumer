using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.contract
{
    public interface ISecurity
    {
        string Name { get; set; }
        int Price { get; set; }
        DateTime CurrentDate { get; set; }
    }
}
