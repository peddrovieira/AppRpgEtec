﻿using AppRpgEtec.Views.Personagens;

namespace AppRpgEtec;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("cadPersonagemView", typeof(CadastroPersonagemView));

		String login = Preferences.Get("UsuarioUsername", string.Empty);
		lblLogin.Text = $"Login: {login}";
	}
}
