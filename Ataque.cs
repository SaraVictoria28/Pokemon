namespace pokemon
{
    public class Ataque
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public string Poder { get; set; }
        public double Precisao { get; set; }
        public int Prioridade { get; set; }
        public string Categoria { get; set; }

        public void VerificarSeAtaqueEspecial() { }

        public void VerificarSeAtaqueFisico() { }

        public void VerificarSeAtaqueDeStatus() { }
    }
}
