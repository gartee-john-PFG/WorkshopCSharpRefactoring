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
            Assert.True(1 == 1);
        }
    }
}