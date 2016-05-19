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
	// Android emulators are slow, give some time for test.
	public class WaitTimes : IWaitTimes
	{
		public TimeSpan GestureWaitTimeout
		{
			get { return TimeSpan.FromMinutes(5); }
		}
		public TimeSpan WaitForTimeout
		{
			get { return TimeSpan.FromMinutes(5); }
		}
	}

	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void BeforeEachTest()
		{
			string apkPath = Environment.GetEnvironmentVariable ("ANDROID_APK_PATH");

			if (apkPath != null && apkPath != "") {
				// In case of Bitrise step: steps-xamarin-uitest
				ConfigureApp
					.Android
					.ApkFile (apkPath)
					.WaitTimes(new WaitTimes())
					.StartApp ();
			} else {
				// In case of Bitrise step: steps-xamarin-testcloud
				ConfigureApp
					.Android
					.WaitTimes(new WaitTimes())
					.StartApp ();
			}
		}

		[Test]
		public void AssertTrue()
		{
			Assert.True (true);
		}
	}
}

