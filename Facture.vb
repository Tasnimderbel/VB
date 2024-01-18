Public Class Facture

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            cmd.Connection = cn
            dr.Close()
            cmd.CommandText = "select*from Facture WHERE Num_fac = " & CInt(TextBox1.Text) & " ' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Attention facture déjà existe!!!")
                TextBox1.Clear()
                TextBox1.Focus()
            Else
                dr.Close()
                cmd.CommandText = "INSERT INTO Facture VALUES('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "')"
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                MessageBox.Show("Le facture a été ajouté avec succès")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim res As DialogResult
        res = MessageBox.Show("voulez vous modifier les cordonnées de cette Facture ?", "attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            cmd.Connection = cn
            cmd.CommandText = "UPDATE Facture Set Num_fac='" & TextBox1.Text & "', Code_fr='" & ComboBox1.Text & "', Code_pai='" & ComboBox2.Text & "', Dat_pai='" & DateTimePicker1.Text & "', WHERE  Num_fac='"
            cmd.CommandType = CommandType.Text
            dr.Close()
            cmd.ExecuteNonQuery()
            DGV3.Update()
            MessageBox.Show("Le facture a été modifier avec succées")
        Else
            MessageBox.Show("modification annulée")
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim res As DialogResult
        res = MessageBox.Show("Voulez-vous vraiment supprimer cette facture ?", "Confirmation de suppression", MessageBoxButtons.YesNo)
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                cmd.Connection = cn
                cmd.CommandText = "DELETE FROM Facture WHERE Num_fac=" & CInt(TextBox1.Text)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
                Dim selectedRow As DataGridViewRow = DGV3.SelectedRows(0)
                DGV3.Rows.Remove(selectedRow)
                MessageBox.Show("Le facture a été supprimé avec succès.")
            Catch ex As Exception
                MessageBox.Show("Erreur lors de la suppression du facture: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Suppression annulée")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM Facture WHERE Num_fac='" & CInt(TextBox1.Text) & "'"
        dr = cmd.ExecuteReader
        Try
            If dr.HasRows Then
                dr.Read()
                TextBox1.Text = dr("Num_fac").ToString()
                ComboBox1.Text = dr("Code_fr").ToString()
                ComboBox2.Text = dr("Code_pai").ToString()
                DateTimePicker1.Text = dr("Dat_pai").ToString()
            Else
                MessageBox.Show("Facture n'existe pas!!!")
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
        End Try
    End Sub
    Private Sub Facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        cmd.CommandText = "select*from Facture"
        Try
            cmd.Connection = cn
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader()
            While dr.Read
                DGV3.Rows.Insert(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3))
                i = i + 1
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGV3_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV3.CellContentClick
        Dim ligne As Integer = DGV3.CurrentRow.Index
        TextBox1.Text = DGV3(0, ligne).Value
        ComboBox1.Text = DGV3(1, ligne).Value
        ComboBox2.Text = DGV3(2, ligne).Value
        DateTimePicker1.Text = DGV3(3, ligne).Value
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim command As String = "INSERT INTO Facture (Num_fac,Code_fr,Code_pai,Dat_pai) VALUES (@Num_fac,@Code_fr,@Code_pai,@Dat_pai)"
        Dim cmd As New SqlClient.SqlCommand(command, cn)
        cmd.Parameters.Add("@Num_fac", SqlDbType.Int)
        cmd.Parameters.Add("@Code_fr", SqlDbType.Int)
        cmd.Parameters.Add("@Code_pai", SqlDbType.NVarChar)
        cmd.Parameters.Add("@Dat_pai", SqlDbType.DateTime2)
        cmd.Parameters("@Num_fac").Value = TextBox1.Text
        cmd.Parameters("@Code_fr").Value = ComboBox1.Text
        cmd.Parameters("@Code_pai").Value = ComboBox2.Text
        cmd.Parameters("@Dat_pai").Value = DateTimePicker1.Text
        MessageBox.Show("Enregistrement effectué avec succés !")
        Try
            Dim c As String = "INSERT INTO Lignefacture(Code_fr,Num_fac,Num_art,Qte,Prix,Mnt,Tva) VALUES (@Code_fr,@Num_fac,@Num_art,@Qte,@Prix,@Mnt,@Tva)"
            Dim cmd2 As New SqlClient.SqlCommand(c, cn)
            cmd2.Parameters.Add("@Code_fr", SqlDbType.Int)
            cmd2.Parameters.Add("@Num_fac", SqlDbType.Int)
            cmd2.Parameters.Add("@Num_art", SqlDbType.Int)
            cmd2.Parameters.Add("@Qte", SqlDbType.Int)
            cmd2.Parameters.Add("@Prix", SqlDbType.Float)
            cmd2.Parameters.Add("@Mnt", SqlDbType.Float)
            cmd2.Parameters.Add("@Tva", SqlDbType.Int)
            For Each row As DataGridView In DGV3.Rows
                cmd2.Parameters("@Code_fr").Value = row.Cells("Column1").value
                cmd2.Parameters("@Num_fac").Value = row.Cells("Column2").value
                cmd2.Parameters("@Num_art").Value = row.Cells("Column3").value
                cmd2.Parameters("@Qte").Value = row.Cells("Column4").value
                cmd2.Parameters("@Prix").Value = row.Cells("Column5").value
                cmd2.Parameters("@Mnt").Value = row.Cells("Column6").value
                cmd2.Parameters("@Tva").Value = row.Cells("Column7").value
                cmd2.ExecuteNonQuery()
                MessageBox.Show("Enregistrement effectué avec sucées !")
                dr.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class