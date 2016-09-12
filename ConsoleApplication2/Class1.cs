using ConsoleApplication2;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2prd_injinierija
{
    
    class Class1
    {
        static ConsoleKeyInfo info; // lietotaja ievads
        static bool parzimet = false;
        protected static int origCol;
        protected static int origRow;

        static void Main(string[] args)
        {
            //saraksta deklareshana
            List<Datorklase> inventars = new List<Datorklase>();
            int listItem=0; // izveleto sarakta elementa indekss
            Console.BufferHeight = Int16.MaxValue - 1;
           // int loop = 900000;
            int loop = 40;
            int i = 0;
            /*

             new Thread(() =>
             {
                 Thread.CurrentThread.IsBackground = true;       

            do
            {
                WriteAt("[#         ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[ #        ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[  #       ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[   #      ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[    #     ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[     #    ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[      #   ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[       #  ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[        # ]", 0, 0);
                Thread.Sleep(50);
                WriteAt("[         #]", 0, 0);
                Thread.Sleep(50);


            } while (i != loop);

            WriteAt("            ", 0, 0);
            Console.CursorVisible = false;
        }).Start();
            */

            for (i=0  ; i < loop; i++)
            {
                Datorklase rec1 = new Datorklase();
                rec1.kods = "kods" + i;
                rec1.nosaukums = "nos" + i;
                rec1.inventara_nr = "inv" + i;
                rec1.uzskaites_val = "uzsk" + i;
                rec1.iegades_val = "iegades_val" + i;
                // klases 1 ierakta pievienošana sarakstam
                inventars.Add(rec1);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            WriteAt("izdruka sarakstu " + "\t" + "[F1]", 80, 1);
            WriteAt("atvērt WIN formu " + "\t" + "[F5]", 80, 2);
            WriteAt("pievienot ierakstu " + "\t" + "[INSERT]", 80, 3);
            WriteAt("DZĒST ierakstu " + "\t" + "\t" + "[DELETE]", 80, 4);
            WriteAt("IZIET " + "\t" + "\t" + "[F3]", 80, 5);
            WriteAt("iezime ierakstu " + "\t" + "[space]", 80, 6);
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);

            info = Console.ReadKey();
            while (info.Key != ConsoleKey.F3)
            {
                int winPos = Console.WindowHeight;

                if (info.Key == ConsoleKey.F1 || parzimet==true)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    WriteAt("izdruka sarakstu " + "\t" + "[F1]", 80, 1);
                    WriteAt("atvērt WIN formu " + "\t" + "[F5]", 80, 2);
                    WriteAt("pievienot ierakstu " + "\t" + "[INSERT]", 80, 3);
                    WriteAt("DZĒST ierakstu " + "\t" + "\t" + "[DELETE]", 80, 4);
                    WriteAt("IZIET " + "\t" + "\t" + "[F3]", 80, 5);
                    WriteAt("iezime ierakstu " + "\t" + "[space]", 80, 6);
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 0);

                    parzimet = false;
                    int num = 1;
                    //tabula
                   

                    if (info.Key == ConsoleKey.Delete || info.Key == ConsoleKey.Insert || info.Key == ConsoleKey.F1 || info.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("{0,5} {1,10} {2,10} {3,10} {4,10}", "kods" + "\t", "nosaukums" + "\t", "inventara_nr" + "\t", "uzskaites_val" + "\t", "iegades_val" + "\t");
                        foreach (Datorklase s in inventars)
                        {
                            s.delete = false;
                            Console.WriteLine("  |" +num+ "|"+ s.kods + "\t"+ s.nosaukums + "\t"+ s.inventara_nr + "\t"+ s.uzskaites_val + "\t"+ s.iegades_val);
                            num++;
                        }
                        
                    }
                    /////////////defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#
                    ///////////tiek izdots paziņojums ja tiek veiktas darbibas ar tukšu sarakstu
                    ///////////if (inventars.Count() > 0)
                    //////////////// else Console.WriteLine("saraksts ir tukšs :/");
                    if (inventars.Count() > 0)
                    {
                        if (listItem < inventars.Count())
                            listItem = Menu(inventars, listItem); // noliek kursoru vietā kad izdzēš vai pievieno
                        else if ((listItem == inventars.Count))
                            listItem = Menu(inventars, --listItem);
                        else Menu(inventars, 0);

                        //Console.WriteLine(listItem);
                        Console.SetCursorPosition(0, 0);
                    }
                    else Console.WriteLine("saraksts ir tukšs :/");


                   
                               
                }
                /// /////////////defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#
                /////////////// tiek liksts atkartoti ievadit iegades un uzskaites vertibas ja tas korektas
                //////////////////while (!double.TryParse(rec.uzskaites_val, out X))
                /////////////////Console.WriteLine("ievadi skaitli, meģini vel!");
                if (info.Key == ConsoleKey.Insert)
                {
                    double X; //////glaba uzskaites un iegades vertiibas
                   
                    // klases mainīgo definešana #### 1 inventara ieraksts 1 rinda
                    Console.SetCursorPosition( 0, inventars.Count() + 2);                    
                    Datorklase rec = new Datorklase();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("kods: " + "\t" + "\t" );
                    Console.ForegroundColor = ConsoleColor.Green; 
                    rec.kods = Console.ReadLine(); //if (rec.kods=="") break;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("nosaukums: " + "\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    rec.nosaukums = Console.ReadLine();               
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("inventara_nr: " + "\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    rec.inventara_nr = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("uzskaites_val: " + "\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    rec.uzskaites_val = Console.ReadLine();
                    while (!double.TryParse(rec.uzskaites_val, out X))
                    {
                        Console.WriteLine("ievadi skaitli, meģini vel!");

                        rec.uzskaites_val = Console.ReadLine();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("iegades_val: " + "\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    rec.iegades_val = Console.ReadLine();
                    while (!double.TryParse(rec.iegades_val, out X))
                    {
                        Console.WriteLine("ievadi skaitli, meģini vel!");

                        rec.iegades_val = Console.ReadLine();
                    }                  
                    Console.ResetColor();
                    // klases 1 ierakta pievienošana sarakstam
                    inventars.Add(rec);
                    listItem = inventars.Count - 1;
                    parzimet = true;
                    Console.Clear();                  
                }


                if (info.Key == ConsoleKey.F5)
                {
                    Application.EnableVisualStyles();
                    if (inventars.Count > 0)
                    {
                        List<object> saraksts = inventars.Cast<object>().ToList();
                        Form1 forma = new Form1(saraksts);
                        Application.Run(forma);
                        // atgriez sarakstu no datagridview1
                        inventars = forma.sarakstsWin().Cast<Datorklase>().ToList();
                    }
                    else
                    {
                        inventars = new List<Datorklase>();
                        Datorklase rec = new Datorklase();
                        inventars.Add(rec);                       
                        List<object> saraksts = inventars.Cast<object>().ToList();
                        Form1 forma = new Form1(saraksts);
                        Application.Run(forma);
                        // atgriez sarakstu no datagridview1
                        inventars = forma.sarakstsWin().Cast<Datorklase>().ToList();
                    }
   
                    Console.Clear();
                    parzimet = true;
                    listItem = 0;
                }

                if (parzimet == false)
                    if (info.Key != ConsoleKey.F3) {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        WriteAt("izdruka sarakstu " + "\t" + "[F1]", 80, 1);
                        WriteAt("atvērt WIN formu " + "\t" + "[F5]", 80, 2);
                        WriteAt("pievienot ierakstu " + "\t" + "[INSERT]", 80, 3);
                        WriteAt("DZĒST ierakstu " + "\t" + "\t" + "[DELETE]", 80, 4);
                        WriteAt("IZIET " + "\t" + "\t" + "[F3]", 80, 5);
                        WriteAt("iezime ierakstu " + "\t" + "[space]", 80, 6);
                        Console.ResetColor();
                        Console.SetCursorPosition(0, 0);

                        info = Console.ReadKey();
                        
                    }
                
               
            }
            ///////////////////////////////////////////////////////////////////////////////////matrix


            Console.CursorVisible = false;
            int width, height;
            int[] y;
            int[] l;
            Initialize(out width, out height, out y, out l);
            int ms;

            var startTime = DateTime.UtcNow;
            while (DateTime.UtcNow - startTime < TimeSpan.FromSeconds(2))
            {
                DateTime t1 = DateTime.Now;
                MatrixStep(width, height, y, l);
                ms = 20 - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;

                if (ms > 0)
                    System.Threading.Thread.Sleep(ms);

                if (Console.KeyAvailable)
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        Initialize(out width, out height, out y, out l);
            }
            
        }

        static bool thistime = false;

        private static void MatrixStep(int width, int height, int[] y, int[] l)
        {
            int x;
            thistime = !thistime;

            for (x = 0; x < width; ++x)
            {
                if (x % 11 == 10)
                {
                    if (!thistime)
                        continue;

                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(x, inBoxY(y[x] - 2 - (l[x] / 40 * 2), height));
                    Console.Write(R);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.SetCursorPosition(x, y[x]);
                Console.Write(R);
                y[x] = inBoxY(y[x] + 1, height);
                Console.SetCursorPosition(x, inBoxY(y[x] - l[x], height));
                Console.Write(" ");
            }
        }

        private static void Initialize(out int width, out int height, out int[] y, out int[] l)
        {
            int h1;
            int h2 = (h1 = (height = Console.WindowHeight) / 2) / 2;
            width = Console.WindowWidth - 1;
            y = new int[width];
            l = new int[width];
            int x;
            Console.Clear();
            for (x = 0; x < width; ++x)
            {
                y[x] = r.Next(height);
                l[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
            }
        }

        static Random r = new Random();

        static char R
        {
            get
            {
                int t = r.Next(10);
                if (t <= 2)
                    return (char)('0' + r.Next(10));
                else if (t <= 4)
                    return (char)('a' + r.Next(27));
                else if (t <= 6)
                    return (char)('A' + r.Next(27));
                else
                    return (char)(r.Next(32, 255));
            }
        }

        public static int inBoxY(int n, int height)
        {
            n = n % height;
            if (n < 0)
                return n + height;
            else
                return n;

        }
        //////////////////////////////////////////////////////////////////////

        // metode ieraksta konsole "tekstu" x un y koordinates
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }


        static int Menu(List<Datorklase> inArray, int selectedItem2)
        {           
            bool loopComplete = false;
            int topOffset = Console.CursorTop;
            int bottomOffset = 0;
            int selectedItem = selectedItem2;
            int winPos = Console.WindowHeight;
            
            
            Console.CursorVisible = false;

            //this will resise the console if the amount of elements in the list are too big
            if ((inArray.Count) > Console.WindowHeight)
            {
                //throw new Exception("Too many items in the array to display");

            }

            /**
             * Drawing phase
             * */
            while (!loopComplete)
            {//This for loop prints the array out
                winPos = Console.WindowHeight;

                if (0 == selectedItem) WriteAt("  ", 0, inArray.Count);
                if (inArray.Count-1  == selectedItem) WriteAt("  ", 0, 1);

                
                if(selectedItem!=0) WriteAt("  ",0, selectedItem );               
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                WriteAt(">>", 0, selectedItem + 1);
                Console.ResetColor();
                WriteAt("  ",0, selectedItem +2 );
               
                bottomOffset = Console.CursorTop;

                info = Console.ReadKey(true); //read the keyboard
               

                switch (info.Key)
                { //react to input
                    case ConsoleKey.UpArrow:

                        if (selectedItem > 0 )
                        {
                            selectedItem--;
                        }
                        else {
                            selectedItem = (inArray.Count - 1);
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (selectedItem < (inArray.Count - 1))
                        {
                            selectedItem++;
                        }
                        else {
                            selectedItem = 0;
                        }
                        break;

                    case ConsoleKey.F5:
                        parzimet = true;
                        loopComplete = true;
                        break;

                    case ConsoleKey.F3:
                        loopComplete = true;

                        break;



                    case ConsoleKey.Spacebar:

                        //atdzime delete list
                        if (inArray.Count > 0)
                        {
                            var s = inArray[selectedItem];

                            if (s.delete == false)
                            {
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(0, selectedItem + 1);
                                Console.WriteLine("  |" + (selectedItem + 1) + "|" + s.kods + "\t" + s.nosaukums + "\t" + s.inventara_nr + "\t" + s.uzskaites_val + "\t" + s.iegades_val);
                                Console.ResetColor();
                                s.delete = true;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.SetCursorPosition(0, selectedItem + 1);
                                Console.WriteLine("  |" + (selectedItem + 1) + "|" + s.kods + "\t" + s.nosaukums + "\t" + s.inventara_nr + "\t" + s.uzskaites_val + "\t" + s.iegades_val);
                                Console.ResetColor();
                                s.delete = false;
                            }

                        }
                        else {
                           
                            Console.CursorVisible = false;
                        }


                        break;
                    case ConsoleKey.Insert:
                        loopComplete = true;
                        break;
                    case ConsoleKey.F1:
                        loopComplete = true;
                        Console.Clear();
                        parzimet = true;
                        break;

                    case ConsoleKey.Delete:
                            loopComplete = true;
                            Console.Clear();
                            foreach (Datorklase x in inArray)
                            {
                                if (x.delete == true)
                                {
                                    Console.WriteLine("  |  |" + x.kods + "\t" + x.nosaukums + "\t" + x.inventara_nr + "\t" + x.uzskaites_val + "\t" + x.iegades_val);
                                }
                            }
                            ConsoleKeyInfo cki;
                        /// /////////////defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#
                        ////////////////////pirms ieraksta/u dzēšanas lietotajam jaapstiprina dzēšana 
                        ///////////////////////Console.WriteLine(" -ieraksti tiks dzēsti, vai turpināt Y/N: ");
                        do
                        {
                                Console.WriteLine(" -ieraksti tiks dzēsti, vai turpināt Y/N:\n ");
                                Console.CursorVisible = true;
                                cki = Console.ReadKey();
                            
                                Console.CursorVisible = false;
                            } while (!((cki.Key == ConsoleKey.Y) || (cki.Key == ConsoleKey.N)));

                            if (cki.Key == ConsoleKey.Y)
                            {
                                Console.SetCursorPosition(0, 0);
                                foreach (Datorklase x in inArray)
                                {
                                    if (x.delete == true)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("  |  |" + x.kods + "\t" + x.nosaukums + "\t" + x.inventara_nr + "\t" + x.uzskaites_val + "\t" + x.iegades_val);
                                        Console.ResetColor();
                                        Thread.Sleep(100);
                                    }
                                }
                                inArray.RemoveAll(o => o.delete == true); // lambada expresion izdzēš iezīmetos

                            }
                            if (cki.Key == ConsoleKey.N)
                            {
                                Console.SetCursorPosition(0, 0);
                                foreach (Datorklase x in inArray)
                                {
                                    if (x.delete == true)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("  |  |" + x.kods + "\t" + x.nosaukums + "\t" + x.inventara_nr + "\t" + x.uzskaites_val + "\t" + x.iegades_val);
                                        Console.ResetColor();
                                        Thread.Sleep(100);
                                    }
                                }
                                inArray.RemoveAll(o => o.delete == true); // lambada expresion izdzēš iezīmetos

                            }



                            Console.Clear();
                            if (inArray.Count()>0) parzimet = true;                     
                       break;

                }
                //Reset the cursor to the top of the screen
                //Console.SetCursorPosition(0, topOffset);
            }
            //set the cursor just after the menu so that the program can continue after the menu
           // Console.SetCursorPosition(0, bottomOffset);

            Console.CursorVisible = true;
            return selectedItem;

            /////////////////////////////////////////////////////////////////////////////////////////

        }

    }

    /// <summary>
    /// /////////////defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#defensive#
    ////////////////tiek izveidota klase, kurai ir get un set lai iegutu, saglabatu ierakstu sarakstaa
    /// </summary>
    public class Datorklase // klase datorklases inventāra parametru ievadei
    {
        public string kods
        {
            get;
            set;
        }
        public string nosaukums
        {
            get;
            set;
        }
        public string inventara_nr
        {
            get;
            set;
        }
        public string uzskaites_val
        {
            get;
            set;
        }
        public string iegades_val
        {
            get;
            set;
        }
        public bool delete
        {
            get;
            set;
        }

        public Datorklase() { }

        public Datorklase(string kods, string nosaukums, string inventara_nr, string uzskaites_val, string iegades_val, bool delete) {
            this.kods = kods;
            this.nosaukums = nosaukums;
            this.inventara_nr = inventara_nr;
            this.uzskaites_val = uzskaites_val;
            this.iegades_val = iegades_val;
            this.delete = false;    // delete sarakstam
        }

    }
    /// <summary>
    /// menu consolei
    /// </summary>
    /// <param name="inArray"></param>
    /// <returns></returns>
  
}

