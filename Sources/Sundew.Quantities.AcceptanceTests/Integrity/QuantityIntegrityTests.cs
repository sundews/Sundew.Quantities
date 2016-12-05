// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="QuantityIntegrityTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Integrity
{
    using System;
    using System.Linq;
    using System.Reflection;
    using FluentAssertions;
    using FluentAssertions.Execution;
    using Sundew.Quantities.Core;
    using Xunit;

    public class QuantityIntegrityTests
    {
        private const string OperatorPrefix = "op_";

        private static readonly Type QuantityInterfaceType = typeof(IQuantity);

        private static readonly Type[] ExcludedQuantityTypes =
            {
                typeof(IQuantity<>),
                typeof(IQuantity<,>)
            };

        [Theory]
        [InlineData("Addition", typeof(double))]
        [InlineData("Subtraction", typeof(double))]
        [InlineData("Multiply", typeof(double))]
        [InlineData("Division", typeof(double))]
        public void All_Quantities_Should_Implement_Standard_Operators(string @operator, Type rhsType)
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                        !quantityType.GetMethods(
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                             .Any(
                                 x =>
                                 x.Name == OperatorPrefix + @operator
                                 && x.GetParameters()
                                        .Select(parameterInfo => parameterInfo.ParameterType)
                                        .SequenceEqual(new[] { x.DeclaringType, rhsType })))
                    .ToList();

            incompleteTypes.Should()
                .BeEmpty(
                    "The types: {0} did not implement the operator: {1} accepting a double as the rhs.",
                    IntegrityHelper.GetTypes(incompleteTypes),
                    @operator,
                    rhsType);
        }

        [Theory]
        [InlineData("Addition")]
        [InlineData("Subtraction")]
        [InlineData("Multiply")]
        [InlineData("Division")]
        public void All_Quantities_Should_Implement_Standard_Operators_With_The_Same_Rhs_Type(string @operator)
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                        !quantityType.GetMethods(
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                             .Any(
                                 x =>
                                 x.Name == OperatorPrefix + @operator
                                 && x.GetParameters()
                                        .Select(parameterInfo => parameterInfo.ParameterType)
                                        .SequenceEqual(new[] { x.DeclaringType, x.DeclaringType })))
                    .ToList();

            incompleteTypes.Should()
                .BeEmpty(
                    "The types: {0} did not implement the operator: {1} accepting a their own type as the rhs.",
                    IntegrityHelper.GetTypes(incompleteTypes),
                    @operator);
        }

        [Theory]
        [InlineData("Increment")]
        [InlineData("Decrement")]
        public void All_Quantities_Should_Implement_Unary_Operators(string @operator)
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                        quantityType.GetMethod(OperatorPrefix + @operator, new[] { quantityType }) == null)
                    .ToList();

            incompleteTypes.Should()
                .BeEmpty(
                    "The types: {0} should implement the {1} operator.",
                    IntegrityHelper.GetTypes(incompleteTypes),
                    @operator);
        }

        [Theory]
        [InlineData("UnaryPlus")]
        [InlineData("UnaryNegation")]
        public void All_Quantities_Should_Inheritt_Unary_Operators(string @operator)
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                        !quantityType.GetMethods(
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                             .Any(
                                 x =>
                                 x.Name == OperatorPrefix + @operator
                                 && x.GetParameters()
                                        .Select(parameterInfo => parameterInfo.ParameterType)
                                        .SequenceEqual(new[] { x.DeclaringType })))
                    .ToList();

            incompleteTypes.Should()
                .BeEmpty(
                    "The types: {0} should implement the {1} operator.",
                    IntegrityHelper.GetTypes(incompleteTypes),
                    @operator);
        }

        [Theory]
        [InlineData("GreaterThan")]
        [InlineData("GreaterThanOrEqual")]
        [InlineData("LessThan")]
        [InlineData("LessThanOrEqual")]
        [InlineData("Equality")]
        [InlineData("Inequality")]
        public void All_Quantities_Should_Implement_Comparison_Operators(string @operator)
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                        !quantityType.GetMethods(
                            BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                             .Any(
                                 x =>
                                 x.Name == OperatorPrefix + @operator
                                 && x.GetParameters()
                                        .Select(parameterInfo => parameterInfo.ParameterType)
                                        .SequenceEqual(new[] { x.DeclaringType, x.DeclaringType })))
                    .ToList();

            incompleteTypes.Should()
                .BeEmpty(
                    "The types: {0} should implement the {1} operator.",
                    IntegrityHelper.GetTypes(incompleteTypes),
                    @operator);
        }

        [Fact]
        public void All_Quantities_Should_Be_Structs()
        {
            var incompleteTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(quantityType => !quantityType.IsValueType)
                    .ToList();

            incompleteTypes.Should().BeEmpty("The types: {0} are not structs.", IntegrityHelper.GetTypes(incompleteTypes));
        }

        [Fact]
        public void No_Quantities_Should_Have_Implicit_From_Double_Operators()
        {
            var invalidTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(quantityType => quantityType.GetMethod("op_Implicit", new[] { typeof(double) }) != null)
                    .ToList();

            invalidTypes.Should()
                .BeEmpty(
                    "The types: {0} should not implement the implicit from {1} operator.",
                    IntegrityHelper.GetTypes(invalidTypes),
                    typeof(double));
        }

        [Fact]
        public void No_Quantities_Should_Have_Implicit_To_Double_Operators()
        {
            var invalidTypes =
                IntegrityHelper.GetDerivedTypes(QuantityInterfaceType, ExcludedQuantityTypes)
                    .Where(
                        quantityType =>
                            {
                                return
                                    quantityType.GetMethods()
                                        .Any(
                                            x =>
                                            x.Name == "op_Implicit"
                                            && x.GetParameters()
                                                   .Select(parameterInfo => parameterInfo.ParameterType)
                                                   .SequenceEqual(new[] { quantityType })
                                            && x.ReturnType == typeof(double));
                            })
                    .ToList();

            Execute.Assertion.ForCondition(!invalidTypes.Any())
                .FailWith(
                    "The types: {0} did implement the {1} to double operator.",
                    IntegrityHelper.GetTypes(invalidTypes),
                    "Implicit");
        }
    }
}