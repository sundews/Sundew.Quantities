// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitRegistrar.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Registration
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Interface for adding <see cref="IUnit"/>s, <see cref="DerivedUnit"/>s and <see cref="Prefix"/>.
    /// </summary>
    public interface IUnitRegistrar
    {
        /// <summary>
        /// Registers the unit.
        /// </summary>
        /// <param name="unit">
        /// The unit to be registered.
        /// </param>
        void Register(IUnit unit);

        /// <summary>
        /// Unregisters the unit.
        /// </summary>
        /// <param name="unit">
        /// The unit to be unregistered.
        /// </param>
        void Unregister(IUnit unit);

        /// <summary>
        /// Registers the unit.
        /// </summary>
        /// <param name="derivedUnit">
        /// The unit to be registered.
        /// </param>
        void Register(DerivedUnit derivedUnit);

        /// <summary>
        /// Unregisters the unit.
        /// </summary>
        /// <param name="derivedUnit">
        /// The unit to be unregistered.
        /// </param>
        void Unregister(DerivedUnit derivedUnit);

        /// <summary>
        /// Registers the prefix.
        /// </summary>
        /// <param name="prefix">
        /// The prefix.
        /// </param>
        void Register(Prefix prefix);

        /// <summary>
        /// Unregisters the prefix.
        /// </summary>
        /// <param name="prefix">
        /// The prefix.
        /// </param>
        void Unregister(Prefix prefix);
    }
}