Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Public Class AssPad

    Public WithEvents MedicalBackground As System.ComponentModel.BackgroundWorker
    Public Steph As New Random 'if you don't know what this does....stop 
    Public RanVal As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub MedBackgroundSub(sender As Object, e As DoWorkEventArgs) Handles MedicalBackground.DoWork
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker) 'Dont access background worker directly so use the reference from sender
        Dim arg As Integer = Fix(e.Argument) 'Extract argument and make sure its not decimal
        e.Result = Steph.Next(30) 'start the op
        RanVal = (CDbl(e.Result.ToString))

    End Sub

    ' This event handler demonstrates how to interpret  
    ' the outcome of the asynchronous operation implemented 
    ' in the DoWork event handler. 
    Private Sub MedBackgroundSub_RunWorkerCompleted( _
    sender As Object, e As RunWorkerCompletedEventArgs) _
    Handles MedicalBackground.RunWorkerCompleted

        If e.Cancelled Then
            ' The user canceled the operation.
            MessageBox.Show("Operation was canceled")
        ElseIf (e.Error IsNot Nothing) Then
            ' There was an error during the operation. 
            Dim msg As String = String.Format("An error occurred: {0}", e.Error.Message)
            MessageBox.Show(msg)
        Else
            ' The operation completed normally. 
            Dim msg As String = String.Format("Result = {0}", e.Result)
            MessageBox.Show(msg)
        End If
    End Sub

    'Idea here is to have the RanVal Generator running as a different thread because speed
    'But its still under construction cuz studio is being a poopy pants and not wanting to share modules and shit...
    'http://msdn.microsoft.com/en-us/library/hybbz6ke.aspx
End Class