Public Class Menu
    Public form_invoiceadd As New invoiceadd
    Public form_addvendor As New addvendor
    Public form_login As New Form1 'login
    Public form_history As New history
    Public form_addstock As New addstock

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        form_login.Show()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        form_addstock.Show()
    End Sub

    Private Sub btnhistory_Click(sender As Object, e As EventArgs) Handles btnhistory.Click, btninvoicehistory.Click, btnvendorhistory.Click, btndisplay.Click
        form_history.Show()
    End Sub
End Class