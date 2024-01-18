Public Class Fournisseur_mode_deconnectée

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dap.Fill(ds, "fournisseur")
        Dim rows() As DataRow = ds.Tables("fournisseur").Select("Code_fr = '" & CInt(Code_fr.Text) & "'")
        If rows.Length > 0 Then
            Dim row As DataRow = rows(0)
            Dim res As DialogResult = MessageBox.Show("Voulez-vous modifier ce fournisseur ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = DialogResult.Yes Then
                row("Code_fr") = Code_fr.Text
                row("Nom_fr") = Nom_fr.Text
                row("Pre_fr") = Pre_fr.Text
                row("Adr_fr") = Adr_fr.Text
                row("Email_fr") = Email_fr.Text
                row("Tel_fr") = CInt(Tel_fr.Text)
                Dim cmbuild As New SqlCommandBuilder(dap)
                dap.Update(ds, "fournisseur")
                ds.Clear()
                dap.Fill(ds, "fournisseur")
                MessageBox.Show("Le fournisseur a été modifié.")
                dgv.DataSource = ds.Tables("fournisseur")
            End If
        Else
            MessageBox.Show("Le fournisseur avec le code " & Code_fr.Text & " n'a pas été trouvé.")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim query As String = "DELETE FROM fournisseur WHERE Code_fr = @Code_fr"
        Dim codeParam As New SqlParameter("@Code_fr", SqlDbType.Int)
        codeParam.Value = CInt(Code_fr.Text)
        cn.Open()
        Dim result As DialogResult = MessageBox.Show("Voulez-vous supprimer ce fournisseur ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Le fournisseur a été supprimé avec succès.")
            Catch ex As Exception
                MessageBox.Show("Une erreur s'est produite lors de la suppression du fournisseur : " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            dtr = ds.Tables("fournisseur").NewRow()
            dtr("Code_fr") = CInt(Code_fr.Text)
            dtr("Nom_fr") = Nom_fr.Text
            dtr("Pre_fr") = Pre_fr.Text
            dtr("Adr_fr") = Adr_fr.Text
            dtr("Email_fr") = Email_fr.Text
            dtr("Tel_fr") = Tel_fr.Text
            ds.Tables("fournisseur").Rows.Add(dtr)
            cmbuild = New SqlCommandBuilder(dap)
            dap.Update(ds, "fournisseur")
            ds.Clear()
            dap.Fill(ds, "fournisseur")
            DGV1.DataSource = ds.Tables("fournisseur")
            MessageBox.Show("Le fournisseur a été ajouter")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class