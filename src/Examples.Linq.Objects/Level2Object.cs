using System;
using System.Collections.Generic;

namespace Examples.Linq.Objects
{
    public class Level2Object
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.MinValue;
        public DateTime PeriodFrom { get; set; } = DateTime.MinValue;
        public DateTime PeriodTo { get; set; } = DateTime.MinValue;
    }
}
