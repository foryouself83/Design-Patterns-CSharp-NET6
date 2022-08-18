# Design Pattern   

# 환경
Language: C# 10.0   
Framework: .NET 6.0
   
# 목차
* [GoF Design Pattern](https://github.com/foryouself83/DesignPattern/blob/master/README.md#gof-design-pattern)
* [Compound Pattern](https://github.com/foryouself83/DesignPattern/blob/master/README.md#compound-pattern)

# GoF Design Pattern
## 문제 해결 방법
- **적당한 객체 찾기**   
프로세스나 알고리즘을 객체로 만들고 Strategy, State, Visit 등을 이용해 설계를 좀 더 `유연하고 재사용`한 것으로 만들려는 노력이 필요하다.
- **객체 크기와 책임 결정**   
Facade을 이용하여 서브 시스템을 어떻게 객체로 만들 수 있고 [Flyweight](https://github.com/foryouself83/DesignPattern/blob/master/README.md#flyweight)을 이용하여 많은 객체를 효율적으로 다룰 수 있다. Abstact Factory, Builder를 이용하여 다른 객체를 `생성하는 책임`만 갖는 객체를 만들거나 Visitor, [Command](https://github.com/foryouself83/DesignPattern/blob/master/README.md#Command) 등을 이용하여 다른 객체에서 `요청에 대한 책임`을 갖도록 객체를 만들 수 있다.
- **객체 인터페이스 명세**   
인터페이스는 구현에 대해서는 전혀 알려주지 않기 때문에 인터페이스를 정의한 서로 다른 객체에서 구현 방법을 결정할 수 있다. 동일한 인터페이스를 갖는 객체들은 완전히 다른 구현을 가질 수 있다는 것으로 동일한 요청이라도 처리하는 객체에 따라 전혀 다른 결과가 나올 수 있다. 요청을 처리할 객체를 런타임 시에 결정하는 기법을 `동적 바인딩(dynamic binding)` 이라고 한다.
이런 대체성은 객체 지향 프로그래밍의 3요소 중 하나인 `다형성` 이라는 핵심 개념이다.
- **인터페이스 관점의 개발**   
클래스 `상속`은 기본적으로 부모 클래스에 정의한 구현의 `재사용`을 통해 기능성을 확장하는 매커니즘이다. 모든 클래스가 `추상 클래스를 상속`하도록 하여 인터페이스를 공유할 수 있게 된다면 부모 클래스에 정의된 요청을 자식 클래스에 전달되어도 처리할 수 있다는 의미이다. 이는 자식 클래스 간의 `종속성`을 저하시키며 `재사용` 가능한 객체지향 원칙을 만족한다.
- **디자인 패턴 선택**
  - 특정 클래스로부터 객체 생성으로 인한 종속성
    > 디자인 패턴: Abstact Factory, [Factory Method](https://github.com/foryouself83/DesignPattern/blob/master/README.md#factory-method), Prototype    
  - 특정 오퍼레이션으로의 종속성
    > 디자인 패턴: [Chain of Responsibility](https://github.com/foryouself83/DesignPattern/blob/master/README.md#chain-of-responsibility), [Command](https://github.com/foryouself83/DesignPattern/blob/master/README.md#Command)
  - 하드웨어와 소프트웨어 플랫폼의 종속성
    > 디자인 패턴: Abstact Factory, Bridge
  - 객체의 구현의 종속성
    > 디자인 패턴: Abstact Factory, Bridge, Memento, Proxy
  - 알고리즘의 종속성
    > 디자인 패턴: Builder, Iterator, Strategy, Template Method, Visitor
  - 높은 결합도
    > 디자인 패턴: Abstact Factory, Bridge, [Chain of Responsibility](https://github.com/foryouself83/DesignPattern/blob/master/README.md#chain-of-responsibility), [Command](https://github.com/foryouself83/DesignPattern/blob/master/README.md#Command), Facade, [Mediator](https://github.com/foryouself83/DesignPattern/blob/master/README.md#mediator), Observer
  - 서브클래싱을 통한 기능성 확장성
    > 디자인 패턴: Bridge, [Chain of Responsibility](https://github.com/foryouself83/DesignPattern/blob/master/README.md#chain-of-responsibility), Decorator, Observer, Strategy
  - 클래스 변경의 편의성
    > 디자인 패턴: Adapter, Decorator, Visitor
## Creational Pattern
객체 생성 매커니즘을 다루는 디자인 패턴으로 설계 과정에서 문제를 일으키거나 복잡성을 줄이기 위해 사용한다.
### Abstact Factory
> 구체적인 클래스를 지정하지 않고 관련성을 갖는 객체들의 집합을 생성하거나 서로 독립적인 객체들의 집합을 생성할 수 있는 인터페이스를 제공한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Builder
> 복합 객체의 생성 과정과 표현 방법을 분리함을써 동일한 생성 공정이 서로 다른 표현을 만들 수 있게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### [Factory Method](<https://github.com/foryouself83/DesignPattern/tree/master/Compound>)
> 객체를 생성하는 인터페이스를 정의 하지만, 인스턴스를 만들 클래스의 결정은 서브 클래스가 한다. 클래스의 인스턴스를 만드는 시점을 서브클래스로 미룬다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### [Singleton](<https://github.com/foryouself83/DesignPattern/tree/master/Compound>)
> 클래스의 인스턴스는 오직 하나임을 보장하며 이 인스턴스에 접근할 수 있는 방법을 제공한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
   
## Structural Pattern
클래스와 객체간의 관계 또는 책임을 파악해서 설계를 용이하게 하기 위해 사용한다.
### Adapter
> 클래스의 인터페이스를 클라이언트가 기대하는 다른 인터페이스로 변환한다. 호환성이 없는 인터페이스 때문에 함께 사용할 수 없는 클래스를 개조하여 동작하도록 해준다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Bridge
> 추상화와 구현을 분리하여 각각을 독립적으로 변형할 수 있게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Composite
> 부분-전체 계층을 나타내기 위해 복합 객체를 트리 구조로 만든다. 클라이언트가 개별적 객체와 복합객체 모두를 동일하게 다루도록 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Decorator
> 객체에 동적으로 책임을 추가할 수 있게 한다. 기능의 유연한 확장을 위해 상속 대신 사용할 수 있는 방법이다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Facade
> 서브 시스템에 있는 인터페이스 집합에 대해서 하나의 통합된 인터페이스를 제공한다. 서브 시스템을 좀 더 사용하기 편하게 하기 위해서 높은 수준의 인터페이스를 제공한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### [Flyweight](<https://github.com/foryouself83/DesignPattern/tree/master/Compound>)
> 작은 크기의 객체들이 여러 개 있는 경우 객체를 효과적으로 사용하는 방법으로 객체를 공유하게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)

생성에 시간이 오래 소요되는 객체가 있을 경우(ex. I/O) 최초 생성시에만 객체를 생성하고 이후에는 생성된 객체를 공유하도록 한다. 불필요한 객체 생성을 방지하고 메모리 및 성능 향상에 도움이 된다.
### proxy
> 다른 객체로의 접근을 통제하기 위해서 다른 객체의 대리자 또는 다른 객체로의 정보 보유자를 제공한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
   
## Behavioral Pattern
알고리즘과 객체 간의 책임 분배에 관련된 패턴으로 객체 간의 결합도를 낮춰 유연성을 향상 시키기위해 사용한다.
### [Chain of Responsibility](<https://github.com/foryouself83/DesignPattern/tree/master/ChainOfResponsibility>)
> 요청을 처리할 수 있는 기회를 하나 이상의 객체에 부여함으로써 요청하는 객체와 처리하는 객체 사이의 결합도를 없애려는 것이다. 요청을 해결할 객체를 만날 때까지 객체 고리를 따라서 요청을 전달한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### [Command](<https://github.com/foryouself83/DesignPattern/tree/master/Command>)
> 요청을 객체로 캡슐화함으로써 서로 다른 요청으로 클라이언트를 파라미터화하고, 요청을 저장하거나 기록을 남겨서 오퍼레이션의 취소도 가능하게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)

호출하는 부분과 실제 기능을 실행하는 부분의 의존성을 제거하여 호출부의 변경 없이 수신부의 변경이 가능하다.

### Interpreter
> 언어에 따라서 문법에 대한 표현을 정의한다. 또 언어의 문장을 해석하기 위해 정의된 표현에 기반하여 분석기를 정의한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Iterator
> 내부 표현 방법을 노출하지 않고 복합 객체의 원소를 순차적으로 접근할 수 있는 방법을 제공한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### [Mediator](<https://github.com/foryouself83/DesignPattern/tree/master/Mediator>)
> 객체들 간의 상호 작용을 객체로 캡슐화한다. 객체들 간의 참조 관계를 객체에서 분리함을써 상호작용만을 독립적으로 다양하게 확대할 수 있다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)

M:N 관계에 해당 패턴을 사용하면 M:1 관계로 만들어 복잡도를 내릴 수 있다. 또한 상호작용에 대한 부분이 한 객체에 모여있어 구현이 편해지는 장점이 있다.
### Memento
> 캡슐화를 위배하지 않고 객체 내부 상태를 객체화하여, 나중에 객체가 이 상태로 복구 가능하게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Observer
> 객체 사이에 일 대 다의 종속성을 정의하고 한 객체의 상태가 변하면 종속된 다른 객체에 통보가 가고 자동으로 수정이 일어나게 된다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### State
> 객체의 내부 상태에 따라 행위를 변경할 수 있게 한다. 이렇게 하면 객체는 마치 클래스를 바꾸는 것처럼 보인다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Strategy
> 알고리즘 군이 존재할 경우 각각의 알고리즘을 별도의 클래스로 캡슐화하고 이들을 상호 교환 가능한 것으로 정의한다. 클라이언트에 영향을 주지 않고 독립적으로 알고리즘을 다양하게 변경할 수 있게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Template Method
> 오퍼레이션에는 알고리즘의 처리 과정만 정의하고 각 단계에서 수행할 구체적 처리는 서브클래스에 정의한다. 알고리즘의 처리 과정은 변경하지 않고 알고리즘 각 단계의 처리를 서브 클래스에서 재정의할 수 있게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)
### Visitor
> 객체 구조의 요소들에 수행할 오퍼레이션을 표현한 패턴이다. 오퍼레이션이 처리할 요소의 클래스를 변경하지 않고도 새로운 오퍼레이션을 정의할 수 있게 한다.[<sup>[1]</sup>](<https://github.com/foryouself83/DesignPattern/blob/master/README.md#%EA%B0%81%EC%A3%BC>)

# [Compound Pattern](<https://github.com/foryouself83/DesignPattern/tree/master/Compound>)
두개 이상의 패턴을 이용하여 일반적인 문제를 해결하는 패턴이다. 대표적인 예로 MVC 패턴이 있다.
 ## MVC
 ## MVP
 ## MVVM
## 각주
<a name="GoF Design Pattern Book">1</a>: Gof의 디자인 패턴 / Erich Gamma, Richard Helm, Ralph Johnson, John vlissides 공저, 김정아 역 / (주)피어슨 에듀케이션 코리아
