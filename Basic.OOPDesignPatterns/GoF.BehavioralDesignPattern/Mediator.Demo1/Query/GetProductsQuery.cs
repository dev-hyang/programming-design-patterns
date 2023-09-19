﻿using Mediator.Demo1.Data;
using Mediator.Demo1.Model;
using MediatR;

namespace Mediator.Demo1.Query
{
    public class GetProductsQuery : IRequest<List<ProductDto>> { }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
    {
        private readonly ProductsInMemory _productsInMemory;

        public GetProductsQueryHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _productsInMemory.ProductDtos;

            return Task.FromResult(products);
        }
    }
}