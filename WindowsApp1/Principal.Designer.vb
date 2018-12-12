<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.btn_oficina = New System.Windows.Forms.Button()
        Me.btn_mesa = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.btn_normal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_oficina
        '
        Me.btn_oficina.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_oficina.Location = New System.Drawing.Point(53, 34)
        Me.btn_oficina.Name = "btn_oficina"
        Me.btn_oficina.Size = New System.Drawing.Size(292, 40)
        Me.btn_oficina.TabIndex = 0
        Me.btn_oficina.Text = "Usuario Oficina"
        Me.btn_oficina.UseVisualStyleBackColor = True
        '
        'btn_mesa
        '
        Me.btn_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa.Location = New System.Drawing.Point(53, 104)
        Me.btn_mesa.Name = "btn_mesa"
        Me.btn_mesa.Size = New System.Drawing.Size(292, 40)
        Me.btn_mesa.TabIndex = 1
        Me.btn_mesa.Text = "Mesa de Entrada"
        Me.btn_mesa.UseVisualStyleBackColor = True
        '
        'btn_admin
        '
        Me.btn_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.Location = New System.Drawing.Point(53, 176)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(292, 40)
        Me.btn_admin.TabIndex = 2
        Me.btn_admin.Text = "Administrador"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'btn_normal
        '
        Me.btn_normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_normal.Location = New System.Drawing.Point(53, 236)
        Me.btn_normal.Name = "btn_normal"
        Me.btn_normal.Size = New System.Drawing.Size(292, 40)
        Me.btn_normal.TabIndex = 3
        Me.btn_normal.Text = "Usuario Normal"
        Me.btn_normal.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(405, 313)
        Me.Controls.Add(Me.btn_normal)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.btn_mesa)
        Me.Controls.Add(Me.btn_oficina)
        Me.Name = "frm_principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_oficina As Button
    Friend WithEvents btn_mesa As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents btn_normal As Button
End Class
