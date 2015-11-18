using System;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Utils;

namespace CreditCardValidator.Droid.UITests
{
	public class WaitTimes : IWaitTimes
	{
		public TimeSpan GestureWaitTimeout
		{
			get { return TimeSpan.FromMinutes(1); }
		}
		public TimeSpan WaitForTimeout
		{
			get { return TimeSpan.FromMinutes(1); }
		}
	}

	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void BeforeEachTest()
		{
			string apkPath = "";
			apkPath = Environment.GetEnvironmentVariable ("ANDROID_APK_PATH");
			if (apkPath == null || apkPath == "") {
				string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
				string dir = new FileInfo(currentFile).Directory.Parent.Parent.Parent.FullName;
				apkPath = Path.Combine(dir, "com.xamarin.example.creditcardvalidator-Signed.apk");
			}
			string emulatorSerial = Environment.GetEnvironmentVariable ("ANDROID_EMULATOR_SERIAL");

			ConfigureApp.Android
				.ApkFile(apkPath)
				.DeviceSerial(emulatorSerial)
				.WaitTimes(new WaitTimes())
				.StartApp();
		}

		[Test]
		public void AssertTrue()
		{
			Assert.True (true);
		}
	}
}

