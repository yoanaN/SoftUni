function GCD(x,y){
    while(x!=y){
        if(x<y){
            let temp=x;
            x=y;
            y=temp;
        }
        x-=y;
    }
    console.log(x);
}
GCD(89,5);