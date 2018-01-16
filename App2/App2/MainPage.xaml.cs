using no.point.paypoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            try
            {
                PayPoint test = new PayPoint();
                test.startTestCom();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
         
		}
	}
}
