

namespace AppRpgEtec.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
    LocalizacaoViewModel viewModel;

    public LocalizacaoView()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
		//viewModel.InicializarMapa();
		viewModel.ExibirUsuariosNoMapa();

		BindingContext = viewModel;
	}
}