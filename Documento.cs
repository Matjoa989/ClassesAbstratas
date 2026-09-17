namespace ClassesAbstratas
{
    class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando documento em formato .DOC");
        }
    }
}
