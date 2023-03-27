// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
//Dependency: Bir nesnenin varlığının başka nesneye bağlı olması durumu:
//Matkap; ucu olmadan çalışmaz. 
//Inversion: Büyük sistem; bağımlısı olduğu nesneyi oluşturmamalı. Dışardan almalı.

Reporter reporter = new Reporter(new MailSender());
Reporter reporter2 = new Reporter(new WhatsAppSender());
Reporter reporter3 = new Reporter(new TelegramSender());

reporter.SendReport();
reporter2.SendReport();
reporter3.SendReport();