using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainInteraction : MonoBehaviour
{
    //Variables
    public int MultiplicadorRecursos;
    public float timeLeft = 10;
    public bool isAccelerated;
    private int valor;

    //Objetos del UI
    public Text CantidadRecurso;
    public Text TasaRecurso;
    public Text MultRecuso;
    public Text Habilidad;
    public toggleOverride toggle;
    public Image tiempoAcelerado;
    public Button acelerar;
    public Dropdown dropdown;

    //Manager, de donde se sacan los valores.
    public ResourceGenerator ManagerRecursos;

	
	// Update is called once per frame
	void Update ()
    {
        valor = dropdown.value;
        CantidadRecurso.text = ManagerRecursos.GetRecurso().ToString();
        TasaRecurso.text = ManagerRecursos.GetTasa().ToString();
        MultRecuso.text = ManagerRecursos.GetMult().ToString();
        if (isAccelerated == true)
        {
            timeLeft -= Time.deltaTime;
            acelerar.interactable = false;
            ManagerRecursos.SetMult(2);
        }
        if (timeLeft <= 0)
        {
            isAccelerated = false;
            timeLeft = 10;
            acelerar.interactable = true;
            ManagerRecursos.SetMult(1);
        }
        tiempoAcelerado.fillAmount = timeLeft/10;
    }

    private void CambiarTextoHabilidad()
    {
        switch (valor)
        {
            case 0:
                if (ManagerRecursos.GetRecurso() > 1000)
                {
                    Habilidad.text = "Habilidad 1";
                }
                else
                    Habilidad.text = "No tienes recursos para Habilidad 1";
                break;

            case 1:
                if (ManagerRecursos.GetRecurso() > 2000)
                {
                    Habilidad.text = "Habilidad 2";
                }
                else
                    Habilidad.text = "No tienes recursos para Habilidad 2";
                break;

            case 2:
                if (ManagerRecursos.GetRecurso() > 3000)
                {
                    Habilidad.text = "Habilidad 3";
                }
                else
                    Habilidad.text = "No tienes recursos para Habilidad 3";
                break;

            case 3:
                if (ManagerRecursos.GetRecurso() > 4000)
                {
                    Habilidad.text = "Habilidad 4";
                }
                else
                    Habilidad.text = "No tienes recursos para Habilidad 4";
                break;
        }
    }

    public void MultiplicarProduccion()
    {
        if (toggle.isOn)
        {
            ManagerRecursos.SetTasa(MultiplicadorRecursos);
        }
        else
        {
            ManagerRecursos.SetTasa(1);
        }
    }
    public void AcelerarProduccion()
    {
        isAccelerated = true;
    }
    public void ActivarHabilidad()
    {
        ManagerRecursos.ActivarHabilidades(valor);
        CambiarTextoHabilidad();
    }
}
