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
					.StartApp ();
			} else {
				// In case of Bitrise step: steps-xamarin-testcloud
				ConfigureApp
					.Android
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

