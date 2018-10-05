Public Class frmBooks
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objdtsBookss As prjctDoReMi.dtsBookss
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblauthor As System.Windows.Forms.Label
    Friend WithEvents lblbookcode As System.Windows.Forms.Label
    Friend WithEvents lblbooktitle As System.Windows.Forms.Label
    Friend WithEvents lblcompocategory As System.Windows.Forms.Label
    Friend WithEvents lblcomposer As System.Windows.Forms.Label
    Friend WithEvents lblcompotitle As System.Windows.Forms.Label
    Friend WithEvents lbledition As System.Windows.Forms.Label
    Friend WithEvents lblepimelitis As System.Windows.Forms.Label
    Friend WithEvents lblgeneralcode As System.Windows.Forms.Label
    Friend WithEvents editauthor As System.Windows.Forms.TextBox
    Friend WithEvents editbookcode As System.Windows.Forms.TextBox
    Friend WithEvents editcompocategory As System.Windows.Forms.TextBox
    Friend WithEvents editcomposer As System.Windows.Forms.TextBox
    Friend WithEvents editcompotitle As System.Windows.Forms.TextBox
    Friend WithEvents editedition As System.Windows.Forms.TextBox
    Friend WithEvents editepimelitis As System.Windows.Forms.TextBox
    Friend WithEvents editgeneralcode As System.Windows.Forms.TextBox
    Friend WithEvents lblgeneralcompotitle As System.Windows.Forms.Label
    Friend WithEvents lblsubcompocategory As System.Windows.Forms.Label
    Friend WithEvents lblsubcompocategory2 As System.Windows.Forms.Label
    Friend WithEvents editsubcompocategory As System.Windows.Forms.TextBox
    Friend WithEvents editsubcompocategory2 As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbookordernumber As System.Windows.Forms.Label
    Friend WithEvents editbookordernumber As System.Windows.Forms.TextBox
    Friend WithEvents lblorders As System.Windows.Forms.Label
    Friend WithEvents lblquantity As System.Windows.Forms.Label
    Friend WithEvents lblsupplier As System.Windows.Forms.Label
    Friend WithEvents editnotes As System.Windows.Forms.TextBox
    Friend WithEvents editorders As System.Windows.Forms.TextBox
    Friend WithEvents editquantity As System.Windows.Forms.TextBox
    Friend WithEvents editsupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblISBN As System.Windows.Forms.Label
    Friend WithEvents editISBN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents editaa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents editgeneralcompotitle As System.Windows.Forms.TextBox
    Friend WithEvents editbooktitle As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand
        Me.objdtsBookss = New prjctDoReMi.dtsBookss
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblauthor = New System.Windows.Forms.Label
        Me.lblbookcode = New System.Windows.Forms.Label
        Me.lblbooktitle = New System.Windows.Forms.Label
        Me.lblcompocategory = New System.Windows.Forms.Label
        Me.lblcomposer = New System.Windows.Forms.Label
        Me.lblcompotitle = New System.Windows.Forms.Label
        Me.lbledition = New System.Windows.Forms.Label
        Me.lblepimelitis = New System.Windows.Forms.Label
        Me.lblgeneralcode = New System.Windows.Forms.Label
        Me.editauthor = New System.Windows.Forms.TextBox
        Me.editbookcode = New System.Windows.Forms.TextBox
        Me.editgeneralcompotitle = New System.Windows.Forms.TextBox
        Me.editcompocategory = New System.Windows.Forms.TextBox
        Me.editcomposer = New System.Windows.Forms.TextBox
        Me.editcompotitle = New System.Windows.Forms.TextBox
        Me.editedition = New System.Windows.Forms.TextBox
        Me.editepimelitis = New System.Windows.Forms.TextBox
        Me.editgeneralcode = New System.Windows.Forms.TextBox
        Me.lblgeneralcompotitle = New System.Windows.Forms.Label
        Me.lblsubcompocategory = New System.Windows.Forms.Label
        Me.lblsubcompocategory2 = New System.Windows.Forms.Label
        Me.editbooktitle = New System.Windows.Forms.TextBox
        Me.editsubcompocategory = New System.Windows.Forms.TextBox
        Me.editsubcompocategory2 = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblbookordernumber = New System.Windows.Forms.Label
        Me.editbookordernumber = New System.Windows.Forms.TextBox
        Me.lblorders = New System.Windows.Forms.Label
        Me.lblquantity = New System.Windows.Forms.Label
        Me.lblsupplier = New System.Windows.Forms.Label
        Me.editorders = New System.Windows.Forms.TextBox
        Me.editquantity = New System.Windows.Forms.TextBox
        Me.editsupplier = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.editnotes = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblISBN = New System.Windows.Forms.Label
        Me.editISBN = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.editaa = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.objdtsBookss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT author, bookcode, bookordernumber, booktitle, compocategory, composer, com" & _
        "potitle, edition, epimelitis, generalcode, generalcompotitle, ISBN, ISMN, notes," & _
        " orders, quantity, subcompocategory, subcompocategory2, supplier FROM tblBooks"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO tblBooks(author, bookcode, bookordernumber, booktitle, compocategory," & _
        " composer, compotitle, edition, epimelitis, generalcode, generalcompotitle, ISBN" & _
        ", ISMN, notes, orders, quantity, subcompocategory, subcompocategory2, supplier) " & _
        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 50, "author"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 50, "booktitle"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 50, "compotitle"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 50, "epimelitis"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcompotitle"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE tblBooks SET author = ?, bookcode = ?, bookordernumber = ?, booktitle = ?," & _
        " compocategory = ?, composer = ?, compotitle = ?, edition = ?, epimelitis = ?, g" & _
        "eneralcode = ?, generalcompotitle = ?, ISBN = ?, ISMN = ?, notes = ?, orders = ?" & _
        ", quantity = ?, subcompocategory = ?, subcompocategory2 = ?, supplier = ? WHERE " & _
        "(generalcode = ?) AND (ISBN = ? OR ? IS NULL AND ISBN IS NULL) AND (ISMN = ? OR " & _
        "? IS NULL AND ISMN IS NULL) AND (author = ? OR ? IS NULL AND author IS NULL) AND" & _
        " (bookcode = ? OR ? IS NULL AND bookcode IS NULL) AND (bookordernumber = ? OR ? " & _
        "IS NULL AND bookordernumber IS NULL) AND (booktitle = ? OR ? IS NULL AND booktit" & _
        "le IS NULL) AND (compocategory = ? OR ? IS NULL AND compocategory IS NULL) AND (" & _
        "composer = ? OR ? IS NULL AND composer IS NULL) AND (compotitle = ? OR ? IS NULL" & _
        " AND compotitle IS NULL) AND (edition = ? OR ? IS NULL AND edition IS NULL) AND " & _
        "(epimelitis = ? OR ? IS NULL AND epimelitis IS NULL) AND (generalcompotitle = ? " & _
        "OR ? IS NULL AND generalcompotitle IS NULL) AND (orders = ? OR ? IS NULL AND ord" & _
        "ers IS NULL) AND (quantity = ? OR ? IS NULL AND quantity IS NULL) AND (subcompoc" & _
        "ategory = ? OR ? IS NULL AND subcompocategory IS NULL) AND (subcompocategory2 = " & _
        "? OR ? IS NULL AND subcompocategory2 IS NULL) AND (supplier = ? OR ? IS NULL AND" & _
        " supplier IS NULL)"
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 50, "author"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 50, "booktitle"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 50, "compotitle"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 50, "epimelitis"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcompotitle"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM tblBooks WHERE (generalcode = ?) AND (ISBN = ? OR ? IS NULL AND ISBN " & _
        "IS NULL) AND (ISMN = ? OR ? IS NULL AND ISMN IS NULL) AND (author = ? OR ? IS NU" & _
        "LL AND author IS NULL) AND (bookcode = ? OR ? IS NULL AND bookcode IS NULL) AND " & _
        "(bookordernumber = ? OR ? IS NULL AND bookordernumber IS NULL) AND (booktitle = " & _
        "? OR ? IS NULL AND booktitle IS NULL) AND (compocategory = ? OR ? IS NULL AND co" & _
        "mpocategory IS NULL) AND (composer = ? OR ? IS NULL AND composer IS NULL) AND (c" & _
        "ompotitle = ? OR ? IS NULL AND compotitle IS NULL) AND (edition = ? OR ? IS NULL" & _
        " AND edition IS NULL) AND (epimelitis = ? OR ? IS NULL AND epimelitis IS NULL) A" & _
        "ND (generalcompotitle = ? OR ? IS NULL AND generalcompotitle IS NULL) AND (order" & _
        "s = ? OR ? IS NULL AND orders IS NULL) AND (quantity = ? OR ? IS NULL AND quanti" & _
        "ty IS NULL) AND (subcompocategory = ? OR ? IS NULL AND subcompocategory IS NULL)" & _
        " AND (subcompocategory2 = ? OR ? IS NULL AND subcompocategory2 IS NULL) AND (sup" & _
        "plier = ? OR ? IS NULL AND supplier IS NULL)"
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT instrument FROM tblInstruments"
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO tblInstruments(instrument) VALUES (?)"
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("instrument", System.Data.OleDb.OleDbType.VarWChar, 50, "instrument"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE tblInstruments SET instrument = ? WHERE (instrument = ?)"
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("instrument", System.Data.OleDb.OleDbType.VarWChar, 50, "instrument"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instrument", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instrument", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM tblInstruments WHERE (instrument = ?)"
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instrument", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instrument", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT instruments, subcategoryInstrument FROM tblSubInstruments"
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO tblSubInstruments(instruments, subcategoryInstrument) VALUES (?, ?)"
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("instruments", System.Data.OleDb.OleDbType.VarWChar, 50, "instruments"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcategoryInstrument", System.Data.OleDb.OleDbType.VarWChar, 50, "subcategoryInstrument"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE tblSubInstruments SET instruments = ?, subcategoryInstrument = ? WHERE (su" & _
        "bcategoryInstrument = ?) AND (instruments = ? OR ? IS NULL AND instruments IS NU" & _
        "LL)"
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("instruments", System.Data.OleDb.OleDbType.VarWChar, 50, "instruments"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcategoryInstrument", System.Data.OleDb.OleDbType.VarWChar, 50, "subcategoryInstrument"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcategoryInstrument", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcategoryInstrument", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instruments", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instruments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instruments1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instruments", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM tblSubInstruments WHERE (subcategoryInstrument = ?) AND (instruments " & _
        "= ? OR ? IS NULL AND instruments IS NULL)"
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcategoryInstrument", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcategoryInstrument", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instruments", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instruments", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_instruments1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "instruments", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT subCategoryInstrument, subCategoryInstrument2 FROM tblSubInstruments2"
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO tblSubInstruments2(subCategoryInstrument, subCategoryInstrument2) VAL" & _
        "UES (?, ?)"
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("subCategoryInstrument", System.Data.OleDb.OleDbType.VarWChar, 50, "subCategoryInstrument"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("subCategoryInstrument2", System.Data.OleDb.OleDbType.VarWChar, 50, "subCategoryInstrument2"))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand5
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand5
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblBooks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("aa", "aa"), New System.Data.Common.DataColumnMapping("author", "author"), New System.Data.Common.DataColumnMapping("bookcode", "bookcode"), New System.Data.Common.DataColumnMapping("bookordernumber", "bookordernumber"), New System.Data.Common.DataColumnMapping("booktitle", "booktitle"), New System.Data.Common.DataColumnMapping("compocategory", "compocategory"), New System.Data.Common.DataColumnMapping("composer", "composer"), New System.Data.Common.DataColumnMapping("compotitle", "compotitle"), New System.Data.Common.DataColumnMapping("edition", "edition"), New System.Data.Common.DataColumnMapping("epimelitis", "epimelitis"), New System.Data.Common.DataColumnMapping("fpa", "fpa"), New System.Data.Common.DataColumnMapping("generalcode", "generalcode"), New System.Data.Common.DataColumnMapping("generalcompotitle", "generalcompotitle"), New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("ISMN", "ISMN"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("orders", "orders"), New System.Data.Common.DataColumnMapping("quantity", "quantity"), New System.Data.Common.DataColumnMapping("subcompocategory", "subcompocategory"), New System.Data.Common.DataColumnMapping("subcompocategory2", "subcompocategory2"), New System.Data.Common.DataColumnMapping("supplier", "supplier"), New System.Data.Common.DataColumnMapping("timiagoras", "timiagoras"), New System.Data.Common.DataColumnMapping("timipolisis", "timipolisis"), New System.Data.Common.DataColumnMapping("Προμηθευτής2", "Προμηθευτής2"), New System.Data.Common.DataColumnMapping("Προμηθευτής3", "Προμηθευτής3")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM tblBooks WHERE (aa = ?) AND (generalcode = ?) AND (ISBN = ? OR ? IS N" & _
        "ULL AND ISBN IS NULL) AND (ISMN = ? OR ? IS NULL AND ISMN IS NULL) AND (author =" & _
        " ? OR ? IS NULL AND author IS NULL) AND (bookcode = ? OR ? IS NULL AND bookcode " & _
        "IS NULL) AND (bookordernumber = ? OR ? IS NULL AND bookordernumber IS NULL) AND " & _
        "(booktitle = ? OR ? IS NULL AND booktitle IS NULL) AND (compocategory = ? OR ? I" & _
        "S NULL AND compocategory IS NULL) AND (composer = ? OR ? IS NULL AND composer IS" & _
        " NULL) AND (compotitle = ? OR ? IS NULL AND compotitle IS NULL) AND (edition = ?" & _
        " OR ? IS NULL AND edition IS NULL) AND (epimelitis = ? OR ? IS NULL AND epimelit" & _
        "is IS NULL) AND (fpa = ? OR ? IS NULL AND fpa IS NULL) AND (generalcompotitle = " & _
        "? OR ? IS NULL AND generalcompotitle IS NULL) AND (orders = ? OR ? IS NULL AND o" & _
        "rders IS NULL) AND (quantity = ? OR ? IS NULL AND quantity IS NULL) AND (subcomp" & _
        "ocategory = ? OR ? IS NULL AND subcompocategory IS NULL) AND (subcompocategory2 " & _
        "= ? OR ? IS NULL AND subcompocategory2 IS NULL) AND (supplier = ? OR ? IS NULL A" & _
        "ND supplier IS NULL) AND (timiagoras = ? OR ? IS NULL AND timiagoras IS NULL) AN" & _
        "D (timipolisis = ? OR ? IS NULL AND timipolisis IS NULL) AND (Προμηθευτής2 = ? O" & _
        "R ? IS NULL AND Προμηθευτής2 IS NULL) AND (Προμηθευτής3 = ? OR ? IS NULL AND Προ" & _
        "μηθευτής3 IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\Program Files\doremi\dbMain.mdb"";Jet OLEDB:Engine " & _
        "Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:S" & _
        "FP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;J" & _
        "et OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB" & _
        ":Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fal" & _
        "se;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO tblBooks(author, bookcode, bookordernumber, booktitle, compocategory," & _
        " composer, compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle," & _
        " ISBN, ISMN, notes, orders, quantity, subcompocategory, subcompocategory2, suppl" & _
        "ier, timiagoras, timipolisis, Προμηθευτής2, Προμηθευτής3) VALUES (?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand5.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 100, "author"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, "booktitle"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "compotitle"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, "epimelitis"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("fpa", System.Data.OleDb.OleDbType.VarWChar, 50, "fpa"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "generalcompotitle"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, "timiagoras"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, "timipolisis"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής2"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής3"))
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT aa, author, bookcode, bookordernumber, booktitle, compocategory, composer," & _
        " compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle, ISBN, ISM" & _
        "N, notes, orders, quantity, subcompocategory, subcompocategory2, supplier, timia" & _
        "goras, timipolisis, Προμηθευτής2, Προμηθευτής3 FROM tblBooks"
        Me.OleDbSelectCommand5.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE tblBooks SET author = ?, bookcode = ?, bookordernumber = ?, booktitle = ?," & _
        " compocategory = ?, composer = ?, compotitle = ?, edition = ?, epimelitis = ?, f" & _
        "pa = ?, generalcode = ?, generalcompotitle = ?, ISBN = ?, ISMN = ?, notes = ?, o" & _
        "rders = ?, quantity = ?, subcompocategory = ?, subcompocategory2 = ?, supplier =" & _
        " ?, timiagoras = ?, timipolisis = ?, Προμηθευτής2 = ?, Προμηθευτής3 = ? WHERE (a" & _
        "a = ?) AND (generalcode = ?) AND (ISBN = ? OR ? IS NULL AND ISBN IS NULL) AND (I" & _
        "SMN = ? OR ? IS NULL AND ISMN IS NULL) AND (author = ? OR ? IS NULL AND author I" & _
        "S NULL) AND (bookcode = ? OR ? IS NULL AND bookcode IS NULL) AND (bookordernumbe" & _
        "r = ? OR ? IS NULL AND bookordernumber IS NULL) AND (booktitle = ? OR ? IS NULL " & _
        "AND booktitle IS NULL) AND (compocategory = ? OR ? IS NULL AND compocategory IS " & _
        "NULL) AND (composer = ? OR ? IS NULL AND composer IS NULL) AND (compotitle = ? O" & _
        "R ? IS NULL AND compotitle IS NULL) AND (edition = ? OR ? IS NULL AND edition IS" & _
        " NULL) AND (epimelitis = ? OR ? IS NULL AND epimelitis IS NULL) AND (fpa = ? OR " & _
        "? IS NULL AND fpa IS NULL) AND (generalcompotitle = ? OR ? IS NULL AND generalco" & _
        "mpotitle IS NULL) AND (orders = ? OR ? IS NULL AND orders IS NULL) AND (quantity" & _
        " = ? OR ? IS NULL AND quantity IS NULL) AND (subcompocategory = ? OR ? IS NULL A" & _
        "ND subcompocategory IS NULL) AND (subcompocategory2 = ? OR ? IS NULL AND subcomp" & _
        "ocategory2 IS NULL) AND (supplier = ? OR ? IS NULL AND supplier IS NULL) AND (ti" & _
        "miagoras = ? OR ? IS NULL AND timiagoras IS NULL) AND (timipolisis = ? OR ? IS N" & _
        "ULL AND timipolisis IS NULL) AND (Προμηθευτής2 = ? OR ? IS NULL AND Προμηθευτής2" & _
        " IS NULL) AND (Προμηθευτής3 = ? OR ? IS NULL AND Προμηθευτής3 IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 100, "author"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, "booktitle"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "compotitle"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, "epimelitis"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("fpa", System.Data.OleDb.OleDbType.VarWChar, 50, "fpa"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "generalcompotitle"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, "timiagoras"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, "timipolisis"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής3"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtsBookss
        '
        Me.objdtsBookss.DataSetName = "dtsBookss"
        Me.objdtsBookss.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(192, 16)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(136, 32)
        Me.btnUpdate.TabIndex = 41
        Me.btnUpdate.Text = "Ενημέρωση Βάσης"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(408, 16)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(136, 32)
        Me.btnCancelAll.TabIndex = 42
        Me.btnCancelAll.Text = "Ακύρωση Αλλαγών"
        '
        'lblauthor
        '
        Me.lblauthor.Location = New System.Drawing.Point(264, 184)
        Me.lblauthor.Name = "lblauthor"
        Me.lblauthor.TabIndex = 3
        Me.lblauthor.Text = "Συγγραφέας *"
        Me.lblauthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblbookcode
        '
        Me.lblbookcode.Location = New System.Drawing.Point(24, 184)
        Me.lblbookcode.Name = "lblbookcode"
        Me.lblbookcode.TabIndex = 4
        Me.lblbookcode.Text = "Κωδικός Βιβλίου *"
        Me.lblbookcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblbooktitle
        '
        Me.lblbooktitle.Location = New System.Drawing.Point(24, 56)
        Me.lblbooktitle.Name = "lblbooktitle"
        Me.lblbooktitle.TabIndex = 6
        Me.lblbooktitle.Text = "Τίτλος Βιβλίου *"
        Me.lblbooktitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcompocategory
        '
        Me.lblcompocategory.Location = New System.Drawing.Point(512, 152)
        Me.lblcompocategory.Name = "lblcompocategory"
        Me.lblcompocategory.TabIndex = 7
        Me.lblcompocategory.Text = "Κατηγορία *"
        Me.lblcompocategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcomposer
        '
        Me.lblcomposer.Location = New System.Drawing.Point(264, 152)
        Me.lblcomposer.Name = "lblcomposer"
        Me.lblcomposer.TabIndex = 8
        Me.lblcomposer.Text = "Συνθέτης *"
        Me.lblcomposer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcompotitle
        '
        Me.lblcompotitle.Location = New System.Drawing.Point(276, 120)
        Me.lblcompotitle.Name = "lblcompotitle"
        Me.lblcompotitle.Size = New System.Drawing.Size(88, 23)
        Me.lblcompotitle.TabIndex = 9
        Me.lblcompotitle.Text = "Τίτλος Έργου *"
        Me.lblcompotitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbledition
        '
        Me.lbledition.Location = New System.Drawing.Point(24, 216)
        Me.lbledition.Name = "lbledition"
        Me.lbledition.TabIndex = 10
        Me.lbledition.Text = "Έκδοση *"
        Me.lbledition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblepimelitis
        '
        Me.lblepimelitis.Location = New System.Drawing.Point(600, 232)
        Me.lblepimelitis.Name = "lblepimelitis"
        Me.lblepimelitis.TabIndex = 11
        Me.lblepimelitis.Text = "Επιμελητής"
        Me.lblepimelitis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblgeneralcode
        '
        Me.lblgeneralcode.Location = New System.Drawing.Point(24, 152)
        Me.lblgeneralcode.Name = "lblgeneralcode"
        Me.lblgeneralcode.TabIndex = 12
        Me.lblgeneralcode.Text = "Γενικός Κωδικός *"
        Me.lblgeneralcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editauthor
        '
        Me.editauthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.author"))
        Me.editauthor.Location = New System.Drawing.Point(376, 184)
        Me.editauthor.Name = "editauthor"
        Me.editauthor.Size = New System.Drawing.Size(128, 20)
        Me.editauthor.TabIndex = 9
        Me.editauthor.Text = ""
        '
        'editbookcode
        '
        Me.editbookcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.bookcode"))
        Me.editbookcode.Location = New System.Drawing.Point(136, 184)
        Me.editbookcode.Name = "editbookcode"
        Me.editbookcode.Size = New System.Drawing.Size(120, 20)
        Me.editbookcode.TabIndex = 4
        Me.editbookcode.Text = ""
        '
        'editgeneralcompotitle
        '
        Me.editgeneralcompotitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.generalcompotitle"))
        Me.editgeneralcompotitle.Location = New System.Drawing.Point(376, 88)
        Me.editgeneralcompotitle.MaxLength = 249
        Me.editgeneralcompotitle.Name = "editgeneralcompotitle"
        Me.editgeneralcompotitle.Size = New System.Drawing.Size(352, 20)
        Me.editgeneralcompotitle.TabIndex = 6
        Me.editgeneralcompotitle.Text = ""
        '
        'editcompocategory
        '
        Me.editcompocategory.BackColor = System.Drawing.SystemColors.HighlightText
        Me.editcompocategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.compocategory"))
        Me.editcompocategory.Location = New System.Drawing.Point(624, 152)
        Me.editcompocategory.Name = "editcompocategory"
        Me.editcompocategory.TabIndex = 11
        Me.editcompocategory.Text = ""
        '
        'editcomposer
        '
        Me.editcomposer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.composer"))
        Me.editcomposer.Location = New System.Drawing.Point(376, 152)
        Me.editcomposer.Name = "editcomposer"
        Me.editcomposer.Size = New System.Drawing.Size(128, 20)
        Me.editcomposer.TabIndex = 8
        Me.editcomposer.Text = ""
        '
        'editcompotitle
        '
        Me.editcompotitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.compotitle"))
        Me.editcompotitle.Location = New System.Drawing.Point(376, 120)
        Me.editcompotitle.MaxLength = 120
        Me.editcompotitle.Name = "editcompotitle"
        Me.editcompotitle.Size = New System.Drawing.Size(352, 20)
        Me.editcompotitle.TabIndex = 7
        Me.editcompotitle.Text = ""
        '
        'editedition
        '
        Me.editedition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.edition"))
        Me.editedition.Location = New System.Drawing.Point(136, 216)
        Me.editedition.Name = "editedition"
        Me.editedition.Size = New System.Drawing.Size(120, 20)
        Me.editedition.TabIndex = 5
        Me.editedition.Text = ""
        '
        'editepimelitis
        '
        Me.editepimelitis.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.epimelitis"))
        Me.editepimelitis.Location = New System.Drawing.Point(376, 216)
        Me.editepimelitis.Name = "editepimelitis"
        Me.editepimelitis.Size = New System.Drawing.Size(128, 20)
        Me.editepimelitis.TabIndex = 10
        Me.editepimelitis.Text = ""
        '
        'editgeneralcode
        '
        Me.editgeneralcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.generalcode"))
        Me.editgeneralcode.Location = New System.Drawing.Point(136, 152)
        Me.editgeneralcode.Name = "editgeneralcode"
        Me.editgeneralcode.Size = New System.Drawing.Size(120, 20)
        Me.editgeneralcode.TabIndex = 3
        Me.editgeneralcode.Text = ""
        '
        'lblgeneralcompotitle
        '
        Me.lblgeneralcompotitle.Location = New System.Drawing.Point(264, 80)
        Me.lblgeneralcompotitle.Name = "lblgeneralcompotitle"
        Me.lblgeneralcompotitle.Size = New System.Drawing.Size(100, 32)
        Me.lblgeneralcompotitle.TabIndex = 23
        Me.lblgeneralcompotitle.Text = "Είδος *"
        Me.lblgeneralcompotitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsubcompocategory
        '
        Me.lblsubcompocategory.Location = New System.Drawing.Point(512, 184)
        Me.lblsubcompocategory.Name = "lblsubcompocategory"
        Me.lblsubcompocategory.TabIndex = 29
        Me.lblsubcompocategory.Text = "Υποκατηγορία 1 *"
        Me.lblsubcompocategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsubcompocategory2
        '
        Me.lblsubcompocategory2.Location = New System.Drawing.Point(512, 216)
        Me.lblsubcompocategory2.Name = "lblsubcompocategory2"
        Me.lblsubcompocategory2.TabIndex = 30
        Me.lblsubcompocategory2.Text = "Υποκατηγορία 2 *"
        Me.lblsubcompocategory2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editbooktitle
        '
        Me.editbooktitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.booktitle"))
        Me.editbooktitle.Location = New System.Drawing.Point(136, 56)
        Me.editbooktitle.MaxLength = 149
        Me.editbooktitle.Name = "editbooktitle"
        Me.editbooktitle.Size = New System.Drawing.Size(592, 20)
        Me.editbooktitle.TabIndex = 0
        Me.editbooktitle.Text = ""
        '
        'editsubcompocategory
        '
        Me.editsubcompocategory.BackColor = System.Drawing.SystemColors.HighlightText
        Me.editsubcompocategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.subcompocategory"))
        Me.editsubcompocategory.Location = New System.Drawing.Point(624, 184)
        Me.editsubcompocategory.Name = "editsubcompocategory"
        Me.editsubcompocategory.TabIndex = 13
        Me.editsubcompocategory.Text = ""
        '
        'editsubcompocategory2
        '
        Me.editsubcompocategory2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.editsubcompocategory2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.subcompocategory2"))
        Me.editsubcompocategory2.Location = New System.Drawing.Point(624, 216)
        Me.editsubcompocategory2.Name = "editsubcompocategory2"
        Me.editsubcompocategory2.TabIndex = 15
        Me.editsubcompocategory2.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(248, 456)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 41
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(288, 456)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 42
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(320, 456)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 43
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(416, 456)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 44
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 456)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 45
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(248, 488)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 38
        Me.btnAdd.Text = "Εισαγωγή"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(336, 488)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Διαγραφή"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(424, 488)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Ακύρωση"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button1.Location = New System.Drawing.Point(728, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "..."
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button2.Location = New System.Drawing.Point(728, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "..."
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Button3.Location = New System.Drawing.Point(728, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.lblbookordernumber)
        Me.GroupBox1.Controls.Add(Me.editbookordernumber)
        Me.GroupBox1.Controls.Add(Me.lblorders)
        Me.GroupBox1.Controls.Add(Me.lblquantity)
        Me.GroupBox1.Controls.Add(Me.lblsupplier)
        Me.GroupBox1.Controls.Add(Me.editorders)
        Me.GroupBox1.Controls.Add(Me.editquantity)
        Me.GroupBox1.Controls.Add(Me.editsupplier)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 184)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(544, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 104)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Συντελεστής"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.fpa"))
        Me.TextBox6.Location = New System.Drawing.Point(40, 80)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 20)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Τιμή Αγοράς"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.timiagoras"))
        Me.TextBox4.Location = New System.Drawing.Point(16, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(96, 20)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = ""
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(536, 136)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 24)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "..."
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(592, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Τιμή Πώλησης"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.timipolisis"))
        Me.TextBox5.Location = New System.Drawing.Point(576, 136)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Προμηθευτής3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Προμηθευτής2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.Προμηθευτής3"))
        Me.TextBox3.Location = New System.Drawing.Point(96, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 120)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Προσθήκη"
        Me.GroupBox2.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Προσθήκη Ποσότητας"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(128, 80)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 24)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "’κυρο"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(24, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 24)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "ΟΚ"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(448, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 24)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Προσθήκη"
        '
        'lblbookordernumber
        '
        Me.lblbookordernumber.Location = New System.Drawing.Point(8, 128)
        Me.lblbookordernumber.Name = "lblbookordernumber"
        Me.lblbookordernumber.Size = New System.Drawing.Size(120, 32)
        Me.lblbookordernumber.TabIndex = 41
        Me.lblbookordernumber.Text = "Αριθμός Παραγγελίας"
        Me.lblbookordernumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editbookordernumber
        '
        Me.editbookordernumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.bookordernumber"))
        Me.editbookordernumber.Location = New System.Drawing.Point(144, 136)
        Me.editbookordernumber.Name = "editbookordernumber"
        Me.editbookordernumber.Size = New System.Drawing.Size(104, 20)
        Me.editbookordernumber.TabIndex = 3
        Me.editbookordernumber.Text = ""
        '
        'lblorders
        '
        Me.lblorders.Location = New System.Drawing.Point(288, 40)
        Me.lblorders.Name = "lblorders"
        Me.lblorders.Size = New System.Drawing.Size(72, 23)
        Me.lblorders.TabIndex = 44
        Me.lblorders.Text = "Παραγγελίες"
        Me.lblorders.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblquantity
        '
        Me.lblquantity.Location = New System.Drawing.Point(296, 72)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(64, 23)
        Me.lblquantity.TabIndex = 45
        Me.lblquantity.Text = "Ποσότητα"
        Me.lblquantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsupplier
        '
        Me.lblsupplier.Location = New System.Drawing.Point(8, 40)
        Me.lblsupplier.Name = "lblsupplier"
        Me.lblsupplier.Size = New System.Drawing.Size(88, 16)
        Me.lblsupplier.TabIndex = 46
        Me.lblsupplier.Text = "Προμηθευτής *"
        Me.lblsupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'editorders
        '
        Me.editorders.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.orders"))
        Me.editorders.Location = New System.Drawing.Point(376, 40)
        Me.editorders.Name = "editorders"
        Me.editorders.Size = New System.Drawing.Size(144, 20)
        Me.editorders.TabIndex = 4
        Me.editorders.Text = ""
        '
        'editquantity
        '
        Me.editquantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.quantity"))
        Me.editquantity.Location = New System.Drawing.Point(376, 72)
        Me.editquantity.Name = "editquantity"
        Me.editquantity.Size = New System.Drawing.Size(64, 20)
        Me.editquantity.TabIndex = 5
        Me.editquantity.Text = ""
        '
        'editsupplier
        '
        Me.editsupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.supplier"))
        Me.editsupplier.Location = New System.Drawing.Point(96, 40)
        Me.editsupplier.Name = "editsupplier"
        Me.editsupplier.Size = New System.Drawing.Size(192, 20)
        Me.editsupplier.TabIndex = 0
        Me.editsupplier.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.Προμηθευτής2"))
        Me.TextBox2.Location = New System.Drawing.Point(96, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(408, 120)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 32)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Σημειώσεις"
        '
        'editnotes
        '
        Me.editnotes.AutoSize = False
        Me.editnotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.notes"))
        Me.editnotes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editnotes.Location = New System.Drawing.Point(8, 24)
        Me.editnotes.Multiline = True
        Me.editnotes.Name = "editnotes"
        Me.editnotes.Size = New System.Drawing.Size(736, 368)
        Me.editnotes.TabIndex = 0
        Me.editnotes.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "(Τα πεδία με αστερίσκο πρέπει να συμπληρωθούν υποχρεωτικά)"
        '
        'lblISBN
        '
        Me.lblISBN.Location = New System.Drawing.Point(24, 88)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.TabIndex = 56
        Me.lblISBN.Text = "ISBN / ISMN *"
        Me.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editISBN
        '
        Me.editISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.ISBN"))
        Me.editISBN.Location = New System.Drawing.Point(136, 88)
        Me.editISBN.Name = "editISBN"
        Me.editISBN.Size = New System.Drawing.Size(120, 20)
        Me.editISBN.TabIndex = 1
        Me.editISBN.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.editnotes)
        Me.GroupBox4.Controls.Add(Me.lblepimelitis)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 440)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Σημειώσεις"
        Me.GroupBox4.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(320, 400)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 32)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Επιστροφή"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "ISBN / ISMN 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.ISMN"))
        Me.TextBox7.Location = New System.Drawing.Point(136, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 20)
        Me.TextBox7.TabIndex = 2
        Me.TextBox7.Text = ""
        '
        'editaa
        '
        Me.editaa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsBookss, "tblBooks.aa"))
        Me.editaa.Location = New System.Drawing.Point(32, 480)
        Me.editaa.Name = "editaa"
        Me.editaa.Size = New System.Drawing.Size(32, 20)
        Me.editaa.TabIndex = 57
        Me.editaa.Text = ""
        Me.editaa.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "aa"
        Me.Label9.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Διαχείριση Βιβλίων"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Κλείσιμο"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Location = New System.Drawing.Point(616, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 96)
        Me.GroupBox5.TabIndex = 60
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(40, 64)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(64, 24)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "ΟΚ"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 32)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Οι κατηγορίες έχουν αλλάξει"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBooks
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 542)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.editaa)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.editISBN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblauthor)
        Me.Controls.Add(Me.lblbookcode)
        Me.Controls.Add(Me.lblbooktitle)
        Me.Controls.Add(Me.lblcompocategory)
        Me.Controls.Add(Me.lblcomposer)
        Me.Controls.Add(Me.lblcompotitle)
        Me.Controls.Add(Me.lbledition)
        Me.Controls.Add(Me.lblgeneralcode)
        Me.Controls.Add(Me.editauthor)
        Me.Controls.Add(Me.editbookcode)
        Me.Controls.Add(Me.editgeneralcompotitle)
        Me.Controls.Add(Me.editcompocategory)
        Me.Controls.Add(Me.editcomposer)
        Me.Controls.Add(Me.editcompotitle)
        Me.Controls.Add(Me.editedition)
        Me.Controls.Add(Me.editepimelitis)
        Me.Controls.Add(Me.editgeneralcode)
        Me.Controls.Add(Me.lblgeneralcompotitle)
        Me.Controls.Add(Me.lblsubcompocategory)
        Me.Controls.Add(Me.lblsubcompocategory2)
        Me.Controls.Add(Me.editbooktitle)
        Me.Controls.Add(Me.editsubcompocategory)
        Me.Controls.Add(Me.editsubcompocategory2)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Βιβλία"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsBookss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsBookss, "tblBooks").CancelCurrentEdit()
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsBookss, "tblBooks").Count > 0) Then
            Me.BindingContext(objdtsBookss, "tblBooks").RemoveAt(Me.BindingContext(objdtsBookss, "tblBooks").Position)
            Me.objdtsBookss_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsBookss, "tblBooks").EndCurrentEdit()
            Me.BindingContext(objdtsBookss, "tblBooks").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If editsupplier.Text = "" Or editedition.Text = "" Or editbookcode.Text = "" Or editgeneralcode.Text = "" Or editcompotitle.Text = "" Or editgeneralcompotitle.Text = "" Or editbooktitle.Text = "" Or editcomposer.Text = "" Or editauthor.Text = "" Or editcompocategory.Text = "" Or editsubcompocategory.Text = "" Or editsubcompocategory2.Text = "" Or editISBN.Text = "" Then GoTo exitt
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsBookss_PositionChanged()
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsBookss_PositionChanged()
        Exit Sub
