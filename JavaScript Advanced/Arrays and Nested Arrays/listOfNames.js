//Sort names alphabetically in ascending order
function listNames(namesArr){
    let res=namesArr.sort((a,b)=>a.localeCompare(b));
    for(let i=0;i<res.length;i++){
        console.log(`${i+1}.${res[i]}`)
    }
}
listNames(["Jhon","Bob","Chris","Ema"]);