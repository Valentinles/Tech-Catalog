using System;
using System.Collections.Generic;

namespace TechCatalog.Models
{
    public class Mouse : Device
    {
        public string ResolutionDpi { get; set; }

        public bool IsScrollButton { get; set; }

        public bool IsErgonomic { get; set; }

        public string Interface { get; set; }
    }
}
