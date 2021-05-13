namespace VideoStore.Tests
{
    using System.Globalization;
    using System.Reflection.Context;
    using System.Reflection.Metadata;
    using ApprovalTests;
    using ApprovalTests.Combinations;
    using ApprovalTests.Reporters;
    using Xunit;

    [UseReporter(typeof(QuietReporter))]
    public class VideoStoreShould
    {

        [Fact]
        public void ApproveCustomerStatement()
        {
            int[] movieType = new int[] { Movie.REGULAR, Movie.CHILDRENS, Movie.NEW_RELEASE };
            int[] daysRented = new int[] { 1, 3, 4 };

            ApprovalTests.Combinations.CombinationApprovals.VerifyAllCombinations(GetStatement, movieType, daysRented);
        }

        private static string GetStatement(int movieType, int daysRented)
        {
            Customer cust = new Customer("Joe Customer");
            cust.AddRental(new Rental(new Movie("Star Wars", movieType), daysRented));

            return cust.Statement();
        }
    }
}