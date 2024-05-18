Imports System.Data.SqlClient
Imports System.Management
Imports System.Net.Security
Imports System.Text

Module mdl_verify

    Function get_USB_serial(lbl_usb As TextBox)
        Dim collection As ManagementObjectCollection


        Using id = New ManagementObjectSearcher("Select * From Win32_DiskDrive")
            collection = id.Get()
        End Using
        For Each device In collection
            lbl_usb.Text = device.GetPropertyValue("SerialNumber")
        Next
    End Function

    Function gen_code(txt_code As TextBox)
        Dim no As Double
        Dim random As New Random()
        'If Not String.IsNullOrEmpty(txt_code.Text.Trim()) Then
        'For i As Integer = 0 To Convert.ToInt32(txt_code.Text.Trim()) - 1
        Dim n As Integer = random.[Next](0, 100000000)
        no += n.ToString("D8") * 22
        'Next
        'End If
        txt_code.Text = no
    End Function
End Module
