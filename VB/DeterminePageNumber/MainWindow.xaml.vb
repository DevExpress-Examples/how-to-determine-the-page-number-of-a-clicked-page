Imports DevExpress.Xpf.PdfViewer
Imports System.Windows
Imports System.Windows.Input

Namespace DeterminePageNumber

    Partial Public Class MainWindow
        Inherits Window


        Public Sub New()
            InitializeComponent()
            pdfViewer.OpenDocument("..\..\demo.pdf")
        End Sub

        Private Sub pdfViewer_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim position As PdfHitTestResult = pdfViewer.HitTest(e.GetPosition(pdfViewer))
            MessageBox.Show(String.Format("You clicked on page {0}", position.DocumentPosition.PageNumber))
        End Sub
    End Class
End Namespace

