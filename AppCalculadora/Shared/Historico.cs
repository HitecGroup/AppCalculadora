namespace AppCalculadora.Shared
{
    public class Historico
    {
        public int idHistorico { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Incoterm { get; set; }
        public string? Destino { get; set; }
        public string? Costo { get; set; }
        public string? Seguro { get; set; }
        public string? SeguroProfit { get; set; }
        public string? FleteMar { get; set; }
        public string? FleteMarProfit { get; set; }
        public string? FleteTer { get; set; }
        public string? FleteTerProfit { get; set; }
        public string? ImpuestoA { get; set; }
        public string? ImpuestoAProfit { get; set; }
        public string? Aam { get; set; }
        public string? AamProfit { get; set; }
        public string? Maniobras { get; set; }
        public string? ManiobrasProfit { get; set; }
        public string? Gl { get; set; }
        public string? GlProfit { get; set; }
        public string? Total { get; set; }
        public string? TotalProfit { get; set; }
        public string? VigenciaMaritimo { get; set; }
        public string? VigenciaTerrestre { get; set; }
    }
}