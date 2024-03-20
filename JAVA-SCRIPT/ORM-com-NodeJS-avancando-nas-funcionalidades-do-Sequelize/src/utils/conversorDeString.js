module.exports = (objetoParams) => {

    for (let propriedade in objetoParams) {
        if (/Id|id/.test(propriedade)) { //O método test da expressão regular é usado para verificar a presença de "Id" ou "id" na propriedade.
            objetoParams[propriedade] = Number(objetoParams[propriedade])
        }
        
    }

    return objetoParams
}