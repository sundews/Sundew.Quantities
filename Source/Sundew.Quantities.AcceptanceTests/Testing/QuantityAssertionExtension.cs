// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityAssertionExtension.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.AcceptanceTests.Testing
{
    using System;
    using FluentAssertions;
    using FluentAssertions.Execution;
    using FluentAssertions.Numeric;
    using Sundew.Quantities.Core;
    using Sundew.Quantities.UnitTests;

    /// <summary>
    /// The quantity assertion extension.
    /// </summary>
    public static class QuantityAssertionExtension
    {
        /// <summary>
        /// The be.
        /// </summary>
        /// <param name="quantityAssertions">
        /// The quantity assertions.
        /// </param>
        /// <param name="expectedValue">
        /// The expected value.
        /// </param>
        /// <param name="expectedUnit">
        /// The expected unit.
        /// </param>
        /// <param name="unitFormat">
        /// The unit format.
        /// </param>
        /// <returns>
        /// The <see cref="AndConstraint{T}"/>.
        /// </returns>
        public static AndConstraint<ComparableTypeAssertions<IQuantity>> Be(
            this ComparableTypeAssertions<IQuantity> quantityAssertions,
            double expectedValue,
            string expectedUnit,
            UnitFormat unitFormat)
        {
            var quantity = (IQuantity)quantityAssertions.Subject;
            var quantityValue = quantity.Value;
            var quantityUnit = UnitFormatHelper.GetNotation(quantity.Unit, unitFormat);
            Execute.Assertion.ForCondition(quantityValue.Equals(expectedValue))
                .FailWith(
                    "The value: {0}, but found: {1}",
                    expectedValue.ToString("N20"),
                    quantityValue.ToString("N20"));
            AssertUnit(quantityUnit, expectedUnit);

            return new AndConstraint<ComparableTypeAssertions<IQuantity>>(quantityAssertions);
        }

        /// <summary>
        /// The be.
        /// </summary>
        /// <param name="quantityAssertions">
        /// The quantity assertions.
        /// </param>
        /// <param name="expectedValue">
        /// The expected value.
        /// </param>
        /// <param name="expectedUnit">
        /// The expected unit.
        /// </param>
        /// <returns>
        /// The <see cref="AndConstraint{T}"/>.
        /// </returns>
        public static AndConstraint<ComparableTypeAssertions<IQuantity>> Be(
            this ComparableTypeAssertions<IQuantity> quantityAssertions,
            double expectedValue,
            string expectedUnit)
        {
            return Be(quantityAssertions, expectedValue, expectedUnit, UnitFormat.Default);
        }

        /// <summary>
        /// The be approximately.
        /// </summary>
        /// <param name="quantityAssertions">
        /// The quantity assertions.
        /// </param>
        /// <param name="expectedValue">
        /// The expected value.
        /// </param>
        /// <param name="expectedUnit">
        /// The expected unit.
        /// </param>
        /// <param name="precision">
        /// The precision.
        /// </param>
        /// <returns>
        /// The <see cref="AndConstraint{T}"/>.
        /// </returns>
        public static AndConstraint<ComparableTypeAssertions<IQuantity>> BeApproximately(
            this ComparableTypeAssertions<IQuantity> quantityAssertions,
            double expectedValue,
            string expectedUnit,
            double precision = TestHelper.DefaultAssertPrecision)
        {
            return BeApproximately(quantityAssertions, expectedValue, expectedUnit, UnitFormat.Default, precision);
        }

        /// <summary>
        /// The be approximately.
        /// </summary>
        /// <param name="quantityAssertions">
        /// The quantity assertions.
        /// </param>
        /// <param name="expectedValue">
        /// The expected value.
        /// </param>
        /// <param name="expectedUnit">
        /// The expected unit.
        /// </param>
        /// <param name="unitFormat">
        /// The unit format.
        /// </param>
        /// <param name="precision">
        /// The precision.
        /// </param>
        /// <returns>
        /// The <see cref="AndConstraint{T}"/>.
        /// </returns>
        public static AndConstraint<ComparableTypeAssertions<IQuantity>> BeApproximately(
            this ComparableTypeAssertions<IQuantity> quantityAssertions,
            double expectedValue,
            string expectedUnit,
            UnitFormat unitFormat,
            double precision)
        {
            var quantity = (IQuantity)quantityAssertions.Subject;
            var quantityValue = quantity.Value;
            var quantityUnit = UnitFormatHelper.GetNotation(quantity.Unit, unitFormat);
            Execute.Assertion.ForCondition(quantityValue == expectedValue || Math.Abs(quantityValue - expectedValue) < precision)
                .FailWith("The value: {0}, but found: {1}", expectedValue, quantityValue);
            AssertUnit(quantityUnit, expectedUnit);

            return new AndConstraint<ComparableTypeAssertions<IQuantity>>(quantityAssertions);
        }

        /// <summary>
        /// The assert unit.
        /// </summary>
        /// <param name="quantityUnit">
        /// The quantity unit.
        /// </param>
        /// <param name="expectedUnit">
        /// The expected unit.
        /// </param>
        private static void AssertUnit(string quantityUnit, string expectedUnit)
        {
            Execute.Assertion.ForCondition(quantityUnit.Equals(expectedUnit))
                .FailWith("Expected expectedUnit {0}, but found: {1}", expectedUnit, quantityUnit);
        }
    }
}