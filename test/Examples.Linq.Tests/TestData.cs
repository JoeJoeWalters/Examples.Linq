﻿using Examples.Linq.Objects;
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

        public readonly int JanuaryChildObjects = 4;
        public readonly int FebruaryChildObjects = 4;
        public readonly int TotalAuthors = 2;
        public readonly int AuthorOccourances = 4;

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
                            CreatedOn = new DateTime(2023, 1, 1),
                            PeriodFrom = new DateTime(2023, 1, 1),
                            PeriodTo = new DateTime(2023, 1, 31)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "SecondChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 2),
                            PeriodFrom = new DateTime(2023, 1, 1),
                            PeriodTo = new DateTime(2023, 1, 31)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "ThirdChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 3),
                            PeriodFrom = new DateTime(2023, 1, 1),
                            PeriodTo = new DateTime(2023, 1, 31)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "FourthChildObject",
                            CreatedBy = "Joe",
                            CreatedOn = new DateTime(2023, 1, 4),
                            PeriodFrom = new DateTime(2023, 1, 1),
                            PeriodTo = new DateTime(2023, 1, 31)
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
                            CreatedOn = new DateTime(2023, 2, 1),
                            PeriodFrom = new DateTime(2023, 2, 1),
                            PeriodTo = new DateTime(2023, 2, 28)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "SecondChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 2),
                            PeriodFrom = new DateTime(2023, 2, 1),
                            PeriodTo = new DateTime(2023, 2, 28)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "ThirdChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 3),
                            PeriodFrom = new DateTime(2023, 2, 1),
                            PeriodTo = new DateTime(2023, 2, 28)
                        },
                        new Level2Object()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "FourthChildObject",
                            CreatedBy = "Dave",
                            CreatedOn = new DateTime(2023, 2, 4),
                            PeriodFrom = new DateTime(2023, 2, 1),
                            PeriodTo = new DateTime(2023, 2, 28)
                        }
                    }
                }
            };
        }
    }
}
