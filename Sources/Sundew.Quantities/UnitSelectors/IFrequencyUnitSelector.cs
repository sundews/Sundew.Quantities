// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFrequencyUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Interface for <see cref="Frequency"/> unit selector.
    /// </summary>
    public interface IFrequencyUnitSelector : ITimeUnitSelector
    {
        /// <summary>
        /// Gets the one.
        /// </summary>
        /// <value>
        /// The one <see cref="Expression"/>.
        /// </value>
        Expression One { get; }

        /// <summary>
        /// Gets the hertz.
        /// </summary>
        /// <value>
        /// The hertz <see cref="Expression"/>.
        /// </value>
        Expression Hertz { get; }
    }
}