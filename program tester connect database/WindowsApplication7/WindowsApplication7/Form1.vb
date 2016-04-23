Imports System.Data.OleDb

Public Class form1
    Private kon As OleDbConnection
    Private Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub grid()
        Dim adr As New OleDbDataAdapter("select*from table1", kon)
    End Sub

    Private Sub form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DatabaseDataSet.Table1)
        Dim koneksi As String = "provider = microsoft.jet.oledb.4.0;data source = C:\Users\adeputra rizki\Documents\Visual Studio 2015\Projects\WindowsApplication7\WindowsApplication7\bin\Debug\database.mdb"
        kon = New OleDbConnection(koneksi)
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
        Call grid()
    End Sub
    Private Sub datagridview1_autigeneratecolchanged(ByVal sender As Object, ByVale As System.EventArgs) Handles DataGridView1.AutoGenerateColumnsChanged
    End Sub

    Private Sub button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim hapus As String = "insert into table1 values(" & TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & ")"
        Dim cmd As New OleDbCommand(hapus, kon)
        cmd.ExecuteNonQuery()
        Call grid()
    End Sub

    Private Sub button3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim hapus As String = "delete from table1 where nama =" & TextBox1.Text & ""
        Dim cmd As New OleDbCommand(hapus, kon)
        cmd.ExecuteNonQuery()
        Call grid()
    End Sub
    Private Sub button4_click(ByValsender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub button2_clck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.click
        Call bersih()
    End Sub
    Private Sub datagridview1_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        TextBox1.Text = DataGridView1.SelectedCells(0).Value
        TextBox2.Text = DataGridView1.SelectedCells(1).Value
        TextBox3.Text = DataGridView1.SelectedCells(3).Value
    End Sub
End Class

