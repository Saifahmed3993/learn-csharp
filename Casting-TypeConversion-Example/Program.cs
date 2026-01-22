namespace Casting_TypeConversion_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================================
            // TOPIC 1: Implicit & Explicit Conversion
            // =========================================================

            // Example 1: Implicit int -> long
            int a = 10;
            long b = a;
            Console.WriteLine(b);

            /*
             * This is an implicit conversion.
             * int is smaller than long, so C# converts it automatically.
             * No data loss can happen here.
             */


            // Example 2: Implicit int -> double
            int c = 5;
            double d = c;
            Console.WriteLine(d);

            /*
             * int can be safely converted to double because double
             * can represent all integer values.
             */


            // Example 3: Explicit long -> int
            long e = 100;
            int f = (int)e;
            Console.WriteLine(f);

            /*
             * This is an explicit conversion (casting).
             * C# requires casting because long may contain
             * values larger than int.
             */


            // Example 4: Explicit double -> int
            double g = 9.7;
            int h = (int)g;
            Console.WriteLine(h);

            /*
             * The decimal part is removed, not rounded.
             * This causes data loss.
             */


            // Example 5: Explicit conversion with range check
            long i = 300;
            if (i <= int.MaxValue)
            {
                Console.WriteLine((int)i);
            }

            /*
             * Always check the range before casting
             * to avoid overflow.
             */


            // Example 6: Data loss example
            double j = 12.99;
            int k = (int)j;
            Console.WriteLine(k);

            /*
             * Casting forces the conversion even if
             * it causes data loss.
             */



            // =========================================================
            // TOPIC 2: Boxing & Unboxing
            // =========================================================

            // Example 1: Boxing
            int x = 10;
            object obj = x;
            Console.WriteLine(obj);

            /*
             * Boxing converts a value type into a reference type.
             * The value is copied from Stack to Heap.
             */


            // Example 2: Unboxing
            int y = (int)obj;
            Console.WriteLine(y);

            /*
             * Unboxing extracts the value back from the object.
             * Casting is mandatory.
             */


            // Example 3: Boxing double
            double d1 = 5.5;
            object o1 = d1;
            Console.WriteLine(o1);

            /*
             * Any value type can be boxed, not only int.
             */


            // Example 4: Unboxing double
            double d2 = (double)o1;
            Console.WriteLine(d2);

            /*
             * The type must match exactly during unboxing.
             */


            // Example 5: Boxing inside a loop
            for (int m = 0; m < 3; m++)
            {
                object o = m;
                Console.WriteLine(o);
            }

            /*
             * Boxing inside loops is expensive and should be avoided.
             */


            // Example 6: Boxing + Unboxing
            object boxed = 99;
            int unboxed = (int)boxed;
            Console.WriteLine(unboxed);

            /*
             * This is a full boxing-unboxing cycle.
             */



            // =========================================================
            // TOPIC 3: Parse / TryParse / Convert
            // =========================================================

            // Example 1: int.Parse
            string s1 = "100";
            int p1 = int.Parse(s1);
            Console.WriteLine(p1);

            /*
             * Parse assumes the string is valid.
             * If not, it throws an exception.
             */


            // Example 2: TryParse success
            string s2 = "200";
            int.TryParse(s2, out int p2);
            Console.WriteLine(p2);

            /*
             * TryParse is safe and does not throw exceptions.
             */


            // Example 3: TryParse failure
            string s3 = "ABC";
            bool ok = int.TryParse(s3, out int p3);
            Console.WriteLine(ok);

            /*
             * TryParse returns false if conversion fails.
             */


            // Example 4: Convert.ToInt32
            string s4 = "300";
            int p4 = Convert.ToInt32(s4);
            Console.WriteLine(p4);

            /*
             * Convert is flexible and handles null values.
             */


            // Example 5: Convert null
            string s5 = null;
            int p5 = Convert.ToInt32(s5);
            Console.WriteLine(p5);

            /*
             * Convert.ToInt32(null) returns 0.
             */


            // Example 6: Best practice
            /*
             * TryParse is the recommended choice for user input.
             */



            // =========================================================
            // TOPIC 4: BitConverter
            // =========================================================

            // Example 1: Convert int to byte array
            int n1 = 255;
            byte[] bytes1 = BitConverter.GetBytes(n1);
            Console.WriteLine(bytes1.Length);

            /*
             * BitConverter.GetBytes converts a value type
             * into its binary representation as bytes.
             * int occupies 4 bytes in memory.
             */


            // Example 2: Print each byte
            foreach (byte b1 in bytes1)
            {
                Console.WriteLine(b1);
            }

            /*
             * Each byte represents a part of the integer
             * stored in memory.
             */


            // Example 3: Byte to binary representation
            foreach (byte ab in bytes1)
            {
                string binary = Convert.ToString(ab, 2).PadLeft(8, '0');
                Console.WriteLine(binary);
            }

            /*
             * Each byte consists of 8 bits.
             * PadLeft ensures fixed 8-bit formatting.
             */


            // Example 4: short to bytes
            short n2 = 100;
            byte[] bytes2 = BitConverter.GetBytes(n2);
            Console.WriteLine(bytes2.Length);

            /*
             * short occupies 2 bytes in memory.
             */


            // Example 5: double to bytes
            double n3 = 9.5;
            byte[] bytes3 = BitConverter.GetBytes(n3);
            Console.WriteLine(bytes3.Length);

            /*
             * double occupies 8 bytes in memory.
             */


            // Example 6: Endianness
            Console.WriteLine(BitConverter.IsLittleEndian);

            /*
             * Most systems are Little Endian.
             */



            // =========================================================
            // TOPIC 5: Char / ASCII / Binary / Hexadecimal
            // =========================================================

            // Example 1: Char to ASCII
            char c1 = 'A';
            int ascii1 = c1;
            Console.WriteLine(ascii1);

            /*
             * Characters are stored as numeric values.
             * 'A' corresponds to ASCII code 65.
             */


            // Example 2: ASCII to Binary
            string bin1 = Convert.ToString(ascii1, 2);
            Console.WriteLine(bin1);

            /*
             * Binary representation shows how data
             * is stored at the bit level.
             */


            // Example 3: ASCII to Hexadecimal
            Console.WriteLine(ascii1.ToString("X"));

            /*
             * Hexadecimal is a compact representation
             * of binary data.
             */


            // Example 4: String to char array
            string text = "Hi";
            char[] letters = text.ToCharArray();

            /*
             * Strings are collections of characters.
             */


            // Example 5: Loop through characters
            foreach (char ch in letters)
            {
                Console.WriteLine((int)ch);
            }

            /*
             * Casting char to int reveals its ASCII/Unicode value.
             */


            // Example 6: Full character representation
            foreach (char ch in letters)
            {
                Console.WriteLine(
                    $"{ch} -> ASCII:{(int)ch}, " +
                    $"Binary:{Convert.ToString(ch, 2)}, " +
                    $"Hex:{((int)ch):X}"
                );
            }

            /*
             * This shows how a character can be represented
             * in multiple numeric formats.
             */



            // =========================================================
            // FINAL MIXED EXAMPLES
            // =========================================================

            // Mixed Example 1: TryParse + Boxing + Unboxing
            string m1 = "50";
            if (int.TryParse(m1, out int r1))
            {
                object oo1 = r1;
                int v1 = (int)oo1;
                Console.WriteLine(v1);
            }

            /*
             * Safe string parsing followed by boxing and unboxing.
             */


            // Mixed Example 2: double casting + data loss
            double m2 = 7.9;
            int r2 = (int)m2;
            Console.WriteLine(r2);

            /*
             * Explicit casting removes the decimal part.
             */


            // Mixed Example 3: char to binary
            char m3 = 'C';
            Console.WriteLine(Convert.ToString(m3, 2));

            /*
             * Characters can be directly converted to binary.
             */


            // Mixed Example 4: int to bytes
            int m4 = 128;
            foreach (byte pb in BitConverter.GetBytes(m4))
            {
                Console.WriteLine(pb);
            }

            /*
             * Demonstrates memory-level representation of integers.
             */


            // Mixed Example 5: Convert object to int
            object m5 = "123";
            int r5 = Convert.ToInt32(m5);
            Console.WriteLine(r5);

            /*
             * Convert handles object types flexibly.
             */


            // Mixed Example 6: TryParse inside loop
            string[] values = { "1", "X", "3" };
            foreach (string v in values)
            {
                Console.WriteLine(
                    int.TryParse(v, out _) ? "Valid" : "Invalid"
                );
            }

            /*
             * TryParse is ideal for validating multiple inputs.
             */


            // Mixed Example 7: int to char
            int m7 = 65;
            char ch7 = (char)m7;
            Console.WriteLine(ch7);

            /*
             * Casting int to char maps numeric code to character.
             */


            // Mixed Example 8: long to int casting
            long m8 = 500;
            int r8 = (int)m8;
            Console.WriteLine(r8);

            /*
             * Explicit casting is required for narrowing conversions.
             */


            // Mixed Example 9: String + ASCII
            string m9 = "Hello";
            foreach (char ch in m9)
            {
                Console.WriteLine($"{ch} -> {(int)ch}");
            }

            /*
             * Each character in a string has its own numeric code.
             */


            // Mixed Example 10: Full pipeline
            string m10 = "90";
            if (int.TryParse(m10, out int r10))
            {
                object boxed2 = r10;
                string binary = Convert.ToString((int)boxed2, 2);
                Console.WriteLine(binary);
            }

            /*
             * This example combines parsing, boxing,
             * unboxing, and binary conversion.
             */



            // =========================================================
            // FINAL NOTE
            // =========================================================
            /*
             * This file is designed for learning by examples.
             * Read the code, then read the explanation under each example.
             */
        }
    }
}
