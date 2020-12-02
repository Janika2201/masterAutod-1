using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterAutod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chevrolet : ContentPage
    {
        public chevrolet()
        {
            InitializeComponent();
        }

        private void modelChevrolet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}