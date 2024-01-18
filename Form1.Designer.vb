<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Sc = New System.Windows.Forms.SplitContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Sc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sc.Panel1.SuspendLayout()
        Me.Sc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(45, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 113)
        Me.Panel1.TabIndex = 0
        '
        'Sc
        '
        Me.Sc.Location = New System.Drawing.Point(43, 166)
        Me.Sc.Name = "Sc"
        '
        'Sc.Panel1
        '
        Me.Sc.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Sc.Panel1.Controls.Add(Me.Button5)
        Me.Sc.Panel1.Controls.Add(Me.Button3)
        Me.Sc.Panel1.Controls.Add(Me.Button2)
        '
        'Sc.Panel2
        '
        Me.Sc.Panel2.BackColor = System.Drawing.Color.LightPink
        Me.Sc.Size = New System.Drawing.Size(1178, 431)
        Me.Sc.SplitterDistance = 392
        Me.Sc.TabIndex = 1
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.WindowsApplication1.My.Resources.Resources.images__1___1___1_
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(21, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(228, 66)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Article"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.facture4
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(21, 156)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(228, 68)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Facture"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.fr
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(21, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 66)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Fournisseur"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.png_clipart_home_assistant_computer_icons_home_automation_kits_amazon_echo_home_blue_logo__1___1___1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(304, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 76)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Home"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 634)
        Me.Controls.Add(Me.Sc)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Sc.Panel1.ResumeLayout(False)
        CType(Me.Sc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sc As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
