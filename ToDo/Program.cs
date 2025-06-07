using EspacioTareas;

List<Tarea> tareasPendientes = new List<Tarea>();

for (int i = 0; i < 3; i++)
{
    int id = i + 1;
    Console.WriteLine("Ingrese la descripcion de la tarea");
    string descripcionTarea = Console.ReadLine() ?? "Sin Descripcion";

    Tarea NuevaTarea = new Tarea(id, descripcionTarea);
    tareasPendientes.Add(NuevaTarea); 
}


