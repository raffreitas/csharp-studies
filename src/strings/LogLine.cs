namespace Strings
{
    static class LogLine
    {
        public static string Message(string logLine)
        {
            string message = logLine.Split(":")[1].Trim();
            return message;
        }

        public static string LogLevel(string logLine)
        {
            string level = logLine.Split("]:")[0].Replace("[", "").Trim();
            return level;
        }

        public static string Reformat(string logLine)
        {
            string message = logLine.Split(":")[1].Trim();
            string level = logLine.Split("]:")[0].Replace("[", "").Trim();
            return $"{message} ({level})";
        }
    }
}