// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardOperationsGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Sundew.Text.Generation.Common;

namespace Sundew.Quantities.Generator.Quantities
{
    public static class StandardOperationsGenerator
    {
        public static IndentedString GetStandardOperations(QuantityModel quantityModel)
        {
            return new IndentedString(8, $@"
/// <summary>
/// Implements the unary + operator.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
/// The <paramref name=""quantity""/>.
/// </returns>
public static {quantityModel.Name} operator +({quantityModel.Name} quantity)
{{
    return quantity;
}}

/// <summary>
/// Implements the unary - operator.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
/// The negated <paramref name=""quantity""/>.
/// </returns>
public static {quantityModel.Name} operator -({quantityModel.Name} quantity)
{{
    return new {quantityModel.Name}(-quantity.value, quantity.Unit);
}}

/// <summary>
/// Increaments the specified <see cref=""{quantityModel.Name}""/>.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
/// An increamented <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator ++({quantityModel.Name} quantity)
{{
    return new {quantityModel.Name}(quantity.value + 1, quantity.Unit);
}}

/// <summary>
/// Decreaments the specified <see cref=""{quantityModel.Name}""/>.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
/// An decreamented <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator --({quantityModel.Name} quantity)
{{
    return new {quantityModel.Name}(quantity.value - 1, quantity.Unit);
}}

/// <summary>
/// Adds the specified rhs to the specified lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator +({quantityModel.Name} lhs, double rhs)
{{
    return new {quantityModel.Name}(lhs.value + rhs, lhs.Unit);
}}

/// <summary>
/// Subtracts the specified rhs from the specified lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator -({quantityModel.Name} lhs, double rhs)
{{
    return new {quantityModel.Name}(lhs.value - rhs, lhs.Unit);
}}

/// <summary>
/// Multiplies the specified lhs by the specified rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator *({quantityModel.Name} lhs, double rhs)
{{
    return new {quantityModel.Name}(lhs.value * rhs, lhs.Unit);
}}

/// <summary>
/// Divides the specified lhs by the specified rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator /({quantityModel.Name} lhs, double rhs)
{{
    return new {quantityModel.Name}(lhs.value / rhs, lhs.Unit);
}}

/// <summary>
/// Adds the specified rhs to the specified lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator +({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return new {quantityModel.Name}(QuantityOperations.Add(lhs, rhs));
}}

/// <summary>
/// Subtracts the specified rhs from the specified lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static {quantityModel.Name} operator -({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return new {quantityModel.Name}(QuantityOperations.Subtract(lhs, rhs));
}}

/// <summary>
/// Divides the specified lhs by the specified rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
/// A <see cref=""{quantityModel.Name}""/>.
/// </returns>
public static double operator /({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityOperations.Divide(lhs, rhs).Value;
}}

/// <summary>
/// Determines whether the specified rhs, is equal to the lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified rhs is equal to the lhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator ==({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityHelper.AreEqual(lhs, rhs);
}}

/// <summary>
/// Determines whether the specified rhs, is different from the lhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified rhs is different to the lhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator !=({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return !QuantityHelper.AreEqual(lhs, rhs);
}}

/// <summary>
/// Compares whether the specified lhs is greather than or equal to the rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified lhs is greater than or equal to the rhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator >=({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityHelper.CompareTo(lhs, rhs) >= 0;
}}

/// <summary>
/// Compares whether the specified lhs is less than or equal to the rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified lhs is less than or equal to the rhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator <=({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityHelper.CompareTo(lhs, rhs) <= 0;
}}

/// <summary>
/// Compares whether the specified lhs is greather than the rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified lhs is greater than or rhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator >({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityHelper.CompareTo(lhs, rhs) > 0;
}}

/// <summary>
/// Compares whether the specified lhs is less than the rhs.
/// </summary>
/// <param name=""lhs"">The LHS.</param>
/// <param name=""rhs"">The RHS.</param>
/// <returns>
///   <c>true</c> if the specified lhs is less than the rhs; otherwise, <c>false</c>.
/// </returns>
public static bool operator <({quantityModel.Name} lhs, {quantityModel.Name} rhs)
{{
    return QuantityHelper.CompareTo(lhs, rhs) < 0;
}}

/// <summary>
/// Creates an <see cref=""Interval""/> with the specified minimum, maximum and unit.
/// </summary>
/// <param name=""min"">The minimum.</param>
/// <param name=""max"">The maximum.</param>
/// <param name=""unitSelector"">The unit selector.</param>
/// <returns>
/// An <see cref=""Interval""/>.
/// </returns>
public static Interval<{quantityModel.Name}> Interval(double min, double max, SelectUnit<{quantityModel.Name}UnitSelector> unitSelector)
{{
    return new Interval<{quantityModel.Name}>(min, max, unitSelector(new {quantityModel.Name}UnitSelector()));
}}

/// <summary>
/// Squares this instance.
/// </summary>
/// <returns>
/// A <see cref=""Squared{{{quantityModel.Name}}}""/>.
/// </returns>
public Squared<{quantityModel.Name}> Squared()
{{
    return new Squared<{quantityModel.Name}>(this);
}}

/// <summary>
/// Cubes this instance.
/// </summary>
/// <returns>
/// A <see cref=""Cubed{{{quantityModel.Name}}}""/>.
/// </returns>
public Cubed<{quantityModel.Name}> Cubed()
{{
    return new Cubed<{quantityModel.Name}>(this);
}}
");
        }
    }
}