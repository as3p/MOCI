<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupPanelBox11 = New DesainMoci.Komponen.GroupPanelBox1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New DesainMoci.Komponen.Label1()
        Me.Label11 = New DesainMoci.Komponen.Label1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Textbox16 = New DesainMoci.Komponen.Textbox1()
        Me.Textbox15 = New DesainMoci.Komponen.Textbox1()
        Me.Textbox14 = New DesainMoci.Komponen.Textbox1()
        Me.Label18 = New DesainMoci.Komponen.Label1()
        Me.Label17 = New DesainMoci.Komponen.Label1()
        Me.Label16 = New DesainMoci.Komponen.Label1()
        Me.Button12 = New DesainMoci.Komponen.Button1()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Textbox13 = New DesainMoci.Komponen.Textbox1()
        Me.Textbox12 = New DesainMoci.Komponen.Textbox1()
        Me.Textbox11 = New DesainMoci.Komponen.Textbox1()
        Me.Button11 = New DesainMoci.Komponen.Button1()
        Me.Label15 = New DesainMoci.Komponen.Label1()
        Me.Label14 = New DesainMoci.Komponen.Label1()
        Me.Label13 = New DesainMoci.Komponen.Label1()
        Me.GroupPanelBox11.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanelBox11
        '
        Me.GroupPanelBox11.Controls.Add(Me.Label1)
        Me.GroupPanelBox11.Controls.Add(Me.Label12)
        Me.GroupPanelBox11.Controls.Add(Me.Label11)
        Me.GroupPanelBox11.Controls.Add(Me.GroupBox2)
        Me.GroupPanelBox11.Controls.Add(Me.GroupBox1)
        Me.GroupPanelBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelBox11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupPanelBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupPanelBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelBox11.Name = "GroupPanelBox11"
        Me.GroupPanelBox11.NoRounding = False
        Me.GroupPanelBox11.Size = New System.Drawing.Size(593, 331)
        Me.GroupPanelBox11.TabIndex = 0
        Me.GroupPanelBox11.Text = "Kalkulator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(568, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(323, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Simulasi Jual"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(23, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Simulasi Beli"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Textbox16)
        Me.GroupBox2.Controls.Add(Me.Textbox15)
        Me.GroupBox2.Controls.Add(Me.Textbox14)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Location = New System.Drawing.Point(322, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Textbox16
        '
        Me.Textbox16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox16.Location = New System.Drawing.Point(117, 107)
        Me.Textbox16.MaxLength = 32767
        Me.Textbox16.Name = "Textbox16"
        Me.Textbox16.ReadOnly = False
        Me.Textbox16.SideImage = Nothing
        Me.Textbox16.Size = New System.Drawing.Size(110, 30)
        Me.Textbox16.TabIndex = 6
        Me.Textbox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox16.UseSystemPasswordChar = False
        Me.Textbox16.WatermarkText = ""
        '
        'Textbox15
        '
        Me.Textbox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox15.Location = New System.Drawing.Point(117, 70)
        Me.Textbox15.MaxLength = 32767
        Me.Textbox15.Name = "Textbox15"
        Me.Textbox15.ReadOnly = False
        Me.Textbox15.SideImage = Nothing
        Me.Textbox15.Size = New System.Drawing.Size(110, 30)
        Me.Textbox15.TabIndex = 5
        Me.Textbox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox15.UseSystemPasswordChar = False
        Me.Textbox15.WatermarkText = ""
        '
        'Textbox14
        '
        Me.Textbox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox14.Location = New System.Drawing.Point(117, 31)
        Me.Textbox14.MaxLength = 32767
        Me.Textbox14.Name = "Textbox14"
        Me.Textbox14.ReadOnly = False
        Me.Textbox14.SideImage = Nothing
        Me.Textbox14.Size = New System.Drawing.Size(110, 30)
        Me.Textbox14.TabIndex = 4
        Me.Textbox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox14.UseSystemPasswordChar = False
        Me.Textbox14.WatermarkText = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(17, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 19)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Total Rupiah  :"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(17, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 19)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Limit Price     :"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(17, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Total Pair      :"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button12.Location = New System.Drawing.Point(117, 154)
        Me.Button12.Name = "Button12"
        Me.Button12.RoundRadius = 30
        Me.Button12.SideImage = Nothing
        Me.Button12.SideImageAlign = DesainMoci.Komponen.Button1.SideAligin.Left
        Me.Button12.Size = New System.Drawing.Size(110, 30)
        Me.Button12.TabIndex = 0
        Me.Button12.Text = "Hitung"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textbox13)
        Me.GroupBox1.Controls.Add(Me.Textbox12)
        Me.GroupBox1.Controls.Add(Me.Textbox11)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Textbox13
        '
        Me.Textbox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox13.Location = New System.Drawing.Point(111, 107)
        Me.Textbox13.MaxLength = 32767
        Me.Textbox13.Name = "Textbox13"
        Me.Textbox13.ReadOnly = False
        Me.Textbox13.SideImage = Nothing
        Me.Textbox13.Size = New System.Drawing.Size(110, 30)
        Me.Textbox13.TabIndex = 6
        Me.Textbox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox13.UseSystemPasswordChar = False
        Me.Textbox13.WatermarkText = ""
        '
        'Textbox12
        '
        Me.Textbox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox12.Location = New System.Drawing.Point(111, 70)
        Me.Textbox12.MaxLength = 32767
        Me.Textbox12.Name = "Textbox12"
        Me.Textbox12.ReadOnly = False
        Me.Textbox12.SideImage = Nothing
        Me.Textbox12.Size = New System.Drawing.Size(110, 30)
        Me.Textbox12.TabIndex = 5
        Me.Textbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox12.UseSystemPasswordChar = False
        Me.Textbox12.WatermarkText = ""
        '
        'Textbox11
        '
        Me.Textbox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox11.Location = New System.Drawing.Point(111, 31)
        Me.Textbox11.MaxLength = 32767
        Me.Textbox11.Name = "Textbox11"
        Me.Textbox11.ReadOnly = False
        Me.Textbox11.SideImage = Nothing
        Me.Textbox11.Size = New System.Drawing.Size(110, 30)
        Me.Textbox11.TabIndex = 4
        Me.Textbox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox11.UseSystemPasswordChar = False
        Me.Textbox11.WatermarkText = ""
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button11.Location = New System.Drawing.Point(107, 154)
        Me.Button11.Name = "Button11"
        Me.Button11.RoundRadius = 30
        Me.Button11.SideImage = Nothing
        Me.Button11.SideImageAlign = DesainMoci.Komponen.Button1.SideAligin.Left
        Me.Button11.Size = New System.Drawing.Size(110, 30)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "Hitung"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(14, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 19)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Total Pair      :"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Limit Price     :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total Rupiah  :"
        '
        'Kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 331)
        Me.Controls.Add(Me.GroupPanelBox11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kalkulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kalkulator"
        Me.GroupPanelBox11.ResumeLayout(False)
        Me.GroupPanelBox11.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelBox11 As DesainMoci.Komponen.GroupPanelBox1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As DesainMoci.Komponen.Label1
    Friend WithEvents Label11 As DesainMoci.Komponen.Label1
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Textbox16 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Textbox15 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Textbox14 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Label18 As DesainMoci.Komponen.Label1
    Friend WithEvents Label17 As DesainMoci.Komponen.Label1
    Friend WithEvents Label16 As DesainMoci.Komponen.Label1
    Friend WithEvents Button12 As DesainMoci.Komponen.Button1
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Textbox13 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Textbox12 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Textbox11 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Button11 As DesainMoci.Komponen.Button1
    Friend WithEvents Label15 As DesainMoci.Komponen.Label1
    Friend WithEvents Label14 As DesainMoci.Komponen.Label1
    Friend WithEvents Label13 As DesainMoci.Komponen.Label1
End Class
