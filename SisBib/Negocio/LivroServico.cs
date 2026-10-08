using SisBib.Dados;
using SisBib.Modelos;
namespace SisBib.Negocio
{
// A BLL contém as REGRAS DE NEGÓcio e validações

public class LivroServico
    
{ 

private LivroRepositorio_repositorio = new LivroRepositorio();

public bool CadastrarLivro(string titulo,string autor, out string mensagemErro)

{ 

//Regra de Negócio 1: Campos obrigatórios

if (string.IsNullOrWhiteSpace(titulo) || (string.IsNullOrWhiteSpace(autor))
{

mensagemErro = "Título e Autor são obrigatórios!"; 
return false;
}

//Regra de Negócio 2: Título precisa ter pelo menos 3 caracteres if (titulo.Length <3){
mensagemErro = "O título do livro deve ter no mínimo 3 caracteres.";

return false;
 }
 Livro novoLivro = new Livro
 {
     Titulo = titulo,
    
    Autor = autor,

    Emprestado = false 
 };
 _repository.Adicionar(novoLivro);
 mensagemErro = string.Empty; return true;
}
public List<Livro> ListarAcervo()
  { 

    return_repositorio.ObterTodos();
 }
}
 }

                
            