Public Class Article
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd.Connection = cn
            dr.Close()
            cmd.CommandText = "select*from Article where Num_art='" & CInt(TextBox1.Text) & " ' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Attention Article existe déja")
                TextBox1.Focus()
            Else
                dr.Close()
                cmd.CommandText = "insert into Article values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("Ajouter avec succée")
                DGV4.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim res As DialogResult
            res = MessageBox.Show("voulez vous modifier cet Article?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "update Article  set Num_art='" & TextBox1.Text & "', Desg_art='" & TextBox2.Text & "',Prix_art='" & TextBox3.Text & "',='" & CInt(TextBox4.Text) & "' WHERE  Num_art='" & CInt(TextBox1.Text) & "'"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("L'article  a été modifier avec succée")
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim res As DialogResult
            res = MessageBox.Show("Voulez-vous vraiment supprimer cet article?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "delete from Article WHERE Num_art='" & CInt(TextBox1.Text) & "'"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("L'article a été supprimé avec succès")
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        cmd.Connection = cn
        cmd.CommandText = "select * from Article WHERE Num_art='" & CInt(t_r.Text) & "'"
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.GetValue(0)
            TextBox2.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox4.Text = dr.GetValue(3)
        Else
            MessageBox.Show("Article n'existe pas")
        End If
        dr.Close()
    End Sub
    Private Sub DGV4_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV4.CellContentClick
        Dim ligne As Integer = DGV4.CurrentRow.Index
        TextBox1.Text = DGV4(0, ligne).Value
        TextBox2.Text = DGV4(1, ligne).Value
        TextBox3.Text = DGV4(2, ligne).Value
        TextBox4.Text = DGV4(3, ligne).Value
    End Sub

    Private Sub Article_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        cmd.Connection = cn
        cmd.CommandText = "select * from Article"
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        While dr.Read
            DGV4.Rows.Insert(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3))
            i = i + 1
        End While
        dr.Close()
    End Sub
End Class