using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exerc.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManofactureDate { get; private set; }

        public UsedProduct() { }
        public UsedProduct (string name, double price, DateTime manofactureDate) : base(name, price) 
        {
            ManofactureDate = manofactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price + " (Manufacture date: " + ManofactureDate ;
        }
    }
}
