function resolver() {
    let dn1 = window.document.getElementById('duvida')
    let n1 = Number(dn1.value)
    if (n1 % 5 == 0) {
        res.innerText = `O número ${n1} é divisivel por 5`
    } else {
         res.innerText = `O número ${n1} não é divisivel por 5`
    }
}