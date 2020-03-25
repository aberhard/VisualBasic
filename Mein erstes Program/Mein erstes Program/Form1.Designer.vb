<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.cmdHallo = New System.Windows.Forms.Button()
		Me.cmdEnde = New System.Windows.Forms.Button()
		Me.lblAnzeige = New System.Windows.Forms.Label()
		Me.btnAndy = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'cmdHallo
		'
		Me.cmdHallo.Location = New System.Drawing.Point(39, 87)
		Me.cmdHallo.Name = "cmdHallo"
		Me.cmdHallo.Size = New System.Drawing.Size(99, 39)
		Me.cmdHallo.TabIndex = 0
		Me.cmdHallo.Text = "Hallo"
		Me.cmdHallo.UseVisualStyleBackColor = True
		'
		'cmdEnde
		'
		Me.cmdEnde.Location = New System.Drawing.Point(39, 170)
		Me.cmdEnde.Name = "cmdEnde"
		Me.cmdEnde.Size = New System.Drawing.Size(99, 41)
		Me.cmdEnde.TabIndex = 1
		Me.cmdEnde.Text = "Ende"
		Me.cmdEnde.UseVisualStyleBackColor = True
		'
		'lblAnzeige
		'
		Me.lblAnzeige.AutoSize = True
		Me.lblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblAnzeige.Location = New System.Drawing.Point(68, 28)
		Me.lblAnzeige.Name = "lblAnzeige"
		Me.lblAnzeige.Size = New System.Drawing.Size(41, 15)
		Me.lblAnzeige.TabIndex = 2
		Me.lblAnzeige.Text = "Label1"
		'
		'btnAndy
		'
		Me.btnAndy.Location = New System.Drawing.Point(174, 179)
		Me.btnAndy.Name = "btnAndy"
		Me.btnAndy.Size = New System.Drawing.Size(75, 23)
		Me.btnAndy.TabIndex = 3
		Me.btnAndy.Text = "Andy"
		Me.btnAndy.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.btnAndy)
		Me.Controls.Add(Me.lblAnzeige)
		Me.Controls.Add(Me.cmdEnde)
		Me.Controls.Add(Me.cmdHallo)
		Me.Name = "Form1"
		Me.Text = "Mein erstes Program"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents cmdHallo As System.Windows.Forms.Button
    Friend WithEvents cmdEnde As System.Windows.Forms.Button
    Friend WithEvents lblAnzeige As System.Windows.Forms.Label
    Friend WithEvents btnAndy As Button
End Class
