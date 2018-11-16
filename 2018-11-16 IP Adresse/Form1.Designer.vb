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
        Me.components = New System.ComponentModel.Container()
        Me.txtIPone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdKnopf = New System.Windows.Forms.Button()
        Me.txtIPtwo = New System.Windows.Forms.TextBox()
        Me.txtIPthree = New System.Windows.Forms.TextBox()
        Me.txtIPfour = New System.Windows.Forms.TextBox()
        Me.txtAusgabe = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtIPone
        '
        Me.txtIPone.Location = New System.Drawing.Point(316, 107)
        Me.txtIPone.Name = "txtIPone"
        Me.txtIPone.Size = New System.Drawing.Size(100, 26)
        Me.txtIPone.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Adresse:"
        '
        'cmdKnopf
        '
        Me.cmdKnopf.Location = New System.Drawing.Point(316, 200)
        Me.cmdKnopf.Name = "cmdKnopf"
        Me.cmdKnopf.Size = New System.Drawing.Size(418, 40)
        Me.cmdKnopf.TabIndex = 2
        Me.cmdKnopf.Text = "Knopf"
        Me.cmdKnopf.UseVisualStyleBackColor = True
        '
        'txtIPtwo
        '
        Me.txtIPtwo.Location = New System.Drawing.Point(422, 107)
        Me.txtIPtwo.Name = "txtIPtwo"
        Me.txtIPtwo.Size = New System.Drawing.Size(100, 26)
        Me.txtIPtwo.TabIndex = 3
        '
        'txtIPthree
        '
        Me.txtIPthree.Location = New System.Drawing.Point(528, 107)
        Me.txtIPthree.Name = "txtIPthree"
        Me.txtIPthree.Size = New System.Drawing.Size(100, 26)
        Me.txtIPthree.TabIndex = 4
        '
        'txtIPfour
        '
        Me.txtIPfour.Location = New System.Drawing.Point(634, 107)
        Me.txtIPfour.Name = "txtIPfour"
        Me.txtIPfour.Size = New System.Drawing.Size(100, 26)
        Me.txtIPfour.TabIndex = 5
        '
        'txtAusgabe
        '
        Me.txtAusgabe.Location = New System.Drawing.Point(316, 298)
        Me.txtAusgabe.Name = "txtAusgabe"
        Me.txtAusgabe.Size = New System.Drawing.Size(418, 26)
        Me.txtAusgabe.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(316, 342)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(100, 26)
        Me.txtTest.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.txtAusgabe)
        Me.Controls.Add(Me.txtIPfour)
        Me.Controls.Add(Me.txtIPthree)
        Me.Controls.Add(Me.txtIPtwo)
        Me.Controls.Add(Me.cmdKnopf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIPone)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIPone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdKnopf As Button
    Friend WithEvents txtIPtwo As TextBox
    Friend WithEvents txtIPthree As TextBox
    Friend WithEvents txtIPfour As TextBox
    Friend WithEvents txtAusgabe As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtTest As TextBox
End Class
