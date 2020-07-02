namespace ConsoleApp1
{
    class Trabajo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }    
        public float Sueldo { get; set; }                         
        public Persona Ocupa { get; set; }
    }
}
