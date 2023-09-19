# What is MediatR
MediatR is a library that was created by Jimmy Boggard3 based on the Mediator pattern4, which promotes loose coupling by keeping objects from referring to each other explicitly.
MediatR handles two types of message it dispatches:
* Request/response messages, dispatched to a single handler
* Notification messages, dispatched to multiple handlers
	it works as a broadcast, where the notification is sent to multiple listensers

# Why AutoFac
When you think about MediatR, the Inversion of Control(IoC) container that comes handy is Autofac
e.g. MediatR.Extensions.Autofac.DependencyInjection



