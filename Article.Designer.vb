<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Article
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DGV4 = New System.Windows.Forms.DataGridView()
        Me.Num_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desg_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qte_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_r = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(552, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(552, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(552, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Num_art"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Desg_art"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prix_art"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Qte_art"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 22)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(84, 22)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(148, 151)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(84, 22)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 192)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(84, 22)
        Me.TextBox4.TabIndex = 11
        '
        'DGV4
        '
        Me.DGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num_art, Me.Desg_art, Me.Prix_art, Me.Qte_art})
        Me.DGV4.Location = New System.Drawing.Point(30, 299)
        Me.DGV4.Name = "DGV4"
        Me.DGV4.RowTemplate.Height = 24
        Me.DGV4.Size = New System.Drawing.Size(458, 77)
        Me.DGV4.TabIndex = 12
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
        't_r
        '
        Me.t_r.Location = New System.Drawing.Point(503, 240)
        Me.t_r.Name = "t_r"
        Me.t_r.Size = New System.Drawing.Size(106, 22)
        Me.t_r.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.téléchargement33331
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(359, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Rechercher"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 388)
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
        Me.Name = "Article"
        Me.Text = "Article"
        CType(Me.DGV4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DGV4 As System.Windows.Forms.DataGridView
    Friend WithEvents Num_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desg_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prix_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qte_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_r As System.Windows.Forms.TextBox
End Class
