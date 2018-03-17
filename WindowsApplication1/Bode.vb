Imports System.Drawing.Printing

Public Class Bode

    Dim ref1 As Double
    Private Sub Graphique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ref1 = 1
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If ref1 = 1 Then
            PictureBox1.Refresh()
            ref1 = 0
        End If
        bode()
    End Sub
    Sub bode()
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim count As Double 'Compteur des abcisses (fréquence)
        Dim intensité As Double
        Dim freqbas As Integer
        Dim freqhaut As Integer
        Dim facteur_y As Double
        Dim facteur_RLC_série As Double
        Dim facteur_RLC_parallèle As Double
        Dim facteur_rc As Double
        Dim facteur_rL As Double

        Dim x5 As Integer
        Dim y5 As Integer
        Dim y6 As Integer
        Dim y7 As Integer

        Dim aPen As New Pen(Color.Black, 1)
        Dim aPen1 As New Pen(Color.Blue, 1)
        Dim aPen2 As New Pen(Color.Red, 1)
        Dim aPen3 As New Pen(Color.LightGreen, 1)
        Dim aPen4 As New Pen(Color.Tomato, 1)
        Dim axepen As New Pen(Color.White, 1)

        'Coefficients des échelles des abcisses
        facteur_RLC_série = (Val(Principal.fréquence_coupure_haut.Text) + 5000) / 800
        facteur_RLC_série = CInt(facteur_RLC_série)
        facteur_RLC_parallèle = (Val(Principal.fréquence_coupure_haut.Text) + 5000) / 800
        facteur_RLC_parallèle = CInt(facteur_RLC_parallèle)
        facteur_rc = (Val(Principal.Fréquence_coupure_bas.Text) + 5000) / 800
        facteur_rc = CInt(facteur_rc)
        facteur_rL = (Val(Principal.fréquence_coupure_haut.Text) + 10000) / 800
        facteur_rL = CInt(facteur_rL)
        freqbas = CInt((Val(Principal.Fréquence_coupure_bas.Text) / facteur_RLC_série))
        freqhaut = CInt((Val(Principal.fréquence_coupure_haut.Text) / facteur_RLC_série))

        'Dessin de l'axe des abcisses
        g.DrawLine(axepen, 0, 520, 800, 520)
        For abcisse = 0 To 800 Step 10
            g.DrawLine(axepen, abcisse, 518, abcisse, 522)
        Next
        For abcisse = 0 To 800 Step 50
            g.DrawLine(axepen, abcisse, 515, abcisse, 525)
        Next

        'Calcul des lignes de fréquences de coupure
        If Principal.RLC_série.Checked = True Then
            facteur_y = (Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) / Math.Sqrt(2) / 350
            y6 = -CInt(((Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) / Math.Sqrt(2)) / facteur_y) + 520
        End If
        If Principal.RLC_parallèle.Checked = True Then
            facteur_y = (Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) / Math.Sqrt(2) / 10000
            y6 = -CInt((((Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) * Math.Sqrt(2)) / facteur_y) + 520)
        End If
        If Principal.RC_série.Checked = True Then
            facteur_y = Val(Principal.Tension.Text) / 350
            y6 = -CInt(Val(Principal.Tension.Text) / Math.Sqrt(2) / facteur_y) + 520
        End If
        If Principal.RL_série.Checked = True Then
            facteur_y = Val(Principal.Tension.Text) / 350
            y6 = -CInt(Val(Principal.Tension.Text) / Math.Sqrt(2) / facteur_y) + 520
        End If

        'Calculs et dessins des diagrammes de Bode
        If Principal.RLC_série.Checked = True Then
            For count = 1 To (Val(Principal.fréquence_coupure_haut.Text) + 5000) Step facteur_RLC_série
                Principal.Fréquence.Text = count
                Principal.calcul_RLC_série()
                y5 = Principal.intensité_vraie / facteur_y
                x5 = count / facteur_RLC_série
                x5 = CInt(x5)
                y5 = -CInt(y5) + 520
                'Dessin de la courbe
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
                If count >= Val(Principal.Fréquence_coupure_bas.Text) And count <= Val(Principal.fréquence_coupure_haut.Text) Then
                    g.DrawLine(aPen3, x5, y5, x5, 520)
                End If
                REM If count <= Val(Principal.Fréquence_coupure_bas.Text) Or count >= Val(Principal.fréquence_coupure_haut.Text) Then
                REM g.DrawLine(aPen4, x5, y5, x5, 520)
                REM End If
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
            Next
            g.DrawLine(aPen2, freqbas, y6, freqhaut, y6)   'ligne de la bande passante
            g.DrawLine(aPen2, freqbas, y6, freqbas, 520)   'ligne verticale fréquence coupure bas
            g.DrawLine(aPen2, freqhaut, y6, freqhaut, 520) 'ligne verticale fréquence coupure bas

            g.DrawString(Principal.Fréquence_coupure_bas.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqbas - 60, 525))
            g.DrawString(Principal.fréquence_coupure_haut.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqhaut, 525))
        End If

        If Principal.RLC_parallèle.Checked = True Then
            For count = 1 To (Val(Principal.fréquence_coupure_haut.Text) + 5000) Step facteur_RLC_parallèle
                Principal.Fréquence.Text = count
                Principal.calcul_RLC_parallèle()
                y5 = Principal.intensité_vraie / facteur_y
                x5 = count / facteur_RLC_parallèle
                x5 = CInt(x5)
                y5 = -CInt(y5) + 520
                'Dessin de la courbe
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
                If count <= Val(Principal.Fréquence_coupure_bas.Text) Or count >= Val(Principal.fréquence_coupure_haut.Text) Then
                    g.DrawLine(aPen3, x5, y5, x5, 520)
                End If
                If count >= Val(Principal.Fréquence_coupure_bas.Text) And count <= (Val(Principal.Fréquence_coupure_bas.Text) + 50) Then
                    y7 = y5
                End If
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
            Next
            g.DrawLine(aPen2, freqbas, y7, freqhaut, y7)   'ligne de la bande passante
            g.DrawLine(aPen2, freqbas, y7, freqbas, 520)   'ligne verticale fréquence coupure bas
            g.DrawLine(aPen2, freqhaut, y7, freqhaut, 520) 'ligne verticale fréquence coupure bas

            g.DrawString(Principal.Fréquence_coupure_bas.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqbas - 60, 525))
            g.DrawString(Principal.fréquence_coupure_haut.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqhaut, 525))
        End If

        If Principal.RC_série.Checked = True Then
            For count = 1 To (Val(Principal.Fréquence_coupure_bas.Text) + 5000) Step facteur_rc
                Principal.Fréquence.Text = count
                Principal.calcul_RC_série()
                y5 = Principal.tension_uc_vraie / facteur_y
                x5 = count / facteur_rc
                x5 = CInt(x5)
                y5 = -CInt(y5) + 520
                g.DrawLine(aPen, x5, y5, x5, y5 + 1) 'Dessin de la courbe
                If count <= Val(Principal.Fréquence_coupure_bas.Text) Then
                    g.DrawLine(aPen3, x5, y5, x5, 520)
                End If
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
            Next
            freqbas = CInt((Val(Principal.Fréquence_coupure_bas.Text) / facteur_rc))
            g.DrawLine(aPen2, freqbas, y6, freqbas, 520)   'ligne verticale fréquence coupure bas
            g.DrawString(Principal.Fréquence_coupure_bas.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqbas, 525))
        End If
        If Principal.RL_série.Checked = True Then
            For count = 1 To (Val(Principal.fréquence_coupure_haut.Text) + 10000) Step facteur_rL
                Principal.Fréquence.Text = count
                Principal.calcul_RL_série()
                y5 = Principal.tension_ul_vraie / facteur_y
                x5 = count / facteur_rL
                x5 = CInt(x5)
                y5 = -CInt(y5) + 520
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
                If count >= Val(Principal.fréquence_coupure_haut.Text) Then
                    g.DrawLine(aPen3, x5, y5, x5, 520)
                End If
                g.DrawLine(aPen, x5, y5, x5, y5 + 1)
            Next
            freqhaut = CInt((Val(Principal.fréquence_coupure_haut.Text) / facteur_rL))
            g.DrawLine(aPen2, freqhaut, y6, freqhaut, 520)   'ligne verticale fréquence coupure bas
            g.DrawString(Principal.fréquence_coupure_haut.Text, New Font("Tahoma", 8), Brushes.Black, New Point(freqhaut, 525))
        End If

        'Dessins des textes
        If Principal.RLC_série.Checked = True Then
            Principal.calcul_RLC_série()
            intensité = Math.Round((Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) / Math.Sqrt(2), 2)
            g.DrawString("i=" & intensité & " mA", New Font("Tahoma", 8), Brushes.Black, New Point(CInt((freqhaut + freqbas) / 2.1), y6 + 5))
            g.DrawString("Filtre passe-bande", New Font("Tahoma", 16), Brushes.Blue, New Point(300, 5))
        End If
        If Principal.RLC_parallèle.Checked = True Then
            Principal.calcul_RLC_parallèle()
            intensité = Math.Round((Val(Principal.Tension.Text) / Val(Principal.Résistance.Text) * 1000) * Math.Sqrt(2), 2)
            g.DrawString("i=" & intensité & " mA", New Font("Tahoma", 8), Brushes.Black, New Point(CInt((freqhaut + freqbas) / 2.1), y7 - 15))
            g.DrawString("Filtre coupe-bande", New Font("Tahoma", 16), Brushes.Blue, New Point(300, 5))
        End If
        If Principal.RC_série.Checked = True Then
            Principal.calcul_RC_série()
            g.DrawString("UC=" & Math.Round(Val(Principal.Tension.Text) / Math.Sqrt(2), 2) & " V", New Font("Tahoma", 8), Brushes.Black, New Point(CInt(freqbas), y6 - 10))
            g.DrawString("Filtre passe-bas", New Font("Tahoma", 16), Brushes.Blue, New Point(300, 5))
        End If
        If Principal.RL_série.Checked = True Then
            Principal.calcul_RL_série()
            g.DrawString("UL=" & Math.Round(Val(Principal.Tension.Text) / Math.Sqrt(2), 2) & " V", New Font("Tahoma", 8), Brushes.Black, New Point(CInt(freqhaut) - 10, y6 - 20))
            g.DrawString("Filtre passe-haut", New Font("Tahoma", 16), Brushes.Blue, New Point(300, 5))
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