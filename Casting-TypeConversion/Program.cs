namespace Casting_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================================
            // 🔹 Parsing & Conversion from string to numeric types
            // =========================================================

            /*
             * Converting strings to numeric types is very common in real applications:
             * - User input
             * - Configuration files
             * - Data coming from APIs or files
             *
             * C# provides multiple approaches:
             * - Parse
             * - TryParse
             * - Convert
             */


            // =========================================================
            // 🔹 int.Parse
            // =========================================================

            /*
             * int.Parse:
             * - Converts a string representation of a number into an int.
             * - Throws an exception if the string is invalid.
             *
             * When to use:
             * - When you are 100% sure the string is a valid number.
             */

            string stringValue = "123";
            int intv = int.Parse(stringValue);
            Console.WriteLine(intv);

            /*
             * Potential problems with int.Parse:
             * - FormatException (non-numeric string)
             * - OverflowException (value outside int range)
             */


            // =========================================================
            // 🔹 int.TryParse (BEST PRACTICE)
            // =========================================================

            /*
             * int.TryParse:
             * - Attempts to parse a string into an int.
             * - Does NOT throw exceptions.
             * - Returns true if parsing succeeds, false otherwise.
             *
             * This is the safest and recommended approach.
             */

            if (int.TryParse(stringValue, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            /*
             * Why TryParse is preferred:
             * - No exceptions
             * - Better performance
             * - Safer for user input
             */


            // =========================================================
            // 🔹 Convert.ToInt32
            // =========================================================

            /*
             * Convert.ToInt32:
             * - Converts various types to int (string, double, bool, etc.)
             * - Handles null values (returns 0 instead of throwing NullReferenceException)
             *
             * Internally:
             * - Uses IConvertible interface
             */

            var z = Convert.ToInt32(stringValue);

            /*
             * Comparison summary:
             * - Parse      -> throws exceptions, strict
             * - TryParse   -> safe, recommended
             * - Convert    -> flexible, handles nulls
             */


            // =========================================================
            // 🔹 BitConverter
            // =========================================================

            /*
             * BitConverter is used to:
             * - Convert primitive data types into byte arrays
             * - Understand how values are stored at the binary level
             *
             * This is important in:
             * - Low-level programming
             * - Networking
             * - File formats
             * - Cryptography
             */

            var numberbytes = 255;
            var bytes = BitConverter.GetBytes(numberbytes);

            foreach (var b in bytes)
            {
                Console.WriteLine(b);

                /*
                 * Convert byte to binary representation
                 * PadLeft ensures 8-bit format
                 */
                var binary = Convert.ToString(b, 2).PadLeft(8, '0');
                Console.WriteLine(binary);
            }

            /*
             * Note:
             * BitConverter depends on system endianness (Little Endian on most systems).
             */


            // =========================================================
            // 🔹 Character Encoding (ASCII / Binary / Hexadecimal)
            // =========================================================

            /*
             * Characters in C# are stored as Unicode (UTF-16).
             * Each character has a numeric representation.
             */

            var name = "Hello";
            char[] letters = name.ToCharArray();

            foreach (var ch in letters)
            {
                /*
                 * Convert character to its numeric (ASCII/Unicode) value
                 */
                int ascii = Convert.ToInt32(ch);

                /*
                 * Display:
                 * - Character
                 * - ASCII / Unicode value
                 * - Binary representation
                 * - Hexadecimal representation
                 */
                var output =
                    $"'{ch}' --> ASCII: {ascii}, " +
                    $"Binary: {Convert.ToString(ascii, 2).PadLeft(8, '0')}, " +
                    $"Hexadecimal: {ascii:X}";

                Console.WriteLine(output);
            }


            // =========================================================
            // 🔹 Why this matters
            // =========================================================

            /*
             * Understanding conversions helps you:
             * - Avoid runtime exceptions
             * - Write safer input-handling code
             * - Debug low-level issues
             * - Understand memory and data representation
             *
             * This knowledge is essential for:
             * - Backend development
             * - Systems programming
             * - Performance-critical applications
             */
        }
    }
}
