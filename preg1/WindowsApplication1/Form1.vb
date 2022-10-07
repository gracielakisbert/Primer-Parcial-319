Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim r As Integer
        Dim i As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        For i = 1 To 3
            If a > b Then
                r = a
                If r > c Then
                    r = a
                    TextBox4.Text = TextBox4.Text + r.ToString + "-"
                    a = 0
                Else
                    r = c
                    TextBox4.Text = TextBox4.Text + r.ToString + "-"
                    c = 0

                End If
            Else
                r = b
                If b > c Then
                    r = b
                    TextBox4.Text = TextBox4.Text + r.ToString + "-"
                    b = 0

                Else
                    r = c
                    TextBox4.Text = TextBox4.Text + r.ToString + "-"
                    c = 0

                End If
            End If



        Next

    End Sub
End Class

