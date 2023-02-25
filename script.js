let mebleg=1560;
let odenilecekmebleg
if(mebleg<100){
    let odenilecekmebleg=( mebleg-((mebleg/100)*5))
    console.log(odenilecekmebleg);
    
}else if(100<=mebleg && mebleg<=1000){
    let odenilecekmebleg=( mebleg-((mebleg/100)*8))
    console.log(odenilecekmebleg);
}else if(1000< mebleg){
    let odenilecekmebleg=( mebleg-((mebleg/100)*10))
    console.log(odenilecekmebleg);
}else{
    console.log("I don't know");
}