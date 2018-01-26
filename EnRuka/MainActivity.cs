using Android.App;
using Android.Widget;
using Android.OS;

namespace EnRuka
{
    [Activity(Label = "EnRuka", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            spinner.Prompt = "Choose your number";
            spinner.ItemSelected += new System.EventHandler<AdapterView.ItemSelectedEventArgs>(spinner.ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.Counter, Android.Resource.Layout.SimpleSpinnerItem);


            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var spinner = sender as Spinner;
            Toast.MakeText(this, "your choose: " + spinner.GetItemAtPosition(e.Position), ToastLength.Short).Show();

        }
    }
}

