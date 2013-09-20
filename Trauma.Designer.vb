<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trauma
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnReassess = New System.Windows.Forms.Button()
        Me.btnSecAssess = New System.Windows.Forms.Button()
        Me.btnPrimAssess = New System.Windows.Forms.Button()
        Me.btnScene = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "..."
        '
        'btnMain
        '
        Me.btnMain.Enabled = False
        Me.btnMain.Location = New System.Drawing.Point(64, 47)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(156, 23)
        Me.btnMain.TabIndex = 1
        Me.btnMain.Text = "Scenario"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnReassess
        '
        Me.btnReassess.Enabled = False
        Me.btnReassess.Location = New System.Drawing.Point(64, 164)
        Me.btnReassess.Name = "btnReassess"
        Me.btnReassess.Size = New System.Drawing.Size(156, 23)
        Me.btnReassess.TabIndex = 7
        Me.btnReassess.Text = "Begin Reassessment"
        Me.btnReassess.UseVisualStyleBackColor = True
        '
        'btnSecAssess
        '
        Me.btnSecAssess.Enabled = False
        Me.btnSecAssess.Location = New System.Drawing.Point(64, 134)
        Me.btnSecAssess.Name = "btnSecAssess"
        Me.btnSecAssess.Size = New System.Drawing.Size(156, 23)
        Me.btnSecAssess.TabIndex = 6
        Me.btnSecAssess.Text = "Begin Secondary Assessment"
        Me.btnSecAssess.UseVisualStyleBackColor = True
        '
        'btnPrimAssess
        '
        Me.btnPrimAssess.Enabled = False
        Me.btnPrimAssess.Location = New System.Drawing.Point(64, 105)
        Me.btnPrimAssess.Name = "btnPrimAssess"
        Me.btnPrimAssess.Size = New System.Drawing.Size(156, 23)
        Me.btnPrimAssess.TabIndex = 5
        Me.btnPrimAssess.Text = "Begin Primary Assessment"
        Me.btnPrimAssess.UseVisualStyleBackColor = True
        '
        'btnScene
        '
        Me.btnScene.Enabled = False
        Me.btnScene.Location = New System.Drawing.Point(64, 76)
        Me.btnScene.Name = "btnScene"
        Me.btnScene.Size = New System.Drawing.Size(156, 23)
        Me.btnScene.TabIndex = 4
        Me.btnScene.Text = "Scene Size-Up"
        Me.btnScene.UseVisualStyleBackColor = True
        '
        'Trauma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnReassess)
        Me.Controls.Add(Me.btnSecAssess)
        Me.Controls.Add(Me.btnPrimAssess)
        Me.Controls.Add(Me.btnScene)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Trauma"
        Me.Text = "Trauma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnReassess As System.Windows.Forms.Button
    Friend WithEvents btnSecAssess As System.Windows.Forms.Button
    Friend WithEvents btnPrimAssess As System.Windows.Forms.Button
    Friend WithEvents btnScene As System.Windows.Forms.Button
End Class
