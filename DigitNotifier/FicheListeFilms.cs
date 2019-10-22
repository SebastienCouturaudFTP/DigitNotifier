using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestNotify.Repositories;

namespace TestNotify
{
    public partial class FicheListeFilms : Form
    {
        IEnumerable<FilmPreVBE> Films;
        DateTime LastUpdate = DateTime.Now;

        public FicheListeFilms()
        {
            InitializeComponent();
            dataGridFilm.DataSource = null;
            GetFilms();

            if (FilmsCount() != 0)
            {
                notifyIconDigit.Visible = true;
                notifyIconDigit.Text = "Nouveaux films Digit";
            }
        }
        public void HideIconNotif()
        {
            notifyIconDigit.Visible = false;
            notifyIconDigit.Text = "";
            notifyIconDigit.BalloonTipText = "";
            notifyIconDigit.BalloonTipTitle = "Digit";
        }

        private void GetFilms()
        {
            IEnumerable<FilmPreVBE> FilmsCurrent;
            ListeFilmsDigitRepository repo = new ListeFilmsDigitRepository();

            FilmsCurrent = repo.GetFilmsDigitList();
            
            if (FilmsCurrent != null)
            {
                foreach (FilmPreVBE Film in FilmsCurrent)
                {
                    Film.Nouveau = true;

                    if (Films != null)
                    {
                        foreach (FilmPreVBE oldFilm in Films)
                        {
                            if (Film.TID == oldFilm.TID)
                            {
                                Film.Nouveau = false;
                            }
                        }
                    }
                }

                Films = FilmsCurrent;
                dataGridFilm.DataSource = Films;
            }
        }

        private Boolean NewFilms()
        {
            foreach (FilmPreVBE Film in Films)
                if (Film.Nouveau == true)
                    return true;

            return false;
        }

        private string FilmsList(Boolean NewFilms)
        {
            string list = "";

            foreach (FilmPreVBE Film in Films)
            {
                if ((Film.Nouveau == true) || (NewFilms == false))
                {
                    list = list + Film.TID.ToString() + " " + Film.GetShortTitle() + "\n";
                }
            }
            return list;
        }

        private int FilmsCount()
        {
            int count = 0;

            foreach (FilmPreVBE Film in Films)
                count++;

            return count;
        }

        private void ShowIconNotif()
        {
            notifyIconDigit.Visible = true;
            notifyIconDigit.Text = "Nouveaux films Digit";
            notifyIconDigit.BalloonTipText = FilmsList(true);
            notifyIconDigit.BalloonTipTitle = "Nouveaux films Digit";
            notifyIconDigit.ShowBalloonTip(10000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetFilms();
            if (NewFilms())
                ShowIconNotif();
            else
                if (FilmsCount() == 0)
                    HideIconNotif();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
