
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chatbox
{
    public class PlayBook
    {
        public int Rate { get; set; }
        public string[] CheckValue { get; set; }
        public string AnswerValue { get; set; }

        public PlayBook(int rate, string[] checkValue, string answerValue)
        {
            // pass the input value to property
            Rate = rate;
            CheckValue = checkValue;
            AnswerValue = answerValue;


        }
    }

    public class Bot
    {
        //private Dictionary<int, string> _playbook { get; set; }
        //public Dictionary<int, string[]> _checkbook { get; set; }
        //rivate Dictionary<int, int> _scorebook { get; set; }
        //public int currentCount { get; set; }
        //public int MaxKey { get; set; }
        public List<PlayBook> playbook { get; set; }
        public int CurrentCount { get; set; }
        public int MaxCount { get; set; }



        public Bot()// create the initial dictionary for play book

        {
            playbook = new List<PlayBook>();

            string[] check0 = { };
            string[] check1 = { };
            string[] check2 = { "age", "old", "old", "age", "are", "you", "your" };
            string[] check3 = { "How", "are", "you", "is", "going" };
            string[] check4 = { "can", "do", "you", "help", "me" };
            string[] check5 = { "robot", "bot", "you", "chatbot", "robot", "bot" };
            string[] check6 = { "live", "where", "spot", "where", "are", "you", "your" };
            string[] check7 = { "what", "your", "Major", "is", "Major" };
            string[] check8 = { "what", "is", "today", "date", "date" };


            playbook.Add(new PlayBook(0, check0, "What did you just said ?"));
            playbook.Add(new PlayBook(0, check1, "What did you just said ?"));
            playbook.Add(new PlayBook(0, check2, "I am 12 years old"));
            playbook.Add(new PlayBook(0, check3, "I am good!"));
            playbook.Add(new PlayBook(0, check4, "Sure thing!"));
            playbook.Add(new PlayBook(0, check5, "If you can not tell, does it matter?"));
            playbook.Add(new PlayBook(0, check6, "I live in virtual machine!"));
            playbook.Add(new PlayBook(0, check7, "My major is Software Development"));
            playbook.Add(new PlayBook(0, check8, "Today is 3/Nov/2021" + DateTime.Now));

        }

        // Step 1: Read user input method
        public List<string> Read(string text)                             // read user input
        {
            List<string> Keyword = text.Split(',', ' ').ToList();

            return Keyword;
        }

        // Step 2: Rating based on input string, return select index
        public int Rating(List<string> KeyWord)                           // rate the inpout
        {

            MaxCount = 0;

            for (int j = 0; j < playbook.Count; j++)                      // for each play book
            {
                playbook[j].Rate = 0;
                CurrentCount = 0;
                for (int i = 0; i < KeyWord.Count; i++)                   // for each key word 
                {
                    foreach (var item in playbook[j].CheckValue)          // for each checkbook key [j]
                    {
                        if (item == KeyWord[i])                           // check if keyword[i] contains checkbook [j]
                        {
                            CurrentCount += 1;
                        }
                        else
                        {
                            playbook[0].Rate = 1;                        // set defult as 1 in case no match / expection value is changeable
                        }
                    }
                    playbook[j].Rate = CurrentCount;
                }
                if (CurrentCount > MaxCount)
                {
                    MaxCount = CurrentCount;
                } // set max value


            }
            /*
            
            Console.WriteLine(playbook.Count + " of playbook");
            Console.WriteLine("Current Count foro bject 1 is :" + playbook[0].Rate);
            Console.WriteLine("Current Count foro bject 1 is :" + playbook[1].Rate);
            Console.WriteLine("Current Count foro bject 1 is :" + playbook[2].Rate);
            Console.WriteLine("Current Count foro bject 1 is :" + playbook[3].Rate);
            Console.WriteLine("max is"+ MaxCount);
            */

            for (int i = 0; i < 9; i++)
            {
                //   Console.WriteLine("i is:" + playbook[i].Rate + playbook[i].CheckValue[1], playbook[i].AnswerValue);
                if (playbook[i].Rate == MaxCount)
                {
                    //   Console.WriteLine("the return key inside is :"+ i);
                    return i;

                }

            }
            return 0; // if no value check, return defualt
            //Console.WriteLine("why return 0 here");
        }


        // Step 3: display answer based on rating index
        public string Speak(int i) // take rating and give respound
        {
            string answer = playbook[i].AnswerValue;
            return answer;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var bot = new Bot(); // create the instance of the bot

            do
            {
                Console.WriteLine("Hi, my name is ben, How are you?");   //(Key word: age, help, bot, location, date, major, going)
                string answer = Console.ReadLine();                       // recive user input

                List<string> key = bot.Read(answer);                      // store key word into list

                int result = bot.Rating(key);                             // rate the best match

                // Console.WriteLine("the return kay is:", result);

                string botAnswer = bot.Speak(result);                     // fitch answer by rate key

                Console.WriteLine(botAnswer);

            } while (Console.ReadLine() != "end");




        }
    }
}

