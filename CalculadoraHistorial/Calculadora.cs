namespace EspacioCalculadora
{
    public class Calculadora
    {
        public double dato = 100;
        public void sumar(double termino)
        {
            dato += termino;
        }

        public void restar(double termino)
        {
            dato -= termino;
        }

        public void multiplicar(double termino)
        {
            dato *= termino;
        }

        public void dividir(double termino)
        {
            dato /= termino;
        }

        public void limpiar(double termino)
        {
            dato = 0;
        }

        public double resultado
        {
            get => dato;
        }
    }


    public class Operacion
    {
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada
        public double Resultado
        {
            get { return resultadoAnterior; }
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación
        public double NuevoValor
        {
            get { return nuevoValor; }
        }
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
    }

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar // Representa la acción de borrar el resultado actual o el historial
    }


}