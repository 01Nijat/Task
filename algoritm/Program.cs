using System;

namespace algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int cavab = 0;
            //int saygac = say2;
            for (int i = 0; i < say2; i++)
            {
                cavab += say1;

            }
            Console.WriteLine($"{say1} x {say2}={cavab}");
            */
            //2 ci variant
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int saygac = say2;
            int cavab = 0;
            do
            {
                cavab += say1;
                saygac--;
            } while (saygac>0);
            Console.WriteLine($"{say1} x {say2} = {cavab}");
            */
            //--3cu variant
            /*
            Console.WriteLine("reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int cavab = 0;
            int saygac = say2;
            while (saygac>0)
            {
                cavab += say1;
                saygac--;
            }
            Console.WriteLine($"{say1} x {say2} = {cavab}");
            */
            // 4 cu qayda recorsiv funksia ile
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            Console.WriteLine(toplama(say1,say2));
            */
            #endregion
            #region
            //bolme usulunu cixma ile yazaq foreachla
            /*
            Console.WriteLine("reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int _say1 = say1;
            int cavab = 0;
            int qaliq = 0;

            for (int i = 0; i < _say1; i++)
            {
                _say1 -= say2;
                cavab++;
                if (_say1<say2)
                {
                    qaliq = _say1;
                }
            }
            Console.WriteLine($"{say1} / {say2} = {cavab} | qaliq {qaliq}");
            */
            // while usulu ile
            /*
            Console.WriteLine("xais edirik reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("xais edirik reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int _say1 = say1;
            int cavab = 0;
            int qaliq = 0;
            while (_say1>say2)
            {
                _say1 -= say2;
                cavab++;
                if (_say1<say2)
                {
                    qaliq = _say1;
                }
            }
            Console.WriteLine($"{say1} / {say2} = {cavab} | qaliq {qaliq}");
            */
            // do while ile usulu
            /*
            Console.WriteLine("reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int _say1 = say1;
            int cavab = 0;
            int qalan = 0;
            do
            {
                _say1 -= say2;
                cavab++;
                if (_say1<say2)
                {
                    qalan = _say1;
                }
            } while (_say1>say2);
            Console.WriteLine($"{say1} / {say2} = {cavab} | {qalan}");
            */
            // recoursive usulu ile;
            /*
            Console.WriteLine("reqem daxil edin");
            int say1 = int.Parse(Console.ReadLine());
            Console.WriteLine("reqem daxil edin");
            int say2 = int.Parse(Console.ReadLine());
            int cavab = bolme(say1, say2);
            int qaliq = qalan(say1, say2);
            Console.WriteLine($"{say1} / {say2} = {cavab} ve qaliq | {qaliq}");

            */
            #endregion
            #region
            // string metodu ile reqemin mertebesini hesablayaq.
            /*
            Console.WriteLine("xais edirik reqem daxil edin biz mertebesini hesablayaq");
            int say = int.Parse(Console.ReadLine());
            Console.WriteLine($"{say} sayisinin mertebesi--{say.ToString().Length}");
            */
            /*
            Console.WriteLine("xais edirik yazacaginiz reqemi qeyd edin mertebesini yoxluyaq");
            int say = int.Parse(Console.ReadLine());
            int _say = say;
            int mertebesay = 0;
            for (int i = 0; i < _say; i++)
            {
              _say = _say / 10;
                mertebesay++;
            }
            mertebesay++;
            Console.WriteLine($"{say} sayin mertebesi  {mertebesay}");
            */
            //while usulu ile yazaq
            /*
            Console.WriteLine("reqem qeyd edin mertebesini deyek");
            int say=int.Parse(Console.ReadLine());
            int _say = say;
            int mertebe = 0;
            while (_say>=10)
            {
                _say = _say / 10;
                mertebe++;
            }
            mertebe++;
            Console.WriteLine($"{say} sayinin mertebe sayi budur---{mertebe}");
            */
            //do whille yazaq
            /*
            Console.WriteLine("xais edirik bir reqem daxil edin biz mertebesini yazaq");
            int say=int.Parse(Console.ReadLine());
            int _say = say;
            int mertebe = 0;
            do
            {
                if (_say < 10) break;
                _say = _say / 10;
                mertebe++;
            } while (true);
            mertebe++;
            Console.WriteLine($"{say} sayinin mertebesi {mertebe}"); */

            /*
            do
            {
                _say = _say / 10;
                mertebe++;
            } while (_say>=10);
            mertebe++;
            Console.WriteLine($"{say} sayinin mertebe sayi ---{mertebe}");
            */
            //recousiv usula yazaq: 
            /*
            Console.WriteLine("xais edirik reqem daxil edin mertebesini hesablayaq");
           int say=int.Parse(Console.ReadLine());
            int cvb = mertebe( say);
            Console.WriteLine($"{say} sayinin mertebesi {cvb}");
            */

            #endregion
            #region
            // 3 mertebeli sayinin kublarinin ceminin beraberliyi yoxlamaq
            Console.WriteLine("xais edirik bir reqem daxil edin");
            int say = int.Parse(Console.ReadLine());
            // Console.WriteLine(Mertebe(say));
            if (Mertebe(say))
            {
                int _say = say;
                double kubcem = 0;
                while (true)
                {
                    int mertebe = _say % 10;
                    _say /= 10;
                    kubcem += Math.Pow(mertebe, 3);
                    if (_say<10)
                    {
                        mertebe = _say % 10;
                        kubcem += Math.Pow(mertebe, 3);
                        break;
                    }
                }
                if (kubcem==say)
                {
                    Console.WriteLine("eynidir");
                }
                else Console.WriteLine("eyni deyil");
            }
            else Console.WriteLine("xais edirik ucmertebeli qeyd edin");
        }
            #endregion

            #region
            // 2 ci regionun 
            /*
            static int bolme(int say1, int say2)
            {
                say1 -= say2;
                if (say1 >= say2)

                    return 1 + bolme(say1, say2);
                return 1;          
            }
            static int qalan(int say1, int say2)
            {
                say1 -= say2;
                if (say1 >= say2) 
                return  qalan(say1, say2);
                return say1;
            }
            */
            #endregion
            #region  
            //4 vu qaydanin recorsivi
            /*  
            static int toplama(int say1, int say2)
            {   if(say2>1)
                return say1 += toplama(say1, --say2);
                return say1;
            }  */
            #endregion
            #region
            //3 cu regionun axrincisi recorsiv mertebe.
            /*
            static int mertebe(int say)
            {
                say /= 10;
                if (say >= 10)
                    return 1 + mertebe(say);
                return 2;
            }
            */

            #endregion
            #region
      
                static bool Mertebe(int say)
        {
            int mertebesayi = 1;
            while (true)
            {
                if (say < 10)
                    break;
                say /= 10;
                mertebesayi++;
            }return mertebesayi == 3 ? true : false;
        }

            #endregion
        
    }  
}       

