using System;
using System.Diagnostics;

namespace CodeKata
{
    //https://docs.microsoft.com/en-us/visualstudio/debugger/using-the-debuggerdisplay-attribute?view=vs-2019
    [DebuggerDisplay("Driver = {Driver}, StartTime = {StartTime}, StopTime = {StopTime}, Miles = {Miles}, Elapsed = {Elapsed}, MilesPerHour = {MilesPerHour}")]
    public class Trip
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get
    {
        public string Driver { get; }
        public string StartTime { get; }
        public string StopTime { get; }
        public decimal Miles { get; }
        public decimal MilesPerHour { get; }
        public TimeSpan Elapsed { get; }

        public Trip(string driver, string startTime, string stopTime, decimal miles)
        {
            Driver = driver;
            StartTime = startTime;
            StopTime = stopTime;
            Miles = miles;
            Elapsed = TimeSpan.Parse(StopTime) - TimeSpan.Parse(StartTime);
            MilesPerHour = Miles / (decimal)Elapsed.TotalHours;
        }

        public string ToLogString()
        {
            return $"Driver = {Driver}, StartTime = {StartTime}, StopTime = {StopTime}, Miles = {Miles}, Elapsed = {Elapsed}, MilesPerHour = {MilesPerHour}";
        }
    }
}
