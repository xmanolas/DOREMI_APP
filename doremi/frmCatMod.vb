Public Class frmCatMod
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "��������� 1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "��������� 2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "��������� 3"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(96, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "������"
        '
        'frmCatMod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 325)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCatMod"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Module1.apomod = True
        Dim c1 As New frmSmallInstr
        c1.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Module1.apomod = True
        Dim c2 As New frmSmallSubInstr
        c2.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Module1.apomod = True
        Dim c3 As New frmsmallsubinstr2
        c3.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub frmCatMod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
End Class
