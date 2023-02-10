using FactoryPattern;
using FactoryPattern.PizzaStores;

var nyStore = new NYPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

nyStore.OrderPizza(PizzaType.Cheese);
chicagoStore.OrderPizza(PizzaType.Veggie);

// Abstract Factory
// Use when there is a family of products to create 
// to make sure clients create products that belong together

// Factory Method
// Use to decouple client code from concrete classes or don't know how many concrete classes are needed
// Subclass and implement factory method