using System.ComponentModel;
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

    // О приложении

    // Выход

    #endregion

    public AppViewModel(MainWindow hostWindow) {
        HostWindow = hostWindow;

        DownloadByWebClientCommand = new(DownloadByWebClientExec);
    } // AppViewModel

    #region реализация интерфейса INotifyPropertyChanged
    // событие, зажигающееся при изменении свойства
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    } // OnPropertyChanged
    #endregion

}