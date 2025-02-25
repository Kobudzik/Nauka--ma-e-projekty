using MVVM.ViewModel;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AccountCreationViewModel _viewModel = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            _viewModel.ValidatePassword();
        }
    }
}
