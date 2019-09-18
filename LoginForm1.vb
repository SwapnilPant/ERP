Imports System.Security.Cryptography
Public Class LoginForm1

    Protected sqlstartdb As startdb = New startdb

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim dt As New DataTable()
        Dim sqldr As SQLite.SQLiteDataReader
        Dim frmmenu As New Menu()
        sqlstartdb.sqlcomm.CommandText = "select * from tbllogindetails where user_name = '" + UsernameTextBox.Text.ToLower + "' and password = '" + sqlstartdb.cryptoclass.Encrypt(PasswordTextBox.Text.ToString) + "'"
        sqldr = sqlstartdb.sqlcomm.ExecuteReader
        dt.Load(sqldr)
        If dt.Rows.Count = 0 Then
            MsgBox("Please enter correct username and password")
            Return
        End If
        frmmenu.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
