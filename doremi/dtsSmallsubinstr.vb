﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dtsSmallsubinstr
    Inherits DataSet
    
    Private tabletblSubInstruments As tblSubInstrumentsDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("tblSubInstruments")) Is Nothing) Then
                Me.Tables.Add(New tblSubInstrumentsDataTable(ds.Tables("tblSubInstruments")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property tblSubInstruments As tblSubInstrumentsDataTable
        Get
            Return Me.tabletblSubInstruments
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dtsSmallsubinstr = CType(MyBase.Clone,dtsSmallsubinstr)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("tblSubInstruments")) Is Nothing) Then
            Me.Tables.Add(New tblSubInstrumentsDataTable(ds.Tables("tblSubInstruments")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tabletblSubInstruments = CType(Me.Tables("tblSubInstruments"),tblSubInstrumentsDataTable)
        If (Not (Me.tabletblSubInstruments) Is Nothing) Then
            Me.tabletblSubInstruments.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dtsSmallsubinstr"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dtsSmallsubinstr.xsd"
        Me.Locale = New System.Globalization.CultureInfo("el-GR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tabletblSubInstruments = New tblSubInstrumentsDataTable
        Me.Tables.Add(Me.tabletblSubInstruments)
    End Sub
    
    Private Function ShouldSerializetblSubInstruments() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub tblSubInstrumentsRowChangeEventHandler(ByVal sender As Object, ByVal e As tblSubInstrumentsRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblSubInstrumentsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columninstruments As DataColumn
        
        Private columnsubcategoryInstrument As DataColumn
        
        Friend Sub New()
            MyBase.New("tblSubInstruments")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property instrumentsColumn As DataColumn
            Get
                Return Me.columninstruments
            End Get
        End Property
        
        Friend ReadOnly Property subcategoryInstrumentColumn As DataColumn
            Get
                Return Me.columnsubcategoryInstrument
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As tblSubInstrumentsRow
            Get
                Return CType(Me.Rows(index),tblSubInstrumentsRow)
            End Get
        End Property
        
        Public Event tblSubInstrumentsRowChanged As tblSubInstrumentsRowChangeEventHandler
        
        Public Event tblSubInstrumentsRowChanging As tblSubInstrumentsRowChangeEventHandler
        
        Public Event tblSubInstrumentsRowDeleted As tblSubInstrumentsRowChangeEventHandler
        
        Public Event tblSubInstrumentsRowDeleting As tblSubInstrumentsRowChangeEventHandler
        
        Public Overloads Sub AddtblSubInstrumentsRow(ByVal row As tblSubInstrumentsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddtblSubInstrumentsRow(ByVal instruments As String, ByVal subcategoryInstrument As String) As tblSubInstrumentsRow
            Dim rowtblSubInstrumentsRow As tblSubInstrumentsRow = CType(Me.NewRow,tblSubInstrumentsRow)
            rowtblSubInstrumentsRow.ItemArray = New Object() {instruments, subcategoryInstrument}
            Me.Rows.Add(rowtblSubInstrumentsRow)
            Return rowtblSubInstrumentsRow
        End Function
        
        Public Function FindBysubcategoryInstrument(ByVal subcategoryInstrument As String) As tblSubInstrumentsRow
            Return CType(Me.Rows.Find(New Object() {subcategoryInstrument}),tblSubInstrumentsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As tblSubInstrumentsDataTable = CType(MyBase.Clone,tblSubInstrumentsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New tblSubInstrumentsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columninstruments = Me.Columns("instruments")
            Me.columnsubcategoryInstrument = Me.Columns("subcategoryInstrument")
        End Sub
        
        Private Sub InitClass()
            Me.columninstruments = New DataColumn("instruments", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columninstruments)
            Me.columnsubcategoryInstrument = New DataColumn("subcategoryInstrument", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnsubcategoryInstrument)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnsubcategoryInstrument}, true))
            Me.columnsubcategoryInstrument.AllowDBNull = false
            Me.columnsubcategoryInstrument.Unique = true
        End Sub
        
        Public Function NewtblSubInstrumentsRow() As tblSubInstrumentsRow
            Return CType(Me.NewRow,tblSubInstrumentsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New tblSubInstrumentsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(tblSubInstrumentsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.tblSubInstrumentsRowChangedEvent) Is Nothing) Then
                RaiseEvent tblSubInstrumentsRowChanged(Me, New tblSubInstrumentsRowChangeEvent(CType(e.Row,tblSubInstrumentsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.tblSubInstrumentsRowChangingEvent) Is Nothing) Then
                RaiseEvent tblSubInstrumentsRowChanging(Me, New tblSubInstrumentsRowChangeEvent(CType(e.Row,tblSubInstrumentsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.tblSubInstrumentsRowDeletedEvent) Is Nothing) Then
                RaiseEvent tblSubInstrumentsRowDeleted(Me, New tblSubInstrumentsRowChangeEvent(CType(e.Row,tblSubInstrumentsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.tblSubInstrumentsRowDeletingEvent) Is Nothing) Then
                RaiseEvent tblSubInstrumentsRowDeleting(Me, New tblSubInstrumentsRowChangeEvent(CType(e.Row,tblSubInstrumentsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovetblSubInstrumentsRow(ByVal row As tblSubInstrumentsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblSubInstrumentsRow
        Inherits DataRow
        
        Private tabletblSubInstruments As tblSubInstrumentsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tabletblSubInstruments = CType(Me.Table,tblSubInstrumentsDataTable)
        End Sub
        
        Public Property instruments As String
            Get
                Try 
                    Return CType(Me(Me.tabletblSubInstruments.instrumentsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabletblSubInstruments.instrumentsColumn) = value
            End Set
        End Property
        
        Public Property subcategoryInstrument As String
            Get
                Return CType(Me(Me.tabletblSubInstruments.subcategoryInstrumentColumn),String)
            End Get
            Set
                Me(Me.tabletblSubInstruments.subcategoryInstrumentColumn) = value
            End Set
        End Property
        
        Public Function IsinstrumentsNull() As Boolean
            Return Me.IsNull(Me.tabletblSubInstruments.instrumentsColumn)
        End Function
        
        Public Sub SetinstrumentsNull()
            Me(Me.tabletblSubInstruments.instrumentsColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblSubInstrumentsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As tblSubInstrumentsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As tblSubInstrumentsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As tblSubInstrumentsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class