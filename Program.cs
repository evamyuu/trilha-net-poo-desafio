using DesafioPOO.Models;

// Demonstrate functionality with a Nokia smartphone

Console.WriteLine("Nokia Smartphone:");
Smartphone nokia = new Nokia(number: "+555199999-9999", model: "Nokia 8.3 5G", imei: "123456789012345", memory: 64);
nokia.MakeCall();
nokia.InstallApp("WhatsApp");
nokia.TurnOff();

// Demonstrate functionality with an iPhone smartphone
Console.WriteLine("\nIphone Smartphone:");
Smartphone iphone = new Iphone(number: "+555199999-8888", model: "iPhone 12 Pro", imei: "543210987654321", memory: 128);
iphone.ReceiveCall();
iphone.InstallApp("Telegram");
iphone.TurnOff();