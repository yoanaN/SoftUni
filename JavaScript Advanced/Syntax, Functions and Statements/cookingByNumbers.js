function cookingByNumbers(inputNum, ...commands){
  
  commands.forEach(command=>{
    inputNum=manipulator(inputNum,command)});
    
  function manipulator(num,command){
    switch(command){
        case "chop":
            num/=2;
            console.log(num);
        break;
        case "dice":
            num=Math.sqrt(num);
            console.log(num);
        break;
        case "spice":
            num +=1;
            console.log(num);
        break;
        case "bake":
            num *=3;
            console.log(num);
        break;
        case "fillet":
            num *=0.80;
            console.log(num);
        break;
    }
    return num;
   }   
}

cookingByNumbers(32, 'chop', 'chop', 'chop', 'chop', 'chop');
cookingByNumbers(9, 'dice', 'spice', 'chop', 'bake', 'fillet');