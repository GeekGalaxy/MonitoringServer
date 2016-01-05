﻿Imports MonitoringDatabase
Partial Class Events_MyEvents
    Inherits System.Web.UI.Page

    Private Property db As New DBModel

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        BuildTable()

    End Sub


    Private Sub BuildTable()

        'Add Paging for past 1000 Events

        Dim Q = (From T1 In db.AgentEvents
                 Join T2 In db.Subscriptions On T1.AgentName Equals T2.AgentName
                 Where T2.UserName = User.Identity.Name And T1.AgentStatus = True
                 Order By T1.AgentEventDate Descending
                 Select T1).Take(1000)


        Dim Table As New LiteralControl("<table class='HoverTable'><thead><tr><th></th><th>Date</th><th>Severity</th><th>Hostname</th><th>Class</th><th>Message</th></tr></thead>")
        Dim Severity As String = Nothing
        EventPlaceHolder.Controls.Clear()
        EventPlaceHolder.Controls.Add(Table)

        Dim EventRows As String = Nothing

        If Q IsNot Nothing Then
            For Each i In Q
                If i.AgentSeverity = 3 Then
                    Severity = "Critical"
                    EventRows = EventRows & "<tr><td><div class='EventStatusCritical'></div></td><td>" & i.AgentEventDate & "</td><td>" & Severity & "</td><td><a href='../Devices/Device.aspx?hostname=" & i.AgentName & "'>" & i.AgentName & "</a></td><td>" & i.AgentClass & "</td><td>" & i.AgentMessage.Replace(">", "&gt; ").Replace("<", "&lt;") & "</td></tr>"
                ElseIf i.AgentSeverity = 2 Then
                    Severity = "Major"
                    EventRows = EventRows & "<tr><td><div class='EventStatusMajor'></div></td><td>" & i.AgentEventDate & "</td><td>" & Severity & "</td><td><a href='../Devices/Device.aspx?hostname=" & i.AgentName & "'>" & i.AgentName & "</a></td><td>" & i.AgentClass & "</td><td>" & i.AgentMessage.Replace(">", "&gt; ").Replace("<", "&lt;") & "</td></tr>"
                ElseIf i.AgentSeverity = 1 Then
                    Severity = "Minor"
                    EventRows = EventRows & "<tr><td><div class='EventStatusMinor'></div></td><td>" & i.AgentEventDate & "</td><td>" & Severity & "</td><td><a href='../Devices/Device.aspx?hostname=" & i.AgentName & "'>" & i.AgentName & "</a></td><td>" & i.AgentClass & "</td><td>" & i.AgentMessage.Replace(">", "&gt; ").Replace("<", "&lt;") & "</td></tr>"
                End If
            Next
        End If
        If EventRows = "" Then
            EventRows = "<tr><td colspan='6' style='text-align:center'>No Events</td></tr>"
        End If

        Dim Row As New LiteralControl(EventRows)
        EventPlaceHolder.Controls.Add(Row)

        Dim EndTable As New LiteralControl("</Table>")
        EventPlaceHolder.Controls.Add(EndTable)
    End Sub

    Protected Sub EventsTimer_Tick(sender As Object, e As EventArgs) Handles EventsTimer.Tick
        BuildTable()
    End Sub
End Class