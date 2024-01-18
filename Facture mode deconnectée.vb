Public Class Facture_mode_deconnectée

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            dtr = ds.Tables("facture").NewRow()
            dtr("Num_fac") = CInt(Num_fac.Text)
            dtr("Code_fr") = Code_fr.Text
            dtr("Code_pai") = Code_pai.Text
            dtr("Dat_pai") = Dat_pai.Text
            ds.Tables("facture").Rows.Add(dtr)
            cmbuild = New SqlCommandBuilder(dap)
            dap.Update(ds, "facture")
            ds.Clear()
            dap.Fill(ds, "facture")
            dgv.DataSource = ds.Tables("facture")
            MessageBox.Show("Le facture a été ajouter")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        dap.Fill(ds, "facture")
        Dim rows() As DataRow = ds.Tables("facture").Select("code = '" & CInt(Num_fac.Text) & "'")
        If rows.Length > 0 Then
            Dim row As DataRow = rows(0)
            Dim res As DialogResult = MessageBox.Show("Voulez-vous modifier ce facture ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = DialogResult.Yes Then
                row("Num_fac") = Num_fac.Text
                row("Code_fr") = Code_fr.Text
                row("Code_pai") = Code_pai.Text
                row("Dat_pai") = Dat_pai.Text
                Dim cmbuild As New SqlCommandBuilder(dap)
                dap.Update(ds, "facture")
                ds.Clear()
                dap.Fill(ds, "facture")
                MessageBox.Show("Le facture a été modifié.")
                dgv.DataSource = ds.Tables("facture")
            End If
        Else
            MessageBox.Show("Le facture avec le code " & Num_fac.Text & " n'a pas été trouvé.")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim query As String = "DELETE FROM facture WHERE Num_fac = @Num_fac"
        Dim codeParam As New SqlParameter("@Num_fac", SqlDbType.Int)
        codeParam.Value = CInt(Num_fac.Text)
        cn.Open()
        Dim result As DialogResult = MessageBox.Show("Voulez-vous supprimer ce facture ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Le facture a été supprimé avec succès.")
            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite lors de la suppression du facture : " + ex.Message)
            End Try
        End If
    End Sub
End Class