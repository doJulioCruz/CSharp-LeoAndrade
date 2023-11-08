function media() {
    let an1 = document.getElementById("primeira");
    let bn2 = document.getElementById("segunda");
    let cn3 = document.getElementById("terceira");
    let dn4 = document.getElementById("quarta");

    let n1 = Number(an1.value);
    let n2 = Number(bn2.value);
    let n3 = Number(cn3.value);
    let n4 = Number(dn4.value);

    let calc = (n1 + n2 + n3 + n4) / 4; 

    switch(calc) {
        case (n1 + n2 + n3 + n4) / 4 == 0:
            ares.innerText = "REPROVADO - Muito abaixo do esperado."
            break
        case (n1 + n2 + n3 + n4) / 4 == 1: 
            ares.innerText = "REPROVADO - Abaixo do esperado."
            break    
        case (n1 + n2 + n3 + n4) / 4 == 2:
            ares.innerText = "REPROVADO - Estude mais."
            break
        case (n1 + n2 + n3 + n4) / 4 == 3:
            ares.innerText = "REPROVADO - Faltou um ponto."
            break
        case (n1 + n2 + n3 + n4) / 4 == 4:
            ares.innerText = "RECUPERAÇÃO - Precisa de média 8."
            break
        case (n1 + n2 + n3 + n4) / 4 == 5:
            ares.innerText = "RECUPERAÇÃO - Precisa de média 7."
            break
        case (n1 + n2 + n3 + n4) / 4 == 6:
            ares.innerText = "RECUPERAÇÃO - Precisa de média 6."
            break
        case (n1 + n2 + n3 + n4) / 4 == 7:
            ares.innerText = "APROVADO - Tome cuidado na proxima."
            break
        case (n1 + n2 + n3 + n4) / 4 == 8:
            ares.innerText = "APROVADO - Muito bem."
            break
        case (n1 + n2 + n3 + n4) / 4 == 9: 
            ares.innerText = "APROVADO - Parabens."
            break
        case (n1 + n2 + n3 + n4) / 4 == 10:
            ares.innerText = "APROVADO - Extraordinário."
    }
}