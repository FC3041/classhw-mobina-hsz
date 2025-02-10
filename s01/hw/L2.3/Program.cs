// void head(int w){
//     var k;
//     if(w%2==0){
//         k= w/2 + 1;}
//     if(w%2==1){
//         k = (w-1)/2 + 1 ;
//     }
//     console.Write(k * " " + "^" +k * " " );
//      for(int i=1; i<k ; i++){
//       console.Write(" " * (k-i)+ 
//             i*"/" + "|" +
//             i*"\\" + (k-i)*" ");
//     }
// }

void head(int w ){
    int k = (w/2) + 1;
    for(int i=0 ; i<k ; i++){
        Console.Write(" ");
    }
    Console.Write("^");
    for(int i=0 ; i<k ; i++){
        Console.Write(" ");
    }
    Console.WriteLine("");
    // Console.Write(k*" " + "^" +k * " " );
    for(int i=1 ; i<k ; i++){
        for(int j=0 ; j<k-i ; j++){
            Console.Write(" ");
        }
        for(int j=0 ; j<i ; j++){
            Console.Write("/");
        }
        for(int j=0 ; j<i ; j++){
            Console.Write("\\");
        }
        for(int j=0 ; j<k-i ; j++){
            Console.Write(" ");
        }
        Console.WriteLine("");
    //   Console.Write(" " * (k-i)+  i*"/" + "|" + i*"\\" + (k-i)*" ");
    }
}

void line(int w){
    Console.Write("+");
    for(int i=0 ; i<w ; i++)
        Console.Write("-");
    Console.WriteLine("+");
}

void body(int h , int w){
    for(int i=0; i<h ; i++){
        Console.Write("+");
        for(int j=0 ;j<w ; j++)
            Console.Write("*");
        Console.WriteLine("+");
    }
    line(w);
}

void peice(int n , int w , int h){
    line(w);
   for(int i=0;i<n;i++){
      body(w,h);
   }
}

void rocketship(int n , int w , int h){
    head(w);
    peice(n,w,h);
    head(w);
}

rocketship(2,7,7);