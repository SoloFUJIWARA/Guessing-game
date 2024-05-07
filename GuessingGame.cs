

class GuessingGame
{
    static void Main(string[] args)
    {
        bool playing = true;
        int guess;
        int count = 0;
        int number = 0;
        Random random = new Random();

        while (playing)
        {
           
            guess = 0;
            count = 0;
            number = random.Next(1, 11);

            while (guess != number)
            {
                Console.WriteLine("Sheitane ricxvi ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == null)
                {
                    Console.WriteLine("Shen ar shegitania ricxvi ");
                }
                count++;
                if (guess < number)
                {
                    Console.WriteLine("Gueess is lower than number ");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Gueess is Higher than number ");
                }



            }
            if (guess == number)
            {
                Console.WriteLine("Congrats you won in " + count + " Guesees");
                playing = false;
                if (playing == false)
                {
                    Console.WriteLine("Ginda axlidan ? Y/N ");
                    char key;
                    key = Convert.ToChar(Console.ReadLine());
                    if (key == 'Y')
                    {
                        playing = true;
                    }
                    else if (key == 'N')
                    {
                        playing = false;
                    }
                }

            }

        }

    }

}
