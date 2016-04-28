namespace Sundew.Quantities.Engine.Representations.Hierarchical.Units
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Abstract prefix class.
    /// </summary>
    public abstract class Prefix : IEquatable<Prefix>
    {
        /// <summary>
        /// Gets the none prefix.
        /// </summary>
        /// <value>
        /// The none prefix.
        /// </value>
        public static Prefix None { get;  } = new FactorOnePrefix();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the factor.
        /// </summary>
        /// <value>
        /// The factor.
        /// </value>
        public abstract double Factor { get; }

        /// <summary>
        /// Gets the notation.
        /// </summary>
        /// <value>
        /// The notation.
        /// </value>
        public abstract string Notation { get; }

        /// <summary>
        /// Multiplies the specified LHS with the RHS.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// A <see cref="IUnit" />.
        /// </returns>
        public static UnitExpression operator *(Prefix prefix, IUnit unit)
        {
            return new UnitExpression(unit.GetPrefixedUnit(prefix));
        }
        
        /// <summary>
        /// Gets the prefixed notation.
        /// </summary>
        /// <param name="unitNotation">The notation.</param>
        /// <returns>The prefixed notation.</returns>
        public abstract string GetPrefixedNotation(string unitNotation);

        /// <summary>
        /// Converts the specified value into the unit's base value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The unit's base value.
        /// </returns>
        public abstract double ToBase(double value);

        /// <summary>
        /// Froms the base.
        /// </summary>
        /// <param name="value">The value.</param>
        public abstract double FromBase(double value);
        
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(Prefix other)
        {
            return this.Factor.Equals(other.Factor);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Notation;
        }

        private class FactorOnePrefix : Prefix
        {
            private const string NoneName = "None";

            public override string Name => NoneName;

            public override double Factor => 1;

            public override string Notation => string.Empty;

            public override string GetPrefixedNotation(string unitNotation)
            {
                return unitNotation;
            }

            public override double FromBase(double value)
            {
                return value;
            }

            public override double ToBase(double value)
            {
                return value;
            }
        }
    }
}