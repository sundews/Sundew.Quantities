// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Comparison.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Samples;

using Xunit;
using Xunit.Abstractions;

public class Comparison
{
    private readonly ITestOutputHelper output;

    public Comparison(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact(Skip = "Sample")]
    public void TimeComparison()
    {
        #region UsageTimeComparison

        // Create time1
        var time1 = 3.Hours();

        // Create time2
        var time2 = 500.Seconds();

        // Create time3
        var time3 = 10800.Seconds();

        // Compare time1 to time2
        var compare12 = time1.CompareTo(time2);

        // Compare time2 to time1
        var compare21 = time2.CompareTo(time1);

        // Compare time1 to time3
        var compare13 = time1.CompareTo(time3);

        // Print output
        this.WriteResult(time1, time2, compare12);
        this.WriteResult(time2, time1, compare21);
        this.WriteResult(time1, time3, compare13);

        // 3 [h] is greater than 500 [s]
        // 500 [s] is less than 3 [h]
        // 3 [h] and 10800 [s] are equal

        #endregion
    }

    private void WriteResult(Time lhs, Time rhs, int comparison)
    {
        if (comparison < 0)
        {
            this.output.WriteLine(lhs + " is less than " + rhs);
        }
        else if (comparison > 0)
        {
            this.output.WriteLine(lhs + " is greater than " + rhs);
        }
        else
        {
            this.output.WriteLine(lhs + " and " + rhs + " are equal");
        }
    }
}