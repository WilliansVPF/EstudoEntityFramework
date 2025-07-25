using EstudoEntityFramework.Contexts;
using EstudoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext(); //? instancia do DbContext

// var cliente = new ClienteDataAnnotation
// {
//     Nome = "Willians",
//     Cpf = "123.456.789.12"
// };

// var cliente1= new ClienteDataAnnotation
// {
//     Nome = "Pedro",
//     Cpf = "234.674.668.39"
// };

// var cliente2 = new ClienteDataAnnotation
// {
//     Nome = "Paulo",
//     Cpf = "190.693.357-87"
// };



// db.Add(cliente); //? abre um transação de adição no banco
// db.AddRange(cliente1, cliente2); //? adiciona varios elementos. Pode ser passado uma coleção
// db.SaveChanges(); //? faz o commit executando de fato a alteração

// foreach (var c in db.ClienteDataAnnotations) //? busca todos os dados da tabela
// {
//     Console.WriteLine(c);
// }

// var cliente3 = db.ClienteDataAnnotations.Find(1); //? busca por Id
// var cliente3 = db.ClienteDataAnnotations.AsNoTracking().First(c => c.Id == 2); //? busca por Id, porem não monitora alterações no registro
// Console.WriteLine(cliente3);

// var cliente4 = db.ClienteDataAnnotations.Where(c => c.Nome.Contains("Pedro")).SingleOrDefault(); //? busca um registro pela propriedade
// Console.WriteLine(cliente4);

// //* update fazendo primeiro uma busca no banco
// var cliente5 = db.ClienteDataAnnotations.Find(1); //? busca o registro
// cliente5.Cpf = "987.378.124-87"; //? altera o dado
// db.SaveChanges(); //? salva no banco

// //* update sem fazer busca no banco de dados
// var cliente6 = new ClienteDataAnnotation //? cria um objeto
// {
//     Id = 2, //? id do registro salvo no banco
//     Nome = "Pedro Editado", //? dado alterado
//     Cpf = "234.674.668.39" //? é necessario preencher todos os dados, até os que não serão alterados
// };
// db.Update(cliente6); //? abre um transação de update no banco
// db.SaveChanges(); //?  faz o commit executando a alteração

// var cliente7 = new ClienteDataAnnotation //? cria um objeto
// {
//     Id = 3, //? id do registro salvo no banco
//     Nome = "Paulo Editado", //? dado alterado
//     Cpf = "234.674.668.39" //? é necessario preencher todos os dados, até os que não serão alterados
// };
// db.Entry(cliente7).State = EntityState.Modified; //? abre uma transação de update e passa a monitorar o registro
// db.SaveChanges();//?  faz o commit executando a alteração


//* exclusão fazendo primeiro uma busca no banco
var cliente8 = db.ClienteDataAnnotations.Find(2); //? busca o registro
db.Remove(cliente8); //? abre um transação de exclusão
db.SaveChanges(); //? salva as alterações

//* exclusão sem fazer busca
var cliente9 = new ClienteDataAnnotation
{
    Id = 3
};
db.Remove(cliente9);
db.SaveChanges();
