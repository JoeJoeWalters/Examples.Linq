using Examples.Linq.Objects;

namespace Examples.Linq.Tests
{
    public class JoinTests
    {
        [Fact]
        public void Perform_Inner_Join()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            var resultsFromMethodType = data.People.Join(data.Pets,
                                                    person => person,
                                                    pet => pet.Owner,
                                                    (person, pet) =>
                                                        new
                                                        {
                                                            OwnerName = person.FirstName,
                                                            PetName = pet.Name
                                                        })
                                                    .ToList();
            var query =
                from person in data.People
                join pet in data.Pets on person equals pet.Owner
                select new
                {
                    OwnerName = person.FirstName,
                    PetName = pet.Name
                };

            var resultsFromQueryType = query.ToList();

            // ASSERT
            resultsFromQueryType.Should().HaveCount(data.Pets.Count);
            resultsFromMethodType.Should().BeEquivalentTo(resultsFromQueryType); // The data should look the same in both methods (Also does the count)
        }
    }
}