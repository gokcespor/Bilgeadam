using DecoratorPattern.Clients;
using DecoratorPattern.Concrete;
using DecoratorPattern.Interface;

IBilesen bilesen = new Bilesen();

Client.Display("1. Ham Hali => ", bilesen);
Client.Display("2. Ham Hali(Decorator_A ile dekore edilmiş) => ", new Decorator_A(bilesen));
Client.Display("3. Ham Hali(Decorator_B ile dekore edilmiş) => ", new Decorator_B(bilesen));
Client.Display("4. Ham Hali(Önce Decorator_A ile daha sonra Decorator_B ile dekore edilmiş) => ", new Decorator_B(new Decorator_A(bilesen)));