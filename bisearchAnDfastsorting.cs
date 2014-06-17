/*
* Created by SharpDevelop.
* User: crazybee
* Date: 6/16/2014
* Time: 4:29 PM
* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.IO;

namespace Hello
{
	class Program
	{
		
		public static int findmax(int a, int b){
			if (a > b) return a;
			else return b;
		
		
		}
		
		/*
		* 
		* 
		* binary search and print out the index
		* 
		* 
		*/
		public static void bisearch(int[] A,int number){
			
			int length = A.Length;
			int left = 0;
			int right = length-1;
			int index = (right+left)/2;
			while(left <= right){	
				
				if (A[index] < number){left = index+1;}
				else if (A[index] > number){right = index-1;}
				else {
					Console.WriteLine("bi-searched number found at {0}",index);
					break;
				}
				
				index = (right+left)/2;
			}
			
			if (left > right) Console.WriteLine("not found");;   //没有找到
		
		
		
		}
		
		/*bubble method to find max integer in an array
		* 
		*
		**/
		
		public static void findmax(int [] A){
			int length = A.Length;
			int max = A[0];
			for (int i = 1; i < length;i++){
				if (A[i] > max){max = A[i];}
			
			
			
			
			}
			Console.WriteLine("max is {0}",max);
		
		
		
		
		}
		public static int fastsort(int[] A, int start, int end){
		
			int length = A.Length;
			int left = start;
			int right = end;
			int x = A[left];
			while (left < right){
			   
				while (left < right && x <= A[right])
				
					right --;
				if (left < right){
					
					A[left] = A[right];
					left ++;
				}
				
				while (left < right && x >= A[left])
				
					left ++;
				if (left < right){
					
					A[right] = A[left];
					right --;
				}
				
						
			
					
			}
			
			A[left] = x;
			
		
			return left ;
		
		
		
		
		}
	
		
		
		public static void usequicksort(int [] A, int left, int right){
			//Console.WriteLine("");
			//Console.WriteLine("in quicksort");
		
			if (left < right){
			
				int i = fastsort(A,left,right);
		
				usequicksort(A,left,i-1);
				usequicksort(A,i+1,right);
			
			
			}
		
		
	
		
		}
		
		
		
		
		
		
		
		public static void Main(string[] args)
		{
			int inputA = 0;
			int inputB = 0;
			
			int [] B = {1,2,3,4,5,6,9};
			int [] sort = {33,45,12,36,78,7,90,12,234,11,234,55};
			 
			foreach(int i in sort){
			
				Console.Write(i+",");
			
			}
			//Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Console.WriteLine("");
			Console.Write("please input number a");
			inputA = int.Parse(Console.ReadLine());
			Console.WriteLine("");
			Console.Write("please input nubmer b");
			inputB = int.Parse(Console.ReadLine());
			bisearch(B,100);
			findmax(B);
			Console.WriteLine("max number is {0}",findmax(inputA ,inputB));
			usequicksort(sort,0,sort.Length-1);
			Console.WriteLine(" ");
			foreach (int i in sort){
			
				Console.Write(i+",");
			
			}
			Console.ReadKey();
			
		}
	}
}