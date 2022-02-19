﻿using System.Windows;
using System.Collections.Generic;
using AppVerbe.Models;

namespace WPFUI
{
    public partial class ResultsWindow : Window
    {
        private VerbeResults FinalResults = new VerbeResults();
        public ResultsWindow(VerbeResults finalResults)
        {
            InitializeComponent();

            FinalResults = finalResults;

            DataContext = finalResults;
        }
    }
}