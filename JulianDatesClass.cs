using System;
using System.Globalization;

class JulianDatesClass
{
  public const double
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

  public const int
    intSecondsOfDay = 86400;

  public static double calcJulianDate()
  {
    return DateTime.Now.ToOADate() + doubleJulianDateCoefficient;
  }

  public static double calcJulianDate(DateTime date)
  {
    return date.ToOADate() + doubleJulianDateCoefficient;
  }

  public static double calcModifiedJulianDate()
  {
    return calcJulianDate() - doubleModifiedJulianDateCoefficient;
  }

  public static double calcModifiedJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleModifiedJulianDateCoefficient;
  }

  public static double calcReducedJulianDate()
  {
    return calcJulianDate() - doubleReducedJulianDateCoefficient;
  }

  public static double calcReducedJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleReducedJulianDateCoefficient;
  }

  public static double calcTruncatedJulianDate()
  {
    return Math.Floor(calcJulianDate() - doubleTruncatedJulianDateCoefficient);
  }

  public static double calcTruncatedJulianDate(DateTime date)
  {
    return Math.Floor(calcJulianDate(date) - doubleTruncatedJulianDateCoefficient);
  }

  public static double calcDublinJulianDate()
  {
    return calcJulianDate() - doubleDublinJulianDateCoefficient;
  }

  public static double calcDublinJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleDublinJulianDateCoefficient;
  }

  public static double calcCnesJulianDate()
  {
    return calcJulianDate() - doubleCnesJulianDateCoefficient;
  }

  public static double calcCnesJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleCnesJulianDateCoefficient;
  }

  public static double calcCcsdsJulianDate()
  {
    return calcJulianDate() - doubleCcsdsJulianDateCoefficient;
  }

  public static double calcCcsdsJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleCcsdsJulianDateCoefficient;
  }

  public static double calcLopJulianDate()
  {
    return calcJulianDate() - doubleLopJulianDateCoefficient;
  }

  public static double calcLopJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleLopJulianDateCoefficient;
  }

  public static double calcMillenniumJulianDate()
  {
    return calcJulianDate() - doubleMillenniumJulianDateCoefficient;
  }

  public static double calcMillenniumJulianDate(DateTime date)
  {
    return calcJulianDate(date) - doubleMillenniumJulianDateCoefficient;
  }

  public static double calcChronologicalJulianDate()
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    //System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
    //double a = time.Delta.Hours / 24.0;
    return calcJulianDate() + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double calcChronologicalJulianDate(DateTime date)
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    return calcJulianDate(date) + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double calcChronologicalModifiedJulianDate()
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    //System.Windows.Forms.MessageBox.Show((time.Delta.Hours * (24 / 100)).ToString());
    //double a = time.Delta.Hours / 24.0;
    return calcJulianDate() - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double calcChronologicalModifiedJulianDate(DateTime date)
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DaylightTime time = zone.GetDaylightChanges(DateTime.Today.Year);
    return calcJulianDate(date) - doubleModifiedJulianDateCoefficient + 0.5 + (time.Delta.Hours / 24.0);
  }

  public static double calcLilianDate()
  {
    return Math.Floor(calcJulianDate() - doubleLilianDateCoefficient);
  }

  public static double calcLilianDate(DateTime date)
  {
    return Math.Floor(calcJulianDate(date) - doubleLilianDateCoefficient);
  }

  public static double calcRataDie()
  {
    return Math.Floor(calcJulianDate() - doubleRataDieCoefficient);
  }

  public static double calcRataDie(DateTime date)
  {
    return Math.Floor(calcJulianDate(date) - doubleRataDieCoefficient);
  }

  public static double calcMarsSolDate()
  {
    return (calcJulianDate() - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;
  }

  public static double calcMarsSolDate(DateTime date)
  {
    return (calcJulianDate(date) - doubleMarsSolDateCoefficient) / doubleRatioRotationAxisEarthMars;
  }

  public static double calcUnixtime()
  {
    return (calcJulianDate() - doubleUnixtimeCoefficient) * intSecondsOfDay;
  }

  public static double calcUnixtimeDate(DateTime date)
  {
    return (calcJulianDate(date) - doubleUnixtimeCoefficient) * intSecondsOfDay;
  }
}
