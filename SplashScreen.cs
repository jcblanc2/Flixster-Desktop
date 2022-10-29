using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

/// <summary>
/// Name: John Clayton Blanc
/// Date: 10/14/2022
/// Course: C#
/// </summary>
namespace devoir2
{
    public partial class SplashScreen : Form
    {
        public static bool check = false;
        public static List<Film> films;
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Timer to update the progressBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            pgBar.Value += 1;

            if(pgBar.Value == 100)
            {
                checkToGetData();
                timer1.Enabled = false;

                frmFilms frmFilms = new frmFilms();
                frmFilms.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Thread to get data from TMDB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
           Thread th = new Thread(checkToGetData);
            th.Start();
            
        }

        /// <summary>
        /// Check if the user is connected to internet to load data
        /// </summary>
        private void checkToGetData()
        {
            if (Utilities.IsConnectedToInternet())
            {
                films = Utilities.getMovieDbList();
                foreach (Film film in films)
                {
                    check = true;
                    MovieDatabase.SaveMovieToDatabase(film);
                }
            }
            else
            {
                films = MovieDatabase.LoadMoviesFromDB();
            }
        }


       
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
