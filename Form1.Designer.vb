<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSetRuntime = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCurrentSetting = New System.Windows.Forms.Label()
        Me.lbl64bitWaring = New System.Windows.Forms.Label()
        Me.lblfixed1 = New System.Windows.Forms.Label()
        Me.lblRunTimeName = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_help = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetRuntime
        '
        Me.btnSetRuntime.Location = New System.Drawing.Point(423, 21)
        Me.btnSetRuntime.Name = "btnSetRuntime"
        Me.btnSetRuntime.Size = New System.Drawing.Size(154, 35)
        Me.btnSetRuntime.TabIndex = 0
        Me.btnSetRuntime.Text = "Set OpenXR Runtime"
        Me.btnSetRuntime.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(379, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'lblCurrentSetting
        '
        Me.lblCurrentSetting.AutoSize = True
        Me.lblCurrentSetting.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSetting.Location = New System.Drawing.Point(23, 124)
        Me.lblCurrentSetting.Name = "lblCurrentSetting"
        Me.lblCurrentSetting.Size = New System.Drawing.Size(42, 15)
        Me.lblCurrentSetting.TabIndex = 2
        Me.lblCurrentSetting.Text = "Label1"
        '
        'lbl64bitWaring
        '
        Me.lbl64bitWaring.AutoSize = True
        Me.lbl64bitWaring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl64bitWaring.ForeColor = System.Drawing.Color.Red
        Me.lbl64bitWaring.Location = New System.Drawing.Point(22, 9)
        Me.lbl64bitWaring.Name = "lbl64bitWaring"
        Me.lbl64bitWaring.Size = New System.Drawing.Size(306, 13)
        Me.lbl64bitWaring.TabIndex = 3
        Me.lbl64bitWaring.Text = "Running in 32Bit Mode - Settings could be unreliable"
        Me.lbl64bitWaring.Visible = False
        '
        'lblfixed1
        '
        Me.lblfixed1.AutoSize = True
        Me.lblfixed1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfixed1.Location = New System.Drawing.Point(22, 97)
        Me.lblfixed1.Name = "lblfixed1"
        Me.lblfixed1.Size = New System.Drawing.Size(279, 18)
        Me.lblfixed1.TabIndex = 4
        Me.lblfixed1.Text = "Currently Detected Runtime Location"
        '
        'lblRunTimeName
        '
        Me.lblRunTimeName.AutoSize = True
        Me.lblRunTimeName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunTimeName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblRunTimeName.Location = New System.Drawing.Point(347, 148)
        Me.lblRunTimeName.Name = "lblRunTimeName"
        Me.lblRunTimeName.Size = New System.Drawing.Size(85, 18)
        Me.lblRunTimeName.TabIndex = 5
        Me.lblRunTimeName.Text = "Detected :"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.LinkLabel1.LinkVisited = True
        Me.LinkLabel1.Location = New System.Drawing.Point(23, 149)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "________MY LINK _______"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(380, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " Run As Admin to change Runtime"
        '
        'lbl_help
        '
        Me.lbl_help.AutoSize = True
        Me.lbl_help.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_help.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_help.Location = New System.Drawing.Point(399, 2)
        Me.lbl_help.Name = "lbl_help"
        Me.lbl_help.Size = New System.Drawing.Size(19, 21)
        Me.lbl_help.TabIndex = 8
        Me.lbl_help.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(585, 181)
        Me.Controls.Add(Me.lbl_help)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbl64bitWaring)
        Me.Controls.Add(Me.lblCurrentSetting)
        Me.Controls.Add(Me.lblfixed1)
        Me.Controls.Add(Me.lblRunTimeName)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSetRuntime)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OPenXR Runtime Switcher - Sam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetRuntime As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblCurrentSetting As Label
    Friend WithEvents lbl64bitWaring As Label
    Friend WithEvents lblfixed1 As Label
    Friend WithEvents lblRunTimeName As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_help As Label
End Class
