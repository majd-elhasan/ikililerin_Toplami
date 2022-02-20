using System;
namespace Ikililerin_Toplami{
    public static class MainClass{
        static void Main(string[] args){
            List<string> input_list = Console_processor.input();
            if (input_list.Count % 2 == 1) input_list.Add("0");
            List<string> result_list = new List<string>();
            for (int i = 0;i< input_list.Count ; i++)
            {
                int result = 0;
                if(i % 2 == 0) {
                    if(input_list[i] == input_list[i+1]){
                        result =(Convert.ToInt32( input_list[i]) + Convert.ToInt32(input_list[i+1])) 
                        * (Convert.ToInt32( input_list[i]) + Convert.ToInt32(input_list[i+1]));
                    }
                    else {
                        result = Convert.ToInt32( input_list[i]) + Convert.ToInt32(input_list[i+1]);
                    }
                    result_list.Add(result.ToString());
                }
            }
            Console.WriteLine("______Sonuç____ ↓");
            foreach (var item in result_list)
            {
                Console.Write(item + " ");
            }
            
            
        }
    }
}