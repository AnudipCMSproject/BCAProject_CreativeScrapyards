﻿Public Class creativeview3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Label1.Text & "650Rs"
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim count As Integer = 0
        count = count + 1
        For count = 0 To count Step 1
            If (IsPostBack) Then
                If count = 1 Then
                    Image1.ImageUrl = "~/image/IMG6.jpg"
                    Label1.Text = "cost:500Rs"
                ElseIf Image1.ImageUrl = "~/image/IMG6.jpg" Then
                    Response.Redirect("\creative view form\creativeview4.aspx")
                End If

            End If

        Next
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim count As Integer = 0
        count = count + 1
        For count = 0 To count Step 1
            If (IsPostBack) Then
                If count = 1 Then
                    Image1.ImageUrl = "~/image/IMG5.jpg "
                    Label1.Text = "cost:650Rs"
                ElseIf Image1.ImageUrl = "~/image/IMG5.jpg" Then
                    Response.Redirect("\creative view form\creativeView2.aspx")
                End If
            End If

        Next
    End Sub
End Class