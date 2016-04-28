namespace Sundew.Quantities.Serialization.Poco.Periodics
{
    /// <summary>
    /// Serialization extension methods for periodic quantities.
    /// </summary>
    public static class PeriodicsExtensions
    {
        /// <summary>
        /// Creates the serializable frequency.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        /// <returns>A new serializable <see cref="Frequency" />.</returns>
        public static Frequency ToSerializable(this Quantities.Periodics.Frequency frequency)
        {
            return new Frequency(frequency);
        }

        /// <summary>
        /// Creates the serializable time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>A new serializable <see cref="Time" />.</returns>
        public static Time ToSerializable(this Quantities.Periodics.Time time)
        {
            return new Time(time);
        }
    }
}