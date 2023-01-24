<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.grpCells = New System.Windows.Forms.GroupBox()
        Me.grpCells.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_1
        '
        Me.btn_1.Location = New System.Drawing.Point(15, 22)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(100, 100)
        Me.btn_1.TabIndex = 0
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Location = New System.Drawing.Point(121, 22)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(100, 100)
        Me.btn_2.TabIndex = 1
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Location = New System.Drawing.Point(227, 22)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(100, 100)
        Me.btn_3.TabIndex = 2
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Location = New System.Drawing.Point(227, 128)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(100, 100)
        Me.btn_6.TabIndex = 5
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Location = New System.Drawing.Point(121, 128)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(100, 100)
        Me.btn_5.TabIndex = 4
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Location = New System.Drawing.Point(15, 128)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(100, 100)
        Me.btn_4.TabIndex = 3
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Location = New System.Drawing.Point(227, 234)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(100, 100)
        Me.btn_9.TabIndex = 8
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Location = New System.Drawing.Point(121, 234)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(100, 100)
        Me.btn_8.TabIndex = 7
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Location = New System.Drawing.Point(15, 234)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(100, 100)
        Me.btn_7.TabIndex = 6
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'grpCells
        '
        Me.grpCells.Controls.Add(Me.btn_6)
        Me.grpCells.Controls.Add(Me.btn_9)
        Me.grpCells.Controls.Add(Me.btn_1)
        Me.grpCells.Controls.Add(Me.btn_8)
        Me.grpCells.Controls.Add(Me.btn_2)
        Me.grpCells.Controls.Add(Me.btn_7)
        Me.grpCells.Controls.Add(Me.btn_3)
        Me.grpCells.Controls.Add(Me.btn_4)
        Me.grpCells.Controls.Add(Me.btn_5)
        Me.grpCells.Location = New System.Drawing.Point(12, 12)
        Me.grpCells.Name = "grpCells"
        Me.grpCells.Size = New System.Drawing.Size(342, 352)
        Me.grpCells.TabIndex = 9
        Me.grpCells.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 380)
        Me.Controls.Add(Me.grpCells)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpCells.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents grpCells As GroupBox
End Class
