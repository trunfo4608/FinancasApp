using FinancasApp.Data.Contexts;
using FinancasApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Repositories
{
    public class CategoriaRepository
    {

        public List<Categoria> GetAll()
        {

            using(var dataContext = new DataContext())
            {
                return dataContext.Categoria
                    .OrderBy(c => c.Nome)
                    .ToList();
            }
        }
    }
}
