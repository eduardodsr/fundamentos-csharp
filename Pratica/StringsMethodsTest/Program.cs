using System;

namespace StringsMethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            var original = "This is a first sentence. This is a second sentence.";
            var sentence1 = original.Substring(0, original.IndexOf(".") + 1);
            Console.WriteLine(original);   //    This is a first sentence. This is a second sentence.
            Console.WriteLine(sentence1);  //    This is a first sentence.
            Console.WriteLine("");

            String value = "Eduardo Rodrigues.";
            int startIndex = 0;
            int endIndex = 3;   // [INDEX 0] = E; [INDEX 1] = D; [INDEX 2] = U (OPEN SET) -> ( INDEX + 1 )
            // last position is an open set. It has to add ( Index + 1 ) 
            String substring = value.Substring(startIndex, endIndex);
            Console.WriteLine(substring); // Edu
            Console.WriteLine("");


            // *******  C# String methods ( * Method Name() | Description ) ******* 
            // ******* Examples ***************************************************


            // *Clone() - It is used to return a reference to this instance of String.
            Console.WriteLine("Clone()");
            string a1 = "Hello ";
            string a2 = (String)a1.Clone();
            Console.WriteLine(a1); // Hello
            Console.WriteLine(a2); // Hello
            Console.WriteLine("");

            // * Concat(String, String) - It is used to concatenate two specified instances of String.
            Console.WriteLine("Concat()");
            string b1 = "Hello ";
            string b2 = "C#";
            Console.WriteLine(string.Concat(b1, b2)); // Hello C#
            Console.WriteLine("");

            // * Contains(String) -	It is used to return a value indicating whether a specified substring occurs within this string.
            Console.WriteLine("Contains()");
            string c1 = "Hello ";
            string c2 = "He";
            string c3 = "Hi";
            Console.WriteLine(c1.Contains(c2)); // True
            Console.WriteLine(c1.Contains(c3)); // False
            Console.WriteLine("");

            // * EndsWith(String) - It is used to check that the end of this string instance matches the specified string.
            Console.WriteLine("EndsWith()");
            string d1 = "Hello";
            string d2 = "llo";
            string d3 = "C#";
            Console.WriteLine(d1.EndsWith(d2)); // True
            Console.WriteLine(d1.EndsWith(d3)); // False
            Console.WriteLine("");


            // * Equals(String, String)	- It is used to determine that two specified String objects have the same value.
            Console.WriteLine("Equals()");
            string e1 = "Hello";
            string e2 = "Hello";
            string e3 = "Bye";
            Console.WriteLine(e1.Equals(e2)); // True
            Console.WriteLine(e1.Equals(e3)); // False
            Console.WriteLine("");

            // * Format(String, Object)	- It is used to replace one or more format items in a specified string with the string representation of a specified object.
            Console.WriteLine("Format(String, Object)");
            string date = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(date); // Friday, September 24, 2021
            Console.WriteLine("");

            // * GetEnumerator() - It is used to retrieve an object that can iterate through the individual characters in this string.
            Console.WriteLine("GetEnumerator()");
            string fs2 = "Hello C#";
            CharEnumerator ch = fs2.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current); // Return vertical string (the individual characters in this string.)
            }
            Console.WriteLine("");

            // * GetType()	- It is used to get the Type of the current instance.
            Console.WriteLine("GetType()");
            string gs1 = "Hello C#";
            Console.WriteLine(gs1.GetType()); // System.String
            var gs2 = 123;
            Console.WriteLine(gs2.GetType()); // System.Int32
            Console.WriteLine("");

            // * GetTypeCode()	- It is used to return the TypeCode for class String.
            string hs1 = "Hello C#"; // String
            Console.WriteLine(hs1.GetTypeCode());
            var hs2 = 123;
            Console.WriteLine(hs2.GetType()); // System.Int32
            Console.WriteLine("");

            // * IndexOf(String) - It is used to report the zero-based index of the first occurrence of the specified string in this instance.
            Console.WriteLine("IndexOf()");
            string is1 = "Hello C#";
            int index = is1.IndexOf('e');  // 1 = OK
            int index2 = is1.IndexOf('u'); // -1 = NOK
            Console.WriteLine(index);
            Console.WriteLine(index2);
            Console.WriteLine("");

            // * Insert(Int32, String)	- It is used to return a new string in which a specified string is inserted at a specified index position.
            Console.WriteLine("Insert()");
            string js1 = "Hello C#";
            string js2 = js1.Insert(5, "-");
            Console.WriteLine(js2);
            Console.WriteLine("");

            // * Intern(String) - It is used to retrieve the system's reference to the specified String.
            Console.WriteLine("Intern()");
            string ls1 = "Hello C#";
            string ls2 = string.Intern(ls1);
            Console.WriteLine(ls1); // Hello C#
            Console.WriteLine(ls2); // Hello C#
            Console.WriteLine("");

            // * IsNullOrEmpty(String) - It is used to indicate that the specified string is null or an Empty string.
            Console.WriteLine("IsNullOrEmpty()");
            string ms1 = "Hello C#";
            string ms2 = "";
            bool bl1 = string.IsNullOrEmpty(ms1); // False
            bool bl2 = string.IsNullOrEmpty(ms2); // True
            Console.WriteLine(bl1);
            Console.WriteLine(bl2);
            Console.WriteLine("");


            // * IsNullOrWhiteSpace(String) - It is used to indicate whether a specified string is null, empty, or consists only of white-space characters.
            Console.WriteLine("IsNullOrWhiteSpace()");
            string os1 = "Olá C #";
            string os2 = null; // Null
            string os3 = ""; // Empty
            string os4 = " "; // WhiteSpace
            bool bol1 = string.IsNullOrWhiteSpace(os1);
            bool bol2 = string.IsNullOrWhiteSpace(os2);
            bool bol3 = string.IsNullOrWhiteSpace(os3);
            bool bol4 = string.IsNullOrWhiteSpace(os4);
            Console.WriteLine(bol1);       //  False   
            Console.WriteLine(bol2);       //  True   
            Console.WriteLine(bol3);       //  True   
            Console.WriteLine(bol4);       //  True 
            Console.WriteLine("");


            // * Join(String, String[]) - It is used to concatenate all the elements of a string array, using the specified separator between each element.
            Console.WriteLine("Join(String, String[])");
            string[] ts1 = { "Hello", "C#", "by", "javatpoint" };
            string ts2 = string.Join("-", ts1);
            string ts3 = string.Join(" - ", ts1);
            Console.WriteLine(ts2); // Hello-C#-by-javatpoint
            Console.WriteLine(ts3); // Hello - C# - by - javatpoint
            Console.WriteLine("");

            // * LastIndexOf(Char) - It is used to report the zero-based index position of the last occurrence of a specified character within String.
            Console.WriteLine("LastIndexOf(Char)");
            string vs1 = "Hello C#";
            int index3 = vs1.LastIndexOf('l'); // 3 
            Console.WriteLine(index3);
            Console.WriteLine("");

            // * LastIndexOfAny(Char[]) - It is used to report the zero-based index position of the last occurrence in this instance of one or more characters specified in a Unicode array.
            Console.WriteLine("LastIndexOfAny(Char[])");
            string ss1 = "abracadabra";
            char[] ch2 = { 'r', 'b' };
            int index4 = ss1.LastIndexOfAny(ch2);//Finds 'r' at the last  
            Console.WriteLine(index4);
            Console.WriteLine("");

            // * Remove(Int32) - It is used to return a new string in which all the characters in the current instance, beginning at a specified position and continuing through the last position, have been deleted.
            Console.WriteLine("Remove()");
            // * public string Remove(int startIndex)  
            string ys1 = "Hello C#";
            string ys2 = ys1.Remove(2); // He
            Console.WriteLine(ys2);
            Console.WriteLine("");

            // * public string Remove(int startIndex, int count)  
            Console.WriteLine("Remove(int startIndex, int count)");
            string xs3 = "abcdefghijk";
            string xs4 = xs3.Remove(4, 5);  // Remove: int count (5) = [efghi]
            Console.WriteLine(xs4); // abcdjk
            Console.WriteLine("");

            // * Replace(String, String) - It is used to return a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
            Console.WriteLine("Replace(String, String)");
            string ws1 = "Hello F#";
            string ws2 = ws1.Replace('F', 'C');
            Console.WriteLine(ws2); // Hello C#
            Console.WriteLine("");

            // * Split(Char[]) - It is used to split a string into substrings that are based on the characters in an array.
            Console.WriteLine("Split()");
            string sa1 = "Hello C Sharp";
            string[] sa2 = sa1.Split(' ');
            foreach (string sa3 in sa2)
            {
                Console.WriteLine(sa3);
                // Hello
                // C
                // Sharp
            }
            Console.WriteLine("");

            // * StartsWith(String) - It is used to check whether the beginning of this string instance matches the specified string.
            Console.WriteLine("StartsWith()");
            string sb1 = "Hello C Sharp";
            bool bb1 = sb1.StartsWith("h"); // False
            bool bb2 = sb1.StartsWith("H"); // True
            Console.WriteLine(bb1);
            Console.WriteLine(bb2);
            Console.WriteLine("");

            // * Substring(Int32) - It is used to retrieve a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
            Console.WriteLine("Substring(int startIndex)");
            string s1 = "Hello C Sharp";
            string s2 = s1.Substring(6); // return "C Sharp" = ( INDEX + 1 ) =>  ( 5 + 1 ) =>  (6)
            Console.WriteLine(s2); // C Sharp
            Console.WriteLine("");

            // * ToLower() - It is used to convert String into lowercase.
            Console.WriteLine("ToLower()");
            string sd1 = "HELLO C#";
            string sd2 = sd1.ToLower(); // hello c#
            Console.WriteLine(sd2);
            Console.WriteLine("");

            // * ToString() - It is used to return instance of String.
            Console.WriteLine("ToString()");
            string se1 = "Hello C#";
            int a = 123;
            string se2 = se1.ToString();
            string se3 = a.ToString();
            Console.WriteLine(se2); // "Hello C#"
            Console.WriteLine(se1.GetType()); // System.String
            Console.WriteLine("");
            Console.WriteLine(se3); // "123"
            Console.WriteLine(se3.GetType()); // System.String
            Console.WriteLine("");

            // * ToUpper() - It is used to convert String into uppercase.
            Console.WriteLine("ToUpper()");
            string t1 = "Hello C#";
            string t3 = t1.ToUpper(); // HELLO C#
            Console.WriteLine(t3);
            Console.WriteLine("");

            // * Trim() - It is used to remove all leading and trailing white-space characters from the current String object.
            Console.WriteLine("Trim()");
            string tr1 = "   Olá C#      ";
            string tr2 = tr1.Trim(); // Trim() - Remove all whitespace characters (left and right) from current STRING.
            Console.WriteLine(tr2);
            Console.WriteLine(tr1.Length); // Length = 15 ; tr1 = 15 characters
            Console.WriteLine(tr2.Length); // Length = 6 ; tr2 = 6 characters
            Console.WriteLine("");

            // * TrimEnd(Char[]) - It Is used to remove all trailing occurrences of a set of characters specified in an array from the current String object.
            Console.WriteLine("TrimEnd(Char[])");
            string str = "Hello C#";
            char[] cha = { '#' };
            string ste = str.TrimEnd(cha);
            Console.WriteLine(ste); // Hello C
            Console.WriteLine("");

            // * TrimStart(Char[]) - It is used to remove all leading occurrences of a set of characters specified in an array from the current String object.
            Console.WriteLine("TrimStart(Char[])");
            string str1 = "Hello C#";
            char[] c = { 'H' };
            string s = str1.TrimStart(c);
            Console.WriteLine(s); // ello C#
            Console.WriteLine("");

        }
    }
}
