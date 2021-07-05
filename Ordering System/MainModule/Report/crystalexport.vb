Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class crystalexport
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cr"></param>
    ''' <param name="s">sum,sts,scaller,pro</param>
    ''' <param name="details"></param>
    Sub crystalexport(cr As ReportDocument, s As String, details As String)

        Try
            Dim myCredentials As New System.Net.NetworkCredential("Administrator", "Administrat0r")

            'I would try it here...
            System.Threading.Thread.CurrentPrincipal = myCredentials

            Open_Remote_Connection("RO-SERVER", "Administrator", "Administrat0r")
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As PdfRtfWordFormatOptions = New PdfRtfWordFormatOptions()
            Dim com As New Process
            Dim path As String = "\\ro-server\SystemPDF\" & s
            CrDiskFileDestinationOptions.DiskFileName = path & "\" & details & " " & Now.Hour & "_" & Now.Minute & ".pdf"
            If (Not System.IO.Directory.Exists(path)) Then
                System.IO.Directory.CreateDirectory(path)
            End If

            CrExportOptions = cr.ExportOptions

            CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
            CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions
            CrExportOptions.FormatOptions = CrFormatTypeOptions

            cr.Export()

            Dim yourpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\SystemPDF\" & s
            If (Not System.IO.Directory.Exists(yourpath)) Then
                System.IO.Directory.CreateDirectory(yourpath)
            End If

            CrDiskFileDestinationOptions.DiskFileName = yourpath & "\Crystal Report Exported from system " & details & ".pdf"
            CrExportOptions = cr.ExportOptions

            CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
            CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions
            CrExportOptions.FormatOptions = CrFormatTypeOptions

            cr.Export()

            Close_Remote_Connection("it-pc")
        Catch ex As Exception

            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub Open_Remote_Connection(ByVal strComputer As String, ByVal strUsername As String, ByVal strPassword As String)
        Try
            Dim procInfo As New ProcessStartInfo
            procInfo.FileName = "net"
            procInfo.Arguments = "use \\" & strComputer & "\c$ /USER:" & strUsername & " " & strPassword
            procInfo.WindowStyle = ProcessWindowStyle.Hidden
            procInfo.CreateNoWindow = True

            Dim proc As New Process
            proc.StartInfo = procInfo
            proc.Start()
            proc.WaitForExit(15000)
        Catch ex As Exception
            MsgBox("Open_Remote_Connection" & vbCrLf & vbCrLf & ex.Message, 4096, "Error")
        End Try
    End Sub
    Public Sub Close_Remote_Connection(ByVal device As String)
        Shell("cmd.exe /c " & device, vbHidden)
    End Sub
End Class
