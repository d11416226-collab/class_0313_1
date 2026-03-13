namespace class_0313_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a, b, c;
                a = 15;
                b = 5;
                c = a / b;


                string[] names = new string[5];
                string id = names[4];

                if(b > 10)
                {
                    throw new ArithmeticException("B大於10");
                }

                if (a > 10)
                {
                    throw new MyExce("A大於10");
                }


            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Erro1");
                Console.WriteLine(ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro2");
                Console.WriteLine(ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erro3");
                Console.WriteLine(ex.ToString());
            }
            catch (MyExce ex)
            {
                Console.WriteLine("Erro4");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("無論跑什麼都執行");

            }




        }
    }
}
