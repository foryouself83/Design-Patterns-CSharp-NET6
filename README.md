# GoF Design Pattern

# 환경
Language: C# 10.0
Framework: .NET 6.0

# 목차
* Design Pattern
* Sample Code

# Design Pattern
## Creational Pattern
### Abstact Factory
> 구체적인 클래스를 지정하지 않고 관련성을 갖는 객체들의 집합을 생성하거나 서로 독립적인 객체들의 집합을 생성할 수 있는 인터페이스를 제공한다.
### Builder
> 복합 객체의 생성 과정과 표현 방법을 분리함을써 동일한 생성 공정이 서로 다른 표현을 만들 수 있게 한다.
### Factory Method
> 객체를 생성하는 인터페이스를 정의 하지만, 인스턴스를 만들 클래스의 결정은 서브 클래스가 한다. 클ㄹ래스의 인스턴스를 만드는 시점을 서브클래스로 미룬다.
### Singletorn
> 클래스의 인스턴스는 오직 하나임을 보장하며 이 인스턴스에 접근할 수 있는 방법을 제공한다.
   
## Structural Pattern
### Adapter
> 클래스의 인터페이스를 클라이언트가 기대하는 다른 인터페이스로 변환한다. 호환성이 없는 인터페이스 때문에 함께 사용할 수 없는 클래스를 개조하여 동작하도록 해준다.
### Bridge
> 추상화와 구현을 분리하여 각각을 독립적으로 변형할 수 있게 한다.
### Composite
> 부분-전체 계층을 나타내기 위해 복합 객체를 트리 구조로 만든다. 클라이언트가 개별적 객체와 복합객체 모두를 동일하게 다루도록 한다.
### Decorator
> 객체에 동적으로 책임을 추가할 수 있게 한다. 기능의 유연한 확장을 위해 상속 대신 사용할 수 있는 방법이다.
### Facade
> 서브 시스템에 있는 인터페이스 집합에 대해서 하나의 통합된 인터페이스를 제공한다. 서브 시스템을 좀 더 사용하기 편하게 하기 위해서 높은 수준의 인터페이스를 제공한다.
### Flyweight
> 작은 크기의 객체들이 여러 개 있는 경우 객체를 효과적으로 사용하는 방법으로 객체를 공유하게 한다.
### proxy
> 다른 객체로의 접근을 통제하기 위해서 다른 객체의 대리자 또는 다른 객체로의 정보 보유자를 제공한다.
## Behavioral Pattern
### Chain of Responsibility

### Command
### Interpreter
### Iterator
### Mediator
### Observer
### State
### Strategy
### Template Method
### Visitor

<a name="GoF Book">1</a>: Gof의 디자인 패턴 / Erich Gamma, Richard Helm, Ralph Johnson, John vlissides 공저, 김정아 역 / (주)피어슨 에듀케이션 코리아
