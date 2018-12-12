<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adminstrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adminstrador))
        Me.btn_oficina = New System.Windows.Forms.Button()
        Me.btn_Empleado = New System.Windows.Forms.Button()
        Me.btn_asunto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_oficina
        '
        Me.btn_oficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_oficina.Location = New System.Drawing.Point(71, 120)
        Me.btn_oficina.Name = "btn_oficina"
        Me.btn_oficina.Size = New System.Drawing.Size(222, 47)
        Me.btn_oficina.TabIndex = 0
        Me.btn_oficina.Text = "Agregar OFicina"
        Me.btn_oficina.UseVisualStyleBackColor = True
        '
        'btn_Empleado
        '
        Me.btn_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Empleado.Location = New System.Drawing.Point(71, 44)
        Me.btn_Empleado.Name = "btn_Empleado"
        Me.btn_Empleado.Size = New System.Drawing.Size(222, 47)
        Me.btn_Empleado.TabIndex = 1
        Me.btn_Empleado.Text = "Agregar Empleado"
        Me.btn_Empleado.UseVisualStyleBackColor = True
        '
        'btn_asunto
        '
        Me.btn_asunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_asunto.Location = New System.Drawing.Point(71, 196)
        Me.btn_asunto.Name = "btn_asunto"
        Me.btn_asunto.Size = New System.Drawing.Size(222, 47)
        Me.btn_asunto.TabIndex = 2
        Me.btn_asunto.Text = "Agregar Asunto"
        Me.btn_asunto.UseVisualStyleBackColor = True
        '
        'frm_adminstrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_asunto)
        Me.Controls.Add(Me.btn_Empleado)
        Me.Controls.Add(Me.btn_oficina)
        Me.Name = "frm_adminstrador"
        Me.Text = "Administrador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_oficina As Button
    Friend WithEvents btn_Empleado As Button
    Friend WithEvents btn_asunto As Button
End Class
