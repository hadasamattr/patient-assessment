Public Class Trauma
    Dim ROSC As New Random
    Dim MVCEngine As New Random
    Dim RanVal As Integer
    Dim MVC As Integer
    Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker 'declaration for backgroundworker so vb can keep its jew boner in its pants

    Private Sub Trauma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'since this is a trauma, disable NOI
        Form1.Visible = False
        SceneSizeup.btnNOI.Visible = False
        btnMain.Enabled = True
        'BackgroundWorker1.RunWorkerAsync(ThingThatsReallyFuckingIntensive)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        ' Random Scenario generator
        RanVal = ROSC.Next(3)
        MVC = MVCEngine.Next(11)

        'Define values for scenarios. General idea is to create a generalized String value for the 
        'If/Then fun below to define based off the generator above. 
        Dim TraumaCC As String
        'If/Then to select scenario based on value returned from generator above then enable secondary options after scenario
        'assignment
        If btnMain.Enabled = True Then
            If RanVal = 0 Then
                MessageBox.Show("**MVC function under construction**")
            ElseIf RanVal = 1 Then
                TraumaCC = "Assault"
                Label1.Text = TraumaCC
            ElseIf RanVal = 2 Then
                TraumaCC = "Fall"
                Label1.Text = TraumaCC
            ElseIf RanVal = 3 Then
                TraumaCC = "Stabbing"
                Label1.Text = TraumaCC
            End If
        End If

        If RanVal = 0 Or RanVal = 1 Or RanVal = 2 Or RanVal = 3 Then
            btnScene.Enabled = True
            btnPrimAssess.Enabled = True
            btnSecAssess.Enabled = True
            btnReassess.Enabled = True
        Else : MessageBox.Show("Error: Returned value undefined. Contact the writer and punch him in the asshole.")
            btnScene.Enabled = False
            btnPrimAssess.Enabled = False
            btnSecAssess.Enabled = False
            btnReassess.Enabled = False
        End If

    End Sub
    Public Function MVCFunction() As Integer
        Dim MReturn As String
        Dim MVal As Integer
        MVal = MVCEngine.Next(10)

        'If/Then to generate MVC specific scenarios and put them somewhere for now... workin on that part.
        If MVal = 0 Then
            MReturn = "MVC with entrapment. No report given"
        ElseIf MVal = 1 Then
            MReturn = "MVC with fire. 1 Occupant self-extricated. Requested by FD for rehab."
        ElseIf MVal = 2 Then
            MReturn = "Vehicle vs phone pole. 1 occupant w/L shoulder pain"
        End If

    End Function
    Private Sub btnLaunchSizeUP_Click(sender As Object, e As EventArgs) Handles btnScene.Click
        SceneSizeup.ShowDialog()
    End Sub
End Class