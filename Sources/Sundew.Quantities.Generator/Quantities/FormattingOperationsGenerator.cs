// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormattingOperationsGenerator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator.Quantities
{
    using Sundew.Text.Generation.Common;

    public static class FormattingOperationsGenerator
    {
        public static IndentedString GetToStringOperations(QuantityModel quantityModel)
        {
            return new IndentedString(8, @"
/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public override string ToString()
{{
    return this.ToString(CultureInfo.CurrentCulture);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""unitFormat"">The unit format.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(UnitFormat unitFormat)
{{
    return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""format"">The format.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(string format)
{{
    return this.ToString(format, CultureInfo.CurrentCulture);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""formatProvider"">The format provider.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(IFormatProvider formatProvider)
{{
    return this.ToString(null, formatProvider);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""unitFormat"">The unit format.</param>
/// <param name=""format"">The format.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(UnitFormat unitFormat, string format)
{{
    return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""unitFormat"">The unit format.</param>
/// <param name=""formatProvider"">The format provider.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
{{
    return this.ToString(unitFormat, null, formatProvider);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""format"">The format.</param>
/// <param name=""formatProvider"">The format provider.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(string format, IFormatProvider formatProvider)
{{
    return this.ToString(UnitFormat.Default, format, formatProvider);
}}

/// <summary>
/// Returns a <see cref=""string"" /> that represents this instance.
/// </summary>
/// <param name=""unitFormat"">The unit format.</param>
/// <param name=""format"">The format.</param>
/// <param name=""formatProvider"">The format provider.</param>
/// <returns>
/// A <see cref=""string"" /> that represents this instance.
/// </returns>
public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
{{
    return QuantityHelper.ToString(
        this.Unit.FormatValue(this.value, format, formatProvider),
        UnitFormatHelper.GetNotation(this.Unit, unitFormat));
}}
");
        }
    }
}