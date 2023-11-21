using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exerc.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price) 
        {
            CustomsFee = customsfee;
        }

        public override string PriceTag()
        {
            //verificar se vou precisar chamar o metodo TotalPrice antes aqui
            return Name + " $ " + TotalPrice() + " (Customs Fee: " + CustomsFee + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
