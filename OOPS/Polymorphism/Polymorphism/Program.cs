//// Polymorphism

using Polymorphism.src.OopPrinciples.Polymorphism;

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new MotorCycle { Brand = "Harley Davidson", Model = "SuperSport", Year = 2021 });

/// Vehicle Inspection
foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}
