function solucao() {
    let fn1 = document.getElementById("fnumber");
    let opa = document.getElementById("operator");
    let sn2 = document.getElementById("snumber");
    
    let n1 = Number(fn1.value);
    let op = String(opa.value);
    let n2 = Number(sn2.value);

      
    let operacao = (n1 + op + n2);

    switch(operacao) {
        case n1 + "+" + n2: res = (n1 + n2)
        ares.innerText = `O resultado final é: ${res}`
            break
        case n1 + "-" + n2 : res = (n1 - n2)
        ares.innerText = `O resultado final é: ${res}`
            break
        case n1 + "*" + n2 : res = (n1 * n2)
        ares.innerText = `O resultado final é: ${res}`
            break
        case n1 + "/" + n2 : res = (n1 / n2)
        ares.innerText = `O resultado final é: ${res}`
            break
    }

}

/*
 //sem usar o html
var n1 = 53;
var n2 = 16;
var agora = "-"; 
var diaSem = n1 + agora + n2;

switch(diaSem) {
    case n1 + "+" + n2:
        console.log(n1 + n2)
        break
    case n1 + "-" + n2:
        console.log(n1 - n2)
        break
    case n1 + "*" + n2:
        console.log(n1 * n2)
        break
    case n1 + "/" + n2:
        console.log(n1 / n2)    
        break
    }
    */