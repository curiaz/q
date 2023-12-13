<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enroll
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(enroll))
        Panel1 = New Panel()
        Button2 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        txtsearch = New TextBox()
        dtgList = New DataGridView()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        Label3 = New Label()
        txtfullname = New TextBox()
        GroupBox4 = New GroupBox()
        Label4 = New Label()
        txtlevel = New TextBox()
        Label5 = New Label()
        txtsection = New TextBox()
        Label6 = New Label()
        cbolevel = New ComboBox()
        Label7 = New Label()
        cbosection = New ComboBox()
        Label8 = New Label()
        cbosy = New ComboBox()
        GroupBox5 = New GroupBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dtgList, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Bisque
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(763, 42)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(720, 2)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 36)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(228, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 26)
        Label1.TabIndex = 1
        Label1.Text = "Student Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 36)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(dtgList)
        GroupBox1.Controls.Add(txtsearch)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 412)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "List of Student"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 17)
        Label2.TabIndex = 0
        Label2.Text = "Search for Student Name:"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(6, 51)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(281, 29)
        txtsearch.TabIndex = 1
        ' 
        ' dtgList
        ' 
        dtgList.AllowUserToAddRows = False
        dtgList.AllowUserToDeleteRows = False
        dtgList.AllowUserToResizeColumns = False
        dtgList.AllowUserToResizeRows = False
        dtgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dtgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dtgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgList.Location = New Point(6, 82)
        dtgList.MultiSelect = False
        dtgList.Name = "dtgList"
        dtgList.RowTemplate.Height = 25
        dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgList.Size = New Size(281, 324)
        dtgList.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Controls.Add(txtfullname)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(322, 58)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 138)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Student Details"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(cbosy)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(cbosection)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(cbolevel)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(322, 202)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(432, 80)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Update Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(6, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 17)
        Label3.TabIndex = 1
        Label3.Text = "Name:"
        ' 
        ' txtfullname
        ' 
        txtfullname.Location = New Point(58, 28)
        txtfullname.Name = "txtfullname"
        txtfullname.Size = New Size(368, 27)
        txtfullname.TabIndex = 2
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(txtsection)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(txtlevel)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(6, 68)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(420, 61)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "Grade Year / Level  "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(6, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 17)
        Label4.TabIndex = 2
        Label4.Text = "Level:"
        ' 
        ' txtlevel
        ' 
        txtlevel.Location = New Point(52, 28)
        txtlevel.Name = "txtlevel"
        txtlevel.Size = New Size(147, 25)
        txtlevel.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(208, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 17)
        Label5.TabIndex = 4
        Label5.Text = "Section:"
        ' 
        ' txtsection
        ' 
        txtsection.Location = New Point(267, 28)
        txtsection.Name = "txtsection"
        txtsection.Size = New Size(147, 25)
        txtsection.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(7, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 3
        Label6.Text = "Level:"
        ' 
        ' cbolevel
        ' 
        cbolevel.FormattingEnabled = True
        cbolevel.Location = New Point(7, 43)
        cbolevel.Name = "cbolevel"
        cbolevel.Size = New Size(121, 28)
        cbolevel.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(152, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 17)
        Label7.TabIndex = 5
        Label7.Text = "Section:"
        ' 
        ' cbosection
        ' 
        cbosection.FormattingEnabled = True
        cbosection.Location = New Point(152, 43)
        cbosection.Name = "cbosection"
        cbosection.Size = New Size(121, 28)
        cbosection.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(294, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 17)
        Label8.TabIndex = 7
        Label8.Text = "Academic Year:"
        ' 
        ' cbosy
        ' 
        cbosy.FormattingEnabled = True
        cbosy.Location = New Point(294, 43)
        cbosy.Name = "cbosy"
        cbosy.Size = New Size(121, 28)
        cbosy.TabIndex = 8
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.Transparent
        GroupBox5.Controls.Add(DataGridView1)
        GroupBox5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox5.Location = New Point(322, 288)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(432, 182)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "Subjects"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(420, 154)
        DataGridView1.TabIndex = 0
        ' 
        ' enroll
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(762, 477)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "enroll"
        StartPosition = FormStartPosition.CenterScreen
        Text = "enroll"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dtgList, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbosy As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbosection As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbolevel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
