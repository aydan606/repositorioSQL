using Celular;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("Lumia 920", "14514252565", 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();
Console.WriteLine("");
Console.WriteLine("iPhone:");
Smartphone iPhone = new Iphone("11 Pro", "8147565614", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();
