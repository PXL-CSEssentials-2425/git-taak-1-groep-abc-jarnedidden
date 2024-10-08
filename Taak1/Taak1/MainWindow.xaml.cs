﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow; 
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;

        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#FF0000";
            informatiecode.Text = "Rood is de kleur van warmte";

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#FFFF00";
            informatiecode.Text = "geel is de kleur van levenslust";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#008000";
            informatiecode.Text = "groen is de kleur van genezing";
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            kleurCode.Text = "#0000FF";
            informatiecode.Text = "blauw is de kleur van intelligentie";
        }

        

    }
}