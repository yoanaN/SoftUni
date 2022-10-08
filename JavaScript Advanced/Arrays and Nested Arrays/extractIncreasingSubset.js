function extractIncreasingSubset(arrNum){
    let arrRes=[];
    let biggest=arrNum.shift();
    arrRes.push(biggest);
    for(el of arrNum){
        if(biggest<=el){
            arrRes.push(el);
            biggest=el;
        }
    }
    return arrRes;
}
