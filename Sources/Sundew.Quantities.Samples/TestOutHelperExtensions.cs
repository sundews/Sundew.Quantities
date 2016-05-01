// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TestOutHelperExtensions.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

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