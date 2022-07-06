using System;

namespace Method_overload
{
    class Program
    {
        string[] Name = { "Коля", "Валера", "Витя" };

        public void Symbol()
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (i<Name.Length-1)
                {
          Console.Write(Name[i]+ ",");
                }else
                    Console.Write(Name[i] + "\n");

            }
            
        }
        public void Symbol(char S)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (i < Name.Length - 1)
                {
                    Console.Write(Name[i] + S.ToString() + " ");
                }
                else
                    Console.Write(Name[i] + "\n");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            

            p.Symbol();
            Console.WriteLine();
            p.Symbol('#');
            }
            
        }
    }

