Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO


Public Class Menu
    Public form_invoiceadd As New invoiceadd
    Public form_addvendor As New addvendor
    Public form_login As New Form1 'login
    Public form_history As New history
    Public form_addstock As New addstock

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim startdb As New startdb
        'startdb.execute()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddinvoice.Click

        form_invoiceadd.Show()
        ' Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnvendor.Click
        form_addvendor.Show()

    End Sub

    Private Sub btninventory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsettings.Click, btn_Logout.Click
        'form_login.Show()
        Dim sqlconn As SQLite.SQLiteConnection
        Dim sqlcomm As SQLite.SQLiteCommand
        Dim sqldr As SQLite.SQLiteDataReader
        sqlconn = New SQLite.SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;")
        sqlconn.Open()
        sqlcomm = sqlconn.CreateCommand
        'sqlcomm.CommandText = "Create table tbllogindetails(user_id integer primary key autoincrement,user_name text,password text ," _
        '                & "created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
        'sqlcomm.ExecuteNonQuery()
        'sqlcomm.CommandText = "insert into tbllogindetails (user_name,password) values ('admin','admin123')"
        'sqlcomm.ExecuteNonQuery()
        sqlcomm.CommandText = "select * from tbllogindetails"
        sqldr = sqlcomm.ExecuteReader
        Dim dt As DataTable = New DataTable()
        dt.Load(sqldr)
        sqlconn.Close()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        form_addstock.Show()
    End Sub

    Private Sub btnhistory_Click(sender As Object, e As EventArgs) Handles btnhistory.Click, btninvoicehistory.Click, btnvendorhistory.Click, btndisplay.Click
        form_history.Show()
    End Sub
End Class