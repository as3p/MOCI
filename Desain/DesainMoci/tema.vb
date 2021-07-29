'231, 231, 231 = abu = tulisan header
'133, 133, 133 = abu tua = tulisan 
'255, 255, 255 = putih = background
'33, 38, 45    = hitam muda
'29, 33, 39    = hitam tua 
'41, 133, 211  = biru = tema

Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms.Form


Public Module Helpers
    'Nord
    Public Enum MouseMode As Byte
        NormalMode
        Hovered
        Pushed
        Normal
        Disabled
    End Enum

    'firefox
    Public Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

    Public Enum RoundingStyle As Byte
        All = 0
        Top = 1
        Bottom = 2
        Left = 3
        Right = 4
        TopRight = 5
        BottomRight = 6
    End Enum

    Public Sub CenterString(ByVal G As Graphics, ByVal T As String, ByVal F As Font, ByVal C As Color, ByVal R As Rectangle)
        Dim TS As SizeF = G.MeasureString(T, F)

        Using B As New SolidBrush(C)
            G.DrawString(T, F, B, New Point(R.X + R.Width / 2 - (TS.Width / 2), R.Y + R.Height / 2 - (TS.Height / 2)))
        End Using
    End Sub

    Public Function FullRectangle(ByVal S As Size, ByVal Subtract As Boolean) As Rectangle

        If Subtract Then
            Return New Rectangle(0, 0, S.Width - 1, S.Height - 1)
        Else
            Return New Rectangle(0, 0, S.Width, S.Height)
        End If

    End Function

    Public Function RoundRect(ByVal Rect As Rectangle, ByVal Rounding As Integer, Optional ByVal Style As RoundingStyle = RoundingStyle.All) As GraphicsPath

        Dim GP As New GraphicsPath()
        Dim AW As Integer = Rounding * 2

        GP.StartFigure()

        If Rounding = 0 Then
            GP.AddRectangle(Rect)
            GP.CloseAllFigures()
            Return GP
        End If

        Select Case Style
            Case RoundingStyle.All
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Top
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
            Case RoundingStyle.Bottom
                GP.AddLine(New Point(Rect.X, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Left
                GP.AddArc(New Rectangle(Rect.X, Rect.Y, AW, AW), -180, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height))
                GP.AddArc(New Rectangle(Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 90, 90)
            Case RoundingStyle.Right
                GP.AddLine(New Point(Rect.X, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
            Case RoundingStyle.TopRight
                GP.AddLine(New Point(Rect.X, Rect.Y + 1), New Point(Rect.X, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Y, AW, AW), -90, 90)
                GP.AddLine(New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height - 1), New Point(Rect.X + Rect.Width, Rect.Y + Rect.Height))
                GP.AddLine(New Point(Rect.X + 1, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
            Case RoundingStyle.BottomRight
                GP.AddLine(New Point(Rect.X, Rect.Y + 1), New Point(Rect.X, Rect.Y))
                GP.AddLine(New Point(Rect.X + Rect.Width - 1, Rect.Y), New Point(Rect.X + Rect.Width, Rect.Y))
                GP.AddArc(New Rectangle(Rect.Width - AW + Rect.X, Rect.Height - AW + Rect.Y, AW, AW), 0, 90)
                GP.AddLine(New Point(Rect.X + 1, Rect.Y + Rect.Height), New Point(Rect.X, Rect.Y + Rect.Height))
        End Select

        GP.CloseAllFigures()

        Return GP

    End Function

    'pale
    Public Function RoundRec(ByVal r As Rectangle, ByVal Curve As Integer, _
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True) As GraphicsPath
        Dim CreateRoundPath As New GraphicsPath(FillMode.Winding)
        If TopLeft Then
            CreateRoundPath.AddArc(r.X, r.Y, Curve, Curve, 180.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.X, r.Y, r.X, r.Y)
        End If
        If TopRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y)
        End If
        If BottomRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom)

        End If
        If BottomLeft Then
            CreateRoundPath.AddArc(r.X, r.Bottom - Curve, Curve, Curve, 90.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.X, r.Bottom, r.X, r.Bottom)
        End If
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function

    Public Sub FillRoundedPath(ByVal G As Graphics, ByVal B As Brush, ByVal Rect As Rectangle, ByVal Curve As Integer, _
                                Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                                Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .FillPath(B, RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub

    Public Sub DrawRoundedPath(ByVal G As Graphics, ByVal C As Color, ByVal Size As Single, ByVal Rect As Rectangle, ByVal Curve As Integer, _
                                 Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                                 Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .DrawPath(New Pen(C, Size), RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub

    Public Sub CentreString(ByVal G As Graphics, ByVal Text As String, ByVal font As Font, ByVal brush As Brush, ByVal Rect As Rectangle)
        G.DrawString(Text, font, brush, New Rectangle(0, Rect.Y + (Rect.Height / 2) - (G.MeasureString(Text, font).Height / 2) + 0, Rect.Width, Rect.Height), New StringFormat With {.Alignment = StringAlignment.Center})
    End Sub

    'vibelander
    Public MustInherit Class ThemeContainerControl
        Inherits ContainerControl

#Region " Initialization "

        Protected G As Graphics, B As Bitmap
        Sub New()
            SetStyle(DirectCast(139270, ControlStyles), True)
            B = New Bitmap(1, 1)
            G = Graphics.FromImage(B)
        End Sub

        Sub AllowTransparent()
            SetStyle(ControlStyles.Opaque, False)
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        End Sub

#End Region
#Region " Convienence "

        MustOverride Sub PaintHook()
        Protected NotOverridable Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            If Width = 0 OrElse Height = 0 Then Return
            PaintHook()
            e.Graphics.DrawImage(B, 0, 0)
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            If Not Width = 0 AndAlso Not Height = 0 Then
                B = New Bitmap(Width, Height)
                G = Graphics.FromImage(B)
                Invalidate()
            End If
            MyBase.OnSizeChanged(e)
        End Sub

        Private _NoRounding As Boolean
        Property NoRounding() As Boolean
            Get
                Return _NoRounding
            End Get
            Set(ByVal v As Boolean)
                _NoRounding = v
                Invalidate()
            End Set
        End Property

        Private _Rectangle As Rectangle
        Private _Gradient As LinearGradientBrush

        Protected Sub DrawCorners(ByVal c As Color, ByVal rect As Rectangle)
            If _NoRounding Then Return
            B.SetPixel(rect.X, rect.Y, c)
            B.SetPixel(rect.X + (rect.Width - 1), rect.Y, c)
            B.SetPixel(rect.X, rect.Y + (rect.Height - 1), c)
            B.SetPixel(rect.X + (rect.Width - 1), rect.Y + (rect.Height - 1), c)
        End Sub

        Protected Sub DrawBorders(ByVal p1 As Pen, ByVal p2 As Pen, ByVal rect As Rectangle)
            G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1)
            G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3)
        End Sub

        Protected Sub DrawGradient(ByVal c1 As Color, ByVal c2 As Color, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal angle As Single)
            _Rectangle = New Rectangle(x, y, width, height)
            _Gradient = New LinearGradientBrush(_Rectangle, c1, c2, angle)
            G.FillRectangle(_Gradient, _Rectangle)
        End Sub
#End Region

    End Class

End Module

Namespace Base

    'firefox
    Public MustInherit Class LeftTabControl
        Inherits TabControl

        Public BaseRect As Rectangle
        Public OverRect As Rectangle
        Public ItemWidth As Integer = 180

        Private _OverIndex As Integer = -1

        Public ReadOnly Property Hovering As Boolean
            Get
                Return Not OverIndex = -1
            End Get
        End Property

        Public Property OverIndex As Integer
            Get
                Return _OverIndex
            End Get
            Set(ByVal value As Integer)
                _OverIndex = value

                If Not _OverIndex = -1 Then
                    OverRect = New Rectangle(GetTabRect(OverIndex).X, GetTabRect(OverIndex).Y, GetTabRect(OverIndex).Width, GetTabRect(OverIndex).Height)
                End If

                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = Color.FromArgb(66, 78, 90)
            e.Control.Font = New Font("Segoe UI", 10)
        End Sub

        Sub New()
            DoubleBuffered = True
            Alignment = TabAlignment.Left
            ItemSize = New Size(40, ItemWidth)
            SizeMode = TabSizeMode.Fixed
            Font = New Font("Segoe UI", 10)

        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)

            For I As Integer = 0 To TabPages.Count - 1
                If GetTabRect(I).Contains(e.Location) And Not SelectedIndex = I Then
                    OverIndex = I
                    Exit For
                Else
                    OverIndex = -1
                End If
            Next

            MyBase.OnMouseMove(e)

        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            OverIndex = -1
        End Sub

    End Class

    Public MustInherit Class TopTabControl
        Inherits TabControl

        Public BaseRect As Rectangle
        Public OverRect As Rectangle
        Public ItemWidth As Integer = 180

        Private _OverIndex As Integer = -1

        Public ReadOnly Property Hovering As Boolean
            Get
                Return Not OverIndex = -1
            End Get
        End Property

        Public Property OverIndex As Integer
            Get
                Return _OverIndex
            End Get
            Set(ByVal value As Integer)
                _OverIndex = value

                If Not _OverIndex = -1 Then
                    OverRect = New Rectangle(GetTabRect(OverIndex).X, GetTabRect(OverIndex).Y, GetTabRect(OverIndex).Width, GetTabRect(OverIndex).Height)
                End If

                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = Color.FromArgb(66, 78, 90)
            e.Control.Font = New Font("Segoe UI", 10)
        End Sub

        Sub New()
            DoubleBuffered = True
            Alignment = TabAlignment.Top
            ItemSize = New Size(ItemWidth, 40)
            SizeMode = TabSizeMode.Fixed
            Font = New Font("Segoe UI", 10)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)

            For I As Integer = 0 To TabPages.Count - 1
                If GetTabRect(I).Contains(e.Location) And Not SelectedIndex = I Then
                    OverIndex = I
                    Exit For
                Else
                    OverIndex = -1
                End If
            Next

            MyBase.OnMouseMove(e)

        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            OverIndex = -1
        End Sub

    End Class

    Public MustInherit Class CheckControl
        Inherits Control

        Public Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Public State As MouseState

        Private IsEnabled As Boolean
        Private IsChecked As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(ByVal value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(ByVal value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Public Property Checked As Boolean
            Get
                Return IsChecked
            End Get
            Set(ByVal value As Boolean)
                IsChecked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            Enabled = True
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()

            If Enabled Then
                Checked = Not Checked
                RaiseEvent CheckedChanged(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub

    End Class

    Public MustInherit Class BaseRadioButton
        Inherits Control

        Public Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Public State As MouseState

        Private IsEnabled As Boolean
        Private IsChecked As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(ByVal value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(ByVal value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Public Property Checked As Boolean
            Get
                Return IsChecked
            End Get
            Set(ByVal value As Boolean)
                IsChecked = value
                Invalidate()
            End Set
        End Property

        Sub New()
            Enabled = True
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()

            If Enabled Then

                If Not Checked Then

                    For Each C As Control In Parent.Controls
                        If TypeOf C Is BaseRadioButton Then
                            DirectCast(C, BaseRadioButton).Checked = False
                        End If
                    Next

                End If

                Checked = True
                RaiseEvent CheckedChanged(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub

    End Class

    Public MustInherit Class ButtonBase
        Inherits Control

        Public Shadows Event Click(ByVal sender As Object, ByVal e As EventArgs)

        Public State As MouseState
        Private IsEnabled As Boolean

        Public Shadows Property Enabled As Boolean
            Get
                Return EnabledCalc
            End Get
            Set(ByVal value As Boolean)
                IsEnabled = value

                If Enabled Then
                    Cursor = Cursors.Hand
                Else
                    Cursor = Cursors.Default
                End If

                Invalidate()
            End Set
        End Property

        <DisplayName("Enabled")>
        Public Property EnabledCalc As Boolean
            Get
                Return IsEnabled
            End Get
            Set(ByVal value As Boolean)
                Enabled = value
                Invalidate()
            End Set
        End Property

        Sub New()
            DoubleBuffered = True
            Enabled = True
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Over : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseState.Over : Invalidate()

            If Enabled Then
                RaiseEvent Click(Me, e)
            End If

        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            State = MouseState.Down : Invalidate()
        End Sub

    End Class


End Namespace



Namespace Komponen
    'Airfox
    Public Class MainTabControl
        Inherits Base.LeftTabControl

        Private G As Graphics

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            '            warna dasar tema (hitam tua)
            G.Clear(Color.FromArgb(29, 33, 39))

            For I As Integer = 0 To TabPages.Count - 1

                BaseRect = GetTabRect(I)

                If SelectedIndex = I Then
                    '                                     'warna kotak saat di klik(hitam muda)                   'warna tulisan saat di klik (putih)
                    Using SelectionBrush As New SolidBrush(Color.FromArgb(33, 38, 45)), TextBrush As New SolidBrush(Color.FromArgb(255, 255, 255)), TextFont As New Font("Segoe UI", 10)
                        G.FillRectangle(SelectionBrush, New Rectangle(BaseRect.X - 6, BaseRect.Y + 1, BaseRect.Width + 9, BaseRect.Height - 1))
                        G.DrawString(TabPages(I).Text, TextFont, TextBrush, New Point(BaseRect.X + 55, BaseRect.Y + 11))
                    End Using

                    G.SmoothingMode = SmoothingMode.Default
                    '                                        warna garis klik (biru)
                    Using LeftBarBrush As New SolidBrush(Color.FromArgb(41, 133, 211))
                        G.FillRectangle(LeftBarBrush, New Rectangle(BaseRect.X - 2, BaseRect.Y + 2, 4, BaseRect.Height - 2))
                    End Using

                Else
                    '                                     warna tulisan saat diam (abu)
                    Using TextBrush As New SolidBrush(Color.FromArgb(231, 231, 231)), TextFont As New Font("Segoe UI", 10)
                        G.DrawString(TabPages(I).Text, TextFont, TextBrush, New Point(BaseRect.X + 55, BaseRect.Y + 11))
                    End Using

                End If

                If Not IsNothing(ImageList) Then
                    If Not TabPages(I).ImageIndex < 0 Then
                        G.DrawImage(ImageList.Images(TabPages(I).ImageIndex), New Rectangle(BaseRect.X + 23, BaseRect.Y + ((BaseRect.Height / 2) - 8), 16, 16))
                    End If
                End If

                If Hovering Then

                    '                                  warna kotak saat mouse move (hitam muda)                 warna tulisan saat diam (abu)
                    Using HoverBrush As New SolidBrush(Color.FromArgb(33, 38, 45)), TextBrush As New SolidBrush(Color.FromArgb(231, 231, 231)), TextFont As New Font("Segoe UI", 10)
                        G.FillRectangle(HoverBrush, New Rectangle(OverRect.X - 6, OverRect.Y + 1, OverRect.Width + 9, OverRect.Height - 1))
                        G.DrawString(TabPages(OverIndex).Text, TextFont, TextBrush, New Point(OverRect.X + 55, OverRect.Y + 11))
                    End Using

                    If Not IsNothing(ImageList) Then
                        If Not TabPages(OverIndex).ImageIndex < 0 Then
                            G.DrawImage(ImageList.Images(TabPages(OverIndex).ImageIndex), New Rectangle(OverRect.X + 23, OverRect.Y + ((OverRect.Height / 2) - 8), 16, 16))
                        End If
                    End If

                End If

            Next

            MyBase.OnPaint(e)

        End Sub

    End Class

    Public Class SubTabControl
        Inherits Base.TopTabControl


        Private G As Graphics

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

            '            warna dasar tema (hitam tua)
            G.Clear(Color.FromArgb(29, 33, 39))

            For I As Integer = 0 To TabPages.Count - 1

                BaseRect = GetTabRect(I)

                If SelectedIndex = I Then
                    '                                     'warna kotak saat di klik(hitam muda)                   'warna tulisan saat di klik (putih)
                    Using SelectionBrush As New SolidBrush(Color.FromArgb(33, 38, 45)), TextBrush As New SolidBrush(Color.FromArgb(255, 255, 255)), TextFont As New Font("Segoe UI", 10)
                        G.FillRectangle(SelectionBrush, New Rectangle(BaseRect.X + 2, BaseRect.Y - 2, BaseRect.Width, BaseRect.Height + 1))
                        CenterString(G, TabPages(I).Text, TextFont, TextBrush.Color, New Rectangle(BaseRect.X + 4, BaseRect.Y, BaseRect.Width, BaseRect.Height))
                    End Using

                    G.SmoothingMode = SmoothingMode.Default
                    '                                           warna garis klik (biru)
                    Using BottomBarBrush As New SolidBrush(Color.FromArgb(41, 133, 211))
                        G.FillRectangle(BottomBarBrush, New Rectangle(BaseRect.X + 3, BaseRect.Y + 36, BaseRect.Width - 1, 4))
                    End Using

                Else
                    '                                     warna tulisan saat diam (abu)
                    Using TextBrush As New SolidBrush(Color.FromArgb(231, 231, 231)), TextFont As New Font("Segoe UI", 10)
                        CenterString(G, TabPages(I).Text, TextFont, TextBrush.Color, New Rectangle(BaseRect.X + 4, BaseRect.Y, BaseRect.Width, BaseRect.Height))
                    End Using

                End If

                If Hovering Then
                    '                                  warna kotak saat mouse move (hitam muda)                 warna tulisan saat diam (abu)
                    Using HoverBrush As New SolidBrush(Color.FromArgb(33, 38, 45)), TextBrush As New SolidBrush(Color.FromArgb(231, 231, 231)), TextFont As New Font("Segoe UI", 10)
                        G.FillRectangle(HoverBrush, New Rectangle(OverRect.X + 2, OverRect.Y - 2, OverRect.Width, OverRect.Height + 1))
                        CenterString(G, TabPages(OverIndex).Text, TextFont, TextBrush.Color, New Rectangle(OverRect.X + 4, OverRect.Y, OverRect.Width, OverRect.Height))
                    End Using

                End If

            Next
            '                           warna garis line
            Using BottomLine As New Pen(Color.FromArgb(29, 33, 39), 1)
                G.DrawLine(BottomLine, 5, 42, Width - 6, 42)
            End Using

            MyBase.OnPaint(e)

        End Sub

    End Class

    Public Class CheckBox1
        Inherits Base.CheckControl

        Private G As Graphics
        Private B64E As String = "iVBORw0KGgoAAAANSUhEUgAAAAwAAAAMCAMAAABhq6zVAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAABfVBMVEUAAAArntgsm9srm9sgn98gnuE1m9gsndoqnNkvmdYpnNkqm9gvl9YtnNksntosnNorm9o2mtoumtg/mb8rmtotm9snn9s/kMIqnNosm9ksoNssndksndklndwyl9gqn9krm9ornNksm9ksm9srm9srm9ssnNornNkgnd4xm9ksnNosnNorm9orm9ssnNosnNoalf8rnNkrm9ksnNosm9opnNkpnNkrnNkqm9ksnNosnNktmdcqm9ssnNosnNornNssnNksnNornNornNosm9srnNodnNYsmtosnNornNovmtkqnNornNosm9osnNoqmtorm9opntYim9Msm9osnNorm9osnNorm9oum9oAr9U1mNYqndosnNosnNosnNoxmNEont4qndoqnNosnNosnNosm9krm9kpnNksndornNkrnNksntsulc8pnt0snNosnNosnNosnNosnNosnNosnNosnNosnNosnNosnNosnNosnNosnNosnNornNn///9BLcc1AAAAbnRSTlMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWz8agABKOiVAAOt7jYBAgEABFr/fAABAhjRyg0VZhQDi/tMApWzBUD6kwJtgMTcHgIABKTkuvtkBAAAGtb7vwEBAkPz9zABAAJwdAEAANmSOx8AAAABYktHRH4/uEFzAAAAB3RJTUUH3wscBzYVoy2+dwAAAJxJREFUCNdjYAABWTl5RgVFJTBbmUmFWVUtTx3EZmHV0GTTytfWYdDV02c3MOQwMi4w4WTg4jI1M+e2sCy0suZhsLG147XncyhydOJ3ZnApdnUTcPco8RT0EmLwLi3zEfYt9/MXCQhkCAquCAkNqwwXjYiMYhCLjqmKrY4Tj09gYWFIlEhKrklJlUzjSmdgkMqQzqzNksnOyWVgAABtEB7gG6KeHgAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNS0xMS0yOFQwNzo1NDoyMS0wNTowMCRACR8AAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTUtMTEtMjhUMDc6NTQ6MjEtMDU6MDBVHbGjAAAAAElFTkSuQmCC"
        Private B64D As String = "iVBORw0KGgoAAAANSUhEUgAAAAwAAAAMCAMAAABhq6zVAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAABfVBMVEUAAAC2tbW3s7O2tLS/r6/Brq6vtra1s7O2tLS1srK2s7O2tLSxsLC1s7O3t7e2s7O2tLS1ubm0s7OroqK2tLS3s7O2tbWxqKi2s7O1s7O2t7e2tbW2s7O6sbGxtra4tLS2tLS2tLS1tLS3s7O2tLS2tLS2tLS2s7O9r6+ytbW1s7O2tLS2s7O2tLS2tLS1s7P1ioq1tLS1tLS2tLS2tLS2s7O2s7O2tLS2s7O2tLS1s7OzsbG2tLS2tLS1s7O2tbW2s7O2tLS2s7O2s7O2tLS2tLS6srK2tLS2tLS2s7O1tbW2s7O1s7O2tLS2tLS2s7O2tLSys7OssLC2tLS2tLS1tLS2tLS2s7O2tLTGoKCut7e0tbW2tLS2tLS2tLS1rq63tra3s7O3s7O2tLS2tLS1s7O1s7O2s7O2tbW1tLS1tLS3tLSwsbG3tra2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS2tLS1tLT///9wiMU7AAAAbnRSTlMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWz8agABKOiVAAOt7jYBAgEABFr/fAABAhjRyg0VZhQDi/tMApWzBUD6kwJtgMTcHgIABKTkuvtkBAAAGtb7vwEBAkPz9zABAAJwdAEAANmSOx8AAAABYktHRH4/uEFzAAAAB3RJTUUH3wscBzg0cceDpwAAAJxJREFUCNdjYAABWTl5RgVFJTBbmUmFWVUtTx3EZmHV0GTTytfWYdDV02c3MOQwMi4w4WTg4jI1M+e2sCy0suZhsLG147XncyhydOJ3ZnApdnUTcPco8RT0EmLwLi3zEfYt9/MXCQhkCAquCAkNqwwXjYiMYhCLjqmKrY4Tj09gYWFIlEhKrklJlUzjSmdgkMqQzqzNksnOyWVgAABtEB7gG6KeHgAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAxNS0xMS0yOFQwNzo1Njo1Mi0wNTowMBuYyqYAAAAldEVYdGRhdGU6bW9kaWZ5ADIwMTUtMTEtMjhUMDc6NTY6NTItMDU6MDBqxXIaAAAAAElFTkSuQmCC"

        Public Property Bold As Boolean

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit


            'warna dasar tema (sesuai backcolor)
            G.Clear(Parent.BackColor)

            If Enabled Then

                Select Case State

                    Case MouseState.None

                        '                           warna kotak diam (hitam tua)
                        Using Border As New Pen(Color.FromArgb(29, 33, 39, 0))
                            G.DrawPath(Border, RoundRect(New Rectangle(0, 0, 20, 20), 2))
                        End Using


                    Case Else
                        '                  warna kotak mouse move (biru)
                        Using Border As New Pen(Color.FromArgb(41, 133, 211))
                            G.DrawPath(Border, RoundRect(New Rectangle(0, 0, 20, 20), 2))
                        End Using

                End Select
                '                                      warna tulisan (abu)
                Using TextColor As New SolidBrush(Color.FromArgb(133, 133, 133))

                    If Bold Then

                        Using BFont As New Font("Segoe UI", 10, FontStyle.Bold)
                            G.DrawString(Text, BFont, TextColor, New Point(27, 1))
                        End Using

                    Else
                        Using DFont As New Font("Segoe UI", 10)
                            G.DrawString(Text, DFont, TextColor, New Point(27, 1))
                        End Using

                    End If

                End Using

            Else
                '                           warna kotak diam (hitam tua)
                Using Border As New Pen(Color.FromArgb(29, 33, 39, 0))
                    G.DrawPath(Border, RoundRect(New Rectangle(0, 0, 20, 20), 2))
                End Using

                '                                      warna tulisan (abu)
                Using TextColor As New SolidBrush(Color.FromArgb(133, 133, 133))

                    If Bold Then

                        Using BFont As New Font("Segoe UI", 10, FontStyle.Bold)
                            G.DrawString(Text, BFont, TextColor, New Point(27, 1))
                        End Using

                    Else
                        Using DFont As New Font("Segoe UI", 10)
                            G.DrawString(Text, DFont, TextColor, New Point(27, 1))
                        End Using

                    End If

                End Using

            End If

            If Checked Then

                If Enabled Then

                    Using I As Image = Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(B64E)))
                        G.DrawImage(I, New Rectangle(5, 4, 12, 12))
                    End Using

                Else

                    Using I As Image = Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(B64D)))
                        G.DrawImage(I, New Rectangle(5, 4, 12, 12))
                    End Using

                End If

            End If

            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class RadioButton1
        Inherits Base.BaseRadioButton

        Private G As Graphics
        Public Property Bold As Boolean

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit


            G.Clear(Parent.BackColor)

            If Enabled Then

                Select Case State

                    Case MouseState.None
                        '                    warna bulet diam (abu)
                        Using Border As New Pen(Color.FromArgb(231, 231, 231))
                            G.DrawEllipse(Border, New Rectangle(0, 0, 20, 20))
                        End Using

                    Case Else
                        '                    warna bulet klik (biru)
                        Using Border As New Pen(Color.FromArgb(41, 133, 211))
                            G.DrawEllipse(Border, New Rectangle(0, 0, 20, 20))
                        End Using

                End Select
                '                                        warna tulisan (abu tua)
                Using TextColor As New SolidBrush(Color.FromArgb(133, 133, 133))

                    If Bold Then

                        Using BFont As New Font("Segoe UI", 10, FontStyle.Bold)
                            G.DrawString(Text, BFont, TextColor, New Point(27, 1))
                        End Using

                    Else
                        Using DFont As New Font("Segoe UI", 10)
                            G.DrawString(Text, DFont, TextColor, New Point(27, 1))
                        End Using

                    End If

                End Using

            Else
                '                    warna bulet diam (abu)
                Using Border As New Pen(Color.FromArgb(231, 231, 231))
                    G.DrawEllipse(Border, New Rectangle(0, 0, 20, 20))
                End Using

                '                                        warna tulisan (abu tua)
                Using TextColor As New SolidBrush(Color.FromArgb(133, 133, 133))

                    If Bold Then

                        Using BFont As New Font("Segoe UI", 10, FontStyle.Bold)
                            G.DrawString(Text, BFont, TextColor, New Point(27, 1))
                        End Using

                    Else
                        Using DFont As New Font("Segoe UI", 10)
                            G.DrawString(Text, DFont, TextColor, New Point(27, 1))
                        End Using

                    End If

                End Using

            End If

            If Checked Then

                If Enabled Then

                    '                                        saat buletan di klik
                    Using FillColor As New SolidBrush(Color.FromArgb(41, 133, 211))
                        G.FillEllipse(FillColor, New Rectangle(4, 4, 12, 12))
                    End Using

                Else
                    '                                      warna buletan di klik (abu)
                    Using FillColor As New SolidBrush(Color.FromArgb(231, 231, 231))
                        G.FillEllipse(FillColor, New Rectangle(4, 4, 12, 12))
                    End Using

                End If

            End If

            MyBase.OnPaint(e)
        End Sub

    End Class

    Public Class Header1
        Inherits Control

        Private G As Graphics

        Sub New()
            Font = New Font("Segoe UI Semibold", 20)
            '                              warna abu 
            ForeColor = Color.FromArgb(231, 231, 231)
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Size = New Size(Width, 51)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit


            G.Clear(Parent.BackColor)
            '                                                                                       warna abu tua 
            Using HFont As New Font("Segoe UI Semibold", 20), HColor As New SolidBrush(Color.FromArgb(133, 133, 133))
                G.DrawString(Text, HFont, HColor, New Point(0, 0))
            End Using

            Using BottomLine As New Pen(Color.FromArgb(231, 231, 231))
                G.DrawLine(BottomLine, New Point(0, 50), New Point(Width, 50))
            End Using

            MyBase.OnPaint(e)

        End Sub

    End Class

    Public Class Label1
        Inherits Control

        Private G As Graphics

        Sub New()
            Font = New Font("Segoe UI", 10, FontStyle.Regular)
            ForeColor = Color.FromArgb(133, 133, 133)
            DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Size = New Size(Width, 19)
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

            G = e.Graphics
            G.SmoothingMode = SmoothingMode.HighQuality
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

            G.Clear(Parent.BackColor)

            Using HFont As New Font("Segoe UI", 10, FontStyle.Regular), HColor As New SolidBrush(Color.FromArgb(133, 133, 133))
                G.DrawString(Text, HFont, HColor, New Point(0, 0))
            End Using

            MyBase.OnPaint(e)

        End Sub

    End Class

    'NordTextbox
    Public Class Textbox1 : Inherits Control

#Region " Variables "

        Private WithEvents T As New TextBox
        Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
        Private _MaxLength As Integer = 32767
        Private _ReadOnly As Boolean = False
        Private _UseSystemPasswordChar As Boolean = False
        Private _WatermarkText As String = String.Empty
        Private _SideImage As Image
        Private State As MouseMode = MouseMode.NormalMode

#End Region

#Region " Native Methods "

        Private Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)> ByVal lParam As String) As Int32

#End Region

#Region " Properties "

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        ReadOnly Property BorderStyle As BorderStyle
            Get
                Return BorderStyle.None
            End Get
        End Property

        <Category("Appearance"),
        Description("Gets or sets how text is aligned in a System.Windows.Forms.TextBox control.")>
        Public Overridable Shadows Property TextAlign() As HorizontalAlignment
            Get
                Return _TextAlign
            End Get
            Set(ByVal value As HorizontalAlignment)
                _TextAlign = value
                If T IsNot Nothing Then
                    T.TextAlign = value
                End If
            End Set
        End Property

        <Category("Behavior"),
         Description("Gets or sets how text is aligned in a System.Windows.Forms.TextBox control.")>
        Public Overridable Shadows Property MaxLength() As Integer
            Get
                Return _MaxLength
            End Get
            Set(ByVal value As Integer)
                _MaxLength = value
                If T IsNot Nothing Then
                    T.MaxLength = value
                End If
            End Set
        End Property



        <Category("Behavior"),
         Description("Gets or sets a value indicating whether text in the text box is read-only.")>
        Public Overridable Shadows Property [ReadOnly]() As Boolean
            Get
                Return _ReadOnly
            End Get
            Set(ByVal value As Boolean)
                _ReadOnly = value
                If T IsNot Nothing Then
                    T.ReadOnly = value
                End If
            End Set
        End Property

        <Category("Behavior"),
         Description("Gets or sets a value indicating whether the text in the System.Windows.Forms.TextBox control should appear as the default password character.")>
        Public Overridable Shadows Property UseSystemPasswordChar() As Boolean
            Get
                Return _UseSystemPasswordChar
            End Get
            Set(ByVal value As Boolean)
                _UseSystemPasswordChar = value
                If T IsNot Nothing Then
                    T.UseSystemPasswordChar = value
                End If
            End Set
        End Property

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public Overridable Shadows ReadOnly Property Multiline() As Boolean
            Get
                Return False
            End Get
        End Property

        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public Overridable Shadows ReadOnly Property BackgroundImage() As Image
            Get
                Return Nothing
            End Get
        End Property

        <Category("Appearance"),
        Description("Gets or sets the current text in the System.Windows.Forms.TextBox.")>
        Public Overridable Shadows Property Text As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                If T IsNot Nothing Then
                    T.Text = value
                End If
            End Set
        End Property

        <Category("Custom Properties "),
         Description("Gets or sets the text in the System.Windows.Forms.TextBox while being empty.")>
        Public Property WatermarkText As String
            Get
                Return _WatermarkText
            End Get
            Set(ByVal value As String)
                _WatermarkText = value
                SendMessage(T.Handle, &H1501, 0, value)
                Invalidate()
            End Set
        End Property

        <Category("Custom Properties "),
         Description("Gets or sets the image of the control.")>
        <Browsable(True)> Public Property SideImage As Image
            Get
                Return _SideImage
            End Get
            Set(ByVal value As Image)
                _SideImage = value
                Invalidate()
            End Set
        End Property




#End Region

#Region " Constructors "

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                      ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                      ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            BackColor = Color.FromArgb(255, 255, 255)
            With T
                .Multiline = False
                .Cursor = Cursors.IBeam
                .BackColor = Color.FromArgb(255, 255, 255)
                .ForeColor = Color.FromArgb(133, 133, 133) 'warna tulisan
                .BorderStyle = BorderStyle.None
                .Location = New Point(7, 8)
                .Font = New Font("Segoe UI", 10)
                .Size = New Size(Width - 10, 30)
                .UseSystemPasswordChar = _UseSystemPasswordChar
            End With
            Size = New Size(135, 30)
            UpdateStyles()
        End Sub

#End Region

#Region " Events "

        Private Sub T_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles T.TextChanged
            Text = T.Text
        End Sub

        Private Sub T_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles T.KeyDown
            If e.Control AndAlso e.KeyCode = Keys.A Then e.SuppressKeyPress = True
            If e.Control AndAlso e.KeyCode = Keys.C Then
                T.Copy()
                e.SuppressKeyPress = True
            End If
        End Sub

        Protected NotOverridable Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            If Not Controls.Contains(T) Then Controls.Add(T)
        End Sub

        Protected NotOverridable Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Height = 30
        End Sub

        Private Sub T_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles T.MouseHover
            State = MouseMode.Hovered
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseHover(ByVal e As EventArgs)
            MyBase.OnMouseHover(e)
            State = MouseMode.Hovered
            Invalidate()
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseMode.NormalMode
            Invalidate()
        End Sub
        Private Sub T_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles T.MouseLeave
            State = MouseMode.NormalMode
            Invalidate()
        End Sub

        Private Sub T_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles T.MouseUp
            State = MouseMode.NormalMode
            Invalidate()
        End Sub

        Private Sub T_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles T.MouseEnter
            State = MouseMode.NormalMode
            Invalidate()
        End Sub

        Private Sub T_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles T.MouseDown
            State = MouseMode.Pushed
            Invalidate()
        End Sub

#End Region

#Region " Draw Control "

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim G As Graphics = e.Graphics
            With G
                'Dim Rect As New Rectangle(0, 0, Width - 1, Height - 1)
                'Height = 30

                .TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

                Select Case State

                    Case MouseMode.NormalMode
                        '                            warna garis diam
                        .DrawLine(New Pen(Color.FromArgb(133, 133, 133), 1), New Point(0, 29), New Point(Width, 29))
                    Case MouseMode.Hovered
                        '                            warna garis mouse
                        .DrawLine(New Pen(Color.FromArgb(41, 133, 211), 2), New Point(0, 29), New Point(Width, 29)) 'ketebelan Garis
                    Case MouseMode.Pushed
                        '                            warna garis mouse tekan
                        .DrawLine(New Pen(Color.FromArgb(41, 133, 211), 2), New Point(0, 29), New Point(Width, 29)) 'ketebelan Garis

                End Select

                If Not SideImage Is Nothing Then
                    T.Location = New Point(33, 5)
                    T.Width = Width - 60
                    .InterpolationMode = InterpolationMode.HighQualityBicubic
                    .DrawImage(SideImage, New Rectangle(8, 5, 16, 16))
                Else
                    T.Location = New Point(7, 5)
                    T.Width = Width - 10
                End If

                If Not ContextMenuStrip Is Nothing Then T.ContextMenuStrip = ContextMenuStrip

            End With

        End Sub

#End Region

    End Class

    'PaleBlueButton
    Public Class Button1 : Inherits Control

#Region " Variables "

        Private State As MouseMode
        Private _SideImage As Image
        Private _SideImageAlign As SideAligin = SideAligin.Left
        Private _RoundRadius As Integer = 30

#End Region

#Region " Constructors "

        Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or _
             ControlStyles.SupportsTransparentBackColor, True)
            DoubleBuffered = True
            BackColor = Color.Transparent
            Font = New Font("Segoe UI", 10)
            Size = New Size(80, 30)
            UpdateStyles()
        End Sub

#End Region

#Region " Properties "

        <Browsable(True)>
        Public Property SideImage As Image
            Get
                Return _SideImage
            End Get
            Set(ByVal value As Image)
                _SideImage = value
                Invalidate()
            End Set
        End Property

        <Browsable(True)>
        Public Property SideImageAlign As SideAligin
            Get
                Return _SideImageAlign
            End Get
            Set(ByVal value As SideAligin)
                _SideImageAlign = value
                Invalidate()
            End Set
        End Property

        Public Property RoundRadius As Integer
            Get
                Return _RoundRadius
            End Get
            Set(ByVal value As Integer)
                _RoundRadius = value
                Invalidate()
            End Set
        End Property

#End Region

#Region " Enumerators "

        Enum SideAligin
            Left
            Right
        End Enum

#End Region

#Region " Draw Control "

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Using B As New Bitmap(Width, Height), G As Graphics = Graphics.FromImage(B)

                With G
                    Dim Rect As New Rectangle(0, 0, Width - 1, Height - 1)
                    .SmoothingMode = SmoothingMode.HighQuality
                    .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                    Select Case State
                        Case MouseMode.NormalMode
                            FillRoundedPath(G, New SolidBrush(Color.FromArgb(251, 251, 251)), Rect, RoundRadius) 'background
                            DrawRoundedPath(G, Color.FromArgb(213, 213, 213), 1, Rect, RoundRadius) 'garis tepi              
                            CentreString(G, Text, Font, New SolidBrush(Color.FromArgb(124, 133, 142)), Rect) 'warna tulisan
                        Case MouseMode.Hovered
                            FillRoundedPath(G, New SolidBrush(Color.FromArgb(251, 251, 251)), Rect, RoundRadius) 'background
                            DrawRoundedPath(G, Color.FromArgb(41, 133, 211), 1, Rect, RoundRadius) 'garis tepi 
                            CentreString(G, Text, Font, New SolidBrush(Color.FromArgb(124, 133, 142)), Rect) 'warna tulisan
                        Case MouseMode.Pushed
                            FillRoundedPath(G, New SolidBrush(Color.FromArgb(41, 133, 211)), Rect, RoundRadius) 'background
                            DrawRoundedPath(G, Color.FromArgb(41, 133, 211), 1, Rect, RoundRadius) 'garis tepi 
                            CentreString(G, Text, Font, New SolidBrush(Color.FromArgb(251, 251, 251)), Rect) 'warna tulisan

                    End Select
                End With

                e.Graphics.DrawImage(B, 0, 0)
                G.Dispose()
                B.Dispose()

            End Using
        End Sub

#End Region

#Region " Events "

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseMode.Hovered : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            State = MouseMode.Pushed : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseMode.Hovered : Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseMode.NormalMode : Invalidate()
        End Sub

#End Region

    End Class

    'vibelander
    Class GroupPanelBox1
        Inherits ThemeContainerControl
        Private _Checked As Boolean
        Sub New()
            AllowTransparent()
        End Sub
        Overrides Sub PaintHook()
            Me.Font = New Font("Segoe UI", 10)
            Me.ForeColor = Color.FromArgb(231, 231, 231) ' warna tulisan
            G.SmoothingMode = SmoothingMode.AntiAlias
            G.Clear(Color.FromArgb(255, 255, 255)) 'Warna dasar background
            G.FillRectangle(New SolidBrush(Color.FromArgb(33, 38, 45)), New Rectangle(0, 0, Width, 30)) 'warna header
            G.DrawLine(New Pen(Color.FromArgb(33, 38, 45)), 1, 1, Width - 2, 1) 'warna top header
            G.DrawRectangle(New Pen(Color.FromArgb(29, 33, 39)), 0, 0, Width - 1, Height - 1) 'warna pinggiran dasar background
            G.DrawRectangle(New Pen(Color.FromArgb(29, 33, 39)), 0, 0, Width - 1, 30) 'warna pinggiran header
            G.DrawString(Text, Font, New SolidBrush(Me.ForeColor), 7, 6)
        End Sub
    End Class

End Namespace