Public Class Fournisseur
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.Connection = cn
            dr.Close()
            cmd.CommandText = "select*from Fournisseur where code_fr='" & CInt(ComboBox1.Text) & " ' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Attention Fournisseur existe déja")
                ComboBox1.Focus()
            Else
                dr.Close()
                cmd.CommandText = "insert into Fournisseur values('" & ComboBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("Ajouter avec succée")
                DGV1.Rows.Add(ComboBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim res As DialogResult
            res = MessageBox.Show("voulez vous modifier cet Fournisseur ?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "update Fournisseur  set Code_fr='" & ComboBox1.Text & "', Nom_fr='" & TextBox2.Text & "',Pre_fr='" & TextBox3.Text & "',Adr_fr='" & TextBox4.Text & "',Email_fr='" & TextBox5.Text & "',Tel_fr='" & CInt(TextBox6.Text) & "' WHERE  Code_fr='" & CInt(ComboBox1.Text) & "'"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("Le fournisseur a été modifier avec succée")
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim res As DialogResult
            res = MessageBox.Show("Voulez-vous vraiment supprimer cette fournisseur ?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from Fournisseur WHERE Code_fr='" & CInt(ComboBox1.Text) & "'"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("le fournisseur a été supprimé avec succès")
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        cmd.Connection = cn
        cmd.CommandText = "select * from Fournisseur WHERE Code_fr='" & CInt(t_r.Text) & "'"
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()
            If dr.HasRows Then
            ComboBox1.Text = dr.GetValue(0)
            TextBox2.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox4.Text = dr.GetValue(3)
            TextBox5.Text = dr.GetValue(4)
            TextBox6.Text = dr.GetValue(5)
            Else
            MessageBox.Show("Fournisseur n'existe pas")
        End If
            dr.Close()
    End Sub
    Private Sub Fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        cmd.Connection = cn
        cmd.CommandText = "select * from Fournisseur"
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        While dr.Read
            DGV1.Rows.Insert(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5))
            i = i + 1
        End While
        dr.Close()
    End Sub

    Private Sub DGV1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV1.CellDoubleClick
        Dim ligne As Integer = DGV1.CurrentRow.Index
        ComboBox1.Text = DGV1(0, ligne).Value
        TextBox2.Text = DGV1(1, ligne).Value
        TextBox3.Text = DGV1(2, ligne).Value
        TextBox4.Text = DGV1(3, ligne).Value
        TextBox5.Text = DGV1(4, ligne).Value
        TextBox6.Text = DGV1(5, ligne).Value
    End Sub
End Class