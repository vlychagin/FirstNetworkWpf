using System.ComponentModel;
using System.Windows;
using System.Runtime.CompilerServices;
using FirstNetworkWpf.Infrastructure;
using FirstNetworkWpf.Windows;

namespace FirstNetworkWpf.ViewModels;

public partial class AppViewModel: INotifyPropertyChanged
{
    public MainWindow HostWindow { get; set; }

    #region команды
    // Скачать файл при помощи WebClient
    public RelayCommand DownloadByWebClientCommand { get; set; }

    // Скачать файл при помощи WebRequest и распарсить по заданию
    public RelayCommand DownloadByWebRequestCommand { get; set; }

    // О приложении
    public RelayCommand AboutCommand { get; set; }

    // Выход
    public RelayCommand ExitCommand { get; set; }

    #endregion

    public AppViewModel(MainWindow hostWindow) {
        HostWindow = hostWindow;

        DownloadByWebClientCommand = new(DownloadByWebClientExec);
        DownloadByWebRequestCommand = new(DownloadByWebRequestExec);

        // Показать окно сведений о программе
        AboutCommand = new(o => { });

        ExitCommand = new(o => Application.Current.Shutdown(0));
    } // AppViewModel

    #region реализация интерфейса INotifyPropertyChanged
    // событие, зажигающееся при изменении свойства
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    } // OnPropertyChanged
    #endregion

}