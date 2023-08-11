# **Ejercicio: Completar una actividad de desafío para instrucciones de iteración y selección anidadas**

Los desafíos de código refuerzan lo que ha aprendido y le ayudan a tener más confianza antes de continuar.

## **Desafío de pedido fraudulento**

Anteriormente en este módulo, nuestro objetivo era escribir código que almacenara los identificadores de pedido pertenecientes a pedidos potencialmente fraudulentos. Su objetivo es encontrar los pedidos fraudulentos lo antes posible y marcarlos para analizarlos en profundidad.

## **Desafío de código: Notificar los identificadores de pedido que necesitan una investigación más detallada**

El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para investigar más en profundidad.

Siga estos pasos para completar este desafío.

1. Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.
    
    Si es necesario, abra Visual Studio Code y, luego, lleve a cabo los pasos siguientes para preparar un archivo Program.cs en el editor:
    
    1. En el menú **Archivo**, seleccione **Abrir carpeta**.
    2. Use el cuadro de diálogo "Abrir carpeta" para ir a la carpeta **CsharpProjects**.
    3. En el panel EXPLORADOR de Visual Studio Code, seleccione **Program.cs**.
    4. En el menú **Selección** de Visual Studio Code, elija **Seleccionar todo** y presione la tecla Supr.
2. Declare una matriz e inicialícela para que contenga los siguientes elementos:
    
    ```
    B123
    C234
    A345
    C15
    B177
    G3003
    C235
    B179
    ```
    
    Estos valores representan los datos de los identificadores de pedidos fraudulentos que usa la aplicación.
    
3. Cree una instrucción `foreach` para recorrer en iteración cada elemento de la matriz.
4. Informe de los identificadores de pedido que comienzan con la letra "B".
    
    Tendrá que evaluar cada elemento de la matriz. Informe de los identificadores de pedido potencialmente fraudulentos mediante la detección de los pedidos que comienzan por la letra "B". Para saber si un elemento comienza por la letra "B", use el método `String.StartsWith()`. Aquí mostramos un sencillo ejemplo de cómo usar el método  `String.StartsWith()` para que pueda adaptarlo a su código:
    
    ```csharp
    string name = "Bob";
    if (name.StartsWith("B"))
    {
        Console.WriteLine("The name starts with 'B'!");
    }
    ```
    
    La salida debería coincidir con la siguiente:
    
    ```
    B123
    B177
    B179
    ```
    

**Sugerencia**

Sugerencia: Para recorrer en bucle cada elemento de la matriz, necesitará una instrucción `if`. La instrucción `if` tendrá que usar un método en la clase “string” para determinar si una cadena comienza por una letra específica. Si no está seguro de cómo usar una instrucción `if`, vea el módulo "Cómo agregar lógica de decisión al código mediante la instrucción "if-elseif-else" en C#".

Tanto si tiene dificultades y necesita echar un vistazo a la solución como si finaliza el ejercicio correctamente, continúe para ver una solución a este desafío.

## **SOLUCIÓN AUTOR**

El código siguiente es una posible solución para el desafío de la unidad anterior.

```csharp
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
```

Este código es simplemente “*una posible solución*” porque depende en gran medida de cómo haya decidido implementar la lógica. Mientras haya obtenido los resultados correctos según las reglas del desafío y haya usado una matriz y una instrucción “foreach”, habrá hecho un gran trabajo.
