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
    Private IFileReaderService As ReaderOptions
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged, txtpassword.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        dt = ds.Tables("login")
        For Each dr As DataRow In dt.Rows
            If txtname.Text.ToLower = dr("name").ToString.ToLower And txtpassword.Text = dr("password").ToString Then
                status.Text = "Successfull"
                Return
            Else
                status.Text = "UnSuccessfull"
            End If
        Next
    End Sub

    Private Sub llblforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblforgot.LinkClicked

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet("Login")
        Try
            Dim Path As String = "C:/Users/Swapnil Pant/Documents/Visual Studio 2015/Projects/appdata.xml"
            ds.ReadXml("C:/Users/Swapnil Pant/Documents/Visual Studio 2015/Projects/appdata.xml")
            dt = ds.Tables("Login")
        Catch ex As FileNotFoundException
            'Dim xmlDatadoc As New XmlDataDocument()
            'xmlDatadoc.DataSet.ReadXml("F:/customer.xml")
            'ds = xmlDatadoc.DataSet
        End Try
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles status.Click

    End Sub
End Class
