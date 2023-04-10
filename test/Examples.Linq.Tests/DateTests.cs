using Examples.Linq.Objects;

namespace Examples.Linq.Tests
{
    public class DateTests
    {
        [Fact]
        public void Perform_Date_Period_Intersection_Returns_Intersecting_Records()
        {
            // ARRANGE
            TestData data = new TestData();

            // Half way through January to half way through February should intersect with periods covering either full month
            DateTime periodFromDate = new DateTime(2023, 1, 15);
            DateTime periodToDate = new DateTime(2023, 2, 15);

            // ACT
            List<Level2Object> resultsFromMethodType = data.Objects
                                                    .SelectMany(c => c.Children)
                                                    .Where(o => o.PeriodFrom <= periodToDate && o.PeriodTo >= periodFromDate)
                                                    .ToList();

            var query = from o in data.Objects
                        from c in o.Children
                        where (c.PeriodFrom <= periodToDate && c.PeriodTo >= periodFromDate)
                        select c;

            List<Level2Object> resultsFromQueryType = query.ToList();

            // ASSERT
            resultsFromMethodType.Should().HaveCount(data.JanuaryChildObjects + data.FebruaryChildObjects); // Should be all items in the array, the next test will determine the actual data
            resultsFromMethodType.Should().BeEquivalentTo(resultsFromQueryType); // The data should look the same in both methods (Also does the count)
        }

    }
}