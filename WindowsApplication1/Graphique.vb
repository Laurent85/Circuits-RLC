Imports System.Drawing.Printing

Public Class Graphique
    Dim ref1 As Double
    Dim échelle As Double
    Dim max As Double

    Private Sub Graphique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ref1 = 1
        'Recherche du maximum pour déterminer l'échelle
        If Principal.RLC_parallèle.Checked = True Then
            If Val(Principal.Intensité.Text) > Val(Principal.Tension_Ur.Text) Then
                max = Val(Principal.Intensité.Text)
            Else
                max = Val(Principal.Tension_Ur.Text)
            End If
            If Val(Principal.Tension_UL.Text) > max Then
                max = Val(Principal.Tension_UL.Text)
            End If
            If Val(Principal.Tension_Uc.Text) > max Then
                max = Val(Principal.Tension_Uc.Text)
            End If
        End If

        If Principal.RLC_série.Checked = True Or Principal.RC_série.Checked = True Or Principal.RL_série.Checked = True Then
            If Val(Principal.Tension.Text) > Val(Principal.Tension_Ur.Text) Then
                max = Val(Principal.Intensité.Text)
            Else
                max = Val(Principal.Tension_Ur.Text)
            End If
            If Val(Principal.Tension_UL.Text) > max Then
                max = Val(Principal.Tension_UL.Text)
            End If
            If Val(Principal.Tension_Uc.Text) > max Then
                max = Val(Principal.Tension_Uc.Text)
            End If
        End If

        échelle = CInt(max / 16)
        If échelle = 0 Then
            échelle = 1
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Permet d'obtenir le graphique dès l'ouveture du windows form
        If ref1 = 1 Then
            PictureBox1.Refresh()
            ref1 = 0
        End If
        courbe()
    End Sub
    Sub courbe()
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim Pi As Double
        Dim count As Double
        Dim abcisse As Integer
        Dim ordonnée As Integer

        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        Dim x4 As Integer

        Dim y1 As Integer 'Courbe UR
        Dim y2 As Integer 'Courbe U
        Dim y3 As Integer 'Courbe UL
        Dim y4 As Integer 'Courbe UC

        Dim aPen As New Pen(Color.Black, 1)
        Dim aPen1 As New Pen(Color.Blue, 1)
        Dim aPen2 As New Pen(Color.Red, 1)
        Dim aPen3 As New Pen(Color.Green, 1)
        Dim axepen As New Pen(Color.White, 1)

        Pi = Math.PI

        'Dessin des axes
        PictureBox1.CreateGraphics.DrawLine(axepen, 0, 180, 1000, 180) 'Axe des abcisses
        PictureBox1.CreateGraphics.DrawLine(axepen, 500, 0, 500, 380)  'Axe des ordonnées
        'Dessin des graduations
        For abcisse = 0 To 1000 Step 10
            PictureBox1.CreateGraphics.DrawLine(axepen, abcisse, 178, abcisse, 182)
        Next
        For abcisse = 0 To 1000 Step 50
            PictureBox1.CreateGraphics.DrawLine(axepen, abcisse, 175, abcisse, 185)
        Next
        For ordonnée = 0 To 360 Step 10
            PictureBox1.CreateGraphics.DrawLine(axepen, 497, ordonnée, 503, ordonnée)
        Next
        For ordonnée = 30 To 360 Step 50
            PictureBox1.CreateGraphics.DrawLine(axepen, 0, ordonnée, 1000, ordonnée)
        Next

        For count = 0 To 12 * Pi Step 0.005
            'Calcul de la position x
            x1 = count * (1000 / (12 * Pi))
            x2 = count * (1000 / (12 * Pi))
            x3 = count * (1000 / (12 * Pi))
            x4 = count * (1000 / (12 * Pi))

            'Conversion en entiers
            x1 = CInt(x1)
            x2 = CInt(x2)
            x3 = CInt(x3)
            x4 = CInt(x4)

            'Tension Ur
            y1 = -(Math.Sin(count) * 10 * Val(Principal.Tension_Ur.Text) / échelle) + 180
            If Principal.RLC_série.Checked = True Or Principal.RC_série.Checked = True Or Principal.RL_série.Checked = True Then
                'Tension U
                y2 = -(Math.Sin(count + (Val(Principal.Déphasage.Text) * Pi / 180)) * 10 * Val(Principal.Tension.Text) / échelle) + 180
            End If
            If Principal.RLC_parallèle.Checked = True Then
                'Intensité i
                y2 = -(Math.Sin(count + (Val(Principal.Déphasage.Text) * Pi / 180)) * 10 * Val(Principal.Intensité.Text) / échelle) + 180
            End If
            If Principal.RLC_série.Checked = True Or Principal.RC_série.Checked = True Or Principal.RL_série.Checked = True Then
                'Tensions UL et UC
                y3 = -(Math.Sin(count + (Pi / 2)) * 10 * Val(Principal.Tension_UL.Text) / échelle) + 180
                y4 = -(Math.Sin(count - (Pi / 2)) * 10 * Val(Principal.Tension_Uc.Text) / échelle) + 180
            End If
            If Principal.RLC_parallèle.Checked = True Then
                'Tensions UL et UC
                y3 = -(Math.Sin(count - (Pi / 2)) * 10 * Val(Principal.Tension_UL.Text) / échelle) + 180
                y4 = -(Math.Sin(count + (Pi / 2)) * 10 * Val(Principal.Tension_Uc.Text) / échelle) + 180
            End If

            'Conversion en entiers
            y1 = CInt(y1)
            y2 = CInt(y2)
            y3 = CInt(y3)
            y4 = CInt(y4)

            'Dessin des courbes
            g.DrawLine(aPen, x1, y1, x1, y1 + 1)
            g.DrawLine(aPen1, x2, y2, x2, y2 + 1)
            If Principal.RLC_série.Checked = True Or Principal.RL_série.Checked = True Or Principal.RLC_parallèle.Checked = True Then
                g.DrawLine(aPen2, x3, y3, x3, y3 + 1)
            End If
            If Principal.RLC_série.Checked = True Or Principal.RC_série.Checked = True Or Principal.RLC_parallèle.Checked = True Then
                g.DrawLine(aPen3, x4, y4, x4, y4 + 1)
            End If
        Next

        'Légendes
        If Principal.RLC_parallèle.Checked = True Then
            g.DrawString("iL", New Font("Tahoma", 10), Brushes.Red, New Point(200, 5))
            g.DrawString("iC", New Font("Tahoma", 10), Brushes.Green, New Point(250, 5))
            g.DrawString("iR", New Font("Tahoma", 10), Brushes.Black, New Point(300, 5))
            g.DrawString("i", New Font("Tahoma", 10), Brushes.Blue, New Point(350, 5))
            g.DrawString("échelle (/" & échelle & ")", New Font("Tahoma", 8), Brushes.White, New Point(900, 340))
        Else
            If Principal.RLC_série.Checked = True Or Principal.RL_série.Checked = True Or Principal.RLC_parallèle.Checked = True Then
                g.DrawString("UL", New Font("Tahoma", 10), Brushes.Red, New Point(200, 5))
            End If
            If Principal.RLC_série.Checked = True Or Principal.RC_série.Checked = True Or Principal.RLC_parallèle.Checked = True Then
                g.DrawString("UC", New Font("Tahoma", 10), Brushes.Green, New Point(250, 5))
            End If
            g.DrawString("UR", New Font("Tahoma", 10), Brushes.Black, New Point(300, 5))
            g.DrawString("U", New Font("Tahoma", 10), Brushes.Blue, New Point(350, 5))
            g.DrawString("échelle (/" & échelle & ")", New Font("Tahoma", 8), Brushes.White, New Point(900, 340))
        End If
    End Sub

    Friend WithEvents prntDoc As New PrintDocument()
    Private Print_Image As Image
    Declare Auto Function BitBlt Lib "GDI32.DLL" ( _
    ByVal hdcDest As IntPtr, _
    ByVal nXDest As Integer, _
    ByVal nYDest As Integer, _
    ByVal nWidth As Integer, _
    ByVal nHeight As Integer, _
    ByVal hdcSrc As IntPtr, _
    ByVal nXSrc As Integer, _
    ByVal nYSrc As Integer, _
    ByVal dwRop As Int32) As Boolean
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        'print picture   
        Dim prnDialog As New PrintDialog()
        'Get a Graphics Object from the form   
        Dim FormG As Graphics = Me.PictureBox1.CreateGraphics
        'Create a bitmap from that graphics   
        Dim i As New Bitmap(Me.Width, Me.Height, FormG)
        'Create a Graphics object in memory from that bitmap   
        Dim memG As Graphics = Graphics.FromImage(i)
        'get the IntPtr's of the graphics   
        Dim HDC1 As IntPtr = FormG.GetHdc
        Dim HDC2 As IntPtr = memG.GetHdc
        'get the picture   
        BitBlt(HDC2, 0, 0, Me.PictureBox1.Width, Me.PictureBox1.Height, HDC1, 0, 0, 13369376)
        'Clone the bitmap so we can dispose this one   
        Me.Print_Image = i.Clone()
        'Clean Up   
        FormG.ReleaseHdc(HDC1)
        memG.ReleaseHdc(HDC2)
        FormG.Dispose()
        memG.Dispose()
        i.Dispose()

        prnDialog.Document = prntDoc

        ' Optional Dialog:   
        Dim r As DialogResult = prnDialog.ShowDialog
        If r = DialogResult.OK Then
            prntDoc.Print()
        End If
    End Sub

    Private Sub prntDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prntDoc.PrintPage
        e.Graphics.DrawImage(Print_Image, 0, 0)
    End Sub

End Class