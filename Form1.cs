using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePattern
{
    public partial class Form1 : Form
    {
        //Se crea una instancia de la clase SwimData, se envía como parámetro la ruta del archivo a leer 
        private SwimData swdata;

        public Form1()
        {
            InitializeComponent();
            swdata = new SwimData("C:\\Users\\cliente-preferido\\source\\repos\\PrototypePattern\\swimmers.txt");
            reload();
        }

        //Este método se encarga de cargar el ListBox con los nombres que se obtienen del archivo
        private void reload()
        {
            lsKids.Items.Clear();
            swdata.moveFirst();
            while (swdata.hasMoreElements())
            {
                Swimmer sw = swdata.getSwimmer();
                lsKids.Items.Add(sw.getName());
            }
        }

        /*En el evento del botón, se clona el array con los datos obtenidos del archivo leído al inicio,
         * primero se verifica si algún RadioButton  está seleccionado, si ninguno lo está, se añaden 
         * todos los datos, si alguno esta seleccionado se toma el valor del cual está seleccionado y 
         * se envía como parámetro al método encargado de rellenar el array, esta vez con datos filtrados
         */
        private void BtnA_Click(object sender, EventArgs e)
        {
            SwimData newSd = (SwimData)swdata.Clone();
            if (!radioFem.Checked && !radioMasc.Checked) {
                newSd.addAll();
            }
            else {
                newSd.sort(radioFem.Checked);
                reload();
            }
            lsNewKids.Items.Clear();
            while (newSd.hasMoreElements())
            {
                Swimmer sw = (Swimmer)newSd.getSwimmer();
                lsNewKids.Items.Add(sw.getName());
                lsKids.Items.Remove(sw.getName());
            }        }

    }
}
