<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secret
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
        Me.Textbox12 = New DesainMoci.Komponen.Textbox1()
        Me.Textbox11 = New DesainMoci.Komponen.Textbox1()
        Me.Button11 = New DesainMoci.Komponen.Button1()
        Me.Label13 = New DesainMoci.Komponen.Label1()
        Me.Label12 = New DesainMoci.Komponen.Label1()
        Me.Label11 = New DesainMoci.Komponen.Label1()
        Me.GroupPanelBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanelBox11
        '
        Me.GroupPanelBox11.Controls.Add(Me.Label1)
        Me.GroupPanelBox11.Controls.Add(Me.Textbox12)
        Me.GroupPanelBox11.Controls.Add(Me.Textbox11)
        Me.GroupPanelBox11.Controls.Add(Me.Button11)
        Me.GroupPanelBox11.Controls.Add(Me.Label13)
        Me.GroupPanelBox11.Controls.Add(Me.Label12)
        Me.GroupPanelBox11.Controls.Add(Me.Label11)
        Me.GroupPanelBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelBox11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupPanelBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.GroupPanelBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelBox11.Name = "GroupPanelBox11"
        Me.GroupPanelBox11.NoRounding = False
        Me.GroupPanelBox11.Size = New System.Drawing.Size(722, 199)
        Me.GroupPanelBox11.TabIndex = 0
        Me.GroupPanelBox11.Text = "Masukan  API Key Anda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(697, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X"
        '
        'Textbox12
        '
        Me.Textbox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox12.Location = New System.Drawing.Point(123, 89)
        Me.Textbox12.MaxLength = 32767
        Me.Textbox12.Name = "Textbox12"
        Me.Textbox12.ReadOnly = False
        Me.Textbox12.SideImage = Nothing
        Me.Textbox12.Size = New System.Drawing.Size(572, 30)
        Me.Textbox12.TabIndex = 5
        Me.Textbox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox12.UseSystemPasswordChar = False
        Me.Textbox12.WatermarkText = ""
        '
        'Textbox11
        '
        Me.Textbox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Textbox11.Location = New System.Drawing.Point(123, 49)
        Me.Textbox11.MaxLength = 32767
        Me.Textbox11.Name = "Textbox11"
        Me.Textbox11.ReadOnly = False
        Me.Textbox11.SideImage = Nothing
        Me.Textbox11.Size = New System.Drawing.Size(380, 30)
        Me.Textbox11.TabIndex = 4
        Me.Textbox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Textbox11.UseSystemPasswordChar = False
        Me.Textbox11.WatermarkText = ""
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Button11.Location = New System.Drawing.Point(123, 136)
        Me.Button11.Name = "Button11"
        Me.Button11.RoundRadius = 30
        Me.Button11.SideImage = Nothing
        Me.Button11.SideImageAlign = DesainMoci.Komponen.Button1.SideAligin.Left
        Me.Button11.Size = New System.Drawing.Size(88, 30)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "Masuk"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(227, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Dapatkan API Key dan Secret Key"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(30, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Secret Key"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(30, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "API Key "
        '
        'Secret
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(722, 199)
        Me.Controls.Add(Me.GroupPanelBox11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Secret"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secret"
        Me.GroupPanelBox11.ResumeLayout(False)
        Me.GroupPanelBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelBox11 As DesainMoci.Komponen.GroupPanelBox1
    Friend WithEvents Textbox12 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Textbox11 As DesainMoci.Komponen.Textbox1
    Friend WithEvents Button11 As DesainMoci.Komponen.Button1
    Friend WithEvents Label13 As DesainMoci.Komponen.Label1
    Friend WithEvents Label12 As DesainMoci.Komponen.Label1
    Friend WithEvents Label11 As DesainMoci.Komponen.Label1
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
