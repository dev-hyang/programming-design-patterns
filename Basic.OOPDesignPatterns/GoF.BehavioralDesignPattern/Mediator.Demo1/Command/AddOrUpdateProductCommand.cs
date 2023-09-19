using Mediator.Demo1.Data;
using Mediator.Demo1.Model;
using MediatR;

namespace Mediator.Demo1.Command
{
    public class AddOrUpdateProductCommand : IRequest<bool>
    {
        public ProductDto ProductDto { get; set; }
    }

    public class AddOrUpdateProductCommandHandler : IRequestHandler<AddOrUpdateProductCommand, bool>
    {
        private readonly ProductsInMemory _productsInMemory;

        public AddOrUpdateProductCommandHandler()
        {
            _productsInMemory = new ProductsInMemory();
        }

        public Task<bool> Handle(AddOrUpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct =
                _productsInMemory.ProductDtos.FirstOrDefault(p => p.Sku.Equals(request.ProductDto.Sku));

            if (existingProduct != null)
            {
                var index = _productsInMemory.ProductDtos.FindIndex(p => p.Sku.Equals(request.ProductDto.Sku));
                _productsInMemory.ProductDtos[index] = request.ProductDto;
                return Task.FromResult(true);
            }

            _productsInMemory.ProductDtos.Add(request.ProductDto);
            return Task.FromResult(true);
        }
    }
}