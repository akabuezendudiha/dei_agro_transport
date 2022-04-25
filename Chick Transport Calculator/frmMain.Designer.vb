<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDistanceCharge = New System.Windows.Forms.TextBox()
        Me.txtDistanceOfTravel = New System.Windows.Forms.TextBox()
        Me.txtDistanceChargePerKm = New System.Windows.Forms.TextBox()
        Me.txtFixedCharge = New System.Windows.Forms.TextBox()
        Me.txtComputedGITCost = New System.Windows.Forms.TextBox()
        Me.txtGITPercentage = New System.Windows.Forms.TextBox()
        Me.txtTotalValueOfChicks = New System.Windows.Forms.TextBox()
        Me.txtCostPerDayoldChick = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNoOfChicks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblComputedCostOfChick = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalDistanceCharge)
        Me.GroupBox1.Controls.Add(Me.txtDistanceOfTravel)
        Me.GroupBox1.Controls.Add(Me.txtDistanceChargePerKm)
        Me.GroupBox1.Controls.Add(Me.txtFixedCharge)
        Me.GroupBox1.Controls.Add(Me.txtComputedGITCost)
        Me.GroupBox1.Controls.Add(Me.txtGITPercentage)
        Me.GroupBox1.Controls.Add(Me.txtTotalValueOfChicks)
        Me.GroupBox1.Controls.Add(Me.txtCostPerDayoldChick)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNoOfChicks)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cost Per Chick"
        '
        'txtTotalDistanceCharge
        '
        Me.txtTotalDistanceCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDistanceCharge.Location = New System.Drawing.Point(369, 330)
        Me.txtTotalDistanceCharge.Name = "txtTotalDistanceCharge"
        Me.txtTotalDistanceCharge.ReadOnly = True
        Me.txtTotalDistanceCharge.Size = New System.Drawing.Size(174, 25)
        Me.txtTotalDistanceCharge.TabIndex = 6
        Me.txtTotalDistanceCharge.Text = "0"
        Me.txtTotalDistanceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDistanceOfTravel
        '
        Me.txtDistanceOfTravel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDistanceOfTravel.Location = New System.Drawing.Point(369, 293)
        Me.txtDistanceOfTravel.Name = "txtDistanceOfTravel"
        Me.txtDistanceOfTravel.Size = New System.Drawing.Size(174, 25)
        Me.txtDistanceOfTravel.TabIndex = 5
        Me.txtDistanceOfTravel.Text = "0"
        Me.txtDistanceOfTravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDistanceChargePerKm
        '
        Me.txtDistanceChargePerKm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDistanceChargePerKm.Location = New System.Drawing.Point(369, 256)
        Me.txtDistanceChargePerKm.Name = "txtDistanceChargePerKm"
        Me.txtDistanceChargePerKm.Size = New System.Drawing.Size(174, 25)
        Me.txtDistanceChargePerKm.TabIndex = 4
        Me.txtDistanceChargePerKm.Text = "900"
        Me.txtDistanceChargePerKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixedCharge
        '
        Me.txtFixedCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFixedCharge.Location = New System.Drawing.Point(369, 219)
        Me.txtFixedCharge.Name = "txtFixedCharge"
        Me.txtFixedCharge.Size = New System.Drawing.Size(174, 25)
        Me.txtFixedCharge.TabIndex = 3
        Me.txtFixedCharge.Text = "250000"
        Me.txtFixedCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComputedGITCost
        '
        Me.txtComputedGITCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComputedGITCost.Location = New System.Drawing.Point(369, 182)
        Me.txtComputedGITCost.Name = "txtComputedGITCost"
        Me.txtComputedGITCost.ReadOnly = True
        Me.txtComputedGITCost.Size = New System.Drawing.Size(174, 25)
        Me.txtComputedGITCost.TabIndex = 10
        Me.txtComputedGITCost.Text = "0"
        Me.txtComputedGITCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGITPercentage
        '
        Me.txtGITPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGITPercentage.Location = New System.Drawing.Point(369, 108)
        Me.txtGITPercentage.Name = "txtGITPercentage"
        Me.txtGITPercentage.Size = New System.Drawing.Size(174, 25)
        Me.txtGITPercentage.TabIndex = 2
        Me.txtGITPercentage.Text = "0"
        Me.txtGITPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalValueOfChicks
        '
        Me.txtTotalValueOfChicks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalValueOfChicks.Location = New System.Drawing.Point(368, 145)
        Me.txtTotalValueOfChicks.Name = "txtTotalValueOfChicks"
        Me.txtTotalValueOfChicks.ReadOnly = True
        Me.txtTotalValueOfChicks.Size = New System.Drawing.Size(174, 25)
        Me.txtTotalValueOfChicks.TabIndex = 9
        Me.txtTotalValueOfChicks.Text = "0"
        Me.txtTotalValueOfChicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPerDayoldChick
        '
        Me.txtCostPerDayoldChick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerDayoldChick.Location = New System.Drawing.Point(369, 71)
        Me.txtCostPerDayoldChick.Name = "txtCostPerDayoldChick"
        Me.txtCostPerDayoldChick.Size = New System.Drawing.Size(174, 25)
        Me.txtCostPerDayoldChick.TabIndex = 1
        Me.txtCostPerDayoldChick.Text = "0"
        Me.txtCostPerDayoldChick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(281, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total Distance Charge [To && Fro] (₦)"
        '
        'txtNoOfChicks
        '
        Me.txtNoOfChicks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoOfChicks.Location = New System.Drawing.Point(369, 34)
        Me.txtNoOfChicks.Name = "txtNoOfChicks"
        Me.txtNoOfChicks.Size = New System.Drawing.Size(174, 25)
        Me.txtNoOfChicks.TabIndex = 0
        Me.txtNoOfChicks.Text = "0"
        Me.txtNoOfChicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Distance of Travel (To destination in km)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Distance Charge / km (₦)"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fixed Vehicle Charge / Trip (₦)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "GIT Insurance Cost (₦)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "GIT Percentage (%)"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Value of DOC being Transported"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cost Per Day-old Chick (₦)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Chicks To Transport"
        '
        'btnCompute
        '
        Me.btnCompute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCompute.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCompute.Location = New System.Drawing.Point(12, 526)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(240, 36)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(425, 526)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 36)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblComputedCostOfChick)
        Me.Panel1.Location = New System.Drawing.Point(11, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 84)
        Me.Panel1.TabIndex = 3
        '
        'lblComputedCostOfChick
        '
        Me.lblComputedCostOfChick.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComputedCostOfChick.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblComputedCostOfChick.Location = New System.Drawing.Point(20, 16)
        Me.lblComputedCostOfChick.Name = "lblComputedCostOfChick"
        Me.lblComputedCostOfChick.Size = New System.Drawing.Size(524, 53)
        Me.lblComputedCostOfChick.TabIndex = 0
        Me.lblComputedCostOfChick.Text = "₦0"
        Me.lblComputedCostOfChick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(170, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(266, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cost of Transport Per Chick (₦)"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(583, 574)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chick Transport Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoOfChicks As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtDistanceChargePerKm As TextBox
    Friend WithEvents txtFixedCharge As TextBox
    Friend WithEvents txtComputedGITCost As TextBox
    Friend WithEvents txtGITPercentage As TextBox
    Friend WithEvents txtCostPerDayoldChick As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblComputedCostOfChick As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDistanceOfTravel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalValueOfChicks As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalDistanceCharge As TextBox
    Friend WithEvents Label10 As Label
End Class
