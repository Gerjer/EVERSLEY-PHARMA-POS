Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop


Public Class OpenFileEditor
    '<DllImport("user32.dll", CharSet:=CharSet.Auto)>
    'Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    'End Function

    '<DllImport("user32.dll", SetLastError:=True)>
    'Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    'End Function


    'Private Const WM_SYSCOMMAND As Integer = &H112
    'Private Const SC_MINIMIZE As Integer = &HF020
    'Private Const SC_MAXIMIZE As Integer = &HF030

    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Dim proc As Process



    Dim pathword As String = "C:\Users\Roger  Petailan\OneDrive\Documents\21st century literature.docx"
    Private Sub OpenFileEditor_Load(sender As Object, e As EventArgs) Handles Me.Load


        'Dim p As Process = Process.Start(New ProcessStartInfo() With {.FileName = String.Concat(Application.StartupPath, "C:\Users\Roger  Petailan\OneDrive\Documents\21st century literature.docx"), .WindowStyle = ProcessWindowStyle.Minimized})
        'System.Threading.Thread.Sleep(4000)
        'Dim value As IntPtr = SetParent(p.MainWindowHandle, Panel1.Handle)
        'SendMessage(p.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        'Me.Controls.Add(Panel1)

        'Try
        '    Dim proc As Process
        '    proc = Process.Start(pathword)
        '    proc.WaitForInputIdle()
        '    Threading.Thread.Sleep(4000)
        '    SetParent(proc.MainWindowHandle, Me.Panel1.Handle)
        '    SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        '    'Me.Panel1.
        'Catch ex As Exception
        '    Dim errormsg As String = String.Empty
        '    errormsg = ex.ToString()
        'End Try

        'Dim wordapp As New Word.Application 'new word app 
        'wordapp.Visible = False 'hide word app 
        'wordapp.Documents.Open("C:\Users\Roger  Petailan\OneDrive\Documents\21st century literature.docx", , True) 'open document as readonly 
        'wordapp.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone 'stop alerts 
        'wordapp.ActivePrinter = "Microsoft Office Document Image Writer" 'Set the printer 
        'wordapp.Documents(1).PrintOut(True, , Word.WdPrintOutRange.wdPrintAllDocument, "C:\Users\Roger  Petailan\OneDrive\Documents\21st century literature.docx",
        '                              , , Word.WdPrintOutItem.wdPrintDocumentContent, 1, "", Word.WdPrintOutPages.wdPrintAllPages,
        '                              False, True, , False, 0, 0, 0, 0) 'Print parameters 


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '    proc = Process.Start("notepad.exe")

        '    proc = Process.Start(pathword)

        Dim startInfo As New ProcessStartInfo("winword.exe")
        startInfo.Arguments = "/q /t d:\Resignation Letter 2.doc"
        proc = Process.Start(startInfo)

        proc.WaitForInputIdle()
        SetParent(proc.MainWindowHandle, Panel1.Handle)
        SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub
End Class