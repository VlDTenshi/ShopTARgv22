﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Domain
{
    public class FileToApi
    {
        public Guid Id { get; set; }
        public string ExistingFilePath {set; get; }
        public Guid? SpaceshipId { get; set; }
    }
}
