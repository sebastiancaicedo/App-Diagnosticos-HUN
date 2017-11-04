using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hospital_UN
{
	public partial class MainPage : ContentPage
	{
        public const string THE_TITLE = "GUIA Terapeutica HUN";

		public MainPage()
		{
            Title = THE_TITLE;
			InitializeComponent();
		}

        public void OnDiagnosticosUrinariosClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Urinarios.DiagnosticosUrinariosPage());
        }

        public void OnDiagnosticosCardiacosClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cardiacos.DiagnosticosCardiacosPage());
        }

        public void OnDiagnosticosInmunologicosClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inmunologicos.DiagnosticosInmunologicosPage());
        }

    }
}
