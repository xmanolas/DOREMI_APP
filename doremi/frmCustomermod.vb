Public Class frmCustomermod
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
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lbl���������� As System.Windows.Forms.Label
    Friend WithEvents lbl���������Email As System.Windows.Forms.Label
    Friend WithEvents lbl���������������� As System.Windows.Forms.Label
    Friend WithEvents lbl����������������� As System.Windows.Forms.Label
    Friend WithEvents lbl������������� As System.Windows.Forms.Label
    Friend WithEvents lbl����������� As System.Windows.Forms.Label
    Friend WithEvents lbl�����_������� As System.Windows.Forms.Label
    Friend WithEvents edit���������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���������Email As System.Windows.Forms.TextBox
    Friend WithEvents edit���������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit����������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit������������� As System.Windows.Forms.TextBox
    Friend WithEvents edit����������� As System.Windows.Forms.TextBox
    Friend WithEvents edit�����_������� As System.Windows.Forms.TextBox
    Friend WithEvents lbl����������� As System.Windows.Forms.Label
    Friend WithEvents lbl���� As System.Windows.Forms.Label
    Friend WithEvents lbl������������������� As System.Windows.Forms.Label
    Friend WithEvents lbl�������� As System.Windows.Forms.Label
    Friend WithEvents lbl��������1 As System.Windows.Forms.Label
    Friend WithEvents lbl����_������� As System.Windows.Forms.Label
    Friend WithEvents edit����������� As System.Windows.Forms.TextBox
    Friend WithEvents edit���� As System.Windows.Forms.TextBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents objdtsCustomermod As prjctDoReMi.dtsCustomermod
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lbl���������� = New System.Windows.Forms.Label
        Me.lbl���������Email = New System.Windows.Forms.Label
        Me.lbl���������������� = New System.Windows.Forms.Label
        Me.lbl����������������� = New System.Windows.Forms.Label
        Me.lbl������������� = New System.Windows.Forms.Label
        Me.lbl����������� = New System.Windows.Forms.Label
        Me.lbl�����_������� = New System.Windows.Forms.Label
        Me.edit���������� = New System.Windows.Forms.TextBox
        Me.objdtsCustomermod = New prjctDoReMi.dtsCustomermod
        Me.edit���������Email = New System.Windows.Forms.TextBox
        Me.edit���������������� = New System.Windows.Forms.TextBox
        Me.edit����������������� = New System.Windows.Forms.TextBox
        Me.edit������������� = New System.Windows.Forms.TextBox
        Me.edit����������� = New System.Windows.Forms.TextBox
        Me.edit�����_������� = New System.Windows.Forms.TextBox
        Me.lbl����������� = New System.Windows.Forms.Label
        Me.lbl���� = New System.Windows.Forms.Label
        Me.lbl������������������� = New System.Windows.Forms.Label
        Me.lbl�������� = New System.Windows.Forms.Label
        Me.lbl��������1 = New System.Windows.Forms.Label
        Me.lbl����_������� = New System.Windows.Forms.Label
        Me.edit����������� = New System.Windows.Forms.TextBox
        Me.edit���� = New System.Windows.Forms.TextBox
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        CType(Me.objdtsCustomermod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(0, 376)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(320, 16)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 32)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "��������� �����"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(472, 8)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'lbl����������
        '
        Me.lbl����������.Location = New System.Drawing.Point(352, 136)
        Me.lbl����������.Name = "lbl����������"
        Me.lbl����������.Size = New System.Drawing.Size(104, 23)
        Me.lbl����������.TabIndex = 3
        Me.lbl����������.Text = "���"
        Me.lbl����������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl���������Email
        '
        Me.lbl���������Email.Location = New System.Drawing.Point(336, 296)
        Me.lbl���������Email.Name = "lbl���������Email"
        Me.lbl���������Email.Size = New System.Drawing.Size(120, 23)
        Me.lbl���������Email.TabIndex = 4
        Me.lbl���������Email.Text = "���������Email"
        Me.lbl���������Email.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl����������������
        '
        Me.lbl����������������.Location = New System.Drawing.Point(24, 232)
        Me.lbl����������������.Name = "lbl����������������"
        Me.lbl����������������.Size = New System.Drawing.Size(104, 23)
        Me.lbl����������������.TabIndex = 5
        Me.lbl����������������.Text = "����������������"
        Me.lbl����������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�����������������
        '
        Me.lbl�����������������.Location = New System.Drawing.Point(8, 104)
        Me.lbl�����������������.Name = "lbl�����������������"
        Me.lbl�����������������.Size = New System.Drawing.Size(120, 23)
        Me.lbl�����������������.TabIndex = 6
        Me.lbl�����������������.Text = "�������� ��������� *"
        Me.lbl�����������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�������������
        '
        Me.lbl�������������.Location = New System.Drawing.Point(24, 136)
        Me.lbl�������������.Name = "lbl�������������"
        Me.lbl�������������.Size = New System.Drawing.Size(104, 23)
        Me.lbl�������������.TabIndex = 7
        Me.lbl�������������.Text = "������������� *"
        Me.lbl�������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�����������
        '
        Me.lbl�����������.Location = New System.Drawing.Point(24, 72)
        Me.lbl�����������.Name = "lbl�����������"
        Me.lbl�����������.Size = New System.Drawing.Size(104, 23)
        Me.lbl�����������.TabIndex = 8
        Me.lbl�����������.Text = "�����������"
        Me.lbl�����������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�����_�������
        '
        Me.lbl�����_�������.Location = New System.Drawing.Point(336, 200)
        Me.lbl�����_�������.Name = "lbl�����_�������"
        Me.lbl�����_�������.Size = New System.Drawing.Size(120, 23)
        Me.lbl�����_�������.TabIndex = 9
        Me.lbl�����_�������.Text = "�����/�������"
        Me.lbl�����_�������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.���"))
        Me.edit����������.Location = New System.Drawing.Point(464, 136)
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(192, 20)
        Me.edit����������.TabIndex = 11
        Me.edit����������.Text = ""
        '
        'objdtsCustomermod
        '
        Me.objdtsCustomermod.DataSetName = "dtsCustomermod"
        Me.objdtsCustomermod.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'edit���������Email
        '
        Me.edit���������Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.���������Email"))
        Me.edit���������Email.Location = New System.Drawing.Point(464, 296)
        Me.edit���������Email.Name = "edit���������Email"
        Me.edit���������Email.Size = New System.Drawing.Size(192, 20)
        Me.edit���������Email.TabIndex = 16
        Me.edit���������Email.Text = ""
        '
        'edit����������������
        '
        Me.edit����������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.����������������"))
        Me.edit����������������.Location = New System.Drawing.Point(136, 232)
        Me.edit����������������.Name = "edit����������������"
        Me.edit����������������.Size = New System.Drawing.Size(176, 20)
        Me.edit����������������.TabIndex = 5
        Me.edit����������������.Text = ""
        '
        'edit�����������������
        '
        Me.edit�����������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�����������������"))
        Me.edit�����������������.Location = New System.Drawing.Point(136, 104)
        Me.edit�����������������.Name = "edit�����������������"
        Me.edit�����������������.Size = New System.Drawing.Size(176, 20)
        Me.edit�����������������.TabIndex = 1
        Me.edit�����������������.Text = ""
        '
        'edit�������������
        '
        Me.edit�������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�������������"))
        Me.edit�������������.Location = New System.Drawing.Point(136, 136)
        Me.edit�������������.Name = "edit�������������"
        Me.edit�������������.Size = New System.Drawing.Size(176, 20)
        Me.edit�������������.TabIndex = 2
        Me.edit�������������.Text = ""
        '
        'edit�����������
        '
        Me.edit�����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�����������"))
        Me.edit�����������.Location = New System.Drawing.Point(136, 72)
        Me.edit�����������.Name = "edit�����������"
        Me.edit�����������.Size = New System.Drawing.Size(176, 20)
        Me.edit�����������.TabIndex = 0
        Me.edit�����������.Text = ""
        '
        'edit�����_�������
        '
        Me.edit�����_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�����/�������"))
        Me.edit�����_�������.Location = New System.Drawing.Point(464, 200)
        Me.edit�����_�������.Name = "edit�����_�������"
        Me.edit�����_�������.Size = New System.Drawing.Size(192, 20)
        Me.edit�����_�������.TabIndex = 13
        Me.edit�����_�������.Text = ""
        '
        'lbl�����������
        '
        Me.lbl�����������.Location = New System.Drawing.Point(24, 168)
        Me.lbl�����������.Name = "lbl�����������"
        Me.lbl�����������.Size = New System.Drawing.Size(104, 23)
        Me.lbl�����������.TabIndex = 17
        Me.lbl�����������.Text = "�����������"
        Me.lbl�����������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl����
        '
        Me.lbl����.Location = New System.Drawing.Point(336, 168)
        Me.lbl����.Name = "lbl����"
        Me.lbl����.Size = New System.Drawing.Size(120, 23)
        Me.lbl����.TabIndex = 18
        Me.lbl����.Text = "���� *"
        Me.lbl����.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl�������������������
        '
        Me.lbl�������������������.Location = New System.Drawing.Point(336, 264)
        Me.lbl�������������������.Name = "lbl�������������������"
        Me.lbl�������������������.Size = New System.Drawing.Size(120, 23)
        Me.lbl�������������������.TabIndex = 20
        Me.lbl�������������������.Text = "�������������������"
        Me.lbl�������������������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl��������
        '
        Me.lbl��������.Location = New System.Drawing.Point(24, 264)
        Me.lbl��������.Name = "lbl��������"
        Me.lbl��������.Size = New System.Drawing.Size(104, 23)
        Me.lbl��������.TabIndex = 21
        Me.lbl��������.Text = "�������� 1"
        Me.lbl��������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl��������1
        '
        Me.lbl��������1.Location = New System.Drawing.Point(24, 296)
        Me.lbl��������1.Name = "lbl��������1"
        Me.lbl��������1.Size = New System.Drawing.Size(104, 23)
        Me.lbl��������1.TabIndex = 22
        Me.lbl��������1.Text = "�������� 2"
        Me.lbl��������1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl����_�������
        '
        Me.lbl����_�������.Location = New System.Drawing.Point(336, 232)
        Me.lbl����_�������.Name = "lbl����_�������"
        Me.lbl����_�������.Size = New System.Drawing.Size(120, 23)
        Me.lbl����_�������.TabIndex = 23
        Me.lbl����_�������.Text = "����/�������"
        Me.lbl����_�������.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'edit�����������
        '
        Me.edit�����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�����������"))
        Me.edit�����������.Location = New System.Drawing.Point(136, 168)
        Me.edit�����������.Name = "edit�����������"
        Me.edit�����������.Size = New System.Drawing.Size(176, 20)
        Me.edit�����������.TabIndex = 3
        Me.edit�����������.Text = ""
        '
        'edit����
        '
        Me.edit����.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.����"))
        Me.edit����.Location = New System.Drawing.Point(464, 168)
        Me.edit����.Name = "edit����"
        Me.edit����.Size = New System.Drawing.Size(192, 20)
        Me.edit����.TabIndex = 12
        Me.edit����.Text = ""
        '
        'edit����������
        '
        Me.edit����������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.����������"))
        Me.edit����������.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.edit����������.Location = New System.Drawing.Point(16, 16)
        Me.edit����������.Multiline = True
        Me.edit����������.Name = "edit����������"
        Me.edit����������.Size = New System.Drawing.Size(608, 312)
        Me.edit����������.TabIndex = 20
        Me.edit����������.Text = ""
        '
        'edit�������������������
        '
        Me.edit�������������������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.�������������������"))
        Me.edit�������������������.Location = New System.Drawing.Point(464, 264)
        Me.edit�������������������.Name = "edit�������������������"
        Me.edit�������������������.Size = New System.Drawing.Size(192, 20)
        Me.edit�������������������.TabIndex = 15
        Me.edit�������������������.Text = ""
        '
        'edit��������
        '
        Me.edit��������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.��������"))
        Me.edit��������.Location = New System.Drawing.Point(136, 264)
        Me.edit��������.Name = "edit��������"
        Me.edit��������.Size = New System.Drawing.Size(176, 20)
        Me.edit��������.TabIndex = 6
        Me.edit��������.Text = ""
        '
        'edit��������1
        '
        Me.edit��������1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.��������1"))
        Me.edit��������1.Location = New System.Drawing.Point(136, 296)
        Me.edit��������1.Name = "edit��������1"
        Me.edit��������1.Size = New System.Drawing.Size(176, 20)
        Me.edit��������1.TabIndex = 7
        Me.edit��������1.Text = ""
        '
        'edit����_�������
        '
        Me.edit����_�������.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.����/�������"))
        Me.edit����_�������.Location = New System.Drawing.Point(464, 232)
        Me.edit����_�������.Name = "edit����_�������"
        Me.edit����_�������.Size = New System.Drawing.Size(192, 20)
        Me.edit����_�������.TabIndex = 14
        Me.edit����_�������.Text = ""
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(208, 384)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 31
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(248, 384)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 32
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(280, 384)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 33
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(376, 384)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 34
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(408, 384)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 35
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(208, 416)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "��������"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 416)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "��������"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(368, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "�������"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "����������"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.edit����������)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 368)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "����������"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "���������"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.kinhto"))
        Me.TextBox1.Location = New System.Drawing.Point(136, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(352, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "����������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.����������"))
        Me.TextBox2.Location = New System.Drawing.Point(464, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(352, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.���"))
        Me.TextBox3.Location = New System.Drawing.Point(464, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.���������"))
        Me.TextBox4.Location = New System.Drawing.Point(136, 200)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "���������"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(336, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Web Site"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "�����������.website"))
        Me.TextBox5.Location = New System.Drawing.Point(464, 328)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 20)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "���������� �������"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "��������"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "�����������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("kinhto", "kinhto"), New System.Data.Common.DataColumnMapping("website", "website"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������Email", "���������Email"), New System.Data.Common.DataColumnMapping("����������������", "����������������"), New System.Data.Common.DataColumnMapping("���", "���"), New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("�����������������", "�����������������"), New System.Data.Common.DataColumnMapping("�������������", "�������������"), New System.Data.Common.DataColumnMapping("�����������", "�����������"), New System.Data.Common.DataColumnMapping("�����/�������", "�����/�������"), New System.Data.Common.DataColumnMapping("�����������", "�����������"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("����������", "����������"), New System.Data.Common.DataColumnMapping("�������������������", "�������������������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("��������1", "��������1"), New System.Data.Common.DataColumnMapping("����/�������", "����/�������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ����������� WHERE (����������� = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO �����������(kinhto, website, ����������, ���, ���������Email, �������" & _
        "���������, ���, ���������, �����������������, �������������, �����������, [�����" & _
        "/�������], �����������, ����, ����������, �������������������, ��������, �������" & _
        "�1, [����/�������]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 30, "�����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT kinhto, website, ����������, ���, ���������Email, ����������������, ���, �" & _
        "��������, �����������������, �������������, �����������, [�����/�������], ������" & _
        "�����, ����, ����������, �������������������, ��������, ��������1, [����/�������" & _
        "] FROM �����������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ����������� SET kinhto = ?, website = ?, ���������� = ?, ��� = ?, ��������" & _
        "�Email = ?, ���������������� = ?, ��� = ?, ��������� = ?, ����������������� = ?," & _
        " ������������� = ?, ����������� = ?, [�����/�������] = ?, ����������� = ?, ���� " & _
        "= ?, ���������� = ?, ������������������� = ?, �������� = ?, ��������1 = ?, [����" & _
        "/�������] = ? WHERE (����������� = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("kinhto", System.Data.OleDb.OleDbType.VarWChar, 30, "kinhto"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("website", System.Data.OleDb.OleDbType.VarWChar, 30, "website"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 30, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������Email", System.Data.OleDb.OleDbType.VarWChar, 50, "���������Email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������", System.Data.OleDb.OleDbType.VarWChar, 255, "����������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 12, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 50, "�����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����_�������", System.Data.OleDb.OleDbType.VarWChar, 20, "�����/�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�����������", System.Data.OleDb.OleDbType.VarWChar, 30, "�����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 50, "����"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������������", System.Data.OleDb.OleDbType.VarWChar, 20, "�������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 30, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������1", System.Data.OleDb.OleDbType.VarWChar, 30, "��������1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����_�������", System.Data.OleDb.OleDbType.VarWChar, 50, "����/�������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�����������", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmCustomermod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 448)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lbl����������)
        Me.Controls.Add(Me.lbl���������Email)
        Me.Controls.Add(Me.lbl����������������)
        Me.Controls.Add(Me.lbl�����������������)
        Me.Controls.Add(Me.lbl�������������)
        Me.Controls.Add(Me.lbl�����������)
        Me.Controls.Add(Me.lbl�����_�������)
        Me.Controls.Add(Me.edit����������)
        Me.Controls.Add(Me.edit���������Email)
        Me.Controls.Add(Me.edit����������������)
        Me.Controls.Add(Me.edit�����������������)
        Me.Controls.Add(Me.edit�������������)
        Me.Controls.Add(Me.edit�����������)
        Me.Controls.Add(Me.edit�����_�������)
        Me.Controls.Add(Me.lbl�����������)
        Me.Controls.Add(Me.lbl����)
        Me.Controls.Add(Me.lbl�������������������)
        Me.Controls.Add(Me.lbl��������)
        Me.Controls.Add(Me.lbl��������1)
        Me.Controls.Add(Me.lbl����_�������)
        Me.Controls.Add(Me.edit�����������)
        Me.Controls.Add(Me.edit����)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmCustomermod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�������"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsCustomermod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsCustomermod, "�����������").CancelCurrentEdit()
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsCustomermod, "�����������").Count > 0) Then
            Me.BindingContext(objdtsCustomermod, "�����������").RemoveAt(Me.BindingContext(objdtsCustomermod, "�����������").Position)
            Me.objdtsCustomermod_PositionChanged()
        End If
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objdtsCustomermod_PositionChanged()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdtsCustomermod, "�����������").EndCurrentEdit()
            Me.BindingContext(objdtsCustomermod, "�����������").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsCustomermod_PositionChanged()
        edit�����������.Focus()
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
        Me.objdtsCustomermod_PositionChanged()
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objdtsCustomermod_PositionChanged()

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
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdtsCustomermod, "�����������").Position = 0
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsCustomermod, "�����������").Position = (Me.objdtsCustomermod.Tables("�����������").Rows.Count - 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsCustomermod, "�����������").Position = (Me.BindingContext(objdtsCustomermod, "�����������").Position - 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsCustomermod, "�����������").Position = (Me.BindingContext(objdtsCustomermod, "�����������").Position + 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub objdtsCustomermod_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsCustomermod, "�����������").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsCustomermod, "�����������").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsCustomermod.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsCustomermod = New prjctDoReMi.dtsCustomermod
        'Stop any current edits.
        Me.BindingContext(objdtsCustomermod, "�����������").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdtsCustomermod.GetChanges, prjctDoReMi.dtsCustomermod)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdtsCustomermod.Merge(objDataSetChanges)
                objdtsCustomermod.AcceptChanges()
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
        Dim objDataSetTemp As prjctDoReMi.dtsCustomermod
        objDataSetTemp = New prjctDoReMi.dtsCustomermod
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdtsCustomermod.Clear()
            'Merge the records into the main dataset.
            objdtsCustomermod.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As prjctDoReMi.dtsCustomermod)
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
    Public Sub FillDataSet(ByVal dataSet As prjctDoReMi.dtsCustomermod)
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

    Private Sub frmCustomermod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleDbConnection1.ConnectionString = Module1.iuDataAccess.AccessConnection(Module1.fp)

        If Module1.varCustomertemp <> "" Then
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� where ����������� like '" & Module1.varCustomertemp & "%';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        Else
            Dim varsql As New OleDb.OleDbCommand("select * from ����������� ;", OleDbConnection1)
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
        Me.objdtsCustomermod_PositionChanged()


    End Sub

    Private Sub edit�����_�������_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit�����_�������.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
        GroupBox1.SendToBack()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        GroupBox1.BringToFront()
    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub frmCustomermod_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
