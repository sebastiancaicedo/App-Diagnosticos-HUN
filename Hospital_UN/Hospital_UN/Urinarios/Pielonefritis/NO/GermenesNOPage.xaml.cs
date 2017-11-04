using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios.Pielonefritis.NO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GermenesNOPage : ContentPage
	{
		public GermenesNOPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}
	}
}