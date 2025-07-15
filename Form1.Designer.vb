<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UNITS = New System.Windows.Forms.GroupBox()
        Me.txtMIS = New System.Windows.Forms.TextBox()
        Me.txtOOP1 = New System.Windows.Forms.TextBox()
        Me.txtPDA = New System.Windows.Forms.TextBox()
        Me.lblMIS = New System.Windows.Forms.Label()
        Me.lblOOP1 = New System.Windows.Forms.Label()
        Me.lblPDA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGRADE = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAVERAGE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTOTAL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.btnCOMPUTE = New System.Windows.Forms.Button()
        Me.UNITS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UNITS
        '
        Me.UNITS.Controls.Add(Me.txtMIS)
        Me.UNITS.Controls.Add(Me.txtOOP1)
        Me.UNITS.Controls.Add(Me.txtPDA)
        Me.UNITS.Controls.Add(Me.lblMIS)
        Me.UNITS.Controls.Add(Me.lblOOP1)
        Me.UNITS.Controls.Add(Me.lblPDA)
        Me.UNITS.Location = New System.Drawing.Point(0, 0)
        Me.UNITS.Name = "UNITS"
        Me.UNITS.Size = New System.Drawing.Size(420, 249)
        Me.UNITS.TabIndex = 0
        Me.UNITS.TabStop = False
        Me.UNITS.Text = "UNITS"
        '
        'txtMIS
        '
        Me.txtMIS.Location = New System.Drawing.Point(256, 182)
        Me.txtMIS.Name = "txtMIS"
        Me.txtMIS.Size = New System.Drawing.Size(100, 20)
        Me.txtMIS.TabIndex = 2
        '
        'txtOOP1
        '
        Me.txtOOP1.Location = New System.Drawing.Point(256, 98)
        Me.txtOOP1.Name = "txtOOP1"
        Me.txtOOP1.Size = New System.Drawing.Size(100, 20)
        Me.txtOOP1.TabIndex = 1
        '
        'txtPDA
        '
        Me.txtPDA.Location = New System.Drawing.Point(256, 38)
        Me.txtPDA.Name = "txtPDA"
        Me.txtPDA.Size = New System.Drawing.Size(100, 20)
        Me.txtPDA.TabIndex = 0
        '
        'lblMIS
        '
        Me.lblMIS.AutoSize = True
        Me.lblMIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMIS.Location = New System.Drawing.Point(46, 182)
        Me.lblMIS.Name = "lblMIS"
        Me.lblMIS.Size = New System.Drawing.Size(32, 15)
        Me.lblMIS.TabIndex = 0
        Me.lblMIS.Text = "MIS"
        '
        'lblOOP1
        '
        Me.lblOOP1.AutoSize = True
        Me.lblOOP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOOP1.Location = New System.Drawing.Point(46, 105)
        Me.lblOOP1.Name = "lblOOP1"
        Me.lblOOP1.Size = New System.Drawing.Size(44, 15)
        Me.lblOOP1.TabIndex = 0
        Me.lblOOP1.Text = "OOP1"
        '
        'lblPDA
        '
        Me.lblPDA.AutoSize = True
        Me.lblPDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDA.Location = New System.Drawing.Point(46, 41)
        Me.lblPDA.Name = "lblPDA"
        Me.lblPDA.Size = New System.Drawing.Size(34, 15)
        Me.lblPDA.TabIndex = 0
        Me.lblPDA.Text = "PDA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblGRADE)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblAVERAGE)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblTOTAL)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 237)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATIONS"
        '
        'lblGRADE
        '
        Me.lblGRADE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGRADE.Location = New System.Drawing.Point(105, 171)
        Me.lblGRADE.Name = "lblGRADE"
        Me.lblGRADE.Size = New System.Drawing.Size(134, 46)
        Me.lblGRADE.TabIndex = 0
        Me.lblGRADE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(126, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GRADE"
        '
        'lblAVERAGE
        '
        Me.lblAVERAGE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAVERAGE.Location = New System.Drawing.Point(105, 109)
        Me.lblAVERAGE.Name = "lblAVERAGE"
        Me.lblAVERAGE.Size = New System.Drawing.Size(134, 46)
        Me.lblAVERAGE.TabIndex = 0
        Me.lblAVERAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "AVERAGE"
        '
        'lblTOTAL
        '
        Me.lblTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTOTAL.Location = New System.Drawing.Point(105, 45)
        Me.lblTOTAL.Name = "lblTOTAL"
        Me.lblTOTAL.Size = New System.Drawing.Size(134, 36)
        Me.lblTOTAL.TabIndex = 0
        Me.lblTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEXIT)
        Me.GroupBox3.Controls.Add(Me.btnCLEAR)
        Me.GroupBox3.Controls.Add(Me.btnCOMPUTE)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 298)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 174)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ANALYSIS"
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(368, 76)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(75, 23)
        Me.btnEXIT.TabIndex = 0
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnCLEAR
        '
        Me.btnCLEAR.Location = New System.Drawing.Point(237, 76)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.btnCLEAR.TabIndex = 0
        Me.btnCLEAR.Text = "C&LEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnCOMPUTE
        '
        Me.btnCOMPUTE.Location = New System.Drawing.Point(101, 76)
        Me.btnCOMPUTE.Name = "btnCOMPUTE"
        Me.btnCOMPUTE.Size = New System.Drawing.Size(75, 23)
        Me.btnCOMPUTE.TabIndex = 0
        Me.btnCOMPUTE.Text = "&COMPUTE"
        Me.btnCOMPUTE.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.UNITS)
        Me.Name = "Form1"
        Me.Text = "c"
        Me.UNITS.ResumeLayout(False)
        Me.UNITS.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UNITS As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMIS As TextBox
    Friend WithEvents txtOOP1 As TextBox
    Friend WithEvents txtPDA As TextBox
    Friend WithEvents lblMIS As Label
    Friend WithEvents lblOOP1 As Label
    Friend WithEvents lblPDA As Label
    Friend WithEvents lblGRADE As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAVERAGE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTOTAL As Label
    Friend WithEvents btnEXIT As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents btnCOMPUTE As Button
End Class
