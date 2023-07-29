using Examples.Linq.Objects;

namespace Examples.Linq.Tests
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Person() { }
        public Person(string firstName, string lastName) {  FirstName = firstName; LastName = lastName;}
    }

    public class Pet
    {
        public string Name { get; set; } = string.Empty;
        public Person? Owner { get; set; }

        public Pet() { }
        public Pet(string name, Person owner) {  Name = name; Owner = owner; }
    }

    public class TestData
    {
        public List<Level1Object> Objects = new List<Level1Object>();

        public readonly int JanuaryChildObjects = 4;
        public readonly int FebruaryChildObjects = 4;
        public readonly int TotalAuthors = 2;
        public readonly int AuthorOccourances = 4;

        static Person magnus = new(firstName: "Magnus", lastName: "Hedlund");
        static Person terry = new(firstName: "Terry", lastName: "Adams");
        static Person charlotte = new(firstName: "Charlotte", lastName: "Weiss");
        static Person arlene = new(firstName: "Arlene", lastName: "Huff");
        static Person rui = new(firstName: "Rui", lastName: "Raposo");

        public List<Person> People = new() { magnus, terry, charlotte, arlene, rui };
            
        public List<Pet> Pets = new()
            {
                new(name: "Barley", owner: terry),
                new(name: "Boots", owner: terry),
                new(name: "Whiskers", owner: charlotte),
                new(name: "Blue Moon", owner: rui),
                new(name: "Daisy", owner: magnus),
            };

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
