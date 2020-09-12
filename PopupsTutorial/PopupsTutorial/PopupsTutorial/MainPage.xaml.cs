﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsTutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert.", "OK");
        }

        private async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save?", "Would you like to save your data?", "Yes", "No");
            Console.WriteLine("Save data: " + response);
        }

        private async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Send to?", "Cancel", "？？？", "Email", "Twitter", "Facebook");
            Console.WriteLine("Action: " + action);
        }
    }
}
