# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Create an entertaining random generator that displays different loot combinations for the user to admire. 
**TODO: Complete this section**

### 3a ii.

My video demonstrates how my program can prompt the user to say how many combinations of loot they would like and the requested amount is then displayed
**TODO: Complete this section**

### 3a iii.


My program receives a numeric input ranging from 1 to 3 from the user and then outputs a list containing that many loot combinations
**TODO: Complete this section**

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
    List<string> elements = new List<string>();

            elements.Add("fire");
            elements.Add("ice");
            elements.Add("lightning");```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
Random generator = new Random();
            int index = generator.Next(0, weapons.Count);

            string randomWeapon = weapons[index];
            // Console.WriteLine($"You found a {randomWeapon}");

            int index2 = generator.Next(0, elements.Count);

            string randomElement = elements[index2];
            // Console.WriteLine($"You found a {randomElement}");

            int index3 = generator.Next(0, themes.Count);

            string randomTheme = themes[index3];
            // Console.WriteLine($"You found a {randomTheme}");


            return $"{randomTheme} {randomElement} {randomWeapon}";
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

 "The list is stored in the variable {weapons.Count}"

### 3b iv.

Describes what the data contained in the list represents in your program

The list represents all of the possible weapon combinations that are possible to be generated

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**

Without a list, it would be difficult but not impossible for there to be a selection of weapons since there would be no random index. If I wanted to add more possibilities it would make the process very redundant and not efficient. In order to manage complexity, this list allows the program to efficiently generate a random weapon without the need of numerous if / else if statements for each possible random number that could be generated. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
 public static int GetValidInt(string prompt)
        {

            if (prompt == null)
            {
                throw new Exception("That is invalid");
            }

            int userChoice;

            do
            {
                Console.Write($"{prompt}: ");

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you failed to enter a number");

                }
                else if (userChoice >= 4 || userChoice <= 0) //TODO(jcollard 2022-02-11): What if the user selects 0? or -5?
                {
                    Console.WriteLine("That is not a number 1-3");
                    
                }
            }

            while (userChoice >= 4 || userChoice <= 0); //TODO(jcollard 2022-02-11): Are you sure you should keep looping if the user selected a number less than 4?

            return userChoice;


        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
            int combos = GetValidInt("How many loot combinations would you like?");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a valid number of loot combinations to generate, displays a list of loot to generate. This is the main function of the program. 
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.


1. Validate the prompt is a string
2. Display the prompt
3. Read input from the user
4. If the user entered an Invalid weapon, element, or theme, 
   - display the error message
   - go to step 2
5. Otherwise, return the users input

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 
GetValidInt(null)

**TODO: Complete this section**

Second call:
GetValidInt("Enter a number")

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:

I am testing if the user has inputted is null. This will cause the body of the if statement to execute.
 
**TODO: Complete this section**

Condition(s) tested by the second call:

I am testing is the prompt the user has inputted is not null. This will skip the the body of the if statement. 

**TODO: Complete this section**

### 3d iii.

Result of the first call:

The result of calling with a string that is null is an exception being thrown.

**TODO: Complete this section**

Result of the second call:
The result of calling with a number that is at least 1 is to display that many combinations of loot. 

**TODO: Complete this section**