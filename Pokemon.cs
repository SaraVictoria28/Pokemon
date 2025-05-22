namespace pokemon
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public Tipo Tipo { get; set; }
        public Ataque Ataque { get; set; }

        public void AprenderAtaque() { }

        public void RemoverAtaque() { }
    }
}
