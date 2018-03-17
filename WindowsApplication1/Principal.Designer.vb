<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Fréquence = New System.Windows.Forms.TextBox()
        Me.Fréquence_texte = New System.Windows.Forms.Label()
        Me.Tension_texte = New System.Windows.Forms.Label()
        Me.Tension = New System.Windows.Forms.TextBox()
        Me.Résistance = New System.Windows.Forms.TextBox()
        Me.Résistance_texte = New System.Windows.Forms.Label()
        Me.Capacité = New System.Windows.Forms.TextBox()
        Me.Capacité_texte = New System.Windows.Forms.Label()
        Me.Inductance = New System.Windows.Forms.TextBox()
        Me.Inductance_texte = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Pulsation = New System.Windows.Forms.TextBox()
        Me.Pulsation_texte = New System.Windows.Forms.Label()
        Me.Période_texte = New System.Windows.Forms.Label()
        Me.Période = New System.Windows.Forms.TextBox()
        Me.tension_efficace_text = New System.Windows.Forms.Label()
        Me.Tension_efficace = New System.Windows.Forms.TextBox()
        Me.Résistance_vraie_texte = New System.Windows.Forms.Label()
        Me.Résistance1 = New System.Windows.Forms.TextBox()
        Me.Réactance_capacitive_texte = New System.Windows.Forms.Label()
        Me.Réactance_capacitive = New System.Windows.Forms.TextBox()
        Me.Réactance_inductive_texte = New System.Windows.Forms.Label()
        Me.Réactance_inductive = New System.Windows.Forms.TextBox()
        Me.Impédance_texte = New System.Windows.Forms.Label()
        Me.Impédance = New System.Windows.Forms.TextBox()
        Me.Facteur_qualité_texte = New System.Windows.Forms.Label()
        Me.Facteur_qualité = New System.Windows.Forms.TextBox()
        Me.Déphasage_texte = New System.Windows.Forms.Label()
        Me.Déphasage = New System.Windows.Forms.TextBox()
        Me.Circuit = New System.Windows.Forms.Label()
        Me.Intensité_texte = New System.Windows.Forms.Label()
        Me.Intensité = New System.Windows.Forms.TextBox()
        Me.Tension_Ur_texte = New System.Windows.Forms.Label()
        Me.Tension_Ur = New System.Windows.Forms.TextBox()
        Me.Tension_Uc_texte = New System.Windows.Forms.Label()
        Me.Tension_Uc = New System.Windows.Forms.TextBox()
        Me.Tension_UL_texte = New System.Windows.Forms.Label()
        Me.Tension_UL = New System.Windows.Forms.TextBox()
        Me.Fréquence_résonnance_texte = New System.Windows.Forms.Label()
        Me.Fréquence_résonance = New System.Windows.Forms.TextBox()
        Me.Bande_passante_texte = New System.Windows.Forms.Label()
        Me.Bande_passante = New System.Windows.Forms.TextBox()
        Me.Fréquence_haut_texte = New System.Windows.Forms.Label()
        Me.fréquence_coupure_haut = New System.Windows.Forms.TextBox()
        Me.Fréquence_bas_texte = New System.Windows.Forms.Label()
        Me.Fréquence_coupure_bas = New System.Windows.Forms.TextBox()
        Me.Echelle = New System.Windows.Forms.TrackBar()
        Me.Diagramme_fresnel_texte = New System.Windows.Forms.Label()
        Me.RLC_série = New System.Windows.Forms.RadioButton()
        Me.RLC_parallèle = New System.Windows.Forms.RadioButton()
        Me.Diagramme_texte = New System.Windows.Forms.Label()
        Me.RC_série = New System.Windows.Forms.RadioButton()
        Me.RL_série = New System.Windows.Forms.RadioButton()
        Me.Tension_UL_eff = New System.Windows.Forms.TextBox()
        Me.Tension_Uc_eff = New System.Windows.Forms.TextBox()
        Me.Tension_Ur_eff = New System.Windows.Forms.TextBox()
        Me.intensité_eff = New System.Windows.Forms.TextBox()
        Me.Max_texte = New System.Windows.Forms.Label()
        Me.Eff_texte = New System.Windows.Forms.Label()
        Me.Puissance_active_texte = New System.Windows.Forms.Label()
        Me.Puissance_active = New System.Windows.Forms.TextBox()
        Me.Facteur_puissance_texte = New System.Windows.Forms.Label()
        Me.Facteur_puissance = New System.Windows.Forms.TextBox()
        Me.Puissance_apparente_texte = New System.Windows.Forms.Label()
        Me.Puissance_apparente = New System.Windows.Forms.TextBox()
        Me.Puissance_réactive_texte = New System.Windows.Forms.Label()
        Me.Puissance_réactive = New System.Windows.Forms.TextBox()
        Me.Montage = New System.Windows.Forms.PictureBox()
        Me.Fresnel = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Echelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Montage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fresnel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fréquence
        '
        Me.Fréquence.Location = New System.Drawing.Point(39, 145)
        Me.Fréquence.Name = "Fréquence"
        Me.Fréquence.Size = New System.Drawing.Size(58, 20)
        Me.Fréquence.TabIndex = 0
        Me.Fréquence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fréquence_texte
        '
        Me.Fréquence_texte.AutoSize = True
        Me.Fréquence_texte.Location = New System.Drawing.Point(31, 129)
        Me.Fréquence_texte.Name = "Fréquence_texte"
        Me.Fréquence_texte.Size = New System.Drawing.Size(80, 13)
        Me.Fréquence_texte.TabIndex = 1
        Me.Fréquence_texte.Text = "Fréquence (Hz)"
        '
        'Tension_texte
        '
        Me.Tension_texte.AutoSize = True
        Me.Tension_texte.Location = New System.Drawing.Point(135, 129)
        Me.Tension_texte.Name = "Tension_texte"
        Me.Tension_texte.Size = New System.Drawing.Size(61, 13)
        Me.Tension_texte.TabIndex = 2
        Me.Tension_texte.Text = "Tension (V)"
        '
        'Tension
        '
        Me.Tension.ForeColor = System.Drawing.Color.Blue
        Me.Tension.Location = New System.Drawing.Point(138, 145)
        Me.Tension.Name = "Tension"
        Me.Tension.Size = New System.Drawing.Size(58, 20)
        Me.Tension.TabIndex = 3
        Me.Tension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Résistance
        '
        Me.Résistance.Location = New System.Drawing.Point(238, 145)
        Me.Résistance.Name = "Résistance"
        Me.Résistance.Size = New System.Drawing.Size(58, 20)
        Me.Résistance.TabIndex = 5
        Me.Résistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Résistance_texte
        '
        Me.Résistance_texte.AutoSize = True
        Me.Résistance_texte.Location = New System.Drawing.Point(235, 129)
        Me.Résistance_texte.Name = "Résistance_texte"
        Me.Résistance_texte.Size = New System.Drawing.Size(78, 13)
        Me.Résistance_texte.TabIndex = 4
        Me.Résistance_texte.Text = "Résistance (Ω)"
        '
        'Capacité
        '
        Me.Capacité.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Capacité.Location = New System.Drawing.Point(346, 145)
        Me.Capacité.Name = "Capacité"
        Me.Capacité.Size = New System.Drawing.Size(58, 20)
        Me.Capacité.TabIndex = 7
        Me.Capacité.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Capacité_texte
        '
        Me.Capacité_texte.AutoSize = True
        Me.Capacité_texte.Location = New System.Drawing.Point(343, 129)
        Me.Capacité_texte.Name = "Capacité_texte"
        Me.Capacité_texte.Size = New System.Drawing.Size(64, 13)
        Me.Capacité_texte.TabIndex = 6
        Me.Capacité_texte.Text = "Capacité (F)"
        '
        'Inductance
        '
        Me.Inductance.ForeColor = System.Drawing.Color.Red
        Me.Inductance.Location = New System.Drawing.Point(442, 145)
        Me.Inductance.Name = "Inductance"
        Me.Inductance.Size = New System.Drawing.Size(58, 20)
        Me.Inductance.TabIndex = 9
        Me.Inductance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Inductance_texte
        '
        Me.Inductance_texte.AutoSize = True
        Me.Inductance_texte.Location = New System.Drawing.Point(439, 129)
        Me.Inductance_texte.Name = "Inductance_texte"
        Me.Inductance_texte.Size = New System.Drawing.Size(78, 13)
        Me.Inductance_texte.TabIndex = 8
        Me.Inductance_texte.Text = "Inductance (H)"
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.SystemColors.Control
        Me.Titre.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Titre.Location = New System.Drawing.Point(311, 9)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(216, 24)
        Me.Titre.TabIndex = 10
        Me.Titre.Text = "Le circuit RLC série"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pulsation
        '
        Me.Pulsation.Location = New System.Drawing.Point(208, 204)
        Me.Pulsation.Name = "Pulsation"
        Me.Pulsation.ReadOnly = True
        Me.Pulsation.Size = New System.Drawing.Size(78, 20)
        Me.Pulsation.TabIndex = 11
        Me.Pulsation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pulsation_texte
        '
        Me.Pulsation_texte.AutoSize = True
        Me.Pulsation_texte.Location = New System.Drawing.Point(217, 188)
        Me.Pulsation_texte.Name = "Pulsation_texte"
        Me.Pulsation_texte.Size = New System.Drawing.Size(50, 13)
        Me.Pulsation_texte.TabIndex = 12
        Me.Pulsation_texte.Text = "Pulsation"
        '
        'Période_texte
        '
        Me.Période_texte.AutoSize = True
        Me.Période_texte.Location = New System.Drawing.Point(338, 188)
        Me.Période_texte.Name = "Période_texte"
        Me.Période_texte.Size = New System.Drawing.Size(43, 13)
        Me.Période_texte.TabIndex = 14
        Me.Période_texte.Text = "Période"
        '
        'Période
        '
        Me.Période.Location = New System.Drawing.Point(337, 204)
        Me.Période.Name = "Période"
        Me.Période.ReadOnly = True
        Me.Période.Size = New System.Drawing.Size(58, 20)
        Me.Période.TabIndex = 13
        Me.Période.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tension_efficace_text
        '
        Me.tension_efficace_text.AutoSize = True
        Me.tension_efficace_text.Location = New System.Drawing.Point(71, 188)
        Me.tension_efficace_text.Name = "tension_efficace_text"
        Me.tension_efficace_text.Size = New System.Drawing.Size(86, 13)
        Me.tension_efficace_text.TabIndex = 16
        Me.tension_efficace_text.Text = "Tension efficace"
        '
        'Tension_efficace
        '
        Me.Tension_efficace.Location = New System.Drawing.Point(88, 204)
        Me.Tension_efficace.Name = "Tension_efficace"
        Me.Tension_efficace.ReadOnly = True
        Me.Tension_efficace.Size = New System.Drawing.Size(58, 20)
        Me.Tension_efficace.TabIndex = 15
        Me.Tension_efficace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Résistance_vraie_texte
        '
        Me.Résistance_vraie_texte.AutoSize = True
        Me.Résistance_vraie_texte.Location = New System.Drawing.Point(37, 247)
        Me.Résistance_vraie_texte.Name = "Résistance_vraie_texte"
        Me.Résistance_vraie_texte.Size = New System.Drawing.Size(60, 13)
        Me.Résistance_vraie_texte.TabIndex = 18
        Me.Résistance_vraie_texte.Text = "Résistance"
        '
        'Résistance1
        '
        Me.Résistance1.Location = New System.Drawing.Point(39, 263)
        Me.Résistance1.Name = "Résistance1"
        Me.Résistance1.ReadOnly = True
        Me.Résistance1.Size = New System.Drawing.Size(58, 20)
        Me.Résistance1.TabIndex = 17
        Me.Résistance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Réactance_capacitive_texte
        '
        Me.Réactance_capacitive_texte.AutoSize = True
        Me.Réactance_capacitive_texte.ForeColor = System.Drawing.Color.Green
        Me.Réactance_capacitive_texte.Location = New System.Drawing.Point(126, 247)
        Me.Réactance_capacitive_texte.Name = "Réactance_capacitive_texte"
        Me.Réactance_capacitive_texte.Size = New System.Drawing.Size(112, 13)
        Me.Réactance_capacitive_texte.TabIndex = 20
        Me.Réactance_capacitive_texte.Text = "Réactance capacitive"
        '
        'Réactance_capacitive
        '
        Me.Réactance_capacitive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Réactance_capacitive.Location = New System.Drawing.Point(138, 263)
        Me.Réactance_capacitive.Name = "Réactance_capacitive"
        Me.Réactance_capacitive.ReadOnly = True
        Me.Réactance_capacitive.Size = New System.Drawing.Size(87, 20)
        Me.Réactance_capacitive.TabIndex = 19
        Me.Réactance_capacitive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Réactance_inductive_texte
        '
        Me.Réactance_inductive_texte.AutoSize = True
        Me.Réactance_inductive_texte.ForeColor = System.Drawing.Color.Red
        Me.Réactance_inductive_texte.Location = New System.Drawing.Point(243, 247)
        Me.Réactance_inductive_texte.Name = "Réactance_inductive_texte"
        Me.Réactance_inductive_texte.Size = New System.Drawing.Size(106, 13)
        Me.Réactance_inductive_texte.TabIndex = 22
        Me.Réactance_inductive_texte.Text = "Réactance inductive"
        '
        'Réactance_inductive
        '
        Me.Réactance_inductive.ForeColor = System.Drawing.Color.Red
        Me.Réactance_inductive.Location = New System.Drawing.Point(255, 263)
        Me.Réactance_inductive.Name = "Réactance_inductive"
        Me.Réactance_inductive.ReadOnly = True
        Me.Réactance_inductive.Size = New System.Drawing.Size(81, 20)
        Me.Réactance_inductive.TabIndex = 21
        Me.Réactance_inductive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Impédance_texte
        '
        Me.Impédance_texte.AutoSize = True
        Me.Impédance_texte.ForeColor = System.Drawing.Color.Blue
        Me.Impédance_texte.Location = New System.Drawing.Point(360, 247)
        Me.Impédance_texte.Name = "Impédance_texte"
        Me.Impédance_texte.Size = New System.Drawing.Size(89, 13)
        Me.Impédance_texte.TabIndex = 24
        Me.Impédance_texte.Text = "Impédance totale"
        '
        'Impédance
        '
        Me.Impédance.ForeColor = System.Drawing.Color.Blue
        Me.Impédance.Location = New System.Drawing.Point(363, 263)
        Me.Impédance.Name = "Impédance"
        Me.Impédance.ReadOnly = True
        Me.Impédance.Size = New System.Drawing.Size(81, 20)
        Me.Impédance.TabIndex = 23
        Me.Impédance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Facteur_qualité_texte
        '
        Me.Facteur_qualité_texte.AutoSize = True
        Me.Facteur_qualité_texte.Location = New System.Drawing.Point(223, 314)
        Me.Facteur_qualité_texte.Name = "Facteur_qualité_texte"
        Me.Facteur_qualité_texte.Size = New System.Drawing.Size(92, 13)
        Me.Facteur_qualité_texte.TabIndex = 26
        Me.Facteur_qualité_texte.Text = "Facteur de qualité"
        '
        'Facteur_qualité
        '
        Me.Facteur_qualité.Location = New System.Drawing.Point(239, 330)
        Me.Facteur_qualité.Name = "Facteur_qualité"
        Me.Facteur_qualité.ReadOnly = True
        Me.Facteur_qualité.Size = New System.Drawing.Size(58, 20)
        Me.Facteur_qualité.TabIndex = 25
        Me.Facteur_qualité.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Déphasage_texte
        '
        Me.Déphasage_texte.AutoSize = True
        Me.Déphasage_texte.Location = New System.Drawing.Point(399, 314)
        Me.Déphasage_texte.Name = "Déphasage_texte"
        Me.Déphasage_texte.Size = New System.Drawing.Size(62, 13)
        Me.Déphasage_texte.TabIndex = 28
        Me.Déphasage_texte.Text = "Déphasage"
        '
        'Déphasage
        '
        Me.Déphasage.Location = New System.Drawing.Point(401, 330)
        Me.Déphasage.Name = "Déphasage"
        Me.Déphasage.ReadOnly = True
        Me.Déphasage.Size = New System.Drawing.Size(58, 20)
        Me.Déphasage.TabIndex = 27
        Me.Déphasage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Circuit
        '
        Me.Circuit.AutoSize = True
        Me.Circuit.Location = New System.Drawing.Point(756, 453)
        Me.Circuit.Name = "Circuit"
        Me.Circuit.Size = New System.Drawing.Size(0, 13)
        Me.Circuit.TabIndex = 29
        '
        'Intensité_texte
        '
        Me.Intensité_texte.AutoSize = True
        Me.Intensité_texte.ForeColor = System.Drawing.Color.Blue
        Me.Intensité_texte.Location = New System.Drawing.Point(101, 434)
        Me.Intensité_texte.Name = "Intensité_texte"
        Me.Intensité_texte.Size = New System.Drawing.Size(78, 13)
        Me.Intensité_texte.TabIndex = 31
        Me.Intensité_texte.Text = "Intensité circuit"
        '
        'Intensité
        '
        Me.Intensité.Location = New System.Drawing.Point(105, 450)
        Me.Intensité.Name = "Intensité"
        Me.Intensité.ReadOnly = True
        Me.Intensité.Size = New System.Drawing.Size(58, 20)
        Me.Intensité.TabIndex = 30
        Me.Intensité.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tension_Ur_texte
        '
        Me.Tension_Ur_texte.AutoSize = True
        Me.Tension_Ur_texte.Location = New System.Drawing.Point(200, 434)
        Me.Tension_Ur_texte.Name = "Tension_Ur_texte"
        Me.Tension_Ur_texte.Size = New System.Drawing.Size(59, 13)
        Me.Tension_Ur_texte.TabIndex = 33
        Me.Tension_Ur_texte.Text = "Tension Ur"
        '
        'Tension_Ur
        '
        Me.Tension_Ur.Location = New System.Drawing.Point(202, 450)
        Me.Tension_Ur.Name = "Tension_Ur"
        Me.Tension_Ur.ReadOnly = True
        Me.Tension_Ur.Size = New System.Drawing.Size(58, 20)
        Me.Tension_Ur.TabIndex = 32
        Me.Tension_Ur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tension_Uc_texte
        '
        Me.Tension_Uc_texte.AutoSize = True
        Me.Tension_Uc_texte.ForeColor = System.Drawing.Color.Green
        Me.Tension_Uc_texte.Location = New System.Drawing.Point(300, 434)
        Me.Tension_Uc_texte.Name = "Tension_Uc_texte"
        Me.Tension_Uc_texte.Size = New System.Drawing.Size(62, 13)
        Me.Tension_Uc_texte.TabIndex = 35
        Me.Tension_Uc_texte.Text = "Tension Uc"
        '
        'Tension_Uc
        '
        Me.Tension_Uc.Location = New System.Drawing.Point(302, 450)
        Me.Tension_Uc.Name = "Tension_Uc"
        Me.Tension_Uc.ReadOnly = True
        Me.Tension_Uc.Size = New System.Drawing.Size(58, 20)
        Me.Tension_Uc.TabIndex = 34
        Me.Tension_Uc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tension_UL_texte
        '
        Me.Tension_UL_texte.AutoSize = True
        Me.Tension_UL_texte.ForeColor = System.Drawing.Color.Red
        Me.Tension_UL_texte.Location = New System.Drawing.Point(407, 434)
        Me.Tension_UL_texte.Name = "Tension_UL_texte"
        Me.Tension_UL_texte.Size = New System.Drawing.Size(62, 13)
        Me.Tension_UL_texte.TabIndex = 37
        Me.Tension_UL_texte.Text = "Tension UL"
        '
        'Tension_UL
        '
        Me.Tension_UL.Location = New System.Drawing.Point(409, 450)
        Me.Tension_UL.Name = "Tension_UL"
        Me.Tension_UL.ReadOnly = True
        Me.Tension_UL.Size = New System.Drawing.Size(58, 20)
        Me.Tension_UL.TabIndex = 36
        Me.Tension_UL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fréquence_résonnance_texte
        '
        Me.Fréquence_résonnance_texte.AutoSize = True
        Me.Fréquence_résonnance_texte.Location = New System.Drawing.Point(38, 314)
        Me.Fréquence_résonnance_texte.Name = "Fréquence_résonnance_texte"
        Me.Fréquence_résonnance_texte.Size = New System.Drawing.Size(126, 13)
        Me.Fréquence_résonnance_texte.TabIndex = 39
        Me.Fréquence_résonnance_texte.Text = "Fréquence de résonance"
        '
        'Fréquence_résonance
        '
        Me.Fréquence_résonance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Fréquence_résonance.ForeColor = System.Drawing.Color.Black
        Me.Fréquence_résonance.Location = New System.Drawing.Point(40, 330)
        Me.Fréquence_résonance.Name = "Fréquence_résonance"
        Me.Fréquence_résonance.ReadOnly = True
        Me.Fréquence_résonance.Size = New System.Drawing.Size(124, 20)
        Me.Fréquence_résonance.TabIndex = 38
        Me.Fréquence_résonance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bande_passante_texte
        '
        Me.Bande_passante_texte.AutoSize = True
        Me.Bande_passante_texte.Location = New System.Drawing.Point(389, 370)
        Me.Bande_passante_texte.Name = "Bande_passante_texte"
        Me.Bande_passante_texte.Size = New System.Drawing.Size(84, 13)
        Me.Bande_passante_texte.TabIndex = 42
        Me.Bande_passante_texte.Text = "Bande passante"
        '
        'Bande_passante
        '
        Me.Bande_passante.Location = New System.Drawing.Point(370, 386)
        Me.Bande_passante.Name = "Bande_passante"
        Me.Bande_passante.ReadOnly = True
        Me.Bande_passante.Size = New System.Drawing.Size(124, 20)
        Me.Bande_passante.TabIndex = 41
        Me.Bande_passante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fréquence_haut_texte
        '
        Me.Fréquence_haut_texte.AutoSize = True
        Me.Fréquence_haut_texte.Location = New System.Drawing.Point(205, 370)
        Me.Fréquence_haut_texte.Name = "Fréquence_haut_texte"
        Me.Fréquence_haut_texte.Size = New System.Drawing.Size(139, 13)
        Me.Fréquence_haut_texte.TabIndex = 44
        Me.Fréquence_haut_texte.Tag = ""
        Me.Fréquence_haut_texte.Text = "Fréquence de coupure haut"
        '
        'fréquence_coupure_haut
        '
        Me.fréquence_coupure_haut.Location = New System.Drawing.Point(212, 386)
        Me.fréquence_coupure_haut.Name = "fréquence_coupure_haut"
        Me.fréquence_coupure_haut.ReadOnly = True
        Me.fréquence_coupure_haut.Size = New System.Drawing.Size(124, 20)
        Me.fréquence_coupure_haut.TabIndex = 43
        Me.fréquence_coupure_haut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fréquence_bas_texte
        '
        Me.Fréquence_bas_texte.AutoSize = True
        Me.Fréquence_bas_texte.Location = New System.Drawing.Point(33, 370)
        Me.Fréquence_bas_texte.Name = "Fréquence_bas_texte"
        Me.Fréquence_bas_texte.Size = New System.Drawing.Size(135, 13)
        Me.Fréquence_bas_texte.TabIndex = 46
        Me.Fréquence_bas_texte.Text = "Fréquence de coupure bas"
        '
        'Fréquence_coupure_bas
        '
        Me.Fréquence_coupure_bas.Location = New System.Drawing.Point(39, 386)
        Me.Fréquence_coupure_bas.Name = "Fréquence_coupure_bas"
        Me.Fréquence_coupure_bas.ReadOnly = True
        Me.Fréquence_coupure_bas.Size = New System.Drawing.Size(124, 20)
        Me.Fréquence_coupure_bas.TabIndex = 45
        Me.Fréquence_coupure_bas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Echelle
        '
        Me.Echelle.Location = New System.Drawing.Point(759, 476)
        Me.Echelle.Maximum = 280
        Me.Echelle.Name = "Echelle"
        Me.Echelle.Size = New System.Drawing.Size(284, 45)
        Me.Echelle.TabIndex = 49
        Me.Echelle.Value = 1
        '
        'Diagramme_fresnel_texte
        '
        Me.Diagramme_fresnel_texte.AutoSize = True
        Me.Diagramme_fresnel_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diagramme_fresnel_texte.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Diagramme_fresnel_texte.Location = New System.Drawing.Point(815, 87)
        Me.Diagramme_fresnel_texte.Name = "Diagramme_fresnel_texte"
        Me.Diagramme_fresnel_texte.Size = New System.Drawing.Size(170, 20)
        Me.Diagramme_fresnel_texte.TabIndex = 50
        Me.Diagramme_fresnel_texte.Text = "Diagramme de Fresnel"
        '
        'RLC_série
        '
        Me.RLC_série.AutoSize = True
        Me.RLC_série.Location = New System.Drawing.Point(40, 69)
        Me.RLC_série.Name = "RLC_série"
        Me.RLC_série.Size = New System.Drawing.Size(71, 17)
        Me.RLC_série.TabIndex = 51
        Me.RLC_série.TabStop = True
        Me.RLC_série.Text = "RLC série"
        Me.RLC_série.UseVisualStyleBackColor = True
        '
        'RLC_parallèle
        '
        Me.RLC_parallèle.AutoSize = True
        Me.RLC_parallèle.Location = New System.Drawing.Point(139, 69)
        Me.RLC_parallèle.Name = "RLC_parallèle"
        Me.RLC_parallèle.Size = New System.Drawing.Size(88, 17)
        Me.RLC_parallèle.TabIndex = 52
        Me.RLC_parallèle.TabStop = True
        Me.RLC_parallèle.Text = "RLC parallèle"
        Me.RLC_parallèle.UseVisualStyleBackColor = True
        '
        'Diagramme_texte
        '
        Me.Diagramme_texte.AutoSize = True
        Me.Diagramme_texte.Location = New System.Drawing.Point(827, 430)
        Me.Diagramme_texte.Name = "Diagramme_texte"
        Me.Diagramme_texte.Size = New System.Drawing.Size(0, 13)
        Me.Diagramme_texte.TabIndex = 53
        '
        'RC_série
        '
        Me.RC_série.AutoSize = True
        Me.RC_série.Location = New System.Drawing.Point(239, 69)
        Me.RC_série.Name = "RC_série"
        Me.RC_série.Size = New System.Drawing.Size(65, 17)
        Me.RC_série.TabIndex = 54
        Me.RC_série.TabStop = True
        Me.RC_série.Text = "RC série"
        Me.RC_série.UseVisualStyleBackColor = True
        '
        'RL_série
        '
        Me.RL_série.AutoSize = True
        Me.RL_série.Location = New System.Drawing.Point(337, 69)
        Me.RL_série.Name = "RL_série"
        Me.RL_série.Size = New System.Drawing.Size(64, 17)
        Me.RL_série.TabIndex = 55
        Me.RL_série.TabStop = True
        Me.RL_série.Text = "RL série"
        Me.RL_série.UseVisualStyleBackColor = True
        '
        'Tension_UL_eff
        '
        Me.Tension_UL_eff.Location = New System.Drawing.Point(409, 473)
        Me.Tension_UL_eff.Name = "Tension_UL_eff"
        Me.Tension_UL_eff.ReadOnly = True
        Me.Tension_UL_eff.Size = New System.Drawing.Size(58, 20)
        Me.Tension_UL_eff.TabIndex = 64
        Me.Tension_UL_eff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tension_Uc_eff
        '
        Me.Tension_Uc_eff.Location = New System.Drawing.Point(302, 473)
        Me.Tension_Uc_eff.Name = "Tension_Uc_eff"
        Me.Tension_Uc_eff.ReadOnly = True
        Me.Tension_Uc_eff.Size = New System.Drawing.Size(58, 20)
        Me.Tension_Uc_eff.TabIndex = 63
        Me.Tension_Uc_eff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tension_Ur_eff
        '
        Me.Tension_Ur_eff.Location = New System.Drawing.Point(202, 473)
        Me.Tension_Ur_eff.Name = "Tension_Ur_eff"
        Me.Tension_Ur_eff.ReadOnly = True
        Me.Tension_Ur_eff.Size = New System.Drawing.Size(58, 20)
        Me.Tension_Ur_eff.TabIndex = 62
        Me.Tension_Ur_eff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'intensité_eff
        '
        Me.intensité_eff.Location = New System.Drawing.Point(105, 473)
        Me.intensité_eff.Name = "intensité_eff"
        Me.intensité_eff.ReadOnly = True
        Me.intensité_eff.Size = New System.Drawing.Size(58, 20)
        Me.intensité_eff.TabIndex = 61
        Me.intensité_eff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Max_texte
        '
        Me.Max_texte.AutoSize = True
        Me.Max_texte.Location = New System.Drawing.Point(37, 453)
        Me.Max_texte.Name = "Max_texte"
        Me.Max_texte.Size = New System.Drawing.Size(51, 13)
        Me.Max_texte.TabIndex = 65
        Me.Max_texte.Text = "Maximum"
        '
        'Eff_texte
        '
        Me.Eff_texte.AutoSize = True
        Me.Eff_texte.Location = New System.Drawing.Point(37, 476)
        Me.Eff_texte.Name = "Eff_texte"
        Me.Eff_texte.Size = New System.Drawing.Size(46, 13)
        Me.Eff_texte.TabIndex = 66
        Me.Eff_texte.Text = "Efficace"
        '
        'Puissance_active_texte
        '
        Me.Puissance_active_texte.AutoSize = True
        Me.Puissance_active_texte.Location = New System.Drawing.Point(40, 517)
        Me.Puissance_active_texte.Name = "Puissance_active_texte"
        Me.Puissance_active_texte.Size = New System.Drawing.Size(88, 13)
        Me.Puissance_active_texte.TabIndex = 72
        Me.Puissance_active_texte.Text = "Puissance active"
        '
        'Puissance_active
        '
        Me.Puissance_active.Location = New System.Drawing.Point(43, 533)
        Me.Puissance_active.Name = "Puissance_active"
        Me.Puissance_active.ReadOnly = True
        Me.Puissance_active.Size = New System.Drawing.Size(85, 20)
        Me.Puissance_active.TabIndex = 71
        Me.Puissance_active.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Facteur_puissance_texte
        '
        Me.Facteur_puissance_texte.AutoSize = True
        Me.Facteur_puissance_texte.Location = New System.Drawing.Point(362, 517)
        Me.Facteur_puissance_texte.Name = "Facteur_puissance_texte"
        Me.Facteur_puissance_texte.Size = New System.Drawing.Size(109, 13)
        Me.Facteur_puissance_texte.TabIndex = 70
        Me.Facteur_puissance_texte.Text = "Facteur de puissance"
        '
        'Facteur_puissance
        '
        Me.Facteur_puissance.Location = New System.Drawing.Point(386, 533)
        Me.Facteur_puissance.Name = "Facteur_puissance"
        Me.Facteur_puissance.ReadOnly = True
        Me.Facteur_puissance.Size = New System.Drawing.Size(58, 20)
        Me.Facteur_puissance.TabIndex = 69
        Me.Facteur_puissance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Puissance_apparente_texte
        '
        Me.Puissance_apparente_texte.AutoSize = True
        Me.Puissance_apparente_texte.Location = New System.Drawing.Point(246, 517)
        Me.Puissance_apparente_texte.Name = "Puissance_apparente_texte"
        Me.Puissance_apparente_texte.Size = New System.Drawing.Size(107, 13)
        Me.Puissance_apparente_texte.TabIndex = 68
        Me.Puissance_apparente_texte.Text = "Puissance apparente"
        '
        'Puissance_apparente
        '
        Me.Puissance_apparente.Location = New System.Drawing.Point(250, 533)
        Me.Puissance_apparente.Name = "Puissance_apparente"
        Me.Puissance_apparente.ReadOnly = True
        Me.Puissance_apparente.Size = New System.Drawing.Size(94, 20)
        Me.Puissance_apparente.TabIndex = 67
        Me.Puissance_apparente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Puissance_réactive_texte
        '
        Me.Puissance_réactive_texte.AutoSize = True
        Me.Puissance_réactive_texte.Location = New System.Drawing.Point(145, 517)
        Me.Puissance_réactive_texte.Name = "Puissance_réactive_texte"
        Me.Puissance_réactive_texte.Size = New System.Drawing.Size(97, 13)
        Me.Puissance_réactive_texte.TabIndex = 74
        Me.Puissance_réactive_texte.Text = "Puissance réactive"
        '
        'Puissance_réactive
        '
        Me.Puissance_réactive.Location = New System.Drawing.Point(148, 533)
        Me.Puissance_réactive.Name = "Puissance_réactive"
        Me.Puissance_réactive.ReadOnly = True
        Me.Puissance_réactive.Size = New System.Drawing.Size(84, 20)
        Me.Puissance_réactive.TabIndex = 73
        Me.Puissance_réactive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Montage
        '
        Me.Montage.BackColor = System.Drawing.Color.Transparent
        Me.Montage.Image = CType(resources.GetObject("Montage.Image"), System.Drawing.Image)
        Me.Montage.Location = New System.Drawing.Point(567, 136)
        Me.Montage.Name = "Montage"
        Me.Montage.Size = New System.Drawing.Size(186, 284)
        Me.Montage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Montage.TabIndex = 60
        Me.Montage.TabStop = False
        '
        'Fresnel
        '
        Me.Fresnel.BackColor = System.Drawing.Color.Transparent
        Me.Fresnel.Location = New System.Drawing.Point(759, 136)
        Me.Fresnel.Name = "Fresnel"
        Me.Fresnel.Size = New System.Drawing.Size(284, 284)
        Me.Fresnel.TabIndex = 40
        Me.Fresnel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(596, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Clique sur l'image pour Bode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(807, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Clique sur diagramme pour les courbes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(595, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Scéma du circuit"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Puissance_réactive_texte)
        Me.Controls.Add(Me.Puissance_réactive)
        Me.Controls.Add(Me.Puissance_active_texte)
        Me.Controls.Add(Me.Puissance_active)
        Me.Controls.Add(Me.Facteur_puissance_texte)
        Me.Controls.Add(Me.Facteur_puissance)
        Me.Controls.Add(Me.Puissance_apparente_texte)
        Me.Controls.Add(Me.Puissance_apparente)
        Me.Controls.Add(Me.Eff_texte)
        Me.Controls.Add(Me.Max_texte)
        Me.Controls.Add(Me.Tension_UL_eff)
        Me.Controls.Add(Me.Tension_Uc_eff)
        Me.Controls.Add(Me.Tension_Ur_eff)
        Me.Controls.Add(Me.intensité_eff)
        Me.Controls.Add(Me.Montage)
        Me.Controls.Add(Me.RL_série)
        Me.Controls.Add(Me.RC_série)
        Me.Controls.Add(Me.Diagramme_texte)
        Me.Controls.Add(Me.RLC_parallèle)
        Me.Controls.Add(Me.RLC_série)
        Me.Controls.Add(Me.Diagramme_fresnel_texte)
        Me.Controls.Add(Me.Echelle)
        Me.Controls.Add(Me.Fréquence_bas_texte)
        Me.Controls.Add(Me.Fréquence_coupure_bas)
        Me.Controls.Add(Me.Fréquence_haut_texte)
        Me.Controls.Add(Me.fréquence_coupure_haut)
        Me.Controls.Add(Me.Bande_passante_texte)
        Me.Controls.Add(Me.Bande_passante)
        Me.Controls.Add(Me.Fresnel)
        Me.Controls.Add(Me.Fréquence_résonnance_texte)
        Me.Controls.Add(Me.Fréquence_résonance)
        Me.Controls.Add(Me.Tension_UL_texte)
        Me.Controls.Add(Me.Tension_UL)
        Me.Controls.Add(Me.Tension_Uc_texte)
        Me.Controls.Add(Me.Tension_Uc)
        Me.Controls.Add(Me.Tension_Ur_texte)
        Me.Controls.Add(Me.Tension_Ur)
        Me.Controls.Add(Me.Intensité_texte)
        Me.Controls.Add(Me.Intensité)
        Me.Controls.Add(Me.Circuit)
        Me.Controls.Add(Me.Déphasage_texte)
        Me.Controls.Add(Me.Déphasage)
        Me.Controls.Add(Me.Facteur_qualité_texte)
        Me.Controls.Add(Me.Facteur_qualité)
        Me.Controls.Add(Me.Impédance_texte)
        Me.Controls.Add(Me.Impédance)
        Me.Controls.Add(Me.Réactance_inductive_texte)
        Me.Controls.Add(Me.Réactance_inductive)
        Me.Controls.Add(Me.Réactance_capacitive_texte)
        Me.Controls.Add(Me.Réactance_capacitive)
        Me.Controls.Add(Me.Résistance_vraie_texte)
        Me.Controls.Add(Me.Résistance1)
        Me.Controls.Add(Me.tension_efficace_text)
        Me.Controls.Add(Me.Tension_efficace)
        Me.Controls.Add(Me.Période_texte)
        Me.Controls.Add(Me.Période)
        Me.Controls.Add(Me.Pulsation_texte)
        Me.Controls.Add(Me.Pulsation)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Inductance)
        Me.Controls.Add(Me.Inductance_texte)
        Me.Controls.Add(Me.Capacité)
        Me.Controls.Add(Me.Capacité_texte)
        Me.Controls.Add(Me.Résistance)
        Me.Controls.Add(Me.Résistance_texte)
        Me.Controls.Add(Me.Tension)
        Me.Controls.Add(Me.Tension_texte)
        Me.Controls.Add(Me.Fréquence_texte)
        Me.Controls.Add(Me.Fréquence)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Text = "Le circuit RLC"
        CType(Me.Echelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Montage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fresnel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fréquence As System.Windows.Forms.TextBox
    Friend WithEvents Fréquence_texte As System.Windows.Forms.Label
    Friend WithEvents Tension_texte As System.Windows.Forms.Label
    Friend WithEvents Tension As System.Windows.Forms.TextBox
    Friend WithEvents Résistance As System.Windows.Forms.TextBox
    Friend WithEvents Résistance_texte As System.Windows.Forms.Label
    Friend WithEvents Capacité As System.Windows.Forms.TextBox
    Friend WithEvents Capacité_texte As System.Windows.Forms.Label
    Friend WithEvents Inductance As System.Windows.Forms.TextBox
    Friend WithEvents Inductance_texte As System.Windows.Forms.Label
    Friend WithEvents Titre As System.Windows.Forms.Label
    Friend WithEvents Pulsation As System.Windows.Forms.TextBox
    Friend WithEvents Pulsation_texte As System.Windows.Forms.Label
    Friend WithEvents Période_texte As System.Windows.Forms.Label
    Friend WithEvents Période As System.Windows.Forms.TextBox
    Friend WithEvents tension_efficace_text As System.Windows.Forms.Label
    Friend WithEvents Tension_efficace As System.Windows.Forms.TextBox
    Friend WithEvents Résistance_vraie_texte As System.Windows.Forms.Label
    Friend WithEvents Résistance1 As System.Windows.Forms.TextBox
    Friend WithEvents Réactance_capacitive_texte As System.Windows.Forms.Label
    Friend WithEvents Réactance_capacitive As System.Windows.Forms.TextBox
    Friend WithEvents Réactance_inductive_texte As System.Windows.Forms.Label
    Friend WithEvents Réactance_inductive As System.Windows.Forms.TextBox
    Friend WithEvents Impédance_texte As System.Windows.Forms.Label
    Friend WithEvents Impédance As System.Windows.Forms.TextBox
    Friend WithEvents Facteur_qualité_texte As System.Windows.Forms.Label
    Friend WithEvents Facteur_qualité As System.Windows.Forms.TextBox
    Friend WithEvents Déphasage_texte As System.Windows.Forms.Label
    Friend WithEvents Déphasage As System.Windows.Forms.TextBox
    Friend WithEvents Circuit As System.Windows.Forms.Label
    Friend WithEvents Intensité_texte As System.Windows.Forms.Label
    Friend WithEvents Intensité As System.Windows.Forms.TextBox
    Friend WithEvents Tension_Ur_texte As System.Windows.Forms.Label
    Friend WithEvents Tension_Ur As System.Windows.Forms.TextBox
    Friend WithEvents Tension_Uc_texte As System.Windows.Forms.Label
    Friend WithEvents Tension_Uc As System.Windows.Forms.TextBox
    Friend WithEvents Tension_UL_texte As System.Windows.Forms.Label
    Friend WithEvents Tension_UL As System.Windows.Forms.TextBox
    Friend WithEvents Fréquence_résonnance_texte As System.Windows.Forms.Label
    Friend WithEvents Fréquence_résonance As System.Windows.Forms.TextBox
    Friend WithEvents Fresnel As System.Windows.Forms.PictureBox
    Friend WithEvents Bande_passante_texte As System.Windows.Forms.Label
    Friend WithEvents Bande_passante As System.Windows.Forms.TextBox
    Friend WithEvents Fréquence_haut_texte As System.Windows.Forms.Label
    Friend WithEvents fréquence_coupure_haut As System.Windows.Forms.TextBox
    Friend WithEvents Fréquence_bas_texte As System.Windows.Forms.Label
    Friend WithEvents Fréquence_coupure_bas As System.Windows.Forms.TextBox
    Friend WithEvents Echelle As System.Windows.Forms.TrackBar
    Friend WithEvents Diagramme_fresnel_texte As System.Windows.Forms.Label
    Friend WithEvents RLC_série As System.Windows.Forms.RadioButton
    Friend WithEvents RLC_parallèle As System.Windows.Forms.RadioButton
    Friend WithEvents Diagramme_texte As System.Windows.Forms.Label
    Friend WithEvents RC_série As System.Windows.Forms.RadioButton
    Friend WithEvents RL_série As System.Windows.Forms.RadioButton
    Friend WithEvents Montage As System.Windows.Forms.PictureBox
    Friend WithEvents Tension_UL_eff As System.Windows.Forms.TextBox
    Friend WithEvents Tension_Uc_eff As System.Windows.Forms.TextBox
    Friend WithEvents Tension_Ur_eff As System.Windows.Forms.TextBox
    Friend WithEvents intensité_eff As System.Windows.Forms.TextBox
    Friend WithEvents Max_texte As System.Windows.Forms.Label
    Friend WithEvents Eff_texte As System.Windows.Forms.Label
    Friend WithEvents Puissance_active_texte As System.Windows.Forms.Label
    Friend WithEvents Puissance_active As System.Windows.Forms.TextBox
    Friend WithEvents Facteur_puissance_texte As System.Windows.Forms.Label
    Friend WithEvents Facteur_puissance As System.Windows.Forms.TextBox
    Friend WithEvents Puissance_apparente_texte As System.Windows.Forms.Label
    Friend WithEvents Puissance_apparente As System.Windows.Forms.TextBox
    Friend WithEvents Puissance_réactive_texte As System.Windows.Forms.Label
    Friend WithEvents Puissance_réactive As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
