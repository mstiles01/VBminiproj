Imports System

Namespace RobbingBank
    Module Program
        Sub Main(args As String())
            Console.WriteLine("Plan Your Heist")
            Dim team As Dictionary(Of String, String) = New Dictionary(Of String, String)()

            Console.Write("Bank Difficulty> ")
            Dim bankDifficulty As Integer = Integer.Parse(Console.ReadLine())
            Console.WriteLine()
            Dim random As New Random()

            Console.Write("Name > ")
            Dim name = Console.ReadLine()


            Do Until (name = "")

                Console.Write("Skill Level> ")
                Dim skillLevel = Console.ReadLine

                Console.Write("Courage Factor > ")
                Dim courageFactor = Console.ReadLine()

                Dim member As Dictionary(Of String, String) = New Dictionary(Of String, String)()
                member("Name") = name
                member("SkillLevel") = skillLevel
                member("CourageFactor") = courageFactor



                Console.WriteLine("Name> ")
                name = Console.ReadLine()
            Loop






        End Sub
    End Module
End Namespace
