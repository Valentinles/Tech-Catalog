using System;
using System.Collections.Generic;
using System.Text;
using TechCatalog.Models.Enums;

namespace TechCatalog.Common.ViewModels
{
    public class CookerDetailViewModel : DeviceListingViewModel
    {
        public EnergyClass EnergyClass { get; set; }

        public int NumberOfFunctions { get; set; }

        public bool IsTimer { get; set; }

        public bool IsProgrammer { get; set; }

        public bool IsCatalicPanel { get; set; }

        public int Volume { get; set; }
    }
}
