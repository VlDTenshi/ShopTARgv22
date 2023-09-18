﻿namespace Shop.Models.Spaceship
{
    public class SpaceshipsCreateViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Passengers { get; set; }
        public int EnginePower { get; set; }
        public int Crew { get; set; }
        //public string FuelType { get; set; }
        //public int FuelCapacity { get; set; }
        public string Company { get; set; }
        public int CargoWeight { get; set; }
    }
}
