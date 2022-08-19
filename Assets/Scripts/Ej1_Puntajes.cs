//Para almacenar el puntaje obtenido en un juego que tiene 10 desafíos crea un array de 10 posiciones donde
//guardaremos cuántos puntos se obtuvieron en cada desafío.Implementa las siguientes funciones:
//a. int ObtenerMayorPuntaje()
//Devuelve el puntaje más alto de los 10 almacenados
//b. int ObtenerNivelDeMenorPuntaje()
//Devuelve el índice que tiene el menor puntaje (si hay más de un nivel con puntaje mínimo idéntico, devolver el primero encontrado)
//c. float ObtenerPuntajePromedio()


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_Puntajes : MonoBehaviour
{

    [SerializeField] int[] puntajes = new int [10]; //Se le asigna la longitud del array

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El nivel con menor puntaje es " + ObtenerMenorPuntaje());
        Debug.Log("El promedio es " + ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje() //No es void porque tiene que devolver algo. El void no devuelve
    {
        int mayorPuntaje = 0;

        foreach (int puntaje in puntajes)
        {
            if (puntaje > mayorPuntaje)
            {
                mayorPuntaje = puntaje;
            }
        }

        return mayorPuntaje;
    }

    int ObtenerMenorPuntaje() //No es void porque tiene que devolver algo. El void no devuelve
    {
        int indiceNivelMenorPuntaje = 0;
        int menorPuntaje = puntajes[0];

        for (int i = 1; i < puntajes.Length; i++)
        {
            if (puntajes[i] < menorPuntaje)
            {
                menorPuntaje = puntajes[i];
                indiceNivelMenorPuntaje = i;
            }
        }

        return indiceNivelMenorPuntaje;
    }

    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
        
        foreach (int puntaje in puntajes)
        {
            promedio += puntaje;
        }

        promedio = promedio / puntajes.Length;
        return promedio;
    }
}
