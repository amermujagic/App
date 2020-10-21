Public Class Test_1_TT

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = True

    End Sub
    Private Sub Test_1_TT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Visible = False
        Panel3.Visible = True
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel4.Visible = True
        Panel3.Visible = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel4.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel5.Visible = True
        Panel4.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel5.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel5.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel6.Visible = False
        Panel5.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel7.Visible = True
        Panel6.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel7.Visible = False
        Panel6.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel7.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Panel8.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel9.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel8.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Panel9.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Panel10.Visible = False
        Panel9.Visible = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Panel10.Visible = False
        Panel11.Visible = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Panel11.Visible = False
        Panel10.Visible = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Panel11.Visible = False
        Panel12.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Panel11.Visible = True
        Panel12.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Panel12.Visible = False
        Panel13.Visible = True
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Panel13.Visible = False
        Panel12.Visible = True
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Panel13.Visible = False
        Panel14.Visible = True
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Panel14.Visible = False
        Panel13.Visible = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Panel14.Visible = False
        Panel15.Visible = True
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Panel15.Visible = False
        Panel14.Visible = True
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim zbir As Integer = 0

        If RadioButton2.Checked Then
            TextBox1.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton1.Checked Or RadioButton3.Checked Then
            TextBox1.Text = "Netačan odgovor!"
        End If

        If RadioButton5.Checked Then
            TextBox2.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton4.Checked Or RadioButton6.Checked Then
            TextBox2.Text = "Netačan odgovor!"
        End If

        If RadioButton7.Checked Then
            TextBox3.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton9.Checked Or RadioButton8.Checked Then
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

        If RadioButton20.Checked Then
            TextBox7.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton19.Checked Or RadioButton21.Checked Then
            TextBox7.Text = "Netačan odgovor!"
        End If

        If RadioButton24.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton22.Checked Or RadioButton23.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton25.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton26.Checked Or RadioButton27.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton30.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton29.Checked Or RadioButton28.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton32.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton31.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton34.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton33.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton36.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton35.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton38.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton37.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton39.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton40.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton42.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton41.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton44.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton43.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton46.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton45.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton47.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton48.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton49.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton50.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton52.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton51.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton53.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton52.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton55.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton54.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton57.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton58.Checked Or RadioButton59.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton61.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton60.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton64.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton62.Checked Or RadioButton63.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton66.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton65.Checked Or RadioButton69.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton68.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton67.Checked Or RadioButton70.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton71.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton72.Checked Or RadioButton75.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        If RadioButton73.Checked Then
            TextBox8.Text = "Tačan odgovor!"
            zbir = zbir + 1
        ElseIf RadioButton74.Checked Or RadioButton76.Checked Then
            TextBox8.Text = "Netačan odgovor!"
        End If

        Button30.Enabled = False
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
        RadioButton25.Enabled = False
        RadioButton26.Enabled = False
        RadioButton27.Enabled = False
        RadioButton28.Enabled = False
        RadioButton29.Enabled = False
        RadioButton30.Enabled = False
        RadioButton31.Enabled = False
        RadioButton32.Enabled = False
        RadioButton33.Enabled = False
        RadioButton34.Enabled = False
        RadioButton35.Enabled = False
        RadioButton36.Enabled = False
        RadioButton37.Enabled = False
        RadioButton38.Enabled = False
        RadioButton39.Enabled = False
        RadioButton40.Enabled = False
        RadioButton41.Enabled = False
        RadioButton42.Enabled = False
        RadioButton43.Enabled = False
        RadioButton44.Enabled = False
        RadioButton45.Enabled = False
        RadioButton46.Enabled = False
        RadioButton47.Enabled = False
        RadioButton48.Enabled = False
        RadioButton49.Enabled = False
        RadioButton50.Enabled = False
        RadioButton51.Enabled = False
        RadioButton52.Enabled = False
        RadioButton53.Enabled = False
        RadioButton54.Enabled = False
        RadioButton55.Enabled = False
        RadioButton56.Enabled = False
        RadioButton57.Enabled = False
        RadioButton58.Enabled = False
        RadioButton59.Enabled = False
        RadioButton60.Enabled = False
        RadioButton61.Enabled = False
        RadioButton62.Enabled = False
        RadioButton63.Enabled = False
        RadioButton64.Enabled = False
        RadioButton65.Enabled = False
        RadioButton66.Enabled = False
        RadioButton67.Enabled = False
        RadioButton68.Enabled = False
        RadioButton69.Enabled = False
        RadioButton70.Enabled = False
        RadioButton71.Enabled = False
        RadioButton72.Enabled = False
        RadioButton73.Enabled = False
        RadioButton74.Enabled = False
        RadioButton75.Enabled = False
        RadioButton76.Enabled = False

        MessageBox.Show("Zbir bodova je :" & zbir)

        If zbir > 15 Then
            MessageBox.Show("Položili ste.Čestitamo!", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Niste položili test!", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class