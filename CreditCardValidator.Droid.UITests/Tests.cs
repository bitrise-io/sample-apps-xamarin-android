using System;
using System.IO;
using System.Linq;
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
			string apkPath = Environment.GetEnvironmentVariable ("ANDROID_APK_PATH");
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

