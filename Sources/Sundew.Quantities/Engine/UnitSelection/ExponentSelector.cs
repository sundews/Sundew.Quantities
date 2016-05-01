// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExponentSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Abstract class for implementing order an of magnitude selector.
    /// </summary>
    /// <typeparam name="TUnits">The type of the units.</typeparam>
    /// <typeparam name="TPrefixesAndUnits">The type of the prefixed units.</typeparam>
    public abstract class ExponentSelector<TUnits, TPrefixesAndUnits> : IExponentSelector<TPrefixesAndUnits>
        where TPrefixesAndUnits : IPrefixSelector<TUnits>
    {
        private int actualExponent = 1;

        private Prefix actualPrefix;

        /// <summary>
        /// Gets the square.
        /// </summary>
        /// <value>
        /// The square.
        /// </value>
        public TPrefixesAndUnits Square => this.GetPrefixesAndUnits(2);

        /// <summary>
        /// Gets the cubic.
        /// </summary>
        /// <value>
        /// The cubic.
        /// </value>
        public TPrefixesAndUnits Cubic => this.GetPrefixesAndUnits(3);

        /// <summary>
        /// Gets the quartic.
        /// </summary>
        /// <value>
        /// The quartic.
        /// </value>
        public TPrefixesAndUnits Quartic => this.GetPrefixesAndUnits(4);

        /// <summary>
        /// Gets the quintic.
        /// </summary>
        /// <value>
        /// The quintic.
        /// </value>
        public TPrefixesAndUnits Quintic => this.GetPrefixesAndUnits(5);

        /// <summary>
        /// Wraps the specified <see cref="Expression"/> in a <see cref="ParenthesisExpression"/>.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="ParenthesisExpression"/>.</returns>
        public ParenthesisExpression P(Expression expression)
        {
            return new ParenthesisExpression(expression);
        }

        /// <summary>
        /// Specifies the exponent.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        public void SpecifyExponent(int exponent)
        {
            this.actualExponent = exponent;
        }

        /// <summary>
        /// Specifies the prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        public void SpecifyPrefix(Prefix prefix)
        {
            this.actualPrefix = prefix;
        }

        /// <summary>
        /// Selects the unit based on the specified magnitude, prefix and base unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// A <see cref="UnitBuilder"/>.
        /// </returns>
        public Expression SpecifyUnit(IUnit unit)
        {
            var exponent = this.actualExponent;
            var prefix = this.actualPrefix;
            this.actualExponent = 1;
            this.actualPrefix = null;

            if (prefix != null)
            {
                unit = unit.GetPrefixedUnit(prefix);
            }

            if (exponent > 1)
            {
                return new MagnitudeExpression(unit.GetExpression(), new ConstantExpression(exponent));
            }

            return unit.GetExpression();
        }

        /// <summary>
        /// Gets the prefixes and unit selector.
        /// </summary>
        /// <returns>A <see cref="TPrefixesAndUnits"/>.</returns>
        protected abstract TPrefixesAndUnits GetPrefixesAndUnits();

        /// <summary>
        /// Gets the prefixes and unit selector.
        /// </summary>
        /// <param name="exponent">The exponent.</param>
        /// <returns>
        /// A <see cref="TPrefixesAndUnits" />.
        /// </returns>
        private TPrefixesAndUnits GetPrefixesAndUnits(int exponent)
        {
            this.SpecifyExponent(exponent);
            return this.GetPrefixesAndUnits();
        }
    }
}