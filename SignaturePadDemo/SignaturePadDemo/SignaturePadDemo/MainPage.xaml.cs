using System;
using System.IO;
using SignaturePad.Forms;
using Xamarin.Forms;

namespace SignaturePadDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void Save(object sender, EventArgs eventArgs)
	    {

	        Stream stream = await Pad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
        }
	}
}
