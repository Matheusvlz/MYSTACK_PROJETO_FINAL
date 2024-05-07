﻿using MyStack.Pacotes.Telas;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyStackV_
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateToPage(new Login());
            
        }


        public void NavigateToPage(Page page)
        {
            frameConteudo.NavigationService.Navigate(page);
        }
    }
}