Imports System.Data.SqlClient

Public Class frm_com_info
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_tax_no.Text = Nothing Or txt_com_name.Text = Nothing Then
            MessageBox.Show("Please Write A Company Name Or Tax No")
            Exit Sub
        End If

        CloseCon()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        dt.Clear()

        con.Open()

        cmd = New SqlCommand("Select * From Company_Info", con)
        da = New SqlDataAdapter(cmd)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr("USB_Serial") = lbl_usb.Text Then
                MessageBox.Show("This USB Is Registered Before Under ID: " & dr("ID") & "")
                Exit Sub
            End If

        End If
        dr.Close()
        con.Close()

        Dim command As New SqlCommand("Insert Into Company_Info(Com_Name,Tax_No,Country,Account_State,USB_Serial) values(@name,@tax,@coun,@state,@usb)", con)

        command.Parameters.Add("@name", SqlDbType.NVarChar).Value = txt_com_name.Text
        command.Parameters.Add("@tax", SqlDbType.Float).Value = txt_tax_no.Text
        command.Parameters.Add("@coun", SqlDbType.NVarChar).Value = cb_country.Text
        command.Parameters.Add("@state", SqlDbType.Bit).Value = chb_state.CheckState
        command.Parameters.Add("@usb", SqlDbType.NVarChar).Value = lbl_usb.Text

        con.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Company Added")

        Else

            MessageBox.Show("Company Not Added")

        End If

        con.Close()


    End Sub

    Private Sub chb_state_CheckStateChanged(sender As Object, e As EventArgs) Handles chb_state.CheckStateChanged
        If chb_state.CheckState = CheckState.Checked Then
            chb_state.Text = "True"
        Else
            chb_state.Text = "False"
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_com_name.Text = Nothing
        txt_tax_no.Text = Nothing
        cb_country.SelectedIndex = 0
        chb_state.CheckState = CheckState.Unchecked

    End Sub

    Private Sub frm_com_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_reset.PerformClick()
    End Sub
End Class