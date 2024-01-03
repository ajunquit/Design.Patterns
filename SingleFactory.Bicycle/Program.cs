using SingleFactory.Bicycle;

var bicycleFactory = new SimpleBicycleFactory();
var bikeToBuild = bicycleFactory.CreateBicycle("mountainbike");
bikeToBuild.Build();
