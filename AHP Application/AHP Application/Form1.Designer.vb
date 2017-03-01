<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtncriteria = New System.Windows.Forms.TextBox()
        Me.txtnalternatives = New System.Windows.Forms.TextBox()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.dgvpcm = New System.Windows.Forms.DataGridView()
        Me.dgvnormalizedpcm = New System.Windows.Forms.DataGridView()
        Me.btnnormalize = New System.Windows.Forms.Button()
        Me.dgvfinaldec = New System.Windows.Forms.DataGridView()
        Me.btncalfinaldec = New System.Windows.Forms.Button()
        Me.btninitialize = New System.Windows.Forms.Button()
        CType(Me.dgvpcm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvnormalizedpcm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvfinaldec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Number of Criteria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Number of Alternatives"
        '
        'txtncriteria
        '
        Me.txtncriteria.AccessibleName = "txtncriteria"
        Me.txtncriteria.Location = New System.Drawing.Point(194, 34)
        Me.txtncriteria.Name = "txtncriteria"
        Me.txtncriteria.Size = New System.Drawing.Size(100, 20)
        Me.txtncriteria.TabIndex = 2
        '
        'txtnalternatives
        '
        Me.txtnalternatives.AccessibleName = "txtnalternatives"
        Me.txtnalternatives.Location = New System.Drawing.Point(194, 78)
        Me.txtnalternatives.Name = "txtnalternatives"
        Me.txtnalternatives.Size = New System.Drawing.Size(100, 20)
        Me.txtnalternatives.TabIndex = 3
        '
        'btngenerate
        '
        Me.btngenerate.AccessibleName = "btngenerate"
        Me.btngenerate.Location = New System.Drawing.Point(173, 120)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(75, 23)
        Me.btngenerate.TabIndex = 4
        Me.btngenerate.Text = "Generate"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'dgvpcm
        '
        Me.dgvpcm.AllowUserToAddRows = False
        Me.dgvpcm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpcm.Location = New System.Drawing.Point(49, 162)
        Me.dgvpcm.Name = "dgvpcm"
        Me.dgvpcm.Size = New System.Drawing.Size(460, 245)
        Me.dgvpcm.TabIndex = 5
        '
        'dgvnormalizedpcm
        '
        Me.dgvnormalizedpcm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnormalizedpcm.Location = New System.Drawing.Point(516, 162)
        Me.dgvnormalizedpcm.Name = "dgvnormalizedpcm"
        Me.dgvnormalizedpcm.Size = New System.Drawing.Size(460, 245)
        Me.dgvnormalizedpcm.TabIndex = 6
        '
        'btnnormalize
        '
        Me.btnnormalize.Location = New System.Drawing.Point(616, 117)
        Me.btnnormalize.Name = "btnnormalize"
        Me.btnnormalize.Size = New System.Drawing.Size(75, 23)
        Me.btnnormalize.TabIndex = 7
        Me.btnnormalize.Text = "Normalize"
        Me.btnnormalize.UseVisualStyleBackColor = True
        '
        'dgvfinaldec
        '
        Me.dgvfinaldec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfinaldec.Location = New System.Drawing.Point(49, 461)
        Me.dgvfinaldec.Name = "dgvfinaldec"
        Me.dgvfinaldec.Size = New System.Drawing.Size(927, 245)
        Me.dgvfinaldec.TabIndex = 8
        '
        'btncalfinaldec
        '
        Me.btncalfinaldec.AccessibleName = "btngenerate"
        Me.btncalfinaldec.Location = New System.Drawing.Point(280, 423)
        Me.btncalfinaldec.Name = "btncalfinaldec"
        Me.btncalfinaldec.Size = New System.Drawing.Size(145, 23)
        Me.btncalfinaldec.TabIndex = 9
        Me.btncalfinaldec.Text = "Calculate Final Decision"
        Me.btncalfinaldec.UseVisualStyleBackColor = True
        '
        'btninitialize
        '
        Me.btninitialize.AccessibleName = "btngenerate"
        Me.btninitialize.Location = New System.Drawing.Point(173, 423)
        Me.btninitialize.Name = "btninitialize"
        Me.btninitialize.Size = New System.Drawing.Size(75, 23)
        Me.btninitialize.TabIndex = 10
        Me.btninitialize.Text = "Initialize"
        Me.btninitialize.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AccessibleName = "frmmain"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btninitialize)
        Me.Controls.Add(Me.btncalfinaldec)
        Me.Controls.Add(Me.dgvfinaldec)
        Me.Controls.Add(Me.btnnormalize)
        Me.Controls.Add(Me.dgvnormalizedpcm)
        Me.Controls.Add(Me.dgvpcm)
        Me.Controls.Add(Me.btngenerate)
        Me.Controls.Add(Me.txtnalternatives)
        Me.Controls.Add(Me.txtncriteria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmain"
        Me.Text = "Main GUI"
        CType(Me.dgvpcm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvnormalizedpcm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvfinaldec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtncriteria As TextBox
    Friend WithEvents txtnalternatives As TextBox
    Friend WithEvents btngenerate As Button
    Friend WithEvents dgvpcm As DataGridView
    Friend WithEvents dgvnormalizedpcm As DataGridView
    Friend WithEvents btnnormalize As Button
    Friend WithEvents dgvfinaldec As DataGridView
    Friend WithEvents btncalfinaldec As Button
    Friend WithEvents btninitialize As Button
End Class
