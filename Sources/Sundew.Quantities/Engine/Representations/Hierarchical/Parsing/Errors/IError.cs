// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IError.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors
{
    /// <summary>
    /// Interface for representing an error.
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <returns>The error message.</returns>
        string GetMessage();
    }
}