<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fournisseur_mode_deconnectée
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.t_r = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Code_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pre_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adr_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(83, 24)
        Me.ComboBox1.TabIndex = 36
        '
        't_r
        '
        Me.t_r.Location = New System.Drawing.Point(487, 242)
        Me.t_r.Name = "t_r"
        Me.t_r.Size = New System.Drawing.Size(101, 22)
        Me.t_r.TabIndex = 35
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_fr, Me.Nom_fr, Me.Pre_fr, Me.Adr_fr, Me.Email_fr, Me.Tel_fr})
        Me.DGV1.Location = New System.Drawing.Point(26, 289)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(661, 92)
        Me.DGV1.TabIndex = 34
        '
        'Code_fr
        '
        Me.Code_fr.HeaderText = "Code_fr"
        Me.Code_fr.Name = "Code_fr"
        '
        'Nom_fr
        '
        Me.Nom_fr.HeaderText = "Nom_fr"
        Me.Nom_fr.Name = "Nom_fr"
        '
        'Pre_fr
        '
        Me.Pre_fr.HeaderText = "Pre_fr"
        Me.Pre_fr.Name = "Pre_fr"
        '
        'Adr_fr
        '
        Me.Adr_fr.HeaderText = "Adr_fr"
        Me.Adr_fr.Name = "Adr_fr"
        '
        'Email_fr
        '
        Me.Email_fr.HeaderText = "Email_fr"
        Me.Email_fr.Name = "Email_fr"
        '
        'Tel_fr
        '
        Me.Tel_fr.HeaderText = "Tel_fr"
        Me.Tel_fr.Name = "Tel_fr"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.téléchargement3333
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(313, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 46)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Rechercher"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightPink
        Me.Button3.Location = New System.Drawing.Point(534, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 44)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Plum
        Me.Button2.Location = New System.Drawing.Point(534, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 47)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Location = New System.Drawing.Point(534, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(114, 239)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(83, 22)
        Me.TextBox6.TabIndex = 29
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(114, 196)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(83, 22)
        Me.TextBox5.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(114, 150)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(83, 22)
        Me.TextBox4.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 22)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 22)
        Me.TextBox2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Tel_fr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Email_fr"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Adr_fr"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Pre_fr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nom_fr"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Code_fr"
        '
        'Fournisseur_mode_deconnectée
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 404)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.t_r)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fournisseur_mode_deconnectée"
        Me.Text = "Fournisseur_mode_deconnectée"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents t_r As System.Windows.Forms.TextBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents Code_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pre_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adr_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
