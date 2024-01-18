Public Class Article_mode_deconnectée
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim query As String = "DELETE FROM article WHERE Num_art = @Num_art"
        Dim codeParam As New SqlParameter("@Num_art", SqlDbType.Int)
        codeParam.Value = CInt(Num_art.Text)
        cn.Open()
        Dim result As DialogResult = MessageBox.Show("Voulez-vous supprimer ce article ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Le article a été supprimé avec succès.")
            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite lors de la suppression de l'article : " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        dap.Fill(ds, "article")
        Dim rows() As DataRow = ds.Tables("article").Select("code = '" & CInt(Num_art.Text) & "'")
        If rows.Length > 0 Then
            Dim row As DataRow = rows(0)
            Dim res As DialogResult = MessageBox.Show("Voulez-vous modifier ce article ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = DialogResult.Yes Then
                row("Num_art") = Num_art.Text
                row("Desg_art") = Desg_art.Text
                row("Prix_art") = Prix_art.Text
                row("Qte_art") = Qte_art.Text
                Dim cmbuild As New SqlCommandBuilder(dap)
                dap.Update(ds, "article")
                ds.Clear()
                dap.Fill(ds, "article")
                MessageBox.Show("Le article a été modifié.")
                dgv.DataSource = ds.Tables("article")
            End If
        Else
            MessageBox.Show("L'article avec le code " & Num_art.Text & " n'a pas été trouvé.")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            dtr = ds.Tables("article").NewRow()
            dtr("Num_art") = CInt(Num_art.Text)
            dtr("Desg_art") = Desg_art.Text
            dtr("Prix_art") = Prix_art.Text
            dtr("Qte_art") = Qte_art.Text
            ds.Tables("article").Rows.Add(dtr)
            cmbuild = New SqlCommandBuilder(dap)
            dap.Update(ds, "article")
            ds.Clear()
            dap.Fill(ds, "article")
            dgv.DataSource = ds.Tables("article")
            MessageBox.Show("L'article a été ajouter")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class