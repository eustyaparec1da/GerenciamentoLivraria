
public class Livro
{
    private string nome = "";
    private string Autor = "";
    private int Isbn = 123;
    private int venda;
    
    private int Estoque = 20;
    
    private bool a;
    
    public string GetNome()
    {
        string Nome = nome;
        return nome;    
    }
    public void Settitulo(string titulo)
    {
        if (Confirma()){
        this.nome = titulo;
        Console.WriteLine("Livros alugado com sucesso", nome);
        }
    }
    
    
    public string GetAutor()
    {
        string autor = Autor;
        Console.WriteLine("Autor: Josh Merleman");
        return Autor;    
    }
    public void SetAutor(string autor)
    {
        if (Confirma()){
        this.Autor = autor;
        }
    }
    
    public int GetEstoque()
    {
        int estoque = Estoque;
        Console.WriteLine("Estoque: A quantidade em estoque eh", estoque);
        return Estoque;    
    }
    public void SetEstoque(int estoque)
    {
        if (Confirma()){
        this.Estoque = estoque;
        }
    }

    public int VenderLivro()
    {
        return ((-1)*venda);
    }
         
    public int GetIsbn()
    {
        
        int isbn = Isbn;
        Console.WriteLine("Isbn: Codigo do livro eh", isbn);
        return Isbn; 
           
    }
    public void SetIsbn(int isbn)
    {
        if (Confirma()){
        this.Isbn = isbn;
        
        }
    }
    
    
    
    
    public bool Confirma()
    {
        Console.WriteLine("Confirmar 'S/N'");
        string r = Console.WhiteLine();
        if (r == "s")
        {
            return true;
        }
        else return false;
    }
}