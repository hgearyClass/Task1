Public Class FibonacciSeries
    ''' <summary>
    ''' Find a number in the Fibonacci series located at a specified position
    ''' </summary>
    ''' <param name="position">Unvalidated position number in the Fibonacci series</param>
    ''' <returns>A number in the Fibonacci series</returns>
    ''' <remarks></remarks>
    Public Shared Function FindFibonacciValue(ByVal position As String) As String
        Dim tmpPosition As Integer = 0

        If (Not Integer.TryParse(position, tmpPosition)) Then
            Return "Error"
        ElseIf tmpPosition < 1 Then
            Return "Error"
        Else
            Return Fibonacci(tmpPosition).ToString()
        End If
    End Function

    ''' <summary>
    ''' Find a number in the Fibonacci series located at a specified validated position
    ''' </summary>
    ''' <param name="number">Validated position number in the Fibonacci series</param>
    ''' <returns>A number in the Fibonacci series</returns>
    ''' <remarks></remarks>
    Public Shared Function Fibonacci(ByVal number As Integer) As Long
        Select Case number
            Case 1
                Return 0
            Case 2, 3
                Return 1
            Case Else
                Return Fibonacci(number - 1) + Fibonacci(number - 2)
        End Select
    End Function
End Class
