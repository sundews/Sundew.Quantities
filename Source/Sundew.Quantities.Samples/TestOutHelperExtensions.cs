// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestOutHelperExtensions.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
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