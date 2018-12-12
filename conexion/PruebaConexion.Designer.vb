<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PruebaConexion
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
        Me.btn_conec = New System.Windows.Forms.Button()
        Me.btn_desccone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_conec
        '
        Me.btn_conec.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_conec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_conec.Location = New System.Drawing.Point(198, 67)
        Me.btn_conec.Name = "btn_conec"
        Me.btn_conec.Size = New System.Drawing.Size(193, 61)
        Me.btn_conec.TabIndex = 0
        Me.btn_conec.Text = "Conectar"
        Me.btn_conec.UseVisualStyleBackColor = False
        '
        'btn_desccone
        '
        Me.btn_desccone.BackColor = System.Drawing.Color.Crimson
        Me.btn_desccone.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desccone.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_desccone.Location = New System.Drawing.Point(221, 102)
        Me.btn_desccone.Name = "btn_desccone"
        Me.btn_desccone.Size = New System.Drawing.Size(193, 61)
        Me.btn_desccone.TabIndex = 1
        Me.btn_desccone.Text = "Desconectar"
        Me.btn_desccone.UseVisualStyleBackColor = False
        Me.btn_desccone.Visible = False
        '
        'PruebaConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 207)
        Me.Controls.Add(Me.btn_desccone)
        Me.Controls.Add(Me.btn_conec)
        Me.Name = "PruebaConexion"
        Me.Text = "PruebaConexion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_conec As Windows.Forms.Button
    Friend WithEvents btn_desccone As Windows.Forms.Button
End Class
