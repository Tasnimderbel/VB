<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Article_mode_deconnectée
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
        Me.t_r = New System.Windows.Forms.TextBox()
        Me.DGV4 = New System.Windows.Forms.DataGridView()
        Me.Num_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desg_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qte_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_r
        '
        Me.t_r.Location = New System.Drawing.Point(495, 231)
        Me.t_r.Name = "t_r"
        Me.t_r.Size = New System.Drawing.Size(106, 22)
        Me.t_r.TabIndex = 27
        '
        'DGV4
        '
        Me.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num_art, Me.Desg_art, Me.Prix_art, Me.Qte_art})
        Me.DGV4.Location = New System.Drawing.Point(22, 290)
        Me.DGV4.Name = "DGV4"
        Me.DGV4.RowTemplate.Height = 24
        Me.DGV4.Size = New System.Drawing.Size(458, 77)
        Me.DGV4.TabIndex = 26
        '
        'Num_art
        '
        Me.Num_art.HeaderText = "Num_art"
        Me.Num_art.Name = "Num_art"
        '
        'Desg_art
        '
        Me.Desg_art.HeaderText = "Desg_art"
        Me.Desg_art.Name = "Desg_art"
        '
        'Prix_art
        '
        Me.Prix_art.HeaderText = "Prix_art"
        Me.Prix_art.Name = "Prix_art"
        '
        'Qte_art
        '
        Me.Qte_art.HeaderText = "Qte_art"
        Me.Qte_art.Name = "Qte_art"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(140, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(84, 22)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(140, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(84, 22)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 22)
        Me.TextBox2.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 22)
        Me.TextBox1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Qte_art"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Prix_art"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Desg_art"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Num_art"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.téléchargement33331
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(351, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 47)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Rechercher"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(544, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 35)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(544, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(544, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Article_mode_deconnectée
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 382)
        Me.Controls.Add(Me.t_r)
        Me.Controls.Add(Me.DGV4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Article_mode_deconnectée"
        Me.Text = "Article_mode_deconnectée"
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_r As System.Windows.Forms.TextBox
    Friend WithEvents DGV4 As System.Windows.Forms.DataGridView
    Friend WithEvents Num_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desg_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prix_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qte_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
