using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNP.contract
{
    internal class ISIN : ISecurity
    {
        /// <summary>
        ///  A security is a financial instrument identified by an ISIN, an alphanumeric code of 12 characters
        /// </summary>
        [MaxLength(12)]
        [MinLength(12)]
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
