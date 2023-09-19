# Pre-words
These tutorial is originated from this website: https://dotnettutorials.net/course/dot-net-design-patterns/
which are mostly covered by the legend book "Gang of Four" - Elements of Reusable Object-Oriented Software.

# What are Design Patterns?
Design Patterns are just best practices of industry software development methodology around OOP in a given context.
It's reusable and basically aiming at solving Object Generation and Integration problems.
* Design Patterns is not a Silver Bullet
* Do not overdo Design Patterns
Sometimes simple projects don't neeed design patterns. So be aware different Design Patterns have their context and background(Pros & Cons).

# Type of Design Patterns 
1. Creational Design Pattern: Object Creation and Initialization
The context means we have a lot of objects/instances to be created. If we put the creation logic in the client code(which is the invoker), it means the creation logic is not centralized which could lead to a very complicated client code everywhere.
The Creational Design Pattern help to centralize the creation/initialization logic. Based on the conditions, it would return expected object to the client. The client does not need to know how the object is created and initialized(Encapsulation).

Examples: **Singleton, Factory, Builder, ProtoType, Fluent Interface, Factory Method, Abstract Factory**

2. Structural Design Pattern: Structural Changes of Classes, and interfaces, and the reationship between classes
The context mainly describes the impact to the relationships between classes along with requirement changes. How we could better organize their relationships to better adapt to future progress with minimum changes.

Examples: **Adapter, Facade, Decorator, Composite, Proxy, Flyweight, and Bridge**

3. Behavioral Design Pattern: Communication between objects
If you want to change the behavior of the class/object, you want it to affect other classes as well.

Examples: **Chain of Responsibility, Command, Observer, Iterator, State, Template Method, Visitor, Strategy, Mediator, Memento, Interpreter**

4. Other Design Patterns
**Dependency Injection, DI using Unity Container, Repository Pattern, Repository using Unity of Work, Inversion of Control**
