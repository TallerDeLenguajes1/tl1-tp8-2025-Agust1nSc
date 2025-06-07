namespace EspacioTareas
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; } // Validar que esté entre 10 y 100.

        // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario.

        public Tarea(int id, string descripcion)
        {
            TareaID = id;
            Descripcion = descripcion;
            Duracion = ValidarDuracion(); 
        }

        private int ValidarDuracion()
        {
            int duracionTemporal = 0;
            bool esValido = false;

            while (!esValido)
            {

                Console.WriteLine("Ingrese una duracion entre 10 y 100");

                string numero = Console.ReadLine() ?? "";

                bool control = int.TryParse(numero, out duracionTemporal);

                if (!control)
                {
                    Console.WriteLine("Debe ingresar un número válido para seleccionar una opción.");
                    continue;
                }

                if (duracionTemporal < 10 || duracionTemporal > 100)
                {
                    Console.WriteLine("Debe ingresar una duracion valida.");
                    continue;
                }

                esValido = true;
            }
            Duracion = duracionTemporal;
            return Duracion;
        }
    }
}