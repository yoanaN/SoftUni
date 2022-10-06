function addAndRemove(arrCmd){
    let arrNum=[];
    for(let i =0;i<arrCmd.length;i++){
        command(arrCmd[i],arrNum);
    }
    arrNum.join('\n');
}
function command(cmd,arr){
    switch(cmd){
        case 'add':{
            arr.push(arr.length+1);
        }break;
        case 'remove':{
            arr.pop();
        }break;
    }
}