using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Cardiacos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiagnosticosCardiacosPage : ContentPage
	{
		public DiagnosticosCardiacosPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnEndoNativaClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndocarditisNativaPage());
        }

        public void OnEndoProtesicaClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EndocarditisProtesicaPage());
        }
    }
}