exitt:
        MsgBox("Πιθανόν να έχετε αφήσει κενά κάποια απαραίτητα πεδία στην τρέχουσα εγγραφή. Παρακαλώ ελέγξτε ξανά την καταχώρηση.(Τα πεδία με αστερίσκο πρέπει να συμπληρωθούν υποχρεωτικά)")

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsBookss, "tblBooks").Position = 0
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsBookss, "tblBooks").Position = (Me.objdtsBookss.Tables("tblBooks").Rows.Count - 1)
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsBookss, "tblBooks").Position = (Me.BindingContext(objdtsBookss, "tblBooks").Position - 1)
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsBookss, "tblBooks").Position = (Me.BindingContext(objdtsBookss, "tblBooks").Position + 1)
        Me.objdtsBookss_PositionChanged()

    End Sub
    Private Sub objdtsBookss_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsBookss, "tblBooks").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsBookss, "tblBooks").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsBookss.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsBookss = New prjctDoReMi.dtsBookss
        'Stop any current edits.
        Me.BindingContext(objdtsBookss, "tblBooks").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsBookss.GetChanges, prjctDoReMi.dtsBookss)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsBookss.Merge(objDataSetChanges)
                objdtsBookss.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As prjctDoReMi.dtsBookss
        objDataSetTemp = New prjctDoReMi.dtsBookss
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsBookss.Clear()
            'Merge the records into the main dataset.
            objdtsBookss.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsBookss)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsBookss)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Add your error handling code here.
            Throw fillException
        Finally
            'Turn constraint checking back on.
            dataSet.EnforceConstraints = True
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Module1.varTempStr = ""
        Module1.varTempStr2 = ""
        Module1.varTempStr3 = ""
        GroupBox5.Visible = True
        Module1.categoryflag = False
        'End If

        Dim frmopen As New frmSmallInstr
        frmopen.MdiParent = prjctDoReMi.frmMain.ActiveForm
        frmopen.Show()

    End Sub

    Private Sub frmBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)
        Module1.varTempStr = ""
        Module1.varTempStr2 = ""
        Module1.varTempStr3 = ""
        If Module1.bookanal = True Then
            Dim varsql As New OleDb.OleDbCommand("select * from tblbooks where aa like '" & Int(Module1.varbooktemp) & "' ;", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
            Module1.bookanal = False
        End If

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsBookss_PositionChanged()
    End Sub

    Private Sub frmBooks_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
        If Module1.categoryflag = True Then
            editcompocategory.Text = Module1.varTempStr
            editsubcompocategory.Text = Module1.varTempStr2
            If editcompocategory.Text <> "" And editsubcompocategory.Text <> "" Then
                editsubcompocategory2.Text = Module1.varTempStr3
            Else
                editsubcompocategory2.Text = ""
            End If
            Module1.categoryflag = False
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Module1.varTempStr2 = ""
        Module1.varTempStr3 = ""
        GroupBox5.Visible = True
        Module1.categoryflag = False
        'End If
        Dim frmopen As New frmSmallSubInstr
        Module1.vartempsql = editcompocategory.Text
        frmopen.MdiParent = prjctDoReMi.frmMain.ActiveForm
        frmopen.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox5.Visible = True
        'End If
        Dim frmopen As New frmsmallsubinstr2
        Module1.vartempsql2 = editsubcompocategory.Text
        frmopen.MdiParent = prjctDoReMi.frmMain.ActiveForm
        frmopen.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error GoTo mistake

        editquantity.Text = Val(editquantity.Text) + Val(TextBox1.Text)
        GroupBox2.Visible = False
        Exit Sub

mistake:
        MsgBox("Υπάρχει κάποιο πρόβλημα ή κάποια λανθασμένη καταχώρηση στην συγκεκριμένη κίνηση. Παρακαλώ ξαναπροσπαθήστε.")


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox2.Visible = True
        TextBox1.Focus()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub editbookordernumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editbookordernumber.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If GroupBox3.Visible = False Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GroupBox4.Visible = False
        GroupBox4.SendToBack()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        GroupBox4.Visible = True
        GroupBox4.BringToFront()
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub frmBooks_MenuStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MenuStart

    End Sub

    Private Sub frmBooks_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Module1.categoryflag = True Then
            editcompocategory.Text = Module1.varTempStr
            editsubcompocategory.Text = Module1.varTempStr2
            If editcompocategory.Text <> "" And editsubcompocategory.Text <> "" Then
                editsubcompocategory2.Text = Module1.varTempStr3
            Else
                editsubcompocategory2.Text = ""
            End If
            Module1.categoryflag = False
        End If
    End Sub

    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
        'If Module1.categoryflag = True Then
        editcompocategory.Text = Module1.varTempStr
        editsubcompocategory.Text = Module1.varTempStr2
        If editcompocategory.Text <> "" And editsubcompocategory.Text <> "" Then
            editsubcompocategory2.Text = Module1.varTempStr3
        Else
            editsubcompocategory2.Text = ""
        End If
        Module1.categoryflag = False
        'End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.WindowState = FormWindowState.Maximized
        'If Module1.categoryflag = True Then
        editcompocategory.Text = Module1.varTempStr
        editsubcompocategory.Text = Module1.varTempStr2
        If editcompocategory.Text <> "" And editsubcompocategory.Text <> "" Then
            editsubcompocategory2.Text = Module1.varTempStr3
        Else
            editsubcompocategory2.Text = ""
        End If
        Module1.categoryflag = False
        'End If
        GroupBox5.Visible = False

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox5.Visible = False

    End Sub
End Class
