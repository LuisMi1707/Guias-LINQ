using IntroduccionLinq;

#region Introduccion 
/*
// Definición de un arreglo de strings llamado "palabras" que contiene una lista de palabras y números
string[] palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo", "serpiente", "123456789" };

// Mensaje inicial que se muestra en la consola, indicando el propósito del código
Console.WriteLine("Más de 5 letras");

// Creación de una lista vacía llamada "resultado" para almacenar las palabras que cumplen la condición
List<string> resultado = new List<string>();

// Bucle que recorre cada palabra en el arreglo "palabras"
foreach (string str in palabras) 
{
    // Si la longitud de la palabra es mayor a 5 caracteres, se agrega a la lista "resultado"
    if (str.Length > 5) 
    {
        resultado.Add(str);
    }
}

// Bucle que recorre la lista "resultado" y muestra en la consola las palabras que tienen más de 5 letras
foreach (var r in resultado) 
{
    Console.WriteLine(r);
}
*/
#endregion
#region utilizando Linq
/*
// Se imprime una línea de separación en la consola
Console.WriteLine("-----------------------------------------------------");

// Se utiliza LINQ para filtrar las palabras que tienen más de 8 letras
IEnumerable<string> list = from r in palabras 
                           where r.Length > 8 
                           select r;

// Bucle que recorre la lista "list" y muestra en la consola las palabras que cumplen la condición
foreach (var listado in list)
    Console.WriteLine(listado);

// Se imprime otra línea de separación en la consola
Console.WriteLine("-----------------------------------------------------");
*/
#endregion
#region ListaModelos
//Aquí se está creando una lista genérica llamada ListaCasas que almacenará objetos del tipo 
List<Casa> ListaCasas = new List<Casa>();

//Similar a la lista anterior, aquí se está creando una lista genérica llamada ListaHabitantes que almacenará objetos del tipo Habitante.
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion
#region listaCasa
ListaCasas.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion
#region ListaHabitante
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Bruno Diaz",
    Edad = 36,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 36,
    IdCasa = 1
});
#endregion
#region SentenciasLinQ
/*
// Filtrado de habitantes con edad mayor a 40 años usando LINQ
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40 // Condición: edad mayor a 40
                                   select ObjetoProvicional; // Selección de los habitantes que cumplen la condición

// Recorre la lista filtrada e imprime los datos de cada habitante mayor a 40 años
foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante()); // Imprime la información del habitante
}

// Operación de 'join' para unir la lista de habitantes con la lista de casas en "Gothan City"
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id // Unión por ID
                                         where objetoTemporalCasa.Ciudad == "Gothan City" // Filtra por la ciudad "Gothan City"
                                         select objetoTemporalHabitante; // Selecciona los habitantes que viven en "Gothan City"

// Imprime una línea de separación en la consola
Console.WriteLine("----------------------------------------------------------------------------------------------");

// Recorre la lista filtrada e imprime los datos de cada habitante que vive en "Gothan City"
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante()); // Imprime la información del habitante
}
*/
#endregion
#region FirsthAndFirsthOrDefault
/* Console.WriteLine("----------------------------------------------------------------------------------------------");
var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable
Console.WriteLine(primeraCasa.dameDatosCasa());

//aplicando una restriccion sin restricion lambda
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad >25);
Console.WriteLine(Habitante1.datosHabitante());

// Si no tenemos el elemento que buscamos entoences la sonsulta devolvera una exepcion esto detendra el codigo en su totalidad

//Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id >10 select vCasaTemp).First() ;
//Console.WriteLine(EdadError.dameDatosCasa());

Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirsthOrDedault == null ) {
    Console.WriteLine("No existe !No hay!");
    return;
}
Console.WriteLine("existe !Si existe!");
*/
#endregion
#region ElementAt
/*
// Obtiene el tercer elemento de la lista ListaCasas usando ElementAt (índice 2, ya que los índices comienzan en 0)
var terceraCasa = ListaCasas.ElementAt(2);
// Imprime la información de la tercera casa usando el método dameDatosCasa()
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

// Usa ElementAtOrDefault para obtener el cuarto elemento (índice 3) de ListaCasas, evitando errores si el índice está fuera de rango
var casaError = ListaCasas.ElementAtOrDefault(3);
// Verifica si el valor es diferente de null (si la casa existe) antes de intentar imprimir los datos
if (casaError != null)
{
    Console.WriteLine($"La cuarta casa es {casaError.dameDatosCasa()}");
}

// Usando LINQ para seleccionar todos los habitantes y luego obtener el tercer habitante (índice 2) con ElementAtOrDefault
var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
// Imprime la información del segundo habitante si existe
Console.WriteLine($"El tercer habitante es: {segundoHabitante.datosHabitante()}");
*/
#endregion
#region single
/*
try
{
    // Utiliza Single para encontrar un habitante cuya edad esté entre 40 y 70 años.
    // Single lanzará una excepción si no encuentra exactamente un elemento que cumpla la condición.
    var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad < 70);

    // Utiliza LINQ con Single para encontrar un habitante cuya edad sea mayor a 70 años.
    var habitante2 = (from obtem in ListaHabitantes
                      where obtem.Edad > 70
                      select obtem).Single();

    // Imprime los datos del habitante que tiene entre 40 y 70 años.
    Console.WriteLine($"Habitante con entre 40 y 70 años: {habitantes.datosHabitante()}");

    // Imprime los datos del habitante que tiene más de 70 años.
    Console.WriteLine($"Habitante con más de 70 años: {habitante2.datosHabitante()}");
}
catch (Exception)
{
    // Captura cualquier excepción que ocurra (como cuando no hay un único habitante que cumpla las condiciones)
    Console.WriteLine("Ocurrió un error.");
}
*/
#endregion
#region typeOf
/*
// Crea una lista de objetos de tipo Empleado que contiene un Medico y un Enfermero.
var listaEmpleados = new List<Empleado>() {
    new Medico() { nombre = "Jorge Casa" },
    new Enfermero() { nombre = "Raul Blanco" }
};

// Usa OfType para filtrar la lista y obtener solo los objetos que son del tipo Medico.
var medico = listaEmpleados.OfType<Medico>();

// Imprime el nombre del único objeto Medico en la lista, usando Single para asegurar que solo haya uno.
Console.WriteLine(medico.Single().nombre);
*/
#endregion
#region Last

