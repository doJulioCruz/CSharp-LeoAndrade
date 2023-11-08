function calcular() {
    let numero = document.getElementById("usuario")
    let res = document.getElementById("ares")
    
    let n = Number(numero.value)
    res.innerHTML = ''
    for (let x = 1;x <= 10; x++){
        let item = document.createElement("option")
        item.text = `${x} x ${n} = ${x * n}`
        res.appendChild(item)
    }
}