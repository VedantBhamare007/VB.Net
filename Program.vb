Imports System.IO 'for file handling

Module Program

    ' Class
    Class Sample

        Dim var As Integer = 0 'Default scope is Private
        Public Shared count As Integer 'Static variable  
        'Function can also be Static [static member function]
        Public Sub SetVar(ByVal var As Integer)
            Me.var = var 'Me is same as This
        End Sub
        Public Function getVar()
            Return var
        End Function

    End Class

    Class Construct

        Dim var As Integer
        Public Sub New() 'Constructor
            var = 0
        End Sub
        ' Constructor Overloading
        Public Sub New(var As Integer) 'Constructor with parameter
            Me.var = var
        End Sub
        Public Function printVar()
            Return var
        End Function

        ' Destructor
        Protected Overrides Sub Finalize()
            Console.WriteLine("Destructor is called")
        End Sub

    End Class

    ' Inheritance
    Class Base

        'Private variables & functions are only accessible inside the classand not accessible outside the class
        Private privateNum As Integer = 199
        Public baseNum As Integer 'no need to use Dim keyword
        'Protected variables & functions can be accessible inside the class and also in the derived class [inherited]
        Protected protectedNum As Integer = 299
        Public Sub printBaseNum()
            Console.WriteLine(baseNum)
        End Sub

    End Class

    Class Derived : Inherits Base

        Public derivedNum As Integer
        Public Sub printDerivedNum()
            Console.WriteLine(derivedNum)
        End Sub
        'Public Sub printPrivateNum()
        '    'public variablees and functions of base class cannot be inherited
        '    Console.WriteLine(privateNum)
        'End Sub
        Public Sub printProtectedNum()
            Console.WriteLine(protectedNum)
        End Sub

    End Class

    ' Function
    Function AddNumbers(ByVal num1 As Integer, ByVal num2 As Integer)
        Return num1 + num2
    End Function

    ' SubProcedure - function doesnt returns anything
    Sub Greet()
        Console.WriteLine("Hello, How are you?")
    End Sub

    ' ByVal Method
    Sub Add(ByVal num1 As Integer, ByVal num2 As Integer)
        Console.WriteLine(num1 + num2)
    End Sub

    ' ByRef Method
    Sub SwapNumbers(ByRef num1 As Integer, ByRef num2 As Integer)
        Dim temp As Integer
        temp = num1
        num1 = num2
        num2 = temp
        Console.WriteLine("In Swap Method")
        Console.WriteLine("Number1: " & num1 & " and Number2: " & num2)
    End Sub

    ' Directives
#Const MyName = "Vedant"
    '#Const directiveName = value

    ' Creating an Enum variable
    Enum Names
        VedantBhamare = 205110
        SahilBhoye = 205113
        RajBodke = 205115
        VedantPatil = 205142
        AjitRathod = 205146
    End Enum

    Sub Main(args As String())

        ' Write on a Console
        Console.Write("Hello ")
        Console.WriteLine("Everyone") ' console.Write() + newline
        Dim name As String = "Vedant"
        Console.WriteLine("I am " & "Bhamare " & name)

        ' This is a Comment

        ' Variables
        Dim var As Integer = 10
        'Dim variableName As dataType = value 

        ' Read from a Console
        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        Console.WriteLine("Your name is {0}", name)

        ' DataTypes
        Dim intVar As Integer = 999999999
        Dim longVar As Long = 99999999999
        Dim doubleVar As Long = 3.14
        Dim charVar As Char = "A"
        Dim stringVar As String = "This is a String"
        Dim booleanVar As Boolean = True
        ' Writing on a Console
        Console.WriteLine(intVar)
        Console.WriteLine(longVar)
        Console.WriteLine(doubleVar)
        Console.WriteLine(charVar)
        Console.WriteLine(stringVar)
        Console.WriteLine(booleanVar)

        ' Constants
        Const constant As Integer = 10
        'Const constantVariableName As dataTypr = value
        'constant = 205110 ' constant cannot be modified
        Console.WriteLine(constant)

        ' Enumerations
        Console.WriteLine(Names.VedantBhamare)
        Console.WriteLine(Names.SahilBhoye)
        Console.WriteLine(Names.RajBodke)
        Console.WriteLine(Names.VedantPatil)
        Console.WriteLine(Names.AjitRathod)
        ' Default value of VedantBhamare, SahilBhoye, ... are 0, 1, ...

        'Console.WriteLine(MyName) 'Directives cannot be Written
