using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] message = logLine.Split(":");
        return message[1].TrimStart().Trim('\t','\r','\n').TrimEnd();
    }

    public static string LogLevel(string logLine)
    {
        int inicioPalavra = logLine.IndexOf('[') + 1;
        int fimPalavra = logLine.IndexOf(']')-1;
        return logLine.Substring(inicioPalavra, fimPalavra).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = $"{Message(logLine)} ({LogLevel(logLine)})";
        return message;
    }
}
