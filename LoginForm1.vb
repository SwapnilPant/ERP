Imports System.Security.Cryptography
Public Class LoginForm1
    Protected sqlstartdb As startdb = New startdb()

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Dim dt As New DataTable()
        Dim frmmenu As New Menu()
        'dt = sqlstartdb.login(UsernameTextBox.Text.ToLower, sqlstartdb.cryptoclass.Encrypt(PasswordTextBox.Text.ToString))
        'If dt.Rows.Count = 0 Then
        '    MsgBox("Please enter correct username and password")
        '    Return
        'End If
        frmmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlstartdb.execute()
    End Sub
End Class
