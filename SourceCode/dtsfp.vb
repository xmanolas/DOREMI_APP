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
Public Class dtsfp
    Inherits DataSet
    
    Private tabletblfp As tblfpDataTable
    
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
            If (Not (ds.Tables("tblfp")) Is Nothing) Then
                Me.Tables.Add(New tblfpDataTable(ds.Tables("tblfp")))
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
    Public ReadOnly Property tblfp As tblfpDataTable
        Get
            Return Me.tabletblfp
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dtsfp = CType(MyBase.Clone,dtsfp)
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
        If (Not (ds.Tables("tblfp")) Is Nothing) Then
            Me.Tables.Add(New tblfpDataTable(ds.Tables("tblfp")))
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
        Me.tabletblfp = CType(Me.Tables("tblfp"),tblfpDataTable)
        If (Not (Me.tabletblfp) Is Nothing) Then
            Me.tabletblfp.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dtsfp"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dtsfp.xsd"
        Me.Locale = New System.Globalization.CultureInfo("el-GR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tabletblfp = New tblfpDataTable
        Me.Tables.Add(Me.tabletblfp)
    End Sub
    
    Private Function ShouldSerializetblfp() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub tblfpRowChangeEventHandler(ByVal sender As Object, ByVal e As tblfpRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblfpDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnaa As DataColumn
        
        Private columnfp As DataColumn
        
        Friend Sub New()
            MyBase.New("tblfp")
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
        
        Friend ReadOnly Property aaColumn As DataColumn
            Get
                Return Me.columnaa
            End Get
        End Property
        
        Friend ReadOnly Property fpColumn As DataColumn
            Get
                Return Me.columnfp
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As tblfpRow
            Get
                Return CType(Me.Rows(index),tblfpRow)
            End Get
        End Property
        
        Public Event tblfpRowChanged As tblfpRowChangeEventHandler
        
        Public Event tblfpRowChanging As tblfpRowChangeEventHandler
        
        Public Event tblfpRowDeleted As tblfpRowChangeEventHandler
        
        Public Event tblfpRowDeleting As tblfpRowChangeEventHandler
        
        Public Overloads Sub AddtblfpRow(ByVal row As tblfpRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddtblfpRow(ByVal fp As String) As tblfpRow
            Dim rowtblfpRow As tblfpRow = CType(Me.NewRow,tblfpRow)
            rowtblfpRow.ItemArray = New Object() {Nothing, fp}
            Me.Rows.Add(rowtblfpRow)
            Return rowtblfpRow
        End Function
        
        Public Function FindByaa(ByVal aa As Integer) As tblfpRow
            Return CType(Me.Rows.Find(New Object() {aa}),tblfpRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As tblfpDataTable = CType(MyBase.Clone,tblfpDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New tblfpDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnaa = Me.Columns("aa")
            Me.columnfp = Me.Columns("fp")
        End Sub
        
        Private Sub InitClass()
            Me.columnaa = New DataColumn("aa", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnaa)
            Me.columnfp = New DataColumn("fp", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfp)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnaa}, true))
            Me.columnaa.AutoIncrement = true
            Me.columnaa.AllowDBNull = false
            Me.columnaa.Unique = true
        End Sub
        
        Public Function NewtblfpRow() As tblfpRow
            Return CType(Me.NewRow,tblfpRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New tblfpRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(tblfpRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.tblfpRowChangedEvent) Is Nothing) Then
                RaiseEvent tblfpRowChanged(Me, New tblfpRowChangeEvent(CType(e.Row,tblfpRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.tblfpRowChangingEvent) Is Nothing) Then
                RaiseEvent tblfpRowChanging(Me, New tblfpRowChangeEvent(CType(e.Row,tblfpRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.tblfpRowDeletedEvent) Is Nothing) Then
                RaiseEvent tblfpRowDeleted(Me, New tblfpRowChangeEvent(CType(e.Row,tblfpRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.tblfpRowDeletingEvent) Is Nothing) Then
                RaiseEvent tblfpRowDeleting(Me, New tblfpRowChangeEvent(CType(e.Row,tblfpRow), e.Action))
            End If
        End Sub
        
        Public Sub RemovetblfpRow(ByVal row As tblfpRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblfpRow
        Inherits DataRow
        
        Private tabletblfp As tblfpDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tabletblfp = CType(Me.Table,tblfpDataTable)
        End Sub
        
        Public Property aa As Integer
            Get
                Return CType(Me(Me.tabletblfp.aaColumn),Integer)
            End Get
            Set
                Me(Me.tabletblfp.aaColumn) = value
            End Set
        End Property
        
        Public Property fp As String
            Get
                Try 
                    Return CType(Me(Me.tabletblfp.fpColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tabletblfp.fpColumn) = value
            End Set
        End Property
        
        Public Function IsfpNull() As Boolean
            Return Me.IsNull(Me.tabletblfp.fpColumn)
        End Function
        
        Public Sub SetfpNull()
            Me(Me.tabletblfp.fpColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class tblfpRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As tblfpRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As tblfpRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As tblfpRow
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
