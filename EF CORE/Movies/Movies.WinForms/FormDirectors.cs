using Movies.Application;
using Movies.Application.DTOs.Requests;
using Movies.Data.Data;
using Movies.Data.Repositories;

namespace Movies.WinForms
{
    public partial class FormDirectors : Form
    {
        public FormDirectors()
        {
            InitializeComponent();
        }


        DirectorService directorService = null;
        private async void FormDirectors_Load(object sender, EventArgs e)
        {
            var context = new MoviesDbContext();
            var repo = new EFDirectorRepository(context);
            directorService = new DirectorService(repo);

            await fillGrid();

        }

        private async Task fillGrid()
        {
            var directors = await directorService.GetDirectorsAsync();
            dataGridView1.DataSource = directors.ToList();
        }

        private async void buttonAddDirector_Click(object sender, EventArgs e)
        {
            var request = new CreateDirectorRequest
            {
                Name = textBoxDirectorName.Text,
                LastName = textBoxDirectorLastName.Text,
                Info = textBoxDirectorInfo.Text
            };

            var directorId = await directorService.CreateNewDirectorAsync(request);
            var message = directorId != 0 ? "Ok" : "Failed";
            MessageBox.Show(message);
            await fillGrid();
        }

        int selectedDirectorId = 0;
        private async void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDirectorId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var director = await directorService.GetDirectorAsync(selectedDirectorId);
            textBoxDirectorInfo.Text = director.Info;
            textBoxDirectorName.Text = director.Name;
            textBoxDirectorLastName.Text = director.LastName;

            buttonUpdate.Enabled = selectedDirectorId != 0;

        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            var request = new UpdateDirectorRequest
            {
                Id = selectedDirectorId,
                Info = textBoxDirectorInfo.Text,
                LastName = textBoxDirectorLastName.Text,
                Name = textBoxDirectorName.Text

            };
            await directorService.UpdateDirectorAsync(request);
            await fillGrid();


        }
    }
}
