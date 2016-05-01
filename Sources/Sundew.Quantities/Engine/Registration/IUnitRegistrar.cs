// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IUnitRegistrar.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Registration
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

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