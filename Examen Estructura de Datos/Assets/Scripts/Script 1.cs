using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script1 : MonoBehaviour
{
    public int numeroMaquina1 = 0;
    public int numeroMaquina2 = 0;
    public int numeroUsuario = 0;
    public TMP_InputField input;
    public TMP_Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        private int numeroMaquina = (numeroMaquina1 + numeroMaquina2);
        GeneraNumero();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void Random()
    {
        int.TryParse(input.text, out numeroUsuario );
        if (numeroUsuario == numeroMaquina)
        {
            text.text = "Correcto, has GANADO";
        }
        else if (numeroUsuario < numeroMaquina)
        {
            text.text = "Intentalo de Nuevo";
        }
        else 
        {
            text.text = "Tu Puedes, hasta los Mejores se Equivocan";
        }
    }
