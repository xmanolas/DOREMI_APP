Public Class frmKiniseislast
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
    Friend WithEvents objdtskiniseislast As prjctDoReMi.dtskiniseislast
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lbl���������������� As System.Windows.Forms.Label
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents lbl��� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents lbl������� As System.Windows.Forms.Label
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents edit���������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit��� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
    Friend WithEvents lbl�������_������� As System.Windows.Forms.Label
    Friend WithEvents lbl����� As System.Windows.Forms.Label
    Friend WithEvents lbl������ As System.Windows.Forms.Label
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl����_��������� As System.Windows.Forms.Label
    Friend WithEvents lbl������_������� As System.Windows.Forms.Label
    Friend WithEvents edit�������_������� As System.Windows.Forms.TextBox
    Friend WithEvents edit����� As System.Windows.Forms.TextBox
    Friend WithEvents edit������ As System.Windows.Forms.TextBox
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents editISBN As System.Windows.Forms.TextBox
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
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.objdtskiniseislast = New prjctDoReMi.dtskiniseislast
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lbl���������������� = New System.Windows.Forms.Label
        Me.lbl��� = New System.Windows.Forms.Label
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.lbl��� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.lbl������� = New System.Windows.Forms.Label
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.edit���������������� = New System.Windows.Forms.TextBox
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.edit��� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.edit������� = New System.Windows.Forms.TextBox
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
        Me.lbl�������_������� = New System.Windows.Forms.Label
        Me.lbl����� = New System.Windows.Forms.Label
        Me.lbl������ = New System.Windows.Forms.Label
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl����_��������� = New System.Windows.Forms.Label
        Me.lbl������_������� = New System.Windows.Forms.Label
        Me.edit�������_������� = New System.Windows.Forms.TextBox
        Me.edit����� = New System.Windows.Forms.TextBox
        Me.edit������ = New System.Windows.Forms.TextBox
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
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.editISBN = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.objdtskiniseislast, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM �������� WHERE (���������������� = ?) AND (ISBN = ? OR ? IS NULL AND " & _
        "ISBN IS NULL) AND (������ = ? OR ? IS NULL AND ������ IS NULL) AND (����� = ? OR" & _
        " ? IS NULL AND ����� IS NULL) AND (������ = ? OR ? IS NULL AND ������ IS NULL) A" & _
        "ND (��� = ? OR ? IS NULL AND ��� IS NULL) AND (��� = ? OR ? IS NULL AND ��� IS N" & _
        "ULL) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND (��������� = ? O" & _
        "R ? IS NULL AND ��������� IS NULL) AND (������� = ? OR ? IS NULL AND ������� IS " & _
        "NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (������ = ? O" & _
        "R ? IS NULL AND ������ IS NULL) AND ([������� �������] = ? OR ? IS NULL AND [���" & _
        "���� �������] IS NULL) AND (�������� = ? OR ? IS NULL AND �������� IS NULL) AND " & _
        "(���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (�������� = ? OR ? IS N" & _
        "ULL AND �������� IS NULL) AND ([������ �������] = ? OR ? IS NULL AND [������ ���" & _
        "����] IS NULL) AND (�������� = ? OR ? IS NULL AND �������� IS NULL) AND ([���� �" & _
        "��������] = ? OR ? IS NULL AND [���� ���������] IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������� �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������� �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������ �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������ �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_���������", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���� ���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_���������1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���� ���������", System.Data.DataRowVersion.Original, Nothing))
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
        "���������] = ?, [������ �������] = ? WHERE (���������������� = ?) AND (ISBN = ? " & _
        "OR ? IS NULL AND ISBN IS NULL) AND (������ = ? OR ? IS NULL AND ������ IS NULL) " & _
        "AND (����� = ? OR ? IS NULL AND ����� IS NULL) AND (������ = ? OR ? IS NULL AND " & _
        "������ IS NULL) AND (��� = ? OR ? IS NULL AND ��� IS NULL) AND (��� = ? OR ? IS " & _
        "NULL AND ��� IS NULL) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND" & _
        " (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND (������� = ? OR ? IS NUL" & _
        "L AND ������� IS NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) " & _
        "AND (������ = ? OR ? IS NULL AND ������ IS NULL) AND ([������� �������] = ? OR ?" & _
        " IS NULL AND [������� �������] IS NULL) AND (�������� = ? OR ? IS NULL AND �����" & _
        "��� IS NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (�����" & _
        "��� = ? OR ? IS NULL AND �������� IS NULL) AND ([������ �������] = ? OR ? IS NUL" & _
        "L AND [������ �������] IS NULL) AND (�������� = ? OR ? IS NULL AND �������� IS N" & _
        "ULL) AND ([���� ���������] = ? OR ? IS NULL AND [���� ���������] IS NULL)"
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
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������� �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������� �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������ �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������ �������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_���������", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���� ���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_���������1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���� ���������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "�����������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("kinhto", "kinhto"), New System.Data.Common.DataColumnMapping("website", "website"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������Email", "���������Email"), New System.Data.Common.DataColumnMapping("����������������", "����������������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("�����������������", "�����������������"), New System.Data.Common.DataColumnMapping("�������������", "�������������"), New System.Data.Common.DataColumnMapping("�����������", "�����������"), New System.Data.Common.DataColumnMapping("�����/�������", "�����/�������"), New System.Data.Common.DataColumnMapping("�����������", "�����������"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("�������������������", "�������������������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������1", "��������1"), New System.Data.Common.DataColumnMapping("����/�������", "����/�������")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM ����������� WHERE (����������� = ?) AND (kinhto = ? OR ? IS NULL AND " & _
        "kinhto IS NULL) AND (website = ? OR ? IS NULL AND website IS NULL) AND (��������" & _
        "��� = ? OR ? IS NULL AND ����������� IS NULL) AND (��� = ? OR ? IS NULL AND ��� " & _
        "IS NULL) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (��� = ? O" & _
        "R ? IS NULL AND ��� IS NULL) AND (���������Email = ? OR ? IS NULL AND ���������E" & _
        "mail IS NULL) AND (���������������� = ? OR ? IS NULL AND ���������������� IS NUL" & _
        "L) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND (�����������������" & _
        " = ? OR ? IS NULL AND ����������������� IS NULL) AND (������������� = ? OR ? IS " & _
        "NULL AND ������������� IS NULL) AND ([�����/�������] = ? OR ? IS NULL AND [�����" & _
        "/�������] IS NULL) AND (���� = ? OR ? IS NULL AND ���� IS NULL) AND (�����������" & _
        "�������� = ? OR ? IS NULL AND ������������������� IS NULL) AND (�������� = ? OR " & _
        "? IS NULL AND �������� IS NULL) AND (��������1 = ? OR ? IS NULL AND ��������1 IS" & _
        " NULL) AND ([����/�������] = ? OR ? IS NULL AND [����/�������] IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO �����������(kinhto, website, ����������, ���, ���������Email, �������" & _
        "���������, ���, ���������, �����������������, �������������, �����������, [�����" & _
        "/�������], �����������, ����, ����������, �������������������, ��������, �������" & _
        "�1, [����/�������]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 30, "�����������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT kinhto, website, ����������, ���, ���������Email, ����������������, ���, �" & _
        "��������, �����������������, �������������, �����������, [�����/�������], ������" & _
        "�����, ����, ����������, �������������������, ��������, ��������1, [����/�������" & _
        "] FROM �����������"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE ����������� SET kinhto = ?, website = ?, ���������� = ?, ��� = ?, ��������" & _
        "�Email = ?, ���������������� = ?, ��� = ?, ��������� = ?, ����������������� = ?," & _
        " ������������� = ?, ����������� = ?, [�����/�������] = ?, ����������� = ?, ���� " & _
        "= ?, ���������� = ?, ������������������� = ?, �������� = ?, ��������1 = ?, [����" & _
        "/�������] = ? WHERE (����������� = ?) AND (kinhto = ? OR ? IS NULL AND kinhto IS" & _
        " NULL) AND (website = ? OR ? IS NULL AND website IS NULL) AND (����������� = ? O" & _
        "R ? IS NULL AND ����������� IS NULL) AND (��� = ? OR ? IS NULL AND ��� IS NULL) " & _
        "AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (��� = ? OR ? IS NU" & _
        "LL AND ��� IS NULL) AND (���������Email = ? OR ? IS NULL AND ���������Email IS N" & _
        "ULL) AND (���������������� = ? OR ? IS NULL AND ���������������� IS NULL) AND (�" & _
        "�������� = ? OR ? IS NULL AND ��������� IS NULL) AND (����������������� = ? OR ?" & _
        " IS NULL AND ����������������� IS NULL) AND (������������� = ? OR ? IS NULL AND " & _
        "������������� IS NULL) AND ([�����/�������] = ? OR ? IS NULL AND [�����/�������]" & _
        " IS NULL) AND (���� = ? OR ? IS NULL AND ���� IS NULL) AND (������������������� " & _
        "= ? OR ? IS NULL AND ������������������� IS NULL) AND (�������� = ? OR ? IS NULL" & _
        " AND �������� IS NULL) AND (��������1 = ? OR ? IS NULL AND ��������1 IS NULL) AN" & _
        "D ([����/�������] = ? OR ? IS NULL AND [����/�������] IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 30, "�����������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_kinhto1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "kinhto", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_website1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "website", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblBooks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("aa", "aa"), New System.Data.Common.DataColumnMapping("author", "author"), New System.Data.Common.DataColumnMapping("bookcode", "bookcode"), New System.Data.Common.DataColumnMapping("bookordernumber", "bookordernumber"), New System.Data.Common.DataColumnMapping("booktitle", "booktitle"), New System.Data.Common.DataColumnMapping("compocategory", "compocategory"), New System.Data.Common.DataColumnMapping("composer", "composer"), New System.Data.Common.DataColumnMapping("compotitle", "compotitle"), New System.Data.Common.DataColumnMapping("edition", "edition"), New System.Data.Common.DataColumnMapping("epimelitis", "epimelitis"), New System.Data.Common.DataColumnMapping("fpa", "fpa"), New System.Data.Common.DataColumnMapping("generalcode", "generalcode"), New System.Data.Common.DataColumnMapping("generalcompotitle", "generalcompotitle"), New System.Data.Common.DataColumnMapping("ISBN", "ISBN"), New System.Data.Common.DataColumnMapping("ISMN", "ISMN"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("orders", "orders"), New System.Data.Common.DataColumnMapping("quantity", "quantity"), New System.Data.Common.DataColumnMapping("subcompocategory", "subcompocategory"), New System.Data.Common.DataColumnMapping("subcompocategory2", "subcompocategory2"), New System.Data.Common.DataColumnMapping("supplier", "supplier"), New System.Data.Common.DataColumnMapping("timiagoras", "timiagoras"), New System.Data.Common.DataColumnMapping("timipolisis", "timipolisis"), New System.Data.Common.DataColumnMapping("�����������2", "�����������2"), New System.Data.Common.DataColumnMapping("�����������3", "�����������3")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM tblBooks WHERE (aa = ?) AND (generalcode = ?) AND (ISBN = ? OR ? IS N" & _
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
        "D (timipolisis = ? OR ? IS NULL AND timipolisis IS NULL) AND (�����������2 = ? O" & _
        "R ? IS NULL AND �����������2 IS NULL) AND (�����������3 = ? OR ? IS NULL AND ���" & _
        "��������3 IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������3", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO tblBooks(author, bookcode, bookordernumber, booktitle, compocategory," & _
        " composer, compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle," & _
        " ISBN, ISMN, notes, orders, quantity, subcompocategory, subcompocategory2, suppl" & _
        "ier, timiagoras, timipolisis, �����������2, �����������3) VALUES (?, ?, ?, ?, ?," & _
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
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������2", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������3", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������3"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT aa, author, bookcode, bookordernumber, booktitle, compocategory, composer," & _
        " compotitle, edition, epimelitis, fpa, generalcode, generalcompotitle, ISBN, ISM" & _
        "N, notes, orders, quantity, subcompocategory, subcompocategory2, supplier, timia" & _
        "goras, timipolisis, �����������2, �����������3 FROM tblBooks"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE tblBooks SET author = ?, bookcode = ?, bookordernumber = ?, booktitle = ?," & _
        " compocategory = ?, composer = ?, compotitle = ?, edition = ?, epimelitis = ?, f" & _
        "pa = ?, generalcode = ?, generalcompotitle = ?, ISBN = ?, ISMN = ?, notes = ?, o" & _
        "rders = ?, quantity = ?, subcompocategory = ?, subcompocategory2 = ?, supplier =" & _
        " ?, timiagoras = ?, timipolisis = ?, �����������2 = ?, �����������3 = ? WHERE (a" & _
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
        "ULL AND timipolisis IS NULL) AND (�����������2 = ? OR ? IS NULL AND �����������2" & _
        " IS NULL) AND (�����������3 = ? OR ? IS NULL AND �����������3 IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("author", System.Data.OleDb.OleDbType.VarWChar, 100, "author"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, "bookcode"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, "bookordernumber"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, "booktitle"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "compocategory"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("composer", System.Data.OleDb.OleDbType.VarWChar, 50, "composer"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "compotitle"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("edition", System.Data.OleDb.OleDbType.VarWChar, 50, "edition"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, "epimelitis"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("fpa", System.Data.OleDb.OleDbType.VarWChar, 50, "fpa"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, "generalcode"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, "generalcompotitle"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISBN"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, "ISMN"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("notes", System.Data.OleDb.OleDbType.VarWChar, 0, "notes"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("orders", System.Data.OleDb.OleDbType.Integer, 0, "orders"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("quantity", System.Data.OleDb.OleDbType.Integer, 0, "quantity"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, "subcompocategory2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("supplier", System.Data.OleDb.OleDbType.VarWChar, 50, "supplier"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, "timiagoras"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, "timipolisis"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������2", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������3", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_aa", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "aa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISBN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISBN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ISMN1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ISMN", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_author1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookcode1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookcode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_bookordernumber1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookordernumber", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_booktitle1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "booktitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_composer1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "composer", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_compotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "compotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_edition1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "edition", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_epimelitis1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "epimelitis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_fpa1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fpa", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_generalcompotitle1", System.Data.OleDb.OleDbType.VarWChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generalcompotitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_orders1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "orders", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_quantity1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_subcompocategory21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "subcompocategory2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_supplier1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "supplier", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timiagoras1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timiagoras", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_timipolisis1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "timipolisis", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������2", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������21", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������3", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������31", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������3", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtskiniseislast
        '
        Me.objdtskiniseislast.DataSetName = "dtskiniseislast"
        Me.objdtskiniseislast.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(-248, 688)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(92, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.TabStop = False
        Me.btnLoad.Text = "&Load"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(-64, 800)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(680, 848)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.TabStop = False
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'lbl����������������
        '
        Me.lbl����������������.Location = New System.Drawing.Point(-176, 760)
        Me.lbl����������������.Name = "lbl����������������"
        Me.lbl����������������.Size = New System.Drawing.Size(117, 23)
        Me.lbl����������������.TabIndex = 3
        Me.lbl����������������.Text = "����������������"
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(-176, 792)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.Size = New System.Drawing.Size(117, 23)
        Me.lbl���.TabIndex = 4
        Me.lbl���.Text = "���"
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(256, 848)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.TabIndex = 5
        Me.lbl���������.Text = "���������"
        '
        'lbl���
        '
        Me.lbl���.Location = New System.Drawing.Point(256, 880)
        Me.lbl���.Name = "lbl���"
        Me.lbl���.TabIndex = 6
        Me.lbl���.Text = "���"
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(256, 920)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.TabIndex = 7
        Me.lbl������.Text = "������"
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(-328, 744)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.Size = New System.Drawing.Size(117, 23)
        Me.lbl���������.TabIndex = 8
        Me.lbl���������.Text = "���������"
        '
        'lbl�������
        '
        Me.lbl�������.Location = New System.Drawing.Point(-328, 776)
        Me.lbl�������.Name = "lbl�������"
        Me.lbl�������.Size = New System.Drawing.Size(117, 23)
        Me.lbl�������.TabIndex = 9
        Me.lbl�������.Text = "�������"
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(104, 832)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.TabIndex = 10
        Me.lbl����������.Text = "����������"
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(104, 864)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.TabIndex = 11
        Me.lbl������.Text = "������"
        '
        'edit����������������
        '
        Me.edit����������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.����������������"))
        Me.edit����������������.Location = New System.Drawing.Point(-312, 864)
        Me.edit����������������.Name = "edit����������������"
        Me.edit����������������.Size = New System.Drawing.Size(117, 20)
        Me.edit����������������.TabIndex = 12
        Me.edit����������������.TabStop = False
        Me.edit����������������.Text = ""
        '
        'edit���
        '
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.���"))
        Me.edit���.Location = New System.Drawing.Point(-312, 896)
        Me.edit���.Name = "edit���"
        Me.edit���.Size = New System.Drawing.Size(117, 20)
        Me.edit���.TabIndex = 13
        Me.edit���.TabStop = False
        Me.edit���.Text = ""
        '
        'edit���������
        '
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(360, 848)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.TabIndex = 14
        Me.edit���������.TabStop = False
        Me.edit���������.Text = ""
        '
        'edit���
        '
        Me.edit���.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.���"))
        Me.edit���.Location = New System.Drawing.Point(360, 880)
        Me.edit���.Name = "edit���"
        Me.edit���.TabIndex = 15
        Me.edit���.TabStop = False
        Me.edit���.Text = ""
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(360, 920)
        Me.edit������.Name = "edit������"
        Me.edit������.TabIndex = 16
        Me.edit������.TabStop = False
        Me.edit������.Text = ""
        '
        'edit���������
        '
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(-224, 744)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.Size = New System.Drawing.Size(117, 20)
        Me.edit���������.TabIndex = 17
        Me.edit���������.TabStop = False
        Me.edit���������.Text = ""
        '
        'edit�������
        '
        Me.edit�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.�������"))
        Me.edit�������.Location = New System.Drawing.Point(-224, 776)
        Me.edit�������.Name = "edit�������"
        Me.edit�������.Size = New System.Drawing.Size(117, 20)
        Me.edit�������.TabIndex = 18
        Me.edit�������.TabStop = False
        Me.edit�������.Text = ""
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(208, 832)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.TabIndex = 19
        Me.edit����������.TabStop = False
        Me.edit����������.Text = ""
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(208, 864)
        Me.edit������.Name = "edit������"
        Me.edit������.TabIndex = 20
        Me.edit������.TabStop = False
        Me.edit������.Text = ""
        '
        'lbl�������_�������
        '
        Me.lbl�������_�������.Location = New System.Drawing.Point(-200, 864)
        Me.lbl�������_�������.Name = "lbl�������_�������"
        Me.lbl�������_�������.Size = New System.Drawing.Size(117, 23)
        Me.lbl�������_�������.TabIndex = 21
        Me.lbl�������_�������.Text = "������� �������"
        '
        'lbl�����
        '
        Me.lbl�����.Location = New System.Drawing.Point(-200, 896)
        Me.lbl�����.Name = "lbl�����"
        Me.lbl�����.Size = New System.Drawing.Size(117, 23)
        Me.lbl�����.TabIndex = 22
        Me.lbl�����.Text = "�����"
        '
        'lbl������
        '
        Me.lbl������.Location = New System.Drawing.Point(472, 848)
        Me.lbl������.Name = "lbl������"
        Me.lbl������.TabIndex = 23
        Me.lbl������.Text = "������"
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(472, 880)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.TabIndex = 24
        Me.lbl����������.Text = "����������"
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(472, 920)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.TabIndex = 25
        Me.lbl��������.Text = "��������"
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(-112, 744)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(112, 23)
        Me.lbl��������.TabIndex = 26
        Me.lbl��������.Text = "��������"
        '
        'lbl����_���������
        '
        Me.lbl����_���������.Location = New System.Drawing.Point(-112, 776)
        Me.lbl����_���������.Name = "lbl����_���������"
        Me.lbl����_���������.Size = New System.Drawing.Size(112, 23)
        Me.lbl����_���������.TabIndex = 27
        Me.lbl����_���������.Text = "���� ���������"
        '
        'lbl������_�������
        '
        Me.lbl������_�������.Location = New System.Drawing.Point(320, 832)
        Me.lbl������_�������.Name = "lbl������_�������"
        Me.lbl������_�������.TabIndex = 28
        Me.lbl������_�������.Text = "������ �������"
        '
        'edit�������_�������
        '
        Me.edit�������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.������� �������"))
        Me.edit�������_�������.Location = New System.Drawing.Point(-88, 864)
        Me.edit�������_�������.Name = "edit�������_�������"
        Me.edit�������_�������.TabIndex = 29
        Me.edit�������_�������.TabStop = False
        Me.edit�������_�������.Text = ""
        '
        'edit�����
        '
        Me.edit�����.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.�����"))
        Me.edit�����.Location = New System.Drawing.Point(-88, 896)
        Me.edit�����.Name = "edit�����"
        Me.edit�����.TabIndex = 30
        Me.edit�����.TabStop = False
        Me.edit�����.Text = ""
        '
        'edit������
        '
        Me.edit������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.������"))
        Me.edit������.Location = New System.Drawing.Point(584, 848)
        Me.edit������.Name = "edit������"
        Me.edit������.TabIndex = 31
        Me.edit������.TabStop = False
        Me.edit������.Text = ""
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(584, 880)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.TabIndex = 32
        Me.edit����������.TabStop = False
        Me.edit����������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(584, 920)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.TabIndex = 33
        Me.edit��������.TabStop = False
        Me.edit��������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(-240, 848)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(117, 20)
        Me.edit��������.TabIndex = 34
        Me.edit��������.TabStop = False
        Me.edit��������.Text = ""
        '
        'edit����_���������
        '
        Me.edit����_���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.���� ���������"))
        Me.edit����_���������.Location = New System.Drawing.Point(-240, 880)
        Me.edit����_���������.Name = "edit����_���������"
        Me.edit����_���������.Size = New System.Drawing.Size(117, 20)
        Me.edit����_���������.TabIndex = 35
        Me.edit����_���������.TabStop = False
        Me.edit����_���������.Text = ""
        '
        'edit������_�������
        '
        Me.edit������_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.������ �������"))
        Me.edit������_�������.Location = New System.Drawing.Point(432, 832)
        Me.edit������_�������.Name = "edit������_�������"
        Me.edit������_�������.TabIndex = 36
        Me.edit������_�������.TabStop = False
        Me.edit������_�������.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(-104, 712)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(57, 23)
        Me.btnNavFirst.TabIndex = 37
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(-64, 712)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(52, 23)
        Me.btnNavPrev.TabIndex = 38
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(-264, 816)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(112, 23)
        Me.lblNavLocation.TabIndex = 39
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(-168, 816)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(52, 23)
        Me.btnNavNext.TabIndex = 40
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(-136, 816)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(57, 23)
        Me.btnLast.TabIndex = 41
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(-104, 744)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(-256, 848)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 23)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(-168, 848)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 23)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
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
        Me.GroupBox1.Location = New System.Drawing.Point(48, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 168)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "�������� �������� ������"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.���������"))
        Me.Label16.Location = New System.Drawing.Point(472, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 16)
        Me.Label16.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.���"))
        Me.Label15.Location = New System.Drawing.Point(344, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.���"))
        Me.Label14.Location = New System.Drawing.Point(216, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 16)
        Me.Label14.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.����������������"))
        Me.Label13.Location = New System.Drawing.Point(24, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 16)
        Me.Label13.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.��������1"))
        Me.Label12.Location = New System.Drawing.Point(480, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 16)
        Me.Label12.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.��������"))
        Me.Label11.Location = New System.Drawing.Point(352, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.�����������"))
        Me.Label10.Location = New System.Drawing.Point(193, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 16)
        Me.Label10.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "�����������.�������������"))
        Me.Label9.Location = New System.Drawing.Point(24, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 16)
        Me.Label9.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(480, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "���������"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(360, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "���"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(224, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "���"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "���������"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(488, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "������"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(360, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "��������"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "�����"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "�������"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
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
        Me.GroupBox2.Location = New System.Drawing.Point(48, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 160)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.ISBN"))
        Me.Label36.Location = New System.Drawing.Point(16, 80)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 14
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(24, 64)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(32, 16)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "ISBN"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 24)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "�������� �������� �������"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.timipolisis"))
        Me.Label17.Location = New System.Drawing.Point(536, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.quantity"))
        Me.Label18.Location = New System.Drawing.Point(464, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.author"))
        Me.Label19.Location = New System.Drawing.Point(296, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 16)
        Me.Label19.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.bookcode"))
        Me.Label20.Location = New System.Drawing.Point(96, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.edition"))
        Me.Label21.Location = New System.Drawing.Point(168, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 16)
        Me.Label21.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.subcompocategory2"))
        Me.Label22.Location = New System.Drawing.Point(40, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 16)
        Me.Label22.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.booktitle"))
        Me.Label23.Location = New System.Drawing.Point(360, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(280, 16)
        Me.Label23.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "tblBooks.composer"))
        Me.Label24.Location = New System.Drawing.Point(192, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(168, 16)
        Me.Label24.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(544, 112)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 16)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "���� "
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(464, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 16)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "��������"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(304, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "����������"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(96, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 16)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "���. ����."
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(168, 112)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "������"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(48, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "������"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(368, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "������ �������"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(200, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 16)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "��������"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(352, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "���������� �������"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 120)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(80, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(128, 16)
        Me.Label35.TabIndex = 53
        Me.Label35.Text = "�������� �������"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(160, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 32)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "�����"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "OK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.��������"))
        Me.TextBox2.Location = New System.Drawing.Point(424, 864)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 20)
        Me.TextBox2.TabIndex = 49
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(288, 376)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 20)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "=today"
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(296, 360)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "����������"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(414, 360)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 16)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "���� �������"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(408, 376)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 20)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.Text = ""
        '
        'editISBN
        '
        Me.editISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtskiniseislast, "��������.ISBN"))
        Me.editISBN.Location = New System.Drawing.Point(64, 296)
        Me.editISBN.Name = "editISBN"
        Me.editISBN.Size = New System.Drawing.Size(80, 20)
        Me.editISBN.TabIndex = 53
        Me.editISBN.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "�������� �������"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "��������"
        '
        'frmKiniseislast
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 534)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lbl����������������)
        Me.Controls.Add(Me.lbl���)
        Me.Controls.Add(Me.lbl���������)
        Me.Controls.Add(Me.lbl���)
        Me.Controls.Add(Me.lbl������)
        Me.Controls.Add(Me.lbl���������)
        Me.Controls.Add(Me.lbl�������)
        Me.Controls.Add(Me.lbl����������)
        Me.Controls.Add(Me.lbl������)
        Me.Controls.Add(Me.edit����������������)
        Me.Controls.Add(Me.edit���)
        Me.Controls.Add(Me.edit���������)
        Me.Controls.Add(Me.edit���)
        Me.Controls.Add(Me.edit������)
        Me.Controls.Add(Me.edit���������)
        Me.Controls.Add(Me.edit�������)
        Me.Controls.Add(Me.edit����������)
        Me.Controls.Add(Me.edit������)
        Me.Controls.Add(Me.lbl�������_�������)
        Me.Controls.Add(Me.lbl�����)
        Me.Controls.Add(Me.lbl������)
        Me.Controls.Add(Me.lbl����������)
        Me.Controls.Add(Me.lbl��������)
        Me.Controls.Add(Me.lbl��������)
        Me.Controls.Add(Me.lbl����_���������)
        Me.Controls.Add(Me.lbl������_�������)
        Me.Controls.Add(Me.edit�������_�������)
        Me.Controls.Add(Me.edit�����)
        Me.Controls.Add(Me.edit������)
        Me.Controls.Add(Me.edit����������)
        Me.Controls.Add(Me.edit��������)
        Me.Controls.Add(Me.edit��������)
        Me.Controls.Add(Me.edit����_���������)
        Me.Controls.Add(Me.edit������_�������)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.editISBN)
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmKiniseislast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��������"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtskiniseislast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtskiniseislast, "��������").CancelCurrentEdit()
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtskiniseislast, "��������").Count > 0) Then
            Me.BindingContext(objdtskiniseislast, "��������").RemoveAt(Me.BindingContext(objdtskiniseislast, "��������").Position)
            Me.objdtskiniseislast_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtskiniseislast, "��������").EndCurrentEdit()
            Me.BindingContext(objdtskiniseislast, "��������").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtskiniseislast_PositionChanged()

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
        Me.objdtskiniseislast_PositionChanged()

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
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtskiniseislast, "��������").Position = 0
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtskiniseislast, "��������").Position = (Me.objdtskiniseislast.Tables("��������").Rows.Count - 1)
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtskiniseislast, "��������").Position = (Me.BindingContext(objdtskiniseislast, "��������").Position - 1)
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtskiniseislast, "��������").Position = (Me.BindingContext(objdtskiniseislast, "��������").Position + 1)
        Me.objdtskiniseislast_PositionChanged()

    End Sub
    Private Sub objdtskiniseislast_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtskiniseislast, "��������").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtskiniseislast, "��������").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtskiniseislast.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtskiniseislast = New prjctDoReMi.dtskiniseislast
        'Stop any current edits.
        Me.BindingContext(objdtskiniseislast, "��������").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtskiniseislast.GetChanges, prjctDoReMi.dtskiniseislast)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtskiniseislast.Merge(objDataSetChanges)
                objdtskiniseislast.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtskiniseislast
        objDataSetTemp = New prjctDoReMi.dtskiniseislast
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtskiniseislast.Clear()
            'Merge the records into the main dataset.
            objdtskiniseislast.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtskiniseislast)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtskiniseislast)
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

    Private Sub frmKiniseislast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)


        Module1.tempdate = True
    End Sub

    Private Sub frmKiniseislast_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

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
            Me.objdtskiniseislast_PositionChanged()
            Module1.tempswitch = False
        End If
        If Module1.tempswitch2 = True Then
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ����������� like '" & Module1.vartempcuscode & "'; ", OleDbConnection1)
            OleDbDataAdapter2.SelectCommand = varsql
            Try
                'Attempt to load the dataset.
                Me.LoadDataSet()
            Catch eLoad As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eLoad.Message)
            End Try
            Me.objdtskiniseislast_PositionChanged()
            Module1.tempswitch2 = False
        End If


        If Module1.telospolisis = True Then
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""
            Label15.Text = ""
            Label16.Text = ""
            Label24.Text = ""
            Label23.Text = ""
            Label22.Text = ""
            Label21.Text = ""
            Label20.Text = ""
            Label18.Text = ""
            Label19.Text = ""
            Label17.Text = ""
            Label36.Text = ""

            edit���.Text = ""
            edit���������.Text = ""
            edit���.Text = ""
            edit������.Text = ""
            edit���������.Text = ""
            edit�������.Text = ""
            edit�������_�������.Text = ""
            edit������.Text = ""
            edit�����.Text = ""
            edit������.Text = ""
            edit����������.Text = ""
            edit��������.Text = ""
            edit��������.Text = ""
            edit����_���������.Text = ""
            edit����������.Text = ""
            edit������_�������.Text = ""
            editISBN.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Module1.telospolisis = False
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label24.Text = ""
        Label23.Text = ""
        Label22.Text = ""
        Label21.Text = ""
        Label20.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label17.Text = ""
        Label36.Text = ""

        Dim a As New frmBookSearch
        a.MdiParent = prjctDoReMi.frmMain.ActiveForm
        a.Show()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox3.Visible = True

        'this code inserts a new record in kiniseis
        If Module1.tempvalidkinishswitch = True Then
            Try
                'Clear out the current edits
                Me.BindingContext(objdtskiniseislast, "��������").EndCurrentEdit()
                Me.BindingContext(objdtskiniseislast, "��������").AddNew()
            Catch eEndEdit As System.Exception
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
            Me.objdtskiniseislast_PositionChanged()
            edit���.Text = Label14.Text
            edit���������.Text = Label13.Text
            edit���.Text = Label15.Text
            edit������.Text = Label21.Text
            edit���������.Text = Label16.Text
            edit�������.Text = Label9.Text
            edit�������_�������.Text = Label20.Text
            edit������.Text = Label12.Text
            edit�����.Text = Label10.Text
            edit������.Text = Label22.Text
            edit����������.Text = Label19.Text
            edit��������.Text = Label24.Text
            edit��������.Text = Label11.Text
            edit����_���������.Text = Label17.Text
            edit������_�������.Text = Label23.Text

            Try
                'Attempt to update the datasource.
                Me.UpdateDataSet()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eUpdate.Message)
            End Try
            Me.objdtskiniseislast_PositionChanged()
            Module1.tempvalidkinishswitch = False
        End If

    End Sub

    Private Sub edit���_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit���.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim a, b As Double
        a = Val(TextBox1.Text)
        b = Val(Label18.Text)

        If a <= b And b <> 0 Then
            'Module1.tempvalidkinishswitch = True
            ' Module1.tempkinishquantity = TextBox1.Text
            '  TextBox1.Text = ""
            Try
                'Clear out the current edits
                Me.BindingContext(objdtskiniseislast, "��������").EndCurrentEdit()
                Me.BindingContext(objdtskiniseislast, "��������").AddNew()
            Catch eEndEdit As System.Exception
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

            Me.objdtskiniseislast_PositionChanged()
            edit���.Text = Label14.Text
            edit���������.Text = Label13.Text
            edit���.Text = Label15.Text
            edit������.Text = Label21.Text
            edit���������.Text = Label16.Text
            edit�������.Text = Label9.Text
            edit�������_�������.Text = Label20.Text
            edit������.Text = Label12.Text
            edit�����.Text = Label10.Text
            edit������.Text = Label22.Text
            edit����������.Text = Label19.Text
            edit��������.Text = Label24.Text
            edit��������.Text = Label11.Text
            edit����_���������.Text = TextBox4.Text
            edit����������.Text = TextBox3.Text
            edit������_�������.Text = Label23.Text
            editISBN.Text = Label36.Text

            TextBox2.Text = a
            Module1.tempsmlbooks = b - a


            Dim ss As New frmtempbooks
            ss.ShowDialog()

            Try
                'Attempt to update the datasource.
                Me.UpdateDataSet()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                'Display error message, if any.
                System.Windows.Forms.MessageBox.Show(eUpdate.Message)
            End Try

            Me.objdtskiniseislast_PositionChanged()

            TextBox1.Text = ""
            GroupBox3.Visible = False

            If Module1.tempswitch = True Then
                Dim varsql As New OleDb.OleDbCommand("select * from tblBooks where ISBN like '" & Module1.vartempISBN & "%' ", OleDbConnection1)
                OleDbDataAdapter3.SelectCommand = varsql
                Try
                    'Attempt to load the dataset.
                    Me.LoadDataSet()
                Catch eLoad As System.Exception
                    'Add your error handling code here.
                    'Display error message, if any.
                    System.Windows.Forms.MessageBox.Show(eLoad.Message)
                End Try
                Me.objdtskiniseislast_PositionChanged()
                Module1.tempswitch = False
            End If

            If Module1.tempswitch2 = True Then
                Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ����������� like '" & Module1.vartempcuscode & "%' ", OleDbConnection1)
                OleDbDataAdapter2.SelectCommand = varsql
                Try
                    'Attempt to load the dataset.
                    Me.LoadDataSet()
                Catch eLoad As System.Exception
                    'Add your error handling code here.
                    'Display error message, if any.
                    System.Windows.Forms.MessageBox.Show(eLoad.Message)
                End Try
                Me.objdtskiniseislast_PositionChanged()
                Module1.tempswitch2 = False
            End If
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""
            Label15.Text = ""
            Label16.Text = ""
            Label17.Text = ""
            Label18.Text = ""
            Label19.Text = ""
            Label20.Text = ""
            Label21.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""
            Label36.Text = ""
            TextBox3.Text = Today
            TextBox4.Text = ""

        ElseIf a > b Then
            MsgBox("� �������� ��� �������� ����� ���������� ��� ��� ��������� � ����� �� �������� ����.�������� ���������������.")
        End If

       



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        TextBox1.Text = ""
        GroupBox3.Visible = False

    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
End Class
