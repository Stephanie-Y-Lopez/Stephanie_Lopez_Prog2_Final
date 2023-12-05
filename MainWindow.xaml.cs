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

namespace Stephanie_Lopez_Prog2_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    // Section 1: Name
    // Stephanie Lopez
    // 12.4.23
    // Programming 2 Final

    public partial class MainWindow : Window
    {
        List<ComboBox> categories;
        LocalizationCategory selectedCategory;
        
        List<string> Task;
        //For ComboBox List
        public MainWindow()
        {
            InitializeComponent();

            List<string> Task = new List<string>
            {
             "Today",
             "Shopping",
             "Travel"
             // List for ComboBox
            };
            
            CMB_Task.ItemsSource = Task;
            //Displays List for ComboBox


            // Adding items to our Today category
            int index = 0;
            CMB_Task[index].AddItemToCategory(new Item("Grocery Shopping", "Go to Fred Meyers", false, true));

            // Adding items to our Shopping category
            index = 1;
            _categories[index].AddItemToCategory(new Item("Pick up Cat Food", "Get Cuts", true, true));

            // Adding items to our Travel category
            index = 2;
            _categories[index].AddItemToCategory(new Item("TPick up travel adapter", "Make sure it covers the UK", true, true));
        }
      
    }

}

