namespace B5_Practice.common
{
    internal class Common
    {
        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "MM/dd/yyyy" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}