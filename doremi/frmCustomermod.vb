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
    Friend WithEvents lblΑριθμόςΦαξ As System.Windows.Forms.Label
    Friend WithEvents lblΔιεύθυνσηEmail As System.Windows.Forms.Label
    Friend WithEvents lblΔιεύθυνσηΧρέωσης As System.Windows.Forms.Label
    Friend WithEvents lblΕπωνυμίαΕταιρείας As System.Windows.Forms.Label
    Friend WithEvents lblΕπώνυμοΕπαφής As System.Windows.Forms.Label
    Friend WithEvents lblΚωδΑγοραστή As System.Windows.Forms.Label
    Friend WithEvents lblΝομός_Περιοχή As System.Windows.Forms.Label
    Friend WithEvents editΑριθμόςΦαξ As System.Windows.Forms.TextBox
    Friend WithEvents editΔιεύθυνσηEmail As System.Windows.Forms.TextBox
    Friend WithEvents editΔιεύθυνσηΧρέωσης As System.Windows.Forms.TextBox
    Friend WithEvents editΕπωνυμίαΕταιρείας As System.Windows.Forms.TextBox
    Friend WithEvents editΕπώνυμοΕπαφής As System.Windows.Forms.TextBox
    Friend WithEvents editΚωδΑγοραστή As System.Windows.Forms.TextBox
    Friend WithEvents editΝομός_Περιοχή As System.Windows.Forms.TextBox
    Friend WithEvents lblΌνομαΕπαφής As System.Windows.Forms.Label
    Friend WithEvents lblΠόλη As System.Windows.Forms.Label
    Friend WithEvents lblΤαχυδρομικόςΚώδικας As System.Windows.Forms.Label
    Friend WithEvents lblΤηλέφωνο As System.Windows.Forms.Label
    Friend WithEvents lblΤηλέφωνο1 As System.Windows.Forms.Label
    Friend WithEvents lblΧώρα_Περιοχή As System.Windows.Forms.Label
    Friend WithEvents editΌνομαΕπαφής As System.Windows.Forms.TextBox
    Friend WithEvents editΠόλη As System.Windows.Forms.TextBox
    Friend WithEvents editΣημειώσεις As System.Windows.Forms.TextBox
    Friend WithEvents editΤαχυδρομικόςΚώδικας As System.Windows.Forms.TextBox
    Friend WithEvents editΤηλέφωνο As System.Windows.Forms.TextBox
    Friend WithEvents editΤηλέφωνο1 As System.Windows.Forms.TextBox
    Friend WithEvents editΧώρα_Περιοχή As System.Windows.Forms.TextBox
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
        Me.lblΑριθμόςΦαξ = New System.Windows.Forms.Label
        Me.lblΔιεύθυνσηEmail = New System.Windows.Forms.Label
        Me.lblΔιεύθυνσηΧρέωσης = New System.Windows.Forms.Label
        Me.lblΕπωνυμίαΕταιρείας = New System.Windows.Forms.Label
        Me.lblΕπώνυμοΕπαφής = New System.Windows.Forms.Label
        Me.lblΚωδΑγοραστή = New System.Windows.Forms.Label
        Me.lblΝομός_Περιοχή = New System.Windows.Forms.Label
        Me.editΑριθμόςΦαξ = New System.Windows.Forms.TextBox
        Me.objdtsCustomermod = New prjctDoReMi.dtsCustomermod
        Me.editΔιεύθυνσηEmail = New System.Windows.Forms.TextBox
        Me.editΔιεύθυνσηΧρέωσης = New System.Windows.Forms.TextBox
        Me.editΕπωνυμίαΕταιρείας = New System.Windows.Forms.TextBox
        Me.editΕπώνυμοΕπαφής = New System.Windows.Forms.TextBox
        Me.editΚωδΑγοραστή = New System.Windows.Forms.TextBox
        Me.editΝομός_Περιοχή = New System.Windows.Forms.TextBox
        Me.lblΌνομαΕπαφής = New System.Windows.Forms.Label
        Me.lblΠόλη = New System.Windows.Forms.Label
        Me.lblΤαχυδρομικόςΚώδικας = New System.Windows.Forms.Label
        Me.lblΤηλέφωνο = New System.Windows.Forms.Label
        Me.lblΤηλέφωνο1 = New System.Windows.Forms.Label
        Me.lblΧώρα_Περιοχή = New System.Windows.Forms.Label
        Me.editΌνομαΕπαφής = New System.Windows.Forms.TextBox
        Me.editΠόλη = New System.Windows.Forms.TextBox
        Me.editΣημειώσεις = New System.Windows.Forms.TextBox
        Me.editΤαχυδρομικόςΚώδικας = New System.Windows.Forms.TextBox
        Me.editΤηλέφωνο = New System.Windows.Forms.TextBox
        Me.editΤηλέφωνο1 = New System.Windows.Forms.TextBox
        Me.editΧώρα_Περιοχή = New System.Windows.Forms.TextBox
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
        Me.btnUpdate.Text = "Ενημέρωση Βάσης"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(472, 8)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.Text = "Ca&ncel All"
        Me.btnCancelAll.Visible = False
        '
        'lblΑριθμόςΦαξ
        '
        Me.lblΑριθμόςΦαξ.Location = New System.Drawing.Point(352, 136)
        Me.lblΑριθμόςΦαξ.Name = "lblΑριθμόςΦαξ"
        Me.lblΑριθμόςΦαξ.Size = New System.Drawing.Size(104, 23)
        Me.lblΑριθμόςΦαξ.TabIndex = 3
        Me.lblΑριθμόςΦαξ.Text = "ΔΟΥ"
        Me.lblΑριθμόςΦαξ.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΔιεύθυνσηEmail
        '
        Me.lblΔιεύθυνσηEmail.Location = New System.Drawing.Point(336, 296)
        Me.lblΔιεύθυνσηEmail.Name = "lblΔιεύθυνσηEmail"
        Me.lblΔιεύθυνσηEmail.Size = New System.Drawing.Size(120, 23)
        Me.lblΔιεύθυνσηEmail.TabIndex = 4
        Me.lblΔιεύθυνσηEmail.Text = "ΔιεύθυνσηEmail"
        Me.lblΔιεύθυνσηEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΔιεύθυνσηΧρέωσης
        '
        Me.lblΔιεύθυνσηΧρέωσης.Location = New System.Drawing.Point(24, 232)
        Me.lblΔιεύθυνσηΧρέωσης.Name = "lblΔιεύθυνσηΧρέωσης"
        Me.lblΔιεύθυνσηΧρέωσης.Size = New System.Drawing.Size(104, 23)
        Me.lblΔιεύθυνσηΧρέωσης.TabIndex = 5
        Me.lblΔιεύθυνσηΧρέωσης.Text = "ΔιεύθυνσηΧρέωσης"
        Me.lblΔιεύθυνσηΧρέωσης.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΕπωνυμίαΕταιρείας
        '
        Me.lblΕπωνυμίαΕταιρείας.Location = New System.Drawing.Point(8, 104)
        Me.lblΕπωνυμίαΕταιρείας.Name = "lblΕπωνυμίαΕταιρείας"
        Me.lblΕπωνυμίαΕταιρείας.Size = New System.Drawing.Size(120, 23)
        Me.lblΕπωνυμίαΕταιρείας.TabIndex = 6
        Me.lblΕπωνυμίαΕταιρείας.Text = "Επωνυμία Εταιρείας *"
        Me.lblΕπωνυμίαΕταιρείας.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΕπώνυμοΕπαφής
        '
        Me.lblΕπώνυμοΕπαφής.Location = New System.Drawing.Point(24, 136)
        Me.lblΕπώνυμοΕπαφής.Name = "lblΕπώνυμοΕπαφής"
        Me.lblΕπώνυμοΕπαφής.Size = New System.Drawing.Size(104, 23)
        Me.lblΕπώνυμοΕπαφής.TabIndex = 7
        Me.lblΕπώνυμοΕπαφής.Text = "ΕπώνυμοΕπαφής *"
        Me.lblΕπώνυμοΕπαφής.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΚωδΑγοραστή
        '
        Me.lblΚωδΑγοραστή.Location = New System.Drawing.Point(24, 72)
        Me.lblΚωδΑγοραστή.Name = "lblΚωδΑγοραστή"
        Me.lblΚωδΑγοραστή.Size = New System.Drawing.Size(104, 23)
        Me.lblΚωδΑγοραστή.TabIndex = 8
        Me.lblΚωδΑγοραστή.Text = "ΚωδΑγοραστή"
        Me.lblΚωδΑγοραστή.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΝομός_Περιοχή
        '
        Me.lblΝομός_Περιοχή.Location = New System.Drawing.Point(336, 200)
        Me.lblΝομός_Περιοχή.Name = "lblΝομός_Περιοχή"
        Me.lblΝομός_Περιοχή.Size = New System.Drawing.Size(120, 23)
        Me.lblΝομός_Περιοχή.TabIndex = 9
        Me.lblΝομός_Περιοχή.Text = "Νομός/Περιοχή"
        Me.lblΝομός_Περιοχή.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'editΑριθμόςΦαξ
        '
        Me.editΑριθμόςΦαξ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΔΟΥ"))
        Me.editΑριθμόςΦαξ.Location = New System.Drawing.Point(464, 136)
        Me.editΑριθμόςΦαξ.Name = "editΑριθμόςΦαξ"
        Me.editΑριθμόςΦαξ.Size = New System.Drawing.Size(192, 20)
        Me.editΑριθμόςΦαξ.TabIndex = 11
        Me.editΑριθμόςΦαξ.Text = ""
        '
        'objdtsCustomermod
        '
        Me.objdtsCustomermod.DataSetName = "dtsCustomermod"
        Me.objdtsCustomermod.Locale = New System.Globalization.CultureInfo("el-GR")
        '
        'editΔιεύθυνσηEmail
        '
        Me.editΔιεύθυνσηEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΔιεύθυνσηEmail"))
        Me.editΔιεύθυνσηEmail.Location = New System.Drawing.Point(464, 296)
        Me.editΔιεύθυνσηEmail.Name = "editΔιεύθυνσηEmail"
        Me.editΔιεύθυνσηEmail.Size = New System.Drawing.Size(192, 20)
        Me.editΔιεύθυνσηEmail.TabIndex = 16
        Me.editΔιεύθυνσηEmail.Text = ""
        '
        'editΔιεύθυνσηΧρέωσης
        '
        Me.editΔιεύθυνσηΧρέωσης.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΔιεύθυνσηΧρέωσης"))
        Me.editΔιεύθυνσηΧρέωσης.Location = New System.Drawing.Point(136, 232)
        Me.editΔιεύθυνσηΧρέωσης.Name = "editΔιεύθυνσηΧρέωσης"
        Me.editΔιεύθυνσηΧρέωσης.Size = New System.Drawing.Size(176, 20)
        Me.editΔιεύθυνσηΧρέωσης.TabIndex = 5
        Me.editΔιεύθυνσηΧρέωσης.Text = ""
        '
        'editΕπωνυμίαΕταιρείας
        '
        Me.editΕπωνυμίαΕταιρείας.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΕπωνυμίαΕταιρείας"))
        Me.editΕπωνυμίαΕταιρείας.Location = New System.Drawing.Point(136, 104)
        Me.editΕπωνυμίαΕταιρείας.Name = "editΕπωνυμίαΕταιρείας"
        Me.editΕπωνυμίαΕταιρείας.Size = New System.Drawing.Size(176, 20)
        Me.editΕπωνυμίαΕταιρείας.TabIndex = 1
        Me.editΕπωνυμίαΕταιρείας.Text = ""
        '
        'editΕπώνυμοΕπαφής
        '
        Me.editΕπώνυμοΕπαφής.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΕπώνυμοΕπαφής"))
        Me.editΕπώνυμοΕπαφής.Location = New System.Drawing.Point(136, 136)
        Me.editΕπώνυμοΕπαφής.Name = "editΕπώνυμοΕπαφής"
        Me.editΕπώνυμοΕπαφής.Size = New System.Drawing.Size(176, 20)
        Me.editΕπώνυμοΕπαφής.TabIndex = 2
        Me.editΕπώνυμοΕπαφής.Text = ""
        '
        'editΚωδΑγοραστή
        '
        Me.editΚωδΑγοραστή.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΚωδΑγοραστή"))
        Me.editΚωδΑγοραστή.Location = New System.Drawing.Point(136, 72)
        Me.editΚωδΑγοραστή.Name = "editΚωδΑγοραστή"
        Me.editΚωδΑγοραστή.Size = New System.Drawing.Size(176, 20)
        Me.editΚωδΑγοραστή.TabIndex = 0
        Me.editΚωδΑγοραστή.Text = ""
        '
        'editΝομός_Περιοχή
        '
        Me.editΝομός_Περιοχή.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Νομός/Περιοχή"))
        Me.editΝομός_Περιοχή.Location = New System.Drawing.Point(464, 200)
        Me.editΝομός_Περιοχή.Name = "editΝομός_Περιοχή"
        Me.editΝομός_Περιοχή.Size = New System.Drawing.Size(192, 20)
        Me.editΝομός_Περιοχή.TabIndex = 13
        Me.editΝομός_Περιοχή.Text = ""
        '
        'lblΌνομαΕπαφής
        '
        Me.lblΌνομαΕπαφής.Location = New System.Drawing.Point(24, 168)
        Me.lblΌνομαΕπαφής.Name = "lblΌνομαΕπαφής"
        Me.lblΌνομαΕπαφής.Size = New System.Drawing.Size(104, 23)
        Me.lblΌνομαΕπαφής.TabIndex = 17
        Me.lblΌνομαΕπαφής.Text = "ΌνομαΕπαφής"
        Me.lblΌνομαΕπαφής.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΠόλη
        '
        Me.lblΠόλη.Location = New System.Drawing.Point(336, 168)
        Me.lblΠόλη.Name = "lblΠόλη"
        Me.lblΠόλη.Size = New System.Drawing.Size(120, 23)
        Me.lblΠόλη.TabIndex = 18
        Me.lblΠόλη.Text = "Πόλη *"
        Me.lblΠόλη.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΤαχυδρομικόςΚώδικας
        '
        Me.lblΤαχυδρομικόςΚώδικας.Location = New System.Drawing.Point(336, 264)
        Me.lblΤαχυδρομικόςΚώδικας.Name = "lblΤαχυδρομικόςΚώδικας"
        Me.lblΤαχυδρομικόςΚώδικας.Size = New System.Drawing.Size(120, 23)
        Me.lblΤαχυδρομικόςΚώδικας.TabIndex = 20
        Me.lblΤαχυδρομικόςΚώδικας.Text = "ΤαχυδρομικόςΚώδικας"
        Me.lblΤαχυδρομικόςΚώδικας.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΤηλέφωνο
        '
        Me.lblΤηλέφωνο.Location = New System.Drawing.Point(24, 264)
        Me.lblΤηλέφωνο.Name = "lblΤηλέφωνο"
        Me.lblΤηλέφωνο.Size = New System.Drawing.Size(104, 23)
        Me.lblΤηλέφωνο.TabIndex = 21
        Me.lblΤηλέφωνο.Text = "Τηλέφωνο 1"
        Me.lblΤηλέφωνο.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΤηλέφωνο1
        '
        Me.lblΤηλέφωνο1.Location = New System.Drawing.Point(24, 296)
        Me.lblΤηλέφωνο1.Name = "lblΤηλέφωνο1"
        Me.lblΤηλέφωνο1.Size = New System.Drawing.Size(104, 23)
        Me.lblΤηλέφωνο1.TabIndex = 22
        Me.lblΤηλέφωνο1.Text = "Τηλέφωνο 2"
        Me.lblΤηλέφωνο1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblΧώρα_Περιοχή
        '
        Me.lblΧώρα_Περιοχή.Location = New System.Drawing.Point(336, 232)
        Me.lblΧώρα_Περιοχή.Name = "lblΧώρα_Περιοχή"
        Me.lblΧώρα_Περιοχή.Size = New System.Drawing.Size(120, 23)
        Me.lblΧώρα_Περιοχή.TabIndex = 23
        Me.lblΧώρα_Περιοχή.Text = "Χώρα/Περιοχή"
        Me.lblΧώρα_Περιοχή.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'editΌνομαΕπαφής
        '
        Me.editΌνομαΕπαφής.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΌνομαΕπαφής"))
        Me.editΌνομαΕπαφής.Location = New System.Drawing.Point(136, 168)
        Me.editΌνομαΕπαφής.Name = "editΌνομαΕπαφής"
        Me.editΌνομαΕπαφής.Size = New System.Drawing.Size(176, 20)
        Me.editΌνομαΕπαφής.TabIndex = 3
        Me.editΌνομαΕπαφής.Text = ""
        '
        'editΠόλη
        '
        Me.editΠόλη.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Πόλη"))
        Me.editΠόλη.Location = New System.Drawing.Point(464, 168)
        Me.editΠόλη.Name = "editΠόλη"
        Me.editΠόλη.Size = New System.Drawing.Size(192, 20)
        Me.editΠόλη.TabIndex = 12
        Me.editΠόλη.Text = ""
        '
        'editΣημειώσεις
        '
        Me.editΣημειώσεις.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Σημειώσεις"))
        Me.editΣημειώσεις.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editΣημειώσεις.Location = New System.Drawing.Point(16, 16)
        Me.editΣημειώσεις.Multiline = True
        Me.editΣημειώσεις.Name = "editΣημειώσεις"
        Me.editΣημειώσεις.Size = New System.Drawing.Size(608, 312)
        Me.editΣημειώσεις.TabIndex = 20
        Me.editΣημειώσεις.Text = ""
        '
        'editΤαχυδρομικόςΚώδικας
        '
        Me.editΤαχυδρομικόςΚώδικας.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΤαχυδρομικόςΚώδικας"))
        Me.editΤαχυδρομικόςΚώδικας.Location = New System.Drawing.Point(464, 264)
        Me.editΤαχυδρομικόςΚώδικας.Name = "editΤαχυδρομικόςΚώδικας"
        Me.editΤαχυδρομικόςΚώδικας.Size = New System.Drawing.Size(192, 20)
        Me.editΤαχυδρομικόςΚώδικας.TabIndex = 15
        Me.editΤαχυδρομικόςΚώδικας.Text = ""
        '
        'editΤηλέφωνο
        '
        Me.editΤηλέφωνο.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Τηλέφωνο"))
        Me.editΤηλέφωνο.Location = New System.Drawing.Point(136, 264)
        Me.editΤηλέφωνο.Name = "editΤηλέφωνο"
        Me.editΤηλέφωνο.Size = New System.Drawing.Size(176, 20)
        Me.editΤηλέφωνο.TabIndex = 6
        Me.editΤηλέφωνο.Text = ""
        '
        'editΤηλέφωνο1
        '
        Me.editΤηλέφωνο1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Τηλέφωνο1"))
        Me.editΤηλέφωνο1.Location = New System.Drawing.Point(136, 296)
        Me.editΤηλέφωνο1.Name = "editΤηλέφωνο1"
        Me.editΤηλέφωνο1.Size = New System.Drawing.Size(176, 20)
        Me.editΤηλέφωνο1.TabIndex = 7
        Me.editΤηλέφωνο1.Text = ""
        '
        'editΧώρα_Περιοχή
        '
        Me.editΧώρα_Περιοχή.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Χώρα/Περιοχή"))
        Me.editΧώρα_Περιοχή.Location = New System.Drawing.Point(464, 232)
        Me.editΧώρα_Περιοχή.Name = "editΧώρα_Περιοχή"
        Me.editΧώρα_Περιοχή.Size = New System.Drawing.Size(192, 20)
        Me.editΧώρα_Περιοχή.TabIndex = 14
        Me.editΧώρα_Περιοχή.Text = ""
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
        Me.btnAdd.Text = "Εισαγωγή"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 416)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Διαγραφή"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(368, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Ακύρωση"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Σημειώσεις"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.editΣημειώσεις)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 368)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Σημειώσεις"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Επιστροφή"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Κινητό"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.kinhto"))
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
        Me.Label2.Text = "ΑριθμόςΦαξ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΑριθμόςΦαξ"))
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
        Me.Label3.Text = "ΑΦΜ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.ΑΦΜ"))
        Me.TextBox3.Location = New System.Drawing.Point(464, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.Επάγγελμα"))
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
        Me.Label4.Text = "Επάγγελμα"
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
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdtsCustomermod, "Πελατολόγιο.website"))
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
        Me.MenuItem1.Text = "Διαχείριση Πελατών"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Κλείσιμο"
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
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Πελατολόγιο WHERE (ΚωδΑγοραστή = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ΚωδΑγοραστή", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ΚωδΑγοραστή", System.Data.DataRowVersion.Original, Nothing))
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
        "/Περιοχή] = ? WHERE (ΚωδΑγοραστή = ?)"
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
        '
        'frmCustomermod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(682, 448)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblΑριθμόςΦαξ)
        Me.Controls.Add(Me.lblΔιεύθυνσηEmail)
        Me.Controls.Add(Me.lblΔιεύθυνσηΧρέωσης)
        Me.Controls.Add(Me.lblΕπωνυμίαΕταιρείας)
        Me.Controls.Add(Me.lblΕπώνυμοΕπαφής)
        Me.Controls.Add(Me.lblΚωδΑγοραστή)
        Me.Controls.Add(Me.lblΝομός_Περιοχή)
        Me.Controls.Add(Me.editΑριθμόςΦαξ)
        Me.Controls.Add(Me.editΔιεύθυνσηEmail)
        Me.Controls.Add(Me.editΔιεύθυνσηΧρέωσης)
        Me.Controls.Add(Me.editΕπωνυμίαΕταιρείας)
        Me.Controls.Add(Me.editΕπώνυμοΕπαφής)
        Me.Controls.Add(Me.editΚωδΑγοραστή)
        Me.Controls.Add(Me.editΝομός_Περιοχή)
        Me.Controls.Add(Me.lblΌνομαΕπαφής)
        Me.Controls.Add(Me.lblΠόλη)
        Me.Controls.Add(Me.lblΤαχυδρομικόςΚώδικας)
        Me.Controls.Add(Me.lblΤηλέφωνο)
        Me.Controls.Add(Me.lblΤηλέφωνο1)
        Me.Controls.Add(Me.lblΧώρα_Περιοχή)
        Me.Controls.Add(Me.editΌνομαΕπαφής)
        Me.Controls.Add(Me.editΠόλη)
        Me.Controls.Add(Me.editΤαχυδρομικόςΚώδικας)
        Me.Controls.Add(Me.editΤηλέφωνο)
        Me.Controls.Add(Me.editΤηλέφωνο1)
        Me.Controls.Add(Me.editΧώρα_Περιοχή)
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
        Me.Text = "Πελάτες"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.objdtsCustomermod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").CancelCurrentEdit()
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Count > 0) Then
            Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").RemoveAt(Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position)
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
            Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").EndCurrentEdit()
            Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdtsCustomermod_PositionChanged()
        editΚωδΑγοραστή.Focus()
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
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position = 0
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position = (Me.objdtsCustomermod.Tables("Πελατολόγιο").Rows.Count - 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position = (Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position - 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position = (Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position + 1)
        Me.objdtsCustomermod_PositionChanged()

    End Sub
    Private Sub objdtsCustomermod_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdtsCustomermod.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As prjctDoReMi.dtsCustomermod = New prjctDoReMi.dtsCustomermod
        'Stop any current edits.
        Me.BindingContext(objdtsCustomermod, "Πελατολόγιο").EndCurrentEdit()
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
            Dim varsql As New OleDb.OleDbCommand("select * from Πελατολόγιο where ΚωδΑγοραστή like '" & Module1.varCustomertemp & "%';", OleDbConnection1)
            OleDbDataAdapter1.SelectCommand = varsql
        Else
            Dim varsql As New OleDb.OleDbCommand("select * from Πελατολόγιο ;", OleDbConnection1)
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

    Private Sub editΝομός_Περιοχή_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editΝομός_Περιοχή.TextChanged

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
