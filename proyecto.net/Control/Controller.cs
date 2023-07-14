
using Model;


namespace Control
{
    public sealed class Controller
    {

        public List<Consumable> Product_List { get; set; }

        public Queue<int> Billetes { get; set; }
        private Controller()
        {

            Product_List = new List<Consumable>();

            Product_List.Add(new Consumable("pepsi", 2000, 20));
            Product_List.Add(new Consumable("Coca Cola", 2000, 15));
            Product_List.Add(new Consumable("papitas", 1500, 20));
            Product_List.Add(new Consumable("choco ramo", 2000, 7));

            Billetes = new Queue<int>();
        }

        private static Controller _instance;

        public static Controller GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Controller();
            }

            return _instance;
        }

        public void enqueue_cash() {

            {
                Console.WriteLine("Ingrese billetes consecutivamente. Ingrese solo billetes de denominacion de peso colombiano como numeros enteros. Si no desea ingresar mas billetes, deje el campo vacio y presione ENTER");


                bool ingresar_billete = true;

                while (ingresar_billete)
                {
                    string input_usuario = Console.ReadLine();

                    if (input_usuario == "" && Billetes.Count != 0)
                    {
                        ingresar_billete = false;
                    }
                    else if (input_usuario == "" && Billetes.Count == 0)
                    {
                        Console.WriteLine("Ingrese por lo menos un billete");
                    }
                    else
                    {
                        Billetes.Enqueue(Convert.ToInt32(input_usuario));
                    }

                }
                int total_billetes = 0;

                foreach (int billete in Billetes)
                {
                    total_billetes += billete;
                }
                return total_billetes;
            }



            public int cashback_algorithm(Consumable product)
            {

                return 0;
            }
        }
    }
}

         

