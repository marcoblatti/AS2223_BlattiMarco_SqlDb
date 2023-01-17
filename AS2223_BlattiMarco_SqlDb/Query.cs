namespace AS2223_BlattiMarco_SqlDb
{
    internal class Query
    {
        public string Titolo { get;  }
        public string Contenuto { get; }
        public Query(string titolo, string contenuto)
        {
            Titolo = titolo;
            Contenuto = contenuto;
        }

    }
}