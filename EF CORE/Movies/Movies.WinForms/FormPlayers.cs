using Movies.Application;
using Movies.Application.DTOs.Requests;
using Movies.Data.Data;
using Movies.Data.Repositories;

namespace Movies.WinForms
{
    public partial class FormPlayers : Form
    {
        public FormPlayers()
        {
            InitializeComponent();
            MoviesDbContext context = new MoviesDbContext();
            EFPlayerRepository eFPlayerRepository = new EFPlayerRepository(context);
            playerService = new PlayerService(eFPlayerRepository);
        }

        PlayerService playerService = null;
        private async void FormPlayers_Load(object sender, EventArgs e)
        {

            await fillPlayers();
        }

        private async Task fillPlayers()
        {
            var players = await playerService.GetPlayerLists();
            dataGridViewPlayers.DataSource = players.ToList();
            //var anotherPlayers = playerService.GetPlayerLists()
            //                                  .GetAwaiter()
            //                                  .GetResult();



        }

        private async void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            var dto = new CreateNewPlayerRequest
            {
                Info = textBoxPlayerInfo.Text,
                LastName = textBoxPlayerLastName.Text,
                Name = textBoxPlayerName.Text
            };
            await playerService.CreateNewPlayer(dto);

            await fillPlayers();
            textBoxPlayerName.Clear();
            textBoxPlayerInfo.Clear();
            textBoxPlayerLastName.Clear();
        }
    }
}
