  using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = Stocks.Domain.Models;

namespace Stocks.Application.CasosUso.AdministrarProductos.RegistrarProductos
{
    public class RegistrarProductosMapper: Profile
    {
        public RegistrarProductosMapper() {
            CreateMap<RegistrarProductosRequest, Models.Producto>();

        }
    }
}
