using Android.App;
using Android.Media;
using Android.OS;
using Android.Widget;

namespace CotecCelebrities.Droid
{
    [Activity(Label = "CotecCelebrities", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        MediaPlayer _player;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);

            //button.Click += delegate { button.Text = $"{count++} clicks!"; };

            Button btnJose1 = FindViewById<Button>(Resource.Id.btnJose1);
            btnJose1.Click += BtnJose1_Click;

            Button btnJose2 = FindViewById<Button>(Resource.Id.btnJose2);
            btnJose2.Click += BtnJose2_Click;

            Button btnJose3 = FindViewById<Button>(Resource.Id.btnJose3);
            btnJose3.Click += BtnJose3_Click;

            Button btnHector1 = FindViewById<Button>(Resource.Id.btnHector1);
            btnHector1.Click += BtnHector1_Click;

            Button btnHector2 = FindViewById<Button>(Resource.Id.btnHector2);
            btnHector2.Click += BtnHector2_Click;

            Button btnHector3 = FindViewById<Button>(Resource.Id.btnHector3);
            btnHector3.Click += BtnHector3_Click;
        }

        #region José
        private void BtnJose1_Click(object sender, System.EventArgs e)
        {
            _player = MediaPlayer.Create(this, Resource.Raw.uiuiuiui);
            _player.Start();
        }

        private void BtnJose2_Click(object sender, System.EventArgs e)
        {
            _player = MediaPlayer.Create(this, Resource.Raw.jaja);
            _player.Start();
        }

        private void BtnJose3_Click(object sender, System.EventArgs e)
        {
            _player = MediaPlayer.Create(this, Resource.Raw.cade_meu_fi);
            _player.Start();
        }
        #endregion

        #region Hector
        private void BtnHector1_Click(object sender, System.EventArgs e)
        {
            _player = _player = MediaPlayer.Create(this, Resource.Raw.chupa_manga);
            _player.Start();
        }

        private void BtnHector2_Click(object sender, System.EventArgs e)
        {
            _player = _player = MediaPlayer.Create(this, Resource.Raw.risada);
            _player.Start();
        }

        private void BtnHector3_Click(object sender, System.EventArgs e)
        {
            _player = _player = MediaPlayer.Create(this, Resource.Raw.taca_o_pal);
            _player.Start();
        }
        #endregion
    }
}

