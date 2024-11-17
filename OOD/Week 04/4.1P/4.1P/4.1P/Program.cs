namespace Exceptions
{
    internal class Program
    {
        class Account
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Balance { get; private set; }
            public Account(string firstName, string lastName, int balance)
            {
                FirstName = firstName;
                LastName = lastName;
                Balance = balance;
            }
            public void Withdraw(int amount)
            {
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient fund");
                }
                Balance = Balance - amount;
            }

            private static void PrintExceptionDetails(Exception exception)
            {
                Console.WriteLine("The following error detected: " +
                    exception.GetType().ToString() + " with message \"" +
                    exception.Message + "\"");
            }


            static void Main(string[] args)
            {
                try
                {
                    Account account = new Account("Sergey", "P.", 100);
                    account.Withdraw(1000);
                }
                catch (InvalidOperationException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  NullReferenceException
                    object obj = null;
                    int length = obj.ToString().Length;  // This line will fail Exception NullReferenceException
                }
                catch (NullReferenceException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  IndexOutOfRangeException
                    int[] array = { 1, 2, 3 };
                    int value = array[5];  // This line will fail Exception IndexOutOfRangeException
                }
                catch (IndexOutOfRangeException ex)
                {
                    PrintExceptionDetails(ex);
                }



                try
                {
                    //  OutOfMemoryException
                    AllocateMemory();  // Eventually, this will result in an OutOfMemoryException
                }
                catch (OutOfMemoryException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  InvalidCastException
                    object invalidCast = "Invalid Cast";
                    int result = (int)invalidCast;  // This line will fail Exception InvalidCastException
                }
                catch (InvalidCastException ex)
                {
                    PrintExceptionDetails(ex);
                }

                //  DivideByZeroException
                try
                {
                    int result = DivideByZeroExample(5, 0);  // This line will fail Exception DivideByZeroException
                }
                catch (System.DivideByZeroException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  ArgumentException
                    ProcessArgument(null);  // This will fail Exception ArgumentException
                }
                catch (ArgumentException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  ArgumentOutOfRangeException
                    ProcessIndex(-1);  // This will fail Exception ArgumentOutOfRangeException
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  SystemException
                    throw new SystemException("Custom System Exception");  // This will fail Exception SystemException
                }
                catch (SystemException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    //  StackOverflowException
                    RecursiveMethod();  // This will eventually fail Exception StackOverflowException
                }
                catch (StackOverflowException ex)
                {
                    PrintExceptionDetails(ex);
                }
            }

            static void RecursiveMethod()
            {
                RecursiveMethod();
            }

            static void AllocateMemory()
            {
                int[] largeArray = new int[int.MaxValue];
            }

            static void ProcessArgument(string value)
            {
                if (value == null)
                {
                    throw new ArgumentException("Argument cannot be null", nameof(value));
                }
            }
            static void ProcessIndex(int index)
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative");
                }
            }

            static int DivideByZeroExample(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new System.DivideByZeroException("Cannot divide by zero.");
                }

                return numerator / denominator;
            }
        }
    }
}