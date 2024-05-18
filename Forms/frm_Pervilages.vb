Imports System.Data.SqlClient
Imports DevExpress.Utils

Public Class frm_Pervilages
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub frm_Pervilages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clb.SetItemCheckState(0, CheckState.Unchecked)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        CloseCon()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        dt.Clear()

        con.Open()

        cmd = New SqlCommand("Select * From Pervilages", con)
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

        Dim command As New SqlCommand("INSERT INTO [dbo].[Pervilages]
           ([USB_Serial]
           ,[Barcode]
           ,[QR]
           ,[Borrow Quantities]
           ,[Item Coding]
           ,[E Verification R]
           ,[Elecrtonic Verification]
           ,[Expiry Monitoring]
           ,[Item Receive]
           ,[User Register]
           ,[Lot Verification]
           ,[Search Lot]
           ,[Verify Now]
           ,[Lot Track]
           ,[Quantity Receive]
           ,[Tracking All Quantity Used]
           ,[Quantity Loand]
           ,[Reagent Registration]
           ,[Dashboard Designer]
           ,[Descreption]
           ,[Lot To Lot Verfication]
           ,[MSDS]
           ,[Web 1]
           ,[Backup Database]
           ,[Restore Database]
           ,[Tracking All Quantinty Received]
           ,[Create Database]
           ,[Configure Database]
           ,[Receiving From Other Facility / Company]
           ,[Sending To Other Facility / company]
           ,[Quantitys Statistic]
           ,[MSDS report]
           ,[Dashboard Details]
           ,[Leaflets]
           ,[Reagent Withdrawals]
           ,[Temp Monitoring]
           ,[Themes]
           ,[Configure Database icon]
           ,[Invoice]
           ,[Customers-Suppliers]) values(@USB_Serial,@Barcode,@QR,@Borrow,@Item,@E,@Elecrtonic,@Expiry,@ItemReceive,@UserRegister,@LotVerification,@SearchLot,@VerifyNow,@LotTrack,@QuantityReceive,@TrackingAllQuantityUsed,@QuantityLoand,@ReagentRegistration,@DashboardDesigner,@Descreption,@Lot2,@MSDS,@Web,@Back,@Rest,@tq,@Cr_db,@Co_db,@Receiving,@Sending,@Qs,@MS_rep,@dd,@Leaflets,@rw,@Tm,@Themes,@Co_d_i,@Invoice,@cs)", con)

        command.Parameters.Add("@USB_Serial", SqlDbType.NVarChar).Value = lbl_usb.Text
        command.Parameters.Add("@Barcode", SqlDbType.Bit).Value = clb.GetItemCheckState(0)
        command.Parameters.Add("@QR", SqlDbType.Bit).Value = clb.GetItemCheckState(1)
        command.Parameters.Add("@Borrow", SqlDbType.Bit).Value = clb.GetItemCheckState(2)
        command.Parameters.Add("@Item", SqlDbType.Bit).Value = clb.GetItemCheckState(3)
        command.Parameters.Add("@E", SqlDbType.Bit).Value = clb.GetItemCheckState(4)
        command.Parameters.Add("@Elecrtonic", SqlDbType.Bit).Value = clb.GetItemCheckState(5)
        command.Parameters.Add("@Expiry", SqlDbType.Bit).Value = clb.GetItemCheckState(6)
        command.Parameters.Add("@ItemReceive", SqlDbType.Bit).Value = clb.GetItemCheckState(7)
        command.Parameters.Add("@UserRegister", SqlDbType.Bit).Value = clb.GetItemCheckState(8)
        command.Parameters.Add("@LotVerification", SqlDbType.Bit).Value = clb.GetItemCheckState(9)
        command.Parameters.Add("@SearchLot", SqlDbType.Bit).Value = clb.GetItemCheckState(10)
        command.Parameters.Add("@VerifyNow", SqlDbType.Bit).Value = clb.GetItemCheckState(11)
        command.Parameters.Add("@LotTrack", SqlDbType.Bit).Value = clb.GetItemCheckState(12)
        command.Parameters.Add("@QuantityReceive", SqlDbType.Bit).Value = clb.GetItemCheckState(13)
        command.Parameters.Add("@TrackingAllQuantityUsed", SqlDbType.Bit).Value = clb.GetItemCheckState(14)
        command.Parameters.Add("@QuantityLoand", SqlDbType.Bit).Value = clb.GetItemCheckState(15)
        command.Parameters.Add("@ReagentRegistration", SqlDbType.Bit).Value = clb.GetItemCheckState(16)
        command.Parameters.Add("@DashboardDesigner", SqlDbType.Bit).Value = clb.GetItemCheckState(17)
        command.Parameters.Add("@Descreption", SqlDbType.Bit).Value = clb.GetItemCheckState(18)
        command.Parameters.Add("@Lot2", SqlDbType.Bit).Value = clb.GetItemCheckState(19)
        command.Parameters.Add("@MSDS", SqlDbType.Bit).Value = clb.GetItemCheckState(20)
        command.Parameters.Add("@Web", SqlDbType.Bit).Value = clb.GetItemCheckState(21)
        command.Parameters.Add("@Back", SqlDbType.Bit).Value = clb.GetItemCheckState(22)
        command.Parameters.Add("@Rest", SqlDbType.Bit).Value = clb.GetItemCheckState(23)
        command.Parameters.Add("@tq", SqlDbType.Bit).Value = clb.GetItemCheckState(24)
        command.Parameters.Add("@Cr_db", SqlDbType.Bit).Value = clb.GetItemCheckState(25)
        command.Parameters.Add("@Co_db", SqlDbType.Bit).Value = clb.GetItemCheckState(26)
        command.Parameters.Add("@Receiving", SqlDbType.Bit).Value = clb.GetItemCheckState(27)
        command.Parameters.Add("@Sending", SqlDbType.Bit).Value = clb.GetItemCheckState(28)
        command.Parameters.Add("@Qs", SqlDbType.Bit).Value = clb.GetItemCheckState(29)
        command.Parameters.Add("@MS_rep", SqlDbType.Bit).Value = clb.GetItemCheckState(30)
        command.Parameters.Add("@dd", SqlDbType.Bit).Value = clb.GetItemCheckState(31)
        command.Parameters.Add("@Leaflets", SqlDbType.Bit).Value = clb.GetItemCheckState(32)
        command.Parameters.Add("@rw", SqlDbType.Bit).Value = clb.GetItemCheckState(33)
        command.Parameters.Add("@Tm", SqlDbType.Bit).Value = clb.GetItemCheckState(34)
        command.Parameters.Add("@Themes", SqlDbType.Bit).Value = clb.GetItemCheckState(35)
        command.Parameters.Add("@Co_d_i", SqlDbType.Bit).Value = clb.GetItemCheckState(36)
        command.Parameters.Add("@Invoice", SqlDbType.Bit).Value = clb.GetItemCheckState(37)
        command.Parameters.Add("@cs", SqlDbType.Bit).Value = clb.GetItemCheckState(38)


        con.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Pervilages Set")

        Else

            MessageBox.Show("Pervilages Not Set")

        End If

        con.Close()

    End Sub
End Class