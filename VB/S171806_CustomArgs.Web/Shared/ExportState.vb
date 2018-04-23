Imports Microsoft.VisualBasic
Imports System.Runtime.Serialization

Namespace S171806_CustomArgs
	<DataContract> _
	Public Class ExportState
		Private privateFileName As String
		<DataMember> _
		Public Property FileName() As String
			Get
				Return privateFileName
			End Get
			Set(ByVal value As String)
				privateFileName = value
			End Set
		End Property
	End Class
End Namespace