Imports System.Text

<TestClass()>
Public Class FibonacciSeriesTest
    ''' <summary>
    ''' Test Fibonacci (validated input)
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()>
    Public Sub FibonacciTest()
        Dim aryPosition() As Integer = {1, 2, 3, 4, 12, 20, 29}
        Dim aryExpectedOutput() As Long = {0, 1, 1, 2, 89, 4181, 317811}

        If (aryPosition.Count = aryExpectedOutput.Count) Then
            For i As Integer = 0 To (aryPosition.Count - 1)
                Assert.AreEqual(aryExpectedOutput(i), Task1.FibonacciSeries.Fibonacci(aryPosition(i)))
            Next
        Else
            Throw New AssertFailedException("Test arrays do not have same range.")
        End If

    End Sub

    ''' <summary>
    ''' Test Fibonacci (input not validated)
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()>
    Public Sub FibonacciTest2()
        Dim aryPosition() As String = {"1", "2", "3", "4", "12", "20", "29", "-1", "a"}
        Dim aryExpectedOutput() As String = {"0", "1", "1", "2", "89", "4181", "317811", "Error", "Error"}

        If (aryPosition.Count = aryExpectedOutput.Count) Then
            For i As Integer = 0 To (aryPosition.Count - 1)
                Assert.AreEqual(aryExpectedOutput(i), Task1.FibonacciSeries.FindFibonacciValue(aryPosition(i)))
            Next
        Else
            Throw New AssertFailedException("Test arrays do not have same range.")
        End If
    End Sub
End Class
