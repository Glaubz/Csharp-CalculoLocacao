using System;
using System.Globalization;

namespace Aula195_Ex.Entities
{
    public class Locacao
    {
        public string Modelo { get; private set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        public Locacao(){
        }

        public Locacao(string modelo, DateTime dataAluguel, DateTime dataDevolucao, double precoHora, double precoDia)
        {
            Modelo = modelo;
            DataAluguel = dataAluguel;
            DataDevolucao = dataDevolucao;
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public TimeSpan TempoAluguel(){
            return DataDevolucao - DataAluguel;
        }

        public int TempoTotal(){
            var tempo = TempoAluguel();
            int tempoTotal;
            if(tempo.Days > 0) {tempoTotal = tempo.Days;}
            else {tempoTotal = tempo.Hours;}
            if(tempo.Minutes > 0) tempoTotal += 1;
            return tempoTotal;
        }

        public double ValorBasico(){
            var tempo = TempoAluguel();
            int tempoTotal = TempoTotal();
            if(tempo.Days > 0) {return tempoTotal * PrecoDia;}
            else {return tempoTotal * PrecoHora;}
        }

        public double Taxa(){
            if(ValorBasico() <= 100) {return ValorBasico() * 0.20;}
            else {return ValorBasico() * 0.15;}
        }

        public double DividaTotal(){
            return ValorBasico() + Taxa();
        }

        public override string ToString(){
            return "DADOS DA CONTA:\nValor básico: " + ValorBasico().ToString("F2", CultureInfo.InvariantCulture) + "\nTaxa: " + Taxa().ToString("F2", CultureInfo.InvariantCulture) + "\nValor total: " + DividaTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}