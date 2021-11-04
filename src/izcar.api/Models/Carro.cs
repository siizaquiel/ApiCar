using System;

namespace izcar.api.Models
{

    public class Carro
    {
        public int Id { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
         public int Ano { get; private set; }

         public Carro(int id, string modelo, string placa, int ano)
         {
             Id = id;
             Modelo = modelo;
             Placa = placa;
             Ano = ano;
         }
    }
}