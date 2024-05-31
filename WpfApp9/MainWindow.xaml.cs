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
using SerLib;


namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Class1.MySerialize(Tbx.Text, "Save.json");
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Tbx.Text = Class1.MyDeserialize<string>("Save.json");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LangCombo.SelectedIndex == 1)
            {
                App.Lang = "en-en";
            }
            else
            {
                App.Lang = "ru-ru";
            }
        }
    }
}
