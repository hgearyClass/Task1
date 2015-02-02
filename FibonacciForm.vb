Public Class FibonacciForm

    Private Sub BtnGo_Click(sender As System.Object, e As System.EventArgs) Handles BtnGo.Click
        LblOutput.Text = FibonacciSeries.FindFibonacciValue(TxtPosition.Text)
    End Sub


End Class
