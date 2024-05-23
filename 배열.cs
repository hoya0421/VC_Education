using System;

class Program {
  public static void Main (string[] args) {
    //배얼을 초기화하는 첫 번째 방법
    int[] array1=new int[3];
    array1[0]=10;
    array1[1]=20;
    array1[2]=30;

    //배얼을 초기화하는 두 번째 방법
    int[] array2={10,20,30};  //자동으로 값이 저장 

    //배열을 초기화하는 세번째 방법
    int[] array3={4,5,6};
    
    //Console.WriteLine(array1[0]);
    //Console.WriteLine(array2[1]);
    //Console.WriteLine(array3[2]);

    //Console.WriteLine(array3.Length);            // Leangth을 활용해여 출력
    //for(int i=0; i<array3.Length; i++)
    //Console.WriteLine(array2[i]);

    foreach(int i in array3)
    Console.WriteLine(i);
    
    

    //array.Length - 배열의 갯수를 반환함. 
  }
}