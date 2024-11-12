namespace _02_DispositivosEletronicos.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoDeFabricacao { get; set; }
        //é um método
        public abstract string ExibirDetalhes();
    }
}
