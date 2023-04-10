using Examples.Linq.Objects;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Examples.Linq.Tests
{
    public class ChildSelectTests
    {
        [Fact]
        public void Get_All_Children_Returns_All_Children()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            List<Level2Object> resultsMethod1 = data.Objects.SelectMany(c => c.Children).ToList();

            var results2 = from o in data.Objects
                            from c in o.Children
                            select c;

            List<Level2Object> resultsMethod2 = results2.ToList();

            // ASSERT
            resultsMethod1.Should().HaveCount(8); // Should be X items in the array, the next test will determine the actual data
            resultsMethod1.Should().BeEquivalentTo(resultsMethod2); // The data should look the same in both methods (Also does the count)
        }

        [Fact]
        public void Get_Children_With_Parent_Filter_Returns_Appropriate_Children()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            List<Level2Object> resultsMethod1 = data.Objects.Where(parent => parent.CreatedOn.Month == 1).SelectMany(c => c.Children).ToList();

            var results2 = from o in data.Objects
                           from c in o.Children
                           where o.CreatedOn.Month == 1
                           select c;

            List<Level2Object> resultsMethod2 = results2.ToList();

            // ASSERT
            resultsMethod1.Should().HaveCount(4); // Should be X items in the array for just January, the next test will determine the actual data
            resultsMethod1.Should().BeEquivalentTo(resultsMethod2); // The data should look the same in both methods (Also does the count)
        }

        [Fact]
        public void Get_Children_With_Child_Filter_Returns_Appropriate_Children()
        {
            // ARRANGE
            TestData data = new TestData();

            // ACT
            List<Level2Object> resultsMethod1 = data.Objects.SelectMany(c => c.Children).Where(c => c.CreatedOn.Month == 1).ToList();

            var results2 = from o in data.Objects
                           from c in o.Children
                           where c.CreatedOn.Month == 1
                           select c;

            List<Level2Object> resultsMethod2 = results2.ToList();

            // ASSERT
            resultsMethod1.Should().HaveCount(4); // Should be X items in the array for just January, the next test will determine the actual data
            resultsMethod1.Should().BeEquivalentTo(resultsMethod2); // The data should look the same in both methods (Also does the count)
        }
    }
}