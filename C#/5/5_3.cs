void EvaluateCondition(int number1)
{
    if (number1 > 0) 
    { //positive

        if (number1 < 10)
        { // under 10

            if (number1 % 2 == 0)
            { //even
                Console.WriteLine("The number you entered is positive, less than 10, and even.");
            } //even

            else
            { //odd
                Console.WriteLine("The number you entered is positive, less than 10, and odd.");
            } //odd

        } // under 10

        else
        { //over 10

            if (number1 % 2 == 0)
            { //even
                Console.WriteLine("The number you entered is positive, 10 or more, and even.");
            } //even
            
            else
            { //odd
                Console.WriteLine("aThe number you entered is positive, 10 or more, and odd.");
            } //odd

        } //over 10

    } //positive

    else if (number1 == 0)
    { //zero
        Console.WriteLine("The number you entered is zero.");
    } //zero

    else
    { //negative
        Console.WriteLine("The number you entered is negative.");
    } //negative
}
