﻿Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim astPeople(4, 5) As String
        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Vincent"
        astPeople(1, 4) = "van Gogh"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Dutch"
        astPeople(4, 4) = "Artist"

        astPeople(0, 5) = "Mahatma"
        astPeople(1, 5) = "Ganghi"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Indian"
        astPeople(4, 5) = "Lawyer"

        For x = 0 To 4
            MsgBox((astPeople(3, 4)))
        Next
    End Sub
End Class
