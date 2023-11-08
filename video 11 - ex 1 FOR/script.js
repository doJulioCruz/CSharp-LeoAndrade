function calcular() {
    let res = document.getElementById("ares")
    res.innerHTML = ''
    for (let i = 1; i <= 10; i++) { 
            let item = document.createElement("option")
            item.text = ` ${i} x 7 = ${i * 7}`
            res.appendChild(item) 
    }
}

