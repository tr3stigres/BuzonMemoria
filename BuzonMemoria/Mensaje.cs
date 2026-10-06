using static System.Net.Mime.MediaTypeNames;

public class Mensaje
{
    public int Id { get; set; }
    public string Texto { get; set; }
    public AnalisisMensaje? Analisis { get; set; } = null;

    public Mensaje(int id, string texto, AnalisisMensaje? analisis)
    {

        Id = id;
        Texto = texto;
        Analisis = analisis;
    }

}