using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private int recurso;
    private int tasa;
    private int timeLeft;
    private int multiplier;
    public MainInteraction interaccion;

	//METODOS DEL SISTEMA
	void Start ()
    {
        tasa = 1;
        recurso = 0;
        timeLeft = 1;
        multiplier = 1;

    }
    void Update ()
    {
        GenerarRecurso();
	}


    //GETTERS
    public int GetRecurso()
    {
        return recurso;
    }

    public int GetTasa()
    {
        return tasa;
    }

    public int GetMult()
    {
        return multiplier;
    }

    //SETTERS
    public void SetTasa(int multiplicador)
    {
       tasa = 1 * multiplicador;
    }

    public void SetMult(int multiplicador)
    {
        multiplier = 1 * multiplicador;
    }


    //METODOS DE LA FUNCIONALIDAD
    void GenerarRecurso()
    {
        recurso += 1 * tasa * multiplier;
    }
    public void ActivarHabilidades(int valor)
    {
        switch (valor)
        {
            case 0:
                if (recurso >= 1000)
                {
                    Debug.Log("Caso 1");
                    recurso -= 1000;
                }
                else
                {
                   Debug.Log("No Tienes Plata Para Caso 1");
                }
                break;
            case 1:
                if (recurso >= 2000)
                {
                    Debug.Log("Caso 2");
                    recurso -= 2000;
                }
                else
                {
                    Debug.Log("No Tienes Plata Para Caso 2");
                }
                break;
            case 2:
                if (recurso >= 3000)
                {
                    Debug.Log("Caso 3");
                    recurso -= 3000;
                }
                else
                {
                    Debug.Log("No Tienes Plata Para Caso 3");
                }
                break;
            case 3:
                if (recurso >= 4000)
                {
                    Debug.Log("Caso 4");
                    recurso -= 4000;
                }
                else
                {
                    Debug.Log("No Tienes Plata Para Caso 4");
                }
                break;
        }
    }

}
