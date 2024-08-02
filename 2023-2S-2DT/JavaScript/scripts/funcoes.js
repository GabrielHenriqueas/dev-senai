function calcular() {
    event.preventDefault();//interrompe o submit

    let n1 = parseFloat(document.getElementById("n1").value);
    let n2 = parseFloat(document.getElementById("n2").value);
    let res;//undefined
    let op = document.getElementById("operacao").value;

    if (isNaN(n1) || isNaN(n2)) {
        alert("Preencha todos os campos")
        return;
    }

    if (op == '+') {                
        res = somar(n1, n2);

    } else if (op == '-') {
        res = subtrair(n1, n2);

    } else if (op == '*') {
        res = multiplicar(n1, n2);

    } else if (op == '/') {
        res = dividir(n1, n2);
    } else {
        res = "Operação Inválida!";
    }

    console.log(`Resultado é: ${res}`)
    document.getElementById('resultado').innerText = res;
}//fim da função

function somar(x, y) {
    return (x + y).toFixed(2);
}

function subtrair(x, y) {
    return (x - y).toFixed(2);
}

function multiplicar(x, y) {
    return (x * y).toFixed(2);
}

function dividir(x, y) {
    if (y == 0) {
        return "Operação Inválida"
    }

    return (x / y).toFixed(2);           
}