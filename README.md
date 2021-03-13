# Design Patterns
Desgin patterns are essential part of modern software development.
They help us wirte efficient and cleaner code which helps to debug fast and develop faster.

Design patterns are tested and proven solutions to common development problems which helps us to reduce our time designing code and focus more on the business logic.

There are 3 + 1 major categories of design patterns -

1. Creational
    - Singleton
    - Abstract Factory
    - Factory Method
    - Builder
2. Behavioral
   - Command
   - Iterator
   - Observer
   - Strategy
   - Template Method
3. Structural
    - Adapter
    - Decorator
    - Facade 
4. Concurrent

---------


# Design Principles
Software development especially writing code for large projects can become very troublesome if not maintained properly. 
Therefore writing maintainable code is essential for a succesful product.

There are a few priciples that help us guide to write better code and software. Starting from the easiest to understand -

## KISS
#### Keep it simple stupid

Over engineering is not a good idea in SE. Learning to keep things in
contol is very important.

## YAGNI
#### You aren't gonna need it
Adding more features and code doesn't automatically make a software great.
Knowing what is necessary and what is not can help to save a lot of time and effort. 

Therefore twice think before you code a feature.

## DRY
#### Do not repeat yourself
Well that's it.

## Bounded Context (basis of Functional Partitioning)
Bounded contexts are a central pattern in Domain-Driven Design. They provide a 
way of tackling complexity in large applications or organizations by breaking it up 
into separate conceptual modules. Each conceptual module then represents a context 
that is separated from other contexts (hence, bounded), and can evolve independently. 
Each bounded context should ideally be free to choose its own names for concepts within it, 
and should have exclusive access to its own persistence store.

At a minimum, individual web applications should strive to be their own bounded context, 
with their own persistence store for their business model, rather than sharing a database 
with other applications. Communication between bounded contexts occurs through 
programmatic interfaces, rather than through a shared database, which allows for 
business logic and events to take place in response to changes that take place. 
Bounded contexts map closely to microservices, which also are ideally implemented as 
their own individual bounded contexts.
[Source](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#bounded-contexts)

## SOLID

1. Single Responsibility Principle
2. Open Closed Principle
3. Liskov Substitution Principle
4. Interface Segregation Principle
5. Dependency Inversion Principle

