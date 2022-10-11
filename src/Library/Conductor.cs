using System;
using System.Collections;

namespace PII_Herencia
{
    public class Conductor : Persona
    {
        public string bio{get;set;}
        public string vehiculo {get;set;}
        public int capacidadDisponible {get;set;}
        public string typeOfDriver 
        {
            get => typeOfDriver; 
            set => typeOfDriver = capacidadDisponible == 1 ? "Comun" : "Pool"; 
        }
        public string getTextC(){
            string text = getText();
            text += $", una breve biografia de {nombre}:\n {bio}";
            return text;
        }   
    }
}