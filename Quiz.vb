
Module Module1 
    'Made by Jamie Parsons.
 
    Dim choice, answer, score As Integer

    Sub Main()
        'Setting text to white
        Console.ForegroundColor = ConsoleColor.White

        'REM Welcome Screen
        Console.WriteLine("Welcome to the Fallout 4 Quiz! ")
        Console.WriteLine("Made by Jamie Parsons.")
        Console.WriteLine("Released in 2019")
        Console.WriteLine("Press enter key to continue ...")
        Console.ReadLine()
        Console.Clear()

        'REM Game loop starts
        While choice <> 3
            REM Menu appears on screen giving choices (1 instructions,
            REM 2 play, 3 exit)
            menu()
            REM Get choice from user from keyboard
            get_choice()
            REM do choice
            do_choice()
            Console.Clear()
        End While
        'REM Game loop ends
    End Sub

    Sub menu()
        Console.WriteLine("======================================== Fallout 4 QUIZ MENU ========================================")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("1. Instructions")
        Console.WriteLine("2. Play Quiz")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("3. Exit")
        Console.ForegroundColor = ConsoleColor.White
    End Sub

    Sub get_choice()
        Console.WriteLine("Choose option 1, 2 or 3 ")
        choice = Console.ReadLine()
    End Sub

    Sub do_choice()
        Console.WriteLine(choice)
        If (choice = 1) Then
            show_help()
        ElseIf (choice = 2) Then
            play_quiz()
        ElseIf (choice = 3) Then
            quit_quiz()
        Else
            Console.WriteLine("Incorrect value. Pick options 1, 2 or 3")
            Console.WriteLine("Press enter key to continue ...")
            Console.ReadLine()
        End If
    End Sub

    Sub show_help()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("======================================== Fallout 4 QUIZ HELP ========================================")
        Console.WriteLine("This quiz will consist of ten multiple choice questions.")
        Console.WriteLine("Each question will have four possible answers one of which will be correct.")
        Console.WriteLine("If you choose the correct answer your score will be updated.")
        Console.WriteLine("A message on screen will indicate whether you have chosen the correct answer and display your running score.")
        Console.WriteLine("The screen will clear before moving on to the next question.")
        Console.WriteLine("After you have completed the quiz you will be taken back to the menu.")
        Console.WriteLine("Press enter key to continue ...")
        Console.ReadLine()
    End Sub

    Sub play_quiz()

        ' Remove menu before start of quiz
        Console.Clear()

        ' Initialize user score
        score = 0
        Console.ForegroundColor = ConsoleColor.White

        'Question 1 Starts
        Console.WriteLine("======================================== QUESTION 1 ========================================")
        Console.WriteLine()
        Console.WriteLine("What is the Location you are in at the very start of Fallout 4? ")
        Console.WriteLine(" 1. Vault 111 ")
        Console.WriteLine(" 2. Sanctuary hills ")
        Console.WriteLine(" 3. Diamond city")
        Console.WriteLine(" 4. The Institute ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 2 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 1 Ends

        'Question 2 Starts
        Console.WriteLine("======================================== QUESTION 2 ========================================")
        Console.WriteLine()
        Console.WriteLine("Who is your fastest avaliable companion? ")
        Console.WriteLine(" 1. Valentine ")
        Console.WriteLine(" 2. Preston ")
        Console.WriteLine(" 3. Codsworth")
        Console.WriteLine(" 4. Dogmeat ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 4 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 2 Ends

        'Question 3 Starts
        Console.WriteLine("======================================== QUESTION 3 ========================================")
        Console.WriteLine()
        Console.WriteLine("What Faction is not in the game ? ")
        Console.WriteLine(" 1. Brother hood of steel ")
        Console.WriteLine(" 2. Minutemen ")
        Console.WriteLine(" 3. Crimson caravan ")
        Console.WriteLine(" 4. The Operators")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine

        If answer = 3 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 3 Ends

        'Question 4 Starts
        Console.WriteLine("======================================== QUESTION 4 ========================================")
        Console.WriteLine()
        Console.WriteLine("What is the silenced weapon you can obtain after doing your first mission with the railroad ? ")
        Console.WriteLine(" 1. Overseerers Guardian ")
        Console.WriteLine(" 2. The deliverer ")
        Console.WriteLine(" 3. Supressed 10mm Pistol ")
        Console.WriteLine(" 4. The railway rifle ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine

        If answer = 2 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 4 Ends

        'Question 5 Starts
        Console.WriteLine("======================================== QUESTION 5 ========================================")
        Console.WriteLine()
        Console.WriteLine(" What is the person's name that kidnapped your son at the beginning of the game ? ")
        Console.WriteLine(" 1. Steve ")
        Console.WriteLine(" 2. Shaun ")
        Console.WriteLine(" 3. Kellog ")
        Console.WriteLine(" 4. Hazel ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 3 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 5 Ends

        'Question 6 Starts
        Console.WriteLine("======================================== QUESTION 6 ========================================")
        Console.WriteLine()
        Console.WriteLine(" Which faction is companion Deacon in ? ")
        Console.WriteLine(" 1. Railroad ")
        Console.WriteLine(" 2. Institute ")
        Console.WriteLine(" 3. Minutemen ")
        Console.WriteLine(" 4. Brotherhood of steel ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 1 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 6 Ends

        'Question 7 Starts
        Console.WriteLine("======================================== QUESTION 7 ========================================")
        Console.WriteLine()
        Console.WriteLine(" Which Human Companion can join you in Goodneighbour ? ")
        Console.WriteLine(" 1. Hancock ")
        Console.WriteLine(" 2. Deacon ")
        Console.WriteLine(" 3. Valentine ")
        Console.WriteLine(" 4. Macreedy")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 4 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 7 Ends

        'Question 8 Starts
        Console.WriteLine("======================================== QUESTION 8 ========================================")
        Console.WriteLine()
        Console.WriteLine(" Which faction has a Airship ? ")
        Console.WriteLine(" 1. The NCR ")
        Console.WriteLine(" 2. The brotherhood of steel ")
        Console.WriteLine(" 3. Railroad ")
        Console.WriteLine(" 4. Institute")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 2 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 8 Ends

        'Question 9 Starts
        Console.WriteLine("======================================== QUESTION 9 ========================================")
        Console.WriteLine()
        Console.WriteLine(" What town has the Museum of freedom ? ")
        Console.WriteLine(" 1. Diamond City ")
        Console.WriteLine(" 2. Concord ")
        Console.WriteLine(" 3. Sanctuary hills ")
        Console.WriteLine(" 4. Covenant")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 2 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 9 Ends
        
        'Question 10 Starts
        Console.WriteLine("======================================== QUESTION 10 ========================================")
        Console.WriteLine()
        Console.WriteLine(" What DLC is not part of fallout 4 ? ")
        Console.WriteLine(" 1. Far Harbour ")
        Console.WriteLine(" 2. Nuka world ")
        Console.WriteLine(" 3. Vault workshop ")
        Console.WriteLine(" 4. Broken steel ")
        Console.WriteLine("Please enter your Answer - 1 2 3 or 4")

        answer = Console.ReadLine
        
        If answer = 4 Then
            score += 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Correct answer")
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Sorry wrong answer")
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Your score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
        'Question 10 Ends

        'Print final score
        Console.WriteLine("Your final score is " & score)
        Console.WriteLine("press enter to continue")
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub quit_quiz()
        Console.WriteLine("======================================== GOODBYE ========================================")
        Console.WriteLine("Thank you for playing the quiz")
        Console.WriteLine("Press enter key to quit ...")
        Console.ReadLine()
    End Sub
    
End Module