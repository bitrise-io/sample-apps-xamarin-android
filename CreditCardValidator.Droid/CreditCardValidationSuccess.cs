using Android.App;
using Android.OS;
using Android;

namespace CreditCardValidator.Droid
{
	[Activity(Label = "@string/activity_success", Theme = "@android:style/Theme.Holo.Light")]
    public class CreditCardValidationSuccess : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.CreditCardValidationSuccess);
        }
    }
}
