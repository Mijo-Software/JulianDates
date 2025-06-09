namespace Julian_and_his_dates
{
	/// <summary>
	/// Provides static methods and constants for converting and calculating various astronomical and civil date formats
	/// based on the Julian Date system. This class includes methods for converting between Julian Date, Modified Julian Date,
	/// Reduced Julian Date, Truncated Julian Date, Dublin Julian Date, CNES Julian Date, CCSDS Julian Date, LOP Julian Date,
	/// Millennium Julian Date, Lilian Date, Rata Die, Mars Sol Date, Unix Time, and civil calendar dates.
	/// </summary>
	public static class JulianDates
	{
		#region consonants

		/// <summary>
		/// Offset to convert OLE Automation Date (OADate) to Julian Date.
		/// </summary>
		private const double DoubleJulianDateCoefficient = 2415018.5;

		/// <summary>
		/// Offset to convert Julian Date to Modified Julian Date (MJD).
		/// </summary>
		private const double DoubleModifiedJulianDateCoefficient = 2400000.5;

		/// <summary>
		/// Offset to convert Julian Date to Reduced Julian Date (RJD).
		/// </summary>
		private const double DoubleReducedJulianDateCoefficient = 2400000;

		/// <summary>
		/// Offset to convert Julian Date to Truncated Julian Date (TJD).
		/// </summary>
		private const double DoubleTruncatedJulianDateCoefficient = 2440000.5;

		/// <summary>
		/// Offset to convert Julian Date to Dublin Julian Date (DJD).
		/// </summary>
		private const double DoubleDublinJulianDateCoefficient = 2415020;

		/// <summary>
		/// Offset to convert Julian Date to CNES Julian Date.
		/// </summary>
		private const double DoubleCnesJulianDateCoefficient = 2433282.5;

		/// <summary>
		/// Offset to convert Julian Date to CCSDS Julian Date.
		/// </summary>
		private const double DoubleCcsdsJulianDateCoefficient = 2436204.5;

		/// <summary>
		/// Offset to convert Julian Date to LOP Julian Date.
		/// </summary>
		private const double DoubleLopJulianDateCoefficient = 2448622.5;

		/// <summary>
		/// Offset to convert Julian Date to Millennium Julian Date.
		/// </summary>
		private const double DoubleMillenniumJulianDateCoefficient = 2451544.5;

		/// <summary>
		/// Offset to convert Julian Date to Lilian Date.
		/// </summary>
		private const double DoubleLilianDateCoefficient = 2299159.5;

		/// <summary>
		/// Offset to convert Julian Date to Rata Die.
		/// </summary>
		private const double DoubleRataDieCoefficient = 1721424.5;

		/// <summary>
		/// Offset to convert Julian Date to Mars Sol Date.
		/// </summary>
		private const double DoubleMarsSolDateCoefficient = 2405522;

		/// <summary>
		/// Ratio of the rotation period of Earth to Mars (used for Mars Sol Date calculation).
		/// </summary>
		private const double DoubleRatioRotationAxisEarthMars = 1.02749;

		/// <summary>
		/// Offset to convert Julian Date to Unix Time (seconds since 1970-01-01).
		/// </summary>
		private const double DoubleUnixTimeCoefficient = 2440587.5;

		/// <summary>
		/// Number of seconds in a day (used for time conversions).
		/// </summary>
		private const int SecondsOfDay = 86400;

		#endregion

		#region JD Calculators

		/// <summary>
		/// Calculates the current Julian Date using the current system time in UTC.
		/// The calculation is based on converting the current UTC time to an OLE Automation Date (OADate)
		/// and then adding the Julian Date coefficient to obtain the astronomical Julian Date.
		/// </summary>
		/// <returns>Julian Date for the current UTC time</returns>
		public static double CalculateJulianDate() => DateTime.Now.ToUniversalTime().ToOADate() + DoubleJulianDateCoefficient;

		/// <summary>
		/// Calculates the Julian Date for a given date and time.
		/// The calculation converts the provided DateTime to an OLE Automation Date (OADate)
		/// and adds the Julian Date coefficient to obtain the astronomical Julian Date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Julian Date corresponding to the specified date and time</returns>
		public static double CalculateJulianDate(DateTime date) => date.ToOADate() + DoubleJulianDateCoefficient;

		/// <summary>
		/// Calculates the current Modified Julian Date (MJD) using the current system time in UTC.
		/// The result is obtained by subtracting the Modified Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>Modified Julian Date for the current UTC time</returns>
		public static double CalculateModifiedJulianDate() => CalculateJulianDate() - DoubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculates the Modified Julian Date (MJD) for a given date and time.
		/// The result is obtained by subtracting the Modified Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Modified Julian Date corresponding to the specified date and time</returns>
		public static double CalculateModifiedJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculates the Modified Julian Date (MJD) from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Modified Julian Date</returns>
		public static double CalculateModifiedJulianDate(double julianDate) => julianDate - DoubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculates the current Reduced Julian Date (RJD) using the current system time in UTC.
		/// The result is obtained by subtracting the Reduced Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>Reduced Julian Date for the current UTC time</returns>
		public static double CalculateReducedJulianDate() => CalculateJulianDate() - DoubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculates the Reduced Julian Date (RJD) for a given date and time.
		/// The result is obtained by subtracting the Reduced Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Reduced Julian Date corresponding to the specified date and time</returns>
		public static double CalculateReducedJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculates the Reduced Julian Date (RJD) from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Reduced Julian Date</returns>
		public static double CalculateReducedJulianDate(double julianDate) => julianDate - DoubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculates the current Truncated Julian Date (TJD) using the current system time in UTC.
		/// The result is the floored value of the current Julian Date minus the Truncated Julian Date coefficient.
		/// </summary>
		/// <returns>Truncated Julian Date for the current UTC time</returns>
		public static double CalculateTruncatedJulianDate() => Math.Floor(d: CalculateJulianDate() - DoubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculates the Truncated Julian Date (TJD) for a given date and time.
		/// The result is the floored value of the Julian Date of the specified date minus the Truncated Julian Date coefficient.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Truncated Julian Date corresponding to the specified date and time</returns>
		public static double CalculateTruncatedJulianDate(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - DoubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculates the Truncated Julian Date (TJD) from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Truncated Julian Date</returns>
		public static double CalculateTruncatedJulianDate(double julianDate) => Math.Floor(d: julianDate - DoubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculates the current Dublin Julian Date (DJD) using the current system time in UTC.
		/// The result is obtained by subtracting the Dublin Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>Dublin Julian Date for the current UTC time</returns>
		public static double CalculateDublinJulianDate() => CalculateJulianDate() - DoubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculates the Dublin Julian Date (DJD) for a given date and time.
		/// The result is obtained by subtracting the Dublin Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Dublin Julian Date corresponding to the specified date and time</returns>
		public static double CalculateDublinJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculates the Dublin Julian Date (DJD) from a given Julian Date.
		/// The result is obtained by subtracting the Dublin Julian Date coefficient from the specified Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Dublin Julian Date</returns>
		public static double CalculateDublinJulianDate(double julianDate) => julianDate - DoubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculates the current CNES Julian Date using the current system time in UTC.
		/// The result is obtained by subtracting the CNES Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>CNES Julian Date for the current UTC time</returns>
		public static double CalculateCnesJulianDate() => CalculateJulianDate() - DoubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculates the CNES Julian Date for a given date and time.
		/// The result is obtained by subtracting the CNES Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>CNES Julian Date corresponding to the specified date and time</returns>
		public static double CalculateCnesJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculates the CNES Julian Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CNES Julian Date</returns>
		public static double CalculateCnesJulianDate(double julianDate) => julianDate - DoubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculates the current CCSDS Julian Date using the current system time in UTC.
		/// The result is obtained by subtracting the CCSDS Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>CCSDS Julian Date for the current UTC time</returns>
		public static double CalculateCcsdsJulianDate() => CalculateJulianDate() - DoubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculates the CCSDS Julian Date for a given date and time.
		/// The result is obtained by subtracting the CCSDS Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>CCSDS Julian Date corresponding to the specified date and time</returns>
		public static double CalculateCcsdsJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculates the CCSDS Julian Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CCSDS Julian Date</returns>
		public static double CalculateCcsdsJulianDate(double julianDate) => julianDate - DoubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculates the current LOP Julian Date using the current system time in UTC.
		/// The result is obtained by subtracting the LOP Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>LOP Julian Date for the current UTC time</returns>
		public static double CalculateLopJulianDate() => CalculateJulianDate() - DoubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculates the LOP Julian Date for a given date and time.
		/// The result is obtained by subtracting the LOP Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>LOP Julian Date corresponding to the specified date and time</returns>
		public static double CalculateLopJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculates the LOP Julian Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>LOP Julian Date</returns>
		public static double CalculateLopJulianDate(double julianDate) => julianDate - DoubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculates the current Millennium Julian Date using the current system time in UTC.
		/// The result is obtained by subtracting the Millennium Julian Date coefficient from the current Julian Date.
		/// </summary>
		/// <returns>Millennium Julian Date for the current UTC time</returns>
		public static double CalculateMillenniumJulianDate() => CalculateJulianDate() - DoubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculates the Millennium Julian Date for a given date and time.
		/// The result is obtained by subtracting the Millennium Julian Date coefficient from the Julian Date of the specified date.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Millennium Julian Date corresponding to the specified date and time</returns>
		public static double CalculateMillenniumJulianDate(DateTime date) => CalculateJulianDate(date: date) - DoubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculates the Millennium Julian Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Millennium Julian Date</returns>
		public static double CalculateMillenniumJulianDate(double julianDate) => julianDate - DoubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculates the current Chronological Julian Date using the current system time in the local time zone.
		/// The result is the Julian Date plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <returns>Chronological Julian Date for the current local time</returns>
		public static double CalculateChronologicalJulianDate()
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate() + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the Chronological Julian Date for a given date and time in the local time zone.
		/// The result is the Julian Date of the specified date plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Chronological Julian Date corresponding to the specified date and time</returns>
		public static double CalculateChronologicalJulianDate(DateTime date)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate(date: date) + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the Chronological Julian Date from a given Julian Date in the local time zone.
		/// The result is the specified Julian Date plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Julian Date</returns>
		public static double CalculateChronologicalJulianDate(double julianDate)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return julianDate + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the current Chronological Modified Julian Date using the current system time in the local time zone.
		/// The result is the Modified Julian Date plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <returns>Chronological Modified Julian Date for the current local time</returns>
		public static double CalculateChronologicalModifiedJulianDate()
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate() - DoubleModifiedJulianDateCoefficient + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the Chronological Modified Julian Date for a given date and time in the local time zone.
		/// The result is the Modified Julian Date of the specified date plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Chronological Modified Julian Date corresponding to the specified date and time</returns>
		public static double CalculateChronologicalModifiedJulianDate(DateTime date)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate(date: date) -
				DoubleModifiedJulianDateCoefficient +
				0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the Chronological Modified Julian Date from a given Julian Date in the local time zone.
		/// The result is the specified Julian Date minus the Modified Julian Date coefficient, plus 0.5 and the local daylight saving time offset (in days).
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double CalculateChronologicalModifiedJulianDate(double julianDate)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return julianDate - DoubleModifiedJulianDateCoefficient + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculates the current Lilian Date using the current system time in UTC.
		/// The result is the floored value of the current Julian Date minus the Lilian Date coefficient.
		/// </summary>
		/// <returns>Lilian Date for the current UTC time</returns>
		public static double CalculateLilianDate() => Math.Floor(d: CalculateJulianDate() - DoubleLilianDateCoefficient);

		/// <summary>
		/// Calculates the Lilian Date for a given date and time.
		/// The result is the floored value of the Julian Date of the specified date minus the Lilian Date coefficient.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Lilian Date corresponding to the specified date and time</returns>
		public static double CalculateLilianDate(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - DoubleLilianDateCoefficient);

		/// <summary>
		/// Calculates the Lilian Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Lilian Date</returns>
		public static double CalculateLilianDate(double julianDate) => Math.Floor(d: julianDate - DoubleLilianDateCoefficient);

		/// <summary>
		/// Calculates the current Rata Die using the current system time in UTC.
		/// The result is the floored value of the current Julian Date minus the Rata Die coefficient.
		/// </summary>
		/// <returns>Rata Die for the current UTC time</returns>
		public static double CalculateRataDie() => Math.Floor(d: CalculateJulianDate() - DoubleRataDieCoefficient);

		/// <summary>
		/// Calculates the Rata Die for a given date and time.
		/// The result is the floored value of the Julian Date of the specified date minus the Rata Die coefficient.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Rata Die corresponding to the specified date and time</returns>
		public static double CalculateRataDie(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - DoubleRataDieCoefficient);

		/// <summary>
		/// Calculates the Rata Die from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Rata Die</returns>
		public static double CalculateRataDie(double julianDate) => Math.Floor(d: julianDate - DoubleRataDieCoefficient);

		/// <summary>
		/// Calculates the current Mars Sol Date using the current system time in UTC.
		/// The result is obtained by subtracting the Mars Sol Date coefficient from the current Julian Date
		/// and dividing by the Earth-Mars rotation ratio.
		/// </summary>
		/// <returns>Mars Sol Date for the current UTC time</returns>
		public static double CalculateMarsSolDate() => (CalculateJulianDate() - DoubleMarsSolDateCoefficient) / DoubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculates the Mars Sol Date for a given date and time.
		/// The result is obtained by subtracting the Mars Sol Date coefficient from the Julian Date of the specified date
		/// and dividing by the Earth-Mars rotation ratio.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Mars Sol Date corresponding to the specified date and time</returns>
		public static double CalculateMarsSolDate(DateTime date) => (CalculateJulianDate(date: date) - DoubleMarsSolDateCoefficient) / DoubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculates the Mars Sol Date from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Mars Sol Date</returns>
		public static double CalculateMarsSolDate(double julianDate) => (julianDate - DoubleMarsSolDateCoefficient) / DoubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculates the current Unix Time (seconds since 1970-01-01) using the current system time in UTC.
		/// The result is obtained by subtracting the Unix Time coefficient from the current Julian Date and multiplying by the number of seconds in a day.
		/// </summary>
		/// <returns>Unix Time for the current UTC time</returns>
		public static double CalculateUnixTime() => (CalculateJulianDate() - DoubleUnixTimeCoefficient) * SecondsOfDay;

		/// <summary>
		/// Calculates the Unix Time (seconds since 1970-01-01) for a given date and time.
		/// The result is obtained by subtracting the Unix Time coefficient from the Julian Date of the specified date and multiplying by the number of seconds in a day.
		/// </summary>
		/// <param name="date">The date and time to convert</param>
		/// <returns>Unix Time corresponding to the specified date and time</returns>
		public static double CalculateUnixTime(DateTime date) => (CalculateJulianDate(date: date) - DoubleUnixTimeCoefficient) * SecondsOfDay;

		/// <summary>
		/// Calculates the Unix Time (seconds since 1970-01-01) from a given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Unix Time</returns>
		public static double CalculateUnixTime(double julianDate) => (julianDate - DoubleUnixTimeCoefficient) * SecondsOfDay;

		#endregion

		#region JD Converters

		/// <summary>
		/// Converts a Julian Date to a civil calendar date and time (DateTime).
		/// </summary>
		/// <param name="julianDate">The Julian Date to convert.</param>
		/// <returns>DateTime representing the corresponding civil calendar date and time.</returns>
		public static DateTime ConvertJulianDateToCivilCalendar(double julianDate)
		{
			// Add 0.5 to the Julian date to align with the start of the civil day
			double j = julianDate + 0.5;

			// Separate the integer and fractional parts
			int z = (int)j;
			double f = j - z;

			// Gregorian calendar correction
			int a;
			if (z < 2299161)
			{
				// Julian calendar
				a = z;
			}
			else
			{
				// Gregorian calendar
				int alpha = (int)((z - 1867216.25) / 36524.25);
				a = z + 1 + alpha - (alpha / 4);
			}

			// Calculate intermediate values for year, month, and day
			int b = a + 1524;
			int c = (int)((b - 122.1) / 365.25);
			int d = (int)(365.25 * c);
			int e = (int)((b - d) / 30.6001);

			// Calculate day, month, and year
			int day = b - d - (int)(30.6001 * e);
			int month = (e < 14) ? e - 1 : e - 13;
			int year = (month > 2) ? c - 4716 : c - 4715;

			// Efficiently calculate the time part (hour, minute, second) from the fractional day
			double totalSeconds = f * 86400.0;
			int hour = (int)(totalSeconds / 3600);
			int minute = (int)(totalSeconds % 3600 / 60);
			int second = (int)(totalSeconds % 60);

			// Construct and return the DateTime object
			return new DateTime(year: year, month: month, day: day, hour: hour, minute: minute, second: second);
		}

		/// <summary>
		/// Converts a Julian Date to the Modified Julian Date (MJD).
		/// The result is obtained by subtracting the Modified Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Modified Julian Date</returns>
		public static double ConvertJulianDateToModifiedJulianDate(double julianDate) => julianDate - DoubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Converts a Modified Julian Date (MJD) to the Julian Date.
		/// The result is obtained by adding the Modified Julian Date coefficient to the given Modified Julian Date.
		/// </summary>
		/// <param name="julianModifiedDate">Modified Julian Date</param>
		/// <returns>Julian Date</returns>
		public static double ConvertModifiedJulianDateToJulianDate(double julianModifiedDate) => julianModifiedDate + DoubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Reduced Julian Date (RJD).
		/// The result is obtained by subtracting the Reduced Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Reduced Julian Date</returns>
		public static double ConvertJulianDateToReducedJulianDate(double julianDate) => julianDate - DoubleReducedJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Truncated Julian Date (TJD).
		/// The result is obtained by subtracting the Truncated Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Truncated Julian Date</returns>
		public static double ConvertJulianDateToTruncatedJulianDate(double julianDate) => julianDate - DoubleTruncatedJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Dublin Julian Date (DJD).
		/// The result is obtained by subtracting the Dublin Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Dublin Julian Date</returns>
		public static double ConvertJulianDateToDublinJulianDate(double julianDate) => julianDate - DoubleDublinJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the CNES Julian Date.
		/// The result is obtained by subtracting the CNES Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CNES Julian Date</returns>
		public static double ConvertJulianDateToCnesJulianDate(double julianDate) => julianDate - DoubleCnesJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the CCSDS Julian Date.
		/// The result is obtained by subtracting the CCSDS Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CCSDS Julian Date</returns>
		public static double ConvertJulianDateToCcsdsJulianDate(double julianDate) => julianDate - DoubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the LOP Julian Date.
		/// The result is obtained by subtracting the LOP Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>LOP Julian Date</returns>
		public static double ConvertJulianDateToLopJulianDate(double julianDate) => julianDate - DoubleLopJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Millennium Julian Date.
		/// The result is obtained by subtracting the Millennium Julian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Millennium Julian Date</returns>
		public static double ConvertJulianDateToMillenniumJulianDate(double julianDate) => julianDate - DoubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Chronological Julian Date.
		/// The result is calculated using the CalculateChronologicalJulianDate method.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Julian Date</returns>
		public static double ConvertJulianDateToChronologicalJulianDate(double julianDate) => CalculateChronologicalJulianDate(julianDate: julianDate);

		/// <summary>
		/// Converts a Julian Date to the Chronological Modified Julian Date.
		/// The result is calculated using the CalculateChronologicalModifiedJulianDate method.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double ConvertJulianDateToChronologicalModifiedJulianDate(double julianDate) => CalculateChronologicalModifiedJulianDate(julianDate: julianDate);

		/// <summary>
		/// Converts a Julian Date to the Lilian Date.
		/// The result is obtained by subtracting the Lilian Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Lilian Date</returns>
		public static double ConvertJulianDateToLilianDate(double julianDate) => julianDate - DoubleLilianDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Rata Die.
		/// The result is obtained by subtracting the Rata Die coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Rata Die</returns>
		public static double ConvertJulianDateToRataDie(double julianDate) => julianDate - DoubleRataDieCoefficient;

		/// <summary>
		/// Converts a Julian Date to the Mars Sol Date.
		/// The result is obtained by subtracting the Mars Sol Date coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Mars Sol Date</returns>
		public static double ConvertJulianDateToMarsSolDate(double julianDate) => julianDate - DoubleMarsSolDateCoefficient;

		/// <summary>
		/// Converts a Julian Date to Unix Time (days since 1970-01-01).
		/// The result is obtained by subtracting the Unix Time coefficient from the given Julian Date.
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Unix Time</returns>
		public static double ConvertJulianDateToUnixTime(double julianDate) => julianDate - DoubleUnixTimeCoefficient;

		#endregion
	}
}