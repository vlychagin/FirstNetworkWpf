using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

namespace FirstNetworkWpf.ViewModels;

public partial class AppViewModel
{

    // При помощи WebClient загрузите файл с этой ссылки
    // https://github.com/twbs/bootstrap/releases/download/v4.6.1/bootstrap-4.6.1-examples.zip
    // (это CSS-фреймворк Bootstrap).
    private void DownloadByWebClientExec(object o) {
        // класс для загрузки файлов из интернет
        var webClient = new WebClient();

        // адрес для скачивания
        var uri = "https://github.com/twbs/bootstrap/releases/download/v4.6.1/bootstrap-4.6.1-examples.zip";

        // получим имя локального файла из uri: строка после последнего / 
        // т.е. последний элемент массива строк 
        var fileName = uri.Split('/', StringSplitOptions.RemoveEmptyEntries)[^1];

        // полное имя локального файла с путем для сохраенния
        var path = @$"..\..\..\App_Data\{fileName}";

        HostWindow.TblStatus.Text = $"Начата загрузка с URI {uri}";

        // простейшая команда загрузки файла, используем URI, имя локального файла
        webClient.DownloadFile(uri, path);

        HostWindow.TblResult.Text = $"\nФайл {fileName} загружен, скачано, байт: ${new FileInfo(path).Length}";
        HostWindow.TblStatus.Text = $"Завершена загрузка с URI {uri}";
    } // DownloadByWebClientExec


} // class AppViewModel
