﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labb_4 {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            RunPlayGame();

        }

        private static void RunPlayGame()
        {

            App.Current.MainWindow.DataContext = new PlayGame();

        }

        private void PlayGameButton_Clicked(object sender, RoutedEventArgs e) {
            DataContext = new PlayGame();
        }

        private void EditQuizButton_Clicked(object sender, RoutedEventArgs e) {
            DataContext = new EditQuiz();
        }

        private void CreateQuizButton_Clicked(object sender, RoutedEventArgs e) {
            DataContext = new CreateNewQuizTitle();
        }

    }

}
