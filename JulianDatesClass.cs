using System;

class JulianDatesClass
{
  public static double calcJulianDate()
  {
    return DateTime.Now.ToOADate() + 2415018.5;
  }

  public static double calcJulianDate(DateTime date)
  {
    return date.ToOADate() + 2415018.5;
  }

  public static double calcModifiedJulianDate()
  {
    return calcJulianDate() - 2400000.5;
  }

  public static double calcModifiedJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2400000.5;
  }

  public static double calcReducedJulianDate()
  {
    return calcJulianDate() - 2400000;
  }

  public static double calcReducedJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2400000;
  }

  public static double calcTruncatedJulianDate()
  {
    return Math.Floor(calcJulianDate() - 2440000.5);
  }

  public static double calcTruncatedJulianDate(DateTime date)
  {
    return Math.Floor(calcJulianDate(date) - 2440000.5);
  }

  public static double calcDublinJulianDate()
  {
    return calcJulianDate() - 2415020;
  }

  public static double calcDublinJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2415020;
  }

  public static double calcCnesJulianDate()
  {
    return calcJulianDate() - 2433282.5;
  }

  public static double calcCnesJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2433282.5;
  }

  public static double calcCcsdsJulianDate()
  {
    return calcJulianDate() - 2436204.5;
  }

  public static double calcCcsdsJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2436204.5;
  }

  public static double calcLopJulianDate()
  {
    return calcJulianDate() - 2448622.5;
  }

  public static double calcLopJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2448622.5;
  }

  public static double calcMilleniumJulianDate()
  {
    return calcJulianDate() - 2451544.5;
  }

  public static double calcMilleniumJulianDate(DateTime date)
  {
    return calcJulianDate(date) - 2451544.5;
  }
}