// Utiliza Last para obtener el último objeto en ListaCasas que cumpla con la condición: Id > 1
Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
// Imprime los datos de la última casa que cumple con la condición
Console.WriteLine(ultimaCasa.dameDatosCasa());

// Imprime una línea de separación en la consola
Console.WriteLine("_____________________________________________________");

// Realiza una consulta LINQ para obtener el último habitante cuya edad sea mayor a 60 años
var h1 = (from objHabitante in ListaHabitantes
          where objHabitante.Edad > 60
          select objHabitante)
    .LastOrDefault();

// Verifica si h1 es null (no se encontró ningún habitante que cumpla la condición)
// Si es null, imprime un mensaje de error y termina la ejecución
if (h1 == null)
{
    Console.WriteLine("Algo falló");
    return;
}

// Imprime los datos del último habitante cuya edad es mayor a 60 años
Console.WriteLine(h1.datosHabitante());

#endregion
#region OrderBy

/*
   // Ordena la lista de habitantes por edad en orden ascendente usando OrderBy.
   // Luego imprime los datos de cada habitante en la lista ordenada.

var edadA = ListaHabitantes.OrderBy(x => x.Edad);
// Utiliza una consulta LINQ para ordenar la lista por edad en orden ascendente
var edadAC = from vt in ListaHabitantes
             orderby vt.Edad // Ordena por edad en orden ascendente
             select vt;

// Recorre la lista ordenada e imprime los datos de cada habitante
foreach (var edad in edadAC)
{
    Console.WriteLine(edad.datosHabitante());
}
*/
#endregion
#region OrderBYDescending()
/*
   
   // Ordena la lista de habitantes por edad en orden descendente usando OrderByDescending.
   // Luego imprime los datos de cada habitante en la lista ordenada.

var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
foreach (Habitante h in listaEdad)
{
    Console.WriteLine(h.datosHabitante());
}

// Imprime una línea de separación en la consola
Console.WriteLine("-------------------------------------------");


   // Utiliza una consulta LINQ para ordenar la lista de habitantes por edad en orden descendente.
   // Luego imprime los datos de cada habitante en la lista ordenada.

var ListaEdad2 = from h in ListaHabitantes
                 orderby h.Edad descending // Ordena por edad en orden descendente
                 select h;

foreach (Habitante h in ListaEdad2)
{
    Console.WriteLine(h.datosHabitante());
}

*/
#endregion
#region ThenBy
// Ordena la lista de habitantes primero por edad en orden ascendente y luego por nombre en orden ascendente
// var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);

// Consulta LINQ para ordenar los habitantes primero por edad en orden ascendente y luego por nombre en orden descendente
var edadATA = from h in ListaHabitantes
              orderby h.Edad, h.Nombre descending // Ordena por edad (ascendente por defecto) y luego por nombre (descendente)
              select h;

// Recorre la lista ordenada e imprime los datos de cada habitante
foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}

Console.WriteLine("------------------");

// Ordena la lista de habitantes primero por edad en orden ascendente y luego por nombre en orden descendente
// var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

// Consulta LINQ para ordenar los habitantes primero por edad en orden ascendente y luego por nombre en orden ascendente
var lista4 = from h in ListaHabitantes
             orderby h.Edad, h.Nombre ascending // Ordena por edad (ascendente por defecto) y luego por nombre (ascendente)
             select h;

// Recorre la lista ordenada e imprime los datos de cada habitante
foreach (var h in lista4)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion
