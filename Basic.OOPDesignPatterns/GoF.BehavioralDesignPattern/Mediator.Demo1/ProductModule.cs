using Autofac;
using Mediator.Demo1.Command;
using Mediator.Demo1.EventModel;
using Mediator.Demo1.Query;

namespace Mediator.Demo1
{
    public class ProductModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GetProductQuery>().AsImplementedInterfaces();
            builder.RegisterType<GetProductsQuery>().AsImplementedInterfaces();
            builder.RegisterType<AddOrUpdateProductCommand>().AsImplementedInterfaces();
            builder.RegisterType<DeleteProductCommand>().AsImplementedInterfaces();
            builder.RegisterType<PublishProductEvent>().AsImplementedInterfaces();

            builder.RegisterType<GetProductQueryHandler>().AsImplementedInterfaces();
            builder.RegisterType<GetProductsQueryHandler>().AsImplementedInterfaces();
            builder.RegisterType<AddOrUpdateProductCommandHandler>().AsImplementedInterfaces();
            builder.RegisterType<DeleteProductCommandHandler>().AsImplementedInterfaces();
            builder.RegisterType<PublishProductEventMessageHandler>().AsImplementedInterfaces();
            builder.RegisterType<PublishProductEventTextHandler>().AsImplementedInterfaces();
        }
    }
}