<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblInstructionsTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstructionsTitle
        '
        Me.lblInstructionsTitle.AutoSize = True
        Me.lblInstructionsTitle.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsTitle.Location = New System.Drawing.Point(92, 25)
        Me.lblInstructionsTitle.Name = "lblInstructionsTitle"
        Me.lblInstructionsTitle.Size = New System.Drawing.Size(81, 15)
        Me.lblInstructionsTitle.TabIndex = 0
        Me.lblInstructionsTitle.Text = "Instructions"
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(12, 40)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(249, 264)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(273, 326)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblInstructionsTitle)
        Me.Name = "Form2"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructionsTitle As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
End Class
