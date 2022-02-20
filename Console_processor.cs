using System;
namespace Ikililerin_Toplami{
    public static class Console_processor{
        static List<string> input_list = new List<string>();
        public static List<string> input(){
            string valid_chars = "0123456789 ";
             string input_s = "";
            try_input();
            void try_input(){
                Console.WriteLine("sayıları giriniz.");
                input_s = Console.ReadLine();
                input_s =  input_s.Trim();
                if (input_s == "" ) {Console.WriteLine("hiçbir veri girmediniz."); try_input();}
                int counter = 0;
                foreach (char i in input_s)
                {
                    foreach (var valid_char in valid_chars)
                    {
                        if (i == valid_char){counter ++ ;}
                    }
                    
                }
                if (counter != input_s.Length) {Console.WriteLine("sadece sayı girmelisiniz"); try_input();}
            }
                
            input_list = input_s.Split(' ').ToList();

            return input_list;
        }
    }
}