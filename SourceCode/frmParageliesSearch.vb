Public Class frmParageliesSearch
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
    Friend WithEvents objdtsparagelliessearch As prjctDoReMi.dtsparagelliessearch
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents lbl������� As System.Windows.Forms.Label
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents lbl�������_������� As System.Windows.Forms.Label
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents edit�������_������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl������������ As System.Windows.Forms.Label
    Friend WithEvents lbl����� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl����_��������� As System.Windows.Forms.Label
    Friend WithEvents lbl������_������� As System.Windows.Forms.Label
    Friend WithEvents edit����� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents edit����_��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������_������� As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.objdtsparagelliessearch = New prjctDoReMi.dtsparagelliessearch
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lbl��� = New System.Windows.Forms.Label
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.lbl��� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.lbl������� = New System.Windows.Forms.Label
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.lbl�������_������� = New System.Windows.Forms.Label
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.edit������� = New System.Windows.Forms.TextBox
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.edit�������_������� = New System.Windows.Forms.TextBox
        Me.lbl������������ = New System.Windows.Forms.Label
        Me.lbl����� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl����_��������� = New System.Windows.Forms.Label
        Me.lbl������_������� = New System.Windows.Forms.Label
        Me.edit����� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.edit����_��������� = New System.Windows.Forms.TextBox
        Me.edit������_������� = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button4 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.objdtsparagelliessearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "�����������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("offerprice", "offerprice"), New System.Data.Common.DataColumnMapping("OrderNotes", "OrderNotes"), New System.Data.Common.DataColumnMapping("����������������", "����������������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("�������", "�������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("������� �������", "������� �������"), New System.Data.Common.DataColumnMapping("������������", "������������"), New System.Data.Common.DataColumnMapping("�����", "�����"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("������ �������", "������ �������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ����������� WHERE (���������������� = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Registry Path=;Data Source=""C:\Program Files\doremi\dbMain.mdb"";Jet OLE" & _
        "DB:System database=;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:Don't Copy Lo" & _
        "cale on Compact=False;User ID=Admin;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB" & _
        ":Database Locking Mode=1;Jet OLEDB:SFP=False;Jet OLEDB:Encrypt Database=False;Je" & _
        "t OLEDB:Create System Database=False;Jet OLEDB:Compact Without Replica Repair=Fa" & _
        "lse;Jet OLEDB:Global Partial Bulk Ops=2;Mode=Share Deny None;Extended Properties" & _
        "=;Jet OLEDB:Engine Type=5"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO �����������(ISBN, offerprice, OrderNotes, ���, ���������, ���, ������" & _
        ", ���������, �������, ����������, ������, [������� �������], ������������, �����" & _
        ", ������, ��������, ��������, ����������, ��������, ��������, [������ �������]) " & _
        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("offerprice", System.Data.OleDb.OleDbType.Integer, 0, "offerprice"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderNotes", System.Data.OleDb.OleDbType.VarChar, 0, "OrderNotes"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 10, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 20, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 30, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 30, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 30, "�������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.DBDate, 0, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 15, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "������� �������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 10, "������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����", System.Data.OleDb.OleDbType.VarWChar, 30, "�����"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 20, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 50, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.Integer, 0, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 15, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "������ �������"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ISBN, offerprice, OrderNotes, ����������������, ���, ���������, ���, �����" & _
        "�, ���������, �������, ����������, ������, [������� �������], ������������, ����" & _
        "�, ������, ��������, ��������, ����������, ��������, ��������, [������ �������] " & _
        "FROM �����������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ����������� SET ISBN = ?, offerprice = ?, OrderNotes = ?, ��� = ?, �������" & _
        "�� = ?, ��� = ?, ������ = ?, ��������� = ?, ������� = ?, ���������� = ?, ������ " & _
        "= ?, [������� �������] = ?, ������������ = ?, ����� = ?, ������ = ?, �������� = " & _
        "?, �������� = ?, ���������� = ?, �������� = ?, �������� = ?, [������ �������] = " & _
        "? WHERE (���������������� = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("offerprice", System.Data.OleDb.OleDbType.Integer, 0, "offerprice"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderNotes", System.Data.OleDb.OleDbType.VarChar, 0, "OrderNotes"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 10, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 20, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 30, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 30, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 30, "�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.DBDate, 0, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 15, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "������� �������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 10, "������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����", System.Data.OleDb.OleDbType.VarWChar, 30, "�����"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 20, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 50, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.Integer, 0, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 15, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "������ �������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtsparagelliessearch
        '
        Me.objdtsparagelliessearch.DataSetName = "dtsparagelliessearch"
        Me.objdtsparagelliessearch.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(528, 392)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(652, 208)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 24)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "���������"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(648, 408)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(14, 160)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.Size = New System.Drawing.Size(64, 16)
        Me.lbl���.TabIndex = 3
        Me.lbl���.Text = "���"
        Me.lbl���.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(17, 106)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.Size = New System.Drawing.Size(64, 16)
        Me.lbl���������.TabIndex = 4
        Me.lbl���������.Text = "���������"
        Me.lbl���������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(25, 186)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.Size = New System.Drawing.Size(56, 16)
        Me.lbl���.TabIndex = 5
        Me.lbl���.Text = "���"
        Me.lbl���.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(16, 195)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(80, 16)
        Me.lbl������.TabIndex = 6
        Me.lbl������.Text = "������"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(15, 212)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.Size = New System.Drawing.Size(64, 16)
        Me.lbl���������.TabIndex = 7
        Me.lbl���������.Text = "���������"
        Me.lbl���������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl�������
        '
        Me.lbl�������.Location = New System.Drawing.Point(16, 24)
        Me.lbl�������.Name = "lbl�������"
        Me.lbl�������.Size = New System.Drawing.Size(64, 16)
        Me.lbl�������.TabIndex = 8
        Me.lbl�������.Text = "�������"
        Me.lbl�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(21, 221)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(80, 16)
        Me.lbl����������.TabIndex = 9
        Me.lbl����������.Text = "����������"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(26, 79)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(56, 16)
        Me.lbl������.TabIndex = 10
        Me.lbl������.Text = "������"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl�������_�������
        '
        Me.lbl�������_�������.Location = New System.Drawing.Point(8, 19)
        Me.lbl�������_�������.Name = "lbl�������_�������"
        Me.lbl�������_�������.Size = New System.Drawing.Size(88, 16)
        Me.lbl�������_�������.TabIndex = 11
        Me.lbl�������_�������.Text = "������� �������"
        Me.lbl�������_�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit���
        '
        Me.edit���.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.���"))
        Me.edit���.Location = New System.Drawing.Point(87, 159)
        Me.edit���.Name = "edit���"
        Me.edit���.ReadOnly = True
        Me.edit���.Size = New System.Drawing.Size(193, 20)
        Me.edit���.TabIndex = 11
        Me.edit���.Text = ""
        '
        'edit���������
        '
        Me.edit���������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(86, 106)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.ReadOnly = True
        Me.edit���������.Size = New System.Drawing.Size(194, 20)
        Me.edit���������.TabIndex = 9
        Me.edit���������.Text = ""
        '
        'edit���
        '
        Me.edit���.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.���"))
        Me.edit���.Location = New System.Drawing.Point(88, 184)
        Me.edit���.Name = "edit���"
        Me.edit���.ReadOnly = True
        Me.edit���.Size = New System.Drawing.Size(192, 20)
        Me.edit���.TabIndex = 12
        Me.edit���.Text = ""
        '
        'edit������
        '
        Me.edit������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������"))
        Me.edit������.Location = New System.Drawing.Point(104, 195)
        Me.edit������.Name = "edit������"
        Me.edit������.ReadOnly = True
        Me.edit������.Size = New System.Drawing.Size(208, 20)
        Me.edit������.TabIndex = 5
        Me.edit������.Text = ""
        '
        'edit���������
        '
        Me.edit���������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(88, 212)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.ReadOnly = True
        Me.edit���������.Size = New System.Drawing.Size(192, 20)
        Me.edit���������.TabIndex = 13
        Me.edit���������.Text = ""
        '
        'edit�������
        '
        Me.edit�������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.�������"))
        Me.edit�������.Location = New System.Drawing.Point(85, 24)
        Me.edit�������.Name = "edit�������"
        Me.edit�������.ReadOnly = True
        Me.edit�������.Size = New System.Drawing.Size(195, 20)
        Me.edit�������.TabIndex = 6
        Me.edit�������.Text = ""
        '
        'edit����������
        '
        Me.edit����������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(104, 219)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.ReadOnly = True
        Me.edit����������.Size = New System.Drawing.Size(208, 20)
        Me.edit����������.TabIndex = 14
        Me.edit����������.Text = ""
        '
        'edit������
        '
        Me.edit������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������"))
        Me.edit������.Location = New System.Drawing.Point(87, 79)
        Me.edit������.Name = "edit������"
        Me.edit������.ReadOnly = True
        Me.edit������.Size = New System.Drawing.Size(193, 20)
        Me.edit������.TabIndex = 8
        Me.edit������.Text = ""
        '
        'edit�������_�������
        '
        Me.edit�������_�������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit�������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������� �������"))
        Me.edit�������_�������.Location = New System.Drawing.Point(104, 19)
        Me.edit�������_�������.Name = "edit�������_�������"
        Me.edit�������_�������.ReadOnly = True
        Me.edit�������_�������.Size = New System.Drawing.Size(208, 20)
        Me.edit�������_�������.TabIndex = 1
        Me.edit�������_�������.Text = ""
        '
        'lbl������������
        '
        Me.lbl������������.Location = New System.Drawing.Point(18, 15)
        Me.lbl������������.Name = "lbl������������"
        Me.lbl������������.Size = New System.Drawing.Size(88, 16)
        Me.lbl������������.TabIndex = 21
        Me.lbl������������.Text = "������������"
        Me.lbl������������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl�����
        '
        Me.lbl�����.Location = New System.Drawing.Point(15, 52)
        Me.lbl�����.Name = "lbl�����"
        Me.lbl�����.Size = New System.Drawing.Size(64, 16)
        Me.lbl�����.TabIndex = 22
        Me.lbl�����.Text = "�����"
        Me.lbl�����.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(16, 171)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(80, 16)
        Me.lbl������.TabIndex = 23
        Me.lbl������.Text = "������"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(37, 59)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(56, 16)
        Me.lbl��������.TabIndex = 24
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(16, 146)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(80, 16)
        Me.lbl����������.TabIndex = 25
        Me.lbl����������.Text = "����������"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(16, 121)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(80, 16)
        Me.lbl��������.TabIndex = 26
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(16, 133)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(64, 16)
        Me.lbl��������.TabIndex = 27
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl����_���������
        '
        Me.lbl����_���������.Location = New System.Drawing.Point(13, 103)
        Me.lbl����_���������.Name = "lbl����_���������"
        Me.lbl����_���������.Size = New System.Drawing.Size(96, 16)
        Me.lbl����_���������.TabIndex = 28
        Me.lbl����_���������.Text = "����"
        Me.lbl����_���������.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl������_�������
        '
        Me.lbl������_�������.Location = New System.Drawing.Point(16, 75)
        Me.lbl������_�������.Name = "lbl������_�������"
        Me.lbl������_�������.Size = New System.Drawing.Size(80, 16)
        Me.lbl������_�������.TabIndex = 29
        Me.lbl������_�������.Text = "������ �������"
        Me.lbl������_�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit�����
        '
        Me.edit�����.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit�����.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.�����"))
        Me.edit�����.Location = New System.Drawing.Point(86, 52)
        Me.edit�����.Name = "edit�����"
        Me.edit�����.ReadOnly = True
        Me.edit�����.Size = New System.Drawing.Size(194, 20)
        Me.edit�����.TabIndex = 7
        Me.edit�����.Text = ""
        '
        'edit������
        '
        Me.edit������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������"))
        Me.edit������.Location = New System.Drawing.Point(104, 171)
        Me.edit������.Name = "edit������"
        Me.edit������.ReadOnly = True
        Me.edit������.Size = New System.Drawing.Size(208, 20)
        Me.edit������.TabIndex = 4
        Me.edit������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(32, 75)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(67, 20)
        Me.edit��������.TabIndex = 2
        Me.edit��������.Text = ""
        '
        'edit����������
        '
        Me.edit����������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(104, 145)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.ReadOnly = True
        Me.edit����������.Size = New System.Drawing.Size(208, 20)
        Me.edit����������.TabIndex = 3
        Me.edit����������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(104, 120)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.ReadOnly = True
        Me.edit��������.Size = New System.Drawing.Size(208, 20)
        Me.edit��������.TabIndex = 2
        Me.edit��������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(87, 133)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.ReadOnly = True
        Me.edit��������.Size = New System.Drawing.Size(193, 20)
        Me.edit��������.TabIndex = 10
        Me.edit��������.Text = ""
        '
        'edit����_���������
        '
        Me.edit����_���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.offerprice"))
        Me.edit����_���������.Location = New System.Drawing.Point(32, 119)
        Me.edit����_���������.Name = "edit����_���������"
        Me.edit����_���������.Size = New System.Drawing.Size(67, 20)
        Me.edit����_���������.TabIndex = 3
        Me.edit����_���������.Text = ""
        '
        'edit������_�������
        '
        Me.edit������_�������.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edit������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������ �������"))
        Me.edit������_�������.Location = New System.Drawing.Point(104, 67)
        Me.edit������_�������.Multiline = True
        Me.edit������_�������.Name = "edit������_�������"
        Me.edit������_�������.ReadOnly = True
        Me.edit������_�������.Size = New System.Drawing.Size(208, 48)
        Me.edit������_�������.TabIndex = 0
        Me.edit������_�������.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(528, 306)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(32, 23)
        Me.btnNavFirst.TabIndex = 39
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(560, 306)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(32, 23)
        Me.btnNavPrev.TabIndex = 40
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(592, 306)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(88, 23)
        Me.lblNavLocation.TabIndex = 41
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(680, 306)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(32, 23)
        Me.btnNavNext.TabIndex = 42
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(712, 306)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(32, 23)
        Me.btnLast.TabIndex = 43
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 406)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "��������"
        Me.btnAdd.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(536, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 24)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "��������"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "�������"
        Me.btnCancel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 80)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(424, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "�������"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(232, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 16)
        Me.CheckBox1.TabIndex = 69
        Me.CheckBox1.Text = "���� ������������"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(288, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "���"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(144, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "���"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "��������� �� �������"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(424, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "���������"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 66
        Me.TextBox1.Text = ""
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(652, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "E�������"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "�����������"
        Me.DataGrid1.DataSource = Me.objdtsparagelliessearch
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 336)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(752, 192)
        Me.DataGrid1.TabIndex = 47
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn28})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "�����������"
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "�������"
        Me.DataGridTextBoxColumn20.MappingName = "�������"
        Me.DataGridTextBoxColumn20.Width = 75
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "��� �������"
        Me.DataGridTextBoxColumn22.MappingName = "������� �������"
        Me.DataGridTextBoxColumn22.Width = 75
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "ISBN"
        Me.DataGridTextBoxColumn21.MappingName = "ISBN"
        Me.DataGridTextBoxColumn21.Width = 75
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "������ �������"
        Me.DataGridTextBoxColumn23.MappingName = "������ �������"
        Me.DataGridTextBoxColumn23.Width = 150
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "��������"
        Me.DataGridTextBoxColumn24.MappingName = "��������"
        Me.DataGridTextBoxColumn24.Width = 75
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "����������"
        Me.DataGridTextBoxColumn25.MappingName = "����������"
        Me.DataGridTextBoxColumn25.Width = 75
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "������"
        Me.DataGridTextBoxColumn26.MappingName = "������"
        Me.DataGridTextBoxColumn26.Width = 75
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "��������"
        Me.DataGridTextBoxColumn27.MappingName = "��������"
        Me.DataGridTextBoxColumn27.Width = 75
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "����"
        Me.DataGridTextBoxColumn29.MappingName = "offerprice"
        Me.DataGridTextBoxColumn29.Width = 55
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "����������"
        Me.DataGridTextBoxColumn28.MappingName = "����������"
        Me.DataGridTextBoxColumn28.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "��"
        Me.DataGridTextBoxColumn1.MappingName = "����������������"
        Me.DataGridTextBoxColumn1.Width = 25
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "�������"
        Me.DataGridTextBoxColumn2.MappingName = "�������"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "�����"
        Me.DataGridTextBoxColumn10.MappingName = "�����"
        Me.DataGridTextBoxColumn10.Width = 90
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "�����."
        Me.DataGridTextBoxColumn14.MappingName = "��������"
        Me.DataGridTextBoxColumn14.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "������"
        Me.DataGridTextBoxColumn7.MappingName = "������"
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "����/���"
        Me.DataGridTextBoxColumn8.MappingName = "����������"
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "���.����."
        Me.DataGridTextBoxColumn9.MappingName = "������� �������"
        Me.DataGridTextBoxColumn9.Width = 65
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "������ �������"
        Me.DataGridTextBoxColumn11.MappingName = "������ �������"
        Me.DataGridTextBoxColumn11.Width = 95
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "����������"
        Me.DataGridTextBoxColumn12.MappingName = "����������"
        Me.DataGridTextBoxColumn12.Width = 85
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "��������"
        Me.DataGridTextBoxColumn13.MappingName = "��������"
        Me.DataGridTextBoxColumn13.Width = 80
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "������"
        Me.DataGridTextBoxColumn15.MappingName = "������"
        Me.DataGridTextBoxColumn15.Width = 65
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "������"
        Me.DataGridTextBoxColumn16.MappingName = "������"
        Me.DataGridTextBoxColumn16.Width = 65
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "�����."
        Me.DataGridTextBoxColumn17.MappingName = "��������"
        Me.DataGridTextBoxColumn17.Width = 55
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "���� �����."
        Me.DataGridTextBoxColumn18.MappingName = "���� ���������"
        Me.DataGridTextBoxColumn18.Width = 55
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "�����."
        Me.DataGridTextBoxColumn19.MappingName = "������������"
        Me.DataGridTextBoxColumn19.Width = 55
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "���������"
        Me.DataGridTextBoxColumn4.MappingName = "���������"
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "���������"
        Me.DataGridTextBoxColumn3.MappingName = "���������"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "���"
        Me.DataGridTextBoxColumn5.MappingName = "���"
        Me.DataGridTextBoxColumn5.Width = 65
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "���"
        Me.DataGridTextBoxColumn6.MappingName = "���"
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "ISBN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.ISBN"))
        Me.TextBox4.Location = New System.Drawing.Point(104, 43)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(208, 20)
        Me.TextBox4.TabIndex = 49
        Me.TextBox4.Text = ""
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(760, 528)
        Me.CrystalReportViewer1.TabIndex = 51
        Me.CrystalReportViewer1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(281, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 24)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "��������"
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
        Me.MenuItem1.Text = "��������� �����������"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "��������"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.edit�������_�������)
        Me.GroupBox2.Controls.Add(Me.lbl�������_�������)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.lbl������)
        Me.GroupBox2.Controls.Add(Me.edit������_�������)
        Me.GroupBox2.Controls.Add(Me.lbl����������)
        Me.GroupBox2.Controls.Add(Me.lbl��������)
        Me.GroupBox2.Controls.Add(Me.lbl������_�������)
        Me.GroupBox2.Controls.Add(Me.lbl������)
        Me.GroupBox2.Controls.Add(Me.edit������)
        Me.GroupBox2.Controls.Add(Me.edit������)
        Me.GroupBox2.Controls.Add(Me.edit����������)
        Me.GroupBox2.Controls.Add(Me.edit��������)
        Me.GroupBox2.Controls.Add(Me.lbl����������)
        Me.GroupBox2.Controls.Add(Me.edit����������)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 248)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "�������� �������"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl�������)
        Me.GroupBox3.Controls.Add(Me.lbl������)
        Me.GroupBox3.Controls.Add(Me.lbl�����)
        Me.GroupBox3.Controls.Add(Me.edit�����)
        Me.GroupBox3.Controls.Add(Me.edit�������)
        Me.GroupBox3.Controls.Add(Me.edit������)
        Me.GroupBox3.Controls.Add(Me.lbl���������)
        Me.GroupBox3.Controls.Add(Me.edit���)
        Me.GroupBox3.Controls.Add(Me.lbl��������)
        Me.GroupBox3.Controls.Add(Me.edit���������)
        Me.GroupBox3.Controls.Add(Me.edit���)
        Me.GroupBox3.Controls.Add(Me.lbl���)
        Me.GroupBox3.Controls.Add(Me.edit���������)
        Me.GroupBox3.Controls.Add(Me.lbl���)
        Me.GroupBox3.Controls.Add(Me.lbl���������)
        Me.GroupBox3.Controls.Add(Me.edit��������)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 249)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "�������� ������"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lbl������������)
        Me.GroupBox4.Controls.Add(Me.lbl��������)
        Me.GroupBox4.Controls.Add(Me.edit��������)
        Me.GroupBox4.Controls.Add(Me.lbl����_���������)
        Me.GroupBox4.Controls.Add(Me.edit����_���������)
        Me.GroupBox4.Location = New System.Drawing.Point(636, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 192)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.��������"))
        Me.ComboBox2.Items.AddRange(New Object() {"���������", "���� - ������������", "Courrier"})
        Me.ComboBox2.Location = New System.Drawing.Point(8, 164)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.������������"))
        Me.ComboBox1.Items.AddRange(New Object() {"���", "���"})
        Me.ComboBox1.Location = New System.Drawing.Point(32, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "������ ���������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(652, 240)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 24)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "����������"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsparagelliessearch, "�����������.OrderNotes"))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(8, 336)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(752, 192)
        Me.TextBox5.TabIndex = 74
        Me.TextBox5.Text = ""
        Me.TextBox5.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(704, 504)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 24)
        Me.Button6.TabIndex = 75
        Me.Button6.Text = "��"
        Me.Button6.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(184, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 81
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(320, 32)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "��������� �� ����������"
        '
        'frmParageliesSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 529)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.TextBox5)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmParageliesSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��������� �����������"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsparagelliessearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsparagelliessearch, "�����������").CancelCurrentEdit()
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim answer As String
        answer = MsgBox("����� �������� ��� ������ �� ���������� ��� ����������;", MsgBoxStyle.OKCancel, "�������� �����������")
        If answer = vbOK Then

            If (Me.BindingContext(objdtsparagelliessearch, "�����������").Count > 0) Then
                Me.BindingContext(objdtsparagelliessearch, "�����������").RemoveAt(Me.BindingContext(objdtsparagelliessearch, "�����������").Position)
                Me.objdtsparagelliessearch_PositionChanged()
            End If
            Try
                'Attempt to update the datasource.
                Me.UpdateDataSet()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eUpdate.Message)
            End Try
            Me.objdtsparagelliessearch_PositionChanged()

        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsparagelliessearch, "�����������").EndCurrentEdit()
            Me.BindingContext(objdtsparagelliessearch, "�����������").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If TextBox5.Text = "" Then
            TextBox5.Text = "  "
        End If

        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()

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
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsparagelliessearch, "�����������").Position = 0
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsparagelliessearch, "�����������").Position = (Me.objdtsparagelliessearch.Tables("�����������").Rows.Count - 1)
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsparagelliessearch, "�����������").Position = (Me.BindingContext(objdtsparagelliessearch, "�����������").Position - 1)
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsparagelliessearch, "�����������").Position = (Me.BindingContext(objdtsparagelliessearch, "�����������").Position + 1)
        Me.objdtsparagelliessearch_PositionChanged()

    End Sub
    Private Sub objdtsparagelliessearch_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsparagelliessearch, "�����������").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsparagelliessearch, "�����������").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsparagelliessearch.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsparagelliessearch = New prjctDoReMi.dtsparagelliessearch
        'Stop any current edits.
        Me.BindingContext(objdtsparagelliessearch, "�����������").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsparagelliessearch.GetChanges, prjctDoReMi.dtsparagelliessearch)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsparagelliessearch.Merge(objDataSetChanges)
                objdtsparagelliessearch.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsparagelliessearch
        objDataSetTemp = New prjctDoReMi.dtsparagelliessearch
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsparagelliessearch.Clear()
            'Merge the records into the main dataset.
            objdtsparagelliessearch.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsparagelliessearch)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsparagelliessearch)
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

    Private Sub frmParageliesSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CheckBox1.Checked = False Then
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ���������� between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and ������� like '" & TextBox1.Text & "%';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        Else
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ���������� between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and ������� like '" & TextBox1.Text & "%' and ������������ not like '���';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        End If

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ���������� between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and ������� like '" & TextBox1.Text & "%' and ������������ not like '���';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        Else
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ���������� between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and ������� like '" & TextBox1.Text & "%';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        End If


        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'TextBox1.Text = ""
        'TextBox2.Text = "1/9/2003"
        'TextBox3.Text = Today

        Dim varsqlall As New OleDb.OleDbCommand("select * from ����������� ", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsqlall

        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsparagelliessearch_PositionChanged()
    End Sub

   
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim report As New rptparagellies
        report.SetDataSource(objdtsparagelliessearch)
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

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()

    End Sub

    Private Sub frmParageliesSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        TextBox5.SendToBack()
        TextBox5.Visible = False
        Button6.Visible = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        TextBox5.Visible = True
        Button6.Visible = True
        TextBox5.BringToFront()
        Button6.BringToFront()

    End Sub
End Class
