using Examples.Linq.Objects;

namespace Examples.Linq.Tests
{
    public class SortTests
    {
        [Fact]
        public void Perform_SortBy_Then()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            var resultsFromMethodType = data.People.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();
            var query =
                from person in data.People orderby person.LastName, person.FirstName select person;

            var resultsFromQueryType = query.ToList();

            // ASSERT
            resultsFromQueryType.Should().HaveCount(resultsFromMethodType.Count);
            resultsFromMethodType.First().Should().BeEquivalentTo(resultsFromQueryType.First());
            resultsFromMethodType.Last().Should().BeEquivalentTo(resultsFromQueryType.Last());
        }
    }
}