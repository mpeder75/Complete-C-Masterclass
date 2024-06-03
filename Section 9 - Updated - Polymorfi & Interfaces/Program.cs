using Section_9___Updated___Polymorfi___Interfaces;


IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
PaymentService paymentService = new PaymentService(creditCardProcessor);
paymentService.ProcessOrderPayment(100.00m);

// Polymorfi: Her bruges et interface til at oprettre et IPaymentProcessor
IPaymentProcessor paypalProcessor = new PaypalProcessor();
