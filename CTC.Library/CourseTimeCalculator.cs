using System.Reflection.Metadata.Ecma335;
using CTC.Library.Models;

namespace CTC.Library;

public class CourseTimeCalculator : ICourseTimeCalculator
{
    public double TotalHours { get; private set; }
    public List<string> PreProcessedData { get; private set; } = new List<string>();

    public void ProcessText(string text, DelimiterModel delimiter )
    {
        TotalHours = 0;
        PreProcessedData = new List<string>();

        
        var lines = text.Split("\n").ToList();

        foreach (var line in lines)
        {
            int pFrom = line.IndexOf(delimiter.Start);
            int pTo = -1;
            if (pFrom >= 0)
            {
                pTo = (line.Substring(pFrom + 1).IndexOf(delimiter.End) + (pFrom + 1));
            }

            if (pFrom >= 0 && pTo >= 0)
            {
                //string result = line.Substring(pFrom + 1, pTo - (pFrom + 1)).Replace(delimiter.Middle, ".");
                string result = line.Substring(pFrom + 1, pTo - (pFrom + 1)).Replace(delimiter.Middle, ".");
                PreProcessedData.Add(result);
                var isValidTime = double.TryParse(result, out double sectionHour);

                TotalHours += sectionHour;
            }
        }
    }
}