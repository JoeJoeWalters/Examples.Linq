namespace Examples.Linq.Tests
{
    public class Grouping
    {
        public string Key { get; set; } = string.Empty;
        public int Count { get; set; } = 0;
    }

    public class GroupTests
    {
        [Fact]
        public void Perform_SubQuery_Returns_Distinct_SubValue()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            List<string> resultsFromMethodType = data.Objects
                                                    .SelectMany(c => c.Children)
                                                    .Select(c => c.CreatedBy)
                                                    .Distinct()
                                                    .ToList();

            var query = (from o in data.Objects
                         from c in o.Children
                         select c.CreatedBy).Distinct(); // or Distinct(StringComparer.OrdinalIgnoreCase);

            List<string> resultsFromQueryType = query.ToList();

            // ASSERT
            resultsFromMethodType.Should().HaveCount(data.TotalAuthors); // Should be X items in the array, the next test will determine the actual data
            resultsFromMethodType.Should().BeEquivalentTo(resultsFromQueryType); // The data should look the same in both methods (Also does the count)
        }
        [Fact]
        public void Perform_SubQuery_Returns_Distinct_SubValue_And_Occourances()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            List<Grouping> resultsFromMethodType = data.Objects
                                                    .SelectMany(c => c.Children)
                                                    .GroupBy(c => c.CreatedBy)
                                                    .Select(group => new Grouping()
                                                    {
                                                        Count = group.Count(),
                                                        Key = group.Key
                                                    })
                                                    .ToList();

            var query = from o in data.Objects
                        from c in o.Children
                        group c by c.CreatedBy into g
                        select new Grouping() { Count = g.Count(), Key = g.Key };

            List<Grouping> resultsFromQueryType = query.ToList();

            // ASSERT
            resultsFromMethodType.Should().HaveCount(data.TotalAuthors); // Should be X items in the array, the next test will determine the actual data
            resultsFromMethodType.ForEach(result => result.Count.Should().Be(data.AuthorOccorances)); // Each author should appear Y times
            resultsFromMethodType.Should().BeEquivalentTo(resultsFromQueryType); // The data should look the same in both methods (Also does the count)
        }
    }
}