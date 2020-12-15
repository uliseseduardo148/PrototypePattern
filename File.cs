using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    //Esta clase solo se encarga de leer y escribr el archivo de texto, para este proyecto sólo es lectura
    public class File
    {
        private string fileName;
        StreamReader ts;
        StreamWriter ws;
        private bool opened, writeOpened;

        public File()
        {
            init();
        }

        private void init()
        {
            opened = false;
            writeOpened = false;
        }

        public File(string file_name)
        {
            fileName = file_name;
            init();
        }

        public bool OpenForRead(string file_name)
        {
            fileName = file_name;
            try
            {
                ts = new StreamReader(fileName);
                opened = true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            return true;
        }

        public bool OpenForRead()
        {
            return OpenForRead(fileName);
        }

        public string readLine()
        {
            return ts.ReadLine();
        }

        public void writeLine(string s)
        {
            ws.WriteLine(s);
        }

        public void close()
        {
            if (opened)
                ts.Close();
            if (writeOpened)
                ws.Close();
        }

        public bool OpenForWrite()
        {
            return OpenForWrite(fileName);
        }

        public bool OpenForWrite(string file_name)
        {
            try
            {
                ws = new StreamWriter(file_name);
                fileName = file_name;
                writeOpened = true;
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }
    }
}
