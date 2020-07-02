namespace ConsoleApp1
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private Trabajo trabajo;
        public Trabajo Trabajo
        {
            get { return trabajo; }
            set
            {
                trabajo = value;
                trabajo.Ocupa = this;
            }
        }

        private Portatil portatil;
        public Portatil Portatil
        {
            get { return portatil; }
            set
            {
                portatil = value;
                portatil.Propietario = this;
            }
        }

        private Ubicacion ubicacion;
        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set
            {
                ubicacion = value;
                ubicacion.Lugar = this;
            }
        }

        public string Saludar()
        {
            return $"Hola, mucho gusto mi nombre es {Nombre} {Apellido} es un gusto conocerte";
        }
        public string Trabajar()
        {
            return $"Trabajo en {Trabajo.Nombre}, con una portatil de modelo {Portatil.Marca} para diferentes proyectos";
        }
        public string Ubicar()
        {
            return $"Ubicado en {Ubicacion.Ciudad}";
        }
    }
}
