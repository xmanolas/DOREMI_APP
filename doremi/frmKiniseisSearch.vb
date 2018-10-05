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
    Friend WithEvents lbl������� As System.Windows.Forms.Label
    Friend WithEvents edit������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl����� As System.Windows.Forms.Label
    Friend WithEvents edit����� As System.Windows.Forms.TextBox
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents lbl�������_������� As System.Windows.Forms.Label
    Friend WithEvents edit�������_������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl������_������� As System.Windows.Forms.Label
    Friend WithEvents edit������_������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl����_��������� As System.Windows.Forms.Label
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents edit����_��������� As System.Windows.Forms.TextBox
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
        Me.lbl��� = New System.Windows.Forms.Label
        Me.lbl��� = New System.Windows.Forms.Label
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.lbl������ = New System.Windows.Forms.Label
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.lbl����� = New System.Windows.Forms.Label
        Me.edit����� = New System.Windows.Forms.TextBox
        Me.lbl������� = New System.Windows.Forms.Label
        Me.edit������� = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl����_��������� = New System.Windows.Forms.Label
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.edit����_��������� = New System.Windows.Forms.TextBox
        Me.lbl������ = New System.Windows.Forms.Label
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.lbl������ = New System.Windows.Forms.Label
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.lbl������_������� = New System.Windows.Forms.Label
        Me.edit������_������� = New System.Windows.Forms.TextBox
        Me.lbl�������_������� = New System.Windows.Forms.Label
        Me.edit�������_������� = New System.Windows.Forms.TextBox
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
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "��������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("����������������", "����������������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("�������", "�������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("������� �������", "������� �������"), New System.Data.Common.DataColumnMapping("�����", "�����"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("���� ���������", "���� ���������"), New System.Data.Common.DataColumnMapping("������ �������", "������ �������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM �������� WHERE (���������������� = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ��������(ISBN, ���, ���������, ���, ������, ���������, �������, �����" & _
        "�����, ������, [������� �������], �����, ������, ��������, ����������, ��������," & _
        " ��������, [���� ���������], [������ �������]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 10, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 20, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 30, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 30, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 30, "�������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.DBDate, 0, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 15, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "������� �������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����", System.Data.OleDb.OleDbType.VarWChar, 30, "�����"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 20, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.Integer, 0, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 15, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_���������", System.Data.OleDb.OleDbType.Single, 0, "���� ���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "������ �������"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ISBN, ����������������, ���, ���������, ���, ������, ���������, �������, �" & _
        "���������, ������, [������� �������], �����, ������, ��������, ����������, �����" & _
        "���, ��������, [���� ���������], [������ �������] FROM ��������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE �������� SET ISBN = ?, ��� = ?, ��������� = ?, ��� = ?, ������ = ?, ������" & _
        "��� = ?, ������� = ?, ���������� = ?, ������ = ?, [������� �������] = ?, ����� =" & _
        " ?, ������ = ?, �������� = ?, ���������� = ?, �������� = ?, �������� = ?, [���� " & _
        "���������] = ?, [������ �������] = ? WHERE (���������������� = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 10, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 20, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 30, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 30, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 30, "�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.DBDate, 0, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 15, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "������� �������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����", System.Data.OleDb.OleDbType.VarWChar, 30, "�����"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 20, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.Integer, 0, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 15, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_���������", System.Data.OleDb.OleDbType.Single, 0, "���� ���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "������ �������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
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
        Me.btnUpdate.Text = "���������"
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
        Me.btnDelete.Text = "��������"
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
        Me.DataGrid1.DataMember = "��������"
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
        Me.DataGridTableStyle1.MappingName = "��������"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "�������"
        Me.DataGridTextBoxColumn1.MappingName = "�������"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "��� �������"
        Me.DataGridTextBoxColumn6.MappingName = "������� �������"
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
        Me.DataGridTextBoxColumn7.HeaderText = "������ �������"
        Me.DataGridTextBoxColumn7.MappingName = "������ �������"
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "��������"
        Me.DataGridTextBoxColumn8.MappingName = "��������"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "����������"
        Me.DataGridTextBoxColumn9.MappingName = "����������"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "������"
        Me.DataGridTextBoxColumn10.MappingName = "������"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "��������"
        Me.DataGridTextBoxColumn4.MappingName = "��������"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "����������"
        Me.DataGridTextBoxColumn3.MappingName = "����������"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl���)
        Me.GroupBox1.Controls.Add(Me.lbl���)
        Me.GroupBox1.Controls.Add(Me.edit���)
        Me.GroupBox1.Controls.Add(Me.edit���)
        Me.GroupBox1.Controls.Add(Me.lbl���������)
        Me.GroupBox1.Controls.Add(Me.edit���������)
        Me.GroupBox1.Controls.Add(Me.lbl������)
        Me.GroupBox1.Controls.Add(Me.edit������)
        Me.GroupBox1.Controls.Add(Me.lbl��������)
        Me.GroupBox1.Controls.Add(Me.edit��������)
        Me.GroupBox1.Controls.Add(Me.lbl���������)
        Me.GroupBox1.Controls.Add(Me.edit���������)
        Me.GroupBox1.Controls.Add(Me.lbl�����)
        Me.GroupBox1.Controls.Add(Me.edit�����)
        Me.GroupBox1.Controls.Add(Me.lbl�������)
        Me.GroupBox1.Controls.Add(Me.edit�������)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "�������� ������"
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(8, 94)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.Size = New System.Drawing.Size(64, 23)
        Me.lbl���.TabIndex = 41
        Me.lbl���.Text = "���"
        Me.lbl���.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(8, 120)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.Size = New System.Drawing.Size(64, 23)
        Me.lbl���.TabIndex = 42
        Me.lbl���.Text = "���"
        Me.lbl���.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit���
        '
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.���"))
        Me.edit���.Location = New System.Drawing.Point(80, 94)
        Me.edit���.Name = "edit���"
        Me.edit���.Size = New System.Drawing.Size(288, 20)
        Me.edit���.TabIndex = 4
        Me.edit���.Text = ""
        '
        'edit���
        '
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.���"))
        Me.edit���.Location = New System.Drawing.Point(80, 120)
        Me.edit���.Name = "edit���"
        Me.edit���.Size = New System.Drawing.Size(288, 20)
        Me.edit���.TabIndex = 5
        Me.edit���.Text = ""
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(8, 68)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.Size = New System.Drawing.Size(64, 23)
        Me.lbl���������.TabIndex = 39
        Me.lbl���������.Text = "���������"
        Me.lbl���������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit���������
        '
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(80, 68)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.Size = New System.Drawing.Size(288, 20)
        Me.edit���������.TabIndex = 3
        Me.edit���������.Text = ""
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(8, 195)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(64, 23)
        Me.lbl������.TabIndex = 37
        Me.lbl������.Text = "������"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(80, 198)
        Me.edit������.Name = "edit������"
        Me.edit������.Size = New System.Drawing.Size(288, 20)
        Me.edit������.TabIndex = 8
        Me.edit������.Text = ""
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(8, 170)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(64, 23)
        Me.lbl��������.TabIndex = 35
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(80, 172)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(288, 20)
        Me.edit��������.TabIndex = 7
        Me.edit��������.Text = ""
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(8, 145)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.Size = New System.Drawing.Size(64, 23)
        Me.lbl���������.TabIndex = 32
        Me.lbl���������.Text = "���������"
        Me.lbl���������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit���������
        '
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(80, 146)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.Size = New System.Drawing.Size(288, 20)
        Me.edit���������.TabIndex = 6
        Me.edit���������.Text = ""
        '
        'lbl�����
        '
        Me.lbl�����.Location = New System.Drawing.Point(8, 42)
        Me.lbl�����.Name = "lbl�����"
        Me.lbl�����.Size = New System.Drawing.Size(64, 23)
        Me.lbl�����.TabIndex = 30
        Me.lbl�����.Text = "�����"
        Me.lbl�����.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit�����
        '
        Me.edit�����.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.�����"))
        Me.edit�����.Location = New System.Drawing.Point(80, 42)
        Me.edit�����.Name = "edit�����"
        Me.edit�����.Size = New System.Drawing.Size(288, 20)
        Me.edit�����.TabIndex = 2
        Me.edit�����.Text = ""
        '
        'lbl�������
        '
        Me.lbl�������.Location = New System.Drawing.Point(8, 16)
        Me.lbl�������.Name = "lbl�������"
        Me.lbl�������.Size = New System.Drawing.Size(64, 23)
        Me.lbl�������.TabIndex = 18
        Me.lbl�������.Text = "�������"
        Me.lbl�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit�������
        '
        Me.edit�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.�������"))
        Me.edit�������.Location = New System.Drawing.Point(80, 16)
        Me.edit�������.Name = "edit�������"
        Me.edit�������.Size = New System.Drawing.Size(288, 20)
        Me.edit�������.TabIndex = 1
        Me.edit�������.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl����������)
        Me.GroupBox2.Controls.Add(Me.edit����������)
        Me.GroupBox2.Controls.Add(Me.lbl��������)
        Me.GroupBox2.Controls.Add(Me.lbl����_���������)
        Me.GroupBox2.Controls.Add(Me.edit��������)
        Me.GroupBox2.Controls.Add(Me.edit����_���������)
        Me.GroupBox2.Controls.Add(Me.lbl������)
        Me.GroupBox2.Controls.Add(Me.edit������)
        Me.GroupBox2.Controls.Add(Me.lbl������)
        Me.GroupBox2.Controls.Add(Me.edit������)
        Me.GroupBox2.Controls.Add(Me.lbl����������)
        Me.GroupBox2.Controls.Add(Me.edit����������)
        Me.GroupBox2.Controls.Add(Me.lbl��������)
        Me.GroupBox2.Controls.Add(Me.edit��������)
        Me.GroupBox2.Controls.Add(Me.lbl������_�������)
        Me.GroupBox2.Controls.Add(Me.edit������_�������)
        Me.GroupBox2.Controls.Add(Me.lbl�������_�������)
        Me.GroupBox2.Controls.Add(Me.edit�������_�������)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 240)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "�������� �������"
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(8, 181)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(88, 23)
        Me.lbl����������.TabIndex = 47
        Me.lbl����������.Text = "����������"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(96, 181)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(88, 20)
        Me.edit����������.TabIndex = 16
        Me.edit����������.Text = ""
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(224, 181)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(72, 23)
        Me.lbl��������.TabIndex = 49
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl����_���������
        '
        Me.lbl����_���������.Location = New System.Drawing.Point(104, 208)
        Me.lbl����_���������.Name = "lbl����_���������"
        Me.lbl����_���������.Size = New System.Drawing.Size(96, 23)
        Me.lbl����_���������.TabIndex = 50
        Me.lbl����_���������.Text = "���� �������"
        Me.lbl����_���������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(296, 181)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(72, 20)
        Me.edit��������.TabIndex = 17
        Me.edit��������.Text = ""
        '
        'edit����_���������
        '
        Me.edit����_���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.���� ���������"))
        Me.edit����_���������.Location = New System.Drawing.Point(200, 211)
        Me.edit����_���������.Name = "edit����_���������"
        Me.edit����_���������.TabIndex = 18
        Me.edit����_���������.Text = ""
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(8, 157)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(88, 23)
        Me.lbl������.TabIndex = 45
        Me.lbl������.Text = "������������ 2"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(96, 157)
        Me.edit������.Name = "edit������"
        Me.edit������.Size = New System.Drawing.Size(272, 20)
        Me.edit������.TabIndex = 15
        Me.edit������.Text = ""
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(8, 133)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.Size = New System.Drawing.Size(88, 23)
        Me.lbl������.TabIndex = 43
        Me.lbl������.Text = "������"
        Me.lbl������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(96, 133)
        Me.edit������.Name = "edit������"
        Me.edit������.Size = New System.Drawing.Size(272, 20)
        Me.edit������.TabIndex = 14
        Me.edit������.Text = ""
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(8, 109)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(88, 23)
        Me.lbl����������.TabIndex = 41
        Me.lbl����������.Text = "����������"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(96, 109)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(272, 20)
        Me.edit����������.TabIndex = 13
        Me.edit����������.Text = ""
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(8, 85)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(88, 23)
        Me.lbl��������.TabIndex = 39
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(96, 85)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(272, 20)
        Me.edit��������.TabIndex = 12
        Me.edit��������.Text = ""
        '
        'lbl������_�������
        '
        Me.lbl������_�������.Location = New System.Drawing.Point(8, 40)
        Me.lbl������_�������.Name = "lbl������_�������"
        Me.lbl������_�������.Size = New System.Drawing.Size(88, 23)
        Me.lbl������_�������.TabIndex = 37
        Me.lbl������_�������.Text = "������ �������"
        Me.lbl������_�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit������_�������
        '
        Me.edit������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.������ �������"))
        Me.edit������_�������.Location = New System.Drawing.Point(96, 40)
        Me.edit������_�������.Multiline = True
        Me.edit������_�������.Name = "edit������_�������"
        Me.edit������_�������.Size = New System.Drawing.Size(272, 40)
        Me.edit������_�������.TabIndex = 11
        Me.edit������_�������.Text = ""
        '
        'lbl�������_�������
        '
        Me.lbl�������_�������.Location = New System.Drawing.Point(8, 16)
        Me.lbl�������_�������.Name = "lbl�������_�������"
        Me.lbl�������_�������.Size = New System.Drawing.Size(88, 23)
        Me.lbl�������_�������.TabIndex = 21
        Me.lbl�������_�������.Text = "������� �������"
        Me.lbl�������_�������.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edit�������_�������
        '
        Me.edit�������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsKiniseisSrch, "��������.������� �������"))
        Me.edit�������_�������.Location = New System.Drawing.Point(96, 16)
        Me.edit�������_�������.Name = "edit�������_�������"
        Me.edit�������_�������.TabIndex = 10
        Me.edit�������_�������.Text = ""
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
        Me.Label2.Text = "��������� �� ����������"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(392, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "�����"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(392, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "���������"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(312, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "���"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "���"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "��������� �� �������"
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
        Me.Button3.Text = "��������"
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
        Me.MenuItem1.Text = "��������� �������"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "��������"
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
        Me.Text = "��������� ��������"
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
        Me.BindingContext(objdtsKiniseisSrch, "��������").CancelCurrentEdit()
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsKiniseisSrch, "��������").Count > 0) Then
            Me.BindingContext(objdtsKiniseisSrch, "��������").RemoveAt(Me.BindingContext(objdtsKiniseisSrch, "��������").Position)
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
            Me.BindingContext(objdtsKiniseisSrch, "��������").EndCurrentEdit()
            Me.BindingContext(objdtsKiniseisSrch, "��������").AddNew()
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
        Me.BindingContext(objdtsKiniseisSrch, "��������").Position = 0
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsKiniseisSrch, "��������").Position = (Me.objdtsKiniseisSrch.Tables("��������").Rows.Count - 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsKiniseisSrch, "��������").Position = (Me.BindingContext(objdtsKiniseisSrch, "��������").Position - 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsKiniseisSrch, "��������").Position = (Me.BindingContext(objdtsKiniseisSrch, "��������").Position + 1)
        Me.objdtsKiniseisSrch_PositionChanged()

    End Sub
    Private Sub objdtsKiniseisSrch_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsKiniseisSrch, "��������").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsKiniseisSrch, "��������").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsKiniseisSrch.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsKiniseisSrch = New prjctDoReMi.dtsKiniseisSrch
        'Stop any current edits.
        Me.BindingContext(objdtsKiniseisSrch, "��������").EndCurrentEdit()
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
        
        Dim varsql As New OleDb.OleDbCommand("select * from �������� where ���������� between #" & DateTimePicker1.Text & "# and #" & DateTimePicker2.Text & "# and ������� like '" & TextBox1.Text & "%';", OleDbConnection1)
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
        
        

        Dim varsql As New OleDb.OleDbCommand("select * from ��������", OleDbConnection1)
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
