<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnGO = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLemon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(488, 185)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(75, 23)
        Me.btnGO.TabIndex = 0
        Me.btnGO.Text = "&GO"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(488, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLemon
        '
        Me.lblLemon.AutoSize = True
        Me.lblLemon.Font = New System.Drawing.Font("Segoe UI Symbol", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLemon.ForeColor = System.Drawing.Color.Lime
        Me.lblLemon.Location = New System.Drawing.Point(128, 87)
        Me.lblLemon.Name = "lblLemon"
        Me.lblLemon.Size = New System.Drawing.Size(275, 47)
        Me.lblLemon.TabIndex = 2
        Me.lblLemon.Text = "I love Lemonade"
        Me.lblLemon.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 272)
        Me.Controls.Add(Me.lblLemon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGO)
        Me.Name = "frmMain"
        Me.Text = "Summer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGO As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLemon As Label
End Class
