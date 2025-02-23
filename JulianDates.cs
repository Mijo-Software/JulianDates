namespace Julian_and_his_dates
{
	/// <summary>
	/// JulianDates
	/// </summary>
	public static class JulianDates
	{
		#region consonants

		/// <summary>
		/// Julian Date coefficient
		/// </summary>
		private const double doubleJulianDateCoefficient = 2415018.5;

		/// <summary>
		/// Modified Julian Date coefficient
		/// </summary>
		private const double doubleModifiedJulianDateCoefficient = 2400000.5;

		/// <summary>
		/// Reduced Julian Date coefficient
		/// </summary>
		private const double doubleReducedJulianDateCoefficient = 2400000;

		/// <summary>
		/// Truncated Julian Date coefficient
		/// </summary>
		private const double doubleTruncatedJulianDateCoefficient = 2440000.5;

		/// <summary>
		/// Dublin Julian Date coefficient
		/// </summary>
		private const double doubleDublinJulianDateCoefficient = 2415020;

		/// <summary>
		/// CCNES Julian Date coefficient
		/// </summary>
		private const double doubleCnesJulianDateCoefficient = 2433282.5;

		/// <summary>
		/// CCSDS Julian Date coefficient
		/// </summary>
		private const double doubleCcsdsJulianDateCoefficient = 2436204.5;

		/// <summary>
		/// LOP Julian Date coefficient
		/// </summary>
		private const double doubleLopJulianDateCoefficient = 2448622.5;

		/// <summary>
		/// Millennium Julian Date coefficient
		/// </summary>
		private const double doubleMillenniumJulianDateCoefficient = 2451544.5;

		/// <summary>
		/// Lilian Date coefficient
		/// </summary>
		private const double doubleLilianDateCoefficient = 2299159.5;

		/// <summary>
		/// Rata Die coefficient
		/// </summary>
		private const double doubleRataDieCoefficient = 1721424.5;

		/// <summary>
		/// Mars Sol Date coefficient
		/// </summary>
		private const double doubleMarsSolDateCoefficient = 2405522;

		/// <summary>
		/// ratio of the rotation of Earth and Mars
		/// </summary>
		private const double doubleRatioRotationAxisEarthMars = 1.02749;

		/// <summary>
		/// Unix Time coefficient
		/// </summary>
		private const double doubleUnixtimeCoefficient = 2440587.5;

		/// <summary>
		/// seconds in a day
		/// </summary>
		private const int secondsOfDay = 86400;

		#endregion

		#region JD Calculators

		/// <summary>
		/// Calculate the Julian Date from the Universal time
		/// </summary>
		/// <returns>Julian Date</returns>
		public static double CalculateJulianDate() => DateTime.Now.ToUniversalTime().ToOADate() + doubleJulianDateCoefficient;

		/// <summary>
		/// Calculate the Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Julian Date</returns>
		public static double CalculateJulianDate(DateTime date) => date.ToOADate() + doubleJulianDateCoefficient;

		/// <summary>
		/// Calculate the Modified Julian Date
		/// </summary>
		/// <returns>Modified Julian Date</returns>
		public static double CalculateModifiedJulianDate() => CalculateJulianDate() - doubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Modified Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Modified Julian Date</returns>
		public static double CalculateModifiedJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Modified Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Modified Julian Date</returns>
		public static double CalculateModifiedJulianDate(double julianDate) => julianDate - doubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Reduced Julian Date
		/// </summary>
		/// <returns>Reduced Julian Date</returns>
		public static double CalculateReducedJulianDate() => CalculateJulianDate() - doubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Reduced Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Reduced Julian Date</returns>
		public static double CalculateReducedJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Reduced Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Reduced Julian Date</returns>
		public static double CalculateReducedJulianDate(double julianDate) => julianDate - doubleReducedJulianDateCoefficient;

		/// <summary>
		/// Calculate the Truncated Julian Date
		/// </summary>
		/// <returns>Truncated Julian Date</returns>
		public static double CalculateTruncatedJulianDate() => Math.Floor(d: CalculateJulianDate() - doubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculate the Truncated Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Truncated Julian Date</returns>
		public static double CalculateTruncatedJulianDate(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - doubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculate the Truncated Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Truncated Julian Date</returns>
		public static double CalculateTruncatedJulianDate(double julianDate) => Math.Floor(d: julianDate - doubleTruncatedJulianDateCoefficient);

		/// <summary>
		/// Calculate the Dublin Julian Date
		/// </summary>
		/// <returns>Dublin Julian Date</returns>
		public static double CalculateDublinJulianDate() => CalculateJulianDate() - doubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculate the Dublin Julian Date from the date
		/// </summary>
		/// <param name="date"></param>
		/// <returns>Dublin Julian Date</returns>
		public static double CalculateDublinJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculate the Dublin Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate"></param>
		/// <returns>Dublin Julian Date</returns>
		public static double CalculateDublinJulianDate(double julianDate) => julianDate - doubleDublinJulianDateCoefficient;

		/// <summary>
		/// Calculate the CNES Julian Date
		/// </summary>
		/// <returns>CNES Julian Date</returns>
		public static double CalculateCnesJulianDate() => CalculateJulianDate() - doubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculate the CNES Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>CNES Julian Date</returns>
		public static double CalculateCnesJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculate the CNES Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CNES Julian Date</returns>
		public static double CalculateCnesJulianDate(double julianDate) => julianDate - doubleCnesJulianDateCoefficient;

		/// <summary>
		/// Calculate the CCSDS Julian Date
		/// </summary>
		/// <returns>CCSDS Julian Date</returns>
		public static double CalculateCcsdsJulianDate() => CalculateJulianDate() - doubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculate the CCSDS Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>CCSDS Julian Date</returns>
		public static double CalculateCcsdsJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculate the CCSDS Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CCSDS Julian Date</returns>
		public static double CalculateCcsdsJulianDate(double julianDate) => julianDate - doubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Calculate the LOP Julian Date
		/// </summary>
		/// <returns>LOP Julian Date</returns>
		public static double CalculateLopJulianDate() => CalculateJulianDate() - doubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculate the LOP Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>LOP Julian Date</returns>
		public static double CalculateLopJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculate the LOP Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns></returns>
		/// <returns>LOP Julian Date</returns>
		public static double CalculateLopJulianDate(double julianDate) => julianDate - doubleLopJulianDateCoefficient;

		/// <summary>
		/// Calculate the Millennium Julian Date
		/// </summary>
		/// <returns>Millennium Julian Date</returns>
		public static double CalculateMillenniumJulianDate() => CalculateJulianDate() - doubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculate the Millennium Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Millennium Julian Date</returns>
		public static double CalculateMillenniumJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculate the Millennium Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Millennium Julian Date</returns>
		public static double CalculateMillenniumJulianDate(double julianDate) => julianDate - doubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Calculate the Chronological Julian Date
		/// </summary>
		/// <returns>Chronological Julian Date</returns>
		public static double CalculateChronologicalJulianDate()
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate() + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculate the Chronological Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Chronological Julian Date</returns>
		public static double CalculateChronologicalJulianDate(DateTime date)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate(date: date) + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculate the Chronological Julian Date from the Julian Date
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
		/// Calculate the Chronological Modified Julian Date
		/// </summary>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double CalculateChronologicalModifiedJulianDate()
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate() - doubleModifiedJulianDateCoefficient + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculate the Chronological Modified Julian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double CalculateChronologicalModifiedJulianDate(DateTime date)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return CalculateJulianDate(date: date) -
			doubleModifiedJulianDateCoefficient +
			0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculate the Chronological Modified Julian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double CalculateChronologicalModifiedJulianDate(double julianDate)
		{
			TimeZoneInfo zone = TimeZoneInfo.Local;
			TimeSpan time = zone.GetAdjustmentRules().FirstOrDefault()?.DaylightDelta ?? TimeSpan.Zero;
			return julianDate - doubleModifiedJulianDateCoefficient + 0.5 + (time.TotalHours / 24.0);
		}

		/// <summary>
		/// Calculate the Lilian Date
		/// </summary>
		/// <returns>Lilian Date</returns>
		public static double CalculateLilianDate() => Math.Floor(d: CalculateJulianDate() - doubleLilianDateCoefficient);

		/// <summary>
		/// Calculate the Lilian Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Lilian Date</returns>
		public static double CalculateLilianDate(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - doubleLilianDateCoefficient);

		/// <summary>
		/// Calculate the Lilian Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Lilian Date</returns>
		public static double CalculateLilianDate(double julianDate) => Math.Floor(d: julianDate - doubleLilianDateCoefficient);

		/// <summary>
		/// Calculate the Rata Die
		/// </summary>
		/// <returns>Rata Die</returns>
		public static double CalculateRataDie() => Math.Floor(d: CalculateJulianDate() - doubleRataDieCoefficient);

		/// <summary>
		/// Calculate the Rata Die from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Rata Die</returns>
		public static double CalculateRataDie(DateTime date) => Math.Floor(d: CalculateJulianDate(date: date) - doubleRataDieCoefficient);

		/// <summary>
		/// Calculate the Rata Die from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Rata Die</returns>
		public static double CalculateRataDie(double julianDate) => Math.Floor(d: julianDate - doubleRataDieCoefficient);

		/// <summary>
		/// Calculate the Mars Sol Date
		/// </summary>
		/// <returns>Mars Sol Date</returns>
		public static double CalculateMarsSolDate() => (CalculateJulianDate() - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculate the Mars Sol Date from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Mars Sol Date</returns>
		public static double CalculateMarsSolDate(DateTime date) => (CalculateJulianDate(date: date) - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculate the Mars Sol Date from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Mars Sol Date</returns>
		public static double CalculateMarsSolDate(double julianDate) => (julianDate - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

		/// <summary>
		/// Calculate the Unix Time
		/// </summary>
		/// <returns>Unix Time</returns>
		public static double CalculateUnixTime() => (CalculateJulianDate() - doubleUnixtimeCoefficient) * secondsOfDay;

		/// <summary>
		/// Calculate the Unix Time from the date
		/// </summary>
		/// <param name="date">date</param>
		/// <returns>Unix Time</returns>
		public static double CalculateUnixTime(DateTime date) => (CalculateJulianDate(date: date) - doubleUnixtimeCoefficient) * secondsOfDay;

		/// <summary>
		/// Calculate the Unix Time from the Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Unix Time</returns>
		public static double CalculateUnixTime(double julianDate) => (julianDate - doubleUnixtimeCoefficient) * secondsOfDay;

		#endregion

		#region JD Converters

		/// <summary>
		/// Convert Julian Date to civil calendar
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>civil calendar</returns>
		public static DateTime ConvertJulianDateToCivilCalendar(double julianDate)
		{
			double j = julianDate + 0.5;
			int Z = (int)j;
			double F = j - Z;
			int A = Z;
			if (Z >= 2299161)
			{
				int alpha = (int)((Z - 1867216.25) / 36524.25);
				A += 1 + alpha - (int)(alpha / 4.0);
			}
			int B = A + 1524;
			int C = (int)((B - 122.1) / 365.25);
			int D = (int)(365.25 * C);
			int E = (int)((B - D) / 30.6001);

			int day = B - D - (int)(30.6001 * E);
			int month = (E < 14) ? E - 1 : E - 13;
			int year = (month > 2) ? C - 4716 : C - 4715;

			double dayFraction = F * 24.0;
			int hour = (int)dayFraction;
			double minuteFraction = (dayFraction - hour) * 60.0;
			int minute = (int)minuteFraction;
			int second = (int)((minuteFraction - minute) * 60.0);

			return new DateTime(year, month, day, hour, minute, second);
		}


		/// <summary>
		/// Convert the Julian Date to the Modified Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Modified Julian Date</returns>
		public static double ConvertJulianDateToModifiedJulianDate(double julianDate) => julianDate -
			doubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Convert the Modified Julian Date to the Julian Date
		/// </summary>
		/// <param name="julianModifiedDate">Modified Julian Date</param>
		/// <returns>Julian Date</returns>
		public static double ConvertModifiedJulianDateToJulianDate(double julianModifiedDate) => julianModifiedDate +
			doubleModifiedJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Reduced Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Reduced Julian Date</returns>
		public static double ConvertJulianDateToReducedJulianDate(double julianDate) => julianDate -
			doubleReducedJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Truncated Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Truncated Julian Date</returns>
		public static double ConvertJulianDateToTruncatedJulianDate(double julianDate) => julianDate -
			doubleTruncatedJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Dublin Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Dublin Julian Date</returns>
		public static double ConvertJulianDateToDublinJulianDate(double julianDate) => julianDate -
			doubleDublinJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date the CNES Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CNES Julian Date</returns>
		public static double ConvertJulianDateToCnesJulianDate(double julianDate) => julianDate -
			doubleCnesJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the CCSDS Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>CCSDS Julian Date</returns>
		public static double ConvertJulianDateToCcsdsJulianDate(double julianDate) => julianDate -
			doubleCcsdsJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the LOP Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>LOP Julian Date</returns>
		public static double ConvertJulianDateToLopJulianDate(double julianDate) => julianDate -
			doubleLopJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Millennium Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Millennium Julian Date</returns>
		public static double ConvertJulianDateToMillenniumJulianDate(double julianDate) => julianDate -
			doubleMillenniumJulianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Chronological Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Julian Date</returns>
		public static double ConvertJulianDateToChronologicalJulianDate(double julianDate) => CalculateChronologicalJulianDate(
			julianDate: julianDate);

		/// <summary>
		/// Convert the Julian Date to the Chronological Modified Julian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Chronological Modified Julian Date</returns>
		public static double ConvertJulianDateToChronologicalModifiedJulianDate(double julianDate) => CalculateChronologicalModifiedJulianDate(
			julianDate: julianDate);

		/// <summary>
		/// Convert the Julian Date to the Lilian Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Lilian Date</returns>
		public static double ConvertJulianDateToLilianDate(double julianDate) => julianDate -
			doubleLilianDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Rata Die
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Rata Die</returns>
		public static double ConvertJulianDateToRataDie(double julianDate) => julianDate - doubleRataDieCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Mars Sol Date
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Mars Sol Date</returns>
		public static double ConvertJulianDateToMarsSolDate(double julianDate) => julianDate -
			doubleMarsSolDateCoefficient;

		/// <summary>
		/// Convert the Julian Date to the Unix Time
		/// </summary>
		/// <param name="julianDate">Julian Date</param>
		/// <returns>Unix Time</returns>
		public static double ConvertJulianDateToUnixtime(double julianDate) => julianDate - doubleUnixtimeCoefficient;
		#endregion
	}
}