﻿Public Class Form1

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub TextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox3.Visible = False Then
            TextBox3.Visible = True
            Button2.Text = "Registo"
        Else
            TextBox3.Visible = False
            Button2.Text = "Login"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Registo" Then
            If TextBox2.Text = TextBox3.Text Then
                'Dim nUsers As Integer = 0
                'nUsers = nUsers + 1
                'Dim user As New User With {.nome = TextBox1.Text, .pass = TextBox2.Text}
                'Dim users(nUsers) As String
                'users(nUsers - 1) = TextBox1.Text
                'Form3.Show()

            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Date.Now.Year
    End Sub
End Class
'my.computer.filesystem 
'   writtealltext(dir, ficheiro, boool)
'
'