
using System.Windows.Forms;

namespace Clase_herencia_y_clase_derivada

{
    public abstract class Colores
    {
        public abstract void SeleccionarColor();
    }

    public class Azul : Colores, Icolores
    {
        public override void SeleccionarColor()
        {
            MessageBox.Show("Has seleccionado el color azul");
        }

        public void Elegir()
        {
            MessageBox.Show("Es un hermoso color, por algo es mi favorito");
        }
    }

    public class Rojo : Colores, Icolores
    {
        public override void SeleccionarColor()
        {
            MessageBox.Show("Has seleccionado el color Rojo");
        }

        public void Elegir()
        {
            MessageBox.Show("No es mi favorito pero no esta mal");
        }
    }

    public interface Icolores
    {
        void Elegir();
    }
}