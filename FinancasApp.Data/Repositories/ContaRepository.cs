using FinancasApp.Data.Contexts;
using FinancasApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Repositories
{
    public class ContaRepository
    {

        public void Create(Conta conta)
        {
            using (var dataContext =new DataContext())
            {
                dataContext.Add(conta);
                dataContext.SaveChanges();
            }
        }


        public void Update(Conta conta)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(conta);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Conta conta)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(conta);
                dataContext.SaveChanges();
            }
        }

        public List<Conta> GetAll(DateTime dataMin,DateTime dataMax,Guid usuarioId)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Conta
                    .Include(c => c.Categoria) //LEFT JOIN
                    .Where(c => c.Data >= dataMin && c.Data <= dataMax && c.UsuarioId == usuarioId)
                    .OrderBy(c => c.Data)
                    .ToList();
            }

        }


        public Conta? GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Conta
                    //.Include(c => c.Categoria) //LEFT JOIN
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
            }
        }

   



    }
}
