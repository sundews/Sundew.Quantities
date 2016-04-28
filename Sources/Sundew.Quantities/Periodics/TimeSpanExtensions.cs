namespace Sundew.Quantities.Periodics
{
    using System;

    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Periodics.UnitSelection;

    /// <summary>
    /// Extension methods for converting <see cref="TimeSpan"/> into <see cref="Time"/>.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Converts the specified <see cref="TimeSpan"/> to <see cref="Time"/> with the specified unit.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The <see cref="Time"/> quantity.</returns>
        public static Time ToTime(this TimeSpan timeSpan, SelectUnit<TimeUnitSelector> unitSelector)
        {
            return ((Time)timeSpan).ToUnit(unitSelector);
        }
    }
}