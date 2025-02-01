
//using System;
//using System.Collections;


//namespace ConsoleApp1WiproTraining
//{
//    internal class CollectionHashTable
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();
//            ht.Add("a", 1);
//            ht.Add("b", 7);
//            ht.Add("c", 89);
//            ht.Add("d", 43);
//            ht.Add("e", 23);
//            Console.WriteLine("all the keys : ");
//            foreach (string k in ht.Keys) {
//            Console.WriteLine(k);
//            }
//            Console.WriteLine("for all the values : ");
//            foreach (int k in ht.Values) { Console.WriteLine(k); }
//            Console.WriteLine("for all the key and value");
//            foreach (DictionaryEntry s in ht) { 
//            Console.WriteLine(s.Key + " " + s.Value);
//            }
//            // to print the first key
//            foreach(var key in ht.Keys) { Console.WriteLine( (string)key); break; }

//            //iterate through key to find one particular key

//            string searchkey = "e";
//            foreach (var key in ht.Keys)
//            {
//                if ((string)key == searchkey)
//                {

//                    Console.WriteLine("found key : " + key);
//                    break;
//                }
//            }

//        }
//    }
//}
