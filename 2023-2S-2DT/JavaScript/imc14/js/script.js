//lista global
const listaPessoas = [];// lista vazia

function calcular(evento) {
    //interrompe/captura o evento disparado
    evento.preventDefault();
    let nome = document.getElementById("nome").value.trim();
    let altura = parseFloat(document.getElementById("altura").value);//NaN
    let peso = parseFloat(document.getElementById("peso").value);

    // verifica se há algum campo sem preencher
    if (isNaN(altura) || isNaN(peso) || nome.lenght < 2) {
        alert('É necessário preencher todos os campos')
        return;
    }

    const imc = calcularImc(peso, altura);
    const situacao = geraSituacao(imc);

    const pessoa = {//objeto literal
        //
        nome: nome,
        altura: altura,
        peso: peso,
        imc: imc,
        situacao: situacao
    }

    listaPessoas.push(pessoa);

    exibirDados();
    limpar();   
}

function limpar() {
    document.getElementById("nome").value = "";
    document.getElementById("altura").value = "";
    document.getElementById("peso").value = "";
}

function calcularImc(peso, altura) {
    //return peso / (altura * altura);
    //return peso / (altura ** 2);
    return peso / Math.pow(altura, 2)

}// fim da função calcular

function geraSituacao(imc) {
    if (imc < 18.5) {
        return ("Magreza Severa")
    } else if (imc <= 24.99) {
        return ("Peso Normal");
    } else if (imc <= 29.99) {
        return ("Acima do peso");
    } else if (imc <= 34.99) {
        return ("Obesidade I");
    } else if (imc <= 39.99) {
        return ("Obesidade II");
    } else {
        return ("Cuidado!");
    }
}//fim da função geraSituacao

function exibirDados() {
    //listar as pessoas no console
    let linhas = "";
    listaPessoas.forEach(function (oPessoa) {
        linhas += `
        <tr>
            <td>${oPessoa.nome}</td>
            <td>${oPessoa.altura}</td>
            <td>${oPessoa.peso}</td>
            <td>${oPessoa.imc.toFixed(2)}</td>
            <td>${oPessoa.situacao}</td>
          </tr>
        `;
    })

    document.getElementById("cadastro").innerHTML = linhas;
}