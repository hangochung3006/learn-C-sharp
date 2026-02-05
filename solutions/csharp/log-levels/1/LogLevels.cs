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
        return logLine.Substring(colonIndex+1).Trim() + " (" + logLine.Substring(0,colonIndex).Trim('[', ']').ToLower() + ")";
    }
}
