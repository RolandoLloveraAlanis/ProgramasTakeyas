using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_de_colas
{
    class Pasajero
    {
        //curp, edad, tipod e pasajero, cantidad de viajes realizados, nimbre, hroa de ingreso

        string _strCurp, _strTipoPasajero, _strNombre;
        int _intEdad, _intCantidadViajes;
        DateTime _dtmhoraIngreso;
        public string CURP
        {
            get { return _strCurp; }
            set { _strCurp = value; }
        }
        public string TipoPasajero
        {
            get { return _strTipoPasajero; }
            set { _strTipoPasajero = value; }
        }
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }
        public int CantidadViajes
        {
            get { return _intCantidadViajes; }
            set { _intCantidadViajes = value; }
        }
        public DateTime HoraIngreso
        {
            get { return _dtmhoraIngreso; }
            set { _dtmhoraIngreso = value; }
        }

    }
}
