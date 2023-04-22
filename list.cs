using System;
public class listEx{
public void fab(){
var abc = new List<int> {0,1};
for(int i=0;i<20;i++){
int a = abc[abc.Count-1];
int b= abc[abc.Count-2];
int c=a+b;  
abc.Add(c);}
foreach(var q in abc)
  {
       Console.WriteLine(q);
    }}
}