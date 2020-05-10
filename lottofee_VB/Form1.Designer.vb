<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.cmdBeenden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBeenden
        '
        Me.cmdBeenden.ForeColor = System.Drawing.Color.Red
        Me.cmdBeenden.Location = New System.Drawing.Point(785, 620)
        Me.cmdBeenden.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmdBeenden.Name = "cmdBeenden"
        Me.cmdBeenden.Size = New System.Drawing.Size(125, 35)
        Me.cmdBeenden.TabIndex = 0
        Me.cmdBeenden.Text = "B&eenden"
        Me.cmdBeenden.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 692)
        Me.Controls.Add(Me.cmdBeenden)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lottofee"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBeenden As Button
End Class
