Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim Operation As String

    Private Sub input(a As String)
        If TextBox1.Text = "0" Then
            TextBox1.Text = a
        Else
            TextBox1.Text += a
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        input("1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        input("2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        input("3")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        input("4")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        input("5")
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        input("6")
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        input("7")
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        input("8")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        input("9")
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        input(".")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "/"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "+"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "-"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "*"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num2 = Decimal.Parse(TextBox1.Text)
        '''///////////////////////////// 
        Select Case Operation
            Case "+"
                TextBox1.Text = (num1 + num2).ToString()
                Exit Select
            Case "-"
                TextBox1.Text = (num1 - num2).ToString()
                Exit Select
            Case "*"
                TextBox1.Text = (num1 * num2).ToString()
                Exit Select
            Case "/"
                TextBox1.Text = (num1 / num2).ToString()
                Exit Select
            Case "^"
                TextBox1.Text = (Integer.Parse(num1.ToString()) Xor Integer.Parse(num2.ToString())).ToString()
                Exit Select
            Case "%"
                TextBox1.Text = (num1 Mod num2).ToString()
                Exit Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = 0
        num2 = 0
        TextBox1.Text = "0"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = (Math.Sin(Double.Parse(TextBox1.Text))).ToString()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = (Math.Cos(Double.Parse(TextBox1.Text))).ToString()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = (Math.Log(Double.Parse(TextBox1.Text))).ToString()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim f As Long = 1
        For i As Long = 1 To Long.Parse(TextBox1.Text)
            f = f * i
        Next
        TextBox1.Text = f.ToString()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = (Math.Sqrt(Double.Parse(TextBox1.Text))).ToString()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "^"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = (Math.Tan(Double.Parse(TextBox1.Text))).ToString()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        num1 = Decimal.Parse(TextBox1.Text)
        Operation = "%"
        TextBox1.Text = "0"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
