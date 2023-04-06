using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat
{
    /// <summary>
    /// Bei diesem Projekt handelt es sich um ein unvollständiges Bankautomat-Projekt, dass Sie vervollständigen sollen. Hier muss ausschließlich die
    /// Konto.cs-Datei vervollständigt werden. Die restlichen logischen Elemente sind bereits implementiert und funktionieren reibungslos.
    /// Viel Spaß mit diesem Super-Tollen Projekt!
    /// Autor: Maurice Hofmann, Hesham Osman
    /// </summary>
   
    public class Konto
    {
        //Bitte legen Sie hier die Variablen 'vorname, nachname, kontostand und pin' an.
        //Verwenden Sie hierfür jeweils einen geeigneten Datentyp und eine geeigneten Wertebereich.
        public string vorname;
        public string nachname;
        public double kontostand;
        public string pin;

        //Bitte definieren Sie hier den Leer-Kontruktor der Konto-Klasse. Hierbei sollen die variablen folgende Werte enthalten:
        //vorname = "";
        //nachname = "";
        //kontostand = 0;
        //pin = "";
        public Konto()
        {
            vorname = "";
            nachname = "";
            kontostand = 0;
            pin = "";
        }

        //Bitte definieren Sie hier einen zweiten Kontruktor mit den Attributen 'vorname, nachname, pin' der Konto-Klasse.
        public Konto(string _vorname, string _nachname, string _pin)
        {
            vorname = _vorname;
            nachname = _nachname;
            pin = _pin;
        }

        //Instanziieren Sie hier bitte ein statisches Objekt vom Typ Konto mit dem Namen 'aktuellerKontoNutzer'
        static public Konto aktuellerKontoNutzer = new Konto();

        //Definieren Sie hier nun folgenden 3 Methoden. 

        //Kontostand
        //Die Methode soll den kontostand vom instanziierten aktuellerKontoNutzer-Objekt zurückgeben.
        public double KontostandAbfragen()
        {
            kontostand = Konto.aktuellerKontoNutzer.kontostand;
            return kontostand;

        }

        //Einzahlen
        //Die Methode soll den kontostand vom instanziierten aktuellerKontoNutzer-Objekt speichern.
        //Der Kontostand wird mit dem Parameter 'einzahlungsBetrag', der der Methode mitgegeben wird addiert und als Rückgabewert festgelegt.
        public double Einzahlen(double einzahlungsBetrag)
        {
            kontostand = Konto.aktuellerKontoNutzer.kontostand;
            double newKontostand = kontostand + einzahlungsBetrag;
            return newKontostand;
        } 

        //Auszahlen
        //Die Methode soll den kontostand vom instanziierten aktuellerKontoNutzer-Objekt speichern.
        //Der Kontostand wird mit dem Parameter 'auszahlungsBetrag', der der Methode mitgegeben wird subtrahiert und als Rückgabewert festgelegt.
        public double Auszahlen(double auszahlungsBetrag)
        {
            kontostand = Konto.aktuellerKontoNutzer.kontostand;
            double newKontostand = kontostand - auszahlungsBetrag;
            return newKontostand;
        }
    }
}