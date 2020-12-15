using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Swimmer:IComparable
    {
        //Esta clase modelo representa a un nadador
        private string name;
        private string lname, frname;
        private int age;
        private string club;
        private float time;
        private bool female;
        public Swimmer(string line)
        {
            StringTokenizer tok = new StringTokenizer(line, ",");
            splitName(tok);
            age = Convert.ToInt32(tok.nextToken());
            club = tok.nextToken();
            time = Convert.ToSingle(tok.nextToken());
            string sx =tok.nextToken().ToUpper().Trim();
            female = sx.Equals("F");
        }

        private void splitName(StringTokenizer tok)
        {
            name = tok.nextToken();
            int i = name.IndexOf(" ");
            if (i > 0)
            {
                frname = name.Substring(0, i);
                lname = name.Substring(i + 1).Trim();
            }
        }
        public bool isFemale()
        {
            return female;
        }

        public int getAge()
        {
            return age;
        }

        public float getTime()
        {
            return time;
        }

        public string getName()
        {
            return name;
        }

        public string getClub()
        {
            return club;
        }
        //Se implementa la interfaz IComparable para comparar los registros en cuanto a su nombre
        public int CompareTo(object swo)
        {
            Swimmer sw = (Swimmer)swo;
            return lname.CompareTo(sw.getName());
        }    }
}
