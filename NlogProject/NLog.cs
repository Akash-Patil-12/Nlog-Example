using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NlogProject
{
    class NLog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Fine-grained statements concerning program state,typically used
        /// </summary>
        /// <param name="message"></param>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogInfo(string message)
        {
            logger.Debug(message);
        }
        /// <summary>
        /// Statements that describe non-fatal errors in the application
        /// this level is used quite often for logging handle
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            logger.Error(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
