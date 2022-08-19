//Creá un array de Strings que contenga los nombres de cada uno de los doce meses del año, y otro que contenga
//la cantidad de días de cada uno(ignorá los años bisiestos). Luego implementá las siguientes funciones
//a. bool ValidarFormatoFecha(string fecha) Devuelve verdadero si la string recibida representa una fecha válida.
//La regla es que sea un string de 4 caracters donde los dos primeros caracteres sean un número entre 01 y 31 y los dos últimos un número entre 01 y 12.
//b.  public String getNombreDelMes(int numeroMes) Recibe el número de mes(entre 1 y 12) y devuelve el nombre del mes en cuestión.
//c.  public int diasTranscurridos(int numeroMes) Recibe el número de mes y devuelve la cantidad de días transcurridos
//en el año antes de comenzar el mes en cuestión.
//Al presionar los botones correspondientes mostrá cuántos días transcurrieron desde el comienzo del año y qué día del año (cuántos días pasaron hasta ese día) es un día determinado ingresado en formato ddmm.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_DiaMes : MonoBehaviour
{

    [SerializeField] string[] nombresMeses = new string[12];
    [SerializeField] int[] diasPorCadaMes = new int[12];
    public string fechaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
    }

    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;

        if (fecha.Length == 4)
        {
            string dia = "";
            string mes = "";
            dia += fecha[0];
            dia += fecha[1];
            int diaNumber = int.Parse(dia);
            Debug.Log("Dias: " + diaNumber);
            mes += fecha[2];
            mes += fecha[3];
            int mesNumber = int.Parse(mes);
            Debug.Log("Mes: " + mesNumber);

            if (diaNumber > 0 && diaNumber <= 31 && mesNumber > 0 && mesNumber <= 12)
            {
                fechaValida = true;
            }
        }

        else
        {
            Debug.Log("El largo de la decha es incorrecto");
        }

        return fechaValida;
    }

}
