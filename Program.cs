class Program
{
    static void Main(string[] args)
    {
        Livros livroBirdBox= new Livros();
        
        
        livroBirdBox.Settitulo("Titulo: Bird Box");
        
        
        
        
        
        Console.WriteLine(livroBirdBox.GetNome());
        Console.WriteLine(livroBirdBox.GetAutor());
        Console.WriteLine(livroBirdBox.GetEstoque());
        Console.WriteLine(livroBirdBox.GetIsbn());
    }
}

