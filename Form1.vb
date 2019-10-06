Imports System.Collections.Generic

Imports System.ComponentModel

Imports System.Data

Imports System.Drawing

Imports System.Linq
Imports System.Windows.Forms
Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO
Imports System.Text

Public Class Form1
    Protected sqlstartdb As startdb = New startdb
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click, Btnback.Click
        Dim dt As New DataTable()
        Dim sqldr As SQLite.SQLiteDataReader
        Dim frmmenu As New LoginForm1()
        sqlstartdb.sqlcomm.CommandText = "select * from tbllogindetails where user_name = '" + txtname.Text.ToLower + "' and password = '" + txtpassword.Text.ToString + "'"
        sqldr = sqlstartdb.sqlcomm.ExecuteReader
        dt.Load(sqldr)
        If dt.Rows.Count = 0 Then
            MsgBox("Please enter correct username and password")
            Return
        End If
        frmmenu.Show()
        Me.Hide()
    End Sub
End Class
