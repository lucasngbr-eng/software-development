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
using StructureAttributes.ViewModel;

namespace StructureAttributes.UI
{
    /// <summary>
    /// Interação lógica para MainView.xam
    /// </summary>
    /// 

    public partial class MainView : UserControl
    {
      
        public MainView()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            
        }
    }
}
