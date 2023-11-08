function calcular() {
    let multiplicador = document.getElementById("multi")
    let finaln = document.getElementById("final")
    let res = document.getElementById("ares")
    
    let mult = Number(multiplicador.value)
    let last = Number(finaln.value)

    res.innerHTML = ''
    for (let x = 0; x <= last; x++){
        let item = document.createElement("option")
        item.text = (x + mult)
        res.appendChild(item)
        if (x >= last){
            break
        } 
    }
}