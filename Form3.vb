Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()

        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label1.BringToFront()

        RadioButton1.Parent = PictureBox1
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.BringToFront()

        RadioButton2.Parent = PictureBox1
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            Test_1_PP.Show()
        ElseIf RadioButton2.Checked Then
            Test_2_PP.Show()
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Niste odabrali ništa, molimo odaberite jedan od testova !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class