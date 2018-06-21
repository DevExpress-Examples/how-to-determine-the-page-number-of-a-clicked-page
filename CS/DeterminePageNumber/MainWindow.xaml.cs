using DevExpress.Xpf.PdfViewer;
using System.Windows;
using System.Windows.Input;

namespace DeterminePageNumber {

    public partial class MainWindow : Window {


        public MainWindow() {
            InitializeComponent();
            pdfViewer.OpenDocument("..\\..\\demo.pdf");
        }

        private void pdfViewer_MouseDown(object sender, MouseButtonEventArgs e) {
            PdfHitTestResult result = pdfViewer.HitTest(e.GetPosition(pdfViewer));
            MessageBox.Show(string.Format("You clicked on page {0}", result.DocumentPosition.PageNumber));
        }
    }
}

