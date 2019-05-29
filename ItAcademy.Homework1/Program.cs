namespace ItAcademy.Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
                // Task 1:
            // Declare and initialize variables of all primitive value types

            byte byteVariable = 250;                        // byte variable
            sbyte sbyteVariable = -128;                     // sbyte variable
            char charVariable = 'c';                        // char variable
            short shortVariable = -32760;                    // short variable
            ushort ushortVariable = 65530;                  // ushort variable
            int intVariable = 214700501;                    // int variable
            uint uintVariable = 4294000080;                 // uint variable
            long longVariable = -9223000000000000018;       // long variable
            ulong ulongVariable = 18440000000000000022;     // ulong variable
            float floatVariable = 3.0120F;                  // float variable
            double doubleVariable = -14.701;                // double variable
            decimal decimalVariable = 591.546M;             // decimal variable
            bool boolVariable = true;                       // bool variable

            
                // Task 2:
            // Boxing and unboxing

            // Declare and initialize value type variable
            double valType = 3.14;

            // Case of boxing
            object refType = valType;

            // Case of unboxing
            int unboxedValue = (int)refType;
            
        }
    }
}
