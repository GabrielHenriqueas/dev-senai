// const somar = function(x, y) {
//     return x + y
// }

// const dobro = numero => {
//     return numero * 2;
// }

// const dobro = numero => numero * 2;

// console.log( dobro(50) );

const convidados = [
    {nome : "Carlos", idade : 36},
    {nome : "Heitor", idade : 17},
    {nome : "Bosta", idade : 16},
    {nome : "coroa", idade : 26},
];

convidados.forEach( p => {
    console.log(`Convidado: ${p.nome}, ${p.idade}`);
})