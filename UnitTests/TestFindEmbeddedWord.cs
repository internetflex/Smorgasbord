using Shouldly;
using TestProject;
using Xunit;

namespace UnitTests
{
    public class TestFindEmbeddedWord
    {
        [Theory]
        [InlineData(new[] { "cat", "baby", "dog", "bird", "car", "ax" }, "tcabnihjs", "cat")]
        [InlineData(new[] { "cat", "baby", "dog", "bird", "car", "ax" }, "tbcanihjs", "cat")]
        [InlineData(new[] { "cat", "baby", "dog", "bird", "car", "ax" }, "bbabylkkj", "baby")]
        [InlineData(new[] { "cat", "baby", "dog", "bird", "car", "ax" }, "ccc", "")]
        [InlineData(new[] { "cat", "baby", "dog", "bird", "car", "ax" }, "breadmaking", "bird")]
        void Test1(string[]words, string searchWord, string expected)
        {
            FindEmbeddedWord.find_embedded_word(words, searchWord).ShouldBe(expected);
        }
    }
}
