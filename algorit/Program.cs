using System;

namespace giris_algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Console.WriteLine("xais edirik bir reqem yazin");
            // int say1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("xais edirik ikinci reqem daxil edin");
            // int say2 = int.Parse(Console.ReadLine());
            // int vurmacavab = 0;
            //  for (int i = 0; i < say1; i++)
            //  {
            // vurmacavab += say2;

            // }
            // Console.WriteLine($"{say1} x {say2} = {vurmacavab}");
            #endregion
            #region 
            //iki ededin toplamaq, readline string oldugu ucun parse metodu ile int e cevirdik. try catchla yazdiq cunki bildiris versin stringle daxil etmesin int le daxil etsin deye.
            //try
            // {
            // Console.WriteLine("xais edirik bir reqem daxil edin");
            // int say1=int.Parse(Console.ReadLine());
            // Console.WriteLine("xais edirik 2 ci reqemi secin");
            // int say2 = int.Parse(Console.ReadLine());
            // int cavab = say1 + say2;
            // Console.WriteLine("Netice");
            // Console.WriteLine(cavab);
            //}
            //catch 
            //{

            // Console.WriteLine("xais edirik Reqem daxil edin");
            // }
            #endregion
            #region
            // iki ededin kvadratinin cemini hesablamaq.
            // Console.WriteLine("xais edirik reqem daxil edin");
            // int num1 = int.Parse( Console.ReadLine());
            //  Console.WriteLine("xais ediri reqem daxil edin");
            //  int num2 = int.Parse(Console.ReadLine());
            // int cavab = num1 * num1 + num2 * num2;
            // Console.WriteLine("Netice");
            // Console.WriteLine(cavab);
            #endregion
            #region
            //iki ededin kvadatinin cemini yazin. asan usul.
            //Math.Pow riyaziyatda istifade olunur yeni riyazi hesablamalar falan, Math.Pow(2,3) yeni 2 nin ustu 3
            //Console.WriteLine("bir ve ikinci reqemi yazin");
            // double cavab= Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2); // double istifade etdik cunki her iki ededin iki qat cavabinin cemi idi 
            // Console.WriteLine(cavab); 

            // ve daha asan tek setirlik usulu.
            // Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2)); //budur
            #endregion
            #region
            // 1 den 10 qeder olan ededlerin kubunun cemini hesablayin. 
            // double netice = 0;
            // for (int i = 1; i <= 10; i++)
            // {
            // netice += i * i * i; //bele yazmagdansa
            //netice+=Math.Pow(i, 3); // bele yaz.              
            // Console.WriteLine(netice); // bu bir bir cavablari cixarib gosterecek sira sira,

            // }
            // Console.WriteLine(netice);

            // Bu ise While usulu iledir.
            // double netice = 0;
            // int saygac = 1;
            //  while (saygac<=10)
            //  {

            //   netice += Math.Pow(saygac, 3);     
            //// if (saygac == 10) break;             bu qayda ilede  olar.
            // saygac++;

            // }
            // Console.WriteLine(netice);
            #endregion
            #region
            //vurma islemini while metoduyla yaziriq, ve toplama kimi.
            // Console.WriteLine("xais edirik bir reqem daxil edin");
            // int say1 = int.Parse(Console.ReadLine());
            // int say2 = int.Parse(Console.ReadLine());
            // int saygac = say2;
            // int cavab = 0;
            // while (saygac>0)
            // {
            // cavab += say1;
            // saygac--;
            // }
            // Console.WriteLine($"{say1} X {say2} = {cavab}");

            // 6ci regionun 2 cisi.
            //vurma usuluynan ikinci bir fuksiada yazma
            // Console.WriteLine("bir reqem daxil edin");
            // int say1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("ikinci bir reqem daxil edin");
            // int say2 = int.Parse(Console.ReadLine());
            // Console.WriteLine(Toplam(say1, say2));
            #endregion
            #region
            //int saygac = 1;
            //double netice = 0;
            // string cavab = "";
            // while (saygac<=10)
            // {

            // netice += Math.Pow(saygac, 3);
            // if (saygac!=10)
            // {
            //    cavab += $"{saygac}kubu +";
            //  }
            //  else
            //  {
            //      cavab += $"{saygac}kubu ={netice}"; 
            //  }


            //  saygac++;

            // }
            // Console.WriteLine(cavab);
            #endregion
            #region
            //dogum tarixi qeyd eden adamin yasini hesablayan masin.
            //Console.WriteLine("xais ediik dogum tarixinizi qeyd edin");
            // DateTime dogumtarixi= Convert.ToDateTime(Console.ReadLine());
            // TimeSpan cavab = DateTime.Now - dogumtarixi;
            // Console.WriteLine(cavab.Days/365);
            #endregion
            #region
            // Console.WriteLine("xais edirik dogum tarixinizi qeyd edin");
            // DateTime dogumtarixi=DateTime.Parse(Console.ReadLine());
            // DateTime bugun = DateTime.Now;
            // int yas = bugun.Year - dogumtarixi.Year;
            //  if (dogumtarixi > bugun.AddYears(-yas)) ;
            //  yas--;
            // Console.WriteLine(yas);
            #endregion
            #region
            //Console.WriteLine("xais edirik dogum tarixinizi yazin.");
            // DateTime dogumtarixi = DateTime.Parse(Console.ReadLine());
            // int gun = (DateTime.Now - dogumtarixi).Days;
            //  int yas = gun / 365;
            // int qalan = gun % 365;
            // Console.WriteLine($"{yas} | {yas + 1} yasina qalan gun sayisi | { 365 +(yas * 1/4)-qalan}");
            #endregion
            #region
            //Console.WriteLine("xais edirik bir reqem yazin"); // girilen reqemin faktorial hesablama eden uygulama. faktorial meseelen 5reqemini 5/4/3/2/1 bele siraynan 5*4 cavabi *3 *2*1 cavabi alir.
            //int say = int.Parse(Console.ReadLine());
            // int cavab = 1;
            // for (int i = say; i > 0; i--)
            // {
            //     cavab *= i;           
            //  }
            // Console.WriteLine(cavab);

            // Console.WriteLine("xais edirik bir reqem yazin");
            //  int say = int.Parse(Console.ReadLine());
            // int cavab = 1;
            // do
            // {
            //  if (say == 0) break;
            // {
            //   cavab *= say;
            //  say--;
            // }

            // } while (true); Console.WriteLine(cavab);

            //3 cu faktorialida while dongusuyle edek.
            //Console.WriteLine("xais edirik bir reqem qeyd edin.");
            // int say = int.Parse(Console.ReadLine());
            // int cavab = 1;
            // while (say>0)
            // {
            //  cavab *= say;
            //  say--;
            // }
            // Console.WriteLine(cavab);

            //Console.WriteLine("xais edirik bir reqem yazin");
            // int say = int.Parse(Console.ReadLine());
            // int cavab = 1;
            // string _cavab = "";
            // while (say>0)
            // {
            //   cavab *= say;
            // if (say != 1)
            // {
            //  _cavab += $"{say } x ";
            //  }
            //  else
            //   _cavab += $"{say}={cavab}";
            // say--;

            // }
            // Console.WriteLine(_cavab);

            #endregion
            #region
            /*   //toplama usulu
            Console.WriteLine("Xais edirik bir reqem qeyd edin");
            int say1=int.Parse(Console.ReadLine());
            Console.WriteLine("Xais edirik ikinci bir reqem qeyd edin");
            int say2 = int.Parse(Console.ReadLine());
            int cavab = say1 + say2;
            Console.WriteLine("Netice");
            Console.WriteLine(cavab);
            */
            // isdifadecinin qeyd etdiyi reqemlerin kvadratini hesablayan uygulama
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik 2 ci reqemi daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int kvadrat = say1 * say1 + say2 * say2;
            Console.WriteLine("netice");
            Console.WriteLine(kvadrat);
            */
            // kvadrat usulunu Math.pow la yazmaq
            /*
            Console.WriteLine("xais edirik reqemleri daxil edin 2 dene");
           double say1 = Math.Pow(int.Parse(Console.ReadLine()),2);
            double say2 = Math.Pow(int.Parse(Console.ReadLine()), 2);
            double netice = say1 + say2;
            Console.WriteLine(netice);
            */

            // ucuncu qaydada tek setrde yazaq
            /*
            Console.WriteLine("xais edirik iki eded qeyd edin");
          //  //double netice = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
          //  // Console.WriteLine(netice);
            Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2)); // tek setr bele
           */
            // 1 den 10 a qeder olan ededlerin kubunun cemini yazan uygulama'
            /*
            Console.WriteLine("xos gelmisiniz");
           double cavab = 0;
            for (int i = 0; i < 11; i++)
            {

                cavab += Math.Pow(i,3);
            }
            Console.WriteLine(cavab);
            */

            //while dongusuyle yazmaq'
            /*
                        Console.WriteLine("xos gelmisiniz");
                        double netice = 0;
                        int sayim = 1;
                        while (sayim<=10)
                        {
                            netice += Math.Pow(sayim, 3);
                            sayim++;
                            //-- if (sayim==10)
                           //-- {
                             //--   break;
                          //--  }
                           //-- sayim++;

                        }
                        Console.WriteLine(netice); 
                        */
            // 1-10 reqemlerin kubunun cmei do/while
            /* Console.WriteLine("hello");
             double cem = 0;
             int say = 1;
             do
             {
                 cem += Math.Pow(say, 3);
                 say++;
             } while (say<=10);
             Console.WriteLine(cem);
            */

            //buda if nen olan
            /*
            Console.WriteLine("hello");
            double cem = 0;
            int say = 1;
            do
            {
                cem += Math.Pow(say, 3);
                
                if (say == 10) break;
                say++;
                              
            } while (true);
            Console.WriteLine(cem);
            */

            // 1-10 a qeder ededlerin kubunun cemini ekranda gostermek,
            /*
            double netice = 0;
            string cavab = "";
            for (int i = 0; i < 11; i++)
            {
                netice += Math.Pow(i, 3);


                if (i!=10)
                {
                    cavab += $"{i}^ +";
                } else
                cavab += $"{i}^ ={netice}";  
                
                
                
            }
            Console.WriteLine(cavab);
            */
            // while dongusuyle yazaq
            /*
            double netice = 0;
            int say = 1;
            string cavab = "";
            while (say<=10)
            {
                
                netice += Math.Pow(say, 3);
                
                
                if (say!=10 )
                {
                    
                    cavab += $"{say}^+";
                }
                
                    
                else cavab += $"{say}^={netice}";
                
                say++;

            }
            Console.WriteLine(cavab);
            */

            //dogum tarixi hesablayan uygulama
            /*
            Console.WriteLine("xais edirik dogum tarixinizi qeyd edin");
            DateTime dogumtarixi = DateTime.Parse(Console.ReadLine());
            int yas = (DateTime.Now - dogumtarixi).Days;
            int il = yas / 365;
            int qalan = yas % 365;
            Console.WriteLine($"sizin yasiniz {il} | {il+1} e qalan gunleriniz {365+(il*1/4)-qalan}");
            */
            /*
            Console.WriteLine("xais edirik dogum tarixini yazin");
            DateTime dogumtarixi = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;
            int yas = (bugun - dogumtarixi).Days;
            int ili = yas / 365;
           
            Console.WriteLine(ili);
            */

            //faktorial heesablama bir reqem secib vuraciyiq 
            /*
            Console.WriteLine("xais edirik bir reqem yazin");
            int reqem = int.Parse(Console.ReadLine());
            int cavab = 1;
            for (int i = reqem; i > 0; i--)
            {
                cavab *= i;
            }
            Console.WriteLine(cavab);
            */
            // 2 ci helli do/while
            /*
            Console.WriteLine("xais edirik bir reqem qeyd edin");
            int reqem = int.Parse(Console.ReadLine());
            int cavab = 1;
            string netice = "";
            do
            {
                cavab *= reqem;
                if (reqem!=1)
                {
                    netice += $"{reqem}X";
                }
                else
                {
                    netice += $"{reqem}={cavab}";
                }
                reqem--;
                if (reqem == 0) break;
                
            } while (true);
            Console.WriteLine(netice);
            */
            //inidide tekce while yazaq
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int reqem = int.Parse(Console.ReadLine());
            int cavab = 1;
            string netice = "";
            while (reqem>0)
            {
                cavab *= reqem;
                
                if (reqem != 1)
                {
                    netice += $"{reqem} X ";
                }
               
                else { netice += $"{reqem} = {cavab}"; }

                reqem--;
            }
            Console.WriteLine(netice);;
            */
            // faktorial do/whille yazilis.
            /*
            Console.WriteLine("Xais edirik bir reqem yazin faktorial vulurmagini hesabliyaq");
            int reqem = int.Parse(Console.ReadLine());
            int cavab = 1;
            do
            {
                cavab *= reqem;
                reqem--;
                if (reqem==0)
                {
                    break;
                }
            } while (true);
            Console.WriteLine(cavab);
            */
            #endregion


            //faktorial hesablama.
            /*
             Console.WriteLine("xais edirik reqem yazin");
              int say = int.Parse(Console.ReadLine());
              Console.WriteLine(Faktorial(say));
            */
        }
        /*
        static int Faktorial(int say)
        {
            if (say > 1)

                return say * Faktorial(--say);
            return say;
        } */
        //6 ci regionun 2 cisinin funksiasi
       // static int Toplam(int say1, int say2)      
	//{
           // if (say2>1)
            
              //  return say1 += Toplam(say1, --say2);
               // return say1;
             
	//}

    }
    }

