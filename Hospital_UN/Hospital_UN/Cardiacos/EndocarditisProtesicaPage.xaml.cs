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
	public partial class EndocarditisProtesicaPage : ContentPage
	{
		public EndocarditisProtesicaPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}
	}
}