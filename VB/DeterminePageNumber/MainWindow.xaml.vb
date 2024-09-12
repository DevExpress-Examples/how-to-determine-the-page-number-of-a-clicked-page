Imports DevExpress.Xpf.PdfViewer
Imports System.Windows
Imports System.Windows.Input

Namespace DeterminePageNumber

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.pdfViewer.OpenDocument("..\..\demo.pdf")
        End Sub

        Private Sub pdfViewer_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim result As PdfHitTestResult = Me.pdfViewer.HitTest(e.GetPosition(Me.pdfViewer))
            MessageBox.Show(String.Format("You clicked on page {0}", result.DocumentPosition.PageNumber))
        End Sub
    End Class
End Namespace
