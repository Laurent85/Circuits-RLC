Imports System.Drawing.Drawing2D

Public Class Principal

    Public impédance_vraie As Double
    Dim réactance_cap_vraie As Double
    Dim réactance_ind_vraie As Double
    Dim résistance_vraie As Double
    Public intensité_vraie As Double
    Public tension_uc_vraie As Double
    Public tension_ul_vraie As Double
    Dim discriminant_vrai As Double
    Public conductance As Double
    Dim susceptance_cap As Double
    Dim susceptance_ind As Double
    Dim admittance As Double
    Dim échelle As Double = 1
    Dim ref As Double
    Dim max As Double

    Private Sub Fréquence_TextChanged(sender As Object, e As EventArgs) Handles Fréquence.TextChanged
        Pulsation.Text = Math.Round((Val(Fréquence.Text) * Math.PI * 2), 2) & " " & "rad/s"
        Période.Text = Format((1 / (Val(Fréquence.Text))), "0.00E+00") & " " & "s"
        If RLC_série.Checked = True Then
            calcul_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            calcul_RLC_parallèle()
        End If
        If RC_série.Checked = True Then
            calcul_RC_série()
        End If
        If RL_série.Checked = True Then
            calcul_RL_série()
        End If
    End Sub

    Private Sub Tension_TextChanged(sender As Object, e As EventArgs) Handles Tension.TextChanged
        If RLC_série.Checked = True Then
            calcul_RLC_série()
            échelle_fresnel()
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            calcul_RLC_parallèle()
            échelle_fresnel()
            Fresnel_RLC_parallèle()
        End If
        If RC_série.Checked = True Then
            calcul_RC_série()
            échelle_fresnel()
            Fresnel_RC_série()
        End If
        If RL_série.Checked = True Then
            calcul_RL_série()
            échelle_fresnel()
            Fresnel_RL_série()
        End If
    End Sub

    Private Sub Résistance_TextChanged(sender As Object, e As EventArgs) Handles Résistance.TextChanged
        If RLC_série.Checked = True Then
            calcul_RLC_série()
            échelle_fresnel()
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            calcul_RLC_parallèle()
            échelle_fresnel()
            Fresnel_RLC_parallèle()
        End If
        If RC_série.Checked = True Then
            calcul_RC_série()
            échelle_fresnel()
            Fresnel_RC_série()
        End If
        If RL_série.Checked = True Then
            calcul_RL_série()
            échelle_fresnel()
            Fresnel_RL_série()
        End If
    End Sub

    Private Sub Capacité_TextChanged(sender As Object, e As EventArgs) Handles Capacité.TextChanged
        If RLC_série.Checked = True Then
            calcul_RLC_série()
            échelle_fresnel()
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            calcul_RLC_parallèle()
            échelle_fresnel()
            Fresnel_RLC_parallèle()
        End If
        If RC_série.Checked = True Then
            calcul_RC_série()
            échelle_fresnel()
            Fresnel_RC_série()
        End If
    End Sub

    Private Sub Inductance_TextChanged(sender As Object, e As EventArgs) Handles Inductance.TextChanged
        If RLC_série.Checked = True Then
            calcul_RLC_série()
            échelle_fresnel()
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            calcul_RLC_parallèle()
            échelle_fresnel()
            Fresnel_RLC_parallèle()
        End If
        If RL_série.Checked = True Then
            calcul_RL_série()
            échelle_fresnel()
            Fresnel_RL_série()
        End If
    End Sub

    Sub Fresnel_RLC_série()
        Dim g As Graphics = Fresnel.CreateGraphics
        g.Clear(Color.LightGray)

        Dim pen As New Pen(Color.FromArgb(255, 50, 40, 80), 4)
        Dim pen1 As New Pen(Color.FromArgb(255, 0, 255, 0), 4)
        Dim pen2 As New Pen(Color.FromArgb(255, 255, 0, 0), 4)
        Dim pen3 As New Pen(Color.FromArgb(255, 0, 0, 255), 4)
        pen.StartCap = LineCap.ArrowAnchor
        pen1.StartCap = LineCap.ArrowAnchor
        pen2.StartCap = LineCap.ArrowAnchor
        pen3.StartCap = LineCap.ArrowAnchor
        If (Val(Tension_Uc.Text)) < 10000 Then
            Dim point1 As New Point(Val(Tension_Ur.Text) * échelle, 140) REM fin flêche
            Dim point2 As New Point(0, 140)                        REM début flêche
            Dim point3 As New Point(5 + Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140)
            Dim point4 As New Point(5 + Val(Tension_Ur.Text) * échelle, 140)
            Dim point5 As New Point(15 + Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point6 As New Point(15 + Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140) REM début flêche
            Dim point7 As New Point(15 + Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point8 As New Point(0, 140) REM début flêche
            g = Me.Fresnel.CreateGraphics
            g.DrawLine(pen, point1, point2)
            g.DrawLine(pen1, point3, point4)
            g.DrawLine(pen2, point5, point6)
            g.DrawLine(pen3, point7, point8)
        End If
        Diagramme_texte.Text = "Diagramme des tensions"
    End Sub

    Sub Fresnel_RLC_parallèle()
        Dim g As Graphics = Fresnel.CreateGraphics
        g.Clear(Color.LightGray)

        Dim pen As New Pen(Color.FromArgb(255, 50, 40, 80), 4)
        Dim pen1 As New Pen(Color.FromArgb(255, 255, 0, 0), 4)
        Dim pen2 As New Pen(Color.FromArgb(255, 0, 255, 0), 4)
        Dim pen3 As New Pen(Color.FromArgb(255, 0, 0, 255), 4)
        pen.StartCap = LineCap.ArrowAnchor
        pen1.StartCap = LineCap.ArrowAnchor
        pen2.StartCap = LineCap.ArrowAnchor
        pen3.StartCap = LineCap.ArrowAnchor
        If (Val(Tension_Uc.Text)) < 10000 Then
            Dim point1 As New Point(Val(Tension_Ur.Text) * échelle, 140) REM fin flêche
            Dim point2 As New Point(0, 140)                        REM début flêche
            Dim point3 As New Point(5 + Val(Tension_Ur.Text) * échelle, (Val(Tension_UL.Text) * échelle) + 140)
            Dim point4 As New Point(5 + Val(Tension_Ur.Text) * échelle, 140)
            Dim point5 As New Point(15 + Val(Tension_Ur.Text) * échelle, ((Val(Tension_UL.Text) * échelle) + 140 - Val(Tension_Uc.Text) * échelle)) REM fin flêche
            Dim point6 As New Point(15 + Val(Tension_Ur.Text) * échelle, (Val(Tension_UL.Text) * échelle) + 140) REM début flêche
            Dim point7 As New Point(15 + Val(Tension_Ur.Text) * échelle, ((Val(Tension_UL.Text) * échelle) + 140 - Val(Tension_Uc.Text) * échelle)) REM fin flêche
            Dim point8 As New Point(0, 140) REM début flêche
            g = Me.Fresnel.CreateGraphics
            g.DrawLine(pen, point1, point2)
            g.DrawLine(pen1, point3, point4)
            g.DrawLine(pen2, point5, point6)
            g.DrawLine(pen3, point7, point8)
        End If
        Diagramme_texte.Text = "Diagramme des intensités"
    End Sub

    Sub Fresnel_RC_série()
        Dim g As Graphics = Fresnel.CreateGraphics
        g.Clear(Color.LightGray)

        Dim pen As New Pen(Color.FromArgb(255, 50, 40, 80), 4)
        Dim pen1 As New Pen(Color.FromArgb(255, 0, 255, 0), 4)
        Dim pen2 As New Pen(Color.FromArgb(255, 255, 0, 0), 4)
        Dim pen3 As New Pen(Color.FromArgb(255, 0, 0, 255), 4)
        pen.StartCap = LineCap.ArrowAnchor
        pen1.StartCap = LineCap.ArrowAnchor
        pen2.StartCap = LineCap.ArrowAnchor
        pen3.StartCap = LineCap.ArrowAnchor
        If (Val(Tension_Uc.Text)) < 10000 Then
            Dim point1 As New Point(Val(Tension_Ur.Text) * échelle, 140) REM fin flêche
            Dim point2 As New Point(0, 140)                        REM début flêche
            Dim point3 As New Point(5 + Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140)
            Dim point4 As New Point(5 + Val(Tension_Ur.Text) * échelle, 140)
            Dim point5 As New Point(15 + Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point6 As New Point(15 + Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140) REM début flêche
            Dim point7 As New Point(Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point8 As New Point(0, 140) REM début flêche
            g = Me.Fresnel.CreateGraphics
            g.DrawLine(pen, point1, point2)
            g.DrawLine(pen1, point3, point4)
            g.DrawLine(pen2, point5, point6)
            g.DrawLine(pen3, point7, point8)
        End If
        Diagramme_texte.Text = "Diagramme des tensions"
    End Sub

    Sub Fresnel_RL_série()
        Dim g As Graphics = Fresnel.CreateGraphics
        g.Clear(Color.LightGray)

        Dim pen As New Pen(Color.FromArgb(255, 50, 40, 80), 4)
        Dim pen1 As New Pen(Color.FromArgb(255, 0, 255, 0), 4)
        Dim pen2 As New Pen(Color.FromArgb(255, 255, 0, 0), 4)
        Dim pen3 As New Pen(Color.FromArgb(255, 0, 0, 255), 4)
        pen.StartCap = LineCap.ArrowAnchor
        pen1.StartCap = LineCap.ArrowAnchor
        pen2.StartCap = LineCap.ArrowAnchor
        pen3.StartCap = LineCap.ArrowAnchor
        If (Val(Tension_Uc.Text)) < 10000 Then
            Dim point1 As New Point(Val(Tension_Ur.Text) * échelle, 140) REM fin flêche
            Dim point2 As New Point(0, 140)                        REM début flêche
            Dim point3 As New Point(5 + Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140)
            Dim point4 As New Point(5 + Val(Tension_Ur.Text) * échelle, 140)
            Dim point5 As New Point(Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point6 As New Point(Val(Tension_Ur.Text) * échelle, (Val(Tension_Uc.Text) * échelle) + 140) REM début flêche
            Dim point7 As New Point(Val(Tension_Ur.Text) * échelle, ((Val(Tension_Uc.Text) * échelle) + 140 - Val(Tension_UL.Text) * échelle)) REM fin flêche
            Dim point8 As New Point(0, 140) REM début flêche
            g = Me.Fresnel.CreateGraphics
            g.DrawLine(pen, point1, point2)
            g.DrawLine(pen1, point3, point4)
            g.DrawLine(pen2, point5, point6)
            g.DrawLine(pen3, point7, point8)
        End If
        Diagramme_texte.Text = "Diagramme des tensions"
    End Sub

    Sub échelle_fresnel()
        Dim maxi As Double
        If RLC_série.Checked Then
            If Val(Tension_Ur.Text) > Val(Tension_Uc.Text) Then
                maxi = Val(Tension_Ur.Text)
            Else
                maxi = Val(Tension_Uc.Text)
            End If
            If Val(Tension_UL.Text) > maxi Then
                maxi = Val(Tension_UL.Text)
            End If

            If maxi = Val(Tension_Ur.Text) Then
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (250 / maxi)
                    If (Val(Tension_UL.Text) * échelle) > 130 Or (Val(Tension_Uc.Text) * échelle) > 130 Then
                        échelle = (130 / maxi)
                    End If
                End If
            Else
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (130 / maxi)
                End If
            End If
        End If

        If RLC_parallèle.Checked Then
            If Val(Tension_Ur.Text) > Val(Tension_Uc.Text) Then
                maxi = Val(Tension_Ur.Text)
            Else
                maxi = Val(Tension_Uc.Text)
            End If
            If Val(Tension_UL.Text) > maxi Then
                maxi = Val(Tension_UL.Text)
            End If

            If maxi = Val(Tension_Ur.Text) Then
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (250 / maxi)
                    If (Val(Tension_UL.Text) * échelle) Or (Val(Tension_Uc.Text) * échelle) > 130 Then
                        échelle = (130 / maxi)
                    End If
                End If
            Else
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (120 / maxi)
                End If
            End If
        End If
        If RC_série.Checked Then
            If Val(Tension_Ur.Text) > Val(Tension_Uc.Text) Then
                maxi = Val(Tension_Ur.Text)
            Else
                maxi = Val(Tension_Uc.Text)
            End If
            If maxi = Val(Tension_Ur.Text) Then
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (250 / maxi)
                    If (Val(Tension_UL.Text) * échelle) > 130 Or (Val(Tension_Uc.Text) * échelle) > 130 Then
                        échelle = (130 / maxi)
                    End If
                End If
            Else
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (130 / maxi)
                End If
            End If
        End If
        If RL_série.Checked Then
            If Val(Tension_Ur.Text) > Val(Tension_UL.Text) Then
                maxi = Val(Tension_Ur.Text)
            Else
                maxi = Val(Tension_UL.Text)
            End If
            If maxi = Val(Tension_Ur.Text) Then
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (250 / maxi)
                    If (Val(Tension_UL.Text) * échelle) > 130 Or (Val(Tension_Uc.Text) * échelle) > 130 Then
                        échelle = (130 / maxi)
                    End If
                End If
            Else
                If maxi = 0 Then
                    échelle = 1
                Else
                    échelle = (130 / maxi)
                End If
            End If
        End If
        Echelle.Value = CInt(échelle)
    End Sub

    Sub calcul_RLC_série()
        visibilité()
        Résistance1.Text = Val(Résistance.Text) & " " & "Ω"
        réactance_cap_vraie = 1 / (2 * Math.PI * Val(Fréquence.Text) * Val(Capacité.Text))
        réactance_ind_vraie = 2 * Math.PI * Val(Fréquence.Text) * Val(Inductance.Text)
        résistance_vraie = Val(Résistance.Text)
        impédance_vraie = Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_ind_vraie) - Val(réactance_cap_vraie)) * (Val(réactance_ind_vraie) - Val(réactance_cap_vraie))))
        Réactance_capacitive.Text = Math.Round(1 / (2 * Math.PI * Val(Fréquence.Text) * Val(Capacité.Text)), 2) & " " & "Ω"
        Réactance_inductive.Text = Math.Round(2 * Math.PI * Val(Fréquence.Text) * Val(Inductance.Text), 2) & " " & "Ω"
        Impédance.Text = Math.Round(Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_ind_vraie) - Val(réactance_cap_vraie)) * (Val(réactance_ind_vraie) - Val(réactance_cap_vraie)))), 2) & " " & "Ω"
        Fréquence_résonance.Text = Math.Round(1 / (2 * Math.PI * Math.Sqrt(Val(Inductance.Text) * Val(Capacité.Text))), 2) & " " & "Hz"
        Fréquence_coupure_bas.Text = Math.Round((Math.Sqrt((((Val(Résistance.Text)) / (2 * Val(Inductance.Text))) ^ 2) + (1 / (Val(Inductance.Text) * Val(Capacité.Text)))) - (Val(Résistance.Text)) / (2 * Val(Inductance.Text))) / (2 * Math.PI), 2) & " " & "Hz"
        fréquence_coupure_haut.Text = Math.Round((Math.Sqrt((((Val(Résistance.Text)) / (2 * Val(Inductance.Text))) ^ 2) + (1 / (Val(Inductance.Text) * Val(Capacité.Text)))) + (Val(Résistance.Text)) / (2 * Val(Inductance.Text))) / (2 * Math.PI), 2) & " " & "Hz"
        Bande_passante.Text = Math.Round((Val(Résistance.Text) / Val(Inductance.Text)) / (2 * Math.PI), 2) & " " & "Hz"
        Facteur_qualité.Text = Math.Round(Val(Fréquence_résonance.Text) / Val(Bande_passante.Text), 2)
        Tension_Ur.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_Uc.Text = Math.Round((Val(réactance_cap_vraie) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_UL.Text = Math.Round((Val(réactance_ind_vraie) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_Ur_eff.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_Uc_eff.Text = Math.Round((Val(réactance_cap_vraie) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_UL_eff.Text = Math.Round((Val(réactance_ind_vraie) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_Uc_texte.Text = "Tension UC"
        Tension_UL_texte.Text = "Tension UL"
        Tension_Ur_texte.Text = "Tension UR"
        Titre.Text = "Le circuit RLC série - Filtre passe-bande"
        Tension_efficace.Text = Math.Round((Val(Tension.Text) / Math.Sqrt(2)), 2) & " " & "V"
        Intensité.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie), 2) & " " & "mA"
        intensité_vraie = 1000 * Val(Tension.Text) / Val(impédance_vraie)
        intensité_eff.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2), 2) & " " & "mA"
        échelle_fresnel()
        Fresnel_RLC_série()
        If (Val(Réactance_capacitive.Text) > Val(Réactance_inductive.Text)) Then
            Déphasage.Text = -Math.Round((Math.Acos(Val(Résistance.Text) / Val(impédance_vraie)) * 180 / Math.PI), 2) & "°"
            Déphasage_texte.ForeColor = Color.Green
            Puissance_réactive_texte.ForeColor = Color.Green
            Circuit.ForeColor = Color.Green
            Circuit.Text = "Le circuit est capacitif ; la tension est en retard sur le courant"
        ElseIf (Val(Réactance_capacitive.Text) < Val(Réactance_inductive.Text)) Then
            Déphasage.Text = "+" & Math.Round((Math.Acos(Val(Résistance.Text) / Val(impédance_vraie)) * 180 / Math.PI), 2) & "°"
            Déphasage_texte.ForeColor = Color.Red
            Puissance_réactive_texte.ForeColor = Color.Red
            Circuit.ForeColor = Color.Red
            Circuit.Text = "Le circuit est inductif ; la tension est en avance sur le courant"
        ElseIf (Val(Réactance_capacitive.Text) = Val(Réactance_inductive.Text)) Then
            Déphasage.Text = "0°"
            Déphasage_texte.ForeColor = Color.Blue
            Puissance_réactive_texte.ForeColor = Color.Blue
            Circuit.ForeColor = Color.Blue
            Circuit.Text = "Le circuit résonne ; la tension est en phase avec le courant"
        End If
        Puissance_active.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Val(Résistance.Text) / Val(impédance_vraie)), 4) & " " & "W"
        Puissance_réactive.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * ((Val(réactance_ind_vraie) - Val(réactance_cap_vraie)) / résistance_vraie), 4) & " " & "VAR"
        Puissance_apparente.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)), 4) & " " & "VA"
        Facteur_puissance.Text = Math.Round(Val(Résistance.Text) / Val(impédance_vraie), 3)
    End Sub

    Sub calcul_RLC_parallèle()
        visibilité()
        Résistance1.Text = Val(Résistance.Text) & " " & "Ω"
        conductance = 1 / Val(Résistance.Text)
        susceptance_cap = 2 * Math.PI * Val(Fréquence.Text) * Val(Capacité.Text)
        susceptance_ind = 1 / (2 * Math.PI * Val(Fréquence.Text) * Val(Inductance.Text))
        admittance = Math.Sqrt((conductance * conductance) + ((susceptance_ind - susceptance_cap) * (susceptance_ind - susceptance_cap)))
        réactance_cap_vraie = 1 / susceptance_cap
        réactance_ind_vraie = 1 / susceptance_ind
        résistance_vraie = Val(Résistance.Text)
        impédance_vraie = 1 / admittance
        intensité_vraie = Val(Tension.Text) / impédance_vraie
        Réactance_capacitive.Text = Math.Round(1 / susceptance_cap, 2) & " " & "Ω"
        Réactance_inductive.Text = Math.Round(1 / susceptance_ind, 2) & " " & "Ω"
        Impédance.Text = Math.Round(1 / admittance, 2) & " " & "Ω"
        Fréquence_résonance.Text = Math.Round(1 / (2 * Math.PI * Math.Sqrt(Val(Inductance.Text) * Val(Capacité.Text))), 2) & " " & "Hz"
        Fréquence_coupure_bas.Text = Math.Round((Math.Sqrt((((1) / (2 * Val(Résistance.Text) * Val(Capacité.Text))) ^ 2) + (1 / (Val(Inductance.Text) * Val(Capacité.Text)))) - (1) / (2 * Val(Résistance.Text) * Val(Capacité.Text))) / (2 * Math.PI), 2) & " " & "Hz"
        fréquence_coupure_haut.Text = Math.Round((Math.Sqrt((((1) / (2 * Val(Résistance.Text) * Val(Capacité.Text))) ^ 2) + (1 / (Val(Inductance.Text) * Val(Capacité.Text)))) + (1) / (2 * Val(Résistance.Text) * Val(Capacité.Text))) / (2 * Math.PI), 2) & " " & "Hz"
        Bande_passante.Text = Math.Round(1 / (Val(Résistance.Text) * Val(Capacité.Text) * 2 * Math.PI), 2) & " " & "Hz"
        Facteur_qualité.Text = Math.Round(Val(Fréquence_résonance.Text) / Val(Bande_passante.Text), 2)
        Tension_Ur.Text = Math.Round((Val(Tension.Text) / Val(Résistance.Text)) * 1000, 2) & " " & "mA"
        Tension_Uc.Text = Math.Round((Val(Tension.Text) / Val(réactance_cap_vraie)) * 1000, 2) & " " & "mA"
        Tension_UL.Text = Math.Round((Val(Tension.Text) / Val(réactance_ind_vraie)) * 1000, 2) & " " & "mA"
        Tension_Ur_eff.Text = Math.Round((Val(Tension.Text) / Val(Résistance.Text)) * 1000 / Math.Sqrt(2), 2) & " " & "mA"
        Tension_Uc_eff.Text = Math.Round((Val(Tension.Text) / Val(réactance_cap_vraie)) * 1000 / Math.Sqrt(2), 2) & " " & "mA"
        Tension_UL_eff.Text = Math.Round((Val(Tension.Text) / Val(réactance_ind_vraie)) * 1000 / Math.Sqrt(2), 2) & " " & "mA"
        Tension_Uc_texte.Text = "Intensité iC"
        Tension_UL_texte.Text = "Intensité iL"
        Tension_Ur_texte.Text = "Intensité iR"
        Titre.Text = "Le circuit RLC parallèle - Filtre coupe-bande"
        Tension_efficace.Text = Math.Round((Val(Tension.Text) / Math.Sqrt(2)), 2) & " " & "V"
        Intensité.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie), 2) & " " & "mA"
        intensité_eff.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2), 2) & " " & "mA"
        échelle_fresnel()
        Fresnel_RLC_parallèle()
        If (Val(Réactance_capacitive.Text) < Val(Réactance_inductive.Text)) Then
            Déphasage.Text = "+" & Math.Round((Math.Acos(Val(impédance_vraie) / Val(Résistance.Text)) * 180 / Math.PI), 2) & "°"
            Déphasage_texte.ForeColor = Color.Green
            Puissance_réactive_texte.ForeColor = Color.Green
            Circuit.ForeColor = Color.Green
            Circuit.Text = "Le circuit est capacitif ; le courant est en avance sur la tension"
        ElseIf (Val(Réactance_capacitive.Text) > Val(Réactance_inductive.Text)) Then
            Déphasage.Text = -Math.Round((Math.Acos(Val(impédance_vraie) / Val(Résistance.Text)) * 180 / Math.PI), 2) & "°"
            Déphasage_texte.ForeColor = Color.Red
            Puissance_réactive_texte.ForeColor = Color.Red
            Circuit.ForeColor = Color.Red
            Circuit.Text = "Le circuit est inductif ; le courant est en retard sur la tension"
        ElseIf (Val(Réactance_capacitive.Text) = Val(Réactance_inductive.Text)) Then
            Déphasage.Text = "0°"
            Déphasage_texte.ForeColor = Color.Blue
            Puissance_réactive_texte.ForeColor = Color.Blue
            Circuit.ForeColor = Color.Blue
            Circuit.Text = "Le circuit résonne ; le courant est en phase avec la tension"
        End If
        Puissance_active.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Math.Cos(Val(Déphasage.Text) * Math.PI / 180)), 4) & " " & "W"
        Puissance_réactive.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * ((Val(Tension_Uc.Text) - Val(Tension_UL.Text)) / Val(intensité_vraie) / 1000), 4) & " " & "VAR"
        Puissance_apparente.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)), 4) & " " & "VA"
        Facteur_puissance.Text = Math.Round((Val(Tension_Ur.Text) / Val(Intensité.Text)), 3)
    End Sub

    Sub calcul_RC_série()
        visibilité()
        Résistance1.Text = Val(Résistance.Text) & " " & "Ω"
        réactance_cap_vraie = 1 / (2 * Math.PI * Val(Fréquence.Text) * Val(Capacité.Text))
        résistance_vraie = Val(Résistance.Text)
        impédance_vraie = Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_cap_vraie)) * (Val(réactance_cap_vraie))))
        intensité_vraie = Val(Tension.Text) / impédance_vraie
        tension_uc_vraie = réactance_cap_vraie * intensité_vraie
        Réactance_capacitive.Text = Math.Round(1 / (2 * Math.PI * Val(Fréquence.Text) * Val(Capacité.Text)), 2) & " " & "Ω"
        Impédance.Text = Math.Round(Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_cap_vraie)) * (Val(réactance_cap_vraie)))), 2) & " " & "Ω"
        Fréquence_coupure_bas.Text = Math.Round(1 / (2 * Val(Résistance.Text) * Val(Capacité.Text) * Math.PI), 2) & " " & "Hz"
        Tension_Ur.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_Uc.Text = Math.Round((Val(réactance_cap_vraie) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_Ur_eff.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_Uc_eff.Text = Math.Round((Val(réactance_cap_vraie) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_Uc_texte.Text = "Tension UC"
        Tension_Ur_texte.Text = "Tension UR"
        Titre.Text = "Le circuit RC série - Filtre passe-bas"
        Tension_efficace.Text = Math.Round((Val(Tension.Text) / Math.Sqrt(2)), 2) & " " & "V"
        Intensité.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie), 2) & " " & "mA"
        intensité_eff.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2), 2) & " " & "mA"
        Tension_UL.Text = "0"
        échelle_fresnel()
        Fresnel_RC_série()
        Déphasage.Text = -Math.Round((Math.Acos(Val(Résistance.Text) / Val(impédance_vraie)) * 180 / Math.PI), 2) & "°"
        Puissance_active.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Val(Résistance.Text) / Val(impédance_vraie)), 4) & " " & "W"
        Puissance_réactive.Text = -Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Val(réactance_cap_vraie) / Val(impédance_vraie)), 4) & " " & "VAR"
        Puissance_apparente.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)), 4) & " " & "VA"
        Facteur_puissance.Text = Math.Round(Val(Résistance.Text) / Val(impédance_vraie), 3)
        Circuit.ForeColor = Color.Green
        Déphasage_texte.ForeColor = Color.Green
        Puissance_réactive_texte.ForeColor = Color.Green
        Circuit.Text = "Le circuit est capacitif ; la tension est en retard sur le courant"
    End Sub

    Sub calcul_RL_série()
        visibilité()
        Résistance1.Text = Val(Résistance.Text) & " " & "Ω"
        réactance_ind_vraie = 2 * Math.PI * Val(Fréquence.Text) * Val(Inductance.Text)
        résistance_vraie = Val(Résistance.Text)
        impédance_vraie = Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_ind_vraie)) * (Val(réactance_ind_vraie))))
        intensité_vraie = Val(Tension.Text) / impédance_vraie
        tension_ul_vraie = réactance_ind_vraie * intensité_vraie
        Réactance_capacitive.Text = Math.Round(2 * Math.PI * Val(Fréquence.Text) * Val(Inductance.Text), 2) & " " & "Ω"
        Impédance.Text = Math.Round(Math.Sqrt((Val(Résistance.Text) * Val(Résistance.Text)) + ((Val(réactance_ind_vraie)) * (Val(réactance_ind_vraie)))), 2) & " " & "Ω"
        fréquence_coupure_haut.Text = Math.Round(Val(Résistance.Text) / (2 * Val(Inductance.Text) * Math.PI), 2) & " " & "Hz"
        Tension_Ur.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_UL.Text = Math.Round((Val(réactance_ind_vraie) * Val(Tension.Text) / Val(impédance_vraie)), 2) & " " & "V"
        Tension_Ur_eff.Text = Math.Round((Val(Résistance.Text) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_UL_eff.Text = Math.Round((Val(réactance_ind_vraie) * Val(Tension.Text) / Val(impédance_vraie)) / Math.Sqrt(2), 2) & " " & "V"
        Tension_UL_texte.Text = "Tension UL"
        Tension_Ur_texte.Text = "Tension UR"
        Titre.Text = "Le circuit RL série - Filtre passe-haut"
        Tension_efficace.Text = Math.Round((Val(Tension.Text) / Math.Sqrt(2)), 2) & " " & "V"
        Intensité.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie), 2) & " " & "mA"
        intensité_eff.Text = Math.Round(1000 * Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2), 2) & " " & "mA"
        Tension_Uc.Text = "0"
        échelle_fresnel()
        Fresnel_RL_série()
        Déphasage.Text = Math.Round((Math.Acos(Val(Résistance.Text) / Val(impédance_vraie)) * 180 / Math.PI), 2) & "°"
        Puissance_active.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Val(Résistance.Text) / Val(impédance_vraie)), 4) & " " & "W"
        Puissance_réactive.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)) * (Val(réactance_ind_vraie) / Val(impédance_vraie)), 4) & " " & "VAR"
        Puissance_apparente.Text = Math.Round(Val(Tension_efficace.Text) * (Val(Tension.Text) / Val(impédance_vraie) / Math.Sqrt(2)), 4) & " " & "VA"
        Facteur_puissance.Text = Math.Round(Val(Résistance.Text) / Val(impédance_vraie), 3)
        Circuit.ForeColor = Color.Red
        Déphasage_texte.ForeColor = Color.Red
        Puissance_réactive_texte.ForeColor = Color.Red
        Circuit.Text = "Le circuit est inductif ; la tension est en avance sur le courant"
    End Sub

    Private Sub Echelle_Scroll(sender As Object, e As EventArgs) Handles Echelle.Scroll
        échelle = Echelle.Value
        If RLC_série.Checked = True Then
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            Fresnel_RLC_parallèle()
        End If
        If RC_série.Checked = True Then
            Fresnel_RC_série()
        End If
        If RL_série.Checked = True Then
            Fresnel_RL_série()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fréquence.Text = "5000"
        Tension.Text = "10"
        Résistance.Text =
            "800"
        Capacité.Text = "8E-08"
        Inductance.Text = "6E-03"
        RLC_série.Checked = True
        ref = 1
    End Sub

    Private Sub RLC_série_CheckedChanged(sender As Object, e As EventArgs) Handles RLC_série.CheckedChanged
        calcul_RLC_série()
    End Sub

    Private Sub RLC_parallèle_CheckedChanged(sender As Object, e As EventArgs) Handles RLC_parallèle.CheckedChanged
        calcul_RLC_parallèle()
    End Sub

    Private Sub RC_série_CheckedChanged(sender As Object, e As EventArgs) Handles RC_série.CheckedChanged
        calcul_RC_série()
    End Sub

    Private Sub RL_série_CheckedChanged(sender As Object, e As EventArgs) Handles RL_série.CheckedChanged
        calcul_RL_série()
    End Sub

    Sub visibilité()
        If RLC_série.Checked = True Then
            Inductance_texte.Visible = True
            Inductance.Visible = True
            Capacité_texte.Visible = True
            Capacité.Visible = True
            Résistance_texte.Visible = True
            Résistance.Visible = True
            Résistance1.Visible = True
            Résistance_vraie_texte.Visible = True
            Réactance_capacitive.Visible = True
            Réactance_capacitive_texte.Visible = True
            Réactance_inductive.Visible = True
            Réactance_inductive_texte.Visible = True
            Tension_Uc.Visible = True
            Tension_Uc_texte.Visible = True
            Tension_UL.Visible = True
            Tension_UL_texte.Visible = True
            Tension_Ur.Visible = True
            Tension_Ur_texte.Visible = True
            Tension_Uc_eff.Visible = True
            Tension_UL_eff.Visible = True
            Tension_Ur_eff.Visible = True
            Facteur_qualité.Visible = True
            Facteur_qualité_texte.Visible = True
            Fréquence_résonance.Visible = True
            Fréquence_résonnance_texte.Visible = True
            Bande_passante.Visible = True
            Bande_passante_texte.Visible = True
            Fréquence_coupure_bas.Visible = True
            Fréquence_bas_texte.Visible = True
            fréquence_coupure_haut.Visible = True
            Fréquence_haut_texte.Visible = True
            Montage.Image = My.Resources.RLC_série
        End If

        If RLC_parallèle.Checked = True Then
            Inductance_texte.Visible = True
            Inductance.Visible = True
            Capacité_texte.Visible = True
            Capacité.Visible = True
            Résistance_texte.Visible = True
            Résistance.Visible = True
            Résistance1.Visible = True
            Résistance_vraie_texte.Visible = True
            Réactance_capacitive.Visible = True
            Réactance_capacitive_texte.Visible = True
            Réactance_inductive.Visible = True
            Réactance_inductive_texte.Visible = True
            Tension_Uc.Visible = True
            Tension_Uc_texte.Visible = True
            Tension_UL.Visible = True
            Tension_UL_texte.Visible = True
            Tension_Ur.Visible = True
            Tension_Ur_texte.Visible = True
            Tension_Uc_eff.Visible = True
            Tension_UL_eff.Visible = True
            Tension_Ur_eff.Visible = True
            Facteur_qualité.Visible = True
            Facteur_qualité_texte.Visible = True
            Fréquence_résonance.Visible = True
            Fréquence_résonnance_texte.Visible = True
            Bande_passante.Visible = True
            Bande_passante_texte.Visible = True
            Fréquence_coupure_bas.Visible = True
            Fréquence_bas_texte.Visible = True
            fréquence_coupure_haut.Visible = True
            Fréquence_haut_texte.Visible = True
            Montage.Image = My.Resources.RLC_parallèle
        End If
        If RC_série.Checked = True Then
            Inductance_texte.Visible = False
            Inductance.Visible = False
            Capacité_texte.Visible = True
            Capacité.Visible = True
            Résistance_texte.Visible = True
            Résistance.Visible = True
            Résistance1.Visible = True
            Résistance_vraie_texte.Visible = True
            Réactance_capacitive.Visible = True
            Réactance_capacitive_texte.Visible = True
            Réactance_inductive.Visible = False
            Réactance_inductive_texte.Visible = False
            Tension_Uc.Visible = True
            Tension_Uc_texte.Visible = True
            Tension_UL.Visible = False
            Tension_UL_texte.Visible = False
            Tension_Ur.Visible = True
            Tension_Ur_texte.Visible = True
            Tension_Uc_eff.Visible = True
            Tension_UL_eff.Visible = False
            Tension_Ur_eff.Visible = True
            Facteur_qualité.Visible = False
            Facteur_qualité_texte.Visible = False
            Fréquence_résonance.Visible = False
            Fréquence_résonnance_texte.Visible = False
            Bande_passante.Visible = False
            Bande_passante_texte.Visible = False
            Fréquence_coupure_bas.Visible = True
            Fréquence_bas_texte.Visible = True
            fréquence_coupure_haut.Visible = False
            Fréquence_haut_texte.Visible = False
            Montage.Image = My.Resources.RC_série
        End If
        If RL_série.Checked = True Then
            Inductance_texte.Visible = True
            Inductance.Visible = True
            Capacité_texte.Visible = False
            Capacité.Visible = False
            Résistance_texte.Visible = True
            Résistance.Visible = True
            Résistance1.Visible = True
            Résistance_vraie_texte.Visible = True
            Réactance_capacitive.Visible = False
            Réactance_capacitive_texte.Visible = False
            Réactance_inductive.Visible = True
            Réactance_inductive_texte.Visible = True
            Tension_Uc.Visible = False
            Tension_Uc_texte.Visible = False
            Tension_UL.Visible = True
            Tension_UL_texte.Visible = True
            Tension_Ur.Visible = True
            Tension_Ur_texte.Visible = True
            Tension_Uc_eff.Visible = False
            Tension_UL_eff.Visible = True
            Tension_Ur_eff.Visible = True
            Facteur_qualité.Visible = False
            Facteur_qualité_texte.Visible = False
            Fréquence_résonance.Visible = False
            Fréquence_résonnance_texte.Visible = False
            Bande_passante.Visible = False
            Bande_passante_texte.Visible = False
            Fréquence_coupure_bas.Visible = False
            Fréquence_bas_texte.Visible = False
            fréquence_coupure_haut.Visible = True
            Fréquence_haut_texte.Visible = True
            Montage.Image = My.Resources.RL_série
        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If RLC_série.Checked = True Then
            If ref = 1 Then
                Me.Refresh()
                ref = 0
            End If
            Fresnel_RLC_série()
        End If
        If RLC_parallèle.Checked = True Then
            If ref = 1 Then
                Me.Refresh()
                ref = 0
            End If
            Fresnel_RLC_parallèle()
        End If
        If RL_série.Checked = True Then
            If ref = 1 Then
                Me.Refresh()
                ref = 0
            End If
            Fresnel_RL_série()
        End If
        If RC_série.Checked = True Then
            If ref = 1 Then
                Me.Refresh()
                ref = 0
            End If
            Fresnel_RC_série()
        End If
    End Sub

    Private Sub Fréquence_haut_texte_Click(sender As Object, e As EventArgs) Handles Fréquence_haut_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Fréquence_coupure_haut_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Fréquence_coupure_haut_parallèle.Show()
        End If
    End Sub

    Private Sub Fréquence_bas_texte_Click(sender As Object, e As EventArgs) Handles Fréquence_bas_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Fréquence_coupure_bas_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Fréquence_coupure_bas_parallèle.Show()
        End If
    End Sub

    Private Sub tension_efficace_text_Click(sender As Object, e As EventArgs) Handles tension_efficace_text.Click
        fermer_fenetres()
        Tension_efficace_série.Show()
    End Sub

    Private Sub Pulsation_texte_Click(sender As Object, e As EventArgs) Handles Pulsation_texte.Click
        fermer_fenetres()
        Pulsation_série.Show()
    End Sub

    Private Sub Période_texte_Click(sender As Object, e As EventArgs) Handles Période_texte.Click
        fermer_fenetres()
        Période_série.Show()
    End Sub

    Private Sub Réactance_inductive_texte_Click(sender As Object, e As EventArgs) Handles Réactance_inductive_texte.Click
        fermer_fenetres()
        Réactance_inductive_série.Show()
    End Sub

    Private Sub Réactance_capacitive_texte_Click(sender As Object, e As EventArgs) Handles Réactance_capacitive_texte.Click
        fermer_fenetres()
        Réactance_capacitive_série.Show()
    End Sub

    Private Sub Impédance_texte_Click(sender As Object, e As EventArgs) Handles Impédance_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Impédance_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Impédance_RLC_parallèle.Show()
        End If
    End Sub

    Private Sub Fréquence_résonnance_texte_Click(sender As Object, e As EventArgs) Handles Fréquence_résonnance_texte.Click
        fermer_fenetres()
        Fréquence_de_résonance.Show()
    End Sub

    Private Sub Facteur_qualité_texte_Click(sender As Object, e As EventArgs) Handles Facteur_qualité_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Facteur_de_qualité_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Facteur_qualité_parallèle.Show()
        End If
    End Sub

    Private Sub Déphasage_texte_Click(sender As Object, e As EventArgs) Handles Déphasage_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Déphasage_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Déphasage_parallèle.Show()
        End If
    End Sub

    Private Sub Bande_passante_texte_Click(sender As Object, e As EventArgs) Handles Bande_passante_texte.Click
        fermer_fenetres()
        Bande_passante_série.Show()
    End Sub

    Private Sub Intensité_texte_Click(sender As Object, e As EventArgs) Handles Intensité_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Intensité_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Intensité_i_parallèle.Show()
        End If
    End Sub

    Private Sub Tension_Ur_texte_Click(sender As Object, e As EventArgs) Handles Tension_Ur_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Tension_UR_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Intensité_ir_parallèle.Show()
        End If
    End Sub

    Private Sub Tension_UL_texte_Click(sender As Object, e As EventArgs) Handles Tension_UL_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Tension_inductance_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Intensité_iL_parallèle.Show()
        End If
    End Sub

    Private Sub Tension_Uc_texte_Click(sender As Object, e As EventArgs) Handles Tension_Uc_texte.Click
        fermer_fenetres()
        If RLC_série.Checked = True Then
            Tension_condensateur_série.Show()
        End If
        If RLC_parallèle.Checked = True Then
            Intensité_iC_parallèle.Show()
        End If
    End Sub

    Private Sub Puissance_active_texte_Click(sender As Object, e As EventArgs) Handles Puissance_active_texte.Click
        fermer_fenetres()
        Puissance_active_série.Show()
    End Sub

    Private Sub Puissance_réactive_texte_Click(sender As Object, e As EventArgs) Handles Puissance_réactive_texte.Click
        fermer_fenetres()
        Puissance_réactive_série.Show()
    End Sub

    Private Sub Puissance_apparente_texte_Click(sender As Object, e As EventArgs) Handles Puissance_apparente_texte.Click
        fermer_fenetres()
        Puissance_apparente_série.Show()
    End Sub

    Private Sub Facteur_puissance_texte_Click(sender As Object, e As EventArgs) Handles Facteur_puissance_texte.Click
        fermer_fenetres()
        Facteur_puissance_série.Show()
    End Sub

    Sub fermer_fenetres()
        Fréquence_coupure_haut_série.Close()
        Fréquence_coupure_haut_parallèle.Close()
        Fréquence_coupure_bas_série.Close()
        Fréquence_coupure_bas_parallèle.Close()
        Tension_efficace_série.Close()
        Pulsation_série.Close()
        Période_série.Close()
        Réactance_inductive_série.Close()
        Réactance_capacitive_série.Close()
        Impédance_série.Close()
        Impédance_RLC_parallèle.Close()
        Fréquence_de_résonance.Close()
        Facteur_de_qualité_série.Close()
        Facteur_qualité_parallèle.Close()
        Déphasage_série.Close()
        Déphasage_parallèle.Close()
        Bande_passante_série.Close()
        Intensité_série.Close()
        Intensité_i_parallèle.Close()
        Tension_UR_série.Close()
        Intensité_ir_parallèle.Close()
        Tension_inductance_série.Close()
        Intensité_iL_parallèle.Close()
        Tension_condensateur_série.Close()
        Intensité_iC_parallèle.Close()
        Puissance_active_série.Close()
        Puissance_réactive_série.Close()
        Puissance_apparente_série.Close()
        Facteur_puissance_série.Close()
    End Sub

    Private Sub Montage_Click(sender As Object, e As EventArgs) Handles Montage.Click
        Bode.Show()
    End Sub

    Private Sub Fresnel_Click(sender As Object, e As EventArgs) Handles Fresnel.Click
        Graphique.Show()
    End Sub

End Class