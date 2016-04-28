namespace Sundew.Quantities.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Operations;
    using Sundew.Quantities.Engine.Registration;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Stores the currently load unit system.
    /// This class must be initialized with the wished units.
    /// </summary>
    public partial class UnitSystem
    {
        internal static IQuantityOperations QuantityOperations
        {
            get
            {
                EnsureInitialization();
                return Instance.quantityOperations;
            }
        }

        internal static IUnitFactory UnitFactory
        {
            get
            {
                EnsureInitialization();
                return Instance.unitFactory;
            }
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static UnitSystem Instance => Nested.UnitSystemInstance;

        /// <summary>
        /// Gets the prefixes.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Prefix> Prefixes
        {
            get
            {
                EnsureInitialization();
                return Instance.GetPrefixes();
            }
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IUnit> Units
        {
            get
            {
                EnsureInitialization();
                return Instance.GetUnits();
            }
        }

        /// <summary>
        /// Gets the specified quantity.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        /// <param name="cultureInfo">The culture information.</param>
        /// <returns>
        /// A <see cref="Quantity" />.
        /// </returns>
        public static Quantity GetQuantityFrom(string quantity, CultureInfo cultureInfo)
        {
            EnsureInitialization();
            return Instance.GetQuantity(quantity, cultureInfo);
        }

        /// <summary>
        /// Gets the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>
        /// An <see cref="IUnit" />.
        /// </returns>
        public static Result<IUnit, Error<ExpressionError>> GetUnitFrom(string unit, ParseSettings parseSettings)
        {
            EnsureInitialization();
            return Instance.GetUnit(unit, parseSettings);
        }

        /// <summary>
        /// Initializes the with defaults.
        /// </summary>
        /// <param name="unitSystemDependencyFactory">The unit system dependency factory.</param>
        /// <param name="registerUnitAction">The register unit action.</param>
        public static UnitSystemDependencies InitializeWithDefaults(IUnitSystemDependencyFactory unitSystemDependencyFactory = null, Action<IUnitRegistrar> registerUnitAction = null)
        {
            return Instance.InitializeUnitSystemWithDefaults(unitSystemDependencyFactory, registerUnitAction);
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <param name="unitSystemDependencyFactory">The unit system dependency factory.</param>
        /// <param name="registerUnitAction">The register unit action.</param>
        public static UnitSystemDependencies Initialize(IUnitSystemDependencyFactory unitSystemDependencyFactory = null, Action<IUnitRegistrar> registerUnitAction = null)
        {
            return Instance.InitializeUnitSystem(unitSystemDependencyFactory, registerUnitAction);
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public static void Reset()
        {
            Instance.ResetUnitSystem();
        }

        /// <summary>
        /// Gets the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// An <see cref="IUnit" />.
        /// </returns>
        internal static IUnit GetUnitFrom(string unit)
        {
            EnsureInitialization();
            return Instance.GetUnit(unit, ParseSettings.DefaultInvariantCulture).Value;
        }

        private static void EnsureInitialization()
        {
            var unitSystem = Instance;
            lock (unitSystem.unitSystemLock)
            {
                if (!Instance.isInitialized)
                {
                    Instance.InitializeUnitSystemWithDefaults();
                }
            }
        }

        private static class Nested
        {
            internal static readonly UnitSystem UnitSystemInstance =
                new UnitSystem();

            [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1409:RemoveUnnecessaryCode",
                Justification = "Explicit static constructor to tell C# compiler not to mark type as beforefieldinit")]
            static Nested()
            {
            }
        }
    }
}