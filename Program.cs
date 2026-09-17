namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento documento = new Documento();
            Foto foto = new Foto();
            documento.Salvar();
            foto.Salvar();
        }
    }
}
