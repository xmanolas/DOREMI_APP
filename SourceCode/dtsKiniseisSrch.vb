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
Public Class dtsKiniseisSrch
    Inherits DataSet
    
    Private tableΚινήσεις As ΚινήσειςDataTable
    
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
            If (Not (ds.Tables("Κινήσεις")) Is Nothing) Then
                Me.Tables.Add(New ΚινήσειςDataTable(ds.Tables("Κινήσεις")))
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
    Public ReadOnly Property Κινήσεις As ΚινήσειςDataTable
        Get
            Return Me.tableΚινήσεις
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dtsKiniseisSrch = CType(MyBase.Clone,dtsKiniseisSrch)
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
        If (Not (ds.Tables("Κινήσεις")) Is Nothing) Then
            Me.Tables.Add(New ΚινήσειςDataTable(ds.Tables("Κινήσεις")))
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
        Me.tableΚινήσεις = CType(Me.Tables("Κινήσεις"),ΚινήσειςDataTable)
        If (Not (Me.tableΚινήσεις) Is Nothing) Then
            Me.tableΚινήσεις.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dtsKiniseisSrch"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dtsKiniseisSrch.xsd"
        Me.Locale = New System.Globalization.CultureInfo("el-GR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableΚινήσεις = New ΚινήσειςDataTable
        Me.Tables.Add(Me.tableΚινήσεις)
    End Sub
    
    Private Function ShouldSerializeΚινήσεις() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ΚινήσειςRowChangeEventHandler(ByVal sender As Object, ByVal e As ΚινήσειςRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΚινήσειςDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnISBN As DataColumn
        
        Private columnαρίθμησηεγγραφών As DataColumn
        
        Private columnΑΦΜ As DataColumn
        
        Private columnΔιεύθυνση As DataColumn
        
        Private columnΔΟΥ As DataColumn
        
        Private columnΈκδοση As DataColumn
        
        Private columnΕπάγγελμα As DataColumn
        
        Private columnΕπώνυμο As DataColumn
        
        Private columnΗμερομηνία As DataColumn
        
        Private columnΚινητό As DataColumn
        
        Private columnΚωδικός_Βιβλίου As DataColumn
        
        Private columnΌνομα As DataColumn
        
        Private columnΌργανο As DataColumn
        
        Private columnΠοσότητα As DataColumn
        
        Private columnΣυγγραφέας As DataColumn
        
        Private columnΣυνθέτης As DataColumn
        
        Private columnΤηλέφωνο As DataColumn
        
        Private columnΤιμή_Προσφοράς As DataColumn
        
        Private columnΤίτλος_Βιβλίου As DataColumn
        
        Friend Sub New()
            MyBase.New("Κινήσεις")
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
        
        Friend ReadOnly Property ISBNColumn As DataColumn
            Get
                Return Me.columnISBN
            End Get
        End Property
        
        Friend ReadOnly Property αρίθμησηεγγραφώνColumn As DataColumn
            Get
                Return Me.columnαρίθμησηεγγραφών
            End Get
        End Property
        
        Friend ReadOnly Property ΑΦΜColumn As DataColumn
            Get
                Return Me.columnΑΦΜ
            End Get
        End Property
        
        Friend ReadOnly Property ΔιεύθυνσηColumn As DataColumn
            Get
                Return Me.columnΔιεύθυνση
            End Get
        End Property
        
        Friend ReadOnly Property ΔΟΥColumn As DataColumn
            Get
                Return Me.columnΔΟΥ
            End Get
        End Property
        
        Friend ReadOnly Property ΈκδοσηColumn As DataColumn
            Get
                Return Me.columnΈκδοση
            End Get
        End Property
        
        Friend ReadOnly Property ΕπάγγελμαColumn As DataColumn
            Get
                Return Me.columnΕπάγγελμα
            End Get
        End Property
        
        Friend ReadOnly Property ΕπώνυμοColumn As DataColumn
            Get
                Return Me.columnΕπώνυμο
            End Get
        End Property
        
        Friend ReadOnly Property ΗμερομηνίαColumn As DataColumn
            Get
                Return Me.columnΗμερομηνία
            End Get
        End Property
        
        Friend ReadOnly Property ΚινητόColumn As DataColumn
            Get
                Return Me.columnΚινητό
            End Get
        End Property
        
        Friend ReadOnly Property Κωδικός_ΒιβλίουColumn As DataColumn
            Get
                Return Me.columnΚωδικός_Βιβλίου
            End Get
        End Property
        
        Friend ReadOnly Property ΌνομαColumn As DataColumn
            Get
                Return Me.columnΌνομα
            End Get
        End Property
        
        Friend ReadOnly Property ΌργανοColumn As DataColumn
            Get
                Return Me.columnΌργανο
            End Get
        End Property
        
        Friend ReadOnly Property ΠοσότηταColumn As DataColumn
            Get
                Return Me.columnΠοσότητα
            End Get
        End Property
        
        Friend ReadOnly Property ΣυγγραφέαςColumn As DataColumn
            Get
                Return Me.columnΣυγγραφέας
            End Get
        End Property
        
        Friend ReadOnly Property ΣυνθέτηςColumn As DataColumn
            Get
                Return Me.columnΣυνθέτης
            End Get
        End Property
        
        Friend ReadOnly Property ΤηλέφωνοColumn As DataColumn
            Get
                Return Me.columnΤηλέφωνο
            End Get
        End Property
        
        Friend ReadOnly Property Τιμή_ΠροσφοράςColumn As DataColumn
            Get
                Return Me.columnΤιμή_Προσφοράς
            End Get
        End Property
        
        Friend ReadOnly Property Τίτλος_ΒιβλίουColumn As DataColumn
            Get
                Return Me.columnΤίτλος_Βιβλίου
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ΚινήσειςRow
            Get
                Return CType(Me.Rows(index),ΚινήσειςRow)
            End Get
        End Property
        
        Public Event ΚινήσειςRowChanged As ΚινήσειςRowChangeEventHandler
        
        Public Event ΚινήσειςRowChanging As ΚινήσειςRowChangeEventHandler
        
        Public Event ΚινήσειςRowDeleted As ΚινήσειςRowChangeEventHandler
        
        Public Event ΚινήσειςRowDeleting As ΚινήσειςRowChangeEventHandler
        
        Public Overloads Sub AddΚινήσειςRow(ByVal row As ΚινήσειςRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddΚινήσειςRow( _
                    ByVal ISBN As String,  _
                    ByVal ΑΦΜ As String,  _
                    ByVal Διεύθυνση As String,  _
                    ByVal ΔΟΥ As String,  _
                    ByVal Έκδοση As String,  _
                    ByVal Επάγγελμα As String,  _
                    ByVal Επώνυμο As String,  _
                    ByVal Ημερομηνία As Date,  _
                    ByVal Κινητό As String,  _
                    ByVal Κωδικός_Βιβλίου As String,  _
                    ByVal Όνομα As String,  _
                    ByVal Όργανο As String,  _
                    ByVal Ποσότητα As Integer,  _
                    ByVal Συγγραφέας As String,  _
                    ByVal Συνθέτης As String,  _
                    ByVal Τηλέφωνο As String,  _
                    ByVal Τιμή_Προσφοράς As Single,  _
                    ByVal Τίτλος_Βιβλίου As String) As ΚινήσειςRow
            Dim rowΚινήσειςRow As ΚινήσειςRow = CType(Me.NewRow,ΚινήσειςRow)
            rowΚινήσειςRow.ItemArray = New Object() {ISBN, Nothing, ΑΦΜ, Διεύθυνση, ΔΟΥ, Έκδοση, Επάγγελμα, Επώνυμο, Ημερομηνία, Κινητό, Κωδικός_Βιβλίου, Όνομα, Όργανο, Ποσότητα, Συγγραφέας, Συνθέτης, Τηλέφωνο, Τιμή_Προσφοράς, Τίτλος_Βιβλίου}
            Me.Rows.Add(rowΚινήσειςRow)
            Return rowΚινήσειςRow
        End Function
        
        Public Function FindByαρίθμησηεγγραφών(ByVal αρίθμησηεγγραφών As Integer) As ΚινήσειςRow
            Return CType(Me.Rows.Find(New Object() {αρίθμησηεγγραφών}),ΚινήσειςRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ΚινήσειςDataTable = CType(MyBase.Clone,ΚινήσειςDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ΚινήσειςDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnISBN = Me.Columns("ISBN")
            Me.columnαρίθμησηεγγραφών = Me.Columns("αρίθμησηεγγραφών")
            Me.columnΑΦΜ = Me.Columns("ΑΦΜ")
            Me.columnΔιεύθυνση = Me.Columns("Διεύθυνση")
            Me.columnΔΟΥ = Me.Columns("ΔΟΥ")
            Me.columnΈκδοση = Me.Columns("Έκδοση")
            Me.columnΕπάγγελμα = Me.Columns("Επάγγελμα")
            Me.columnΕπώνυμο = Me.Columns("Επώνυμο")
            Me.columnΗμερομηνία = Me.Columns("Ημερομηνία")
            Me.columnΚινητό = Me.Columns("Κινητό")
            Me.columnΚωδικός_Βιβλίου = Me.Columns("Κωδικός Βιβλίου")
            Me.columnΌνομα = Me.Columns("Όνομα")
            Me.columnΌργανο = Me.Columns("Όργανο")
            Me.columnΠοσότητα = Me.Columns("Ποσότητα")
            Me.columnΣυγγραφέας = Me.Columns("Συγγραφέας")
            Me.columnΣυνθέτης = Me.Columns("Συνθέτης")
            Me.columnΤηλέφωνο = Me.Columns("Τηλέφωνο")
            Me.columnΤιμή_Προσφοράς = Me.Columns("Τιμή Προσφοράς")
            Me.columnΤίτλος_Βιβλίου = Me.Columns("Τίτλος Βιβλίου")
        End Sub
        
        Private Sub InitClass()
            Me.columnISBN = New DataColumn("ISBN", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnISBN)
            Me.columnαρίθμησηεγγραφών = New DataColumn("αρίθμησηεγγραφών", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnαρίθμησηεγγραφών)
            Me.columnΑΦΜ = New DataColumn("ΑΦΜ", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΑΦΜ)
            Me.columnΔιεύθυνση = New DataColumn("Διεύθυνση", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΔιεύθυνση)
            Me.columnΔΟΥ = New DataColumn("ΔΟΥ", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΔΟΥ)
            Me.columnΈκδοση = New DataColumn("Έκδοση", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΈκδοση)
            Me.columnΕπάγγελμα = New DataColumn("Επάγγελμα", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΕπάγγελμα)
            Me.columnΕπώνυμο = New DataColumn("Επώνυμο", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΕπώνυμο)
            Me.columnΗμερομηνία = New DataColumn("Ημερομηνία", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΗμερομηνία)
            Me.columnΚινητό = New DataColumn("Κινητό", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΚινητό)
            Me.columnΚωδικός_Βιβλίου = New DataColumn("Κωδικός Βιβλίου", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΚωδικός_Βιβλίου)
            Me.columnΌνομα = New DataColumn("Όνομα", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΌνομα)
            Me.columnΌργανο = New DataColumn("Όργανο", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΌργανο)
            Me.columnΠοσότητα = New DataColumn("Ποσότητα", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΠοσότητα)
            Me.columnΣυγγραφέας = New DataColumn("Συγγραφέας", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΣυγγραφέας)
            Me.columnΣυνθέτης = New DataColumn("Συνθέτης", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΣυνθέτης)
            Me.columnΤηλέφωνο = New DataColumn("Τηλέφωνο", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤηλέφωνο)
            Me.columnΤιμή_Προσφοράς = New DataColumn("Τιμή Προσφοράς", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤιμή_Προσφοράς)
            Me.columnΤίτλος_Βιβλίου = New DataColumn("Τίτλος Βιβλίου", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnΤίτλος_Βιβλίου)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnαρίθμησηεγγραφών}, true))
            Me.columnαρίθμησηεγγραφών.AutoIncrement = true
            Me.columnαρίθμησηεγγραφών.AllowDBNull = false
            Me.columnαρίθμησηεγγραφών.Unique = true
        End Sub
        
        Public Function NewΚινήσειςRow() As ΚινήσειςRow
            Return CType(Me.NewRow,ΚινήσειςRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ΚινήσειςRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ΚινήσειςRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ΚινήσειςRowChangedEvent) Is Nothing) Then
                RaiseEvent ΚινήσειςRowChanged(Me, New ΚινήσειςRowChangeEvent(CType(e.Row,ΚινήσειςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ΚινήσειςRowChangingEvent) Is Nothing) Then
                RaiseEvent ΚινήσειςRowChanging(Me, New ΚινήσειςRowChangeEvent(CType(e.Row,ΚινήσειςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ΚινήσειςRowDeletedEvent) Is Nothing) Then
                RaiseEvent ΚινήσειςRowDeleted(Me, New ΚινήσειςRowChangeEvent(CType(e.Row,ΚινήσειςRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ΚινήσειςRowDeletingEvent) Is Nothing) Then
                RaiseEvent ΚινήσειςRowDeleting(Me, New ΚινήσειςRowChangeEvent(CType(e.Row,ΚινήσειςRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveΚινήσειςRow(ByVal row As ΚινήσειςRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΚινήσειςRow
        Inherits DataRow
        
        Private tableΚινήσεις As ΚινήσειςDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableΚινήσεις = CType(Me.Table,ΚινήσειςDataTable)
        End Sub
        
        Public Property ISBN As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ISBNColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ISBNColumn) = value
            End Set
        End Property
        
        Public Property αρίθμησηεγγραφών As Integer
            Get
                Return CType(Me(Me.tableΚινήσεις.αρίθμησηεγγραφώνColumn),Integer)
            End Get
            Set
                Me(Me.tableΚινήσεις.αρίθμησηεγγραφώνColumn) = value
            End Set
        End Property
        
        Public Property ΑΦΜ As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΑΦΜColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΑΦΜColumn) = value
            End Set
        End Property
        
        Public Property Διεύθυνση As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΔιεύθυνσηColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΔιεύθυνσηColumn) = value
            End Set
        End Property
        
        Public Property ΔΟΥ As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΔΟΥColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΔΟΥColumn) = value
            End Set
        End Property
        
        Public Property Έκδοση As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΈκδοσηColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΈκδοσηColumn) = value
            End Set
        End Property
        
        Public Property Επάγγελμα As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΕπάγγελμαColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΕπάγγελμαColumn) = value
            End Set
        End Property
        
        Public Property Επώνυμο As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΕπώνυμοColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΕπώνυμοColumn) = value
            End Set
        End Property
        
        Public Property Ημερομηνία As Date
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΗμερομηνίαColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΗμερομηνίαColumn) = value
            End Set
        End Property
        
        Public Property Κινητό As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΚινητόColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΚινητόColumn) = value
            End Set
        End Property
        
        Public Property Κωδικός_Βιβλίου As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.Κωδικός_ΒιβλίουColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.Κωδικός_ΒιβλίουColumn) = value
            End Set
        End Property
        
        Public Property Όνομα As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΌνομαColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΌνομαColumn) = value
            End Set
        End Property
        
        Public Property Όργανο As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΌργανοColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΌργανοColumn) = value
            End Set
        End Property
        
        Public Property Ποσότητα As Integer
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΠοσότηταColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΠοσότηταColumn) = value
            End Set
        End Property
        
        Public Property Συγγραφέας As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΣυγγραφέαςColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΣυγγραφέαςColumn) = value
            End Set
        End Property
        
        Public Property Συνθέτης As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΣυνθέτηςColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΣυνθέτηςColumn) = value
            End Set
        End Property
        
        Public Property Τηλέφωνο As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.ΤηλέφωνοColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.ΤηλέφωνοColumn) = value
            End Set
        End Property
        
        Public Property Τιμή_Προσφοράς As Single
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.Τιμή_ΠροσφοράςColumn),Single)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.Τιμή_ΠροσφοράςColumn) = value
            End Set
        End Property
        
        Public Property Τίτλος_Βιβλίου As String
            Get
                Try 
                    Return CType(Me(Me.tableΚινήσεις.Τίτλος_ΒιβλίουColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableΚινήσεις.Τίτλος_ΒιβλίουColumn) = value
            End Set
        End Property
        
        Public Function IsISBNNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ISBNColumn)
        End Function
        
        Public Sub SetISBNNull()
            Me(Me.tableΚινήσεις.ISBNColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΑΦΜNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΑΦΜColumn)
        End Function
        
        Public Sub SetΑΦΜNull()
            Me(Me.tableΚινήσεις.ΑΦΜColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΔιεύθυνσηNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΔιεύθυνσηColumn)
        End Function
        
        Public Sub SetΔιεύθυνσηNull()
            Me(Me.tableΚινήσεις.ΔιεύθυνσηColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΔΟΥNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΔΟΥColumn)
        End Function
        
        Public Sub SetΔΟΥNull()
            Me(Me.tableΚινήσεις.ΔΟΥColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΈκδοσηNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΈκδοσηColumn)
        End Function
        
        Public Sub SetΈκδοσηNull()
            Me(Me.tableΚινήσεις.ΈκδοσηColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΕπάγγελμαNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΕπάγγελμαColumn)
        End Function
        
        Public Sub SetΕπάγγελμαNull()
            Me(Me.tableΚινήσεις.ΕπάγγελμαColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΕπώνυμοNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΕπώνυμοColumn)
        End Function
        
        Public Sub SetΕπώνυμοNull()
            Me(Me.tableΚινήσεις.ΕπώνυμοColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΗμερομηνίαNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΗμερομηνίαColumn)
        End Function
        
        Public Sub SetΗμερομηνίαNull()
            Me(Me.tableΚινήσεις.ΗμερομηνίαColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΚινητόNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΚινητόColumn)
        End Function
        
        Public Sub SetΚινητόNull()
            Me(Me.tableΚινήσεις.ΚινητόColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΚωδικός_ΒιβλίουNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.Κωδικός_ΒιβλίουColumn)
        End Function
        
        Public Sub SetΚωδικός_ΒιβλίουNull()
            Me(Me.tableΚινήσεις.Κωδικός_ΒιβλίουColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΌνομαNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΌνομαColumn)
        End Function
        
        Public Sub SetΌνομαNull()
            Me(Me.tableΚινήσεις.ΌνομαColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΌργανοNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΌργανοColumn)
        End Function
        
        Public Sub SetΌργανοNull()
            Me(Me.tableΚινήσεις.ΌργανοColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΠοσότηταNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΠοσότηταColumn)
        End Function
        
        Public Sub SetΠοσότηταNull()
            Me(Me.tableΚινήσεις.ΠοσότηταColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΣυγγραφέαςNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΣυγγραφέαςColumn)
        End Function
        
        Public Sub SetΣυγγραφέαςNull()
            Me(Me.tableΚινήσεις.ΣυγγραφέαςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΣυνθέτηςNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΣυνθέτηςColumn)
        End Function
        
        Public Sub SetΣυνθέτηςNull()
            Me(Me.tableΚινήσεις.ΣυνθέτηςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤηλέφωνοNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.ΤηλέφωνοColumn)
        End Function
        
        Public Sub SetΤηλέφωνοNull()
            Me(Me.tableΚινήσεις.ΤηλέφωνοColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤιμή_ΠροσφοράςNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.Τιμή_ΠροσφοράςColumn)
        End Function
        
        Public Sub SetΤιμή_ΠροσφοράςNull()
            Me(Me.tableΚινήσεις.Τιμή_ΠροσφοράςColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsΤίτλος_ΒιβλίουNull() As Boolean
            Return Me.IsNull(Me.tableΚινήσεις.Τίτλος_ΒιβλίουColumn)
        End Function
        
        Public Sub SetΤίτλος_ΒιβλίουNull()
            Me(Me.tableΚινήσεις.Τίτλος_ΒιβλίουColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ΚινήσειςRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ΚινήσειςRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ΚινήσειςRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ΚινήσειςRow
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
