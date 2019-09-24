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
        'sqlconn = New SQLite.SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;")
        'sqlconn.Open()
        'sqlcomm = sqlconn.CreateCommand
        Try
            If version < "1.0.0.0" Then
                'stock table
                'sqlcomm.CommandText = "Create table tbllogindetails(ID integer primary key autoincrement,user_name text,password text " _
                '            & " created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                'sqlcomm.CommandText = "insert into tbllogindetails(user_name,password) values('admin','" + cryptoclass.Encrypt("admin123") + "')"
                'sqlcomm.ExecuteNonQuery()
                sqlcomm.CommandText = "Create table tblstock(item_code text primary key ,item_category text,productname text,description text ," _
                            & "unit_quantity real,base_unit text,unit_price real,tax real,discount real,net_price real," _
                            & " created_date datetime default current_timestamp,modified_date datetime default current_timestamp)"
                sqlcomm.ExecuteNonQuery()
                'customer table
                sqlcomm.CommandText = "create table customer (customer_code integer primary key autoincrement,customer_name text,customer_number integer " _
                            & ",customer_address text)"
                sqlcomm.ExecuteNonQuery()
                'vendor table
                sqlcomm.CommandText = "create table vendor(vendor_code integer primary key autoincrement,vendor_name text,vendor_number integer " _
                            & ",vendor_address text,vendor_gst text)"
                sqlcomm.ExecuteNonQuery()
                'invoice table
                sqlcomm.CommandText = "create table invoice(invoice_number integer primary key autoincrement,customer_code integer,item_code text" _
                            & ",item_quantity integer,item_rate real,discount real,tax real,price real,totalprice real,mode_of_payment text,created_date datetime,modified_date)"
                sqlcomm.ExecuteNonQuery()

                sqlcomm.CommandText = "select * from tbllogindetails"
                sqldr = sqlcomm.ExecuteReader
                Dim dt As DataTable = New DataTable()
                dt.Load(sqldr)

            End If
            'sqlcomm.CommandText = "insert into tblstock (item_code,productname,item_category,description,unit_quantity,base_unit,unit_price,tax,discount,net_price) values" _
            '& "('45b','jean full','jean','full jeans 34','100','pcs','400','39',20,41900)"
            'sqlcomm.CommandText = "select stk.description as [Prodcut Name],inv.item_rate as [Unit Price]," _
            '                        & " inv.item_quantity as [Quantity],inv.discount as [Discount],inv.price as [Total Price] from invoice as inv " _
            '                        & "inner join tblstock stk on stk.item_code = inv.item_code order by inv.created_date"
            'sqlcomm.ExecuteNonQuery()
            'dtadd.Load(sqldr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'sqlconn.Close()
    End Sub

    Public Function login(ByVal username As String, ByVal password As String) As DataTable
        Dim dt As New DataTable
        sqlcomm.CommandText = "select * from tbllogindetails where user_name = '" + username + "' and password = '" + password + "'"
        sqldr = sqlcomm.ExecuteReader
        dt.Load(sqldr)
        Return dt
    End Function

    Public Function getProductList() As DataTable
        Dim dtadd As New DataTable
        'sqlconn.Open()
        sqlcomm.CommandText = "select item_code as [Product_ID],description as [Product_Description] from tblstock"
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        'sqlconn.Close()
        Return dtadd
    End Function
    Public Function savecustomer(ByVal customername As String, ByVal customernumber As String, ByVal customeraddress As String) As DataTable
        Dim dtadd As New DataTable
        'sqlconn.Open()
        sqlcomm.CommandText = "insert into customer(customer_name ,customer_number  " _
                        & ",customer_address) values('" + customername + "'," + customernumber + ",'" + customeraddress + "');SELECT last_insert_rowid()"
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        'sqlconn.Close()
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
                                ByVal price As String, ByVal totalprice As String, ByVal dateinv As String) As DataTable

        Dim dtadd As New DataTable
        'sqlconn.Open()
        sqlcomm.CommandText = "insert into invoice(customer_code ,item_code,item_quantity ,item_rate,discount,tax,mode_of_payment,price,totalprice,created_date) " _
                        & " values(" + customercode + ",'" + itemcode + "'," + itemquantity + "," + itemrate + "," + discount + "," + tax + ",'" + modeofpayment _
                            + "'," + price + "," + totalprice + ",'" + dateinv + "');"
        sqldr = sqlcomm.ExecuteReader
        dtadd.Load(sqldr)
        'sqlconn.Close()
        Return dtadd
    End Function

    Public Function setitemstructure() As DataTable
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "select null as [Item Code],stk.description as [Prodcut Name],null as [Description],inv.item_rate as [Unit Price]," _
                                        & " inv.item_quantity as [Quantity],null as [Base unit],inv.discount as [Discount],inv.price as [Total Price] from invoice as inv " _
                                        & "inner join tblstock stk on stk.item_code = inv.item_code where 1=0 order by inv.created_date "
        Try
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
        Catch ex As Exception

        End Try
        Return dtadd
    End Function
    Public Function getnextinvoiceno() As String
        Dim dtadd As New DataTable
        sqlcomm.CommandText = "select seq from sqlite_sequence WHERE name = 'invoice'"
        Try
            sqldr = sqlcomm.ExecuteReader
            dtadd.Load(sqldr)
        Catch ex As Exception

        End Try
        Return dtadd(0)(0).ToString
    End Function
End Class

