<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.Description = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Reference = New System.Windows.Forms.TextBox()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Record = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.Discontinued = New System.Windows.Forms.CheckBox()
        Me.lblDiscontinued = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Supply_dbDataSet2 = New WindowsApplication1.supply_dbDataSet2()
        Me.stocknavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Supply_dbDataSet1 = New WindowsApplication1.supply_dbDataSet()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supply_dbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stocknavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stocknavigator.SuspendLayout()
        CType(Me.Supply_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(92, 104)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(137, 20)
        Me.Description.TabIndex = 0
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(26, 107)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description"
        '
        'Reference
        '
        Me.Reference.Location = New System.Drawing.Point(92, 57)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(100, 20)
        Me.Reference.TabIndex = 2
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(29, 60)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(57, 13)
        Me.lblReference.TabIndex = 3
        Me.lblReference.Text = "Reference"
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(92, 178)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(100, 20)
        Me.Price.TabIndex = 4
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(43, 184)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price"
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(321, 184)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(100, 20)
        Me.Quantity.TabIndex = 6
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(269, 187)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity"
        '
        'Record
        '
        Me.Record.AutoSize = True
        Me.Record.Location = New System.Drawing.Point(310, 63)
        Me.Record.Name = "Record"
        Me.Record.Size = New System.Drawing.Size(42, 13)
        Me.Record.TabIndex = 8
        Me.Record.Text = "Record"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRecord.Location = New System.Drawing.Point(372, 63)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(84, 15)
        Me.lblRecord.TabIndex = 9
        Me.lblRecord.Text = "                         "
        '
        'Discontinued
        '
        Me.Discontinued.AutoSize = True
        Me.Discontinued.Location = New System.Drawing.Point(150, 240)
        Me.Discontinued.Name = "Discontinued"
        Me.Discontinued.Size = New System.Drawing.Size(15, 14)
        Me.Discontinued.TabIndex = 10
        Me.Discontinued.UseVisualStyleBackColor = True
        '
        'lblDiscontinued
        '
        Me.lblDiscontinued.AutoSize = True
        Me.lblDiscontinued.Location = New System.Drawing.Point(66, 240)
        Me.lblDiscontinued.Name = "lblDiscontinued"
        Me.lblDiscontinued.Size = New System.Drawing.Size(69, 13)
        Me.lblDiscontinued.TabIndex = 11
        Me.lblDiscontinued.Text = "Discontinued"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(506, 63)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(506, 92)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(506, 121)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(506, 150)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnArchive
        '
        Me.btnArchive.Location = New System.Drawing.Point(506, 178)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(75, 23)
        Me.btnArchive.TabIndex = 17
        Me.btnArchive.Text = "Archive"
        Me.btnArchive.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(506, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(120, 294)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 71)
        Me.btnFirst.TabIndex = 19
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(211, 294)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 71)
        Me.btnPrevious.TabIndex = 20
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(393, 294)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 71)
        Me.btnLast.TabIndex = 21
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(301, 294)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 71)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Supply_dbDataSet1
        Me.BindingSource1.Position = 0
        '
        'Supply_dbDataSet2
        '
        Me.Supply_dbDataSet2.DataSetName = "supply_dbDataSet2"
        Me.Supply_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'stocknavigator
        '
        Me.stocknavigator.AddNewItem = Nothing
        Me.stocknavigator.BindingSource = Me.BindingSource1
        Me.stocknavigator.CountItem = Me.BindingNavigatorCountItem
        Me.stocknavigator.DeleteItem = Nothing
        Me.stocknavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.stocknavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.stocknavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.stocknavigator.Location = New System.Drawing.Point(243, 240)
        Me.stocknavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.stocknavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.stocknavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.stocknavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.stocknavigator.Name = "stocknavigator"
        Me.stocknavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.stocknavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.stocknavigator.Size = New System.Drawing.Size(194, 25)
        Me.stocknavigator.TabIndex = 23
        Me.stocknavigator.Text = "stocknavigator"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "1"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'Supply_dbDataSet1
        '
        Me.Supply_dbDataSet1.DataSetName = "supply_dbDataSet"
        Me.Supply_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 390)
        Me.Controls.Add(Me.stocknavigator)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnArchive)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblDiscontinued)
        Me.Controls.Add(Me.Discontinued)
        Me.Controls.Add(Me.lblRecord)
        Me.Controls.Add(Me.Record)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.Reference)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Description)
        Me.Name = "frmStock"
        Me.Text = "frmStock"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supply_dbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stocknavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stocknavigator.ResumeLayout(False)
        Me.stocknavigator.PerformLayout()
        CType(Me.Supply_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Description As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents Reference As TextBox
    Friend WithEvents lblReference As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Record As Label
    Friend WithEvents lblRecord As Label
    Friend WithEvents Discontinued As CheckBox
    Friend WithEvents lblDiscontinued As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Supply_dbDataSet2 As supply_dbDataSet2
    Friend WithEvents stocknavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents Supply_dbDataSet1 As supply_dbDataSet
End Class
