Imports Microsoft.SqlServer
Imports System.Data.SqlClient

Public Class frm_USB
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub frm_USB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tech_Functions.FillDataGrid(dgv, "Select * From v_perv", con)

    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        If dgv.SelectedRows.Count > 0 Then

            Dim usb As String = dgv.SelectedRows(0).Cells("USB_Serial").Value.ToString()

            cmd = New SqlCommand("Select * From v_perv Where USB_Serial=@USB_Serial", con)
            cmd.Parameters.Add("@USB_Serial", SqlDbType.NVarChar).Value = usb

            Tech_Functions.CloseCon()
            con.Open()
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lbl_usb.Text = usb

            End If
            con.Close()
            dr.Close()
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If lbl_usb.Text = Nothing Then
            MessageBox.Show("Please Select A USB To Delete")

        Else
            'Delete Record
            cmd.CommandText = CommandType.Text
            cmd.Connection = con
            cmd = New SqlCommand("Delete From USB Where USB_Serial ='" & lbl_usb.Text & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            cmd = New SqlCommand("Delete From Pervilages Where USB_Serial ='" & lbl_usb.Text & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            cmd = New SqlCommand("Delete From Company_Info Where USB_Serial ='" & lbl_usb.Text & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("USB " & lbl_usb.Text & " " & Space(2) & " Has Deleted Suucessfully")

            Tech_Functions.FillDataGrid(dgv, "Select * From v_perv", con)
        End If

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class