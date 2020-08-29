using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using NLog;

namespace BookStore_API.Services
{
    public class LoggerService : ILoggerService
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        /// <inheritdoc />
        public void LogInfo(string message)
        {
            Logger.Info(message);
        }

        /// <inheritdoc />
        public void LogWarn(string message)
        {
            Logger.Warn(message);
        }

        /// <inheritdoc />
        public void LogDebug(string message)
        {
            Logger.Debug(message);
        }

        /// <inheritdoc />
        public void LogError(string message)
        {
            Logger.Error(message);
        }
    }
}
