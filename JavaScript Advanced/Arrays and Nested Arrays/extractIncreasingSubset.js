function extractIncreasingSubset(arrNum){
    let arrRes=[];
    let biggest=arrNum.shift();
    arrRes.push(biggest);
    for(el of arrNum){
        if(biggest<el){
            arrRes.push(el);
            biggest=el;
        }
    }
     console.log(arrRes);
}
extractIncreasingSubset([7,24,1, 2, 3, 4]);
