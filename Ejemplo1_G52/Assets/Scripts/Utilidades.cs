
using UnityEngine;
using System.IO;
using packagePersona;
using System.Collections.Generic;
using packagePunto2D;

public class Utilidades : MonoBehaviour
{
    [SerializeField]

    public class datos
    {
        public List<Estudiante> Estudiante;
        public Punto2D punto2D;
    }
    //serializeField para que salga en la interf
    [SerializeField] UsoEstudiante Estudiante;
    [SerializeField] Punto2D puntos2D;

    [ContextMenu("GUARDAR")]

    public void Guardar()
    {

        datos datosTypes = new datos
        {
            Estudiante = Estudiante.listaE,
            punto2D = this.puntos2D
        };


        string estudianteyPuntosJson = JsonUtility.ToJson( datosTypes, true);
        //file = ruta
        string file = Path.Combine(Application.persistentDataPath + "savearchivo.json");
        File.WriteAllText(file, estudianteyPuntosJson);
        Debug.Log(file);

    }
}







