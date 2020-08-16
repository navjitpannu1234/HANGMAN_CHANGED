using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Hangman_4444.Resources;
using SQLite;

namespace Hangman_4444
{
    [Activity(Label = "view_score")]
    public class view_score : Activity
    {
        List<Playerscores > myList;
        public ConnectionClass  myConnectionClass;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.view_score );

            myConnectionClass = new ConnectionClass();
            myList = myConnectionClass.ViewAll();

            Button btn_Player = FindViewById<Button>
                (Resource.Id.btn_Player);

            btn_Player.Click += btn_Player_Click;

            // Display the player names and high scores 
            ListView Lv_HighScore = FindViewById<ListView>(Resource.Id.Lv_HighScore);
            Lv_HighScore.Adapter = new DataAdpter (this, myList);
        }

        private void btn_Player_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}