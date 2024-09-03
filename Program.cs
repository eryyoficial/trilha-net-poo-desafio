using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone - Nókia");
Smartphone nok = new Nokia("112233","Modelo 1","11111111",64);
nok.Ligar();
nok.InstalarAplicativo("Angry Bird");

Console.WriteLine("\nSmartphone - IPhone");
Smartphone ip = new Iphone("332211","Modelo 2","1111111",123);
ip.ReceberLigacao();
ip.InstalarAplicativo("App Store");
