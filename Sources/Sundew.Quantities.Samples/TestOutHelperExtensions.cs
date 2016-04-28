namespace Sundew.Quantities.Samples
{
    using Xunit.Abstractions;

    public static class TestOutHelperExtensions
    {
        public static void WriteLine(this ITestOutputHelper testOutputHelper, object @object)
        {
            testOutputHelper.WriteLine(@object.ToString());
        }
    }
}