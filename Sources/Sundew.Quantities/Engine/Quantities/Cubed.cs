// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Cubed.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Represents the squared result of a <see cref="IQuantity{TQuantity}"/>.
    /// </summary>
    /// <typeparam name="TBase">The type of the base.</typeparam>
    public class Cubed<TBase> : IDeferredQuantity
        where TBase : IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cubed{TBase}"/> class.
        /// </summary>
        /// <param name="base">The base quantity.</param>
        public Cubed(TBase @base)
        {
            this.Base = @base;
        }

        /// <summary>
        /// Gets the base.
        /// </summary>
        /// <value>
        /// The base quantity.
        /// </value>
        public TBase Base { get; }

        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>
        /// A <see cref="IQuantity{TQuantity}" />.
        /// </returns>
        public IQuantity GetResult()
        {
            return QuantityOperations.Exponential(this.Base.GetResult(), 3);
        }
    }
}