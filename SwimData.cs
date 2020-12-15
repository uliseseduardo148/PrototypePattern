using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class SwimData:ICloneable
    {
        //Esta clase implementa la interfaz ICloneable para poder clonar el array
        protected ArrayList swdata;
        private int index;

        //Se lee el archivo de texto y por cada linea de crea un objeto de la clase Swimmer
        public SwimData(string filename)
        {
            swdata = new ArrayList();
            File fl = new File(filename);
            fl.OpenForRead();
            string s = fl.readLine();
            while (s != null)
            {
                Swimmer sw = new Swimmer(s);
                swdata.Add(sw);
                s = fl.readLine();
            }
            fl.close();
        }
        
        public void moveFirst()
        {
            index = 0;
        }

        public bool hasMoreElements()
        {
            return (index < swdata.Count);
        }

        //Se añaden al array los registros que sean femeninos
        public void sort(bool isFemale)
            {
                ArrayList swd = new ArrayList();
                for (int i = 0; i < swdata.Count; i++)
                {
                    Swimmer sw = (Swimmer)swdata[i];
                    if (isFemale == sw.isFemale())
                    {
                    swd.Add(sw);
                    }
                }
                swdata = swd;
            }

        //Se añaden al array todos los registros
        public void addAll()
        {
            ArrayList swd = new ArrayList();
            for (int i = 0; i < swdata.Count; i++)
            {
                Swimmer sw = (Swimmer)swdata[i];
                    swd.Add(sw);
            }
            swdata = swd;
        }

        //Se obtiene un array con los objetos almacenados
        public Swimmer getSwimmer()
        {
            if (index < swdata.Count)
                return (Swimmer)swdata[index++];
            else
                return null;
        }

        //Se clona el array con datos
        public object Clone()
        {
            ArrayList swd = new ArrayList();
            for (int i = 0; i < swdata.Count; i++)
             swd.Add(swdata[i]);
           SwimData newsd = new SwimData("C:\\Users\\cliente-preferido\\source\\repos\\PrototypePattern\\swimmers.txt");
            return newsd;
        }    }
}

