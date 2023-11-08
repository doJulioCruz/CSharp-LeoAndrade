function menorN() {
let fn1 = window.document.getElementById('firstn');
let sn2 = window.document.getElementById('secondn');
let tn3 = window.document.getElementById('thirdn');
let res =document.getElementById('res')
let n1 = Number(fn1.value)
let n2 = Number(sn2.value)
let n3 = Number(tn3.value)
if (n1 < n2 && n1 < n3) {
    res.innerText = `O menor número é ${n1}`
} else if (n2 < n3) {
    res.innerText = `O menor número é ${n2}`
} else {
    res.innerText = `O menor número é ${n3}`
}

}