Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports System.Globalization
Imports System.Web
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Overrides Sub InitializeCulture()
		SetCulture()
		MyBase.InitializeCulture()
	End Sub

	Private Sub SetCulture()
		Dim c As HttpCookie = Request.Cookies("Lang")
		If c Is Nothing Then
			Return
		End If
		Dim langValue As String = c.Value
		If (Not String.IsNullOrEmpty(langValue)) Then

			Culture = langValue
			UICulture = langValue

			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(langValue)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(langValue)
		End If
	End Sub
	Protected Sub combo_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim c As HttpCookie = Request.Cookies("Lang")
		If c Is Nothing Then
			Return
		End If
		Dim cb As ASPxComboBox = (TryCast(sender, ASPxComboBox))
		cb.Value = c.Value

	End Sub
End Class
