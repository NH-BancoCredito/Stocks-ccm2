using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Application.Common;
using Stocks.Domain.Repositories;
using Models = Stocks.Domain.Models;

namespace Stocks.Application.CasosUso.AdministrarProductos.RegistrarProductos
{
    public  class RegistrarProductosHandler:
        IRequestHandler<RegistrarProductosRequest, IResult>
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public RegistrarProductosHandler(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<IResult> Handle(RegistrarProductosRequest request, CancellationToken cancellationToken)
        {
            IResult response = null;                       

            //Aplicando el automapper para convertir el objeto Request a producto dominio
            var producto = _mapper.Map<Models.Producto>(request);

            /// Registrar producto
            /// 
            await _productoRepository.Adicionar(producto);

            response = new SuccessResult<int>(producto.IdProducto);

            return response;
        }
        

    }
}
