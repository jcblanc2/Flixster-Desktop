using System;
using System.Drawing;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;

namespace devoir2
{
    public partial class frmFilmDetail : Form
    {
        Film currentFilm;
        public const String VIDEO_URL = "https://api.themoviedb.org/3/movie/{0}/videos?api_key=a07e22bc18f5cb106bfe4cc1f83ad8ed";
        public SolidBrush color = new SolidBrush(Color.Red);

        public frmFilmDetail()
        {
            InitializeComponent();
        }


        private String getYoutubeKey()
        {

            String reponse = "";
            String youtubeKey = "";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    reponse = webClient.DownloadString(String.Format(VIDEO_URL, currentFilm.id));
                }

                using (JsonDocument document = JsonDocument.Parse(reponse))
                {
                    JsonElement root = document.RootElement;
                    JsonElement resultsList = root.GetProperty("results");

                    int i = 0;
                    while (true)
                    {
                        String type = resultsList[i].GetProperty("type").ToString();
                        youtubeKey = resultsList[i].GetProperty("key").ToString();
                        if (type.Equals("Clip"))
                        {
                            break;
                        }
                        i++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return youtubeKey;
        }

        

        private void frmFilmDetail_Load_1(object sender, EventArgs e)
        {


            lblTitleDetail.Text = currentFilm.title;
            lblOverViewDetail.Text = currentFilm.overview;
            lbtDateDetail.Text = currentFilm.release_date;
            lblOriginal_language.Text = currentFilm.original_language;
            lblPopularity.Text = currentFilm.popularity.ToString();
            lbl_vote_count.Text = currentFilm.vote_count.ToString();
            lbl_vote_average.Text = currentFilm.vote_average.ToString();



            if (SplashScreen.check)
            {
                color.Color = Color.Blue;
                displayVideo(getYoutubeKey());
            }
            else
            {
                color.Color = Color.Red;
                displayVideo("");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void getData(Film  film)
        {
            currentFilm = film;
        }

        private void frmFilmDetail_Paint(object sender, PaintEventArgs e)
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


        private void displayVideo(String id)
        {
            webBrowser1.DocumentText = String.Format("<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>", id);
        }
    }
}
