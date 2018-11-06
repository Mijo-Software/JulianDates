using System;
using System.Globalization;

class JulianDatesClass
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

  private const int
    intSecondsOfDay = 86400;

	public static double CalcJulianDate() => DateTime.Now.ToOADate() + doubleJulianDateCoefficient;

	public static double CalcJulianDate(DateTime date) => date.ToOADate() + doubleJulianDateCoefficient;

	public static double CalcModifiedJulianDate() => CalcJulianDate() - doubleModifiedJulianDateCoefficient;

	public static double CalcModifiedJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleModifiedJulianDateCoefficient;

	public static double CalcReducedJulianDate() => CalcJulianDate() - doubleReducedJulianDateCoefficient;

	public static double CalcReducedJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleReducedJulianDateCoefficient;

	public static double CalcTruncatedJulianDate() => Math.Floor(CalcJulianDate() - doubleTruncatedJulianDateCoefficient);

	public static double CalcTruncatedJulianDate(DateTime date) => Math.Floor(CalcJulianDate(date: date) - doubleTruncatedJulianDateCoefficient);

	public static double CalcDublinJulianDate() => CalcJulianDate() - doubleDublinJulianDateCoefficient;

	public static double CalcDublinJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleDublinJulianDateCoefficient;

	public static double CalcCnesJulianDate() => CalcJulianDate() - doubleCnesJulianDateCoefficient;

	public static double CalcCnesJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleCnesJulianDateCoefficient;

	public static double CalcCcsdsJulianDate() => CalcJulianDate() - doubleCcsdsJulianDateCoefficient;

	public static double CalcCcsdsJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleCcsdsJulianDateCoefficient;

	public static double CalcLopJulianDate() => CalcJulianDate() - doubleLopJulianDateCoefficient;

	public static double CalcLopJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleLopJulianDateCoefficient;

	public static double CalcMillenniumJulianDate() => CalcJulianDate() - doubleMillenniumJulianDateCoefficient;

	public static double CalcMillenniumJulianDate(DateTime date) => CalcJulianDate(date: date) - doubleMillenniumJulianDateCoefficient;

	public static double CalcChronologicalJulianDate()
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    //System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
    //double a = time.Delta.Hours / 24.0;
    return CalcJulianDate() + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double CalcChronologicalJulianDate(DateTime date)
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    return CalcJulianDate(date: date) + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double calcChronologicalModifiedJulianDate()
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    //System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
    //double a = time.Delta.Hours / 24.0;
    return CalcJulianDate() - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double CalcChronologicalModifiedJulianDate(DateTime date)
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    return CalcJulianDate(date: date) - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
  }

	public static double CalcLilianDate() => Math.Floor(CalcJulianDate() - doubleLilianDateCoefficient);

	public static double CalcLilianDate(DateTime date) => Math.Floor(CalcJulianDate(date: date) - doubleLilianDateCoefficient);

	public static double CalcRataDie() => Math.Floor(CalcJulianDate() - doubleRataDieCoefficient);

	public static double CalcRataDie(DateTime date) => Math.Floor(CalcJulianDate(date: date) - doubleRataDieCoefficient);

	public static double CalcMarsSolDate() => (CalcJulianDate() - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

	public static double CalcMarsSolDate(DateTime date) => (CalcJulianDate(date: date) - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;

	public static double CalcUnixtime() => (CalcJulianDate() - doubleUnixtimeCoefficient) * intSecondsOfDay;

	public static double CalcUnixtime(DateTime date) => (CalcJulianDate(date: date) - doubleUnixtimeCoefficient) * intSecondsOfDay;
}