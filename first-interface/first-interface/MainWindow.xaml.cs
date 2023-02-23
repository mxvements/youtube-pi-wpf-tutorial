using System;
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

namespace first_interface
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            this.Content= grid; //Content represents the window app, add to the window the grid obj

            Button button = new Button();
            button.Width= 200;
            button.Height= 200;
            button.BorderThickness= new Thickness(0);

            WrapPanel wraPanel = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Click";
            wraPanel.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Click";
            wraPanel.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Click";
            wraPanel.Children.Add(txt3);

            button.Content = wraPanel;
            grid.Children.Add(button); //we use the property Children

        }
    }
}
