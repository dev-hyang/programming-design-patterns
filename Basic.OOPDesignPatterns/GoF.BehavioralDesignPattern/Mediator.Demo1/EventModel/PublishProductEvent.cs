using MediatR;

namespace Mediator.Demo1.EventModel
{
    public class PublishProductEvent : INotification
    {
        public string Message { get; set; }
    }

    public class PublishProductEventMessageHandler : INotificationHandler<PublishProductEvent>
    {
        public Task Handle(PublishProductEvent notification, CancellationToken cancellationToken)
        {
            //TODO: Send message
            Console.WriteLine($"Message: {notification.Message}");
            return Task.CompletedTask;
        }
    }

    public class PublishProductEventTextHandler : INotificationHandler<PublishProductEvent>
    {
        public Task Handle(PublishProductEvent notification, CancellationToken cancellationToken)
        {
            //TODO: Send text
            Console.WriteLine($"Text: {notification.Message}");
            return Task.CompletedTask;
        }
    }
}