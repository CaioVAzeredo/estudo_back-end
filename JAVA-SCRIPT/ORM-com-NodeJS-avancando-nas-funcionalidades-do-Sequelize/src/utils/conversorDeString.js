module.exports = (objetoParams) => {
    for (let propriedade in objetoParams) {
        if (/Id|id/.test(propriedade)) { //teste para ver se Id ou id tem em propriedade
            objetoParams[propriedade] = Number(objetoParams[propriedade])
        }
    }
    return objetoParams
}