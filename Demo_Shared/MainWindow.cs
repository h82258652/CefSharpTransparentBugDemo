using System.Windows;
using CefSharp;

namespace Demo
{
    public partial class MainWindow
    {
        private void WebBrowser_IsBrowserInitializedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!WebBrowser.IsBrowserInitialized)
            {
                return;
            }

            const string html = "<html><head></head><body><h1>Hello World</h1></body></html>";
            WebBrowser.LoadHtml(html);
        }
    }
}
