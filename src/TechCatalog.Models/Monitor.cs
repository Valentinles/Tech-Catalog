using System;
using System.Collections.Generic;
using TechCatalog.Models.Enums;

namespace TechCatalog.Models
{
    public class Monitor : Device
    {
        public string Contrast { get; set; }

        public string DisplayType { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public RefreshRate RefreshRate { get; set; }

        public Resolution Resolution { get; set; }

        public string Dimension { get; set; }
    }
}
