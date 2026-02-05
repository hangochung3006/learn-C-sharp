static class LogLine
{
    public static string Message(string logLine)
    {
        //throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        int colonIndex = logLine.IndexOf(":");
        return logLine.Substring(colonIndex+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        //throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        int colonIndex = logLine.IndexOf(":");
        return logLine = logLine.Substring(0,colonIndex).Trim('[', ']').ToLower();
    }

    public static string Reformat(string logLine)
    {
        //throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        int colonIndex = logLine.IndexOf(":");
        string first = logLine.Substring(colonIndex+1).Trim();
        string last = logLine.Substring(0,colonIndex).Trim('[', ']').ToLower();
        return $"{first} ({last})";
    }
}
