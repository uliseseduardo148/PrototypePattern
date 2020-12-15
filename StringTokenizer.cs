using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    //Esta clase sólo se encarga de separar los datos leídos del archivo de texto
    public class StringTokenizer
    {
        private string data, delimiter;
        private string[] tokens;
        private int index;
        public StringTokenizer(string dataLine)
        {
            init(dataLine, " ");
        }
        private void init(String dataLine, string delim)
        {
            delimiter = delim;
            data = dataLine;
            tokens = data.Split(delimiter.ToCharArray());
            index = 0;
        }
        public StringTokenizer(string dataLine, string delim)
        {
            init(dataLine, delim);
        }
        public bool hasMoreElements()
        {
            return (index < (tokens.Length));
        }
        public string nextToken()
        {
            return nextElement();
        }
        public string nextElement()
        {
            string s = tokens[index++];
            while ((s.Length <= 0) && (index < tokens.Length))
                s = tokens[index++];
            return s;
        }
    }
}
