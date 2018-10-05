Public Class frmCustomers
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
    Friend WithEvents objdtsCustomers As prjctDoReMi.dtsCustomers
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents grdΠελατολόγιο As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.objdtsCustomers = New prjctDoReMi.dtsCustomers
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.grdΠελατολόγιο = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.objdtsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdΠελατολόγιο, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Πελατολόγιο", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("kinhto", "kinhto"), New System.Data.Common.DataColumnMapping("website", "website"), New System.Data.Common.DataColumnMapping("ΑριθμόςΦαξ", "ΑριθμόςΦαξ"), New System.Data.Common.DataColumnMapping("ΑΦΜ", "ΑΦΜ"), New System.Data.Common.DataColumnMapping("ΔιεύθυνσηEmail", "ΔιεύθυνσηEmail"), New System.Data.Common.DataColumnMapping("ΔιεύθυνσηΧρέωσης", "ΔιεύθυνσηΧρέωσης"), New System.Data.Common.DataColumnMapping("ΔΟΥ", "ΔΟΥ"), New System.Data.Common.DataColumnMapping("Επάγγελμα", "Επάγγελμα"), New System.Data.Common.DataColumnMapping("ΕπωνυμίαΕταιρείας", "ΕπωνυμίαΕταιρείας"), New System.Data.Common.DataColumnMapping("ΕπώνυμοΕπαφής", "ΕπώνυμοΕπαφής"), New System.Data.Common.DataColumnMapping("ΚωδΑγοραστή", "ΚωδΑγοραστή"), New System.Data.Common.DataColumnMapping("Νομός/Περιοχή", "Νομός/Περιοχή"), New System.Data.Common.DataColumnMapping("ΌνομαΕπαφής", "ΌνομαΕπαφής"), New System.Data.Common.DataColumnMapping("Πόλη", "Πόλη"), New System.Data.Common.DataColumnMapping("Σημειώσεις", "Σημειώσεις"), New System.Data.Common.DataColumnMapping("ΤαχυδρομικόςΚώδικας", "ΤαχυδρομικόςΚώδικας"), New System.Data.Common.DataColumnMapping("Τηλέφωνο", "Τηλέφωνο"), New System.Data.Common.DataColumnMapping("Τηλέφωνο1", "Τηλέφωνο1"), New System.Data.Common.DataColumnMapping("Χώρα/Περιοχή", "Χώρα/Περιοχή")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
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
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=0;Data Source=""C:\Program Files\doremi\dbMain.mdb"";Jet OLEDB:Engine " & _
        "Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:S" & _
        "FP=False;persist security info=False;Extended Properties=;Mode=Share Deny None;J" & _
        "et OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB" & _
        ":Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fal" & _
        "se;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Πελατολόγιο(kinhto, website, ΑριθμόςΦαξ, ΑΦΜ, ΔιεύθυνσηEmail, Διεύθυν" & _
        "σηΧρέωσης, ΔΟΥ, Επάγγελμα, ΕπωνυμίαΕταιρείας, ΕπώνυμοΕπαφής, ΚωδΑγοραστή, [Νομός" & _
        "/Περιοχή], ΌνομαΕπαφής, Πόλη, Σημειώσεις, ΤαχυδρομικόςΚώδικας, Τηλέφωνο, Τηλέφων" & _
        "ο1, [Χώρα/Περιοχή]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑριθμόςΦαξ", System.Data.OleDb.OleDbType.VarWChar, 30, "ΑριθμόςΦαξ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΑΦΜ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΑΦΜ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηEmail", System.Data.OleDb.OleDbType.VarWChar, 50, "ΔιεύθυνσηEmail"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔιεύθυνσηΧρέωσης", System.Data.OleDb.OleDbType.VarWChar, 255, "ΔιεύθυνσηΧρέωσης"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΔΟΥ", System.Data.OleDb.OleDbType.VarWChar, 12, "ΔΟΥ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Επάγγελμα", System.Data.OleDb.OleDbType.VarWChar, 50, "Επάγγελμα"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπωνυμίαΕταιρείας", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπωνυμίαΕταιρείας"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΕπώνυμοΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 50, "ΕπώνυμοΕπαφής"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, "ΚωδΑγοραστή"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Νομός_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 20, "Νομός/Περιοχή"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΌνομαΕπαφής", System.Data.OleDb.OleDbType.VarWChar, 30, "ΌνομαΕπαφής"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Πόλη", System.Data.OleDb.OleDbType.VarWChar, 50, "Πόλη"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Σημειώσεις", System.Data.OleDb.OleDbType.VarWChar, 0, "Σημειώσεις"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ΤαχυδρομικόςΚώδικας", System.Data.OleDb.OleDbType.VarWChar, 20, "ΤαχυδρομικόςΚώδικας"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Τηλέφωνο1", System.Data.OleDb.OleDbType.VarWChar, 30, "Τηλέφωνο1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Χώρα_Περιοχή", System.Data.OleDb.OleDbType.VarWChar, 50, "Χώρα/Περιοχή"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT kinhto, website, ΑριθμόςΦαξ, ΑΦΜ, ΔιεύθυνσηEmail, ΔιεύθυνσηΧρέωσης, ΔΟΥ, Ε" & _
        "πάγγελμα, ΕπωνυμίαΕταιρείας, ΕπώνυμοΕπαφής, ΚωδΑγοραστή, [Νομός/Περιοχή], ΌνομαΕ" & _
        "παφής, Πόλη, Σημειώσεις, ΤαχυδρομικόςΚώδικας, Τηλέφωνο, Τηλέφωνο1, [Χώρα/Περιοχή" & _
        "] FROM Πελατολόγιο"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'objdtsCustomers
        '
        Me.objdtsCustomers.DataSetName = "dtsCustomers"
        Me.objdtsCustomers.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(16, 360)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 16)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.Visible = False
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(624, 8)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'grdΠελατολόγιο
        '
        Me.grdΠελατολόγιο.DataMember = "Πελατολόγιο"
        Me.grdΠελατολόγιο.DataSource = Me.objdtsCustomers
        Me.grdΠελατολόγιο.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdΠελατολόγιο.Location = New System.Drawing.Point(16, 176)
        Me.grdΠελατολόγιο.Name = "grdΠελατολόγιο"
        Me.grdΠελατολόγιο.ReadOnly = True
        Me.grdΠελατολόγιο.Size = New System.Drawing.Size(686, 352)
        Me.grdΠελατολόγιο.TabIndex = 3
        Me.grdΠελατολόγιο.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdΠελατολόγιο.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdΠελατολόγιο
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Πελατολόγιο"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Κωδικός"
        Me.DataGridTextBoxColumn6.MappingName = "ΚωδΑγοραστή"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Επωνυμία Εταιρείας"
        Me.DataGridTextBoxColumn4.MappingName = "ΕπωνυμίαΕταιρείας"
        Me.DataGridTextBoxColumn4.NullText = "-"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Επώνυμο"
        Me.DataGridTextBoxColumn5.MappingName = "ΕπώνυμοΕπαφής"
        Me.DataGridTextBoxColumn5.NullText = "-"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Όνομα"
        Me.DataGridTextBoxColumn8.MappingName = "ΌνομαΕπαφής"
        Me.DataGridTextBoxColumn8.NullText = "-"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Διεύθυνση"
        Me.DataGridTextBoxColumn3.MappingName = "ΔιεύθυνσηΧρέωσης"
        Me.DataGridTextBoxColumn3.NullText = "-"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Πόλη"
        Me.DataGridTextBoxColumn9.MappingName = "Πόλη"
        Me.DataGridTextBoxColumn9.NullText = "Χωρίς Πόλη"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Χώρα"
        Me.DataGridTextBoxColumn1.MappingName = "Χώρα/Περιοχή"
        Me.DataGridTextBoxColumn1.NullText = "-"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Τηλέφωνο"
        Me.DataGridTextBoxColumn12.MappingName = "Τηλέφωνο"
        Me.DataGridTextBoxColumn12.NullText = "-"
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Κινητό"
        Me.DataGridTextBoxColumn13.MappingName = "kinhto"
        Me.DataGridTextBoxColumn13.NullText = "-"
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "ΑΦΜ"
        Me.DataGridTextBoxColumn15.MappingName = "ΑΦΜ"
        Me.DataGridTextBoxColumn15.NullText = "-"
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "ΔΟΥ"
        Me.DataGridTextBoxColumn16.MappingName = "ΔΟΥ"
        Me.DataGridTextBoxColumn16.NullText = "-"
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Επάγγελμα"
        Me.DataGridTextBoxColumn17.MappingName = "Επάγγελμα"
        Me.DataGridTextBoxColumn17.NullText = "-"
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(544, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Αναζήτηση με βάση την Πόλη"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(312, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Αναζήτηση με βάση το Επώνυμο"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(560, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(328, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "’νοιγμα Καρτέλας Πελατών"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Καταχώρηση στις Κινήσεις"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(88, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Αναζήτηση με βάση την Επωνυμία"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(416, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 40)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Καθαρισμός και εμφάνιση όλων"
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(720, 528)
        Me.CrystalReportViewer1.TabIndex = 19
        Me.CrystalReportViewer1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(576, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 40)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Εκτύπωση"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(282, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 24)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Κλείσιμο"
        Me.Button5.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Αναζήτηση Πελατών"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Κλείσιμο"
        '
        'frmCustomers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 529)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.grdΠελατολόγιο)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Αναζήτηση Πελατών"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdΠελατολόγιο, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try

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

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsCustomers.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsCustomers = New prjctDoReMi.dtsCustomers
        'Stop any current edits.
        Me.BindingContext(objdtsCustomers, "Πελατολόγιο").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsCustomers.GetChanges, prjctDoReMi.dtsCustomers)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsCustomers.Merge(objDataSetChanges)
                objdtsCustomers.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsCustomers
        objDataSetTemp = New prjctDoReMi.dtsCustomers
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            grdΠελατολόγιο.DataSource = Nothing
            'Empty the old records from the dataset.
            objdtsCustomers.Clear()
            'Merge the records into the main dataset.
            objdtsCustomers.Merge(objDataSetTemp)
            grdΠελατολόγιο.SetDataBinding(objdtsCustomers, "Πελατολόγιο")
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsCustomers)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsCustomers)
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

    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim varsql As New OleDb.OleDbCommand("select * from Πελατολόγιο where ΕπώνυμοΕπαφής like '" & TextBox1.Text & "%'  and ΕπωνυμίαΕταιρείας like '" & TextBox3.Text & "%' and Πόλη like '" & TextBox2.Text & "%';", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsql
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Dim varsql As New OleDb.OleDbCommand("select * from Πελατολόγιο where ΕπώνυμοΕπαφής like '" & TextBox1.Text & "%'  and ΕπωνυμίαΕταιρείας like '" & TextBox3.Text & "%' and Πόλη like '" & TextBox2.Text & "%';", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsql
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo mistake
        If grdΠελατολόγιο.Item(grdΠελατολόγιο.CurrentCell.RowNumber, 0) <> "" Then
            Module1.varCustomertemp = grdΠελατολόγιο.Item(grdΠελατολόγιο.CurrentCell.RowNumber, 0)
        Else
            Module1.varCustomertemp = ""
        End If
        Module1.currec = Me.BindingContext(objdtsCustomers, "Πελατολόγιο").Position


        Dim ff As New frmCustomermod
        ff.Show()
        Exit Sub
mistake:
        Dim nn As New frmCustomermod
        nn.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo mistake

        Module1.vartempcuscode = grdΠελατολόγιο.Item(grdΠελατολόγιο.CurrentCell.RowNumber, 0)
        Module1.tempswitch2 = True
        Me.Close()
        Exit Sub

mistake:
        MsgBox("Ο συγκεκριμένος πελάτης έχει ελειπή στοιχεία. Παρακαλώ ενημερώστε την εγγραφή του πελάτη και δοκιμάστε ξανά.")

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim varsql As New OleDb.OleDbCommand("select * from Πελατολόγιο where ΕπώνυμοΕπαφής like '" & TextBox1.Text & "%'  and ΕπωνυμίαΕταιρείας like '" & TextBox3.Text & "%' and Πόλη like '" & TextBox2.Text & "%';", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsql
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Dim varsqlall As New OleDb.OleDbCommand("select * from Πελατολόγιο", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsqlall
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try


    End Sub

    Private Sub frmCustomers_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        Me.WindowState = FormWindowState.Maximized
        Dim showall As New OleDb.OleDbCommand("select * from Πελατολόγιο;", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = showall

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.BindingContext(objdtsCustomers, "Πελατολόγιο").Position = Module1.currec
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim report As New rptCustomers
        report.SetDataSource(objdtsCustomers)
        CrystalReportViewer1.Visible = True
        Button5.Visible = True
        CrystalReportViewer1.BringToFront()
        Button5.BringToFront()
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Visible = False
        CrystalReportViewer1.Visible = False

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
End Class
