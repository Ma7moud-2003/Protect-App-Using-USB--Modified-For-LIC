Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports mdl_sql

Public Class Verify_USB
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdl_verify.get_USB_serial(txt_usb_serial)
    End Sub

    Private Sub btn_ref_Click(sender As Object, e As EventArgs) Handles btn_ref.Click
        mdl_verify.get_USB_serial(txt_usb_serial)
        txt_code.Clear()
    End Sub

    Private Sub lbl_gen_code_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_gen_code.LinkClicked
        If txt_code.Text = Nothing Then
            mdl_verify.gen_code(txt_code)
        End If

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        mdl_verify.get_USB_serial(txt_usb_serial)
        txt_code.Text = ""
    End Sub

    Private Sub btn_perv_Click(sender As Object, e As EventArgs) Handles btn_perv.Click
        frm_Pervilages.lbl_usb.Text = txt_usb_serial.Text
        frm_Pervilages.ShowDialog()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        Application.Exit()
    End Sub

    Private Sub btn_com_info_Click(sender As Object, e As EventArgs) Handles btn_com_info.Click
        frm_com_info.lbl_usb.Text = txt_usb_serial.Text
        frm_com_info.ShowDialog()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_code.Text = Nothing Or txt_usb_serial.Text = Nothing Then
            MessageBox.Show("Please Check For A USB_Serial Or Generate Code")
            Exit Sub
        End If

        CloseCon()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        dt.Clear()

        con.Open()

        cmd = New SqlCommand("Select * From USB", con)
        da = New SqlDataAdapter(cmd)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr("USB_Serial") = txt_usb_serial.Text Then
                MessageBox.Show("This USB Is Registered Before Under ID: " & dr("ID") & " Delete It Or Change The Serial")
                Exit Sub
            End If

        End If
        dr.Close()
        con.Close()

        Dim command As New SqlCommand("Insert Into USB (USB_Serial, Activation_Code) values(@usb,@code)", con)

        command.Parameters.Add("@usb", SqlDbType.NChar).Value = txt_usb_serial.Text
        command.Parameters.Add("@code", SqlDbType.NChar).Value = txt_code.Text

        con.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New usb Added")
            txt_code.Clear()
        Else

            MessageBox.Show("USB Not Added")

        End If

        con.Close()

    End Sub

    Private Sub btn_usb_Click(sender As Object, e As EventArgs) Handles btn_usb.Click
        frm_USB.ShowDialog()
    End Sub
End Class
