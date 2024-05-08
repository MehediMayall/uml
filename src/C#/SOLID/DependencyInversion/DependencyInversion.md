#### Dependency Inversion Principle
The Dependency Inversion Principle (DIP) emphasizes decoupling and abstraction. 

The principle consists of two core concepts:
    - high-level modules should not depend on low-level modules
    - both should depend on abstractions.
This inverted dependency relationship promotes flexbility, testability, and maintainability.


#### Without dependency inversion

```mermaid
classDiagram
    class Car{
        string name
        CombustionEngine engine
        Car(CombustionEngine engine)
        start()
    }

    class CombustionEngine{
        string name
        start()
    }

    Car..>CombustionEngine
```



#### Dependency Inversion

```mermaid
classDiagram

    class IEngine{
        <<interface>>
        start()
    }

    class Car{
        string name
        CombustionEngine engine
        Car(CombustionEngine engine)
        start()
    }

    class CombustionEngine{
        string name
        start()
    }
    class ElectricEngine{
        string name
        start()
    }

    Car..>IEngine: Flow of control
    IEngine..>CombustionEngine: Flow of dependencies
    IEngine..>ElectricEngine: Flow of dependencies

```
