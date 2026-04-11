// 1
// int max = int.MinValue;
// while (true)
// {
//     int a = int.Parse(Console.ReadLine());
//     if(a==0) break;
//     else if(a>max) max=a;
// }
// System.Console.WriteLine(max);


// 2
// int a = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// double sum=0;
// for(int i=0; i<=n; i++)
// {
//     sum+=Math.Pow(a, i);
// }
// System.Console.WriteLine(sum);


// 3
// int sum=0;
// int a1, a2;
// a1 = Convert.ToInt32(Console.ReadLine());
// sum=a1;
// while (true)
// {
//     a2 = Convert.ToInt32(Console.ReadLine());
//     if(a1==0 && a2 == 0) break;
//     sum+=a2;
//     a1=a2;
// }
// System.Console.WriteLine(sum);


// 4
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for(int i=0; i<a; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }

// string result = "NO";
// for(int i=0; i<nums.Length-1; i++)
// {
//     if(nums[i]>0 && nums[i+1]>0 || nums[i]<0 && nums[i + 1] < 0)
//     {
//         result = "YES";
//         break;
//     }
// }
// System.Console.WriteLine(result);

// 5
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for(int i=0; i<a; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }

// for(int i=0; i<nums.Length; i++)
// {
//     int x = nums[i];
//     int cnt = 0;
//     for(int j=0; j<nums.Length; j++)
//     {
//         if(x==nums[j]) cnt++;
//     }
//     if(cnt>1) System.Console.Write(x+" ");
// }



// 6
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for(int i=0; i<a; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }

// int min = nums[0];

// for(int i=0; i<nums.Length; i++)
// {
//     if(nums[i]<min) min=nums[i];
// }

// System.Console.WriteLine(min);


// 7
// int sum = 0;
// int cnt = 0;

// while (true)
// {
//     System.Console.Write(@"Give a number
// > ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if(a==0) break;
//     sum+=a;
//     cnt++;
// }

// System.Console.WriteLine($"Sum of numbers: {sum}");
// System.Console.WriteLine($"Count of numbers: {cnt}");


// 8
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int mlt = 1;
// for(int i=a; i>0; i /= 10)
// {
//     sum+=i%10;
//     mlt*=i%10;
//     System.Console.Write(i%10+"=");
// }
// System.Console.WriteLine(sum);
// System.Console.WriteLine(mlt);

//9
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i=a;i>0;i/=10){
//     System.Console.Write(i%10);
// }
// System.Console.WriteLine(" ");

//10
// int n = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[n];
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     int x = nums[i];
//     bool prime = true;
//     if (x < 2) prime = false;
//     else
//     {
//         for (int j = 2; j * j <= x; j++)
//         {
//             if (x % j == 0)
//             {
//                 prime = false;
//                 break;
//             }
//         }

//     if (!prime)
//         Console.Write(x + " ");
// }
// }




//11
// float a = float.Parse(Console.ReadLine());
// if (a < 100)
// {
//     a=a+a*0.05;
// }
// else if(a<=200){
//     a = a + a * 0.07;
// }
// else
// {
//     a = a + a * 0.10;
// }
// System.Console.WriteLine(a);


//12
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for(int i=0; i<a; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }
// int sum=1;
// for(int i = 1; i<=a; i++)
// {
//     System.Console.Write(i+"*");
//     sum*=i;
// }
// System.Console.Write("="+sum);
// System.Console.WriteLine();

//13
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for(int i=0; i<a; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }
// int max = nums[0];
// for(int i = 0; i < nums.Length; i++)
// {
//     if (max < nums[i])
//     {
//         max=nums[i];
//     }
// }
// System.Console.WriteLine(max);

//14
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0; i<nums.Length; i++)
// {
//     int x = nums[i];
//     int cnt = 0;
//     for(int j=0; j<nums.Length; j++)
//     {
//         if(x!=nums[j]) cnt++;
//     }
//     if(cnt>1) System.Console.Write(x+" ");
// }
// System.Console.WriteLine();

//15
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }
// int minIndex = 0;
// for (int i = 1; i < a; i++)
// {
//     if (nums[i] < nums[minIndex])
//         minIndex = i;
// }

// Console.WriteLine(minIndex);


//16
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for (int i = 0; i < a; i++)
// {
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }
// int c = 0;
// for (int i = 1; i < a - 1; i++)
// {
//     if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
//     {
//         c++;
//     }
// }
// Console.WriteLine(c);


//17
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for (int i = 0; i < a; i++)
// {
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }
// int x = 0, y = 0;
// bool found = false;
// for (int i = 0; i < a - 1; i++)
// {
//     if ((nums[i] > 0 && nums[i + 1] > 0) || (nums[i] < 0 && nums[i + 1] < 0))
//     {
//         x = nums[i];
//         y = nums[i + 1];
//         found = true;
//     }
// }
// if (found)
// {
//     Console.WriteLine(x + " " + y);
// }


//18
// int a = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[a];
// for (int i = 0; i < a; i++)
// {
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i=0;i<a;i++){
//     if(nums[i]%2!=0) System.Console.Write(i+" ");
// }
