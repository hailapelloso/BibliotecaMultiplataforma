using TrabalhoFinalFIB.ViewModels;
using Xamarin.Forms;

namespace TrabalhoFinalFIB.Views
{
    public partial class NewAuthorPage : ContentPage
    {
        public NewAuthorPage()
        {
            InitializeComponent();
        }

        // Executado quando a requisição de consulta dos autores falha.
        void Handle_RequestFailed(object sender, Models.ErrorResponse e)
        {
            // Mostra alerta.
            DisplayAlert("Erro", e.Message, "ok");
        }

        async void Handle_AuthorAdded(object sender, Models.Author author)
        {
            await Navigation.PopAsync(true);
        }
    }
}
