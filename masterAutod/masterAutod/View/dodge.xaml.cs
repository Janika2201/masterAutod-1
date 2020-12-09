﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterAutod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dodge : ContentPage
    {
        public dodge()
        {
            InitializeComponent();
        }

        private void modelDodge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelDodge.Items[modelDodge.SelectedIndex] == "Dodge Demon")
            {
                PhotosDodge.Source = "dodgeDiablo.jpg";
            }
            else if (modelDodge.Items[modelDodge.SelectedIndex] == "Dodge Challenger")
            {
                PhotosDodge.Source = "dodgeChallenger.jpg";
            }
            else if (modelDodge.Items[modelDodge.SelectedIndex] == "Dodge Charger")
            {
                PhotosDodge.Source = "dodgeCharger.jpg";
            }
            else if (modelDodge.Items[modelDodge.SelectedIndex] == "Dodge RAM")
            {
                PhotosDodge.Source = "dodgeRAM.jpg";
            }
        }
    }
}