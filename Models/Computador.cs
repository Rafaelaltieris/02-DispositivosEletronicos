﻿namespace _02_DispositivosEletronicos.Models
{
    //Essa linha é responsável por herdar o DispositivoEletronico
    public class Computador : DispositivoEletronico
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRam { get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {SistemaOperacional}";
        }
    }
}
