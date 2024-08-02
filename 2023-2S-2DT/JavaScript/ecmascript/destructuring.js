// const camisaLacoste = {
//     descricao: "Camisa Lacoste",
//     preco: 399.98,
//     marca: "Lacoste",
//     tamanho: "G",
//     cor: "Azul",
//     promo: false,
// }

// const { descricao, preco, promo } = camisaLacoste;

// console.log(`
//     Produto: ${descricao}
//     Preço: ${preco}
//     Promoção: ${promo ? "Sim!" : "Não!"}
// `);

const evento = {
    data: new Date(),
    descricao: "Comemoração do aniversário da Paola",
    titulo: "Niver da PamPam",
    presenca: false,
    comentario: "Muito bom"

};

const { data, descricao, titulo, presenca, comentario } = evento;

console.log(`
    Data: ${data}
    Descrição: ${descricao}
    Titulo: ${titulo}
    Presença: ${presenca ? "Presente!" : "Faltou!"}
    Comentário: ${comentario}
`);