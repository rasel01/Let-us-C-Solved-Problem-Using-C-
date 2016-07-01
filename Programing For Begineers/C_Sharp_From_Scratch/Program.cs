using System;
using System.Collections.Generic;

namespace C_Sharp_From_Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("new learning");
            //BooleanExpression be = new BooleanExpression();
            //be.BoolExpressMethod();
            //Loops lps = new Loops();
            //lps.WhileLoops();
            DataTypesConversion dc = new DataTypesConversion();
            //dc.CastMethod();
            //dc.ConvertMethod();
            //dc.ParseMethod();
            //dc.TryParseMethod();
           //dc.forEverLoop();
           // dc.ContinueBreakLoop();
            EnumConstants ec = new EnumConstants();
            //ec.EnumuseMethod();

            Arrays obj = new Arrays();
           // obj.RandomArray();
            //obj.FunctionsOfArray();

            ListClass listobj = new ListClass();
            //listobj.ListDeclare();

            //listobj.GetListOfItem();
            QueueClass queue = new QueueClass();
            //queue.DeclareQueue();
            //queue.AddRemoveValueQueue();
            SatckClass stack = new SatckClass();
            //stack.AddRemoveValueQueue();
            //stack.DeclareStack();


            DictionaryClass dictionary = new DictionaryClass();
            //dictionary.IntroDictionary();
            //dictionary.CreateDictionaryClass();


            
           LearnCustomeException lc = new LearnCustomeException();
          //  lc.CustomException();

           //var ci = new List<CustomInterface>();
           // Note note = new Note();
           // ci.Add(note);
           // DB db = new DB();
           // ci.Add(db);
           // ci.Add(db);
           // ci.Add(note);
           // ci.Add(db);
           // ci.Add(db);
           // ci.Add(note);

           // foreach (CustomInterface cusint in ci)
           // {
           //     cusint.write(null);
           //     Console.WriteLine(cusint.read());
                
                
           // }



           EmployeeClass employess = new EmployeeClass();
           // employess.UseAbsTrucedClassForMultiPurpose();

           var delegateclass = new DelegatesCalsses();
           var mp3 = new Mp3DelegatePlayer();
           var mp4 = new Mp4DelegatePlayer();

           var mp3Delegate = new DelegatesCalsses.DelegateMethod(mp3.playMp3Player);
           var mp4Delegate = new DelegatesCalsses.DelegateMethod(mp4.PlayMp4Player);

           delegateclass.RunDelegate(mp3Delegate);
           delegateclass.RunDelegate(mp4Delegate);
       

            Console.ReadKey();
        }
    }
}