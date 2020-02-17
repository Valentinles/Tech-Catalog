using System;
using System.Collections.Generic;
using System.Text;
using TechCatalog.Models.Enums;

namespace TechCatalog.Common.ViewModels
{
    public class TvDetailViewModel : DeviceListingViewModel
    {
        public Resolution Resolution { get; set; }

        public ScreenTechnology ScreenTechnology { get; set; }

        public decimal DisplaySizeInch { get; set; }

        public bool IsVoiceControl { get; set; }

        public bool IsSmartTv { get; set; }
    }
}
