using Control;
using Model;




namespace View
{
    public class View

    {
        static void Main(string[] args)
        {
            Controller controller = Controller.GetInstance();

            Console.WriteLine("Bienvenido a la maquina expendora");
            string input_cliente = "";
            do
            {
                Console.WriteLine("Ingrese si es cliente o proveedor: [C] o [P]");

                input_cliente = Console.ReadLine();


                if (input_cliente == "C" || input_cliente == "P")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor correcto");
                }

            } while (true);

            Console.WriteLine("Estos son nuestros productos:");

            Action<string> print = (texto) => Console.WriteLine(texto);

            foreach (Consumable producto in controller.Product_List)
            {
                print(producto.ToString());
            }

            Queue<int> billetes = new Queue<int>();


            if (input_cliente == "C")
            {
                Consumable producto_escogido = null;

                while (true)
                {
                    int total_cash = controller.enqueue_cash();

                    Console.WriteLine("El total de dinero ingresado es : " + total_cash);

                    controller.enqueue_cash();

                    Console.WriteLine("Seleccione uno de los productos indicando su nombre. Si desea ingresar mas billes ,escriba [B]");

                    string input_seleccion = Console.ReadLine();

                    if(input_seleccion == "B")
                    {
                        continue;
                    }
                    foreach (Consumable producto in controller.Product_List)
                    {
                        if(producto.Name == input_seleccion)
                        {
                            producto_escogido = producto;
                            break;
                        }
                    }
                    if (producto_escogido != null)
                    {
                        break;
                    }
                }
               Console.WriteLine("La devuelta es :" + controller.cashback_algorithm(producto_escogido));
            }
            else if (input_cliente == "P")
            {
                Console.WriteLine("Seleccione que producto desea surtir");

                string input_seleccion = Console.ReadLine();


                // Ingresar cantidad de producto a surtir ....
            }


        }
    }
}
