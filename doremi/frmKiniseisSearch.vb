Public Class frmKiniseisSearch
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
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objdtsKiniseisSrch As prjctDoReMi.dtsKiniseisSrch
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblΕπώνυμο As System.Windows.Forms.Label
    Friend WithEvents editΕπώνυμο As System.Windows.Forms.TextBox
    Friend WithEvents lblΌνομα As System.Windows.Forms.Label
    Friend WithEvents editΌνομα As System.Windows.Forms.TextBox
    Friend WithEvents lblΔιεύθυνση As System.Windows.Forms.Label
    Friend WithEvents editΔιεύθυνση As System.Windows.Forms.TextBox
    Friend WithEvents lblΤηλέφωνο As System.Windows.Forms.Label
    Friend WithEvents editΤηλέφωνο As System.Windows.Forms.TextBox
    Friend WithEvents lblΚινητό As System.Windows.Forms.Label
    Friend WithEvents editΚινητό As System.Windows.Forms.TextBox
    Friend WithEvents lblΕπάγγελμα As System.Windows.Forms.Label
    Friend WithEvents editΕπάγγελμα As System.Windows.Forms.TextBox
    Friend WithEvents lblΑΦΜ As System.Windows.Forms.Label
    Friend WithEvents lblΔΟΥ As System.Windows.Forms.Label
    Friend WithEvents editΑΦΜ As System.Windows.Forms.TextBox
    Friend WithEvents editΔΟΥ As System.Windows.Forms.TextBox
    Friend WithEvents lblΚωδικός_Βιβλίου As System.Windows.Forms.Label
    Friend WithEvents editΚωδικός_Βιβλίου As System.Windows.Forms.TextBox
    Friend WithEvents lblΤίτλος_Βιβλίου As System.Windows.Forms.Label
    Friend WithEvents editΤίτλος_Βιβλίου As System.Windows.Forms.TextBox
    Friend WithEvents lblΣυνθέτης As System.Windows.Forms.Label
    Friend WithEvents editΣυνθέτης As System.Windows.Forms.TextBox
    Friend WithEvents lblΣυγγραφέας As System.Windows.Forms.Label
    Friend WithEvents editΣυγγραφέας As System.Windows.Forms.TextBox
    Friend WithEvents lblΈκδοση As System.Windows.Forms.Label
    Friend WithEvents editΈκδοση As System.Windows.Forms.TextBox
    Friend WithEvents lblΌργανο As System.Windows.Forms.Label
    Friend WithEvents editΌργανο As System.Windows.Forms.TextBox
    Friend WithEvents lblΗμερομηνία As System.Windows.Forms.Label
    Friend WithEvents editΗμερομηνία As System.Windows.Forms.TextBox
    Friend WithEvents lblΠοσότητα As System.Windows.Forms.Label
    Friend WithEvents lblΤιμή_Προσφοράς As System.Windows.Forms.Label
    Friend WithEvents editΠοσότητα As System.Windows.Forms.TextBox
    Friend WithEvents editΤιμή_Προσφοράς As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.objdtsKiniseisSrch = New prjctDoReMi.dtsKiniseisSrch
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblΑΦΜ = New System.Windows.Forms.Label
        Me.lblΔΟΥ = New System.Windows.Forms.Label
        Me.editΑΦΜ = New System.Windows.Forms.TextBox
        Me.editΔΟΥ = New System.Windows.Forms.TextBox
        Me.lblΕπάγγελμα = New System.Windows.Forms.Label
        Me.editΕπάγγελμα = New System.Windows.Forms.TextBox
        Me.lblΚινητό = New System.Windows.Forms.Label
        Me.editΚινητό = New System.Windows.Forms.TextBox
        Me.lblΤηλέφωνο = New System.Windows.Forms.Label
        Me.editΤηλέφωνο = New System.Windows.Forms.TextBox
        Me.lblΔιεύθυνση = New System.Windows.Forms.Label
        Me.editΔιεύθυνση = New System.Windows.Forms.TextBox
        Me.lblΌνομα = New System.Windows.Forms.Label
        Me.editΌνομα = New System.Windows.Forms.TextBox
        Me.lblΕπώνυμο = New System.Windows.Forms.Label
        Me.editΕπώνυμο = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblΗμερομηνία = New System.Windows.Forms.Label
        Me.editΗμερομηνία = New System.Windows.Forms.TextBox
        Me.lblΠοσότητα = New System.Windows.Forms.Label
        Me.lblΤιμή_Προσφοράς = New System.Windows.Forms.Label
        Me.editΠοσότητα = New System.Windows.Forms.TextBox
        Me.editΤιμή_Προσφοράς = New System.Windows.Forms.TextBox
        Me.lblΌργανο = New System.Windows.Forms.Label
        Me.editΌργανο = New System.Windows.Forms.TextBox
        Me.lblΈκδοση = New System.Windows.Forms.Label
        Me.editΈκδοση = New System.Windows.Forms.TextBox
        Me.lblΣυγγραφέας = New System.Windows.Forms.Label
        Me.editΣυγγραφέας = New System.Windows.Forms.TextBox
        Me.lblΣυνθέτης = New System.Windows.Forms.Label
        Me.editΣυνθέτης = New System.Windows.Forms.TextBox
        Me.lblΤίτλος_Βιβλίου = New System.Windows.Forms.Label
        Me.editΤίτλος_Βιβλίου = New System.Windows.Forms.TextBox
        Me.lblΚωδικός_Βιβλίου = New System.Windows.Forms.Label
        Me.editΚωδικός_Βιβλίου = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button4 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        CType(Me.objdtsKiniseisSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Κινήσεις", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("αρίθμησηεγγραφών", "αρίθμησηεγγραφών"), New System.Data.Common.DataColumnMapping("ΑΦΜ", "ΑΦΜ"), New System.Data.Common.DataColumnMapping("Διεύθυνση", "Διεύθυνση"), New System.Data.Common.DataColumnMapping("ΔΟΥ", "ΔΟΥ"), New System.Data.Common.DataColumnMapping("Έκδοση", "Έκδοση"), New System.Data.Common.DataColumnMapping("Επάγγελμα", "Επάγγελμα"), New System.Data.Common.DataColumnMapping("Επώνυμο", "Επώνυμο"), New System.Data.Common.DataColumnMapping("Ημερομηνία", "Ημερομηνία"), New System.Data.Common.DataColumnMapping("Κινητό", "Κινητό"), New System.Data.Common.DataColumnMapping("Κωδικός Βιβλίου", "Κωδικός Βιβλίου"), New System.Data.Common.DataColumnMapping("Όνομα", "Όνομα"), New System.Data.Common.DataColumnMapping("Όργανο", "Όργανο"), New System.Data.Common.DataColumnMapping("Ποσότητα", "Ποσότητα"), New System.Data.Common.DataColumnMapping("Συγγραφέας", "Συγγραφέας"), New System.Data.Common.DataColumnMapping("Συνθέτης", "Συνθέτης"), New System.Data.Common.DataColumnMapping("Τηλέφωνο", "Τηλέφωνο"), New System.Data.Common.DataColumnMapping("Τιμή Προσφοράς", "Τιμή Προσφοράς"), New System.Data.Common.DataColumnMapping("Τίτλος Βιβλίου", "Τίτλος Βιβλίου")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Κινήσεις WHERE (αρίθμησηεγγραφών = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_αρίθμησηεγγραφών", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "αρίθμησηεγγραφών", System.Data.DataRowVersion.Original, Nothing))
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
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Κινήσεις(ISBN, ΑΦΜ, Διεύθυνση, ΔΟΥ, Έκδοση, Επάγγελμα, Επώνυμο, Ημερο" & _
        "μηνία, Κινητό, [Κωδικός Βιβλίου], Όνομα, Όργανο, Ποσότητα, Συγγραφέας, Συνθέτης," & _
        " Τηλέφωνο, [Τιμή Προσφοράς], [Τίτλος Βιβλίου]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 10, "ΑΦΜ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Διεύθυνση", System.Data.OleDb.OleDbType.VarWChar, 50, "Διεύθυνση"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 20, "ΔΟΥ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Έκδοση", System.Data.OleDb.OleDbType.VarWChar, 30, "Έκδοση"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 30, "Επάγγελμα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επώνυμο", System.Data.OleDb.OleDbType.VarWChar, 30, "Επώνυμο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ημερομηνία", System.Data.OleDb.OleDbType.DBDate, 0, "Ημερομηνία"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κινητό", System.Data.OleDb.OleDbType.VarWChar, 15, "Κινητό"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κωδικός_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 20, "Κωδικός Βιβλίου"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όνομα", System.Data.OleDb.OleDbType.VarWChar, 30, "Όνομα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όργανο", System.Data.OleDb.OleDbType.VarWChar, 20, "Όργανο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ποσότητα", System.Data.OleDb.OleDbType.Integer, 0, "Ποσότητα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συγγραφέας", System.Data.OleDb.OleDbType.VarWChar, 30, "Συγγραφέας"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συνθέτης", System.Data.OleDb.OleDbType.VarWChar, 30, "Συνθέτης"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 15, "Τηλέφωνο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τιμή_Προσφοράς", System.Data.OleDb.OleDbType.Single, 0, "Τιμή Προσφοράς"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τίτλος_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 50, "Τίτλος Βιβλίου"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ISBN, αρίθμησηεγγραφών, ΑΦΜ, Διεύθυνση, ΔΟΥ, Έκδοση, Επάγγελμα, Επώνυμο, Η" & _
        "μερομηνία, Κινητό, [Κωδικός Βιβλίου], Όνομα, Όργανο, Ποσότητα, Συγγραφέας, Συνθέ" & _
        "της, Τηλέφωνο, [Τιμή Προσφοράς], [Τίτλος Βιβλίου] FROM Κινήσεις"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Κινήσεις SET ISBN = ?, ΑΦΜ = ?, Διεύθυνση = ?, ΔΟΥ = ?, Έκδοση = ?, Επάγγε" & _
        "λμα = ?, Επώνυμο = ?, Ημερομηνία = ?, Κινητό = ?, [Κωδικός Βιβλίου] = ?, Όνομα =" & _
        " ?, Όργανο = ?, Ποσότητα = ?, Συγγραφέας = ?, Συνθέτης = ?, Τηλέφωνο = ?, [Τιμή " & _
        "Προσφοράς] = ?, [Τίτλος Βιβλίου] = ? WHERE (αρίθμησηεγγραφών = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 10, "ΑΦΜ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Διεύθυνση", System.Data.OleDb.OleDbType.VarWChar, 50, "Διεύθυνση"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 20, "ΔΟΥ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Έκδοση", System.Data.OleDb.OleDbType.VarWChar, 30, "Έκδοση"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 30, "Επάγγελμα"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επώνυμο", System.Data.OleDb.OleDbType.VarWChar, 30, "Επώνυμο"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ημερομηνία", System.Data.OleDb.OleDbType.DBDate, 0, "Ημερομηνία"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κινητό", System.Data.OleDb.OleDbType.VarWChar, 15, "Κινητό"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κωδικός_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 20, "Κωδικός Βιβλίου"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όνομα", System.Data.OleDb.OleDbType.VarWChar, 30, "Όνομα"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όργανο", System.Data.OleDb.OleDbType.VarWChar, 20, "Όργανο"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ποσότητα", System.Data.OleDb.OleDbType.Integer, 0, "Ποσότητα"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συγγραφέας", System.Data.OleDb.OleDbType.VarWChar, 30, "Συγγραφέας"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συνθέτης", System.Data.OleDb.OleDbType.VarWChar, 30, "Συνθέτης"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 15, "Τηλέφωνο"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τιμή_Προσφοράς", System.Data.OleDb.OleDbType.Single, 0, "Τιμή Προσφοράς"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τίτλος_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 50, "Τίτλος Βιβλίου"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_αρίθμησηεγγραφών", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "αρίθμησηεγγραφών", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtsKiniseisSrch
        '
        Me.objdtsKiniseisSrch.DataSetName = "dtsKiniseisSrch"
        Me.objdtsKiniseisSrch.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(776, 24)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(24, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(608, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 23)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Ενημέρωση"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(800, 24)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(24, 23)
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(536, 264)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(32, 24)
        Me.btnNavFirst.TabIndex = 37
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(568, 264)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(32, 24)
        Me.btnNavPrev.TabIndex = 38
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(600, 264)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(80, 24)
        Me.lblNavLocation.TabIndex = 39
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(680, 264)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(32, 24)
        Me.btnNavNext.TabIndex = 40
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(712, 264)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(32, 24)
        Me.btnLast.TabIndex = 41
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(744, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 23)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(520, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Διαγραφή"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(792, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(24, 23)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "Κινήσεις"
        Me.DataGrid1.DataSource = Me.objdtsKiniseisSrch
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 336)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(768, 192)
        Me.DataGrid1.TabIndex = 25
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Κινήσεις"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Επώνυμο"
        Me.DataGridTextBoxColumn1.MappingName = "Επώνυμο"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Κωδ Βιβλίου"
        Me.DataGridTextBoxColumn6.MappingName = "Κωδικός Βιβλίου"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ISBN"
        Me.DataGridTextBoxColumn5.MappingName = "ISBN"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Τίτλος Βιβλίου"
        Me.DataGridTextBoxColumn7.MappingName = "Τίτλος Βιβλίου"
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Συνθέτης"
        Me.DataGridTextBoxColumn8.MappingName = "Συνθέτης"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Συγγραφέας"
        Me.DataGridTextBoxColumn9.MappingName = "Συγγραφέας"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Έκδοση"
        Me.DataGridTextBoxColumn10.MappingName = "Έκδοση"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Ποσότητα"
        Me.DataGridTextBoxColumn4.MappingName = "Ποσότητα"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Ημερομηνία"
        Me.DataGridTextBoxColumn3.MappingName = "Ημερομηνία"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblΑΦΜ)
        Me.GroupBox1.Controls.Add(Me.lblΔΟΥ)
        Me.GroupBox1.Controls.Add(Me.editΑΦΜ)
        Me.GroupBox1.Controls.Add(Me.editΔΟΥ)
        Me.GroupBox1.Controls.Add(Me.lblΕπάγγελμα)
        Me.GroupBox1.Controls.Add(Me.editΕπάγγελμα)
        Me.GroupBox1.Controls.Add(Me.lblΚινητό)
        Me.GroupBox1.Controls.Add(Me.editΚινητό)
        Me.GroupBox1.Controls.Add(Me.lblΤηλέφωνο)
        Me.GroupBox1.Controls.Add(Me.editΤηλέφωνο)
        Me.GroupBox1.Controls.Add(Me.lblΔιεύθυνση)
        Me.GroupBox1.Controls.Add(Me.editΔιεύθυνση)
        Me.GroupBox1.Controls.Add(Me.lblΌνομα)
        Me.GroupBox1.Controls.Add(Me.editΌνομα)
        Me.GroupBox1.Controls.Add(Me.lblΕπώνυμο)
        Me.GroupBox1.Controls.Add(Me.editΕπώνυμο)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Στοιχεία Πελάτη"
        '
        'lblΑΦΜ
        '
        Me.lblΑΦΜ.Location = New System.Drawing.Point(8, 94)
        Me.lblΑΦΜ.Name = "lblΑΦΜ"
        Me.lblΑΦΜ.Size = New System.Drawing.Size(64, 23)
        Me.lblΑΦΜ.TabIndex = 41
        Me.lblΑΦΜ.Text = "ΑΦΜ"
        Me.lblΑΦΜ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblΔΟΥ
        '
        Me.lblΔΟΥ.Location = New System.Drawing.Point(8, 120)
        Me.lblΔΟΥ.Name = "lblΔΟΥ"
        Me.lblΔΟΥ.Size = New System.Drawing.Size(64, 23)
        Me.lblΔΟΥ.TabIndex = 42
        Me.lblΔΟΥ.Text = "ΔΟΥ"
        Me.lblΔΟΥ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΑΦΜ
        '
        Me.editΑΦΜ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.ΑΦΜ"))
        Me.editΑΦΜ.Location = New System.Drawing.Point(80, 94)
        Me.editΑΦΜ.Name = "editΑΦΜ"
        Me.editΑΦΜ.Size = New System.Drawing.Size(288, 20)
        Me.editΑΦΜ.TabIndex = 4
        Me.editΑΦΜ.Text = ""
        '
        'editΔΟΥ
        '
        Me.editΔΟΥ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.ΔΟΥ"))
        Me.editΔΟΥ.Location = New System.Drawing.Point(80, 120)
        Me.editΔΟΥ.Name = "editΔΟΥ"
        Me.editΔΟΥ.Size = New System.Drawing.Size(288, 20)
        Me.editΔΟΥ.TabIndex = 5
        Me.editΔΟΥ.Text = ""
        '
        'lblΕπάγγελμα
        '
        Me.lblΕπάγγελμα.Location = New System.Drawing.Point(8, 68)
        Me.lblΕπάγγελμα.Name = "lblΕπάγγελμα"
        Me.lblΕπάγγελμα.Size = New System.Drawing.Size(64, 23)
        Me.lblΕπάγγελμα.TabIndex = 39
        Me.lblΕπάγγελμα.Text = "Επάγγελμα"
        Me.lblΕπάγγελμα.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΕπάγγελμα
        '
        Me.editΕπάγγελμα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Επάγγελμα"))
        Me.editΕπάγγελμα.Location = New System.Drawing.Point(80, 68)
        Me.editΕπάγγελμα.Name = "editΕπάγγελμα"
        Me.editΕπάγγελμα.Size = New System.Drawing.Size(288, 20)
        Me.editΕπάγγελμα.TabIndex = 3
        Me.editΕπάγγελμα.Text = ""
        '
        'lblΚινητό
        '
        Me.lblΚινητό.Location = New System.Drawing.Point(8, 195)
        Me.lblΚινητό.Name = "lblΚινητό"
        Me.lblΚινητό.Size = New System.Drawing.Size(64, 23)
        Me.lblΚινητό.TabIndex = 37
        Me.lblΚινητό.Text = "Κινητό"
        Me.lblΚινητό.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΚινητό
        '
        Me.editΚινητό.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Κινητό"))
        Me.editΚινητό.Location = New System.Drawing.Point(80, 198)
        Me.editΚινητό.Name = "editΚινητό"
        Me.editΚινητό.Size = New System.Drawing.Size(288, 20)
        Me.editΚινητό.TabIndex = 8
        Me.editΚινητό.Text = ""
        '
        'lblΤηλέφωνο
        '
        Me.lblΤηλέφωνο.Location = New System.Drawing.Point(8, 170)
        Me.lblΤηλέφωνο.Name = "lblΤηλέφωνο"
        Me.lblΤηλέφωνο.Size = New System.Drawing.Size(64, 23)
        Me.lblΤηλέφωνο.TabIndex = 35
        Me.lblΤηλέφωνο.Text = "Τηλέφωνο"
        Me.lblΤηλέφωνο.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΤηλέφωνο
        '
        Me.editΤηλέφωνο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Τηλέφωνο"))
        Me.editΤηλέφωνο.Location = New System.Drawing.Point(80, 172)
        Me.editΤηλέφωνο.Name = "editΤηλέφωνο"
        Me.editΤηλέφωνο.Size = New System.Drawing.Size(288, 20)
        Me.editΤηλέφωνο.TabIndex = 7
        Me.editΤηλέφωνο.Text = ""
        '
        'lblΔιεύθυνση
        '
        Me.lblΔιεύθυνση.Location = New System.Drawing.Point(8, 145)
        Me.lblΔιεύθυνση.Name = "lblΔιεύθυνση"
        Me.lblΔιεύθυνση.Size = New System.Drawing.Size(64, 23)
        Me.lblΔιεύθυνση.TabIndex = 32
        Me.lblΔιεύθυνση.Text = "Διεύθυνση"
        Me.lblΔιεύθυνση.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΔιεύθυνση
        '
        Me.editΔιεύθυνση.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Διεύθυνση"))
        Me.editΔιεύθυνση.Location = New System.Drawing.Point(80, 146)
        Me.editΔιεύθυνση.Name = "editΔιεύθυνση"
        Me.editΔιεύθυνση.Size = New System.Drawing.Size(288, 20)
        Me.editΔιεύθυνση.TabIndex = 6
        Me.editΔιεύθυνση.Text = ""
        '
        'lblΌνομα
        '
        Me.lblΌνομα.Location = New System.Drawing.Point(8, 42)
        Me.lblΌνομα.Name = "lblΌνομα"
        Me.lblΌνομα.Size = New System.Drawing.Size(64, 23)
        Me.lblΌνομα.TabIndex = 30
        Me.lblΌνομα.Text = "Όνομα"
        Me.lblΌνομα.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΌνομα
        '
        Me.editΌνομα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Όνομα"))
        Me.editΌνομα.Location = New System.Drawing.Point(80, 42)
        Me.editΌνομα.Name = "editΌνομα"
        Me.editΌνομα.Size = New System.Drawing.Size(288, 20)
        Me.editΌνομα.TabIndex = 2
        Me.editΌνομα.Text = ""
        '
        'lblΕπώνυμο
        '
        Me.lblΕπώνυμο.Location = New System.Drawing.Point(8, 16)
        Me.lblΕπώνυμο.Name = "lblΕπώνυμο"
        Me.lblΕπώνυμο.Size = New System.Drawing.Size(64, 23)
        Me.lblΕπώνυμο.TabIndex = 18
        Me.lblΕπώνυμο.Text = "Επώνυμο"
        Me.lblΕπώνυμο.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΕπώνυμο
        '
        Me.editΕπώνυμο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Επώνυμο"))
        Me.editΕπώνυμο.Location = New System.Drawing.Point(80, 16)
        Me.editΕπώνυμο.Name = "editΕπώνυμο"
        Me.editΕπώνυμο.Size = New System.Drawing.Size(288, 20)
        Me.editΕπώνυμο.TabIndex = 1
        Me.editΕπώνυμο.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblΗμερομηνία)
        Me.GroupBox2.Controls.Add(Me.editΗμερομηνία)
        Me.GroupBox2.Controls.Add(Me.lblΠοσότητα)
        Me.GroupBox2.Controls.Add(Me.lblΤιμή_Προσφοράς)
        Me.GroupBox2.Controls.Add(Me.editΠοσότητα)
        Me.GroupBox2.Controls.Add(Me.editΤιμή_Προσφοράς)
        Me.GroupBox2.Controls.Add(Me.lblΌργανο)
        Me.GroupBox2.Controls.Add(Me.editΌργανο)
        Me.GroupBox2.Controls.Add(Me.lblΈκδοση)
        Me.GroupBox2.Controls.Add(Me.editΈκδοση)
        Me.GroupBox2.Controls.Add(Me.lblΣυγγραφέας)
        Me.GroupBox2.Controls.Add(Me.editΣυγγραφέας)
        Me.GroupBox2.Controls.Add(Me.lblΣυνθέτης)
        Me.GroupBox2.Controls.Add(Me.editΣυνθέτης)
        Me.GroupBox2.Controls.Add(Me.lblΤίτλος_Βιβλίου)
        Me.GroupBox2.Controls.Add(Me.editΤίτλος_Βιβλίου)
        Me.GroupBox2.Controls.Add(Me.lblΚωδικός_Βιβλίου)
        Me.GroupBox2.Controls.Add(Me.editΚωδικός_Βιβλίου)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 240)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Στοιχεία Βιβλίου"
        '
        'lblΗμερομηνία
        '
        Me.lblΗμερομηνία.Location = New System.Drawing.Point(8, 181)
        Me.lblΗμερομηνία.Name = "lblΗμερομηνία"
        Me.lblΗμερομηνία.Size = New System.Drawing.Size(88, 23)
        Me.lblΗμερομηνία.TabIndex = 47
        Me.lblΗμερομηνία.Text = "Ημερομηνία"
        Me.lblΗμερομηνία.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΗμερομηνία
        '
        Me.editΗμερομηνία.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Ημερομηνία"))
        Me.editΗμερομηνία.Location = New System.Drawing.Point(96, 181)
        Me.editΗμερομηνία.Name = "editΗμερομηνία"
        Me.editΗμερομηνία.Size = New System.Drawing.Size(88, 20)
        Me.editΗμερομηνία.TabIndex = 16
        Me.editΗμερομηνία.Text = ""
        '
        'lblΠοσότητα
        '
        Me.lblΠοσότητα.Location = New System.Drawing.Point(224, 181)
        Me.lblΠοσότητα.Name = "lblΠοσότητα"
        Me.lblΠοσότητα.Size = New System.Drawing.Size(72, 23)
        Me.lblΠοσότητα.TabIndex = 49
        Me.lblΠοσότητα.Text = "Ποσότητα"
        Me.lblΠοσότητα.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblΤιμή_Προσφοράς
        '
        Me.lblΤιμή_Προσφοράς.Location = New System.Drawing.Point(104, 208)
        Me.lblΤιμή_Προσφοράς.Name = "lblΤιμή_Προσφοράς"
        Me.lblΤιμή_Προσφοράς.Size = New System.Drawing.Size(96, 23)
        Me.lblΤιμή_Προσφοράς.TabIndex = 50
        Me.lblΤιμή_Προσφοράς.Text = "Τιμή Πώλησης"
        Me.lblΤιμή_Προσφοράς.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΠοσότητα
        '
        Me.editΠοσότητα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Ποσότητα"))
        Me.editΠοσότητα.Location = New System.Drawing.Point(296, 181)
        Me.editΠοσότητα.Name = "editΠοσότητα"
        Me.editΠοσότητα.Size = New System.Drawing.Size(72, 20)
        Me.editΠοσότητα.TabIndex = 17
        Me.editΠοσότητα.Text = ""
        '
        'editΤιμή_Προσφοράς
        '
        Me.editΤιμή_Προσφοράς.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Τιμή Προσφοράς"))
        Me.editΤιμή_Προσφοράς.Location = New System.Drawing.Point(200, 211)
        Me.editΤιμή_Προσφοράς.Name = "editΤιμή_Προσφοράς"
        Me.editΤιμή_Προσφοράς.TabIndex = 18
        Me.editΤιμή_Προσφοράς.Text = ""
        '
        'lblΌργανο
        '
        Me.lblΌργανο.Location = New System.Drawing.Point(8, 157)
        Me.lblΌργανο.Name = "lblΌργανο"
        Me.lblΌργανο.Size = New System.Drawing.Size(88, 23)
        Me.lblΌργανο.TabIndex = 45
        Me.lblΌργανο.Text = "Υποκατηγορία 2"
        Me.lblΌργανο.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΌργανο
        '
        Me.editΌργανο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Όργανο"))
        Me.editΌργανο.Location = New System.Drawing.Point(96, 157)
        Me.editΌργανο.Name = "editΌργανο"
        Me.editΌργανο.Size = New System.Drawing.Size(272, 20)
        Me.editΌργανο.TabIndex = 15
        Me.editΌργανο.Text = ""
        '
        'lblΈκδοση
        '
        Me.lblΈκδοση.Location = New System.Drawing.Point(8, 133)
        Me.lblΈκδοση.Name = "lblΈκδοση"
        Me.lblΈκδοση.Size = New System.Drawing.Size(88, 23)
        Me.lblΈκδοση.TabIndex = 43
        Me.lblΈκδοση.Text = "Έκδοση"
        Me.lblΈκδοση.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΈκδοση
        '
        Me.editΈκδοση.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Έκδοση"))
        Me.editΈκδοση.Location = New System.Drawing.Point(96, 133)
        Me.editΈκδοση.Name = "editΈκδοση"
        Me.editΈκδοση.Size = New System.Drawing.Size(272, 20)
        Me.editΈκδοση.TabIndex = 14
        Me.editΈκδοση.Text = ""
        '
        'lblΣυγγραφέας
        '
        Me.lblΣυγγραφέας.Location = New System.Drawing.Point(8, 109)
        Me.lblΣυγγραφέας.Name = "lblΣυγγραφέας"
        Me.lblΣυγγραφέας.Size = New System.Drawing.Size(88, 23)
        Me.lblΣυγγραφέας.TabIndex = 41
        Me.lblΣυγγραφέας.Text = "Συγγραφέας"
        Me.lblΣυγγραφέας.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΣυγγραφέας
        '
        Me.editΣυγγραφέας.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Συγγραφέας"))
        Me.editΣυγγραφέας.Location = New System.Drawing.Point(96, 109)
        Me.editΣυγγραφέας.Name = "editΣυγγραφέας"
        Me.editΣυγγραφέας.Size = New System.Drawing.Size(272, 20)
        Me.editΣυγγραφέας.TabIndex = 13
        Me.editΣυγγραφέας.Text = ""
        '
        'lblΣυνθέτης
        '
        Me.lblΣυνθέτης.Location = New System.Drawing.Point(8, 85)
        Me.lblΣυνθέτης.Name = "lblΣυνθέτης"
        Me.lblΣυνθέτης.Size = New System.Drawing.Size(88, 23)
        Me.lblΣυνθέτης.TabIndex = 39
        Me.lblΣυνθέτης.Text = "Συνθέτης"
        Me.lblΣυνθέτης.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΣυνθέτης
        '
        Me.editΣυνθέτης.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Συνθέτης"))
        Me.editΣυνθέτης.Location = New System.Drawing.Point(96, 85)
        Me.editΣυνθέτης.Name = "editΣυνθέτης"
        Me.editΣυνθέτης.Size = New System.Drawing.Size(272, 20)
        Me.editΣυνθέτης.TabIndex = 12
        Me.editΣυνθέτης.Text = ""
        '
        'lblΤίτλος_Βιβλίου
        '
        Me.lblΤίτλος_Βιβλίου.Location = New System.Drawing.Point(8, 40)
        Me.lblΤίτλος_Βιβλίου.Name = "lblΤίτλος_Βιβλίου"
        Me.lblΤίτλος_Βιβλίου.Size = New System.Drawing.Size(88, 23)
        Me.lblΤίτλος_Βιβλίου.TabIndex = 37
        Me.lblΤίτλος_Βιβλίου.Text = "Τίτλος Βιβλίου"
        Me.lblΤίτλος_Βιβλίου.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΤίτλος_Βιβλίου
        '
        Me.editΤίτλος_Βιβλίου.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Τίτλος Βιβλίου"))
        Me.editΤίτλος_Βιβλίου.Location = New System.Drawing.Point(96, 40)
        Me.editΤίτλος_Βιβλίου.Multiline = True
        Me.editΤίτλος_Βιβλίου.Name = "editΤίτλος_Βιβλίου"
        Me.editΤίτλος_Βιβλίου.Size = New System.Drawing.Size(272, 40)
        Me.editΤίτλος_Βιβλίου.TabIndex = 11
        Me.editΤίτλος_Βιβλίου.Text = ""
        '
        'lblΚωδικός_Βιβλίου
        '
        Me.lblΚωδικός_Βιβλίου.Location = New System.Drawing.Point(8, 16)
        Me.lblΚωδικός_Βιβλίου.Name = "lblΚωδικός_Βιβλίου"
        Me.lblΚωδικός_Βιβλίου.Size = New System.Drawing.Size(88, 23)
        Me.lblΚωδικός_Βιβλίου.TabIndex = 21
        Me.lblΚωδικός_Βιβλίου.Text = "Κωδικός Βιβλίου"
        Me.lblΚωδικός_Βιβλίου.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editΚωδικός_Βιβλίου
        '
        Me.editΚωδικός_Βιβλίου.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "Κινήσεις.Κωδικός Βιβλίου"))
        Me.editΚωδικός_Βιβλίου.Location = New System.Drawing.Point(96, 16)
        Me.editΚωδικός_Βιβλίου.Name = "editΚωδικός_Βιβλίου"
        Me.editΚωδικός_Βιβλίου.TabIndex = 10
        Me.editΚωδικός_Βιβλίου.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 80)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Αναζήτηση με ημερομηνία"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(392, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "’κυρο"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(392, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Αναζήτηση"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(312, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Έως"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Από"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Αναζήτηση με Επώνυμο"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 61
        Me.TextBox1.Text = ""
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(696, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "Εκτύπωση"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(800, 528)
        Me.CrystalReportViewer1.TabIndex = 62
        Me.CrystalReportViewer1.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(272, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Κλείσιμο"
        Me.Button4.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Αναζήτηση Πώλησης"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Κλείσιμο"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 83
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(288, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 82
        '
        'frmKiniseisSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmKiniseisSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Αναζήτηση Πωλήσεων"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsKiniseisSrch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").CancelCurrentEdit()
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Count > 0) Then
            Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").RemoveAt(Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position)
            Me.objdtsKiniseisSrch_PositionChanged()
        End If

        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").EndCurrentEdit()
            Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position = 0
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position = (Me.objdtsKiniseisSrch.Tables("Κινήσεις").Rows.Count - 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position = (Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position - 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position = (Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position + 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub objdtsKiniseisSrch_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsKiniseisSrch.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsKiniseisSrch = New prjctDoReMi.dtsKiniseisSrch
        'Stop any current edits.
        Me.BindingContext(objdtsKiniseisSrch, "Κινήσεις").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsKiniseisSrch.GetChanges, prjctDoReMi.dtsKiniseisSrch)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsKiniseisSrch.Merge(objDataSetChanges)
                objdtsKiniseisSrch.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsKiniseisSrch
        objDataSetTemp = New prjctDoReMi.dtsKiniseisSrch
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsKiniseisSrch.Clear()
            'Merge the records into the main dataset.
            objdtsKiniseisSrch.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsKiniseisSrch)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsKiniseisSrch)
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

    Private Sub frmKiniseisSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()



    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Dim varsql As New OleDb.OleDbCommand("select * from Κινήσεις where Ημερομηνία between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and Επώνυμο like '" & TextBox1.Text & "%';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        

        Dim varsql As New OleDb.OleDbCommand("select * from Κινήσεις", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsql
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim report As New rptSales
        report.SetDataSource(objdtsKiniseisSrch)
        CrystalReportViewer1.Visible = True
        Button4.Visible = True
        CrystalReportViewer1.BringToFront()
        Button4.BringToFront()
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        CrystalReportViewer1.Visible = False
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub frmKiniseisSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lblNavLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNavLocation.Click

    End Sub
End Class
