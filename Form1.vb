Public Class Form1

    Public CurentRuntimeKeyPath As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Khronos\OpenXR\1\"
    Public CurrentRuntimeKeyValuename As String = "ActiveRuntime"
    Public ErrorMsgHandle As String = "No Permission to Read - Try Running as Admin"
    Public myEnv = Environment.Is64BitProcess   '' This is TRUE if you are running in 64Bit

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Avoid 32 Bit trouble.
#Disable Warning IDE0059 ' Unnecessary assignment of a value
        If Not myEnv Then
            lbl64bitWaring.Visible = True
            lbl64bitWaring.Refresh()
            MsgBox("This program is running in 32 Bit Mode - I won`t touch it unless you are in 64Bit Mode")
        End If

        '' Assign Links to Link Labels
        LinkLabel1.Text = "Validate with OpenXR Dev Tools from Microsoft Store"
        LinkLabel1.Links.Add(14, 37, "ms-windows-store://pdp/?ProductId=9n5cvvl23qbt")

        '' Populate ComboBoxes
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("1 - Steam VR")
        ComboBox1.Items.Add("2 - Oculus (Default)")
        ComboBox1.Items.Add("3 - Oculus in D:\Oculus")
        ComboBox1.Items.Add("4 - Windows Mixed Reality")
        ComboBox1.Text = "Select from..."


        '' Initiate the Reader and 1st Read 
        Init()



#Enable Warning IDE0059 ' Unnecessary assignment of a value
    End Sub

    Private Function DetermineEngineArray(XrRuntimeString As String)

#Disable Warning IDE0059 ' Unnecessary assignment of a value
        '' I tried to to Select Cases here, but it just did not work out for .
        '' Good old IF's .. Sorry

        Dim EngineName As String = ""
        Dim tstEnginename As Boolean = False
        Dim EngineIndexPos As Integer = 0
        Dim tst1 As String = "oculus"
        Dim tst2 As String = "steam"
        Dim tst3 As String = "MixedReality"
        Dim tst4 As String = "D:\Oculus\"


        If XrRuntimeString.Contains(tst1) Then
            EngineName = "Oculus Runtime"

            If XrRuntimeString.Contains(tst4) Then
                EngineIndexPos = 2
            Else
                EngineIndexPos = 1
            End If
            tstEnginename = True
        End If

        If XrRuntimeString.Contains(tst2) Then
            EngineName = "SteamVR Runtime"
            EngineIndexPos = 0
            tstEnginename = True
        End If

        If XrRuntimeString.Contains(tst3) Then
            EngineName = "Windows Mixed Reality Runtime"
            EngineIndexPos = 3
            tstEnginename = True
        End If

        If tstEnginename = False Then
            EngineName = "Not Detected"
            EngineIndexPos = 0
        End If




        DetermineEngineArray = {EngineIndexPos, EngineName, XrRuntimeString}

#Enable Warning IDE0059 ' Unnecessary assignment of a value
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub btnSetRuntime_Click(sender As Object, e As EventArgs) Handles btnSetRuntime.Click

        '' Ok This Should Set the Runtime
        '' ComboBox Index Perspective
        '0 - Steam VR
        '1 - Oculus in C:\Program Files\Oculus
        '2 - Oculus in D:\Oculus
        '3 - Windows Mixed Reality

        '        D:\Oculus\Support\oculus-runtime\oculus_openxr_64.json   
        '        C:\Program Files\Oculus\Support\oculus-runtime\oculus_openxr_64.json
        '        C:\Program Files (x86)\Steam\steamapps\common\SteamVR\steamxr_win64.json
        '        C:\WINDOWS\system32\MixedRealityRuntime.json

        Dim InputIndex As Integer
        Dim PathtoUse As String

        InputIndex = ComboBox1.SelectedIndex

        Select Case InputIndex
            Case 0
                PathtoUse = "C:\Program Files (x86)\Steam\steamapps\common\SteamVR\steamxr_win64.json"
            Case 1
                PathtoUse = "C:\Program Files\Oculus\Support\oculus-runtime\oculus_openxr_64.json"
            Case 2
                PathtoUse = "D:\Oculus\Support\oculus-runtime\oculus_openxr_64.json"
            Case 3
                PathtoUse = "C:\WINDOWS\system32\MixedRealityRuntime.json"
            Case Else
                PathtoUse = "C:\Program Files (x86)\Steam\steamapps\common\SteamVR\steamxr_win64.json"  '' SteamVR default for Compat
        End Select


        '' Set the New selected Runtime
        SetRuntime(PathtoUse)



    End Sub


    Private Sub Init()

        '' Detect Initial Runtime at Load
        Dim myCurRuntimeValue As String
        Dim detEngeineName = {0, "NameEngine", "Path"}
        myCurRuntimeValue = Microsoft.Win32.Registry.GetValue(CurentRuntimeKeyPath, CurrentRuntimeKeyValuename, ErrorMsgHandle).ToString
        lblCurrentSetting.Text = myCurRuntimeValue
        detEngeineName = DetermineEngineArray(myCurRuntimeValue)
        '' Set combo Box to Determined Value

        ComboBox1.SelectedIndex = detEngeineName(0)
        lblRunTimeName.Text = detEngeineName(1)

    End Sub


    Private Sub SetRuntime(strPath As String)

        Microsoft.Win32.Registry.SetValue(CurentRuntimeKeyPath, CurrentRuntimeKeyValuename, strPath)

        '' Start Init Again to Reflect The Changes

        Init()

    End Sub

    Private Sub lbl_help_Click(sender As Object, e As EventArgs) Handles lbl_help.Click

        Dim message As String
        message = "Select the runtime you wish to set for OpenXR" & vbCrLf
        message = message & "You might Need to Run As Admin to be able to make changes" & vbCrLf
        message = message & "To Validate use the Microsoft Dev Tool Link Below." & vbCrLf
        message = message & "Oculus or Steam VR needs to be running to show as Validated" & vbCrLf
        message = message & "No need to Reboot." & vbCrLf
        MsgBox(message)
    End Sub
End Class
