let gabriel = {
    nome : "Gabriel",
    idade : 24,
    altura : 1.74,
};

gabriel.peso = 97;

let carlos = new Object();

carlos.nome = "Carlos";
carlos.idade = 36;
carlos.sobrenome = "Roque";

let pessoas = [];
//let pessoas2 = new Array();

pessoas.push(carlos);
pessoas.push(gabriel);


//console.log(gabriel);
//console.log(carlos);

pessoas.forEach(function(f, index){
    console.log(`Pessoa ${index + 1}: ${f.nome}`);
});