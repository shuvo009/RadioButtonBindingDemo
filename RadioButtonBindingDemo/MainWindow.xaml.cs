using System;
using System.Collections.Generic;
using System.Linq;
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
using System.ComponentModel;

namespace RadioButtonBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _SelectedRadioButtom = "RadioButtonOne";

        public string SelectedRadioButtom
        {
            get { return _SelectedRadioButtom; }
            set
            {
                if (_SelectedRadioButtom == value)
                    return;
                _SelectedRadioButtom = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedRadioButtom"));
            }
        }
        
    }
}
