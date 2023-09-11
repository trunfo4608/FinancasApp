using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Entities
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Conta> Conta { get; set; }
    }
}
