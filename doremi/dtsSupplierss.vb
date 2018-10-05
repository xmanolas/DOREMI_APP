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
Public Class dtsSupplierss
    Inherits DataSet
    
    Private tableΠρομηθευτές As ΠρομηθευτέςDataTable
    
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
            If (Not (ds.Tables("Προμηθευτές")) Is Nothing) Then
                Me.Tables.Add(New ΠρομηθευτέςDataTable(ds.Tables("Προμηθευτές")))
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
    Public ReadOnly Property Προμηθευτές As ΠρομηθευτέςDataTable
        Get
            Return Me.tableΠρομηθευτές
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dtsSupplierss = CType(MyBase.Clone,dtsSupplierss)
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
        If (Not (ds.Tables("Προμηθευτές")) Is Nothing) Then
            Me.Tables.Add(New ΠρομηθευτέςDataTable(ds.Tables("Προμηθευτές")))
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
        Me.tableΠρομηθευτές = CType(Me.Tables("Προμηθευτές"),ΠρομηθευτέςDataTable)
        If (Not (Me.tableΠρομηθευτές) Is Nothing) Then
            Me.tableΠρομηθευτές.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dtsSupplierss"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dtsSupplierss.xsd"
        Me.Locale = New System.Globalization.CultureInfo("el-GR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableΠρομηθευτές = New ΠρομηθευτέςDataTable
        Me.Tables.Add(Me.tableΠρομηθευτές)
    End Sub
    
    Private Function ShouldSerializeΠρομηθευτές() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ΠρομηθευτέςRowChangeEventHandler(ByVal sender As Object, ByVal e As ΠρομηθευτέςRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΠρομηθευτέςDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnΑριθμόςΦαξ As DataColumn
        
        Private columnΔιεύθυνση As DataColumn
        
        Private columnΔιεύθυνσηEmail As DataColumn
        
        Private columnΚωδΠρομηθευτή As DataColumn
        
        Private column_Νομός_Περιοχή As DataColumn
        
        Private columnΠόλη As DataColumn
        
        Private columnΠρομηθευτής As DataColumn
        
        Private columnΣημειώσεις As DataColumn
        
        Private columnΤαχυδρομικόςΚώδικας As DataColumn
        
        Private columnΤηλέφωνο As DataColumn
        
        Private columnΤηλέφωνο1 As DataColumn
        
        Private column_Χώρα_Περιοχή As DataColumn
        
        Friend Sub New()
            MyBase.New("Προμηθευτές")
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
        
        Friend ReadOnly Property ΑριθμόςΦαξColumn As DataColumn
            Get
                Return Me.columnΑριθμόςΦαξ
            End Get
        End Property
        
        Friend ReadOnly Property ΔιεύθυνσηColumn As DataColumn
            Get
                Return Me.columnΔιεύθυνση
            End Get
        End Property
        
        Friend ReadOnly Property ΔιεύθυνσηEmailColumn As DataColumn
            Get
                Return Me.columnΔιεύθυνσηEmail
            End Get
        End Property
        
        Friend ReadOnly Property ΚωδΠρομηθευτήColumn As DataColumn
            Get
                Return Me.columnΚωδΠρομηθευτή
            End Get
        End Property
        
        Friend ReadOnly Property _Νομός_ΠεριοχήColumn As DataColumn
            Get
                Return Me.column_Νομός_Περιοχή
            End Get
        End Property
        
        Friend ReadOnly Property ΠόληColumn As DataColumn
            Get
                Return Me.columnΠόλη
            End Get
        End Property
        
        Friend ReadOnly Property ΠρομηθευτήςColumn As DataColumn
            Get
                Return Me.columnΠρομηθευτής
            End Get
        End Property
        
        Friend ReadOnly Property ΣημειώσειςColumn As DataColumn
            Get
                Return Me.columnΣημειώσεις
            End Get
        End Property
        
        Friend ReadOnly Property ΤαχυδρομικόςΚώδικαςColumn As DataColumn
            Get
                Return Me.columnΤαχυδρομικόςΚώδικας
            End Get
        End Property
        
        Friend ReadOnly Property ΤηλέφωνοColumn As DataColumn
            Get
                Return Me.columnΤηλέφωνο
            End Get
        End Property
        
        Friend ReadOnly Property Τηλέφωνο1Column As DataColumn
            Get
                Return Me.columnΤηλέφωνο1
            End Get
        End Property
        
        Friend ReadOnly Property _Χώρα_ΠεριοχήColumn As DataColumn
            Get
                Return Me.column_Χώρα_Περιοχή
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ΠρομηθευτέςRow
            Get
                Return CType(Me.Rows(index),ΠρομηθευτέςRow)
            End Get
        End Property
        
        Public Event ΠρομηθευτέςRowChanged As ΠρομηθευτέςRowChangeEventHandler
        
        Public Event ΠρομηθευτέςRowChanging As ΠρομηθευτέςRowChangeEventHandler
        
        Public Event ΠρομηθευτέςRowDeleted As ΠρομηθευτέςRowChangeEventHandler
        
        Public Event ΠρομηθευτέςRowDeleting As ΠρομηθευτέςRowChangeEventHandler
        
        Public Overloads Sub AddΠρομηθευτέςRow(ByVal row As ΠρομηθευτέςRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddΠρομηθευτέςRow(ByVal ΑριθμόςΦαξ As String, ByVal Διεύθυνση As String, ByVal ΔιεύθυνσηEmail As String, ByVal ΚωδΠρομηθευτή As String, ByVal _Νομός_Περιοχή As String, ByVal Πόλη As String, ByVal Προμηθευτής As String, ByVal Σημειώσεις As String, ByVal ΤαχυδρομικόςΚώδικας As String, ByVal Τηλέφωνο As String, ByVal Τηλέφωνο1 As String, ByVal _Χώρα_Περιοχή As String) As ΠρομηθευτέςRow
            Dim rowΠρομηθευτέςRow As ΠρομηθευτέςRow = CType(Me.NewRow,ΠρομηθευτέςRow)
            rowΠρομηθευτέςRow.ItemArray = New Object() {ΑριθμόςΦαξ, Διεύθυνση, ΔιεύθυνσηEmail, ΚωδΠρομηθευτή, _Νομός_Περιοχή, Πόλη, Προμηθευτής, Σημειώσεις, ΤαχυδρομικόςΚώδικας, Τηλέφωνο, Τηλέφωνο1, _Χώρα_Περιοχή}
            Me.Rows.Add(rowΠρομηθευτέςRow)
            Return rowΠρομηθευτέςRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ΠρομηθευτέςDataTable = CType(MyBase.Clone,ΠρομηθευτέςDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ΠρομηθευτέςDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnΑριθμόςΦαξ = Me.Columns("ΑριθμόςΦαξ")
            Me.columnΔιεύθυνση = Me.Columns("Διεύθυνση")
            Me.columnΔιεύθυνσηEmail = Me.Columns("ΔιεύθυνσηEmail")
            Me.columnΚωδΠρομηθευτή = Me.Columns("ΚωδΠρομηθευτή")
            Me.column_Νομός_Περιοχή = Me.Columns("Νομός/Περιοχή")
            Me.columnΠόλη = Me.Columns("Πόλη")
            Me.columnΠρομηθευτής = Me.Columns("Προμηθευτής")
            Me.columnΣημειώσεις = Me.Columns("Σημειώσεις")
            Me.columnΤαχυδρομικόςΚώδικας = Me.Columns("ΤαχυδρομικόςΚώδικας")
            Me.columnΤηλέφωνο = Me.Columns("Τηλέφωνο")
            Me.columnΤηλέφωνο1 = Me.Columns("Τηλέφωνο1")
            Me.column_Χώρα_Περιοχή = Me.Columns("Χώρα/Περιοχή")
        End Sub
        
        Private Sub InitClass()
            Me.columnΑριθμόςΦαξ = New DataColumn("ΑριθμόςΦαξ", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΑριθμόςΦαξ)
            Me.columnΔιεύθυνση = New DataColumn("Διεύθυνση", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΔιεύθυνση)
            Me.columnΔιεύθυνσηEmail = New DataColumn("ΔιεύθυνσηEmail", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΔιεύθυνσηEmail)
            Me.columnΚωδΠρομηθευτή = New DataColumn("ΚωδΠρομηθευτή", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΚωδΠρομηθευτή)
            Me.column_Νομός_Περιοχή = New DataColumn("Νομός/Περιοχή", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Νομός_Περιοχή)
            Me.columnΠόλη = New DataColumn("Πόλη", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΠόλη)
            Me.columnΠρομηθευτής = New DataColumn("Προμηθευτής", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΠρομηθευτής)
            Me.columnΣημειώσεις = New DataColumn("Σημειώσεις", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΣημειώσεις)
            Me.columnΤαχυδρομικόςΚώδικας = New DataColumn("ΤαχυδρομικόςΚώδικας", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤαχυδρομικόςΚώδικας)
            Me.columnΤηλέφωνο = New DataColumn("Τηλέφωνο", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤηλέφωνο)
            Me.columnΤηλέφωνο1 = New DataColumn("Τηλέφωνο1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤηλέφωνο1)
            Me.column_Χώρα_Περιοχή = New DataColumn("Χώρα/Περιοχή", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Χώρα_Περιοχή)
        End Sub
        
        Public Function NewΠρομηθευτέςRow() As ΠρομηθευτέςRow
            Return CType(Me.NewRow,ΠρομηθευτέςRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ΠρομηθευτέςRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ΠρομηθευτέςRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ΠρομηθευτέςRowChangedEvent) Is Nothing) Then
                RaiseEvent ΠρομηθευτέςRowChanged(Me, New ΠρομηθευτέςRowChangeEvent(CType(e.Row,ΠρομηθευτέςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ΠρομηθευτέςRowChangingEvent) Is Nothing) Then
                RaiseEvent ΠρομηθευτέςRowChanging(Me, New ΠρομηθευτέςRowChangeEvent(CType(e.Row,ΠρομηθευτέςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ΠρομηθευτέςRowDeletedEvent) Is Nothing) Then
                RaiseEvent ΠρομηθευτέςRowDeleted(Me, New ΠρομηθευτέςRowChangeEvent(CType(e.Row,ΠρομηθευτέςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ΠρομηθευτέςRowDeletingEvent) Is Nothing) Then
                RaiseEvent ΠρομηθευτέςRowDeleting(Me, New ΠρομηθευτέςRowChangeEvent(CType(e.Row,ΠρομηθευτέςRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveΠρομηθευτέςRow(ByVal row As ΠρομηθευτέςRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΠρομηθευτέςRow
        Inherits DataRow
        
        Private tableΠρομηθευτές As ΠρομηθευτέςDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableΠρομηθευτές = CType(Me.Table,ΠρομηθευτέςDataTable)
        End Sub
        
        Public Property ΑριθμόςΦαξ As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΑριθμόςΦαξColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΑριθμόςΦαξColumn) = value
            End Set
        End Property
        
        Public Property Διεύθυνση As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΔιεύθυνσηColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΔιεύθυνσηColumn) = value
            End Set
        End Property
        
        Public Property ΔιεύθυνσηEmail As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΔιεύθυνσηEmailColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΔιεύθυνσηEmailColumn) = value
            End Set
        End Property
        
        Public Property ΚωδΠρομηθευτή As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΚωδΠρομηθευτήColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΚωδΠρομηθευτήColumn) = value
            End Set
        End Property
        
        Public Property _Νομός_Περιοχή As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές._Νομός_ΠεριοχήColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές._Νομός_ΠεριοχήColumn) = value
            End Set
        End Property
        
        Public Property Πόλη As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΠόληColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΠόληColumn) = value
            End Set
        End Property
        
        Public Property Προμηθευτής As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΠρομηθευτήςColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΠρομηθευτήςColumn) = value
            End Set
        End Property
        
        Public Property Σημειώσεις As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΣημειώσειςColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΣημειώσειςColumn) = value
            End Set
        End Property
        
        Public Property ΤαχυδρομικόςΚώδικας As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΤαχυδρομικόςΚώδικαςColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΤαχυδρομικόςΚώδικαςColumn) = value
            End Set
        End Property
        
        Public Property Τηλέφωνο As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.ΤηλέφωνοColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.ΤηλέφωνοColumn) = value
            End Set
        End Property
        
        Public Property Τηλέφωνο1 As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές.Τηλέφωνο1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές.Τηλέφωνο1Column) = value
            End Set
        End Property
        
        Public Property _Χώρα_Περιοχή As String
            Get
                Try 
                    Return CType(Me(Me.tableΠρομηθευτές._Χώρα_ΠεριοχήColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΠρομηθευτές._Χώρα_ΠεριοχήColumn) = value
            End Set
        End Property
        
        Public Function IsΑριθμόςΦαξNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΑριθμόςΦαξColumn)
        End Function
        
        Public Sub SetΑριθμόςΦαξNull()
            Me(Me.tableΠρομηθευτές.ΑριθμόςΦαξColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΔιεύθυνσηNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΔιεύθυνσηColumn)
        End Function
        
        Public Sub SetΔιεύθυνσηNull()
            Me(Me.tableΠρομηθευτές.ΔιεύθυνσηColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΔιεύθυνσηEmailNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΔιεύθυνσηEmailColumn)
        End Function
        
        Public Sub SetΔιεύθυνσηEmailNull()
            Me(Me.tableΠρομηθευτές.ΔιεύθυνσηEmailColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΚωδΠρομηθευτήNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΚωδΠρομηθευτήColumn)
        End Function
        
        Public Sub SetΚωδΠρομηθευτήNull()
            Me(Me.tableΠρομηθευτές.ΚωδΠρομηθευτήColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_Νομός_ΠεριοχήNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές._Νομός_ΠεριοχήColumn)
        End Function
        
        Public Sub Set_Νομός_ΠεριοχήNull()
            Me(Me.tableΠρομηθευτές._Νομός_ΠεριοχήColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΠόληNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΠόληColumn)
        End Function
        
        Public Sub SetΠόληNull()
            Me(Me.tableΠρομηθευτές.ΠόληColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΠρομηθευτήςNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΠρομηθευτήςColumn)
        End Function
        
        Public Sub SetΠρομηθευτήςNull()
            Me(Me.tableΠρομηθευτές.ΠρομηθευτήςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΣημειώσειςNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΣημειώσειςColumn)
        End Function
        
        Public Sub SetΣημειώσειςNull()
            Me(Me.tableΠρομηθευτές.ΣημειώσειςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤαχυδρομικόςΚώδικαςNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΤαχυδρομικόςΚώδικαςColumn)
        End Function
        
        Public Sub SetΤαχυδρομικόςΚώδικαςNull()
            Me(Me.tableΠρομηθευτές.ΤαχυδρομικόςΚώδικαςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤηλέφωνοNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.ΤηλέφωνοColumn)
        End Function
        
        Public Sub SetΤηλέφωνοNull()
            Me(Me.tableΠρομηθευτές.ΤηλέφωνοColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤηλέφωνο1Null() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές.Τηλέφωνο1Column)
        End Function
        
        Public Sub SetΤηλέφωνο1Null()
            Me(Me.tableΠρομηθευτές.Τηλέφωνο1Column) = System.Convert.DBNull
        End Sub
        
        Public Function Is_Χώρα_ΠεριοχήNull() As Boolean
            Return Me.IsNull(Me.tableΠρομηθευτές._Χώρα_ΠεριοχήColumn)
        End Function
        
        Public Sub Set_Χώρα_ΠεριοχήNull()
            Me(Me.tableΠρομηθευτές._Χώρα_ΠεριοχήColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΠρομηθευτέςRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ΠρομηθευτέςRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ΠρομηθευτέςRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ΠρομηθευτέςRow
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