Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A(9, 9) As Integer
        Dim sum As Integer
        For i As Integer = 0 To 9
            A(i, 0) = 1
            A(i, i) = 1
        Next
        For i As Integer = 2 To 9
            For j As Integer = 1 To (i - 1)
                A(i, j) = A(i - 1, j - 1) + A(i - 1, j)
            Next
        Next
        For i As Integer = 0 To 9
            For j As Integer = 0 To i
                TextBox1.Text = TextBox1.Text & A(i, j) & ","
            Next
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next
        For i As Integer = 0 To 9
            sum = sum + A(9, i)
        Next
        TextBox1.Text = TextBox1.Text & "最後一行的總和為:" & sum & vbNewLine
    End Sub
End Class
