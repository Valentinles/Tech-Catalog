using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalog.Common.ViewModels
{
    public class KeyboardDetailViewModel : DeviceListingViewModel
    {
        public bool IsFastButtons { get; set; }
        public string Interface { get; set; }
    }
}
