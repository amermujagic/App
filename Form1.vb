Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form2.Show()
        ElseIf RadioButton2.Checked Then
            Form3.Show()
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Nista nista odabrali, molimo odaberite jedan od testova !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class
