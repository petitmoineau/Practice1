using DateCheck.ViewModels;
using System.Windows.Controls;

namespace DateCheck.Views
{
    /// <summary>
    /// Interaction logic for DateInputView.xaml
    /// </summary>
    /// 
    
    public partial class DateInputView : UserControl
    {
        public DateInputView()
        {
            InitializeComponent();
            DataContext = new DateInputViewModel();
        }
    }
}
