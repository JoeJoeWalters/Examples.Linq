using Examples.Linq.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Linq.Tests
{
    public class TestData
    {
        public List<Level1Object> Objects = new List<Level1Object>();

        public TestData() 
        {
            Objects = new List<Level1Object>()
            {
                new Level1Object()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "FirstObject",
                    CreatedBy = "Joe",
                    CreatedOn = new DateTime(2023, 1, 1),
                    Children = new List<Level2Object>
                    { 
                        new Level2Object() 
                        { 
                            Id = Guid.NewGuid().ToString(),
                            Name = "FirstChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 1)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "SecondChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 2)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "ThirdChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 3)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "FourthChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 4)
                        }
                    }
                },
                new Level1Object()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "SecondObject",
                    CreatedBy = "Dave",
                    CreatedOn = new DateTime(2023, 2, 1),
                    Children = new List<Level2Object>
                    {
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "FirstChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 1)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "SecondChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 2)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "ThirdChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 3)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "FourthChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 4)
                        }
                    }
                }
            };
        }
    }
}
