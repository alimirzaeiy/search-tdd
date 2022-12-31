using search_tdd;
using Xunit.Abstractions;

namespace search_tddTests4
{
    internal class TestOutputWriter : IWriter
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public TestOutputWriter(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        public void WriteLine(string text)
        {
            _testOutputHelper.WriteLine(text);
        }
    }
}
