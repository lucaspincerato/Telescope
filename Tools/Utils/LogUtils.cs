using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telescope.Tools.Utils
{
	public static class LogUtils
	{
		//public static void Log(string line) 
		//{
		//	StreamWriter vWriter = new StreamWriter(@"C:\Users\fcamargo\Desktop\teste\teste.txt", true);
		//	vWriter.WriteLine(line);
		//	vWriter.Flush();
		//	vWriter.Close();
		//}


		public static void SendPublicAPILog(string userName, string userIP, string endPointName, string requirementstatus, string productName, string [] tags)
		{
			LogEntry logentry = new LogEntry();
			logentry.AdditionalData.Add("UserName", userName);
			logentry.ProductName = productName;
			logentry.ProductCompany = "Buy4";
			logentry.SetMessage("Task " + endPointName + " from user:" + userName + " IP:" + userIP + ": " + requirementstatus);
			logentry.AddTags(tags);
			Logger.Log(logentry);
		}

		public static void SendApplicationLog(string message, string endPointName, string productName, string [] tags)
		{
			LogEntry logentry = new LogEntry();
			logentry.ProductName = productName;
			logentry.ProductCompany = "Buy4";
			logentry.SetMessage(message);
			logentry.AddTags(tags);
			Logger.Log(logentry);
		}

		public static void SendErrorLog(string message, string productName, Exception ex, string [] tags)
		{
			Dlp.Buy4.Infrastructure.Logging.ExceptionLogEntry logentry = new Dlp.Buy4.Infrastructure.Logging.ExceptionLogEntry(ex);
			logentry.ProductName = productName;
			logentry.ProductCompany = "Buy4";
			logentry.SetMessage(message);
			logentry.AddTags(tags);
			Logger.Log(logentry);
		}

		public static void Log(string productName, string message, LogSeverity severity, IDictionary<string,object> additionalData, string [] tags) 
		{
			LogEntry entry = new LogEntry();
			entry.SetAdditionalData(additionalData);
			entry.ProductName = productName;
			entry.ProductCompany = "Buy4";
			entry.SetMessage(message);
			entry.SetSeverity(severity);
			entry.AddTags(tags);
			Logger.Log(entry);
		}
	}
}
