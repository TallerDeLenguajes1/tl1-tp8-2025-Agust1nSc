using EspacioTareas;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();


for (int i = 0; i < 3; i++)
{
    int id = i + 1;
    Console.WriteLine("Ingrese la descripcion de la tarea");
    string descripcionTarea = Console.ReadLine() ?? "Sin Descripcion";

    Tarea NuevaTarea = new Tarea(id, descripcionTarea);
    tareasPendientes.Add(NuevaTarea);
}

int numero;
do
{
    Console.WriteLine("-----------Menu---------");
    Console.WriteLine("0_Salir");
    Console.WriteLine("1_Realizar Tareas");
    Console.WriteLine("2_Buscar tareas por descripcion");
    Console.WriteLine("3_Mostrar todas las tareas pendientes y realizadas");

    Console.WriteLine("Ingrese un numero para elegir la operacion");
    string opcion = Console.ReadLine() ?? "";

    bool control = int.TryParse(opcion, out numero);

    if (!control)
    {
        Console.WriteLine("Debe ingresar un número válido para seleccionar una opción.");
        continue;
    }

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el ID de la tarea que desea marcar como realizada:");
            string idInput = Console.ReadLine() ?? "";
            bool idValido = int.TryParse(idInput, out int idTarea);

            if (!idValido)
            {
                Console.WriteLine("ID inválido.");
                break;
            }

            for (int i = 0; i < tareasPendientes.Count; i++)
            {
                if (tareasPendientes[i].TareaID == idTarea)
                {
                    Tarea tarea = tareasPendientes[i];
                    tareasPendientes.RemoveAt(i);
                    tareasRealizadas.Add(tarea);
                }
            }
            break;
        case "2":
            Console.WriteLine("Ingrese la descripcion a buscar");
            string descripcion = Console.ReadLine() ?? "";
            BuscarTareasDescripcion(tareasPendientes, descripcion);
            break;
        case "3":
            MostrarTareas(tareasPendientes, tareasRealizadas);
            break;
    }

} while (numero != 0);

void BuscarTareasDescripcion(List<Tarea> tareasPendientes, string descripcion)
{
    foreach (Tarea tarea in tareasPendientes)
    {
        if (tarea.Descripcion == descripcion)
        {
            Console.WriteLine("Tarea encontrada en tareas pendientes");
            Console.WriteLine("Id:" + tarea.TareaID);
            Console.WriteLine("Descripcion:" + tarea.Descripcion);
            Console.WriteLine("Duracion:" + tarea.Duracion);
        }
    }
}

void MostrarTareas(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
{
    foreach (Tarea tareasPendientesAux in tareasPendientes)
    {
        Console.WriteLine("Tarea encontrada en tareas pendientes");
        Console.WriteLine("Id:" + tareasPendientesAux.TareaID);
        Console.WriteLine("Descripcion:" + tareasPendientesAux.Descripcion);
        Console.WriteLine("Duracion:" + tareasPendientesAux.Duracion);
    }

     foreach (Tarea tareasRealizadasAux in tareasRealizadas)
    {
        Console.WriteLine("Tarea encontrada en tareas realizadas");
        Console.WriteLine("Id:" + tareasRealizadasAux.TareaID);
        Console.WriteLine("Descripcion:" + tareasRealizadasAux.Descripcion);
        Console.WriteLine("Duracion:" + tareasRealizadasAux.Duracion);
    }
}