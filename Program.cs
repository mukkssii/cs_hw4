namespace cs4_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*try
            {
                Console.WriteLine("1. Decimal to Binary");
                Console.WriteLine("2. Binary to Decimal");
                Console.WriteLine("3. Decimal to Hexadecimal");
                Console.WriteLine("4. Hexadecimal to Decimal");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Enter number: ");
                string num = Console.ReadLine();
                int result;
                switch (choice)
                {
                    case 1:
                        result = int.Parse(num);
                        Console.WriteLine(Convert.ToString(result, 2));
                        break;

                    case 2:
                        result = Convert.ToInt32(num, 2);
                        Console.WriteLine(result);
                        break;

                    case 3:
                        result = int.Parse(num);
                        Console.WriteLine(Convert.ToString(result, 16));
                        break;

                    case 4:
                        result = Convert.ToInt32(num, 16);
                        Console.WriteLine(result);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("out of int range");
            }*/


            //2
            /*Console.Write("Enter number in words: ");
            string num = Console.ReadLine().ToLower();
            switch (num)
            {
                case "zero":
                    Console.WriteLine(0);
                    break;

                case "one":
                    Console.WriteLine(1);
                    break;

                case "two":
                    Console.WriteLine(2);
                    break;

                case "three":
                    Console.WriteLine(3);
                    break;

                case "four":
                    Console.WriteLine(4);
                    break;

                case "five":
                    Console.WriteLine(5);
                    break;

                case "six":
                    Console.WriteLine(6);
                    break;

                case "seven":
                    Console.WriteLine(7);
                    break;

                case "eight":
                    Console.WriteLine(8);
                    break;

                case "nine":
                    Console.WriteLine(9);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }*/


            //3
            /*try
            {
                Passport passport = new Passport(
                    "fdsiaid33434",
                    "Sponge Bobik",
                    new DateTime(2378, 10, 17)
                );

                passport.ShowInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            //4
            /*try
            {
                Console.Write("Enter expression: ");
                string expression = Console.ReadLine();
                string[] operators = { "<=", ">=", "==", "!=", "<", ">" };
                string op = "";
                foreach (string oper in operators)
                {
                    if (expression.Contains(oper))
                    {
                        op = oper;
                        break;
                    }
                }
                if (op == "")
                {
                    throw new Exception("Wrong operator!");
                }
                string[] parts = expression.Split(op);
                if (parts.Length != 2)
                {
                    throw new Exception("Wrong expression!");
                }
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);
                bool result = false;
                switch (op)
                {
                    case "<":
                        result = num1 < num2;
                        break;

                    case ">":
                        result = num1 > num2;
                        break;

                    case "<=":
                        result = num1 <= num2;
                        break;

                    case ">=":
                        result = num1 >= num2;
                        break;

                    case "==":
                        result = num1 == num2;
                        break;

                    case "!=":
                        result = num1 != num2;
                        break;
                }

                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/


            //5
            try
            {
                BankAccount account = new BankAccount(1000000);
                account.ShowBalance();
                account.Deposit(500);
                account.ShowBalance();
                account.Withdraw(300);
                account.ShowBalance();
                account.Withdraw(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
