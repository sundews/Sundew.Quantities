// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IDeferredQuantity.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Quantities
{
    /// <summary>
    /// Interface for implementing compositions of quantities.
    /// </summary>
    public interface IDeferredQuantity
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <returns>An <see cref="IQuantity"/>.</returns>
        IQuantity GetResult();
    }
}