using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Hangman_4444
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public TextView txt_player_Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Button btn_save = FindViewById<Button>(Resource.Id.btn_save);
            btn_save.Click += btn_save_Click;
            txt_player_Name = FindViewById<EditText>(Resource.Id.txt_player_Name);


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_player_Name.Text.Length > 0)
            {
                
                var con = new ConnectionClass();
                
                con.InsertNewPlayer(txt_player_Name.Text  , 0);


                Toast.MakeText(this, "Record Save", ToastLength.Short).Show();
                StartActivity(typeof(Play_Game));

            }
          
            else
            {


                Toast.MakeText(this, "Please Fill Name", ToastLength.Short).Show();
            }

        }
    }
}
