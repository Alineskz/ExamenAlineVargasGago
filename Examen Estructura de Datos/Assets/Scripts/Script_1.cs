using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script_1 : MonoBehaviour
{
    public int primerNumero = 0;
    public int segundoNumero = 0;
    private int ecuacion;
    //private string ecu;
    public TMP_InputField input;
    public TMP_Text text;



    // Start is called before the first frame update
    void Start()
    {
        ecuacion = primerNumero + segundoNumero;
        text.text = ecuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
