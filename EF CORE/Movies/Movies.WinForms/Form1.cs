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

        private async void buttonGetMovies_Click(object sender, EventArgs e)
        {
            MoviesDbContext moviesDbContext = new MoviesDbContext();
            EFMovieRepository eFMovieRepository = new EFMovieRepository(moviesDbContext);
            MovieService movieService = new MovieService(eFMovieRepository);

            var responses = await movieService.GetAllMovies();
            foreach (var item in responses)
            {
                listBoxMovies.Items.Add($"{item.Name} {item?.Duration} dakika");
            }
        }
    }
}