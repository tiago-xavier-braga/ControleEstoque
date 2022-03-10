using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    public class Produto
    {
        public String Name { get; set; }
        public short Cody { get; set; }
        public short Inventory { get; set; }
        public override string ToString()
        {
            return "Pessoa: " + Name + "\nCodigo: " + Cody + "\nQuantidade: " + Inventory;
        }
    }
    
}
