Public Class Medical

    Public blnBSI As Boolean = False 'no BSI
    Public blnSceneSafety As Boolean = False 'Not sure if scene safe
    Public blnMOI As Boolean = False 'not a trauma
    Public intNumberPatients As Integer = 1 '1 patient
    Public blnAddlResources As Boolean = False ' No additional resources...at this time
    Public txtChiefComplaint As String 'get method to grab from array. THIS IS CHOSEN CHIEF COMPLAINT. (Populated from lstComplaint)
    Public Steph As New Random 'if you don't know what this does....stop 
    Public MedCC As String
    Public RanVal As Integer

    'Public Function RndChiefComplaint() As Integer
    '    RanVal = Steph.Next(29)
    '    Return RanVal
    'End Function

    Public Sub Medical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this load event will get the values of the scenario generated in MedRand
        'txtChiefComplaint = RndChiefComplaint(
        SceneSizeup.btnMOI.Visible = False 'since this is a medical, disable trauma
        'RanVal = Steph.Next(30)
        If RanVal = 0 Then
            MessageBox.Show("RanVal Not Initialized")
            Me.Close()
        ElseIf RanVal = 1 Then
            MedCC = "Airway Obstruction"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 2 Then
            MedCC = "Allergic Reaction"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 3 Then
            MedCC = "Altered LOC"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 4 Then
            MedCC = "Behavioral/ Psychological disorder"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 5 Then
            MedCC = "Cardiac Arrest"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 6 Then
            MedCC = "Chest pain / discomfort"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 7 Then
            MedCC = "Diabetic symptoms"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 8 Then
            MedCC = "Electrocution"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 9 Then
            MedCC = "Hyperthermia"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 10 Then
            MedCC = "Hypothermia"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 11 Then
            MedCC = "Hypovolemia / shock"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 12 Then
            MedCC = "Inhalation injury (toxic gas)"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 13 Then
            MedCC = "Obvious Death"
            lblMedTest.Text = MedCC
            MessageBox.Show("Congratulations! No action needed on your part!")
        ElseIf RanVal = 14 Then
            MedCC = "Unknown Medical Emergency"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 15 Then
            MedCC = "Poisoning / drug ingestion"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 16 Then
            MedCC = "Respiratory arrest"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 17 Then
            MedCC = "Respiratory distress"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 18 Then
            MedCC = "Seizure"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 19 Then
            MedCC = "Sexual assault / rape"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 20 Then
            MedCC = "Smoke inhalation"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 21 Then
            MedCC = "Stings / venomous bites"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 22 Then
            MedCC = "Stroke / CVA"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 23 Then
            MedCC = "Altered LOC"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 24 Then
            MedCC = "Syncope / fainting"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 25 Then
            MedCC = "Vaginal hemorrhage"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 26 Then
            MedCC = "TMJ"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 27 Then
            MedCC = "Overdose"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 28 Then
            MedCC = "Alcohol Induced Stupidity"
            lblMedTest.Text = MedCC
        ElseIf RanVal = 29 Then
            MedCC = "Rectal Bleeding"
            lblMedTest.Text = MedCC
        End If

    End Sub

    Private Sub btnLaunchSizeUP_Click(sender As Object, e As EventArgs) Handles btnLaunchSizeUP.Click
        SceneSizeup.ShowDialog()
    End Sub
End Class