﻿Public Class history
    Protected startdb As startdb = New startdb()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmmenu As New Menu
        frmmenu.Show()
        Me.Close()
    End Sub

    Private Sub btnfetch_Click(sender As Object, e As EventArgs) Handles Btnfetch.Click
        Dim dt As New DataTable
        Dim strtotalamt As Integer = 0
        Dim strtotalqty As Integer = 0

        If MyBase.Text = "Vendor History" Then
            dt = startdb.getVendorList(False, cbxvendorname.SelectedValue.ToString)
            dgresult.DataSource = dt
        Else
            For Each dr As DataRow In dt.Rows
                strtotalamt = strtotalamt + dr("TOTAL PRICE").ToString
                strtotalqty = strtotalqty + dr("QUANTITY").ToString
            Next
            Txtquantity.Text = strtotalqty
            txtsubtotal.Text = strtotalamt
        End If


    End Sub

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtvendorlist As New DataTable
        Dim dtvendorlistdb As New DataTable
        Dim dtproductlist As New DataTable
        Dim dtproductlistdb As New DataTable
        Dim dtinvoice As New DataTable
        Dim dtcustomer As New DataTable

        cbxproductname.ValueMember = "Product_ID"
        cbxproductname.DisplayMember = "Product_Description"
        dtproductlist.Columns.Add("Product_ID")
        dtproductlist.Columns.Add("Product_Description")
        Dim R As DataRow = dtproductlist.NewRow
        R("Product_ID") = "0"
        R("Product_Description") = "Select Product"
        dtproductlist.Rows.Add(R)
        dtproductlistdb = startdb.getProductList()
        dtproductlist.Merge(dtproductlistdb)
        cbxproductname.DataSource = dtproductlist

        If MyBase.Text = "Vendor History" Then
            cbxtransaction.Enabled = False
            Cbxinvoiceno.Enabled = False
            Cbxcustomername.Enabled = False
            Cbxcode.Enabled = False
            Cbxitem.Enabled = False
            cbxproductname.Enabled = False
            cbxvendorname.ValueMember = "Vendor Code"
            cbxvendorname.DisplayMember = "Vendor Name"
            dtvendorlist.Columns.Add("Vendor Code", Type.GetType("System.Int64"))
            dtvendorlist.Columns.Add("Vendor Name")
            Dim Rv As DataRow = dtvendorlist.NewRow
            Rv("Vendor Code") = Int("0")
            Rv("Vendor Name") = "Select Product"
            dtvendorlist.Rows.Add(Rv)
            dtvendorlistdb = startdb.getVendorList(False)
            dtvendorlist.Merge(dtvendorlistdb)
            cbxvendorname.DataSource = dtvendorlist
        ElseIf MyBase.Text = "Invoice History" Then
            cbxvendorname.Enabled = False
            cbxtransaction.Enabled = False
            Cbxcode.Enabled = False
            cbxproductname.Enabled = False
            Cbxitem.Enabled = False
            dtinvoice = startdb.getInvoice(True)
            dtcustomer = startdb.getCustomer(True)
            Cbxinvoiceno.DisplayMember = "invoice"
            Cbxinvoiceno.ValueMember = "invoice_number"
            Cbxcustomername.DisplayMember = "customercode"
            Cbxcustomername.ValueMember = "customer_code"
            Cbxinvoiceno.DataSource = dtinvoice
            Cbxcustomername.DataSource = dtcustomer
        End If
    End Sub

End Class