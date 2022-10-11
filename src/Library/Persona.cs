using System;
using System.Collections;

namespace PII_Herencia
{
    public class Persona
    {
        public string nombre {get;set;}
        public string apellido {get;set;}  
        public int cedula {private get; set;}
        public string foto {get;set;}
        public string getText(){
            string text = "";
            text += $"{foto}\nBienvenido {nombre} {apellido} a UCURide";
            return text; 
        }

    }   
}