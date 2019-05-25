using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZWaveLib
{
    /// <summary>
    /// Shim the libraries' logging functions to ILogger
    /// </summary>
    public static class ILoggerExtensions
    {
        public static void Info(this ILogger logger, String message)
        {
            logger.LogInformation(message);
        }

        public static void Info(this ILogger logger, String message, params object[] args)
        {
            logger.LogInformation(String.Format(message, args));
        }

        public static void Debug(this ILogger logger, Object message)
        {
            Debug(logger, message?.ToString());
        }

        public static void Debug(this ILogger logger, String message)
        {
            logger.LogDebug(message);
        }

        public static void Debug(this ILogger logger, String message, params object[] args)
        {
            logger.LogDebug(String.Format(message, args));
        }

        public static void Warn(this ILogger logger, String message)
        {
            logger.LogWarning(message);
        }

        public static void Warn(this ILogger logger, String message, params object[] args)
        {
            logger.LogWarning(String.Format(message, args));
        }

        public static void Trace(this ILogger logger, String message)
        {
            logger.LogTrace(message);
        }

        public static void Trace(this ILogger logger, String message, params object[] args)
        {
            logger.LogTrace(String.Format(message, args));
        }

        public static void Trace(this ILogger logger, Object message)
        {
            Trace(logger, message?.ToString());
        }

        public static void Error(this ILogger logger, String message)
        {
            logger.LogError(message);
        }

        public static void Error(this ILogger logger, String message, params object[] args)
        {
            logger.LogError(String.Format(message, args));
        }

        public static void Error(this ILogger logger, Exception ex)
        {
            logger.LogError(ex, $"{ex.GetType().Name}: {ex.Message}");
        }

        public static void Error(this ILogger logger, Object message)
        {
            Error(logger, message?.ToString());
        }
    }
}
