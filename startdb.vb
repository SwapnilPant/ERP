Public Class startdb
    Public sqlconn As SQLite.SQLiteConnection
    Public sqlcomm As SQLite.SQLiteCommand
    Public sqldr As SQLite.SQLiteDataReader
    Public cryptoclass As Crypto
    Public Sub New()
        sqlconn = New SQLite.SQLiteConnection("Data Source=database.erp;Version=3;New=True;Compress=True;")
        cryptoclass = New Crypto
        sqlcomm = sqlconn.CreateCommand
        sqlconn.Open()
    End Sub
    Public Sub execute()
        Dim version As String = Me.GetType.Assembly.GetName.Version.ToString()
        sqlconn = New SQLite.SQLiteConnection("Data Source=database.erp;Version=3;New=True;Compress=True;")
        Try
            If version < "1.0.0.0" Then
                sqlcomm.CommandText = "Create table tbllogindetails(ID integer primary key autoincrement,user_name text,password text " _
                            & " created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()
                sqlcomm.CommandText = "insert into tbllogindetails(user_name,password) values('admin','" + cryptoclass.Encrypt("admin") + "')"
                sqlcomm.ExecuteNonQuery()
                'stock
                sqlcomm.CommandText = "Create table tblstock(item_code text primary key,item_category text,productname text,description text ," _
                            & "unit_quantity real,base_unit text,unit_price real,tax real,discount real,price real,purchase_no integer," _
                            & " created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()

                sqlcomm.CommandText = "create table purchase(purchase_no integer primary key autoincrement,vendor_code integer,net_price real,vendor_invoice_no text" _
                            & ",created_date datetime)"
                sqlcomm.ExecuteNonQuery()
                'customer table
                sqlcomm.CommandText = "create table customer (customer_code integer primary key autoincrement,customer_name text,customer_number integer " _
                            & ",customer_address text)"
                sqlcomm.ExecuteNonQuery()
                'vendor table
                sqlcomm.CommandText = "create table vendor(vendor_code integer primary key autoincrement,vendor_name text,vendor_number integer " _
                            & ",vendor_address text,vendor_email text,vendor_gst text,created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()
                'invoice table
                sqlcomm.CommandText = "create table invoice(invoice_number integer primary key autoincrement,customer_code integer,tax real," _
                & "totalprice real,mode_of_payment text,created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()
                'invoice item
                sqlcomm.CommandText = "create table invoice_items(item_no integer primary key autoincrement,item_code text, invoice_number integer" _
                            & ",item_quantity integer,item_rate real,discount real,price real,created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()

                sqlcomm.CommandText = "select * from tbllogindetails"
                sqldr = sqlcomm.ExecuteReader

                Dim dt As DataTable = New DataTable()
                dt.Load(sqldr)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function login(ByVal username As String, ByVal password As String) As DataTable
        Dim dt As New DataTable
        sqlcomm.CommandText = "select * from tbllogindetails where user_name = '" + username + "' and password = '" + password + "'"
        sqldr = sqlcomm.ExecuteReader
        dt.Load(sqldr)
        Return dt
    End Function

    Public Function getProductList(Optional ByVal productcategory As String = "0") As DataTable
        Dim dtadd As New DataTable
        If productcategory = "0" Then
            sqlcomm.CommandText = "select item_code as [Product_ID],description as [Product_Description] from tblstock where unit_quantity > 0"
        Else
            sqlcomm.CommandText = "select item_code as [Product_ID],description as [Product_Description] from tblstock where " _
                    & " unit_quantity > 0 And item_category = '" + productcategory + "'"
        End If
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        Return dtadd
    End Function

    Public Function savecustomer(ByVal customername As String, ByVal customernumber As String, ByVal customeraddress As String) As DataTable
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "insert into customer(customer_name ,customer_number  " _
                        & ",customer_address) values('" + customername + "'," + customernumber + ",'" + customeraddress + "');SELECT last_insert_rowid()"
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        Return dtadd
    End Function

    Public Function getProductDescription(ByVal itemcode As String) As DataTable
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "Select description,base_unit,unit_price from tblstock where item_code='" + itemcode + "'"
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        Return dtadd
    End Function
    Public Function saveinvoice(ByVal customercode As String, ByVal itemcode As String, ByVal itemquantity As String,
                                ByVal itemrate As String, ByVal discount As String, ByVal tax As String, ByVal modeofpayment As String,
                                ByVal price As String, ByVal totalprice As String, ByVal dateinv As String, ByVal isinvoice As Boolean, ByVal invoice_no As String) As Boolean

        Dim dtadd As New DataTable
        Try
            If isinvoice Then
                sqlcomm.CommandText = "insert into invoice(customer_code ,tax,mode_of_payment,totalprice,created_date) " _
                            & " values(" + customercode + "," + tax + ",'" + modeofpayment + "'," + totalprice + ",'" + dateinv + "');"
                sqlcomm.ExecuteNonQuery()
            Else
                sqlcomm.CommandText = "insert into invoice_items(item_code,invoice_number,item_quantity,item_rate,discount,price,created_date) values(" _
                                & "'" + itemcode + "'," + invoice_no + "," + itemquantity + "," + itemrate + "," + discount + "," + price + ",'" + dateinv + "')"
                sqlcomm.ExecuteNonQuery()

                sqlcomm.CommandText = "update tblstock set unit_quantity=(select unit_quantity - " + itemquantity + " from tblstock where item_code='" + itemcode + "') where item_code='" + itemcode + "'"
                sqlcomm.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function setitemstructure(Optional ByVal isEmpty As Boolean = True) As DataTable
        Dim dtadd As New DataTable


        If isEmpty Then
            sqlcomm.CommandText = "Select null As [Item Code],null As [Prodcut Name],null As [Description],null As [Unit Price]," _
                                        & " null As [Quantity],null As [Base unit],null As [Discount],null As [Total Price] from invoice where 1=0"
        Else
            sqlcomm.CommandText = "select inv.invoice_number as [Invoice Number],cus.customer_name as [CUSTOMER],cus.customer_number as [CUSTOMER NO.], " _
       & " inv.mode_of_payment as [MODE OF PAYMENT], stk.item_code as[ITEM CODE], " _
      & " stk.productname As [PRODUCT NAME],stk.description As [DESCRIPTION],                                   " _
      & " stk.item_category as [ITEM CATEGORY],ivt.item_rate as [ITEM PRICE],                                   " _
      & " ivt.item_quantity As [QUANTITY],stk.base_unit As [BASE UNIT] ,                                        " _
      & " ivt.discount as [ITEM DISCOUNT] ,ivt.price as [NET PRICE],                                            " _
      & " inv.tax As [TAX], inv.totalprice As[TOTAL PRICE]                                                      " _
      & " from invoice inv inner join invoice_items as ivt on inv.invoice_number = ivt.invoice_number           " _
      & " inner join customer As cus On cus.customer_code =inv.customer_code                                    " _
      & " inner join tblstock as stk on ivt.item_code = stk.item_code;                                          "
        End If

        Try



            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
        Catch ex As Exception

        End Try
        Return dtadd
    End Function
    Public Function getnextinvoiceno() As String
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "Select seq from sqlite_sequence WHERE name = 'invoice'"
        Try
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
        Catch ex As Exception

        End Try
        Return If(dtadd.Rows.Count = 0, 1, dtadd(0)(0).ToString)
    End Function

    'for vendor
    Public Function getVendorList(Optional ByVal empty As Boolean = True, Optional ByVal vendorid As String = "0") As DataTable
        Dim dtadd As New DataTable
        Try
            If empty Then
                sqlcomm.CommandText = "select vendor_name + vendor_number as [Vendor Name],vendor_number as [Vendor Number]" _
                            & ",vendor_address as [Vendor Address],vendor_gst as [Vendor GST],vendor_email as [Email] from vendor where 1=0"
                sqldr = sqlcomm.ExecuteReader
                dtadd.Load(sqldr)
            Else
                If vendorid = "0" Then
                    sqlcomm.CommandText = "select vendor_code as [Vendor Code],vendor_name || ' (' || vendor_number || ')' as [Vendor Name],vendor_number as [Vendor Number]" _
                            & ",vendor_address as [Vendor Address],vendor_gst as [Vendor GST],vendor_email as [Email] from vendor"
                    sqldr = sqlcomm.ExecuteReader
                    dtadd.Load(sqldr)
                Else
                    sqlcomm.CommandText = "SELECT vdr.vendor_code AS [Vendor Code]," _
                       & " vdr.vendor_name As [Vendor Name],prs.purchase_no as [Purchase No.],prs.vendor_invoice_no as [Bill No.]," _
                       & " stk.productname AS [Product Name],stk.description AS [Product Description],stk.unit_quantity AS QUANTITY," _
                       & " stk.price As [TOTAL PRICE] FROM vendor vdr " _
                       & " INNER JOIN purchase prs ON prs.vendor_code = vdr.vendor_code INNER JOIN tblstock stk ON stk.purchase_no = prs.purchase_no " _
                       & "  where vdr.vendor_code = " + vendorid
                    sqldr = sqlcomm.ExecuteReader
                    dtadd.Load(sqldr)
                End If
            End If
            Return dtadd
        Catch ex As Exception
            MsgBox("Error While getting vendor data")
        End Try
    End Function

    Public Function savevendor(ByVal vendorname As String, ByVal vendorno As String, ByVal address As String,
                                ByVal gst As String, ByVal email As String, ByVal dateinv As String) As Boolean

        Dim dtadd As New DataTable
        Try
            sqlcomm.CommandText = "insert into vendor(vendor_name ,vendor_number,vendor_address,vendor_gst,vendor_email,created_date) " _
                        & " values('" + vendorname + "'," + vendorno + ",'" + address + "','" + gst + "','" + email + "','" + dateinv + "');"
            sqlcomm.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getstock(Optional ByVal empty As Boolean = True) As DataTable
        Dim dt As New DataTable
        Try
            If empty Then
                sqlcomm.CommandText = "select item_code as [Item Code],item_category as [Item Category],productname as [Product Name],description as [Description]" _
                                            & ",unit_quantity as [Quantity],base_unit as [Base Unit],unit_price as [Unit Price],tax as [Tax],discount as [Discount],price as [Price] from tblstock where 1=0"
                sqldr = sqlcomm.ExecuteReader
                dt.Load(sqldr)
            Else
                sqlcomm.CommandText = "select item_code as [Item Code],item_category as [Item Category],productname as [Product Name],description as [Description]" _
                                            & ",unit_quantity as [Quantity],base_unit as [Base Unit],unit_price as [Unit Price],tax as [Tax],discount as [Discount],price as [Price] from tblstock "
                sqldr = sqlcomm.ExecuteReader
                dt.Load(sqldr)
            End If
            Return dt
        Catch ex As Exception

        End Try
    End Function

    Public Function getpurchaseno() As String
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "Select seq from sqlite_sequence WHERE name = 'purchase'"
        Try
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
        Catch ex As Exception

        End Try
        Return If(dtadd.Rows.Count.ToString = 0, 1, dtadd(0)(0).ToString)
    End Function

    Public Function saveStock(ByVal item_code As String, ByVal purchase_no As String, ByVal vendor_code As String, ByVal net_price As String, ByVal vendor_invoice_no As String _
                                , ByVal item_category As String, ByVal productname As String, ByVal description As String, ByVal unit_quantity As String _
                                , ByVal base_unit As String, ByVal unit_price As String, ByVal tax As String, ByVal discount As String, ByVal price As String,
                                ByVal created_date As String, ByVal isItems As Boolean) As Boolean
        Dim dtadd As New DataTable
        Try
            If isItems Then
                sqlcomm.CommandText = "insert into tblstock(item_code,item_category ,productname,description,unit_quantity,base_unit,unit_price,tax,discount,price,purchase_no,created_date) " _
                & " values('" + item_code + "','" + item_category + "','" + productname + "','" + description + "'," + unit_quantity + ",'" + base_unit + "'," + unit_price + "," + tax + "," _
                & discount + "," + price + "," + purchase_no + ",'" + created_date + "');"
                sqlcomm.ExecuteNonQuery()
            Else
                sqlcomm.CommandText = "insert into purchase(vendor_code,net_price,vendor_invoice_no,created_date) values(" _
                                & "" + vendor_code + "," + net_price + ",'" + vendor_invoice_no + "','" + created_date + "');"
                sqlcomm.ExecuteNonQuery()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getInvoice(Optional ByVal isall As Boolean = True, Optional ByVal invoiceno As String = "0", Optional ByVal customer_code As String = "0") As DataTable
        Dim dtadd As New DataTable
        Try
            If isall Then
                sqlcomm.CommandText = "Select invoice_number,cast(invoice_number as text) as [invoice] from invoice "
            ElseIf invoiceno <> "0" Then
                sqlcomm.CommandText = "SELECT inv.invoice_number AS [Invoice Number],inv.mode_of_payment AS [Mode Of Payement], " _
                   & " cust.customer_name || ' - '|| cust.customer_code as [Customer],inv.tax AS [Total Tax],itm.item_code AS [Item Code],stk.productname as [Product Name], " _
                   & " stk.description As [Description],itm.item_quantity As QUANTITY,itm.price As [TOTAL PRICE],itm.discount As [Item Discount] " _
                & " FROM invoice inv INNER JOIN invoice_items itm ON inv.invoice_number = itm.invoice_number " _
                  & " INNER JOIN customer cust ON cust.customer_code = inv.customer_code inner join tblstock stk on stk.item_code = itm.item_code " _
                & "where inv.invoice_number = " + invoiceno

            ElseIf customer_code <> "0" Then
                sqlcomm.CommandText = "SELECT inv.invoice_number AS [Invoice Number],inv.mode_of_payment AS [Mode Of Payement], " _
                   & " cust.customer_name || ' - '|| cust.customer_code as [Customer],inv.tax AS [Total Tax],itm.item_code AS [Item Code],stk.productname as [Product Name], " _
                   & " stk.description As [Description],itm.item_quantity As QUANTITY,itm.price As [TOTAL PRICE],itm.discount As [Item Discount] " _
                & " FROM invoice inv INNER JOIN invoice_items itm ON inv.invoice_number = itm.invoice_number " _
                  & " INNER JOIN customer cust ON cust.customer_code = inv.customer_code inner join tblstock stk on stk.item_code = itm.item_code " _
                & "where cust.customer_code = " + customer_code
            End If
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
            Return dtadd
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getCustomer(Optional ByVal isall As Boolean = True) As DataTable
        Dim dtadd As New DataTable
        Try
            If isall Then
                sqlcomm.CommandText = "Select customer_code,customer_code || ' - ' || customer_name as [customercode] from customer "
            Else

            End If
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
            Return dtadd
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getinventory(ByVal productcode As String, ByVal itemcategory As String) As DataTable
        Dim dtadd As New DataTable
        Try
            If itemcategory <> "Select Category" Then
                sqlcomm.CommandText = "select item_code as [Item Code],item_category as [Category]," _
                    & " productname as [Name],description AS[Description],unit_quantity as [QUANTITY]," _
                    & " base_unit as [UoM],unit_price as [Unit Price],price as [TOTAL PRICE] from tblstock where item_category like '" + itemcategory + "'"
            ElseIf productcode <> "0" Then
                sqlcomm.CommandText = "select item_code as [Item Code],item_category as [Category]," _
                    & " productname as [Name],description AS[Description],unit_quantity as [QUANTITY]," _
                    & " base_unit as [UoM],unit_price as [Unit Price],price as [TOTAL PRICE] from tblstock  where item_code like '" + productcode + "'"
            Else
                sqlcomm.CommandText = "select item_code as [Item Code],item_category as [Category]," _
                    & " productname as [Name],description AS[Description],unit_quantity as [QUANTITY]," _
                    & " base_unit as [UoM],unit_price as [Unit Price],price as [TOTAL PRICE] from tblstock "
            End If
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
            Return dtadd
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function isstockavailabl(ByVal itemcode As String, ByVal qty As String) As Boolean
        Dim dtadd As New DataTable
        Try
            sqlcomm.CommandText = "select unit_quantity from tblstock where item_code = '" + itemcode + "'  - " + qty
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
            If dtadd(0)(0).ToString > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function
End Class

