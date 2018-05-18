﻿using System.Windows;
using System.Windows.Input;
using PiP_Tool.ViewModels;

namespace PiP_Tool.Views
{
    /// <summary>
    /// Logique d'interaction pour SelectorWindow.xaml
    /// </summary>
    public partial class SelectorWindow
    {

        public readonly Selector ViewModel;

        public SelectorWindow()
        {
            ViewModel = new Selector();
            DataContext = ViewModel;
            InitializeComponent();
        }

        private new void MouseDown(object sender, MouseEventArgs e)
        {
            ViewModel.MouseDown(Mouse.GetPosition(CanvasMain));
        }

        private new void MouseUp(object sender, MouseEventArgs e)
        {
            ViewModel.MouseUp();
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            ViewModel.MouseMove(Mouse.GetPosition(CanvasMain));
        }

        private new void MouseRightButtonUp(object sender, MouseEventArgs e)
        {
            //var pictureInPicture = new Views.PictureInPictureWindow(ViewModel.SelectorBoxPosition, ViewModel.SelectorBoxSize);
            //pictureInPicture.Show();
            Close();
        }

    }
}