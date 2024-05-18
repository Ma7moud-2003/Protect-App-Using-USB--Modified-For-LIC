Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Management
Imports System.Xml


Public Class Tech_Functions
    Public Shared con As New SqlConnection
    Public Shared cmd As New SqlCommand
    Public Shared dr As SqlDataReader
    Public Shared da As SqlDataAdapter
    Public Shared dt As New DataTable
    Public Shared SqlStatment As String
    Public Shared nv As String = String.Empty
    Public Shared cv As String = String.Empty
    Public Shared newestversion As String = String.Empty
    Public Shared currentversion As String = String.Empty
    Public Shared sqlDT As New DataTable
    Public Shared App_Conn_string As String
    Private Shared myConn As SqlConnection = New SqlConnection("Server=.; Database =master;Trusted_Connection=True")
    Public Shared con_db As SqlConnection = New SqlConnection("Server=.; Database =Tech_config;Trusted_Connection=True")

    Public Shared Function Sql_Globale_Query(Sql As String) As DataTable
        If con.State = ConnectionState.Closed Then con.Open()
        Dim InfoTable As New DataTable
        Dim InfoAdapter As New SqlDataAdapter
        InfoAdapter.SelectCommand = New SqlCommand(Sql, con)
        InfoAdapter.Fill(InfoTable)
        If con.State = ConnectionState.Open Then con.Close()
        Return InfoTable
    End Function
    Public Shared Function OpenCon() As Boolean
        On Error Resume Next
        If con.State = ConnectionState.Closed Then
            con.Open()
            Return True
        End If
    End Function

    Public Shared Function CloseCon() As Boolean
        On Error Resume Next
        If con.State = ConnectionState.Open Then
            con.Close()
            Return True
        End If
    End Function

    Public Shared Function ExecuteSQLQuery(SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New SqlConnection(App_Conn_string)
            Dim sqlDA As New SqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New SqlCommandBuilder(sqlDA)
            sqlDT.Reset()
            sqlDA.Fill(sqlDT)
        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        Return sqlDT
    End Function
    ' دالة بناء اوامر الحفظ والحذف والتعديل 
    Public Shared Function SQLExicute(ByVal SQLStatment As String, con As SqlConnection) As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Dim Cmd As New SqlCommand
            Cmd.CommandText = SQLStatment
            con.Open()
            Cmd.Connection = con
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As SqlException
            Return False
            XtraMessageBox.Show("حدث خطأ في عملية الحفظ", "تنبيه")
        Finally
            con.Close()
        End Try
    End Function
    'دالة حذف من الجدول
    Public Shared Function DeleteData(ByVal TName As String, ByVal Whr As String) As Boolean
        Try
            Dim cmd As New SqlCommand
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            SqlStatment = "Delete From " & TName & " " & " Where " & Whr
            con.Open()
            cmd.Connection = con
            cmd.CommandText = SqlStatment
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
            XtraMessageBox.Show("حدث خطأ في عمليه الحذف", "تنبيه")
        Finally
            con.Close()
        End Try
    End Function
    ' اسم اليوم بالعربي
    Public Shared Function GetTodayDayName_AR() As String
        Dim todaydate As String = String.Empty
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        Select Case dayName
            Case "Friday"
                dayName = "الجمعة"
                Exit Select
            Case "Saturday"
                dayName = "السبت"
                Exit Select
            Case "Sunday"
                dayName = "الأحد"
                Exit Select
            Case "Monday"
                dayName = "الإثنين"
                Exit Select
            Case "Tuesday"
                dayName = "الثلاثاء"
                Exit Select
            Case "Wednesday"
                dayName = "الأربعاء"
                Exit Select
            Case "Thursday"
                dayName = "الخميس"
                Exit Select
        End Select
        Return dayName
    End Function

    'اسم اليوم بالإنجليزي
    Public Shared Function GetTodayDayName_EN() As String
        Dim todaydate As String = String.Empty
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        Select Case dayName
            Case "Friday"
                dayName = "Friday"
                Exit Select
            Case "Saturday"
                dayName = "Saturday"
                Exit Select
            Case "Sunday"
                dayName = "Sunday"
                Exit Select
            Case "Monday"
                dayName = "Monday"
                Exit Select
            Case "Tuesday"
                dayName = "Tuesday"
                Exit Select
            Case "Wednesday"
                dayName = "Wednesday"
                Exit Select
            Case "Thursday"
                dayName = "Thursday"
                Exit Select
        End Select
        Return dayName
    End Function
    'اسم اليوم بالهجري
    Public Shared Function GetTodayDayName_Hijri(lbl As LabelControl) As String
        ' Create an instance of the Hijri calendar
        Dim hijriCalendar As New UmAlQuraCalendar()

        ' Get the current date in the Hijri calendar
        Dim today As Date = Date.Now
        Dim hijriYear As Integer = hijriCalendar.GetYear(today)
        Dim hijriMonth As Integer = hijriCalendar.GetMonth(today)

        ' Get the name of the current Hijri month
        Dim monthName As String = hijriCalendar.GetMonth(today)
        '.GetMonthName(hijriYear, hijriMonth)

        ' Set the text of the label to display the Hijri month
        Select Case monthName
            Case "1"
                monthName = "Muharram"
                Exit Select
            Case "2"
                monthName = "Safar"
                Exit Select
            Case "3"
                monthName = "Rabi I"
                Exit Select
            Case "4"
                monthName = "Rabi II"
                Exit Select
            Case "5"
                monthName = "Jumada I"
                Exit Select
            Case "6"
                monthName = "Jumada II"
                Exit Select
            Case "7"
                monthName = "Rajab"
                Exit Select
            Case "8"
                monthName = "Shaaban"
                Exit Select
            Case "9"
                monthName = "Ramadan"
                Exit Select
            Case "10"
                monthName = "Shawwal"
                Exit Select
            Case "11"
                monthName = "Dhu al-Qidah"
                Exit Select
            Case "12"
                monthName = "Dhu al-Hijjah"
                Exit Select
        End Select
        lbl.Text = monthName

    End Function
    Public Shared Function max_cod(TableName, OrderbyField) As Integer
        max_cod = 0
        Dim STR = "select * from " & TableName & " Order by " & OrderbyField
        Dim Adp = New SqlClient.SqlDataAdapter(STR, con)
        Dim Ds = New DataSet
        Adp.Fill(Ds)
        Dim DT As DataTable
        DT = Ds.Tables(0)
        If DT.Rows.Count <> 0 Then
            Dim i = DT.Rows.Count - 1
            max_cod = Val(DT.Rows(i).Item(OrderbyField))
        End If
    End Function

    'اعلي رقم للحقل في الجدول
    Public Shared Function max_code(ByVal tbl As String, ByVal col As String, txt As String)
        Dim id As New Integer
        Dim Sql As String
        On Error Resume Next
        Sql = "select  max(" & col & ") from " & tbl & String.Empty
        Dim cmd As New SqlCommand(Sql, con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim Obj_a As Object = cmd.ExecuteScalar()
        If Obj_a IsNot Nothing Then
            id = cmd.ExecuteScalar
            txt = id
        End If
        con.Close()
        Return id
    End Function
    'اصغر رقم للحقل في الجدول
    Public Shared Function min_code(ByVal tbl As String, ByVal col As String)
        Dim id As New Integer
        Dim Sql As String
        On Error Resume Next
        Sql = "select  min(" & col & ") from " & tbl & String.Empty
        Dim cmd As New SqlCommand(Sql, con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim Obj_a As Object = cmd.ExecuteScalar()
        If Obj_a IsNot Nothing Then
            id = cmd.ExecuteScalar
        End If
        con.Close()
        Return id
    End Function
    'دالة نعبئة الجريد كنترول
    Public Shared Function FillgridControl(ByVal dg As GridControl, gv As GridView, ByVal Sqlstatment As String, con As SqlConnection, filter As Boolean, edit As Boolean) As DataSet
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            gv.OptionsView.ShowAutoFilterRow = filter
            gv.OptionsBehavior.Editable = edit

            'gv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
            Dim sda As New SqlDataAdapter(Sqlstatment, con)
            ds.Clear()
            sda.Fill(ds)
            bs.DataSource = ds.Tables(0)
            dg.DataSource = bs
        Catch ex As Exception
            XtraMessageBox.Show("Error:2400307" & vbNewLine & "Error Loading Data" & vbNewLine & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            con.Close()
            Exit Function
        Finally
            con.Close()
        End Try
        Return ds
    End Function
    ' دالة تعبئة الداتا قريد
    Public Shared Function FillDataGrid(ByVal dg As DataGridView, ByVal Sqlstatment As String, con As SqlConnection) As DataSet
        Dim ds As New DataSet
        Dim bs As New BindingSource
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            Dim sda As New SqlDataAdapter(Sqlstatment, con)
            ds.Clear()
            sda.Fill(ds)

            bs.DataSource = ds.Tables(0)
            dg.DataSource = bs
        Catch ex As Exception
            'MsgShow("حدث خطأ في عرض البيانات", MsgType.Critical, "تنبيه", MsgLocation.Top_Center)
        Finally
            con.Close()
        End Try
        Return ds
    End Function
    'دالة ملئ الكوبو ايديت
    Public Shared Function FillComboEdit(ByVal cbo As ComboBoxEdit, ByVal str As String, ByVal Col_Name As String)
        CloseCon()
        cbo.Properties.Items.Clear()
        cmd = New SqlCommand(str, con)
        con.Open()
        dr = cmd.ExecuteReader

        While dr.Read
            cbo.Properties.Items.Add(dr(Col_Name))
        End While
        dr.Close()
        con.Close()

    End Function

    Public Shared Function FillComboBox(ByVal cbo As System.Windows.Forms.ComboBox, str As String, ByVal Col_Name As String)
        CloseCon()
        con.Open()
        cmd = New SqlCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbo.Items.Add(dr(Col_Name))
        End While
        dr.Close()
        con.Close()
    End Function

    Public Shared Function FillComboBox_dgv(ByVal cbo As DataGridViewComboBoxColumn, str As String, ByVal Col_Name As String)
        CloseCon()
        con.Open()
        cmd = New SqlCommand(str, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cbo.Items.Add(dr(Col_Name))
        End While
        dr.Close()
        con.Close()
    End Function

    Public Shared Function Summery_lbl(ByVal str As String, ByVal con As SqlConnection, ByVal lbl As LabelControl)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = New SqlCommand(str, con)
        lbl.Text = cmd.ExecuteScalar
        con.Close()
    End Function

    Public Shared Function Summery_list(ByVal str As String, ByVal con As SqlConnection, ByVal list As ListView)
        Dim command As New SqlCommand(str, con)
        Dim da As New SqlDataAdapter(command)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()



        da.Fill(dt)

        list.Items.Clear()

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("item_name").ToString())
            item.SubItems.Add(row("total_quantity_setup").ToString())
            item.SubItems.Add(row("total_quantity_used").ToString())
            item.SubItems.Add(row("quantity_difference").ToString())
            ' Add more sub-items if you have more columns
            list.Items.Add(item)
        Next
        con.Close()
    End Function

    Public Shared Sub execute_str(ByVal str As String)
        CloseCon()
        Dim cmd As New SqlCommand
        cmd.CommandText = CommandType.Text
        cmd.Connection = con
        cmd = New SqlCommand(str, con)
        OpenCon()
        cmd.ExecuteNonQuery()
        CloseCon()
    End Sub

    Public Shared Function execute_stored(name As String, ByVal prm() As SqlParameter)
        cmd.Connection = con

        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = name

        cmd.Parameters.Clear()

        OpenCon()

        For i As Integer = 0 To prm.Length - 1
            cmd.Parameters.Add(prm(i))
        Next

        cmd.ExecuteNonQuery()
        CloseCon()
    End Function

    Public Shared Function select_txt(ByVal str As String) As DataTable
        Dim dt As New DataTable
        dt.Clear()
        da = New SqlDataAdapter(str, con)
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function select_stored(name As String, prm() As SqlParameter) As DataTable
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        con.Open()
        For i As Integer = 0 To prm.Length - 1
            cmd.Parameters.Add(prm(i))
        Next
        da = New SqlDataAdapter(cmd)
        dt.Clear()
        da.Fill(dt)
        Return dt
        con.Close()
    End Function

    Public Shared Function get_USB_serial(lbl_usb As LabelControl)
        Dim collection As ManagementObjectCollection


        Using id = New ManagementObjectSearcher("Select * From Win32_DiskDrive")
            collection = id.Get()
        End Using
        For Each device In collection
            lbl_usb.Text = device.GetPropertyValue("SerialNumber")
        Next
    End Function

    'دالة إنشاء قاعدة بيانات
    'دالة إنشاء قاعدة بيانات
    Public Shared Function create_db(ByVal db As String)
        Dim cmd As New SqlCommand
        With cmd
            .Connection = myConn
            .CommandType = CommandType.Text
            .CommandText = "USE [master]
CREATE DATABASE [" & db & "]
COLLATE Arabic_100_CI_AS"
        End With
        myConn.Open()
        cmd.ExecuteNonQuery()
        myConn.Close()
        cmd = Nothing
    End Function
    'دالة إنشاء جداول في قاعدة البيانات
    Public Shared Function create_tb(ByVal db As String)
        Dim cmd As New SqlCommand
        With cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "USE [" & db & "]
CREATE TABLE [dbo].[account](
	[GUID] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_account_GUID]  DEFAULT (newid()),
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [float] NULL,
	[name] [nvarchar](max) NULL,
	[parent_guid] [uniqueidentifier] NULL,
	[end_account] [int] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[area](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_area_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[area] [nvarchar](max) NULL,
	[city] [nvarchar](max) NULL,
 CONSTRAINT [PK_area] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[Catery](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Catery_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[code] [nvarchar](max) NULL,
	[cat] [nvarchar](max) NULL,
 CONSTRAINT [PK_Catery] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[city](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_city_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[city] [nvarchar](max) NULL,
	[country] [nvarchar](max) NULL,
 CONSTRAINT [PK_city] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[country](
	[ID] [float] NULL,
	[Country] [nvarchar](max) NULL,
	[AR] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[currency](
	[Country and currency] [nvarchar](255) NULL,
	[Currency code] [nvarchar](255) NULL,
	[Symbol] [nvarchar](255) NULL
) ON [PRIMARY]


CREATE TABLE [dbo].[day1](
	[GUID] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_day1_GUID]  DEFAULT (newid()),
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number_d] [int] NULL,
	[sanad_date] [date] NULL,
	[note] [nvarchar](max) NULL,
	[type] [uniqueidentifier] NULL,
	[note_day] [nvarchar](max) NULL,
 CONSTRAINT [PK_day1] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[day2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[GUID] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_day2_GUID]  DEFAULT (newid()),
	[parent_GUID] [uniqueidentifier] NULL,
	[account_guid] [uniqueidentifier] NULL,
	[debit] [float] NULL,
	[credit] [float] NULL,
	[note] [nvarchar](max) NULL,
 CONSTRAINT [PK_day2] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[end_acc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_end_acc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[sanad_type](
	[GUID] [uniqueidentifier] NOT NULL,
	[code] [int] NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_sanad_type] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[Units](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Units_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[unit] [nvarchar](max) NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[users](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_users_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[user_name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[add_date] [datetime] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[users_log](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_users_log_GUID]  DEFAULT (newid()),
	[user_name] [nvarchar](max) NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_users_log] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[Ware](
	[GUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Ware_GUID]  DEFAULT (newid()),
	[id] [bigint] NULL,
	[ware] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ware] PRIMARY KEY CLUSTERED 
(
	[GUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE VIEW [dbo].[v_account]
AS
SELECT        dbo.account.GUID, dbo.account.parent_guid, dbo.account.code, dbo.account.name, account_1.name AS name_1, dbo.account.end_account
FROM            dbo.account INNER JOIN
                         dbo.account AS account_1 ON dbo.account.parent_guid = account_1.GUID



EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = (H (1[42] 4[18] 2[10] 3) )
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = (H (1 [50] 4 [25] 3))
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = (H (1 [50] 2 [25] 3))
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = (H (4 [30] 2 [40] 3))
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = (H (1 [56] 3))
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = (H (2 [66] 3))
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = (H (4 [50] 3))
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = (V (3))
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = (H (1[56] 4[18] 2) )
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = (H (1 [75] 4))
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = (H (1[66] 2) )
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = (H (4 [60] 2))
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = (H (1) )
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = (V (4))
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = (V (2))
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = account
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = account_1
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 196
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 3390
         Width = 3390
         Width = 3345
         Width = 1500
         Width = 1500
         Width = 3345
         Width = 3345
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_account'


EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_account'



CREATE proc [dbo].[add_day1]
@number_d as int,@sanad_date as date,@note as nvarchar(max),@type as uniqueidentifier,@note_day as nvarchar(max)

as
begin
INSERT INTO [dbo].[day1]
           ([number_d]
           ,[sanad_date]
           ,[note]
           ,[type]
           ,[note_day])
     VALUES
           (@number_d,@sanad_date,@note,@type,@note_day)
end



create proc [dbo].[add_day2]
@parent_GUID as uniqueidentifier,@account_guid as uniqueidentifier,@debit as float,@credit as float,@note as nvarchar(max)

as
begin
INSERT INTO [dbo].[day2]
           ([parent_GUID]
           ,[account_guid]
           ,[debit]
           ,[credit]
           ,[note])
     VALUES
           (@parent_GUID,@account_guid,@debit,@credit,@note)
end



CREATE proc [dbo].[update_day1]
@GUID as uniqueidentifier,@sanad_date as datetime,@note as nvarchar(max),@type as uniqueidentifier,@note_day as nvarchar(max)

as
begin
UPDATE [dbo].[day1]
   SET [sanad_date] =@sanad_date,[note] = @note,[type] = @type,[note_day] = @note_day
 WHERE GUID =@GUID
end
"
        End With
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        XtraMessageBox.Show("تم انشاء قاعده البيانات بنجاح", "عمليه ناجحه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        cmd = Nothing
    End Function


End Class
