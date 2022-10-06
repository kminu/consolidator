using CTC.Library.Models;

namespace CTC.Library
{
    public interface ICourseTimeCalculator
    {
        double TotalHours { get; }
        List<string> PreProcessedData { get; }

        void ProcessText(string text, DelimiterModel delimiter);
    }
}