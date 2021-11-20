// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EqualityOperationsHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.Quantities;

using Sundew.Generator.Core;

public static class EqualityOperationsHelper
{
    public static IndentedString GetEqualityOperations(IQuantityModel quantityModel)
    {
        return new IndentedString(8, $@"
/// <summary>
/// Returns a hash code for this instance.
/// </summary>
/// <returns>
/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
/// </returns>
public override int GetHashCode()
{{
    return QuantityHelper.GetHashCode(this);
}}

/// <summary>
/// Determines whether the specified <see cref=""object"" />, is equal to this instance.
/// </summary>
/// <param name=""obj"">The <see cref=""object"" /> to compare with this instance.</param>
/// <returns>
///   <c>true</c> if the specified <see cref=""object"" /> is equal to this instance; otherwise, <c>false</c>.
/// </returns>
public override bool Equals(object obj)
{{
    return QuantityHelper.AreEqual(this, obj);
}}

/// <summary>
/// Determines whether the specified <see cref=""IQuantity"" />, is equal to this instance.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
///   <c>true</c> if the specified <see cref=""IQuantity"" /> is equal to this instance; otherwise, <c>false</c>.
/// </returns>
public bool Equals(IQuantity quantity)
{{
    return QuantityHelper.AreEqual(this, quantity);
}}

/// <summary>
/// Determines whether the specified <see cref=""{quantityModel.Name}"" />, is equal to this instance.
/// </summary>
/// <param name=""quantity"">The quantity.</param>
/// <returns>
///   <c>true</c> if the specified <see cref=""{quantityModel.Name}"" /> is equal to this instance; otherwise, <c>false</c>.
/// </returns>
public bool Equals({quantityModel.Name} quantity)
{{
    return QuantityHelper.AreEqual(this, quantity);
}}

/// <summary>
/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
/// </summary>
/// <param name=""obj"">An object to compare with this instance.</param>
/// <returns>
/// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name=""obj"" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name=""obj"" />. Greater than zero This instance follows <paramref name=""obj"" /> in the sort order.
/// </returns>
public int CompareTo(object obj)
{{
    return QuantityHelper.CompareTo<{quantityModel.Name}>(this, obj);
}}

/// <summary>
/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
/// </summary>
/// <param name=""quantity"">A quantityModel to compare with this instance.</param>
/// <returns>
/// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name=""quantity"" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name=""quantity"" />. Greater than zero This instance follows <paramref name=""quantity"" /> in the sort order.
/// </returns>
public int CompareTo(IQuantity quantity)
{{
    return QuantityHelper.CompareTo(this, quantity);
}}

/// <summary>
/// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
/// </summary>
/// <param name=""quantity"">A quantity to compare with this instance.</param>
/// <returns>
/// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name=""quantity"" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name=""quantity"" />. Greater than zero This instance follows <paramref name=""quantity"" /> in the sort order.
/// </returns>
public int CompareTo({quantityModel.Name} quantity)
{{
    return QuantityHelper.CompareTo(this, quantity);
}}
");
    }
}