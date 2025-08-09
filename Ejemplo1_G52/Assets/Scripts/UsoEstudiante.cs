using UnityEngine;
using System;
using packagePersona;
using System.Collections.Generic;

[Serializable]

public class UsoEstudiante : MonoBehaviour
{
    [SerializeField]
    public List<Estudiante> listaE= new List<Estudiante>();


    
    void Start()
    {
        Estudiante e1 = new Estudiante("2025_03" , "Ing multimedia", "David Castro", "dacastro@uao.edu.co",
            "carre 34");

        Estudiante e2 = new Estudiante("2025_03", "Ing Ambiental", "Maria Perez", "merez@uao.edu.co",
           "carre 35");


        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(" "+listaE[i].NameP + " Carrera"+ listaE[i].NameCarreraE);
        }
        
    }

   
    
}
