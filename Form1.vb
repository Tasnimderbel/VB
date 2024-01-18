Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Sc.SplitterDistance > 90 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Sc.SplitterDistance > 90 Then
            Sc.SplitterDistance -= 15
        Else
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Sc.SplitterDistance < 250 Then
            Sc.SplitterDistance += 15
        Else
            Timer2.Enabled = False
        End If

    End Sub
    Sub switchpanel(ByVal pannel As Form)
        Sc.Panel2.Controls.Clear()
        pannel.TopLevel = False
        Sc.Panel2.Controls.Add(pannel)
        pannel.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        switchpanel(Fournisseur)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        switchpanel(Facture)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        switchpanel(Article)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ouvrir()
    End Sub
End Class
