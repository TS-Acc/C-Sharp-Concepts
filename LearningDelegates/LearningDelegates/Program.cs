namespace LearningDelegates
{
    internal class Program
    {
        /* The following example declares a delegate named Del that can encapsulate a method that takes a string as an argument 
         * and returns void */
        public delegate void Del(string message);

        static void Main(string[] args)
        {

            // Instantiate the delegate

            Del handler = DelegateMethod;


            /* A delegate can call more than one method when invoked. This is referred to as multicasting.To add an extra method 
             * to the delegate's list of methods—the invocation list—simply requires adding two delegates using the addition or 
             * addition assignment operators (' + ' or ' += ') */

            MethodClass obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            // Both types of assignment are valid

            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            // You may also remove methods from the invocation list using subtraction or subtraction assignment operators

            allMethodsDelegate -= d1;

            // Copy allMethodsDelegate while removing d2

            Del oneMethodDelegate = allMethodsDelegate - d2;


            // Call the delegate

            handler("Hello World!");

            int invocationCount = d1.GetInvocationList().GetLength(0);
            Console.WriteLine(invocationCount);


            // Using the method "MethodWithCallback" with the instantiated delegate "handler"

            MethodWithCallback(10, 27, handler);


            // Using the method "MultiplyTwoNumbers" with the instantiated delegate "handler"

            MultiplyTwoNumbers(handler);


            // Create a method for the delegate

            static void DelegateMethod(string message)
            {
                Console.WriteLine(message);
            }


            // The following example method uses the Del type as a parameter

            static void MethodWithCallback(int param1, int param2, Del callback)
            {
                callback("The number is: " + (param1 + param2).ToString());
            }


            // The following is a method that takes the Del type as a parameter and multiplies two numbers together

            static void MultiplyTwoNumbers(Del callback)
            {
                Console.WriteLine("Enter two numbers to multiply: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                callback($"{numberOne} multiplied by {numberTwo} is " + (numberOne * numberTwo).ToString());
            }


        }
    }
}