using Movies.Application;
using Movies.Data.Data;
using Movies.Data.Repositories;

namespace Movies.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieService movieService;
        private async void Form1_Load(object sender, EventArgs e)
        {
            var db = new MoviesDbContext();
            var repository = new EFMovieRepository(db);
            movieService = new MovieService(repository);

            await fillGrid();
        }

        private async Task fillGrid()
        {
            var list = await movieService.GetAllMovies();
            dataGridViewMovies.DataSource = list.ToList();
        }

        private void buttonDirector_Click(object sender, EventArgs e)
        {
            FormDirectors formDirectors = new FormDirectors();
            formDirectors.Show();
        }

        private void buttonPlayers_Click(object sender, EventArgs e)
        {
            FormPlayers formPlayers = new FormPlayers();
            formPlayers.Show();
        }

        private async void buttonGetAllMovies_Click(object sender, EventArgs e)
        {
            await fillGrid();
        }

        private void buttonNewMovie_Click(object sender, EventArgs e)
        {
            FormMovies formMovies = new FormMovies();
            formMovies.Show();
        }
    }
}