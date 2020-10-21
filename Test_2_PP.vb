Public Class Test_2_PP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub Test_2_PP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form3.Hide()

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim zbir As Integer = 0

        If RadioButton1.Checked Then
            TextBox1.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton2.Checked Or RadioButton3.Checked Then
            TextBox1.Text = "Netačan odgovor!"
        End If

        If RadioButton6.Checked Then
            TextBox2.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton4.Checked Or RadioButton5.Checked Then
            TextBox2.Text = "Netačan odgovor!"
        End If

        If RadioButton8.Checked Then
            TextBox3.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton7.Checked Or RadioButton9.Checked Then
            TextBox3.Text = "Netačan odgovor!"
        End If

        If RadioButton11.Checked Then
            TextBox4.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton10.Checked Or RadioButton12.Checked Then
            TextBox4.Text = "Netačan odgovor!"
        End If

        If RadioButton13.Checked Then
            TextBox5.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton14.Checked Or RadioButton15.Checked Then
            TextBox5.Text = "Netačan odgovor!"
        End If

        If RadioButton16.Checked Then
            TextBox6.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton17.Checked Or RadioButton18.Checked Then
            TextBox6.Text = "Netačan odgovor!"
        End If

        If RadioButton19.Checked Then
            TextBox7.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton20.Checked Or RadioButton21.Checked Then
            TextBox7.Text = "Netačan odgovor!"
        End If

        If RadioButton24.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton22.Checked Or RadioButton23.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        Button4.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        RadioButton7.Enabled = False
        RadioButton8.Enabled = False
        RadioButton9.Enabled = False
        RadioButton10.Enabled = False
        RadioButton11.Enabled = False
        RadioButton12.Enabled = False
        RadioButton13.Enabled = False
        RadioButton14.Enabled = False
        RadioButton15.Enabled = False
        RadioButton16.Enabled = False
        RadioButton17.Enabled = False
        RadioButton18.Enabled = False
        RadioButton19.Enabled = False
        RadioButton20.Enabled = False
        RadioButton21.Enabled = False
        RadioButton22.Enabled = False
        RadioButton23.Enabled = False
        RadioButton24.Enabled = False

        MessageBox.Show("Zbir bodova je :" & zbir)

        If zbir > 4 Then
            MessageBox.Show("Položili ste.Čestitamo!", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Niste položili test!", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


End Class