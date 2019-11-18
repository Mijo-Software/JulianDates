using System;
using System.Globalization;

/// <summary>
/// 
/// </summary>
public class JulianDates
{
	private const double
		doubleJulianDateCoefficient = 2415018.5,
		doubleModifiedJulianDateCoefficient = 2400000.5,
		doubleReducedJulianDateCoefficient = 2400000,
		doubleTruncatedJulianDateCoefficient = 2440000.5,
		doubleDublinJulianDateCoefficient = 2415020,
		doubleCnesJulianDateCoefficient = 2433282.5,
		doubleCcsdsJulianDateCoefficient = 2436204.5,
		doubleLopJulianDateCoefficient = 2448622.5,
		doubleMillenniumJulianDateCoefficient = 2451544.5,
		doubleLilianDateCoefficient = 2299159.5,
		doubleRataDieCoefficient = 1721424.5,
		doubleMarsSolDateCoefficient = 2405522,
		doubleRatioRotationAxisEarthMars = 1.02749,
		doubleUnixtimeCoefficient = 2440587.5;

	private const int intSecondsOfDay = 86400;

	#region JD Calculators

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateJulianDate() => DateTime.Now.ToUniversalTime().ToOADate() + doubleJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateJulianDate(DateTime date) => date.ToOADate() + doubleJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateModifiedJulianDate() => CalculateJulianDate() - doubleModifiedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateModifiedJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleModifiedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateModifiedJulianDate(double julianDate) => julianDate - doubleModifiedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateReducedJulianDate() => CalculateJulianDate() - doubleReducedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateReducedJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleReducedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateReducedJulianDate(double julianDate) => julianDate - doubleReducedJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateTruncatedJulianDate() => Math.Floor(CalculateJulianDate() - doubleTruncatedJulianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateTruncatedJulianDate(DateTime date) => Math.Floor(CalculateJulianDate(date: date) - doubleTruncatedJulianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateTruncatedJulianDate(double julianDate) => Math.Floor(julianDate - doubleTruncatedJulianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateDublinJulianDate() => CalculateJulianDate() - doubleDublinJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateDublinJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleDublinJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateDublinJulianDate(double julianDate) => julianDate - doubleDublinJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateCnesJulianDate() => CalculateJulianDate() - doubleCnesJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateCnesJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleCnesJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateCnesJulianDate(double julianDate) => julianDate - doubleCnesJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateCcsdsJulianDate() => CalculateJulianDate() - doubleCcsdsJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateCcsdsJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleCcsdsJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateCcsdsJulianDate(double julianDate) => julianDate - doubleCcsdsJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateLopJulianDate() => CalculateJulianDate() - doubleLopJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateLopJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleLopJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateLopJulianDate(double julianDate) => julianDate - doubleLopJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateMillenniumJulianDate() => CalculateJulianDate() - doubleMillenniumJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateMillenniumJulianDate(DateTime date) => CalculateJulianDate(date: date) - doubleMillenniumJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateMillenniumJulianDate(double julianDate) => julianDate - doubleMillenniumJulianDateCoefficient;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateChronologicalJulianDate()
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		//System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
		//double a = time.Delta.Hours / 24.0;
		return CalculateJulianDate() + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateChronologicalJulianDate(DateTime date)
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		return CalculateJulianDate(date: date) + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateChronologicalJulianDate(double julianDate)
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		return julianDate + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateChronologicalModifiedJulianDate()
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		//System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
		//double a = time.Delta.Hours / 24.0;
		return CalculateJulianDate() - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateChronologicalModifiedJulianDate(DateTime date)
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		return CalculateJulianDate(date: date) - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateChronologicalModifiedJulianDate(double julianDate)
	{
		TimeZone zone = TimeZone.CurrentTimeZone;
		DaylightTime time = zone.GetDaylightChanges(year: DateTime.Today.Year);
		return julianDate - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateLilianDate() => Math.Floor(CalculateJulianDate() - doubleLilianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateLilianDate(DateTime date) => Math.Floor(CalculateJulianDate(date: date) - doubleLilianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateLilianDate(double julianDate) => Math.Floor(julianDate - doubleLilianDateCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateRataDie() => Math.Floor(CalculateJulianDate() - doubleRataDieCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateRataDie(DateTime date) => Math.Floor(CalculateJulianDate(date: date) - doubleRataDieCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateRataDie(double julianDate) => Math.Floor(julianDate - doubleRataDieCoefficient);

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateMarsSolDate() => (CalculateJulianDate() - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateMarsSolDate(DateTime date) => (CalculateJulianDate(date: date) - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateMarsSolDate(double julianDate) => (julianDate - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public static double CalculateUnixTime() => (CalculateJulianDate() - doubleUnixtimeCoefficient) * intSecondsOfDay;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="date"></param>
	/// <returns></returns>
	public static double CalculateUnixTime(DateTime date) => (CalculateJulianDate(date: date) - doubleUnixtimeCoefficient) * intSecondsOfDay;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double CalculateUnixTime(double julianDate) => (julianDate - doubleUnixtimeCoefficient) * intSecondsOfDay;

	#endregion

	#region JD Converters

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static DateTime ConvertJulianDateToCivilCalendar(double julianDate)
	{
		double j = julianDate;
		double intgr = Math.Floor(d: j);
		double frac = j - intgr;
		double gregjd = 2299160.5;
		double j1;
		if (j >= gregjd)
		{
			double tmp = Math.Floor(d: (intgr - 1867216.0 - 0.25) / 36524.25);
			j1 = intgr + 1 + tmp - Math.Floor(d: 0.25 * tmp);
		}

		else
		{
			j1 = intgr;
		}

		double df = frac + 0.5;
		if (df >= 1.0)
		{
			df -= 1.0;
			++j1;
		}
		double j2 = j1 + 1524.0;
		double j3 = Math.Floor(d: 6680.0 + ((j2 - 2439870.0 - 122.1) / 365.25));
		double j4 = Math.Floor(d: j3 * 365.25);
		double j5 = Math.Floor(d: (j2 - j4) / 30.6001);
		double d = Math.Floor(d: j2 - j4 - Math.Floor(d: j5 * 30.6001));
		double m = Math.Floor(d: j5 - 1.0);
		if (m > 12)
		{
			m -= 12;
		}
		double y = Math.Floor(d: j3 - 4715.0);
		if (m > 2)
		{
			--y;
		}
		if (y <= 0)
		{
			--y;
		}
		double d1 = df * 24.0;
		double hr = Math.Floor(d: d1);
		double mn = Math.Floor(d: ((df * 24.0) - hr) * 60.0);
		double f = ((((df * 24.0) - hr) * 60.0) - mn) * 60.0;
		double sc = Math.Floor(d: f);
		f -= sc;
		if (f > 0.5)
		{
			++sc;
		}
		if (sc == 60)
		{
			sc = 0;
			++mn;
		}
		if (mn == 60)
		{
			mn = 0;
			++hr;
		}
		if (hr == 24)
		{
			hr = 0;
			++d;
		}
		/*if (y < 0)
		{
		}
		else
		{
		}*/
		return new DateTime(year: (int)y, month: (int)m, day: (int)d, hour: (int)hr, minute: (int)mn, second: (int)sc);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToModifiedJulianDate(double julianDate)
	{
		return julianDate - doubleModifiedJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianModifiedDate"></param>
	/// <returns></returns>
	public static double ConvertModifiedJulianDateToJulianDate(double julianModifiedDate)
	{
		return julianModifiedDate + doubleModifiedJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToReducedJulianDate(double julianDate)
	{
		return julianDate - doubleReducedJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToTruncatedJulianDate(double julianDate)
	{
		return julianDate - doubleTruncatedJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToDublinJulianDate(double julianDate)
	{
		return julianDate - doubleDublinJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToCnesJulianDate(double julianDate)
	{
		return julianDate - doubleCnesJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToCcsdsJulianDate(double julianDate)
	{
		return julianDate - doubleCcsdsJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToLopJulianDate(double julianDate)
	{
		return julianDate - doubleLopJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToMillenniumJulianDate(double julianDate)
	{
		return julianDate - doubleMillenniumJulianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToChronologicalJulianDate(double julianDate)
	{
		return CalculateChronologicalJulianDate(julianDate: julianDate);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToChronologicalModifiedJulianDate(double julianDate)
	{
		return CalculateChronologicalModifiedJulianDate(julianDate: julianDate);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToLilianDate(double julianDate)
	{
		return julianDate - doubleLilianDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToRataDie(double julianDate)
	{
		return julianDate - doubleRataDieCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToMarsSolDate(double julianDate)
	{
		return julianDate - doubleMarsSolDateCoefficient;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="julianDate"></param>
	/// <returns></returns>
	public static double ConvertJulianDateToUnixtime(double julianDate)
	{
		return julianDate - doubleUnixtimeCoefficient;
	}

	#endregion
}