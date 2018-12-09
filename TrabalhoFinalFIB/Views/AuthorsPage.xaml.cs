using TrabalhoFinalFIB.ViewModels;
using Xamarin.Forms;

namespace TrabalhoFinalFIB.Views
{
    public partial class AuthorsPage : ContentPage
    {
        public AuthorsPage()
        {
            InitializeComponent();
        }

        // Executado toda vez que a tela for exibida.
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Pega o view model pelo cast do BindingContext e executa o GetCommand.
            // Isso deve popular a lista de autores inicialmente.
            (BindingContext as AuthorsViewModel).GetCommand.Execute(null);
        }

        // Executado quando a requisição de consulta dos autores falha.
        void Handle_RequestFailed(object sender, Models.ErrorResponse e)
        {
            // Mostra alerta.
            DisplayAlert("Erro", e.Message, "ok");
        }

        private async void AddAuthor_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewAuthorPage());
        }
    }
}
