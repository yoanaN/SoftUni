//the last element become the first
function rotateArray(arr,num){
   for(let i=0;i<num;i++){
    let el=arr.pop();
    arr.unshift(el);
    }
    console.log(arr.join(" "));
}
rotateArray([1,2,3,4],2);
rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);