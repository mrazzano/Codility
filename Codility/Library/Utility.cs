using System;
using System.Text;

namespace Codility.Library
{
    public static class Utility
    {
        private const int LineLength = 60;

        public static string GetProgramHeader(string header, DateTime date)
        {
            var separator = new string('*', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendFormat("* {0}", header);
            sb.Append(Environment.NewLine);
            sb.AppendLine("*");
            sb.AppendFormat("* {0}", date.ToString("MMMM dd, yyyy"));
            sb.Append(Environment.NewLine);
            sb.AppendLine(separator);
            sb.AppendLine();

            return sb.ToString();
        }

        public static string GetLessonHeader(string header)
        {
            var separator = new string('-', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine(header);
            sb.Append(separator);

            return sb.ToString();
        }

        public static string GetPrintArray(int[] array)
        {
            if (array == null || array.Length == 0)
                return ("[]");

            var sb = new StringBuilder();
            sb.Append("[");

            foreach (var item in array)
            {
                sb.AppendFormat("{0} ", item);
            }

            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");

            return sb.ToString();
        }
    }
}