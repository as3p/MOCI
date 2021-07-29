Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Security.Cryptography
Imports System.Web
Imports System.Net.Mail

Module bantuan


    'Update 20210728
    Public a() As String = {"btc", "ten", "1inch", "aave", "abyss", "act", "ada", "aioz", "algo", "amp", "ankr", "aoa", "atom", "att", "bal", "bat", "bcd", "bch", "bnb", "botx", "bsv", "btg", "bts", "btt", "cel", "celo", "chz", "ckb", "coal", "comp", "coti", "cre", "cro", "crv", "dad", "dai", "dash", "dax", "dep", "dgb", "dgx", "doge", "dot", "dvi", "egld", "em", "enj", "eos", "etc", "eth", "eurs", "fil", "firo", "ftm", "glch", "grt", "gsc", "gxc", "hart", "hbar", "hedg", "hive", "hnst", "hot", "hpb", "idk", "ignis", "inj", "iost", "iota", "jst", "kai", "kdag", "let", "lgold", "link", "lland", "loom", "lsilver", "ltc", "lyfe", "mana", "matic", "mbl", "mkr", "neo", "nexo", "nrg", "nxt", "ocean", "octo", "ogn", "okb", "omg", "ont", "orbs", "oxt", "pando", "pax", "paxg", "qnt", "qtum", "ren", "rep", "rvn", "sand", "sfi", "snx", "solve", "sumo", "sushi", "tad", "tel", "tfuel", "theta", "titan", "trx", "uma", "uni", "usdc", "usdt", "vex", "vidy", "vidyx", "vra", "vsys", "waves", "wbtc", "wnxm", "wozx", "xdc", "xem", "xlm", "xmr", "xrp", "xsgd", "xtz", "yfi", "yfii", "zec", "zil", "zrx"}
    Public b() As String = {"idr", "btc", "ten", "1inch", "aave", "abyss", "act", "ada", "aioz", "algo", "amp", "ankr", "aoa", "atom", "att", "bal", "bat", "bcd", "bch", "bnb", "botx", "bsv", "btg", "bts", "btt", "cel", "celo", "chz", "ckb", "coal", "comp", "coti", "cre", "cro", "crv", "dad", "dai", "dash", "dax", "dep", "dgb", "dgx", "doge", "dot", "dvi", "egld", "em", "enj", "eos", "etc", "eth", "eurs", "fil", "firo", "ftm", "glch", "grt", "gsc", "gxc", "hart", "hbar", "hedg", "hive", "hnst", "hot", "hpb", "idk", "ignis", "inj", "iost", "iota", "jst", "kai", "kdag", "let", "lgold", "link", "lland", "loom", "lsilver", "ltc", "lyfe", "mana", "matic", "mbl", "mkr", "neo", "nexo", "nrg", "nxt", "ocean", "octo", "ogn", "okb", "omg", "ont", "orbs", "oxt", "pando", "pax", "paxg", "qnt", "qtum", "ren", "rep", "rvn", "sand", "sfi", "snx", "solve", "sumo", "sushi", "tad", "tel", "tfuel", "theta", "titan", "trx", "uma", "uni", "usdc", "usdt", "vex", "vidy", "vidyx", "vra", "vsys", "waves", "wbtc", "wnxm", "wozx", "xdc", "xem", "xlm", "xmr", "xrp", "xsgd", "xtz", "yfi", "yfii", "zec", "zil", "zrx"}

    'API Key Indodax
    Public api_key As String = "LLXCDDLP-LPQY0DEW-PFGBORPS-OMR7HNAD-O8DNVUZR"

    'Secret Key indodax
    Public secret_key As String = "063a9fdbea3b9e17cf8ffe3ebe645d394ec545b03dda511c92ea2ba045445af9dce329bdbb36911c"






    'Fungsi convert dari waktu unix ke waktu biasa 
    Public Function EpochToDateTime(ByVal EpochValue As Integer) As Date
        If EpochValue > 0 Then
            Return CDate("1.1.1970 00:00:00").AddSeconds(EpochValue)
        Else
            Return CDate("1.1.1970 00:00:00")
        End If
    End Function


    'Fungsi untuk memonitoring Pair terakhir Indodax
    Public Sub monitoring()
        Try
            'membuat permintaan SSL/TLS 
            ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
            'ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

            'Request string dari website
            Dim json As String = (New WebClient).DownloadString("https://indodax.com/api/summaries")
            'mendeklarasikan string JSON menjadi Objek
            Dim objek As JObject = JObject.Parse(json)

            'Menampilkan objek kedalam Listview
            Dim lvl As New ListViewItem
            'Membuat nomor urut otomatis
            lvl.Text = Menu.ListMonitoring.Items.Count + 1
            'Menampilkan waktu sekarang
            lvl.SubItems.Add(Format(Now, "dd/MM/yyyy HH:mm:ss"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(0) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(1) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(2) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(3) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(4) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(5) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(6) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(7) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(8) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(9) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(10) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(11) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(12) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(13) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(14) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(15) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(16) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(17) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(18) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(19) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(20) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(21) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(22) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(23) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(24) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(25) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(26) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(27) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(28) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(29) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(30) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(31) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(32) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(33) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(34) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(35) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(36) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(37) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(38) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(39) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(40) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(41) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(42) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(43) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(44) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(45) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(46) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(47) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(48) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(49) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(50) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(51) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(52) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(53) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(54) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(55) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(56) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(57) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(58) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(59) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(60) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(61) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(62) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(63) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(64) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(65) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(66) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(67) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(68) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(69) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(70) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(71) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(72) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(73) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(74) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(75) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(76) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(77) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(78) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(79) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(80) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(81) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(82) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(83) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(84) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(85) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(86) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(87) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(88) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(89) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(90) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(91) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(92) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(93) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(94) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(95) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(96) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(97) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(98) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(99) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(100) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(101) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(102) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(103) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(104) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(105) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(106) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(107) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(108) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(109) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(110) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(111) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(112) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(113) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(114) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(115) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(116) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(117) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(118) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(119) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(120) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(121) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(122) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(123) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(124) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(125) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(126) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(127) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(128) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(129) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(130) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(131) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(132) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(133) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(134) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(135) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(136) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(137) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(138) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(139) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(140) & "_idr.buy")), ", ###,###"))
            lvl.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(141) & "_idr.buy")), ", ###,###"))
            Menu.ListMonitoring.Items.Add(lvl)
            lvl = Nothing

        Catch ex As Exception
            'Menampilkan pesan jika terjadi Error
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    'Fungsi untuk menampilkan harga pair terbaru
    Sub harga_pasar()
        Try
            'Menghapus semua record yang ada di Listview
            Menu.ListMarketplace.Items.Clear()

            'membuat permintaan SSL/TLS 
            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

            'Request string dari website
            Dim json As String = (New WebClient).DownloadString("https://indodax.com/api/summaries")
            'mendeklarasikan string JSON menjadi Objek
            Dim objek As JObject = JObject.Parse(json)

            'melakukan perulangan untuk pair ( a adalah array dan length adalah jumlah array )
            For pair As Integer = 0 To a.Length - 1

                Dim lvl2 As New ListViewItem
                'Membuat nomor urut otomatis
                lvl2.Text = Menu.ListMarketplace.Items.Count + 1
                lvl2.SubItems.Add(a(pair))
                'lvl2.SubItems.Add(objek.SelectToken("tickers." & a(pair) & "_idr.name"))
                lvl2.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(pair) & "_idr.vol_idr")), ", ###,###"))
                lvl2.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(pair) & "_idr.buy")), ", ###,###"))
                lvl2.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(pair) & "_idr.high")), ", ###,###"))
                lvl2.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(pair) & "_idr.low")), ", ###,###"))
                lvl2.SubItems.Add(Format(Val(objek.SelectToken("tickers." & a(pair) & "_idr.last")), ", ###,###"))
                Menu.ListMarketplace.Items.Add(lvl2)
                lvl2 = Nothing

                'Menampilkan Waktu Server
                Menu.LabelServerTime.Text = "Server Time : " & EpochToDateTime(objek.SelectToken("tickers." & a(0) & "_idr.server_time"))

                ' melanjutkan looping jika belum selesai
            Next pair

        Catch ex As Exception
            'Menampilkan pesan jika terjadi Error
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub market_beli_jual()
        Menu.ListMarketBeli.Items.Clear()
        Menu.ListMarketJual.Items.Clear()
        ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        Dim pair As String = a(Val(Menu.LabelUrutan.Text) - 1)
        Dim situs As String = "https://indodax.com/api/" & pair & "_idr/depth"

        Dim json As String = (New WebClient).DownloadString(situs)
        Dim objek As JObject = JObject.Parse(json)

        For urutan As Integer = 0 To 25 - 1

            Dim price = objek.SelectToken("buy.[" & urutan & "].[0]")
            Dim aa As String = price
            Dim amount = objek.SelectToken("buy.[" & urutan & "].[1]")
            Dim bb As String = amount

            Dim lvl As New ListViewItem
            lvl.Text = Menu.ListMarketBeli.Items.Count + 1
            lvl.SubItems.Add(price)
            lvl.SubItems.Add(amount)
            lvl.SubItems.Add(Format(Val(Val(aa) * Val(bb)), ", ###,###"))
            Menu.ListMarketBeli.Items.Add(lvl)
            lvl = Nothing

        Next urutan

        For urutan2 As Integer = 0 To 50 - 1

            Dim price2 = objek.SelectToken("sell.[" & urutan2 & "].[0]")
            Dim aa2 As String = price2
            Dim amount2 = objek.SelectToken("sell.[" & urutan2 & "].[1]")
            Dim bb2 As String = amount2

            Dim lvl As New ListViewItem
            lvl.Text = Menu.ListMarketJual.Items.Count + 1
            lvl.SubItems.Add(price2)
            lvl.SubItems.Add(amount2)
            lvl.SubItems.Add(Format(Val(Val(aa2) * Val(bb2)), ", ###,###"))
            Menu.ListMarketJual.Items.Add(lvl)
            lvl = Nothing

        Next urutan2

    End Sub

    Sub aktifitas_market()
        Menu.ListAktifitasMarket.Items.Clear()
        ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        Dim pair As String = a(Val(Menu.LabelUrutan.Text) - 1)
        Dim situs As String = "https://indodax.com/api/" & pair & "_idr/trades"

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(situs), HttpWebRequest)
        request.Method = "GET"
        Dim response As WebResponse = request.GetResponse()
        Using dataStream1 As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream1)
            Dim responseFromServer As String = reader.ReadToEnd()

            'RichTextBox1.Text = responseFromServer

            Dim objek As JArray = JArray.Parse(responseFromServer)

            For urutan As Integer = 0 To objek.Count - 1

                Dim dates = objek.SelectToken("[" & urutan & "].date")
                Dim tanggal = EpochToDateTime(dates)
                Dim price = objek.SelectToken("[" & urutan & "].price")
                Dim amount = objek.SelectToken("[" & urutan & "].amount")
                Dim tid = objek.SelectToken("[" & urutan & "].tid")
                Dim type = objek.SelectToken("[" & urutan & "].type")

                Dim aa As String = price
                Dim bb As String = amount

                Dim lvl As New ListViewItem
                lvl.Text = Menu.ListAktifitasMarket.Items.Count + 1
                lvl.SubItems.Add(type)
                lvl.SubItems.Add(Format(Val(Val(aa) * Val(bb)), ", ###,###"))
                lvl.SubItems.Add(price)
                lvl.SubItems.Add(tanggal)
                Menu.ListAktifitasMarket.Items.Add(lvl)
                lvl = Nothing


            Next urutan

        End Using
        response.Close()
    End Sub

    Sub save_monitoring()
        'membuat folder di MyDocuments dan seleksi jika folder sama

        Dim lokasi As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Monitoring file\"
        If System.IO.Directory.Exists(lokasi) Then
            'MsgBox("Folder dengan nama " & TextBox1.Text & " sudah ada")
        Else
            System.IO.Directory.CreateDirectory(lokasi)
            'MsgBox("Folder anda berhasil dibuat dengan lokasi " & Path)
        End If


        'Dim lokasi As String = "C:\Users\ISO\Desktop\File\Campuran\Monitoring file\"


        Dim filename As String = "Save " & Format(Now, "yyyy-MM-dd HHmmss") & ".xls"

        Dim file As String = lokasi & filename

        Dim os As New StreamWriter(file)
        For i As Integer = 0 To Menu.ListMonitoring.Columns.Count - 1
            os.Write("" & Menu.ListMonitoring.Columns(i).Text.Replace("""", """") & vbTab)
        Next
        os.WriteLine()

        For i As Integer = 0 To Menu.ListMonitoring.Items.Count - 1
            For j As Integer = 0 To Menu.ListMonitoring.Columns.Count - 1
                os.Write("" & Menu.ListMonitoring.Items(i).SubItems(j).Text.Replace("""", "") & vbTab)
            Next
            os.WriteLine()
        Next
        os.Close()

    End Sub


   
    'Fungsi untuk melihat isi saldo di Indodax
    Sub wallet()

        'Menghapus semua record yang ada di Listview
        Menu.ListAcount.Items.Clear()

        Try
            'membuat permintaan SSL/TLS 
            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

            'nonce adalah merubah waktu biasa ke dalam UNIX
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)

            'Menulis permintaan ke Website
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest)

            'Metode dalam melakukan ermintaan ke Website
            request.Method = "POST"

            'Mengirimkan data  ke Website
            Dim postData As String = "method=getInfo" & "&nonce=" & nonce

            'Konversi post data dalam bentuk string kedalam bentuk byte array
            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)

            'Konversi secret key kedalam byte array
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)

            'Encrypted secret key dengan metode HMAC-SHA512
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))

            'Encrypted postdata dan secret key dengan metode HMAC-SHA512
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)

            'Lcase digunakan untuk merubah sting menjadi huruf kecil semua
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))

            'Menghilangkan tanda -
            Sign = Sign.Replace("-", "")

            'membuat koneksi terus-menerus ke sumber daya Internet.
            request.KeepAlive = False

            'melakukan permintaan header
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)

            'menyetel ContentType dari WebRequest
            request.ContentType = "application/x-www-form-urlencoded"

            'menyetel ContentTypeLength dari WebRequest
            request.ContentLength = byteArraypostData.Length

            'mendapatkan jalur untuk permintaan
            Dim dataStream As Stream = request.GetRequestStream()

            'menulisakan data kedalam jalur permintaan
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)

            'menutup semua objek permintaan
            dataStream.Close()

            'menerima respon dari permintaan
            Dim response As WebResponse = request.GetResponse()

            'memastikan aliran ditutup secara otomatis
            Using dataStream1 As Stream = response.GetResponseStream()

                'Buka streaming menggunakan StreamReader untuk akses
                Dim reader As New StreamReader(dataStream1)

                'menampilkan kontennya
                Dim responseFromServer As String = reader.ReadToEnd()

                'merubah string menjadi array oleh library newtownsoft dan menjadikannya sebuah objek
                Dim objek As JObject = JObject.Parse(responseFromServer)



                '==[ Menampilkan Nama ]==

                'membuat permintaan SSL/TLS 
                ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
                'Request string dari website
                Dim json As String = (New WebClient).DownloadString("https://indodax.com/api/summaries")
                'mendeklarasikan string JSON menjadi Objek
                Dim objek2 As JObject = JObject.Parse(json)


                'melakukan perulangan untuk pair ( b adalah array dan length adalah jumlah array )
                For pair As Integer = 0 To b.Length - 1

                    Dim balance = objek.SelectToken("return.balance." & b(pair))
                    Dim balance_hold = objek.SelectToken("return.balance_hold." & b(pair))
                    Dim address = objek.SelectToken("return.address." & b(pair))

                    'Menbuat objek dari permintaan ==[ Menampilkan Nama ]==
                    Dim name = objek2.SelectToken("tickers." & b(pair) & "_idr.name")

                    'menampilkan kedalam Listview
                    Dim lvl As New ListViewItem
                    'Membuat nomor urut otomatis
                    lvl.Text = Menu.ListAcount.Items.Count + 1
                    lvl.SubItems.Add(name)
                    lvl.SubItems.Add(balance)
                    lvl.SubItems.Add(balance_hold)
                    Menu.ListAcount.Items.Add(lvl)
                    lvl = Nothing

                Next pair

                'menampilkan saldo IDR di textbox
                Menu.TxtAmountBuy.Text = objek.SelectToken("return.balance.idr")

            End Using

            'membersihkan dari semua responsnya
            response.Close()

        Catch ex As Exception

            'Menampilkan pesan jika terjadi Error
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try

    End Sub



    Sub history_trade()

        On Error Resume Next

        'Menghapus semua record yang ada di Listview
        Menu.ListHistoryTrade.Items.Clear()

        'Try
        'membuat permintaan SSL/TLS 
        ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        'mengambil pair dari nomor label 
        Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)

        'nonce adalah merubah waktu biasa ke dalam UNIX
        Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)

        'Menulis permintaan ke Website
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest)

        'Metode dalam melakukan ermintaan ke Website
        request.Method = "POST"

        'Mengirimkan data  ke Website
        Dim postData As String = "method=tradeHistory" & "&nonce=" & nonce & "&pair=" & pair & "_idr"

        Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
        Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
        Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
        Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
        Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
        Sign = Sign.Replace("-", "")
        request.KeepAlive = False
        request.Headers.Add("Key", api_key)
        request.Headers.Add("Sign", Sign)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArraypostData.Length

        ' Post data
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
        dataStream.Close()

        ' kirim permintaan.  
        Dim response As WebResponse = request.GetResponse()
        Using dataStream1 As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream1)
            Dim responseFromServer As String = reader.ReadToEnd()

            'Utama.RichTextBox2.Text = Newtonsoft.Json.Linq.JObject.Parse(responseFromServer).ToString()

            If responseFromServer.Contains("fee") Then

                Dim objek As JObject = JObject.Parse(responseFromServer)

                For urutan As Integer = 0 To responseFromServer.Split("fee").Length - 2

                    Dim trade_time = objek.SelectToken("return.trades.[" & urutan & "].trade_time")
                    Dim tanggal As String = EpochToDateTime(trade_time)
                    Dim trade_id = objek.SelectToken("return.trades.[" & urutan & "].trade_id")
                    Dim order_id = objek.SelectToken("return.trades.[" & urutan & "].order_id")
                    Dim type = objek.SelectToken("return.trades.[" & urutan & "].type")
                    Dim pairr = objek.SelectToken("return.trades.[" & urutan & "]." & pair)
                    Dim aa As String = pairr
                    Dim price = objek.SelectToken("return.trades.[" & urutan & "].price")
                    Dim bb As String = price
                    Dim fee = objek.SelectToken("return.trades.[" & urutan & "].fee")



                    Dim lvl As New ListViewItem
                    lvl.Text = Menu.ListHistoryTrade.Items.Count + 1
                    lvl.SubItems.Add(tanggal)
                    lvl.SubItems.Add(pair)
                    lvl.SubItems.Add(Format(Val(price), ", ###,###"))
                    lvl.SubItems.Add(pairr)
                    lvl.SubItems.Add(fee)
                    lvl.SubItems.Add(type)
                    lvl.SubItems.Add(Format(Val(Val(aa) * Val(bb)), ", ###,###"))
                    Menu.ListHistoryTrade.Items.Add(lvl)
                    lvl = Nothing

                Next urutan
            Else

            End If


        End Using
        response.Close()

        'Catch ex As Exception

        'Menampilkan pesan jika terjadi Error
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Finally

        'End Try

    End Sub


    Sub save_history_trade()
        'membuat folder di MyDocuments dan seleksi jika folder sama

        Dim lokasi As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Monitoring file\"
        If System.IO.Directory.Exists(lokasi) Then
            'MsgBox("Folder dengan nama " & TextBox1.Text & " sudah ada")
        Else
            System.IO.Directory.CreateDirectory(lokasi)
            'MsgBox("Folder anda berhasil dibuat dengan lokasi " & Path)
        End If


        'Dim lokasi As String = "C:\Users\ISO\Desktop\File\Campuran\Monitoring file\"


        Dim filename As String = "Save History Trade " & Format(Now, "yyyy-MM-dd HHmmss") & ".xls"

        Dim file As String = lokasi & filename

        Dim os As New StreamWriter(file)
        For i As Integer = 0 To Menu.ListHistoryTrade.Columns.Count - 1
            os.Write("" & Menu.ListHistoryTrade.Columns(i).Text.Replace("""", """") & vbTab)
        Next
        os.WriteLine()

        For i As Integer = 0 To Menu.ListHistoryTrade.Items.Count - 1
            For j As Integer = 0 To Menu.ListHistoryTrade.Columns.Count - 1
                os.Write("" & Menu.ListHistoryTrade.Items(i).SubItems(j).Text.Replace("""", "") & vbTab)
            Next
            os.WriteLine()
        Next
        MsgBox("File " & filename & " telah berhasil di buat")
        os.Close()

    End Sub

    Sub history_trade_all()

        On Error Resume Next
        'Menu.ListHistoryTrade.Items.Clear()
        ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        For urutan2 As Integer = 0 To a.Length - 1

            Dim pair As String = b(urutan2)
            'Dim situs As String = "https://indodax.com/api/" & pair & "_idr/depth"

            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds) 'generate UNIX timestamp

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest) 'Menulis permintaan
            request.Method = "POST" ' Method request 

            Dim postData As String = "method=tradeHistory" & "&nonce=" & nonce & "&pair=" & pair & "_idr" 'Kirim data

            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)  'konversikan ke byte array.
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()            ' Get the request stream.  
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length) ' Write the data to the request stream.
            dataStream.Close()                                               ' Close the Stream object.

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()         ' Get the response.
            Using dataStream1 As Stream = response.GetResponseStream()  ' The using block ensures the stream is automatically closed.
                Dim reader As New StreamReader(dataStream1)             ' Open the stream using a StreamReader for easy access.  
                Dim responseFromServer As String = reader.ReadToEnd()   ' Read the content.

                'Menu.RichTextBox1.Text = Newtonsoft.Json.Linq.JObject.Parse(responseFromServer).ToString()  ' Display the content.
                'TextBox2.Text = postData


                'responseFromServer.Split("order").Length - 2
                'Menu.Label14.Text = responseFromServer.Split("fee").Length - 2

                If responseFromServer.Contains("fee") Then

                    Dim objek As JObject = JObject.Parse(responseFromServer)

                    For urutan As Integer = 0 To responseFromServer.Split("fee").Length - 2

                        Dim trade_time = objek.SelectToken("return.trades.[" & urutan & "].trade_time")
                        Dim tanggal As String = EpochToDateTime(trade_time)
                        Dim trade_id = objek.SelectToken("return.trades.[" & urutan & "].trade_id")
                        Dim order_id = objek.SelectToken("return.trades.[" & urutan & "].order_id")
                        Dim type = objek.SelectToken("return.trades.[" & urutan & "].type")
                        Dim pairr = objek.SelectToken("return.trades.[" & urutan & "]." & pair)
                        Dim aa As String = pairr
                        Dim price = objek.SelectToken("return.trades.[" & urutan & "].price")
                        Dim bb As String = price
                        Dim fee = objek.SelectToken("return.trades.[" & urutan & "].fee")



                        Dim lvl As New ListViewItem
                        lvl.Text = Menu.ListHistoryTrade.Items.Count + 1
                        lvl.SubItems.Add(tanggal)
                        lvl.SubItems.Add(pair)
                        lvl.SubItems.Add(Format(Val(price), ", ###,###"))
                        lvl.SubItems.Add(pairr)
                        lvl.SubItems.Add(fee)
                        lvl.SubItems.Add(type)
                        lvl.SubItems.Add(Format(Val(Val(aa) * Val(bb)), ", ###,###"))
                        'lvl.SubItems.Add(trade_id)
                        'lvl.SubItems.Add(order_id)
                        Menu.ListHistoryTrade.Items.Add(lvl)
                        lvl = Nothing

                    Next urutan
                Else

                End If


                'Dim objek As JArray = JArray.Parse(responseFromServer)

            End Using
            response.Close() ' Clean up the response.

        Next urutan2


    End Sub




    'masih eror

    Sub status_buy_sell()
        Menu.ListOpenSellBuy.Items.Clear()
        Try
            Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)

            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest)
            request.Method = "POST"

            Dim postData As String = "method=openOrders" & "&nonce=" & nonce

            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
            dataStream.Close()

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()
            Using dataStream1 As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream1)
                Dim responseFromServer As String = reader.ReadToEnd()

                'Menu.RichTextBox1.Text = Newtonsoft.Json.Linq.JObject.Parse(responseFromServer).ToString()

                If responseFromServer.Contains("buy") Then

                    Dim objek As JObject = JObject.Parse(responseFromServer)

                    Dim order_id = objek.SelectToken("return.orders." & pair & "_idr.[0].order_id")
                    Dim submit_time = objek.SelectToken("return.orders." & pair & "_idr.[0].submit_time")
                    Dim tanggal = EpochToDateTime(submit_time)
                    Dim price = objek.SelectToken("return.orders." & pair & "_idr.[0].price")
                    Dim type = objek.SelectToken("return.orders." & pair & "_idr.[0].type")
                    Dim order_idr = objek.SelectToken("return.orders." & pair & "_idr.[0].order_idr")


                    Dim lvl As New ListViewItem
                    lvl.Text = Menu.ListOpenSellBuy.Items.Count + 1
                    lvl.SubItems.Add(order_id)
                    lvl.SubItems.Add(tanggal)
                    lvl.SubItems.Add(Format(Val(price), ", ###,###"))
                    lvl.SubItems.Add(type)
                    lvl.SubItems.Add(Format(Val(order_idr), ", ###,###"))
                    lvl.SubItems.Add(pair)
                    Menu.ListOpenSellBuy.Items.Add(lvl)
                    lvl = Nothing

                ElseIf responseFromServer.Contains("sell") Then

                    Dim objek As JObject = JObject.Parse(responseFromServer)

                    Dim order_id = objek.SelectToken("return.orders." & pair & "_idr.[0].order_id")
                    Dim submit_time = objek.SelectToken("return.orders." & pair & "_idr.[0].submit_time")
                    Dim tanggal = EpochToDateTime(submit_time)
                    Dim price = objek.SelectToken("return.orders." & pair & "_idr.[0].price")
                    Dim type = objek.SelectToken("return.orders." & pair & "_idr.[0].type")
                    Dim order_pair = objek.SelectToken("return.orders." & pair & "_idr.[0].order_" & pair)

                    Dim aa As String = price
                    Dim bb As String = order_pair

                    Dim lvl As New ListViewItem
                    lvl.Text = Menu.ListOpenSellBuy.Items.Count + 1
                    lvl.SubItems.Add(order_id)
                    lvl.SubItems.Add(tanggal)
                    lvl.SubItems.Add(Format(Val(price), ", ###,###"))
                    lvl.SubItems.Add(type)
                    'lvl.SubItems.Add(order_pair)
                    lvl.SubItems.Add(Format(Val(Val(aa) * Val(bb)), ", ###,###"))


                    lvl.SubItems.Add(pair)
                    Menu.ListOpenSellBuy.Items.Add(lvl)
                    lvl = Nothing

                Else

                End If

            End Using
            response.Close() ' Clean up the response.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
    End Sub

    Sub limit_sell()
        Try
            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest)
            request.Method = "POST"

            Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)

            Dim methode As String = "method=trade"
            Dim _nonce As String = "&nonce=" & nonce
            Dim _pair As String = "&pair=" & pair & "_idr"
            Dim type As String = "&type=sell"
            Dim limit As String = "&price=" & Menu.TxtLimitSell.Text
            Dim amount As String = "&" & pair & "=" & Menu.TxtAmountSell.Text


            Dim postData As String = methode & _nonce & _pair & type & limit & amount


            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
            dataStream.Close()

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()
            Using dataStream1 As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream1)
                Dim responseFromServer As String = reader.ReadToEnd()

            End Using
            response.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        Menu.TxtLimitSell.Text = ""
        Menu.TxtAmountSell.Text = ""
        Call status_buy_sell()
        Call history_trade()
        Call wallet()
    End Sub

    Sub limit_buy()
        Try

            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds) 'generate UNIX timestamp
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest) 'Menulis permintaan
            request.Method = "POST"

            Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)




            Dim methode As String = "method=trade"
            Dim _nonce As String = "&nonce=" & nonce
            Dim _pair As String = "&pair=" & pair & "_idr"
            Dim type As String = "&type=buy"
            Dim limit As String = "&price=" & Menu.TxtLimitBuy.Text
            Dim amount As String = "&idr=" & Menu.TxtAmountBuy.Text



            Dim postData As String = methode & _nonce & _pair & type & limit & amount


            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
            dataStream.Close()

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()
            Using dataStream1 As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream1)
                Dim responseFromServer As String = reader.ReadToEnd()


            End Using
            response.Close() ' Clean up the response.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        Menu.TxtLimitBuy.Text = ""
        Menu.TxtAmountBuy.Text = ""
        Call status_buy_sell()
        Call history_trade()
        Call wallet()
    End Sub


    Sub instan_sell()
        Try
            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest)
            request.Method = "POST"

            Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)

            'Request string dari website
            Dim json As String = (New WebClient).DownloadString("https://indodax.com/api/summaries")
            'mendeklarasikan string JSON menjadi Objek
            Dim objek As JObject = JObject.Parse(json)
            Dim price_instan As String = objek.SelectToken("tickers." & pair & "_idr.buy")




            Dim methode As String = "method=trade"
            Dim _nonce As String = "&nonce=" & nonce
            Dim _pair As String = "&pair=" & pair & "_idr"
            Dim type As String = "&type=sell"
            Dim limit As String = "&price=" & price_instan
            Dim amount As String = "&" & pair & "=" & Menu.TxtAmountSell.Text


            Dim postData As String = methode & _nonce & _pair & type & limit & amount


            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
            dataStream.Close()

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()
            Using dataStream1 As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream1)
                Dim responseFromServer As String = reader.ReadToEnd()

            End Using
            response.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        Menu.TxtLimitSell.Text = ""
        Menu.TxtAmountSell.Text = ""
        Call status_buy_sell()
        Call history_trade()
        Call wallet()
    End Sub

    Sub instan_buy()
        Try

            ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
            Dim nonce As Long = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalSeconds) 'generate UNIX timestamp
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create("https://indodax.com/tapi"), HttpWebRequest) 'Menulis permintaan
            request.Method = "POST"

            Dim pair As String = b(Val(Menu.LabelUrutan.Text) - 1)




            'Request string dari website
            Dim json As String = (New WebClient).DownloadString("https://indodax.com/api/summaries")
            'mendeklarasikan string JSON menjadi Objek
            Dim objek As JObject = JObject.Parse(json)
            Dim price_instan As String = objek.SelectToken("tickers." & pair & "_idr.last")


            Dim methode As String = "method=trade"
            Dim _nonce As String = "&nonce=" & nonce
            Dim _pair As String = "&pair=" & pair & "_idr"
            Dim type As String = "&type=buy"
            Dim instan As String = "&price=" & price_instan
            Dim amount As String = "&idr=" & Menu.TxtAmountBuy.Text



            Dim postData As String = methode & _nonce & _pair & type & instan & amount


            Dim byteArraypostData() As Byte = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim KeyByte() As Byte = Encoding.ASCII.GetBytes(secret_key)
            Dim HMAcSha As New HMACSHA512(Encoding.ASCII.GetBytes(secret_key))
            Dim hashmessage() As Byte = HMAcSha.ComputeHash(byteArraypostData)
            Dim Sign As String = LCase(BitConverter.ToString(hashmessage))
            Sign = Sign.Replace("-", "")
            request.KeepAlive = False
            request.Headers.Add("Key", api_key)
            request.Headers.Add("Sign", Sign)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArraypostData.Length

            ' Post data
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArraypostData, 0, byteArraypostData.Length)
            dataStream.Close()

            ' kirim permintaan.  
            Dim response As WebResponse = request.GetResponse()
            Using dataStream1 As Stream = response.GetResponseStream()
                Dim reader As New StreamReader(dataStream1)
                Dim responseFromServer As String = reader.ReadToEnd()

            End Using
            response.Close() ' Clean up the response.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

        End Try
        Menu.TxtLimitBuy.Text = ""
        Menu.TxtAmountBuy.Text = ""
        Call status_buy_sell()
        Call history_trade()
        Call wallet()
    End Sub




End Module
