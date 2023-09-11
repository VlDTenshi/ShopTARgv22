﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Domain
{
    public class Spaceship
    {
        public Guid? Id {get ; set;}
        public string Name { get; set;}
        public string Type { get; set;}
        public int Passengers { get; set;}
        public int EnginePower { get; set;}
        public int Crew { get; set;}
        public string Company { get; set;}
        public int CargoWeight { get; set;}

        //only in database
        public DateTime CreatedAt { get; set;}
        public  DateTime ModifiedAt { get; set;}

    }
}
