

class Calculator
{
    static void Main(string[] args)
    {
        bool playing = true;
        int a, b;
        char v=' ';
        char key=' ';


        while(playing)
        {
            Console.WriteLine("Sheitane Pirveli cifri ");
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sheitane Meore cifri ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sheitane operacia ");
            v=Convert.ToChar(Console.ReadLine());

            switch (v)
            {
                case '+':
                    int sum = a + b;
                    Console.WriteLine("Jamia " + sum);
                    break;
                case '-':
                    int factor = a - b;
                    Console.WriteLine("Gamoklebaa " + factor);
                    break;
                case '*':
                     int prodcut = a * b;
                    Console.WriteLine("Namravlia " + prodcut);
                    break;
                case '/':
                    double GAyofa = a / b;
                    Console.WriteLine("GAnayofia " + GAyofa);
                    break;

                default:
                    Console.WriteLine("SHen ar shegitania rixcvi an operatori");
                    break;
            }

            Console.WriteLine("Ginda axlidan? Y/N");
            key=Convert.ToChar(Console.ReadLine());

            if (key == 'Y')
            {
                playing = true;
            }
            else
            {
                playing = false;
            }

        }

    }

}
