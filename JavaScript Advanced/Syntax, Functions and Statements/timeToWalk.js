function walkingTime(steps,footprintM,speed){
    let distanceInMeters=steps*footprintM;
    let speedMetersInSec=speed/3.6;

    let time=distanceInMeters/speedMetersInSec;
    let rest=Math.floor(distanceInMeters/500);

    let timeInH=Math.floor(time/3600);
    let timeInMin=Math.floor(time/60);
    timeInMin+=rest;
    if(timeInMin==60){
        timeInMin=0;
        timeInH++;
    }else if(timeInMin>60){
        timeInH++;
        timeInMin-=60;
    }
    let timeInSec=Math.round(time%60);

    let formattedH=timeInH<10?`0${timeInH}`:`${timeInH}`;
    let formattedM=timeInMin<10?`0${timeInMin}`:`${timeInMin}`;
    let formattedS=timeInSec<10?`0${timeInSec}`:`${timeInSec}`;

   console.log(`${formattedH}:${formattedM}:${formattedS}`);

}
walkingTime(2564,0.70,5.5);