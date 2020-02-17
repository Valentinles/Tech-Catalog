using System;
using System.Collections.Generic;
using System.Text;

namespace TechCatalog.Common.ViewModels
{
    public class MouseDetailViewModel : DeviceListingViewModel
    {
        public string ResolutionDpi { get; set; }

        public bool IsScrollButton { get; set; }

        public bool IsErgonomic { get; set; }

        public string Interface { get; set; }
    }
}
