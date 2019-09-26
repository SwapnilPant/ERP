Public Class addvendor
    Protected startdb As startdb = New startdb()
    Protected dtadd As DataTable = New DataTable()
    Private Sub addvendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtadd = startdb.getVendorList()
            dgvvendor.DataSource = dtadd
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnaddvendor_Click(sender As Object, e As EventArgs) Handles btnaddvendor.Click
        dtadd.Rows.Add(txtvendorname.Text.ToString, txtvendornumber.Text.ToString, txtvendoraddress.Text.ToString, txtgst.Text.ToString, txtvendoremail.Text.ToString)
        dgvvendor.DataSource = dtadd
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dtvendors As DataTable = dgvvendor.DataSource
        Try
            For Each dr As DataRow In dtvendors.Rows
                startdb.savevendor(dr("Vendor Name").ToString, dr("Vendor Number").ToString, dr("Vendor Address").ToString, dr("Vendor GST").ToString,
                                        dr("Email").ToString, DateTimePicker1.Value.ToString("dd-MM-yyyy"))
            Next
        Catch ex As Exception
            MsgBox("Error while saving vendor")
        End Try
        reset()
        dgvvendor.DataSource = Nothing
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        reset()
        dgvvendor.DataSource = Nothing
    End Sub

    Protected Function reset()
        txtgst.Text = ""
        txtvendoraddress.Text = ""
        txtvendorname.Text = ""
        txtvendornumber.Text = ""
        txtvendoremail.Text = ""
    End Function
End Class