
//Problem 1 Exchange if greater

var a = 5;
var b = 3;

if (a > b) {
	
	console.log(b, a);
}




//Problem 2  Multiplication Sign

var a = 2;
var b = 3;
var c = 4;

if (a*b*c == 0) {
	
	console.log("0");
} else if (a*b*c < 0) {
	

	console.log("+");
} else {
	
	console.log("-");
} 


//Probelm 3  The biggest of Three

var a = 27; // change value fora different result
var b = 33; // change value fora different result
var c = 77; // change value fora different result



if (a >= b) {

    if (a > c) {
    	console.log(a + " " + "the biggest number");
    } else {
      
       if (c >= b) {
         
         console.log(c + " " + "the biggest number");
       }
      
   }
} else {
  
   if ( b>= c) {
     
     console.log(b + " " + "the biggest number");
   } else {
     console.log(c + " " + "the biggest number");
   }
}

//Problem 4

var a = 123; //change value for a different result
var b = -114; //change value for a different result
var c = 15; //change value for a different result


if (a<=b) {
   if(b<c) {
      console.log(c,b,a); 
	       }
    else{

	   	          if (c > a) {
	   	    	       console.log(b,c,a);
	   	              }
                  else { 
	   	              	   if (a>b) {

	   	              		console.log(a,b,c);
	   	              	   } 
                           else (
	   	              		console.log(b,a,c)
                           );


	   	              }                  	    	

	   }   

} 

else { 
      if (a<c) {
  
          console.log(c,a,b);
      }
      else {
            if (b > c) {
                console.log(a,b,c);
            }
            else {
                console.log(a,c,b);
            }
      }
}


//Problem 5 Digit as word

var number = 8;//change value for a diferent result

switch(number) {
    
    case 0: console.log("Zero");break;
    case 1: console.log("One"); break;
    case 2: console.log("Two"); break;
    case 3: console.log("Three"); break;
    case 4: console.log("Four"); break;
    case 5: console.log("Five"); break;
    case 6: console.log("Six"); break;
    case 7: console.log("Seven"); break;
    case 8: console.log("Eight"); break;
    case 9: console.log("Nine"); break;
    
  default: console.log("Please write a valid number");
}


//Problem 6 Quadratic equation
var a,
    b,
    c,
    x,
    y1,
    y2;

function root (a,b,c) {
  
   var d = b*b - 4*a*c;
   
  //Quadratic equation is ax2 + bx + c = 0. If a=0 then x = -c/b
   if (a === 0) {
     
     console.log("Thgere is only one root:" + " " + ((-c)/b));
     return;
   }
   
  
   if (d<0) {
        
        console.log("There are no real roots");
      }
      
  
      else if (d === 0) {
        
        x = -b/(2*a);
        console.log("There is only one root and it is:" + " " + x);   
        
        }
  
        else {
       
           y1 = ((-b) + Math.sqrt(d))/ (2*a);
           y2 = ((-b) - Math.sqrt(d)) / (2*a);
           console.log ("There are two roots:" + " " + y1 + " " + "and" + " " + y2);
       
        } 
}


//Problem 7 The biggest of five numbers

//change value for a different result
var a = 9;
var b = 332;
var c = 5555;
var d = 61;
var e = 444444;

var arr = [a,b,c,d,e];
var MAX = arr[0];

 function theBiggest () {
    
      for (i=0; i<arr.length; i+=1) {
         if (arr[i] > MAX) {
         MAX = arr[i];  
    }
         
      }
   console.log(MAX);
}


theBiggest();

//Problem 8 is missing 

