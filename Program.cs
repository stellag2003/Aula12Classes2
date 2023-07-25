
using Aula12Classes2;

Produto produto1= new Produto();

produto1.nome = "batom";
produto1.quantidade= 34;
produto1.descricao = "produto de beleza";
produto1.preco = 25;
produto1.status = true;

produto1.mostra();
produto1.desativa();


Produto produto2 = new Produto();

produto2.nome = "gloss";
produto2.quantidade = 10;
produto2.descricao = "produto de beleza";
produto2.preco = 15;
produto2.status = true;

produto2.mostra();
produto2.desativa();
produto2.mostra();

Produto produto3= new Produto();

produto3.nome = "lápis de olho";
produto3.quantidade = 27;
produto3.descricao = "produto de beleza";
produto3.preco = 20;
produto3.status = true;

produto3.mostra();
Console.ReadLine();


