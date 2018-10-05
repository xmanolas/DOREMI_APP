Public Class frmParagelieslast
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
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDataAdapter3 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objdtsparagelieslast As prjctDoReMi.dtsparagelieslast
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblΑΦΜ As System.Windows.Forms.Label
    Friend WithEvents lblΔιεύθυνση As System.Windows.Forms.Label
    Friend WithEvents lblΔΟΥ As System.Windows.Forms.Label
    Friend WithEvents lblΈκδοση As System.Windows.Forms.Label
    Friend WithEvents lblΕπάγγελμα As System.Windows.Forms.Label
    Friend WithEvents lblΕπώνυμο As System.Windows.Forms.Label
    Friend WithEvents lblΗμερομηνία As System.Windows.Forms.Label
    Friend WithEvents lblΚινητό As System.Windows.Forms.Label
    Friend WithEvents editΑΦΜ As System.Windows.Forms.TextBox
    Friend WithEvents editΔιεύθυνση As System.Windows.Forms.TextBox
    Friend WithEvents editΔΟΥ As System.Windows.Forms.TextBox
    Friend WithEvents editΈκδοση As System.Windows.Forms.TextBox
    Friend WithEvents editΕπάγγελμα As System.Windows.Forms.TextBox
    Friend WithEvents editΕπώνυμο As System.Windows.Forms.TextBox
    Friend WithEvents editΗμερομηνία As System.Windows.Forms.TextBox
    Friend WithEvents editΚινητό As System.Windows.Forms.TextBox
    Friend WithEvents lblΚωδικός_Βιβλίου As System.Windows.Forms.Label
    Friend WithEvents lblΌνομα As System.Windows.Forms.Label
    Friend WithEvents lblΌργανο As System.Windows.Forms.Label
    Friend WithEvents lblΠοσότητα As System.Windows.Forms.Label
    Friend WithEvents lblΣυγγραφέας As System.Windows.Forms.Label
    Friend WithEvents lblΣυνθέτης As System.Windows.Forms.Label
    Friend WithEvents lblΤηλέφωνο As System.Windows.Forms.Label
    Friend WithEvents lblΤιμή_Προσφοράς As System.Windows.Forms.Label
    Friend WithEvents lblΤίτλος_Βιβλίου As System.Windows.Forms.Label
    Friend WithEvents editΚωδικός_Βιβλίου As System.Windows.Forms.TextBox
    Friend WithEvents editΌνομα As System.Windows.Forms.TextBox
    Friend WithEvents editΌργανο As System.Windows.Forms.TextBox
    Friend WithEvents editΠοσότητα As System.Windows.Forms.TextBox
    Friend WithEvents editΣυγγραφέας As System.Windows.Forms.TextBox
    Friend WithEvents editΣυνθέτης As System.Windows.Forms.TextBox
    Friend WithEvents editΤηλέφωνο As System.Windows.Forms.TextBox
    Friend WithEvents editΤίτλος_Βιβλίου As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents editISBN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents editofferprice As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.objdtsparagelieslast = New prjctDoReMi.dtsparagelieslast
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblΑΦΜ = New System.Windows.Forms.Label
        Me.lblΔιεύθυνση = New System.Windows.Forms.Label
        Me.lblΔΟΥ = New System.Windows.Forms.Label
        Me.lblΈκδοση = New System.Windows.Forms.Label
        Me.lblΕπάγγελμα = New System.Windows.Forms.Label
        Me.lblΕπώνυμο = New System.Windows.Forms.Label
        Me.lblΗμερομηνία = New System.Windows.Forms.Label
        Me.lblΚινητό = New System.Windows.Forms.Label
        Me.editΑΦΜ = New System.Windows.Forms.TextBox
        Me.editΔιεύθυνση = New System.Windows.Forms.TextBox
        Me.editΔΟΥ = New System.Windows.Forms.TextBox
        Me.editΈκδοση = New System.Windows.Forms.TextBox
        Me.editΕπάγγελμα = New System.Windows.Forms.TextBox
        Me.editΕπώνυμο = New System.Windows.Forms.TextBox
        Me.editΗμερομηνία = New System.Windows.Forms.TextBox
        Me.editΚινητό = New System.Windows.Forms.TextBox
        Me.lblΚωδικός_Βιβλίου = New System.Windows.Forms.Label
        Me.lblΌνομα = New System.Windows.Forms.Label
        Me.lblΌργανο = New System.Windows.Forms.Label
        Me.lblΠοσότητα = New System.Windows.Forms.Label
        Me.lblΣυγγραφέας = New System.Windows.Forms.Label
        Me.lblΣυνθέτης = New System.Windows.Forms.Label
        Me.lblΤηλέφωνο = New System.Windows.Forms.Label
        Me.lblΤιμή_Προσφοράς = New System.Windows.Forms.Label
        Me.lblΤίτλος_Βιβλίου = New System.Windows.Forms.Label
        Me.editΚωδικός_Βιβλίου = New System.Windows.Forms.TextBox
        Me.editΌνομα = New System.Windows.Forms.TextBox
        Me.editΌργανο = New System.Windows.Forms.TextBox
        Me.editΠοσότητα = New System.Windows.Forms.TextBox
        Me.editΣυγγραφέας = New System.Windows.Forms.TextBox
        Me.editΣυνθέτης = New System.Windows.Forms.TextBox
        Me.editΤηλέφωνο = New System.Windows.Forms.TextBox
        Me.editofferprice = New System.Windows.Forms.TextBox
        Me.editΤίτλος_Βιβλίου = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.editISBN = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Label40 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        CType(Me.objdtsparagelieslast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Παραγγελίες", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("offerprice", "offerprice"), New System.Data.Common.DataColumnMapping("OrderNotes", "OrderNotes"), New System.Data.Common.DataColumnMapping("αρίθμησηεγγραφών", "αρίθμησηεγγραφών"), New System.Data.Common.DataColumnMapping("ΑΦΜ", "ΑΦΜ"), New System.Data.Common.DataColumnMapping("Διεύθυνση", "Διεύθυνση"), New System.Data.Common.DataColumnMapping("ΔΟΥ", "ΔΟΥ"), New System.Data.Common.DataColumnMapping("Έκδοση", "Έκδοση"), New System.Data.Common.DataColumnMapping("Επάγγελμα", "Επάγγελμα"), New System.Data.Common.DataColumnMapping("Επώνυμο", "Επώνυμο"), New System.Data.Common.DataColumnMapping("Ημερομηνία", "Ημερομηνία"), New System.Data.Common.DataColumnMapping("Κινητό", "Κινητό"), New System.Data.Common.DataColumnMapping("Κωδικός Βιβλίου", "Κωδικός Βιβλίου"), New System.Data.Common.DataColumnMapping("Ολοκληρώθηκε", "Ολοκληρώθηκε"), New System.Data.Common.DataColumnMapping("Όνομα", "Όνομα"), New System.Data.Common.DataColumnMapping("Όργανο", "Όργανο"), New System.Data.Common.DataColumnMapping("Παράδοση", "Παράδοση"), New System.Data.Common.DataColumnMapping("Ποσότητα", "Ποσότητα"), New System.Data.Common.DataColumnMapping("Συγγραφέας", "Συγγραφέας"), New System.Data.Common.DataColumnMapping("Συνθέτης", "Συνθέτης"), New System.Data.Common.DataColumnMapping("Τηλέφωνο", "Τηλέφωνο"), New System.Data.Common.DataColumnMapping("Τίτλος Βιβλίου", "Τίτλος Βιβλίου")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM Παραγγελίες WHERE (αρίθμησηεγγραφών = ?)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_αρίθμησηεγγραφών", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "αρίθμησηεγγραφών", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Παραγγελίες(ISBN, offerprice, OrderNotes, ΑΦΜ, Διεύθυνση, ΔΟΥ, Έκδοση" & _
        ", Επάγγελμα, Επώνυμο, Ημερομηνία, Κινητό, [Κωδικός Βιβλίου], Ολοκληρώθηκε, Όνομα" & _
        ", Όργανο, Παράδοση, Ποσότητα, Συγγραφέας, Συνθέτης, Τηλέφωνο, [Τίτλος Βιβλίου]) " & _
        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("offerprice", System.Data.OleDb.OleDbType.Integer, 0, "offerprice"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderNotes", System.Data.OleDb.OleDbType.VarChar, 0, "OrderNotes"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 10, "ΑΦΜ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Διεύθυνση", System.Data.OleDb.OleDbType.VarWChar, 50, "Διεύθυνση"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 20, "ΔΟΥ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Έκδοση", System.Data.OleDb.OleDbType.VarWChar, 30, "Έκδοση"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 30, "Επάγγελμα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επώνυμο", System.Data.OleDb.OleDbType.VarWChar, 30, "Επώνυμο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ημερομηνία", System.Data.OleDb.OleDbType.DBDate, 0, "Ημερομηνία"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κινητό", System.Data.OleDb.OleDbType.VarWChar, 15, "Κινητό"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κωδικός_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 20, "Κωδικός Βιβλίου"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ολοκληρώθηκε", System.Data.OleDb.OleDbType.VarWChar, 10, "Ολοκληρώθηκε"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όνομα", System.Data.OleDb.OleDbType.VarWChar, 30, "Όνομα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όργανο", System.Data.OleDb.OleDbType.VarWChar, 20, "Όργανο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Παράδοση", System.Data.OleDb.OleDbType.VarWChar, 50, "Παράδοση"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ποσότητα", System.Data.OleDb.OleDbType.Integer, 0, "Ποσότητα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συγγραφέας", System.Data.OleDb.OleDbType.VarWChar, 30, "Συγγραφέας"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συνθέτης", System.Data.OleDb.OleDbType.VarWChar, 30, "Συνθέτης"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 15, "Τηλέφωνο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τίτλος_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 50, "Τίτλος Βιβλίου"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ISBN, offerprice, OrderNotes, αρίθμησηεγγραφών, ΑΦΜ, Διεύθυνση, ΔΟΥ, Έκδοσ" & _
        "η, Επάγγελμα, Επώνυμο, Ημερομηνία, Κινητό, [Κωδικός Βιβλίου], Ολοκληρώθηκε, Όνομ" & _
        "α, Όργανο, Παράδοση, Ποσότητα, Συγγραφέας, Συνθέτης, Τηλέφωνο, [Τίτλος Βιβλίου] " & _
        "FROM Παραγγελίες"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE Παραγγελίες SET ISBN = ?, offerprice = ?, OrderNotes = ?, ΑΦΜ = ?, Διεύθυν" & _
        "ση = ?, ΔΟΥ = ?, Έκδοση = ?, Επάγγελμα = ?, Επώνυμο = ?, Ημερομηνία = ?, Κινητό " & _
        "= ?, [Κωδικός Βιβλίου] = ?, Ολοκληρώθηκε = ?, Όνομα = ?, Όργανο = ?, Παράδοση = " & _
        "?, Ποσότητα = ?, Συγγραφέας = ?, Συνθέτης = ?, Τηλέφωνο = ?, [Τίτλος Βιβλίου] = " & _
        "? WHERE (αρίθμησηεγγραφών = ?)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("offerprice", System.Data.OleDb.OleDbType.Integer, 0, "offerprice"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderNotes", System.Data.OleDb.OleDbType.VarChar, 0, "OrderNotes"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 10, "ΑΦΜ"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Διεύθυνση", System.Data.OleDb.OleDbType.VarWChar, 50, "Διεύθυνση"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 20, "ΔΟΥ"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Έκδοση", System.Data.OleDb.OleDbType.VarWChar, 30, "Έκδοση"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 30, "Επάγγελμα"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επώνυμο", System.Data.OleDb.OleDbType.VarWChar, 30, "Επώνυμο"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ημερομηνία", System.Data.OleDb.OleDbType.DBDate, 0, "Ημερομηνία"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κινητό", System.Data.OleDb.OleDbType.VarWChar, 15, "Κινητό"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Κωδικός_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 20, "Κωδικός Βιβλίου"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ολοκληρώθηκε", System.Data.OleDb.OleDbType.VarWChar, 10, "Ολοκληρώθηκε"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όνομα", System.Data.OleDb.OleDbType.VarWChar, 30, "Όνομα"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Όργανο", System.Data.OleDb.OleDbType.VarWChar, 20, "Όργανο"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Παράδοση", System.Data.OleDb.OleDbType.VarWChar, 50, "Παράδοση"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ποσότητα", System.Data.OleDb.OleDbType.Integer, 0, "Ποσότητα"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συγγραφέας", System.Data.OleDb.OleDbType.VarWChar, 30, "Συγγραφέας"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Συνθέτης", System.Data.OleDb.OleDbType.VarWChar, 30, "Συνθέτης"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 15, "Τηλέφωνο"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τίτλος_Βιβλίου", System.Data.OleDb.OleDbType.VarWChar, 50, "Τίτλος Βιβλίου"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_αρίθμησηεγγραφών", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "αρίθμησηεγγραφών", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Πελατολόγιο", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("kinhto", "kinhto"), New System.Data.Common.DataColumnMapping("website", "website"), New System.Data.Common.DataColumnMapping("ΑριθμόςΦαξ", "ΑριθμόςΦαξ"), New System.Data.Common.DataColumnMapping("ΑΦΜ", "ΑΦΜ"), New System.Data.Common.DataColumnMapping("ΔιεύθυνσηEmail", "ΔιεύθυνσηEmail"), New System.Data.Common.DataColumnMapping("ΔιεύθυνσηΧρέωσης", "ΔιεύθυνσηΧρέωσης"), New System.Data.Common.DataColumnMapping("ΔΟΥ", "ΔΟΥ"), New System.Data.Common.DataColumnMapping("Επάγγελμα", "Επάγγελμα"), New System.Data.Common.DataColumnMapping("ΕπωνυμίαΕταιρείας", "ΕπωνυμίαΕταιρείας"), New System.Data.Common.DataColumnMapping("ΕπώνυμοΕπαφής", "ΕπώνυμοΕπαφής"), New System.Data.Common.DataColumnMapping("ΚωδΑγοραστή", "ΚωδΑγοραστή"), New System.Data.Common.DataColumnMapping("Νομός/Περιοχή", "Νομός/Περιοχή"), New System.Data.Common.DataColumnMapping("ΌνομαΕπαφής", "ΌνομαΕπαφής"), New System.Data.Common.DataColumnMapping("Πόλη", "Πόλη"), New System.Data.Common.DataColumnMapping("Σημειώσεις", "Σημειώσεις"), New System.Data.Common.DataColumnMapping("ΤαχυδρομικόςΚώδικας", "ΤαχυδρομικόςΚώδικας"), New System.Data.Common.DataColumnMapping("Τηλέφωνο", "Τηλέφωνο"), New System.Data.Common.DataColumnMapping("Τηλέφωνο1", "Τηλέφωνο1"), New System.Data.Common.DataColumnMapping("Χώρα/Περιοχή", "Χώρα/Περιοχή")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Πελατολόγιο WHERE (ΚωδΑγοραστή = ?) AND (kinhto = ? OR ? IS NULL AND " & _
        "kinhto IS NULL) AND (website = ? OR ? IS NULL AND website IS NULL) AND (ΌνομαΕπα" & _
        "φής = ? OR ? IS NULL AND ΌνομαΕπαφής IS NULL) AND (ΑΦΜ = ? OR ? IS NULL AND ΑΦΜ " & _
        "IS NULL) AND (ΑριθμόςΦαξ = ? OR ? IS NULL AND ΑριθμόςΦαξ IS NULL) AND (ΔΟΥ = ? O" & _
        "R ? IS NULL AND ΔΟΥ IS NULL) AND (ΔιεύθυνσηEmail = ? OR ? IS NULL AND ΔιεύθυνσηE" & _
        "mail IS NULL) AND (ΔιεύθυνσηΧρέωσης = ? OR ? IS NULL AND ΔιεύθυνσηΧρέωσης IS NUL" & _
        "L) AND (Επάγγελμα = ? OR ? IS NULL AND Επάγγελμα IS NULL) AND (ΕπωνυμίαΕταιρείας" & _
        " = ? OR ? IS NULL AND ΕπωνυμίαΕταιρείας IS NULL) AND (ΕπώνυμοΕπαφής = ? OR ? IS " & _
        "NULL AND ΕπώνυμοΕπαφής IS NULL) AND ([Νομός/Περιοχή] = ? OR ? IS NULL AND [Νομός" & _
        "/Περιοχή] IS NULL) AND (Πόλη = ? OR ? IS NULL AND Πόλη IS NULL) AND (Ταχυδρομικό" & _
        "ςΚώδικας = ? OR ? IS NULL AND ΤαχυδρομικόςΚώδικας IS NULL) AND (Τηλέφωνο = ? OR " & _
        "? IS NULL AND Τηλέφωνο IS NULL) AND (Τηλέφωνο1 = ? OR ? IS NULL AND Τηλέφωνο1 IS" & _
        " NULL) AND ([Χώρα/Περιοχή] = ? OR ? IS NULL AND [Χώρα/Περιοχή] IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΚωδΑγοραστή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΌνομαΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΌνομαΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΌνομαΕπαφής1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΌνομαΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑΦΜ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑΦΜ1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑΦΜ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑριθμόςΦαξ", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑριθμόςΦαξ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑριθμόςΦαξ1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑριθμόςΦαξ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔΟΥ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔΟΥ1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔΟΥ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηΧρέωσης", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηΧρέωσης", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηΧρέωσης1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηΧρέωσης", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Επάγγελμα", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Επάγγελμα1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Επάγγελμα", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπωνυμίαΕταιρείας", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπωνυμίαΕταιρείας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπωνυμίαΕταιρείας1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπωνυμίαΕταιρείας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπώνυμοΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπώνυμοΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπώνυμοΕπαφής1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπώνυμοΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Νομός_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Νομός/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Νομός_Περιοχή1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Νομός/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Πόλη", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Πόλη", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Πόλη1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Πόλη", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΤαχυδρομικόςΚώδικας", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΤαχυδρομικόςΚώδικας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΤαχυδρομικόςΚώδικας1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΤαχυδρομικόςΚώδικας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Χώρα_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Χώρα/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Χώρα_Περιοχή1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Χώρα/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Πελατολόγιο(kinhto, website, ΑριθμόςΦαξ, ΑΦΜ, ΔιεύθυνσηEmail, Διεύθυν" & _
        "σηΧρέωσης, ΔΟΥ, Επάγγελμα, ΕπωνυμίαΕταιρείας, ΕπώνυμοΕπαφής, ΚωδΑγοραστή, [Νομός" & _
        "/Περιοχή], ΌνομαΕπαφής, Πόλη, Σημειώσεις, ΤαχυδρομικόςΚώδικας, Τηλέφωνο, Τηλέφων" & _
        "ο1, [Χώρα/Περιοχή]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑριθμόςΦαξ", System.Data.OleDb.OleDbType.VarWChar, 30, "ΑριθμόςΦαξ"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΑΦΜ"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "ΔιεύθυνσηEmail"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηΧρέωσης", System.Data.OleDb.OleDbType.VarWChar, 255, "ΔιεύθυνσηΧρέωσης"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΔΟΥ"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 50, "Επάγγελμα"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπωνυμίαΕταιρείας", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπωνυμίαΕταιρείας"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπώνυμοΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπώνυμοΕπαφής"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, "ΚωδΑγοραστή"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Νομός_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 20, "Νομός/Περιοχή"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΌνομαΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 30, "ΌνομαΕπαφής"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Πόλη", System.Data.OleDb.OleDbType.VarWChar, 50, "Πόλη"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Σημειώσεις", System.Data.OleDb.OleDbType.VarWChar, 0, "Σημειώσεις"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΤαχυδρομικόςΚώδικας", System.Data.OleDb.OleDbType.VarWChar, 20, "ΤαχυδρομικόςΚώδικας"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο1", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο1"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Χώρα_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 50, "Χώρα/Περιοχή"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT kinhto, website, ΑριθμόςΦαξ, ΑΦΜ, ΔιεύθυνσηEmail, ΔιεύθυνσηΧρέωσης, ΔΟΥ, Ε" & _
        "πάγγελμα, ΕπωνυμίαΕταιρείας, ΕπώνυμοΕπαφής, ΚωδΑγοραστή, [Νομός/Περιοχή], ΌνομαΕ" & _
        "παφής, Πόλη, Σημειώσεις, ΤαχυδρομικόςΚώδικας, Τηλέφωνο, Τηλέφωνο1, [Χώρα/Περιοχή" & _
        "] FROM Πελατολόγιο"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Πελατολόγιο SET kinhto = ?, website = ?, ΑριθμόςΦαξ = ?, ΑΦΜ = ?, Διεύθυνσ" & _
        "ηEmail = ?, ΔιεύθυνσηΧρέωσης = ?, ΔΟΥ = ?, Επάγγελμα = ?, ΕπωνυμίαΕταιρείας = ?," & _
        " ΕπώνυμοΕπαφής = ?, ΚωδΑγοραστή = ?, [Νομός/Περιοχή] = ?, ΌνομαΕπαφής = ?, Πόλη " & _
        "= ?, Σημειώσεις = ?, ΤαχυδρομικόςΚώδικας = ?, Τηλέφωνο = ?, Τηλέφωνο1 = ?, [Χώρα" & _
        "/Περιοχή] = ? WHERE (ΚωδΑγοραστή = ?) AND (kinhto = ? OR ? IS NULL AND kinhto IS" & _
        " NULL) AND (website = ? OR ? IS NULL AND website IS NULL) AND (ΌνομαΕπαφής = ? O" & _
        "R ? IS NULL AND ΌνομαΕπαφής IS NULL) AND (ΑΦΜ = ? OR ? IS NULL AND ΑΦΜ IS NULL) " & _
        "AND (ΑριθμόςΦαξ = ? OR ? IS NULL AND ΑριθμόςΦαξ IS NULL) AND (ΔΟΥ = ? OR ? IS NU" & _
        "LL AND ΔΟΥ IS NULL) AND (ΔιεύθυνσηEmail = ? OR ? IS NULL AND ΔιεύθυνσηEmail IS N" & _
        "ULL) AND (ΔιεύθυνσηΧρέωσης = ? OR ? IS NULL AND ΔιεύθυνσηΧρέωσης IS NULL) AND (Ε" & _
        "πάγγελμα = ? OR ? IS NULL AND Επάγγελμα IS NULL) AND (ΕπωνυμίαΕταιρείας = ? OR ?" & _
        " IS NULL AND ΕπωνυμίαΕταιρείας IS NULL) AND (ΕπώνυμοΕπαφής = ? OR ? IS NULL AND " & _
        "ΕπώνυμοΕπαφής IS NULL) AND ([Νομός/Περιοχή] = ? OR ? IS NULL AND [Νομός/Περιοχή]" & _
        " IS NULL) AND (Πόλη = ? OR ? IS NULL AND Πόλη IS NULL) AND (ΤαχυδρομικόςΚώδικας " & _
        "= ? OR ? IS NULL AND ΤαχυδρομικόςΚώδικας IS NULL) AND (Τηλέφωνο = ? OR ? IS NULL" & _
        " AND Τηλέφωνο IS NULL) AND (Τηλέφωνο1 = ? OR ? IS NULL AND Τηλέφωνο1 IS NULL) AN" & _
        "D ([Χώρα/Περιοχή] = ? OR ? IS NULL AND [Χώρα/Περιοχή] IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑριθμόςΦαξ", System.Data.OleDb.OleDbType.VarWChar, 30, "ΑριθμόςΦαξ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΑΦΜ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "ΔιεύθυνσηEmail"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηΧρέωσης", System.Data.OleDb.OleDbType.VarWChar, 255, "ΔιεύθυνσηΧρέωσης"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΔΟΥ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 50, "Επάγγελμα"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπωνυμίαΕταιρείας", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπωνυμίαΕταιρείας"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπώνυμοΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπώνυμοΕπαφής"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, "ΚωδΑγοραστή"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Νομός_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 20, "Νομός/Περιοχή"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΌνομαΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 30, "ΌνομαΕπαφής"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Πόλη", System.Data.OleDb.OleDbType.VarWChar, 50, "Πόλη"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Σημειώσεις", System.Data.OleDb.OleDbType.VarWChar, 0, "Σημειώσεις"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΤαχυδρομικόςΚώδικας", System.Data.OleDb.OleDbType.VarWChar, 20, "ΤαχυδρομικόςΚώδικας"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο1", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Χώρα_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 50, "Χώρα/Περιοχή"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΚωδΑγοραστή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΌνομαΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΌνομαΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΌνομαΕπαφής1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΌνομαΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑΦΜ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑΦΜ1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑΦΜ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑριθμόςΦαξ", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑριθμόςΦαξ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΑριθμόςΦαξ1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΑριθμόςΦαξ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔΟΥ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔΟΥ1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔΟΥ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηEmail", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηEmail1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηEmail", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηΧρέωσης", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηΧρέωσης", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΔιεύθυνσηΧρέωσης1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΔιεύθυνσηΧρέωσης", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Επάγγελμα", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Επάγγελμα1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Επάγγελμα", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπωνυμίαΕταιρείας", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπωνυμίαΕταιρείας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπωνυμίαΕταιρείας1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπωνυμίαΕταιρείας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπώνυμοΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπώνυμοΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΕπώνυμοΕπαφής1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΕπώνυμοΕπαφής", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Νομός_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Νομός/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Νομός_Περιοχή1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Νομός/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Πόλη", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Πόλη", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Πόλη1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Πόλη", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΤαχυδρομικόςΚώδικας", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΤαχυδρομικόςΚώδικας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΤαχυδρομικόςΚώδικας1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΤαχυδρομικόςΚώδικας", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Τηλέφωνο12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Τηλέφωνο1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Χώρα_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Χώρα/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Χώρα_Περιοχή1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Χώρα/Περιοχή", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblBooks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("aa", "aa"), New System.Data.Common.DataColumnMapping("author", "author"), New System.Data.Common.DataColumnMapping("bookcode", "bookcode"), New System.Data.Common.DataColumnMapping("bookordernumber", "bookordernumber"), New System.Data.Common.DataColumnMapping("booktitle", "booktitle"), New System.Data.Common.DataColumnMapping("compocategory", "compocategory"), New System.Data.Common.DataColumnMapping("composer", "composer"), New System.Data.Common.DataColumnMapping("compotitle", "compotitle"), New System.Data.Common.DataColumnMapping("edition", "edition"), New System.Data.Common.DataColumnMapping("epimelitis", "epimelitis"), New System.Data.Common.DataColumnMapping("fpa", "fpa"), New System.Data.Common.DataColumnMapping("generalcode", "generalcode"), New System.Data.Common.DataColumnMapping("generalcompotitle", "generalcompotitle"), New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("ISMN", "ISMN"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("orders", "orders"), New System.Data.Common.DataColumnMapping("quantity", "quantity"), New System.Data.Common.DataColumnMapping("subcompocategory", "subcompocategory"), New System.Data.Common.DataColumnMapping("subcompocategory2", "subcompocategory2"), New System.Data.Common.DataColumnMapping("supplier", "supplier"), New System.Data.Common.DataColumnMapping("timiagoras", "timiagoras"), New System.Data.Common.DataColumnMapping("timipolisis", "timipolisis"), New System.Data.Common.DataColumnMapping("Προμηθευτής2", "Προμηθευτής2"), New System.Data.Common.DataColumnMapping("Προμηθευτής3", "Προμηθευτής3")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM tblBooks WHERE (aa = ?) AND (generalcode = ?) AND (ISBN = ? OR ? IS N" & _
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
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO tblBooks(author, bookcode, bookordernumber, booktitle, compocategory," & _
        " composer, compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle," & _
        " ISBN, ISMN, notes, orders, quantity, subcompocategory, subcompocategory2, suppl" & _
        "ier, timiagoras, timipolisis, Προμηθευτής2, Προμηθευτής3) VALUES (?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 100, "author"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, "booktitle"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "compotitle"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, "epimelitis"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("fpa", System.Data.OleDb.OleDbType.VarWChar, 50, "fpa"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "generalcompotitle"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, "timiagoras"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, "timipolisis"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής3"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT aa, author, bookcode, bookordernumber, booktitle, compocategory, composer," & _
        " compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle, ISBN, ISM" & _
        "N, notes, orders, quantity, subcompocategory, subcompocategory2, supplier, timia" & _
        "goras, timipolisis, Προμηθευτής2, Προμηθευτής3 FROM tblBooks"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE tblBooks SET author = ?, bookcode = ?, bookordernumber = ?, booktitle = ?," & _
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
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 100, "author"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, "booktitle"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "compotitle"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, "epimelitis"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("fpa", System.Data.OleDb.OleDbType.VarWChar, 50, "fpa"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "generalcompotitle"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, "timiagoras"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, "timipolisis"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής2"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, "Προμηθευτής3"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Προμηθευτής31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Προμηθευτής3", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtsparagelieslast
        '
        Me.objdtsparagelieslast.DataSetName = "dtsparagelieslast"
        Me.objdtsparagelieslast.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(592, 32)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(40, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(592, 64)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(40, 23)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.Visible = False
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(592, 96)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Size = New System.Drawing.Size(40, 23)
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'lblΑΦΜ
        '
        Me.lblΑΦΜ.Location = New System.Drawing.Point(40, 168)
        Me.lblΑΦΜ.Name = "lblΑΦΜ"
        Me.lblΑΦΜ.Size = New System.Drawing.Size(40, 23)
        Me.lblΑΦΜ.TabIndex = 3
        Me.lblΑΦΜ.Text = "ΑΦΜ"
        '
        'lblΔιεύθυνση
        '
        Me.lblΔιεύθυνση.Location = New System.Drawing.Point(40, 200)
        Me.lblΔιεύθυνση.Name = "lblΔιεύθυνση"
        Me.lblΔιεύθυνση.Size = New System.Drawing.Size(40, 23)
        Me.lblΔιεύθυνση.TabIndex = 4
        Me.lblΔιεύθυνση.Text = "Διεύθυνση"
        '
        'lblΔΟΥ
        '
        Me.lblΔΟΥ.Location = New System.Drawing.Point(40, 232)
        Me.lblΔΟΥ.Name = "lblΔΟΥ"
        Me.lblΔΟΥ.Size = New System.Drawing.Size(40, 23)
        Me.lblΔΟΥ.TabIndex = 5
        Me.lblΔΟΥ.Text = "ΔΟΥ"
        '
        'lblΈκδοση
        '
        Me.lblΈκδοση.Location = New System.Drawing.Point(40, 267)
        Me.lblΈκδοση.Name = "lblΈκδοση"
        Me.lblΈκδοση.Size = New System.Drawing.Size(40, 23)
        Me.lblΈκδοση.TabIndex = 6
        Me.lblΈκδοση.Text = "Έκδοση"
        '
        'lblΕπάγγελμα
        '
        Me.lblΕπάγγελμα.Location = New System.Drawing.Point(96, 168)
        Me.lblΕπάγγελμα.Name = "lblΕπάγγελμα"
        Me.lblΕπάγγελμα.Size = New System.Drawing.Size(40, 23)
        Me.lblΕπάγγελμα.TabIndex = 8
        Me.lblΕπάγγελμα.Text = "Επάγγελμα"
        '
        'lblΕπώνυμο
        '
        Me.lblΕπώνυμο.Location = New System.Drawing.Point(96, 200)
        Me.lblΕπώνυμο.Name = "lblΕπώνυμο"
        Me.lblΕπώνυμο.Size = New System.Drawing.Size(40, 23)
        Me.lblΕπώνυμο.TabIndex = 9
        Me.lblΕπώνυμο.Text = "Επώνυμο"
        '
        'lblΗμερομηνία
        '
        Me.lblΗμερομηνία.Location = New System.Drawing.Point(96, 232)
        Me.lblΗμερομηνία.Name = "lblΗμερομηνία"
        Me.lblΗμερομηνία.Size = New System.Drawing.Size(40, 23)
        Me.lblΗμερομηνία.TabIndex = 10
        Me.lblΗμερομηνία.Text = "Ημερομηνία"
        '
        'lblΚινητό
        '
        Me.lblΚινητό.Location = New System.Drawing.Point(96, 259)
        Me.lblΚινητό.Name = "lblΚινητό"
        Me.lblΚινητό.Size = New System.Drawing.Size(40, 23)
        Me.lblΚινητό.TabIndex = 11
        Me.lblΚινητό.Text = "Κινητό"
        '
        'editΑΦΜ
        '
        Me.editΑΦΜ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.ΑΦΜ"))
        Me.editΑΦΜ.Location = New System.Drawing.Point(152, 168)
        Me.editΑΦΜ.Name = "editΑΦΜ"
        Me.editΑΦΜ.Size = New System.Drawing.Size(40, 20)
        Me.editΑΦΜ.TabIndex = 12
        Me.editΑΦΜ.Text = ""
        '
        'editΔιεύθυνση
        '
        Me.editΔιεύθυνση.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Διεύθυνση"))
        Me.editΔιεύθυνση.Location = New System.Drawing.Point(152, 200)
        Me.editΔιεύθυνση.Name = "editΔιεύθυνση"
        Me.editΔιεύθυνση.Size = New System.Drawing.Size(40, 20)
        Me.editΔιεύθυνση.TabIndex = 13
        Me.editΔιεύθυνση.Text = ""
        '
        'editΔΟΥ
        '
        Me.editΔΟΥ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.ΔΟΥ"))
        Me.editΔΟΥ.Location = New System.Drawing.Point(152, 232)
        Me.editΔΟΥ.Name = "editΔΟΥ"
        Me.editΔΟΥ.Size = New System.Drawing.Size(40, 20)
        Me.editΔΟΥ.TabIndex = 14
        Me.editΔΟΥ.Text = ""
        '
        'editΈκδοση
        '
        Me.editΈκδοση.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Έκδοση"))
        Me.editΈκδοση.Location = New System.Drawing.Point(152, 267)
        Me.editΈκδοση.Name = "editΈκδοση"
        Me.editΈκδοση.Size = New System.Drawing.Size(40, 20)
        Me.editΈκδοση.TabIndex = 15
        Me.editΈκδοση.Text = ""
        '
        'editΕπάγγελμα
        '
        Me.editΕπάγγελμα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Επάγγελμα"))
        Me.editΕπάγγελμα.Location = New System.Drawing.Point(208, 168)
        Me.editΕπάγγελμα.Name = "editΕπάγγελμα"
        Me.editΕπάγγελμα.Size = New System.Drawing.Size(40, 20)
        Me.editΕπάγγελμα.TabIndex = 17
        Me.editΕπάγγελμα.Text = ""
        '
        'editΕπώνυμο
        '
        Me.editΕπώνυμο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Επώνυμο"))
        Me.editΕπώνυμο.Location = New System.Drawing.Point(208, 200)
        Me.editΕπώνυμο.Name = "editΕπώνυμο"
        Me.editΕπώνυμο.Size = New System.Drawing.Size(40, 20)
        Me.editΕπώνυμο.TabIndex = 18
        Me.editΕπώνυμο.Text = ""
        '
        'editΗμερομηνία
        '
        Me.editΗμερομηνία.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Ημερομηνία"))
        Me.editΗμερομηνία.Location = New System.Drawing.Point(208, 232)
        Me.editΗμερομηνία.Name = "editΗμερομηνία"
        Me.editΗμερομηνία.Size = New System.Drawing.Size(40, 20)
        Me.editΗμερομηνία.TabIndex = 19
        Me.editΗμερομηνία.Text = ""
        '
        'editΚινητό
        '
        Me.editΚινητό.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Κινητό"))
        Me.editΚινητό.Location = New System.Drawing.Point(208, 259)
        Me.editΚινητό.Name = "editΚινητό"
        Me.editΚινητό.Size = New System.Drawing.Size(40, 20)
        Me.editΚινητό.TabIndex = 20
        Me.editΚινητό.Text = ""
        '
        'lblΚωδικός_Βιβλίου
        '
        Me.lblΚωδικός_Βιβλίου.Location = New System.Drawing.Point(688, 168)
        Me.lblΚωδικός_Βιβλίου.Name = "lblΚωδικός_Βιβλίου"
        Me.lblΚωδικός_Βιβλίου.Size = New System.Drawing.Size(40, 23)
        Me.lblΚωδικός_Βιβλίου.TabIndex = 21
        Me.lblΚωδικός_Βιβλίου.Text = "Κωδικός Βιβλίου"
        '
        'lblΌνομα
        '
        Me.lblΌνομα.Location = New System.Drawing.Point(688, 200)
        Me.lblΌνομα.Name = "lblΌνομα"
        Me.lblΌνομα.Size = New System.Drawing.Size(40, 23)
        Me.lblΌνομα.TabIndex = 22
        Me.lblΌνομα.Text = "Όνομα"
        '
        'lblΌργανο
        '
        Me.lblΌργανο.Location = New System.Drawing.Point(688, 232)
        Me.lblΌργανο.Name = "lblΌργανο"
        Me.lblΌργανο.Size = New System.Drawing.Size(40, 23)
        Me.lblΌργανο.TabIndex = 23
        Me.lblΌργανο.Text = "Όργανο"
        '
        'lblΠοσότητα
        '
        Me.lblΠοσότητα.Location = New System.Drawing.Point(688, 272)
        Me.lblΠοσότητα.Name = "lblΠοσότητα"
        Me.lblΠοσότητα.Size = New System.Drawing.Size(40, 23)
        Me.lblΠοσότητα.TabIndex = 24
        Me.lblΠοσότητα.Text = "Ποσότητα"
        '
        'lblΣυγγραφέας
        '
        Me.lblΣυγγραφέας.Location = New System.Drawing.Point(608, 168)
        Me.lblΣυγγραφέας.Name = "lblΣυγγραφέας"
        Me.lblΣυγγραφέας.Size = New System.Drawing.Size(40, 23)
        Me.lblΣυγγραφέας.TabIndex = 25
        Me.lblΣυγγραφέας.Text = "Συγγραφέας"
        '
        'lblΣυνθέτης
        '
        Me.lblΣυνθέτης.Location = New System.Drawing.Point(608, 200)
        Me.lblΣυνθέτης.Name = "lblΣυνθέτης"
        Me.lblΣυνθέτης.Size = New System.Drawing.Size(40, 23)
        Me.lblΣυνθέτης.TabIndex = 26
        Me.lblΣυνθέτης.Text = "Συνθέτης"
        '
        'lblΤηλέφωνο
        '
        Me.lblΤηλέφωνο.Location = New System.Drawing.Point(608, 232)
        Me.lblΤηλέφωνο.Name = "lblΤηλέφωνο"
        Me.lblΤηλέφωνο.Size = New System.Drawing.Size(40, 23)
        Me.lblΤηλέφωνο.TabIndex = 27
        Me.lblΤηλέφωνο.Text = "Τηλέφωνο"
        '
        'lblΤιμή_Προσφοράς
        '
        Me.lblΤιμή_Προσφοράς.Location = New System.Drawing.Point(608, 264)
        Me.lblΤιμή_Προσφοράς.Name = "lblΤιμή_Προσφοράς"
        Me.lblΤιμή_Προσφοράς.Size = New System.Drawing.Size(40, 23)
        Me.lblΤιμή_Προσφοράς.TabIndex = 28
        Me.lblΤιμή_Προσφοράς.Text = "Τιμή Προσφοράς"
        '
        'lblΤίτλος_Βιβλίου
        '
        Me.lblΤίτλος_Βιβλίου.Location = New System.Drawing.Point(608, 296)
        Me.lblΤίτλος_Βιβλίου.Name = "lblΤίτλος_Βιβλίου"
        Me.lblΤίτλος_Βιβλίου.Size = New System.Drawing.Size(40, 23)
        Me.lblΤίτλος_Βιβλίου.TabIndex = 29
        Me.lblΤίτλος_Βιβλίου.Text = "Τίτλος Βιβλίου"
        '
        'editΚωδικός_Βιβλίου
        '
        Me.editΚωδικός_Βιβλίου.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Κωδικός Βιβλίου"))
        Me.editΚωδικός_Βιβλίου.Location = New System.Drawing.Point(712, 168)
        Me.editΚωδικός_Βιβλίου.Name = "editΚωδικός_Βιβλίου"
        Me.editΚωδικός_Βιβλίου.Size = New System.Drawing.Size(40, 20)
        Me.editΚωδικός_Βιβλίου.TabIndex = 30
        Me.editΚωδικός_Βιβλίου.Text = ""
        '
        'editΌνομα
        '
        Me.editΌνομα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Όνομα"))
        Me.editΌνομα.Location = New System.Drawing.Point(720, 200)
        Me.editΌνομα.Name = "editΌνομα"
        Me.editΌνομα.Size = New System.Drawing.Size(40, 20)
        Me.editΌνομα.TabIndex = 31
        Me.editΌνομα.Text = ""
        '
        'editΌργανο
        '
        Me.editΌργανο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Όργανο"))
        Me.editΌργανο.Location = New System.Drawing.Point(720, 232)
        Me.editΌργανο.Name = "editΌργανο"
        Me.editΌργανο.Size = New System.Drawing.Size(40, 20)
        Me.editΌργανο.TabIndex = 32
        Me.editΌργανο.Text = ""
        '
        'editΠοσότητα
        '
        Me.editΠοσότητα.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Ποσότητα"))
        Me.editΠοσότητα.Location = New System.Drawing.Point(720, 272)
        Me.editΠοσότητα.Name = "editΠοσότητα"
        Me.editΠοσότητα.Size = New System.Drawing.Size(40, 20)
        Me.editΠοσότητα.TabIndex = 33
        Me.editΠοσότητα.Text = ""
        '
        'editΣυγγραφέας
        '
        Me.editΣυγγραφέας.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Συγγραφέας"))
        Me.editΣυγγραφέας.Location = New System.Drawing.Point(640, 168)
        Me.editΣυγγραφέας.Name = "editΣυγγραφέας"
        Me.editΣυγγραφέας.Size = New System.Drawing.Size(40, 20)
        Me.editΣυγγραφέας.TabIndex = 34
        Me.editΣυγγραφέας.Text = ""
        '
        'editΣυνθέτης
        '
        Me.editΣυνθέτης.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Συνθέτης"))
        Me.editΣυνθέτης.Location = New System.Drawing.Point(640, 200)
        Me.editΣυνθέτης.Name = "editΣυνθέτης"
        Me.editΣυνθέτης.Size = New System.Drawing.Size(40, 20)
        Me.editΣυνθέτης.TabIndex = 35
        Me.editΣυνθέτης.Text = ""
        '
        'editΤηλέφωνο
        '
        Me.editΤηλέφωνο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Τηλέφωνο"))
        Me.editΤηλέφωνο.Location = New System.Drawing.Point(640, 232)
        Me.editΤηλέφωνο.Name = "editΤηλέφωνο"
        Me.editΤηλέφωνο.Size = New System.Drawing.Size(40, 20)
        Me.editΤηλέφωνο.TabIndex = 36
        Me.editΤηλέφωνο.Text = ""
        '
        'editofferprice
        '
        Me.editofferprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.offerprice"))
        Me.editofferprice.Location = New System.Drawing.Point(640, 264)
        Me.editofferprice.Name = "editofferprice"
        Me.editofferprice.Size = New System.Drawing.Size(40, 20)
        Me.editofferprice.TabIndex = 37
        Me.editofferprice.Text = ""
        '
        'editΤίτλος_Βιβλίου
        '
        Me.editΤίτλος_Βιβλίου.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Τίτλος Βιβλίου"))
        Me.editΤίτλος_Βιβλίου.Location = New System.Drawing.Point(640, 296)
        Me.editΤίτλος_Βιβλίου.Name = "editΤίτλος_Βιβλίου"
        Me.editΤίτλος_Βιβλίου.Size = New System.Drawing.Size(40, 20)
        Me.editΤίτλος_Βιβλίου.TabIndex = 38
        Me.editΤίτλος_Βιβλίου.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(520, 56)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 39
        Me.btnNavFirst.Text = "<<"
        Me.btnNavFirst.Visible = False
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(560, 56)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 40
        Me.btnNavPrev.Text = "<"
        Me.btnNavPrev.Visible = False
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(592, 56)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 41
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNavLocation.Visible = False
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(688, 56)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 42
        Me.btnNavNext.Text = ">"
        Me.btnNavNext.Visible = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(720, 56)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 43
        Me.btnLast.Text = ">>"
        Me.btnLast.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(520, 88)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(600, 88)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(688, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 136)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Αυτόματη Εισαγωγή Πελάτη"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.Επάγγελμα"))
        Me.Label16.Location = New System.Drawing.Point(480, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 16)
        Me.Label16.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.ΔΟΥ"))
        Me.Label15.Location = New System.Drawing.Point(384, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.ΑΦΜ"))
        Me.Label14.Location = New System.Drawing.Point(296, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.ΔιεύθυνσηΧρέωσης"))
        Me.Label13.Location = New System.Drawing.Point(120, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.kinhto"))
        Me.Label12.Location = New System.Drawing.Point(504, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.Τηλέφωνο"))
        Me.Label11.Location = New System.Drawing.Point(400, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.ΌνομαΕπαφής"))
        Me.Label10.Location = New System.Drawing.Point(280, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Πελατολόγιο.ΕπώνυμοΕπαφής"))
        Me.Label9.Location = New System.Drawing.Point(128, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(488, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Επάγγελμα"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(384, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "ΔΟΥ"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(296, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "ΑΦΜ"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(120, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Διεύθυνση"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(504, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Κινητό"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(400, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Τηλέφωνο"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(312, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Όνομα"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Επώνυμο"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 168)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(32, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 16)
        Me.Label37.TabIndex = 69
        Me.Label37.Text = "ISBN"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(24, 72)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(88, 20)
        Me.TextBox11.TabIndex = 14
        Me.TextBox11.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(488, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 16)
        Me.Label34.TabIndex = 67
        Me.Label34.Text = "Διαθέσιμα"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(416, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 24)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Καθαρισμός Πεδίων"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(632, 128)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(64, 20)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(568, 128)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(64, 20)
        Me.TextBox7.TabIndex = 17
        Me.TextBox7.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(552, 72)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(176, 20)
        Me.TextBox8.TabIndex = 12
        Me.TextBox8.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(112, 72)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(88, 20)
        Me.TextBox9.TabIndex = 10
        Me.TextBox9.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(360, 128)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(224, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 20)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(352, 20)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = ""
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 24)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Αυτόματη Εισαγωγή Βιβλίου"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.timipolisis"))
        Me.Label17.Location = New System.Drawing.Point(528, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 56
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.quantity"))
        Me.Label18.Location = New System.Drawing.Point(488, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 55
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.author"))
        Me.Label19.Location = New System.Drawing.Point(384, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.bookcode"))
        Me.Label20.Location = New System.Drawing.Point(303, 195)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(8, 8)
        Me.Label20.TabIndex = 53
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.edition"))
        Me.Label21.Location = New System.Drawing.Point(240, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 52
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.subcompocategory2"))
        Me.Label22.Location = New System.Drawing.Point(168, 200)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 51
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.booktitle"))
        Me.Label23.Location = New System.Drawing.Point(96, 200)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 50
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.composer"))
        Me.Label24.Location = New System.Drawing.Point(24, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 49
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(632, 112)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 16)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Τιμή "
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(568, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 16)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Ποσότητα"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(560, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Συγγραφέας"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(112, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "Κωδικός Βιβλίου"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(360, 112)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Έκδοση"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(224, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Υποκατηγορία 2"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(216, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 16)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Τίτλος Βιβλίου"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(64, 112)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 16)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Συνθέτης"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(392, 352)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.Text = "=today"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(408, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 24)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Καταχώρηση"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.αρίθμησηεγγραφών"))
        Me.TextBox10.Location = New System.Drawing.Point(712, 296)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(32, 20)
        Me.TextBox10.TabIndex = 51
        Me.TextBox10.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(392, 336)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 52
        Me.Label33.Text = "Ημερομηνία"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(96, 291)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 23)
        Me.Label35.TabIndex = 54
        Me.Label35.Text = "ολοκληρ"
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Ολοκληρώθηκε"))
        Me.TextBox12.Location = New System.Drawing.Point(208, 291)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(40, 20)
        Me.TextBox12.TabIndex = 55
        Me.TextBox12.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Ναι", "Όχι"})
        Me.ComboBox1.Location = New System.Drawing.Point(520, 352)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 21
        Me.ComboBox1.Text = "Όχι"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(512, 336)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 16)
        Me.Label36.TabIndex = 57
        Me.Label36.Text = "Ολοκληρώθηκε"
        '
        'editISBN
        '
        Me.editISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.ISBN"))
        Me.editISBN.Location = New System.Drawing.Point(40, 291)
        Me.editISBN.Name = "editISBN"
        Me.editISBN.Size = New System.Drawing.Size(72, 20)
        Me.editISBN.TabIndex = 58
        Me.editISBN.Text = ""
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.ISBN"))
        Me.TextBox13.Location = New System.Drawing.Point(568, 176)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(32, 20)
        Me.TextBox13.TabIndex = 59
        Me.TextBox13.Text = ""
        '
        'Label38
        '
        Me.Label38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.bookcode"))
        Me.Label38.Location = New System.Drawing.Point(24, 192)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 16)
        Me.Label38.TabIndex = 60
        '
        'Label39
        '
        Me.Label39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "tblBooks.timipolisis"))
        Me.Label39.Location = New System.Drawing.Point(62, 293)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 16)
        Me.Label39.TabIndex = 61
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Εισαγωγή Παραγγελίας"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Κλείσιμο"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(208, 336)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(144, 16)
        Me.Label40.TabIndex = 63
        Me.Label40.Text = "Τρόπος Παράδοσης"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"Κατάστημα", "ΕΛΤΑ - Αντικαταβολή", "Courrier"})
        Me.ComboBox2.Location = New System.Drawing.Point(208, 352)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox2.TabIndex = 19
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.Παράδοση"))
        Me.TextBox14.Location = New System.Drawing.Point(272, 291)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(104, 20)
        Me.TextBox14.TabIndex = 65
        Me.TextBox14.Text = ""
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(16, 152)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(752, 224)
        Me.TextBox15.TabIndex = 70
        Me.TextBox15.Text = ""
        Me.TextBox15.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(272, 384)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 24)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "Σημειώσεις"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(368, 384)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 24)
        Me.Button6.TabIndex = 71
        Me.Button6.Text = "OK"
        Me.Button6.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelieslast, "Παραγγελίες.OrderNotes"))
        Me.TextBox16.ForeColor = System.Drawing.SystemColors.Control
        Me.TextBox16.Location = New System.Drawing.Point(8, 112)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(208, 13)
        Me.TextBox16.TabIndex = 72
        Me.TextBox16.Text = ""
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(32, 64)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(104, 20)
        Me.TextBox17.TabIndex = 73
        Me.TextBox17.Text = ""
        '
        'frmParagelieslast
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.lblΚωδικός_Βιβλίου)
        Me.Controls.Add(Me.lblΌνομα)
        Me.Controls.Add(Me.lblΌργανο)
        Me.Controls.Add(Me.lblΠοσότητα)
        Me.Controls.Add(Me.lblΣυγγραφέας)
        Me.Controls.Add(Me.lblΣυνθέτης)
        Me.Controls.Add(Me.lblΤηλέφωνο)
        Me.Controls.Add(Me.lblΤιμή_Προσφοράς)
        Me.Controls.Add(Me.lblΤίτλος_Βιβλίου)
        Me.Controls.Add(Me.editΚωδικός_Βιβλίου)
        Me.Controls.Add(Me.editΌνομα)
        Me.Controls.Add(Me.editΌργανο)
        Me.Controls.Add(Me.editΠοσότητα)
        Me.Controls.Add(Me.editΣυγγραφέας)
        Me.Controls.Add(Me.editΣυνθέτης)
        Me.Controls.Add(Me.editΤηλέφωνο)
        Me.Controls.Add(Me.editofferprice)
        Me.Controls.Add(Me.editΤίτλος_Βιβλίου)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.lblΑΦΜ)
        Me.Controls.Add(Me.lblΔιεύθυνση)
        Me.Controls.Add(Me.lblΔΟΥ)
        Me.Controls.Add(Me.lblΈκδοση)
        Me.Controls.Add(Me.lblΕπάγγελμα)
        Me.Controls.Add(Me.lblΕπώνυμο)
        Me.Controls.Add(Me.lblΗμερομηνία)
        Me.Controls.Add(Me.lblΚινητό)
        Me.Controls.Add(Me.editΑΦΜ)
        Me.Controls.Add(Me.editΔιεύθυνση)
        Me.Controls.Add(Me.editΔΟΥ)
        Me.Controls.Add(Me.editΈκδοση)
        Me.Controls.Add(Me.editΕπάγγελμα)
        Me.Controls.Add(Me.editΕπώνυμο)
        Me.Controls.Add(Me.editΗμερομηνία)
        Me.Controls.Add(Me.editΚινητό)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.editISBN)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox17)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmParagelieslast"
        Me.Text = "Παραγγελίες"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsparagelieslast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").CancelCurrentEdit()
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Count > 0) Then
            Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").RemoveAt(Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position)
            Me.objdtsparagelieslast_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").EndCurrentEdit()
            Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsparagelieslast_PositionChanged()

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
        Me.objdtsparagelieslast_PositionChanged()

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
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position = 0
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position = (Me.objdtsparagelieslast.Tables("Παραγγελίες").Rows.Count - 1)
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position = (Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position - 1)
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position = (Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position + 1)
        Me.objdtsparagelieslast_PositionChanged()

    End Sub
    Private Sub objdtsparagelieslast_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsparagelieslast.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsparagelieslast = New prjctDoReMi.dtsparagelieslast
        'Stop any current edits.
        Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsparagelieslast.GetChanges, prjctDoReMi.dtsparagelieslast)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsparagelieslast.Merge(objDataSetChanges)
                objdtsparagelieslast.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsparagelieslast
        objDataSetTemp = New prjctDoReMi.dtsparagelieslast
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsparagelieslast.Clear()
            'Merge the records into the main dataset.
            objdtsparagelieslast.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsparagelieslast)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
                OleDbDataAdapter2.Update(ChangedRows)
                OleDbDataAdapter3.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsparagelieslast)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
            Me.OleDbDataAdapter2.Fill(dataSet)
            Me.OleDbDataAdapter3.Fill(dataSet)
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
        Dim a As New frmCustomers
        a.MdiParent = prjctDoReMi.frmMain.ActiveForm
        a.Show()
    End Sub

    Private Sub frmParagelieslast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        Module1.tempdate = True
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsparagelieslast_PositionChanged()
    End Sub

    Private Sub frmParagelieslast_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Me.WindowState = FormWindowState.Maximized
        If Module1.tempdate = True Then
            TextBox3.Text = Today
            Module1.tempdate = False
        End If


        If Module1.tempswitch = True Then
            Dim varsql As New OleDb.OleDbCommand("select * from tblBooks where aa like '" & Module1.vartempISBN & "'; ", OleDbConnection1)
            OleDbDataAdapter3.SelectCommand = varsql
            Try
                'Attempt to load the dataset.
                Me.LoadDataSet()
            Catch eLoad As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eLoad.Message)
            End Try
            Me.objdtsparagelieslast_PositionChanged()
            TextBox1.Text = Label24.Text
            TextBox2.Text = Label23.Text
            TextBox5.Text = Label22.Text
            TextBox4.Text = Label21.Text
            TextBox9.Text = Label38.Text
            TextBox8.Text = Label19.Text
            TextBox11.Text = TextBox13.Text
            TextBox6.Text = Label39.Text
            Module1.tempswitch = False
        End If
        If Module1.tempswitch2 = True Then
            Dim varsql2 As New OleDb.OleDbCommand("select * from Πελατολόγιο where ΚωδΑγοραστή like '" & Module1.vartempcuscode & "' ;", OleDbConnection1)
            OleDbDataAdapter2.SelectCommand = varsql2
            Try
                'Attempt to load the dataset.
                Me.LoadDataSet()
            Catch eLoad As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eLoad.Message)
            End Try
            Me.objdtsparagelieslast_PositionChanged()
            Module1.tempswitch2 = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As New frmBookSearch
        a.MdiParent = prjctDoReMi.frmMain.ActiveForm
        a.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox11.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").EndCurrentEdit()
            Me.BindingContext(objdtsparagelieslast, "Παραγγελίες").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsparagelieslast_PositionChanged()

        editΣυνθέτης.Text = TextBox1.Text
        editΤίτλος_Βιβλίου.Text = TextBox2.Text
        editΌργανο.Text = TextBox5.Text
        editΈκδοση.Text = TextBox4.Text
        editΣυγγραφέας.Text = TextBox8.Text
        editΠοσότητα.Text = TextBox7.Text
        editΕπώνυμο.Text = Label9.Text
        editΌνομα.Text = Label10.Text
        editΕπάγγελμα.Text = Label10.Text
        editΤηλέφωνο.Text = Label11.Text
        editΚινητό.Text = Label12.Text
        editΔιεύθυνση.Text = Label13.Text
        editΑΦΜ.Text = Label14.Text
        editΔΟΥ.Text = Label15.Text
        editΕπάγγελμα.Text = Label16.Text
        editΗμερομηνία.Text = TextBox3.Text
        editISBN.Text = TextBox11.Text
        editΚωδικός_Βιβλίου.Text = TextBox9.Text
        editofferprice.Text = Val(Label39.Text)
        TextBox12.Text = ComboBox1.Text
        TextBox14.Text = ComboBox2.Text
        If TextBox17.Text = "" Then
            TextBox16.Text = "  "
        Else
            TextBox16.Text = TextBox17.Text
        End If

        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsparagelieslast_PositionChanged()

        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""


        editΣυνθέτης.Text = ""
        editΤίτλος_Βιβλίου.Text = ""
        editΌργανο.Text = ""
        editΈκδοση.Text = ""
        editΣυγγραφέας.Text = ""
        editΠοσότητα.Text = ""
        editofferprice.Text = ""
        editΕπώνυμο.Text = ""
        editΕπάγγελμα.Text = ""
        editΤηλέφωνο.Text = ""
        editΚινητό.Text = ""
        editΔιεύθυνση.Text = ""
        editΑΦΜ.Text = ""
        editΔΟΥ.Text = ""
        editΕπάγγελμα.Text = ""
        editΗμερομηνία.Text = ""
        editISBN.Text = ""
        TextBox12.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = Today

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox11.Text = ""

        MsgBox("Η παραγγελία καταχωρήθηκε με επιτυχία!")

    End Sub

   
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox15.BringToFront()
        TextBox15.Visible = True
        Button6.Visible = True
        Button5.Visible = False
        Button4.Visible = False

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox17.Text = TextBox15.Text
        TextBox15.SendToBack()
        TextBox15.Visible = False
        Button6.Visible = False
        Button5.Visible = True
        Button4.Visible = True
    End Sub
End Class
