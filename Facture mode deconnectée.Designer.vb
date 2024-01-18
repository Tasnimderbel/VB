<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facture_mode_deconnectée
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGV3 = New System.Windows.Forms.DataGridView()
        Me.Code_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_fac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(95, 137)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(90, 24)
        Me.ComboBox2.TabIndex = 43
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Khaki
        Me.Button4.Location = New System.Drawing.Point(519, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 41)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(519, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 39)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Mdifier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(519, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 182)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 22)
        Me.DateTimePicker1.TabIndex = 39
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 24)
        Me.ComboBox1.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Location = New System.Drawing.Point(519, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 41)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DGV3
        '
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code_fr, Me.Num_fac, Me.Num_art, Me.Qte, Me.Prix, Me.Mnt, Me.Tva})
        Me.DGV3.Location = New System.Drawing.Point(4, 308)
        Me.DGV3.Name = "DGV3"
        Me.DGV3.RowTemplate.Height = 24
        Me.DGV3.Size = New System.Drawing.Size(750, 100)
        Me.DGV3.TabIndex = 36
        '
        'Code_fr
        '
        Me.Code_fr.HeaderText = "Code_fr"
        Me.Code_fr.Name = "Code_fr"
        '
        'Num_fac
        '
        Me.Num_fac.HeaderText = "Num_fac"
        Me.Num_fac.Name = "Num_fac"
        '
        'Num_art
        '
        Me.Num_art.HeaderText = "Num_art"
        Me.Num_art.Name = "Num_art"
        '
        'Qte
        '
        Me.Qte.HeaderText = "Qte"
        Me.Qte.Name = "Qte"
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        '
        'Mnt
        '
        Me.Mnt.HeaderText = "Mnt"
        Me.Mnt.Name = "Mnt"
        '
        'Tva
        '
        Me.Tva.HeaderText = "Tva"
        Me.Tva.Name = "Tva"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Code_pai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Code_fr"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 22)
        Me.TextBox1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Dat_pai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Num_fac"
        '
        'Facture_mode_deconnectée
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 453)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Facture_mode_deconnectée"
        Me.Text = "Facture_mode_deconnectée"
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGV3 As System.Windows.Forms.DataGridView
    Friend WithEvents Code_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_fac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_art As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
