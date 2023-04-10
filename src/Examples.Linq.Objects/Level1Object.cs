using System;
using System.Collections.Generic;

namespace Examples.Linq.Objects
{
    public class Level1Object
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public List<Level2Object> Children { get; set; } = new List<Level2Object>();
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.MinValue;
    }
}
