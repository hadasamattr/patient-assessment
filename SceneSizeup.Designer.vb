<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceneSizeup
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
        Me.btnSafe = New System.Windows.Forms.Button()
        Me.btnMOI = New System.Windows.Forms.Button()
        Me.btnNOI = New System.Windows.Forms.Button()
        Me.btnNumPts = New System.Windows.Forms.Button()
        Me.btnCallResources = New System.Windows.Forms.Button()
        Me.btnCspine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSafe
        '
        Me.btnSafe.Location = New System.Drawing.Point(40, 26)
        Me.btnSafe.Name = "btnSafe"
        Me.btnSafe.Size = New System.Drawing.Size(141, 23)
        Me.btnSafe.TabIndex = 0
        Me.btnSafe.Text = "Is Scene Safe?"
        Me.btnSafe.UseVisualStyleBackColor = True
        '
        'btnMOI
        '
        Me.btnMOI.Location = New System.Drawing.Point(39, 55)
        Me.btnMOI.Name = "btnMOI"
        Me.btnMOI.Size = New System.Drawing.Size(142, 23)
        Me.btnMOI.TabIndex = 1
        Me.btnMOI.Text = "What is MOI?"
        Me.btnMOI.UseVisualStyleBackColor = True
        '
        'btnNOI
        '
        Me.btnNOI.Location = New System.Drawing.Point(40, 85)
        Me.btnNOI.Name = "btnNOI"
        Me.btnNOI.Size = New System.Drawing.Size(141, 23)
        Me.btnNOI.TabIndex = 2
        Me.btnNOI.Text = "What is NOI?"
        Me.btnNOI.UseVisualStyleBackColor = True
        '
        'btnNumPts
        '
        Me.btnNumPts.Location = New System.Drawing.Point(40, 115)
        Me.btnNumPts.Name = "btnNumPts"
        Me.btnNumPts.Size = New System.Drawing.Size(141, 23)
        Me.btnNumPts.TabIndex = 3
        Me.btnNumPts.Text = "How many Patients?"
        Me.btnNumPts.UseVisualStyleBackColor = True
        '
        'btnCallResources
        '
        Me.btnCallResources.Location = New System.Drawing.Point(39, 145)
        Me.btnCallResources.Name = "btnCallResources"
        Me.btnCallResources.Size = New System.Drawing.Size(142, 23)
        Me.btnCallResources.TabIndex = 4
        Me.btnCallResources.Text = "Call Additional Resources"
        Me.btnCallResources.UseVisualStyleBackColor = True
        '
        'btnCspine
        '
        Me.btnCspine.Location = New System.Drawing.Point(40, 175)
        Me.btnCspine.Name = "btnCspine"
        Me.btnCspine.Size = New System.Drawing.Size(141, 23)
        Me.btnCspine.TabIndex = 5
        Me.btnCspine.Text = "Consider C-Spine"
        Me.btnCspine.UseVisualStyleBackColor = True
        '
        'SceneSizeup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 224)
        Me.Controls.Add(Me.btnCspine)
        Me.Controls.Add(Me.btnCallResources)
        Me.Controls.Add(Me.btnNumPts)
        Me.Controls.Add(Me.btnNOI)
        Me.Controls.Add(Me.btnMOI)
        Me.Controls.Add(Me.btnSafe)
        Me.Name = "SceneSizeup"
        Me.Text = "SceneSizeup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSafe As System.Windows.Forms.Button
    Friend WithEvents btnMOI As System.Windows.Forms.Button
    Friend WithEvents btnNOI As System.Windows.Forms.Button
    Friend WithEvents btnNumPts As System.Windows.Forms.Button
    Friend WithEvents btnCallResources As System.Windows.Forms.Button
    Friend WithEvents btnCspine As System.Windows.Forms.Button
End Class
