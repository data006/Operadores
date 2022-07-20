<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperadoresLogicos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpAritmeticos = New System.Windows.Forms.GroupBox()
        Me.cmbArit = New System.Windows.Forms.ComboBox()
        Me.txtArit1 = New System.Windows.Forms.TextBox()
        Me.txtArit2 = New System.Windows.Forms.TextBox()
        Me.grpLogicos = New System.Windows.Forms.GroupBox()
        Me.cmbLog2 = New System.Windows.Forms.ComboBox()
        Me.cmbLog1 = New System.Windows.Forms.ComboBox()
        Me.cmbLog = New System.Windows.Forms.ComboBox()
        Me.grpRelacionales = New System.Windows.Forms.GroupBox()
        Me.cmbRel = New System.Windows.Forms.ComboBox()
        Me.txtRel1 = New System.Windows.Forms.TextBox()
        Me.txtRel2 = New System.Windows.Forms.TextBox()
        Me.grpAritmeticos.SuspendLayout()
        Me.grpLogicos.SuspendLayout()
        Me.grpRelacionales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAritmeticos
        '
        Me.grpAritmeticos.Controls.Add(Me.cmbArit)
        Me.grpAritmeticos.Controls.Add(Me.txtArit1)
        Me.grpAritmeticos.Controls.Add(Me.txtArit2)
        Me.grpAritmeticos.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAritmeticos.Location = New System.Drawing.Point(55, 26)
        Me.grpAritmeticos.Name = "grpAritmeticos"
        Me.grpAritmeticos.Size = New System.Drawing.Size(236, 102)
        Me.grpAritmeticos.TabIndex = 0
        Me.grpAritmeticos.TabStop = False
        Me.grpAritmeticos.Text = "Aritmeticos"
        '
        'cmbArit
        '
        Me.cmbArit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArit.FormattingEnabled = True
        Me.cmbArit.Items.AddRange(New Object() {"+", "-", "*", "/", "\", "Mod", "^"})
        Me.cmbArit.Location = New System.Drawing.Point(6, 56)
        Me.cmbArit.Name = "cmbArit"
        Me.cmbArit.Size = New System.Drawing.Size(224, 21)
        Me.cmbArit.TabIndex = 2
        '
        'txtArit1
        '
        Me.txtArit1.Location = New System.Drawing.Point(6, 30)
        Me.txtArit1.Name = "txtArit1"
        Me.txtArit1.Size = New System.Drawing.Size(94, 20)
        Me.txtArit1.TabIndex = 1
        '
        'txtArit2
        '
        Me.txtArit2.Location = New System.Drawing.Point(136, 30)
        Me.txtArit2.Name = "txtArit2"
        Me.txtArit2.Size = New System.Drawing.Size(94, 20)
        Me.txtArit2.TabIndex = 0
        '
        'grpLogicos
        '
        Me.grpLogicos.Controls.Add(Me.cmbLog2)
        Me.grpLogicos.Controls.Add(Me.cmbLog1)
        Me.grpLogicos.Controls.Add(Me.cmbLog)
        Me.grpLogicos.Font = New System.Drawing.Font("Felix Titling", 8.25!)
        Me.grpLogicos.Location = New System.Drawing.Point(397, 26)
        Me.grpLogicos.Name = "grpLogicos"
        Me.grpLogicos.Size = New System.Drawing.Size(236, 102)
        Me.grpLogicos.TabIndex = 3
        Me.grpLogicos.TabStop = False
        Me.grpLogicos.Text = "Logicos"
        '
        'cmbLog2
        '
        Me.cmbLog2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLog2.FormattingEnabled = True
        Me.cmbLog2.Items.AddRange(New Object() {"False", "True"})
        Me.cmbLog2.Location = New System.Drawing.Point(146, 30)
        Me.cmbLog2.Name = "cmbLog2"
        Me.cmbLog2.Size = New System.Drawing.Size(84, 21)
        Me.cmbLog2.TabIndex = 4
        '
        'cmbLog1
        '
        Me.cmbLog1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLog1.FormattingEnabled = True
        Me.cmbLog1.Items.AddRange(New Object() {"False", "True"})
        Me.cmbLog1.Location = New System.Drawing.Point(6, 29)
        Me.cmbLog1.Name = "cmbLog1"
        Me.cmbLog1.Size = New System.Drawing.Size(84, 21)
        Me.cmbLog1.TabIndex = 3
        '
        'cmbLog
        '
        Me.cmbLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLog.FormattingEnabled = True
        Me.cmbLog.Items.AddRange(New Object() {"Not", "And", "Or", "Xor"})
        Me.cmbLog.Location = New System.Drawing.Point(6, 56)
        Me.cmbLog.Name = "cmbLog"
        Me.cmbLog.Size = New System.Drawing.Size(224, 21)
        Me.cmbLog.TabIndex = 2
        '
        'grpRelacionales
        '
        Me.grpRelacionales.Controls.Add(Me.cmbRel)
        Me.grpRelacionales.Controls.Add(Me.txtRel1)
        Me.grpRelacionales.Controls.Add(Me.txtRel2)
        Me.grpRelacionales.Font = New System.Drawing.Font("Felix Titling", 8.25!)
        Me.grpRelacionales.Location = New System.Drawing.Point(227, 134)
        Me.grpRelacionales.Name = "grpRelacionales"
        Me.grpRelacionales.Size = New System.Drawing.Size(236, 102)
        Me.grpRelacionales.TabIndex = 3
        Me.grpRelacionales.TabStop = False
        Me.grpRelacionales.Text = "Relacionales"
        '
        'cmbRel
        '
        Me.cmbRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRel.FormattingEnabled = True
        Me.cmbRel.Items.AddRange(New Object() {">", "<", "<=", ">=", "=", "<>"})
        Me.cmbRel.Location = New System.Drawing.Point(6, 56)
        Me.cmbRel.Name = "cmbRel"
        Me.cmbRel.Size = New System.Drawing.Size(224, 21)
        Me.cmbRel.TabIndex = 2
        '
        'txtRel1
        '
        Me.txtRel1.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRel1.Location = New System.Drawing.Point(6, 30)
        Me.txtRel1.Name = "txtRel1"
        Me.txtRel1.Size = New System.Drawing.Size(94, 24)
        Me.txtRel1.TabIndex = 1
        '
        'txtRel2
        '
        Me.txtRel2.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRel2.Location = New System.Drawing.Point(136, 30)
        Me.txtRel2.Name = "txtRel2"
        Me.txtRel2.Size = New System.Drawing.Size(94, 24)
        Me.txtRel2.TabIndex = 0
        '
        'frmOperadoresLogicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(689, 267)
        Me.Controls.Add(Me.grpRelacionales)
        Me.Controls.Add(Me.grpLogicos)
        Me.Controls.Add(Me.grpAritmeticos)
        Me.Name = "frmOperadoresLogicos"
        Me.Text = "Operadores Logicos"
        Me.grpAritmeticos.ResumeLayout(False)
        Me.grpAritmeticos.PerformLayout()
        Me.grpLogicos.ResumeLayout(False)
        Me.grpRelacionales.ResumeLayout(False)
        Me.grpRelacionales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAritmeticos As GroupBox
    Friend WithEvents cmbArit As ComboBox
    Friend WithEvents txtArit1 As TextBox
    Friend WithEvents txtArit2 As TextBox
    Friend WithEvents grpLogicos As GroupBox
    Friend WithEvents cmbLog As ComboBox
    Friend WithEvents grpRelacionales As GroupBox
    Friend WithEvents cmbRel As ComboBox
    Friend WithEvents txtRel1 As TextBox
    Friend WithEvents txtRel2 As TextBox
    Friend WithEvents cmbLog2 As ComboBox
    Friend WithEvents cmbLog1 As ComboBox
End Class
