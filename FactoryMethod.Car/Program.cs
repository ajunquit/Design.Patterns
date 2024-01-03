// See https://aka.ms/new-console-template for more information

using FactoryMethod.Car;

CarFactory dealerShip = new ChevroletFactory();

Car customerCar = dealerShip.CreateCar();

customerCar.Assemble();