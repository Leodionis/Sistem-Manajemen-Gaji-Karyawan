Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbenefit.SelectedIndexChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sal As Double
        Dim hou As Double
        Dim con As Double
        Dim med As Double
        Dim tran As Double
        Dim util As Double
        Dim bonus As Double
        Dim gross As Double
        Dim net As Double
        Dim tax As Double

        sal = Convert.ToDecimal(txtgajipokok.Text)
        If CheckBox1.Checked = True Then
            hou = (35 / 100) * sal

        End If
        If CheckBox2.Checked = True Then
            med = (7 / 100) * sal

        End If
        If CheckBox3.Checked = True Then
            con = (8.5 / 100) * sal

        End If
        If CheckBox4.Checked Then
            If cmbbenefit.Text = "bonus Tahun Baru" Then

                bonus = 5500000

            End If
            If cmbbenefit.Text = "bonus Hari Raya" Then

                bonus = 3500000

            End If
            If cmbbenefit.Text = "bonus Lembur" Then

                bonus = 100000

            End If
        End If
        If CheckBox5.Checked = True Then
            tran = (9 / 100) * sal


        End If
        If CheckBox6.Checked = True Then
            util = (12 / 100) * sal

        End If
        gross = bonus + hou + med + tran + con + util + sal
        tax = (15 / 100) * sal
        net = gross - tax
        TextBox2.Text = Convert.ToDouble(tax)
        TextBox3.Text = Convert.ToDouble(gross)
        TextBox4.Text = Convert.ToDouble(net)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        cmbposisi.Text = ""
        cmbbenefit.Text = ""
        txtgajipokok.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
