<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgregarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AgregarEmpleado))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_agergar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(49, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 31)
        Me.TextBox1.TabIndex = 0
        '
        'btn_agergar
        '
        Me.btn_agergar.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_agergar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agergar.Location = New System.Drawing.Point(230, 57)
        Me.btn_agergar.Name = "btn_agergar"
        Me.btn_agergar.Size = New System.Drawing.Size(191, 37)
        Me.btn_agergar.TabIndex = 1
        Me.btn_agergar.Text = "Agregar Empleado"
        Me.btn_agergar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Location = New System.Drawing.Point(115, 138)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(191, 37)
        Me.btn_nuevo.TabIndex = 2
        Me.btn_nuevo.Text = "Nueva Persona"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'frm_AgregarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(456, 211)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_agergar)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm_AgregarEmpleado"
        Me.Text = "Agregar  Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_agergar As Button
    Friend WithEvents btn_nuevo As Button
End Class
