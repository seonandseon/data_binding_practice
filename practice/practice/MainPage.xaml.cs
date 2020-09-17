using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace practice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ModelView();
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            ((ModelView)BindingContext).number1++;
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            ((ModelView)BindingContext).number2++;
        }

        void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            ((ModelView)BindingContext).number3++;
        }
    }
}
