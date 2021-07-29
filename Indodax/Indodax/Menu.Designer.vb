<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListMonitoring = New System.Windows.Forms.ListView()
        Me.CheckBoxMonitoring = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelInterval = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelUrutan = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListMarketplace = New System.Windows.Forms.ListView()
        Me.ListAktifitasMarket = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListMarketJual = New System.Windows.Forms.ListView()
        Me.ListMarketBeli = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelServerTime = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtLimitSell = New System.Windows.Forms.TextBox()
        Me.TxtAmountSell = New System.Windows.Forms.TextBox()
        Me.TxtLimitBuy = New System.Windows.Forms.TextBox()
        Me.TxtAmountBuy = New System.Windows.Forms.TextBox()
        Me.Lblhistorytrade = New System.Windows.Forms.Label()
        Me.LblOrderPending = New System.Windows.Forms.Label()
        Me.ListHistoryTrade = New System.Windows.Forms.ListView()
        Me.ListOpenSellBuy = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListAcount = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListMonitoring)
        Me.GroupBox2.Controls.Add(Me.CheckBoxMonitoring)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LabelInterval)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 469)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ListMonitoring
        '
        Me.ListMonitoring.Location = New System.Drawing.Point(6, 45)
        Me.ListMonitoring.Name = "ListMonitoring"
        Me.ListMonitoring.Size = New System.Drawing.Size(951, 415)
        Me.ListMonitoring.TabIndex = 0
        Me.ListMonitoring.UseCompatibleStateImageBehavior = False
        '
        'CheckBoxMonitoring
        '
        Me.CheckBoxMonitoring.AutoSize = True
        Me.CheckBoxMonitoring.Location = New System.Drawing.Point(6, 22)
        Me.CheckBoxMonitoring.Name = "CheckBoxMonitoring"
        Me.CheckBoxMonitoring.Size = New System.Drawing.Size(122, 17)
        Me.CheckBoxMonitoring.TabIndex = 2
        Me.CheckBoxMonitoring.Text = "Start Monitoring"
        Me.CheckBoxMonitoring.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Update Interval :"
        '
        'LabelInterval
        '
        Me.LabelInterval.AutoSize = True
        Me.LabelInterval.Location = New System.Drawing.Point(345, 24)
        Me.LabelInterval.Name = "LabelInterval"
        Me.LabelInterval.Size = New System.Drawing.Size(13, 13)
        Me.LabelInterval.TabIndex = 3
        Me.LabelInterval.Text = "-"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Indodax.My.Resources.Resources.excel16
        Me.Button2.Location = New System.Drawing.Point(934, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelUrutan
        '
        Me.LabelUrutan.AutoSize = True
        Me.LabelUrutan.Location = New System.Drawing.Point(368, 169)
        Me.LabelUrutan.Name = "LabelUrutan"
        Me.LabelUrutan.Size = New System.Drawing.Size(13, 13)
        Me.LabelUrutan.TabIndex = 12
        Me.LabelUrutan.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListMarketplace)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(569, 469)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'ListMarketplace
        '
        Me.ListMarketplace.Location = New System.Drawing.Point(6, 12)
        Me.ListMarketplace.Name = "ListMarketplace"
        Me.ListMarketplace.Size = New System.Drawing.Size(556, 446)
        Me.ListMarketplace.TabIndex = 0
        Me.ListMarketplace.UseCompatibleStateImageBehavior = False
        '
        'ListAktifitasMarket
        '
        Me.ListAktifitasMarket.Location = New System.Drawing.Point(6, 343)
        Me.ListAktifitasMarket.Name = "ListAktifitasMarket"
        Me.ListAktifitasMarket.Size = New System.Drawing.Size(375, 115)
        Me.ListAktifitasMarket.TabIndex = 11
        Me.ListAktifitasMarket.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(3, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Aktifitas Market"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(3, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Market Jual"
        '
        'ListMarketJual
        '
        Me.ListMarketJual.Location = New System.Drawing.Point(6, 30)
        Me.ListMarketJual.Name = "ListMarketJual"
        Me.ListMarketJual.Size = New System.Drawing.Size(375, 130)
        Me.ListMarketJual.TabIndex = 8
        Me.ListMarketJual.UseCompatibleStateImageBehavior = False
        '
        'ListMarketBeli
        '
        Me.ListMarketBeli.Location = New System.Drawing.Point(6, 185)
        Me.ListMarketBeli.Name = "ListMarketBeli"
        Me.ListMarketBeli.Size = New System.Drawing.Size(375, 130)
        Me.ListMarketBeli.TabIndex = 7
        Me.ListMarketBeli.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(3, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Market Beli"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'LabelServerTime
        '
        Me.LabelServerTime.AutoSize = True
        Me.LabelServerTime.Location = New System.Drawing.Point(15, 520)
        Me.LabelServerTime.Name = "LabelServerTime"
        Me.LabelServerTime.Size = New System.Drawing.Size(97, 13)
        Me.LabelServerTime.TabIndex = 3
        Me.LabelServerTime.Text = "Server Time : -"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(979, 504)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "    Monitoring    "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(971, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "    MarketPlace    "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelUrutan)
        Me.GroupBox1.Controls.Add(Me.ListAktifitasMarket)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ListMarketJual)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListMarketBeli)
        Me.GroupBox1.Location = New System.Drawing.Point(578, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 469)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(971, 478)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "      Wallet      "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Lblhistorytrade)
        Me.GroupBox4.Controls.Add(Me.LblOrderPending)
        Me.GroupBox4.Controls.Add(Me.ListHistoryTrade)
        Me.GroupBox4.Controls.Add(Me.ListOpenSellBuy)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.ListAcount)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(963, 469)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'TxtLimitSell
        '
        Me.TxtLimitSell.Location = New System.Drawing.Point(121, 45)
        Me.TxtLimitSell.Name = "TxtLimitSell"
        Me.TxtLimitSell.Size = New System.Drawing.Size(108, 20)
        Me.TxtLimitSell.TabIndex = 9
        '
        'TxtAmountSell
        '
        Me.TxtAmountSell.Location = New System.Drawing.Point(121, 19)
        Me.TxtAmountSell.Name = "TxtAmountSell"
        Me.TxtAmountSell.Size = New System.Drawing.Size(108, 20)
        Me.TxtAmountSell.TabIndex = 8
        '
        'TxtLimitBuy
        '
        Me.TxtLimitBuy.Location = New System.Drawing.Point(135, 45)
        Me.TxtLimitBuy.Name = "TxtLimitBuy"
        Me.TxtLimitBuy.Size = New System.Drawing.Size(108, 20)
        Me.TxtLimitBuy.TabIndex = 7
        '
        'TxtAmountBuy
        '
        Me.TxtAmountBuy.Location = New System.Drawing.Point(135, 19)
        Me.TxtAmountBuy.Name = "TxtAmountBuy"
        Me.TxtAmountBuy.Size = New System.Drawing.Size(108, 20)
        Me.TxtAmountBuy.TabIndex = 6
        '
        'Lblhistorytrade
        '
        Me.Lblhistorytrade.AutoSize = True
        Me.Lblhistorytrade.Location = New System.Drawing.Point(424, 181)
        Me.Lblhistorytrade.Name = "Lblhistorytrade"
        Me.Lblhistorytrade.Size = New System.Drawing.Size(109, 13)
        Me.Lblhistorytrade.TabIndex = 5
        Me.Lblhistorytrade.Text = "Riwayat Transaksi"
        '
        'LblOrderPending
        '
        Me.LblOrderPending.AutoSize = True
        Me.LblOrderPending.Location = New System.Drawing.Point(424, 16)
        Me.LblOrderPending.Name = "LblOrderPending"
        Me.LblOrderPending.Size = New System.Drawing.Size(85, 13)
        Me.LblOrderPending.TabIndex = 4
        Me.LblOrderPending.Text = "Order Pending"
        '
        'ListHistoryTrade
        '
        Me.ListHistoryTrade.Location = New System.Drawing.Point(427, 197)
        Me.ListHistoryTrade.Name = "ListHistoryTrade"
        Me.ListHistoryTrade.Size = New System.Drawing.Size(532, 130)
        Me.ListHistoryTrade.TabIndex = 3
        Me.ListHistoryTrade.UseCompatibleStateImageBehavior = False
        '
        'ListOpenSellBuy
        '
        Me.ListOpenSellBuy.Location = New System.Drawing.Point(427, 30)
        Me.ListOpenSellBuy.Name = "ListOpenSellBuy"
        Me.ListOpenSellBuy.Size = New System.Drawing.Size(531, 130)
        Me.ListOpenSellBuy.TabIndex = 2
        Me.ListOpenSellBuy.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(421, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reload Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListAcount
        '
        Me.ListAcount.Location = New System.Drawing.Point(3, 12)
        Me.ListAcount.Name = "ListAcount"
        Me.ListAcount.Size = New System.Drawing.Size(421, 422)
        Me.ListAcount.TabIndex = 0
        Me.ListAcount.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(835, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Save"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(872, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "semua riwayat"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TxtAmountBuy)
        Me.GroupBox5.Controls.Add(Me.TxtLimitBuy)
        Me.GroupBox5.Location = New System.Drawing.Point(427, 355)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 108)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Button5)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.TxtAmountSell)
        Me.GroupBox6.Controls.Add(Me.TxtLimitSell)
        Me.GroupBox6.Location = New System.Drawing.Point(697, 355)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(260, 108)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Rupiah  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Limit Price     :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Pair     :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Limit Price   :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Limit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Instan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(121, 71)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(51, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Limit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(178, 71)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Instan"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 542)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LabelServerTime)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 580)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Coin Indodax "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListMonitoring As System.Windows.Forms.ListView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents LabelServerTime As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMonitoring As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelInterval As System.Windows.Forms.Label
    Friend WithEvents ListMarketplace As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListMarketJual As System.Windows.Forms.ListView
    Friend WithEvents ListMarketBeli As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListAktifitasMarket As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelUrutan As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListAcount As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListHistoryTrade As System.Windows.Forms.ListView
    Friend WithEvents ListOpenSellBuy As System.Windows.Forms.ListView
    Friend WithEvents TxtLimitSell As System.Windows.Forms.TextBox
    Friend WithEvents TxtAmountSell As System.Windows.Forms.TextBox
    Friend WithEvents TxtLimitBuy As System.Windows.Forms.TextBox
    Friend WithEvents TxtAmountBuy As System.Windows.Forms.TextBox
    Friend WithEvents Lblhistorytrade As System.Windows.Forms.Label
    Friend WithEvents LblOrderPending As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
