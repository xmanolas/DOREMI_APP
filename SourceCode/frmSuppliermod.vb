Public Class frmSuppliermod
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
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objdtsSuppliermod As prjctDoReMi.dtsSuppliermod
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl��������� As System.Windows.Forms.Label
    Friend WithEvents lbl���������Email As System.Windows.Forms.Label
    Friend WithEvents lbl������������� As System.Windows.Forms.Label
    Friend WithEvents lbl�����_������� As System.Windows.Forms.Label
    Friend WithEvents lbl���� As System.Windows.Forms.Label
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit��������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������Email As System.Windows.Forms.TextBox
    Friend WithEvents edit������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit�����_������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���� As System.Windows.Forms.TextBox
    Friend WithEvents lbl����������� As System.Windows.Forms.Label
    Friend WithEvents lbl������������������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl��������1 As System.Windows.Forms.Label
    Friend WithEvents lbl����_������� As System.Windows.Forms.Label
    Friend WithEvents edit����������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit�������� As System.Windows.Forms.TextBox
    Friend WithEvents edit��������1 As System.Windows.Forms.TextBox
    Friend WithEvents edit����_������� As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.objdtsSuppliermod = New prjctDoReMi.dtsSuppliermod
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl��������� = New System.Windows.Forms.Label
        Me.lbl���������Email = New System.Windows.Forms.Label
        Me.lbl������������� = New System.Windows.Forms.Label
        Me.lbl�����_������� = New System.Windows.Forms.Label
        Me.lbl���� = New System.Windows.Forms.Label
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.edit��������� = New System.Windows.Forms.TextBox
        Me.edit���������Email = New System.Windows.Forms.TextBox
        Me.edit������������� = New System.Windows.Forms.TextBox
        Me.edit�����_������� = New System.Windows.Forms.TextBox
        Me.edit���� = New System.Windows.Forms.TextBox
        Me.lbl����������� = New System.Windows.Forms.Label
        Me.lbl������������������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl��������1 = New System.Windows.Forms.Label
        Me.lbl����_������� = New System.Windows.Forms.Label
        Me.edit����������� = New System.Windows.Forms.TextBox
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.edit������������������� = New System.Windows.Forms.TextBox
        Me.edit�������� = New System.Windows.Forms.TextBox
        Me.edit��������1 = New System.Windows.Forms.TextBox
        Me.edit����_������� = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.objdtsSuppliermod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\Program Files\Doremi\dbMain.mdb"";Jet OLEDB:Engine " & _
        "Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";J" & _
        "et OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Extend" & _
        "ed Properties=;Mode=Share Deny None;Jet OLEDB:Create System Database=False;Jet O" & _
        "LEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair" & _
        "=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "�����������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("���������Email", "���������Email"), New System.Data.Common.DataColumnMapping("�������������", "�������������"), New System.Data.Common.DataColumnMapping("�����/�������", "�����/�������"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("�����������", "�����������"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("�������������������", "�������������������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������1", "��������1"), New System.Data.Common.DataColumnMapping("����/�������", "����/�������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ����������� WHERE (������������� = ?) AND (���������� = ? OR ? IS NUL" & _
        "L AND ���������� IS NULL) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL)" & _
        " AND (���������Email = ? OR ? IS NULL AND ���������Email IS NULL) AND ([�����/��" & _
        "�����] = ? OR ? IS NULL AND [�����/�������] IS NULL) AND (����������� = ? OR ? I" & _
        "S NULL AND ����������� IS NULL) AND (���� = ? OR ? IS NULL AND ���� IS NULL) AND" & _
        " (������������������� = ? OR ? IS NULL AND ������������������� IS NULL) AND (���" & _
        "����� = ? OR ? IS NULL AND �������� IS NULL) AND (��������1 = ? OR ? IS NULL AND" & _
        " ��������1 IS NULL) AND ([����/�������] = ? OR ? IS NULL AND [����/�������] IS N" & _
        "ULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO �����������(����������, ���������, ���������Email, �������������, [��" & _
        "���/�������], ����, �����������, ����������, �������������������, ��������, ����" & _
        "����1, [����/�������]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 255, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ����������, ���������, ���������Email, �������������, [�����/�������], ���" & _
        "�, �����������, ����������, �������������������, ��������, ��������1, [����/����" & _
        "���] FROM �����������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ����������� SET ���������� = ?, ��������� = ?, ���������Email = ?, �������" & _
        "������ = ?, [�����/�������] = ?, ���� = ?, ����������� = ?, ���������� = ?, ����" & _
        "��������������� = ?, �������� = ?, ��������1 = ?, [����/�������] = ? WHERE (����" & _
        "��������� = ?) AND (���������� = ? OR ? IS NULL AND ���������� IS NULL) AND (���" & _
        "������ = ? OR ? IS NULL AND ��������� IS NULL) AND (���������Email = ? OR ? IS N" & _
        "ULL AND ���������Email IS NULL) AND ([�����/�������] = ? OR ? IS NULL AND [�����" & _
        "/�������] IS NULL) AND (����������� = ? OR ? IS NULL AND ����������� IS NULL) AN" & _
        "D (���� = ? OR ? IS NULL AND ���� IS NULL) AND (������������������� = ? OR ? IS " & _
        "NULL AND ������������������� IS NULL) AND (�������� = ? OR ? IS NULL AND �������" & _
        "� IS NULL) AND (��������1 = ? OR ? IS NULL AND ��������1 IS NULL) AND ([����/���" & _
        "����] = ? OR ? IS NULL AND [����/�������] IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 255, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������Email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����_�������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������������1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������12", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_����_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����/�������", System.Data.DataRowVersion.Original, Nothing))
        '
        'objdtsSuppliermod
        '
        Me.objdtsSuppliermod.DataSetName = "dtsSuppliermod"
        Me.objdtsSuppliermod.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(320, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 32)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "��������� �����"
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(384, 256)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(72, 23)
        Me.lbl����������.TabIndex = 3
        Me.lbl����������.Text = "����������"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl���������
        '
        Me.lbl���������.Location = New System.Drawing.Point(32, 192)
        Me.lbl���������.Name = "lbl���������"
        Me.lbl���������.TabIndex = 4
        Me.lbl���������.Text = "���������"
        Me.lbl���������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl���������Email
        '
        Me.lbl���������Email.Location = New System.Drawing.Point(368, 160)
        Me.lbl���������Email.Name = "lbl���������Email"
        Me.lbl���������Email.TabIndex = 5
        Me.lbl���������Email.Text = "���������Email"
        Me.lbl���������Email.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�������������
        '
        Me.lbl�������������.Location = New System.Drawing.Point(32, 128)
        Me.lbl�������������.Name = "lbl�������������"
        Me.lbl�������������.TabIndex = 6
        Me.lbl�������������.Text = "�������������"
        Me.lbl�������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�����_�������
        '
        Me.lbl�����_�������.Location = New System.Drawing.Point(32, 256)
        Me.lbl�����_�������.Name = "lbl�����_�������"
        Me.lbl�����_�������.TabIndex = 7
        Me.lbl�����_�������.Text = "�����/�������"
        Me.lbl�����_�������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl����
        '
        Me.lbl����.Location = New System.Drawing.Point(32, 224)
        Me.lbl����.Name = "lbl����"
        Me.lbl����.TabIndex = 8
        Me.lbl����.Text = "����"
        Me.lbl����.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.����������"))
        Me.edit����������.Location = New System.Drawing.Point(472, 256)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(136, 20)
        Me.edit����������.TabIndex = 10
        Me.edit����������.Text = ""
        '
        'edit���������
        '
        Me.edit���������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.���������"))
        Me.edit���������.Location = New System.Drawing.Point(144, 192)
        Me.edit���������.Name = "edit���������"
        Me.edit���������.Size = New System.Drawing.Size(168, 20)
        Me.edit���������.TabIndex = 2
        Me.edit���������.Text = ""
        '
        'edit���������Email
        '
        Me.edit���������Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.���������Email"))
        Me.edit���������Email.Location = New System.Drawing.Point(472, 160)
        Me.edit���������Email.Name = "edit���������Email"
        Me.edit���������Email.Size = New System.Drawing.Size(136, 20)
        Me.edit���������Email.TabIndex = 7
        Me.edit���������Email.Text = ""
        '
        'edit�������������
        '
        Me.edit�������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.�������������"))
        Me.edit�������������.Location = New System.Drawing.Point(144, 128)
        Me.edit�������������.Name = "edit�������������"
        Me.edit�������������.Size = New System.Drawing.Size(168, 20)
        Me.edit�������������.TabIndex = 0
        Me.edit�������������.Text = ""
        '
        'edit�����_�������
        '
        Me.edit�����_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.�����/�������"))
        Me.edit�����_�������.Location = New System.Drawing.Point(144, 256)
        Me.edit�����_�������.Name = "edit�����_�������"
        Me.edit�����_�������.Size = New System.Drawing.Size(168, 20)
        Me.edit�����_�������.TabIndex = 4
        Me.edit�����_�������.Text = ""
        '
        'edit����
        '
        Me.edit����.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.����"))
        Me.edit����.Location = New System.Drawing.Point(144, 224)
        Me.edit����.Name = "edit����"
        Me.edit����.Size = New System.Drawing.Size(168, 20)
        Me.edit����.TabIndex = 3
        Me.edit����.Text = ""
        '
        'lbl�����������
        '
        Me.lbl�����������.Location = New System.Drawing.Point(32, 160)
        Me.lbl�����������.Name = "lbl�����������"
        Me.lbl�����������.TabIndex = 15
        Me.lbl�����������.Text = "����������� *"
        Me.lbl�����������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�������������������
        '
        Me.lbl�������������������.Location = New System.Drawing.Point(360, 128)
        Me.lbl�������������������.Name = "lbl�������������������"
        Me.lbl�������������������.TabIndex = 17
        Me.lbl�������������������.Text = "���. �������"
        Me.lbl�������������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(360, 192)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.TabIndex = 18
        Me.lbl��������.Text = "��������"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl��������1
        '
        Me.lbl��������1.Location = New System.Drawing.Point(360, 224)
        Me.lbl��������1.Name = "lbl��������1"
        Me.lbl��������1.TabIndex = 19
        Me.lbl��������1.Text = "�������� 2"
        Me.lbl��������1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl����_�������
        '
        Me.lbl����_�������.Location = New System.Drawing.Point(32, 288)
        Me.lbl����_�������.Name = "lbl����_�������"
        Me.lbl����_�������.TabIndex = 20
        Me.lbl����_�������.Text = "����/������� *"
        Me.lbl����_�������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'edit�����������
        '
        Me.edit�����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.�����������"))
        Me.edit�����������.Location = New System.Drawing.Point(144, 160)
        Me.edit�����������.Name = "edit�����������"
        Me.edit�����������.Size = New System.Drawing.Size(168, 20)
        Me.edit�����������.TabIndex = 1
        Me.edit�����������.Text = ""
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.����������"))
        Me.edit����������.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.edit����������.Location = New System.Drawing.Point(16, 16)
        Me.edit����������.Multiline = True
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(616, 392)
        Me.edit����������.TabIndex = 13
        Me.edit����������.Text = ""
        '
        'edit�������������������
        '
        Me.edit�������������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.�������������������"))
        Me.edit�������������������.Location = New System.Drawing.Point(472, 128)
        Me.edit�������������������.Name = "edit�������������������"
        Me.edit�������������������.Size = New System.Drawing.Size(136, 20)
        Me.edit�������������������.TabIndex = 6
        Me.edit�������������������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(472, 192)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(136, 20)
        Me.edit��������.TabIndex = 8
        Me.edit��������.Text = ""
        '
        'edit��������1
        '
        Me.edit��������1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.��������1"))
        Me.edit��������1.Location = New System.Drawing.Point(472, 224)
        Me.edit��������1.Name = "edit��������1"
        Me.edit��������1.Size = New System.Drawing.Size(136, 20)
        Me.edit��������1.TabIndex = 9
        Me.edit��������1.Text = ""
        '
        'edit����_�������
        '
        Me.edit����_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsSuppliermod, "�����������.����/�������"))
        Me.edit����_�������.Location = New System.Drawing.Point(144, 288)
        Me.edit����_�������.Name = "edit����_�������"
        Me.edit����_�������.Size = New System.Drawing.Size(168, 20)
        Me.edit����_�������.TabIndex = 5
        Me.edit����_�������.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(248, 328)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 27
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(288, 328)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 28
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(320, 328)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 29
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(416, 328)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 30
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(456, 328)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 31
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(248, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "��������"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(336, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "��������"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(416, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "�������"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(480, 384)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.TabStop = False
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.edit����������)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 464)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "����������"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "���������"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "����������"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "���������� �����������"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "��������"
        '
        'frmSuppliermod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lbl����������)
        Me.Controls.Add(Me.lbl���������)
        Me.Controls.Add(Me.lbl���������Email)
        Me.Controls.Add(Me.lbl�������������)
        Me.Controls.Add(Me.lbl�����_�������)
        Me.Controls.Add(Me.lbl����)
        Me.Controls.Add(Me.edit����������)
        Me.Controls.Add(Me.edit���������)
        Me.Controls.Add(Me.edit���������Email)
        Me.Controls.Add(Me.edit�������������)
        Me.Controls.Add(Me.edit�����_�������)
        Me.Controls.Add(Me.edit����)
        Me.Controls.Add(Me.lbl�����������)
        Me.Controls.Add(Me.lbl�������������������)
        Me.Controls.Add(Me.lbl��������)
        Me.Controls.Add(Me.lbl��������1)
        Me.Controls.Add(Me.lbl����_�������)
        Me.Controls.Add(Me.edit�����������)
        Me.Controls.Add(Me.edit�������������������)
        Me.Controls.Add(Me.edit��������)
        Me.Controls.Add(Me.edit��������1)
        Me.Controls.Add(Me.edit����_�������)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmSuppliermod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�����������"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsSuppliermod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsSuppliermod, "�����������").CancelCurrentEdit()
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsSuppliermod, "�����������").Count > 0) Then
            Me.BindingContext(objdtsSuppliermod, "�����������").RemoveAt(Me.BindingContext(objdtsSuppliermod, "�����������").Position)
            Me.objdtsSuppliermod_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            'Clear out the current edits
            Me.BindingContext(objdtsSuppliermod, "�����������").EndCurrentEdit()
            Me.BindingContext(objdtsSuppliermod, "�����������").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsSuppliermod_PositionChanged()
        edit�������������.Focus()
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
        Me.objdtsSuppliermod_PositionChanged()
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsSuppliermod_PositionChanged()

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
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsSuppliermod, "�����������").Position = 0
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsSuppliermod, "�����������").Position = (Me.objdtsSuppliermod.Tables("�����������").Rows.Count - 1)
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsSuppliermod, "�����������").Position = (Me.BindingContext(objdtsSuppliermod, "�����������").Position - 1)
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsSuppliermod, "�����������").Position = (Me.BindingContext(objdtsSuppliermod, "�����������").Position + 1)
        Me.objdtsSuppliermod_PositionChanged()

    End Sub
    Private Sub objdtsSuppliermod_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsSuppliermod, "�����������").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsSuppliermod, "�����������").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsSuppliermod.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsSuppliermod = New prjctDoReMi.dtsSuppliermod
        'Stop any current edits.
        Me.BindingContext(objdtsSuppliermod, "�����������").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsSuppliermod.GetChanges, prjctDoReMi.dtsSuppliermod)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsSuppliermod.Merge(objDataSetChanges)
                objdtsSuppliermod.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsSuppliermod
        objDataSetTemp = New prjctDoReMi.dtsSuppliermod
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsSuppliermod.Clear()
            'Merge the records into the main dataset.
            objdtsSuppliermod.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsSuppliermod)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsSuppliermod)
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

    Private Sub frmSuppliermod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ������������� like '" & Module1.varSuppliertemp & "%';", OleDbConnection1)
        OleDbDataAdapter1.SelectCommand = varsql
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsSuppliermod_PositionChanged()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()

    End Sub

    Private Sub frmSuppliermod_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
