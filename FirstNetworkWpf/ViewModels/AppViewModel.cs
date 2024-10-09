using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;


namespace BikesMvvm.ViewModels;

public class AppViewModel: INotifyPropertyChanged
{


    #region команды
    // Получение данных 

    // О приложении

    // Выход

    #endregion

    #region реализация интерфейса INotifyPropertyChanged
    // событие, зажигающееся при изменении свойства
    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    } // OnPropertyChanged
    #endregion

}