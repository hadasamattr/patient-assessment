<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medical
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLaunchSizeUP = New System.Windows.Forms.Button()
        Me.btnPrimaryAssess = New System.Windows.Forms.Button()
        Me.btnSecondaryAssessment = New System.Windows.Forms.Button()
        Me.btnReassess = New System.Windows.Forms.Button()
        Me.lstComplaint = New System.Windows.Forms.ListBox()
        Me.lblMedTest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLaunchSizeUP
        '
        Me.btnLaunchSizeUP.Location = New System.Drawing.Point(24, 26)
        Me.btnLaunchSizeUP.Name = "btnLaunchSizeUP"
        Me.btnLaunchSizeUP.Size = New System.Drawing.Size(156, 23)
        Me.btnLaunchSizeUP.TabIndex = 0
        Me.btnLaunchSizeUP.Text = "Scene Size-Up"
        Me.btnLaunchSizeUP.UseVisualStyleBackColor = True
        '
        'btnPrimaryAssess
        '
        Me.btnPrimaryAssess.Location = New System.Drawing.Point(24, 55)
        Me.btnPrimaryAssess.Name = "btnPrimaryAssess"
        Me.btnPrimaryAssess.Size = New System.Drawing.Size(156, 23)
        Me.btnPrimaryAssess.TabIndex = 1
        Me.btnPrimaryAssess.Text = "Begin Primary Assessment"
        Me.btnPrimaryAssess.UseVisualStyleBackColor = True
        '
        'btnSecondaryAssessment
        '
        Me.btnSecondaryAssessment.Location = New System.Drawing.Point(24, 84)
        Me.btnSecondaryAssessment.Name = "btnSecondaryAssessment"
        Me.btnSecondaryAssessment.Size = New System.Drawing.Size(156, 23)
        Me.btnSecondaryAssessment.TabIndex = 2
        Me.btnSecondaryAssessment.Text = "Begin Secondary Assessment"
        Me.btnSecondaryAssessment.UseVisualStyleBackColor = True
        '
        'btnReassess
        '
        Me.btnReassess.Location = New System.Drawing.Point(24, 114)
        Me.btnReassess.Name = "btnReassess"
        Me.btnReassess.Size = New System.Drawing.Size(156, 23)
        Me.btnReassess.TabIndex = 3
        Me.btnReassess.Text = "Begin Reassessment"
        Me.btnReassess.UseVisualStyleBackColor = True
        '
        'lstComplaint
        '
        Me.lstComplaint.FormattingEnabled = True
        Me.lstComplaint.Items.AddRange(New Object() {"Airway obstruction", "Allergic reaction", "Altered level of consciousness", "Behavioral / psychiatric disorder", "Cardiac Arrest", "Cardiac rhythm disturbance", "Chest pain / discomfort", "Diabetic symptoms", "Electrocution", "Hyperthermia", "Hypothermia", "Hypovolemia / shock", "Inhalation injury (toxic gas)", "Not Applicable", "Not Available", "Not Known", "Obvious Death", "Poisoning / drug ingestion", "Respiratory arrest", "Respiratory distress", "Seizure", "Sexual assault / rape", "Smoke inhalation", "Stings / venomous bites", "Stroke / CVA", "Syncope / fainting", "Traumatic injury", "Vaginal hemorrhage"})
        Me.lstComplaint.Location = New System.Drawing.Point(125, 144)
        Me.lstComplaint.Name = "lstComplaint"
        Me.lstComplaint.Size = New System.Drawing.Size(120, 95)
        Me.lstComplaint.TabIndex = 4
        Me.lstComplaint.Visible = False
        '
        'lblMedTest
        '
        Me.lblMedTest.AutoSize = True
        Me.lblMedTest.Location = New System.Drawing.Point(13, 144)
        Me.lblMedTest.Name = "lblMedTest"
        Me.lblMedTest.Size = New System.Drawing.Size(39, 13)
        Me.lblMedTest.TabIndex = 5
        Me.lblMedTest.Text = "Label1"
        '
        'Medical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 182)
        Me.Controls.Add(Me.lblMedTest)
        Me.Controls.Add(Me.lstComplaint)
        Me.Controls.Add(Me.btnReassess)
        Me.Controls.Add(Me.btnSecondaryAssessment)
        Me.Controls.Add(Me.btnPrimaryAssess)
        Me.Controls.Add(Me.btnLaunchSizeUP)
        Me.Name = "Medical"
        Me.Text = "Medical"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaunchSizeUP As System.Windows.Forms.Button
    Friend WithEvents btnPrimaryAssess As System.Windows.Forms.Button
    Friend WithEvents btnSecondaryAssessment As System.Windows.Forms.Button
    Friend WithEvents btnReassess As System.Windows.Forms.Button
    Friend WithEvents lstComplaint As System.Windows.Forms.ListBox
    Friend WithEvents lblMedTest As System.Windows.Forms.Label
End Class
