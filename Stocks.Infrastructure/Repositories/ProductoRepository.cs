using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Domain.Models;
using Stocks.Domain.Repositories;

namespace Stocks.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
       

        public Task<bool> Adicionar(Producto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Producto> Consultar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producto>> Consultar(string nombre)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(Producto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
