using System;
using System.Collections.Generic;
using System.Text;
using TechCatalog.Models.Enums;

namespace TechCatalog.Common.ViewModels
{
    public class RefrigeratorDetailViewModel : DeviceListingViewModel
    {
        public EnergyClass EnergyClass { get; set; }

        public decimal Height { get; set; }

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int TotalCapacity { get; set; }

        public int CapacityRefrigerator { get; set; }

        public int CapacityFreezer { get; set; }

        public int NumberOfShelves { get; set; }

        public int NoiseLevel { get; set; }
    }
}
