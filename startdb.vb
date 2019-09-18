Public Class startdb
    Public sqlconn As SQLite.SQLiteConnection
    Public sqlcomm As SQLite.SQLiteCommand
    Public sqldr As SQLite.SQLiteDataReader
    Public cryptoclass As Crypto
    Public Sub New()
        sqlconn = New SQLite.SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;")
        cryptoclass = New Crypto
        sqlconn.Open()
        sqlcomm = sqlconn.CreateCommand
        cryptoclass = New Crypto
    End Sub
    Public Sub execute()
        Dim version As String = Me.GetType.Assembly.GetName.Version.ToString()
        'sqlconn = New SQLite.SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;")
        'sqlconn.Open()
        'sqlcomm = sqlconn.CreateCommand
        If version < "1.0.0.0" Then
            'stock table
            sqlcomm.CommandText = "Create table tblstock(item_code text primary key,item_category text,description text ," _
                        & "unit_quantity real,unit_price real,tax real,discount real,net_price real," _
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
                        & ",item_quantity integer,item_rate real,discount real,tax real,price real,mode_of_payment text,created_date datetime,modified_date)"
            sqlcomm.ExecuteNonQuery()

            sqlcomm.CommandText = "select * from tbllogindetails"
            sqldr = sqlcomm.ExecuteReader
            Dim dt As DataTable = New DataTable()
            dt.Load(sqldr)

        End If
        sqlconn.Close()
    End Sub

End Class
