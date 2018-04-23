Namespace T461136
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(94, 55)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(232, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Show designer"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click)
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(94, 212)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(232, 23)
			Me.simpleButton2.TabIndex = 1
			Me.simpleButton2.Text = "Show Ribbon Designer"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click)
			' 
			' radioGroup1
			' 
			Me.radioGroup1.EditValue = 0
			Me.radioGroup1.Location = New System.Drawing.Point(94, 97)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Size = New System.Drawing.Size(232, 96)
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Use standard icons"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Use SVG icons")
            })
			Me.radioGroup1.TabIndex = 2
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(427, 309)
			Me.Controls.Add(Me.radioGroup1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup


	End Class
End Namespace

