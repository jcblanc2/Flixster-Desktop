using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace devoir2
{
    public partial class frmFilms : Form
    {
        public Film currentFilm;
        int index = 0;
        List<Film> films = SplashScreen.films;
        public delegate void delPassData(Film film);
        public SolidBrush color = new SolidBrush(Color.Red);
        public frmFilms()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method close the application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFilms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
            display(index);
        }

        
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            index--;
            display(index);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            index++;
            display(index);
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFilmDetail detailForm = new frmFilmDetail();

            delPassData del = new delPassData(detailForm.getData);
            del(this.currentFilm);

            detailForm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Method to bind data with the view 
        /// </summary>
        /// <param name="index"></param>
        private void display(int index)
        {

            if (index == 0)
            {
                btnPrecedent.Enabled = false;
            }
            else if (index == films.Count -1)
            {
                btnSuivant.Enabled = false;
            }
            else
            {
                btnSuivant.Enabled = true;
                btnPrecedent.Enabled = true;
            }
            currentFilm = films.ElementAt(index);

            lblTitle.Text = currentFilm.title;
            lblOverView.Text = currentFilm.overview;

            if (SplashScreen.check)
            {
                picBox.LoadAsync("https://image.tmdb.org/t/p/w342" + currentFilm.backdrop_path);
                color.Color = Color.Blue;

            }
            else
            {
                picBox.Image = Utilities.ByteToImage(currentFilm.image);
                color.Color = Color.Red;
            }

        }

        private void frmFilms_Paint_1(object sender, PaintEventArgs e)
        {
            int cellSize = 30, x1 = 681, y1 = 39;

            if (SplashScreen.check)
            {
                color.Color = Color.Blue;
            }
            else
            {
                color.Color = Color.Red;
            }

            Graphics formGraphics = e.Graphics;

            formGraphics.FillEllipse(color, new Rectangle(x1, y1, cellSize, cellSize));

        }
    }
}
