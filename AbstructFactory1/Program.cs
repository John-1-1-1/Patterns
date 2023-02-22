// See https://aka.ms/new-console-template for more information

using Lab_2;

Client client = new Client(new ModernFactory());
client.Factory.CreateChair().PrintInfo();
client.Factory.CreateSofa().PrintInfo();
client.Factory.CreateTable().PrintInfo();

client.Factory = new VictorianFactory();
client.Factory.CreateChair().PrintInfo();
client.Factory.CreateSofa().PrintInfo();
client.Factory.CreateTable().PrintInfo();

client.Factory = new ArDecoFactory();
client.Factory.CreateChair().PrintInfo();
client.Factory.CreateSofa().PrintInfo();
client.Factory.CreateTable().PrintInfo();