#If MyName = "Vedant" Then
        Console.WriteLine("Authorized")
#Else
                Console.WriteLine("Unauthorized")
#End If

        ' Conditional Statement
        '''
        'If
        If 0 = False Then
            Console.WriteLine("0 = False")
        End If
        'If condition Then
        '   ...
        'End If
        '''
        'If Else
        If 1 = False Then
            Console.WriteLine("1 = False")
        Else
            Console.WriteLine("1 <> False")
        End If
        'If condition Then
        '   ...
        'Else
        '   ...
        'End If
        '''
        'If ElseIf Else
        If 0 = True Then
            Console.WriteLine("0 = True")
        ElseIf 0 = False Then
            Console.WriteLine("0 = False")
        Else
            Console.WriteLine("0 <> True And False")
        End If
        'If condition Then
        '   ...
        'ElseIf condition Then
        '   ...
        'Else
        '   ...
        'End If
        '''
        'SelectCase
        Console.Write("Enter a number from 1 to 7: ")
        Dim inputNum As Integer = Console.ReadLine()
        Select Case inputNum
            Case 1, -1
                Console.WriteLine("Sunday")
            Case 2, -2
                Console.WriteLine("Monday")
            Case 3, -3
                Console.WriteLine("Tuesday")
            Case 4, -4
                Console.WriteLine("Wednesday")
            Case 5, -5
                Console.WriteLine("Thursday")
            Case 6, -6
                Console.WriteLine("Friday")
            Case 7, -7
                Console.WriteLine("Saturday")
            Case Else
                Console.WriteLine("Invalid Input")
        End Select
        'Select Case caseVariable
        '   Case value
        '       ...
        '   Case value1, value2, ...
        '       ...
        '   Case Else
        '       ...
        'End Select

        ' Looping Statement
        '''
        'For Loop
        Console.Write("Enter a number: ")
        Dim tableNum As Integer = Console.ReadLine()
        Dim i As Integer
        For i = 1 To 10 Step 1
            Console.WriteLine(tableNum & " * " & i & " = " & tableNum * i)
        Next
        'For counter = initialization to condition Step incrementation/decrementation
        '   ...
        'Next
        '''
        'While Loop
        i = 1
        While i <= 10
            Console.WriteLine(tableNum & " * " & i & " = " & tableNum * i)
            i += 1
        End While
        'While condition
        '   ...
        '   increment/decrement [optional]
        'End While
        '''
        'Do Loop
        Dim conditionVar As Boolean = True
        Do
            Console.WriteLine("Condition is " & conditionVar)
        Loop While conditionVar <> True
        'Do
        '   ...
        '   increment/decrement [optional]
        'Loop

        ' Strings
        Dim str, str1, str2 As String
        str = "Hello"
        str1 = "World"
        str2 = str + str1 'String Concatenation
        Console.WriteLine(str2)
        Dim len As Integer = str2.Length
        Console.WriteLine("Length of " & str2 & " is: " & len)
        ' Strings are immutable
        Console.WriteLine(str2 & " in upper case: " & str2.ToUpper)

        ' Date And Time
        Console.WriteLine(Now.ToShortDateString)
        Console.WriteLine(Now.ToShortTimeString)
        Console.WriteLine(Now.ToLongDateString)
        Console.WriteLine(Now.ToLongTimeString)
        'Try Different Date&Time Methods

        ' Arrays
        Dim arr(5) As Integer 'Declaration 'Dim arrayName(size) As DataType
        arr = {0, 1, 2, 3, 4} 'Initialization
        'getting elements of array
        For i = 0 To arr.Length - 1
            Console.Write("Enter {0}th element: ", i)
            arr(i) = Console.ReadLine()
        Next
        'printing elements of array
        For i = 0 To arr.Length - 1
            Console.Write("{0}th element: {0}", i, arr(i))
        Next
        '2D Array
        Dim twoDArr(5, 5) As Integer
        twoDArr = {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        }
        Console.WriteLine(twoDArr(4, 4))

        ' ForEach Loop
        Dim element As Integer
        For Each element In arr
            Console.WriteLine(element)
        Next
        'For Each element In array
        '   ...
        'Next

        ' ArrayList
        Dim arrList As ArrayList = New ArrayList()
        arrList.Add(1)
        arrList.Add(2)
        arrList.Add(3)
        arrList.Add(4)
        arrList.Add(5)
        Console.WriteLine(arrList.Count)

        ' HashTable
        Dim hash As Hashtable = New Hashtable()
        hash.Add("VedantBhamare", 205110) 'key value pair
        hash.Add("SahilBhoye", 205113)
        hash.Add("RajBodke", 205115)
        hash.Add("VedantPatil", 205142)
        hash.Add("AjitRathod", 205146)
        Console.WriteLine(hash("VedantBhamare"))
        Console.WriteLine(hash("SahilBhoye"))
        Console.WriteLine(hash("RajBodke"))
        Console.WriteLine(hash("VedantPatil"))
        Console.WriteLine(hash("AjitRathod"))
        Console.WriteLine(hash.ContainsKey("VedantBhamare"))

        ' SortedList
        Dim sortedList As SortedList = New SortedList()
        sortedList.Add("VedantBhamare", 205110)
        sortedList.Add("SahilBhoye", 205113)
        sortedList.Add("RajBodke", 205115)
        sortedList.Add("VedantPatil", 205142)
        sortedList.Add("AjitRathod", 205146)
        Console.WriteLine(sortedList)

        ' Stack - FIFO / LILO
        Dim st As Stack = New Stack()
        st.Push(1)
        st.Push(2)
        st.Push(3)
        st.Push(4)
        st.Push(5)
        For Each element In st
            Console.WriteLine(element)
        Next
        st.Pop()
        st.Pop()
        Console.WriteLine()
        For Each element In st
            Console.WriteLine(element)
        Next

        ' Queue - FILO / LIFO
        Dim que As Queue = New Queue()
        que.Enqueue(11)
        que.Enqueue(12)
        que.Enqueue(13)
        que.Enqueue(14)
        que.Enqueue(15)

        For Each element In que
            Console.WriteLine(element)
        Next
        que.Dequeue()
        que.Dequeue()
        Console.WriteLine()
        For Each element In que
            Console.WriteLine(element)
        Next

        ' BitArray
        Dim bitArr As BitArray = New BitArray(5)
        For Each element In bitArr
            Console.WriteLine(element)
        Next

        ' SubProcedures
        Dim num1, num2 As Integer
        num1 = 3
        num2 = 4
        Greet() 'Calling a SubProcedure
        Add(num1, num2)
        Console.WriteLine("Before Calling the Swap ByRef Method")
        Console.WriteLine("Number1: " & num1 & " and Number2: " & num2)
        SwapNumbers(num1, num2)
        Console.WriteLine("After Calling the Swap ByRef Method")
        Console.WriteLine("Number1: " & num1 & " and Number2: " & num2)

        ' Functions
        Dim result As Integer
        result = AddNumbers(num1, num2)
        Console.WriteLine(result)

        ' Exception Handling
        Dim n1, n2, div As Integer
        n1 = 5
        n2 = 0
        Try
            div = n1 / n2
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally 'Optional
            Console.WriteLine("0 cannot be divisor")
        End Try

        ' Object
        Dim s As Sample = New Sample()
        Dim inputVar, objectVar As Integer
        's.var = 10 'Cannot be accessible
        Console.Write("Enter a number: ")
        inputVar = Console.ReadLine()
        s.SetVar(inputVar)
        objectVar = s.getVar()
        Console.WriteLine("Number: " & objectVar)

        ' Constructor
        Dim c1 As Construct = New Construct()
        Dim c2 As Construct = New Construct(10)
        Console.WriteLine("C1.var: " & c1.printVar())
        Console.WriteLine("C2.var: " & c2.printVar())

        ' Static Variable
        Dim obj1 As Sample = New Sample()
        Dim obj2 As Sample = New Sample()
        obj1.count = 1
        Console.WriteLine(obj1.count)
        Console.WriteLine(obj2.count)
        obj2.count = 2
        Console.WriteLine(obj1.count)
        Console.WriteLine(obj2.count)

        ' Inheritance
        Dim obj As Derived = New Derived()
        'properties and methods of base class can be acces by derived class
        obj.baseNum = 10
        obj.derivedNum = 20
        obj.printBaseNum()
        obj.printDerivedNum()
        'obj.protectedNum = 7 'cannot be accessible
        obj.printProtectedNum()

        ' File Handling
        'Creating and opening a file
        Dim file As FileStream = New FileStream("new.txt", FileMode.Create, FileAccess.ReadWrite)
        Dim k As Integer
        'Writing in a file
        file.WriteByte("Hello World")
        'Reading from a file
        For k = 0 To file.Length
            Console.WriteLine(file.ReadByte)
        Next

    End Sub

End Module
