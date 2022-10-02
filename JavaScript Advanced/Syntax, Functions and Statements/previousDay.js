function previousDay(year,month,day){
    let mDate=new Date(year,month-1,day-1);
    console.log(`${mDate.getFullYear()}-${mDate.getMonth()+1}-${mDate.getDate()}`);
}
previousDay(2016,9,30);
previousDay(2016,10,1);
