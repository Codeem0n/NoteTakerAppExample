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

namespace CodeemonNoteTakerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public List<string> ListOfMonths = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        
        public MainWindow()
        {
            InitializeComponent();
            DateComboBox.ItemsSource = ListOfMonths;
        }

        private void EnterText_Click(object sender, RoutedEventArgs e)
        {
            string DateSelected = DateComboBox.SelectedItem.ToString();
            string note = DateSelected+"- "+ SubjectHeaderTextbox.Text + ": " + YourNoteTextbox.Text;

            SavedNotes.Items.Add(note);
        }
    }
}
