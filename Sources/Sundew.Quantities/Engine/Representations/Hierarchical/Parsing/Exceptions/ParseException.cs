// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ParseException.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;

    /// <summary>
    /// Abstract base class for various parse exceptions.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public abstract class ParseException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseException" /> class.
        /// </summary>
        /// <param name="error">The parse error.</param>
        protected ParseException(IError error)
            : base(error.GetMessage())
        {
        }
    }
}