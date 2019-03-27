using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTORES
{
    class Vector
    {
        private int[] _vec;

        public Vector(int tam)//constructor
        {
            _vec = new int[tam];
           
        }
        
        /// <summary>
        /// Funcion que llena el vector (.legth nos permite conocer la longitud del vector)
        /// son publicas para poder llamarlas en el formulario 
        /// </summary>
        /// <param name="vinicio"></param>
       public void llenar(int vinicio)
        {
           for(int i = 0; i < _vec.Length; i++)
            {
                _vec[i] = vinicio++;      
            }
        }

        /// <summary>
        /// funcion que muestra en formato =, la casilla y el valor que tine dentro del vector
        /// son publicas para poder mandarlas a llamar desde el formulario
        /// </summary>
        /// <returns></returns>
        public string fmostrar()
        {
            string valorv=" ";
            for(int i=0;i<_vec.Length;i++)
            {
                valorv +="[" + i + "] = " + _vec[i] + Environment.NewLine;
            }
            return valorv;
        }
        /// <summary>
        /// funcion para voltear el vector
        /// </summary>
        /// <returns></returns>
        public void girararriba()
        {
            int s = _vec.Length - 1,t;
            t = _vec[s];
            for(int i=s;i>=1;i--)
            {
                _vec[i] = _vec[i - 1];
            }
            _vec[0] = t;
           /* string volteado = " ";
            int temporal = _vec[0];
            volteado = "[" + 0 + "] = " + _vec[7] + Environment.NewLine;
            for (int i=1;i<_vec.Length;i++)
            {
                volteado += "[" + i + "] = " + _vec[i-1] + Environment.NewLine;
            }
            
            return volteado;*/
        }
      
        /// <summary>
        /// funcion para invertir el acomodo de los valores del vector
        /// </summary>
        /// <returns></returns>
        
        public void invertir()
        {
            int s = _vec.Length - 1, t;
            for(int i=0;i<=_vec.Length/2;i++)
            {
                t = _vec[i];
                _vec[i] = _vec[s];
                _vec[s] = t;
                s--;
            }

        }

        /// <summary>
        /// funcion que gira el vector hacia abajo
        /// </summary>
        public void girarabajo()
        {
            int s = _vec.Length - 1;
            int t = _vec[0];
            for(int i=0;i<s;i++)
            {
                _vec[i] = _vec[i + 1];
            }
            _vec[s] = t ;
        }

    }
}
