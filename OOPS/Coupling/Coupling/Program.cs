///// Coupling


using Coupling.src.OopPrincoples.Coupling;

var order = new Order(new SmsService());
order.PlaceOrder();
