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
				.StartApp();
		}

		[Test]
		public void True()
		{
			Assert.True (true);
		}
	}
}

