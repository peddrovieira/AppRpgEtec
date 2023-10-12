using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class LoginView : ContentPage
{
    UsuarioViewModel usuarioViewModel;

    public LoginView()
    {
        InitializeComponent();
        usuarioViewModel = new UsuarioViewModel();
        BindingContext = usuarioViewModel;
    }

    private List<Color> randomColors = new List<Color>
        {
            Color.FromHex("#7AE3EB"), 
            Color.FromHex("#7DB8F5"), 
            Color.FromHex("#7479DB"), 
            Color.FromHex("#AD7DF5"),
            Color.FromHex("#D76FE8"),
            Color.FromHex("#87EB81"),
            Color.FromHex("#84F5B4"),
            Color.FromHex("#7BDCD2"),
            Color.FromHex("#84CEF5"),
            Color.FromHex("#EBC775"),
            Color.FromHex("#CDDB6F"),
            Color.FromHex("#9BF578"),

        };

    private void ChangeColorButton_Clicked(object sender, EventArgs e)
    {
        // Escolher uma cor aleatória da lista
        Random random = new Random();
        Color randomColor = randomColors[random.Next(randomColors.Count)];

        // Alterar a cor de fundo da página
        Resources["PageBackgroundColor"] = randomColor;
    }
}