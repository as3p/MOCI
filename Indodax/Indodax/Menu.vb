Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Security.Cryptography
Imports System.Web
Imports System.Net.Mail

Public Class Menu

   



    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LabelUrutan.ForeColor = Color.White

       



        '========[ Awal Mengatur Monitoring ]========

        'mengatur properti
        ListMonitoring.View = View.Details
        ListMonitoring.GridLines = True
        ListMonitoring.FullRowSelect = True

        'menambahkan header kolom
        ListMonitoring.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add("Time", 130, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(0), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(1), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(2), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(3), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(4), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(5), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(6), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(7), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(8), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(9), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(10), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(11), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(12), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(13), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(14), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(15), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(16), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(17), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(18), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(19), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(20), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(21), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(22), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(23), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(24), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(25), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(26), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(27), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(28), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(29), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(30), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(31), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(32), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(33), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(34), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(35), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(36), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(37), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(38), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(39), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(40), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(41), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(42), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(43), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(44), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(45), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(46), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(47), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(48), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(49), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(50), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(51), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(52), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(53), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(54), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(55), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(56), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(57), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(58), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(59), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(60), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(61), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(62), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(63), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(64), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(65), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(66), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(67), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(68), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(69), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(70), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(71), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(72), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(73), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(74), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(75), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(76), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(77), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(78), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(79), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(80), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(81), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(82), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(83), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(84), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(85), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(86), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(87), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(88), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(89), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(90), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(91), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(92), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(93), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(94), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(95), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(96), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(97), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(98), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(99), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(100), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(101), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(102), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(103), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(104), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(105), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(106), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(107), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(108), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(109), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(110), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(111), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(112), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(113), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(114), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(115), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(116), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(117), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(118), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(119), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(120), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(121), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(122), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(123), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(124), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(125), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(126), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(127), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(128), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(129), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(130), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(131), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(132), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(133), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(134), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(135), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(136), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(137), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(138), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(139), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(140), 90, HorizontalAlignment.Center)
        ListMonitoring.Columns.Add(a(141), 90, HorizontalAlignment.Center)



        '========[ Akhir Mengatur Monitoring ]========



        '========[ Awal Mengatur Market Place ]========

        'mengatur properti
        ListMarketplace.View = View.Details
        ListMarketplace.GridLines = True
        ListMarketplace.FullRowSelect = True

        'menambahkan header kolom
        ListMarketplace.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListMarketplace.Columns.Add(" Market", 55, HorizontalAlignment.Left)
        ListMarketplace.Columns.Add("Volume IDR   ", 105, HorizontalAlignment.Right)
        ListMarketplace.Columns.Add("OPEN    ", 85, HorizontalAlignment.Right)
        ListMarketplace.Columns.Add("HIGHT    ", 85, HorizontalAlignment.Right)
        ListMarketplace.Columns.Add("LOW    ", 85, HorizontalAlignment.Right)
        ListMarketplace.Columns.Add("CLOSE    ", 85, HorizontalAlignment.Right)


        'mengatur properti
        ListMarketBeli.View = View.Details
        ListMarketBeli.GridLines = True
        ListMarketBeli.FullRowSelect = True

        'menambahkan header kolom
        ListMarketBeli.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListMarketBeli.Columns.Add("   Price", 85, HorizontalAlignment.Left)
        ListMarketBeli.Columns.Add("Coint Pair   ", 110, HorizontalAlignment.Right)
        ListMarketBeli.Columns.Add("Nilai IDR   ", 100, HorizontalAlignment.Right)


        'mengatur properti
        ListMarketJual.View = View.Details
        ListMarketJual.GridLines = True
        ListMarketJual.FullRowSelect = True

        'menambahkan header kolom
        ListMarketJual.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListMarketJual.Columns.Add("   Price", 85, HorizontalAlignment.Left)
        ListMarketJual.Columns.Add("Amount    ", 110, HorizontalAlignment.Right)
        ListMarketJual.Columns.Add("Nilai IDR   ", 100, HorizontalAlignment.Right)



        'mengatur properti
        ListAktifitasMarket.View = View.Details
        ListAktifitasMarket.GridLines = True
        ListAktifitasMarket.FullRowSelect = True

        'menambahkan header kolom
        ListAktifitasMarket.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListAktifitasMarket.Columns.Add("Type", 45, HorizontalAlignment.Center)
        ListAktifitasMarket.Columns.Add("Nilai IDR ", 80, HorizontalAlignment.Right)
        ListAktifitasMarket.Columns.Add("Price   ", 68, HorizontalAlignment.Right)
        ListAktifitasMarket.Columns.Add("Time        ", 130, HorizontalAlignment.Right)
        
        '========[ Akhir Mengatur Market Place ]========



        '========[ Awal Mengatur Wallet ]========

        'mengatur properti
        ListAcount.View = View.Details
        ListAcount.GridLines = True
        ListAcount.FullRowSelect = True

        'menambahkan header kolom
        ListAcount.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListAcount.Columns.Add("      Nama Pair", 140, HorizontalAlignment.Left)
        ListAcount.Columns.Add("Saldo Tersedia  ", 110, HorizontalAlignment.Right)
        ListAcount.Columns.Add("Saldo Tertunda  ", 110, HorizontalAlignment.Right)
        
        'mengatur properti
        ListHistoryTrade.View = View.Details
        ListHistoryTrade.GridLines = True
        ListHistoryTrade.FullRowSelect = True

        'menambahkan header kolom
        ListHistoryTrade.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListHistoryTrade.Columns.Add("Tanggal Trading", 120, HorizontalAlignment.Center)
        ListHistoryTrade.Columns.Add("Pair", 55, HorizontalAlignment.Center)
        ListHistoryTrade.Columns.Add("Price", 90, HorizontalAlignment.Right)
        ListHistoryTrade.Columns.Add("Koin Pair", 90, HorizontalAlignment.Right)
        ListHistoryTrade.Columns.Add("Fee", 30, HorizontalAlignment.Right)
        ListHistoryTrade.Columns.Add("Jenis", 45, HorizontalAlignment.Left)
        ListHistoryTrade.Columns.Add("Nilai IDR", 80, HorizontalAlignment.Left)



        'mengatur properti
        ListOpenSellBuy.View = View.Details
        ListOpenSellBuy.GridLines = True
        ListOpenSellBuy.FullRowSelect = True

        'menambahkan header kolom
        ListOpenSellBuy.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListOpenSellBuy.Columns.Add("ID", 75, HorizontalAlignment.Center)
        ListOpenSellBuy.Columns.Add("Tanggal Trading", 120, HorizontalAlignment.Left)
        ListOpenSellBuy.Columns.Add("Price", 90, HorizontalAlignment.Left)
        ListOpenSellBuy.Columns.Add("Jenis", 45, HorizontalAlignment.Left)
        ListOpenSellBuy.Columns.Add("Nilai IDR", 80, HorizontalAlignment.Right)
        ListOpenSellBuy.Columns.Add("Pair", 50, HorizontalAlignment.Right)


        '========[ Akhir Mengatur Wallet ]========

       

        Timer1.Enabled = True



    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call save_monitoring()
    End Sub

    

    Private Sub ListMarketplace_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMarketplace.SelectedIndexChanged
        If ListMarketplace.SelectedItems.Count > 0 Then

            
            LabelUrutan.Text = ListMarketplace.SelectedItems(0).SubItems(0).Text
            Label3.Text = "Market Beli " & ListMarketplace.SelectedItems(0).SubItems(1).Text
            Label5.Text = "Market Jual " & ListMarketplace.SelectedItems(0).SubItems(1).Text
            Label6.Text = "Aktivitas Market " & ListMarketplace.SelectedItems(0).SubItems(1).Text
            Label6.Text = "Aktivitas Market " & ListMarketplace.SelectedItems(0).SubItems(1).Text
            
            Call market_beli_jual()
            Call aktifitas_market()


        End If
    End Sub

  
    Dim hitung_monitor As Integer = 5
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If hitung_monitor > 0 Then
            hitung_monitor = hitung_monitor - 1
            LabelInterval.Text = hitung_monitor.ToString()
        ElseIf hitung_monitor = 0 Then
            LabelInterval.Text = "-"
            Timer1.Enabled = False
            hitung_monitor = 60
            Call harga_pasar()
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxMonitoring_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMonitoring.CheckedChanged
        Try

            If CheckBoxMonitoring.Checked Then
                'hitung2 = Integer.Parse(TextBox2.Text)
                hitung_monitor = 5
                Timer1.Enabled = False
                Timer2.Enabled = True
                'Button1.Enabled = False
                CheckBoxMonitoring.Text = "Stop Monitoring"
            Else
                Timer2.Enabled = False
                Timer1.Enabled = False
                'Label1.Text = "-"
                LabelInterval.Text = "-"
                'Button1.Enabled = True
                CheckBoxMonitoring.Text = "Start Monitoring"
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If hitung_monitor > 0 Then
            hitung_monitor = hitung_monitor - 1
            'Label1.Text = hitung2.ToString()
            LabelInterval.Text = hitung_monitor.ToString()
        ElseIf hitung_monitor = 0 Then


            LabelInterval.Text = "-"


            Timer2.Enabled = False

            hitung_monitor = 60

            Call monitoring()
            Call harga_pasar()


            Timer2.Enabled = True
        End If
    End Sub


   

    

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If "23:59:00" = Format(Now, "HH:mm:ss") Then
            Call save_monitoring()
        ElseIf "06:00:00" = Format(Now, "HH:mm:ss") Then
            Call save_monitoring()
        ElseIf "12:00:00" = Format(Now, "HH:mm:ss") Then
            Call save_monitoring()
        ElseIf "18:00:00" = Format(Now, "HH:mm:ss") Then
            Call save_monitoring()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

   
 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call wallet()
    End Sub

    Private Sub ListAcount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListAcount.SelectedIndexChanged
        If ListAcount.SelectedItems.Count > 0 Then



            LabelUrutan.Text = ListAcount.SelectedItems(0).SubItems(0).Text
            Lblhistorytrade.Text = "Riwayat Transaksi  " & ListAcount.SelectedItems(0).SubItems(1).Text
            LblOrderPending.Text = "Order Pending  " & ListAcount.SelectedItems(0).SubItems(1).Text
            'GroupBox1.Text = "Beli  " & ListAcount.SelectedItems(0).SubItems(1).Text
            'GroupBox2.Text = "Jual  " & ListAcount.SelectedItems(0).SubItems(1).Text
            TxtAmountSell.Text = ListAcount.SelectedItems(0).SubItems(2).Text

            Call history_trade()
            'Call status_buy_sell()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Call save_history_trade()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Call history_trade_all()
    End Sub
End Class
