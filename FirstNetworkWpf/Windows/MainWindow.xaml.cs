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

namespace FirstNetworkWpf;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow() {
        InitializeComponent();

        // привязка данных окна к классу ApplicationViewModel 
        // реализация связи между View и ViewModel
        _applicationViewModel = new ApplicationViewModel(
            new DefaultDialogService(), // реализация диалогов
            new JsonFileService()       // реализация работы с файлами
        );
        DataContext = _applicationViewModel;
    }
}