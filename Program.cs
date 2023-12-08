int v1 = 1;
int v2 = 2;
int v3 = 5;
double s = 100;
double s1 = 0;
double s2 = 0;
int count = 0;
double t = 0;

while(s>1)
{
    if(count%2==0)
    {
        t = s/(v2+v3);
        s1 = v1*t;
        s2 = v2*t;
        s = s - s1 - s2;  
        count++;
    }

    if(count%2!=0)
    {
        t = s/(v1+v3);
        s1 = v1*t;
        s2 = v2*t;
        s = s - s1 - s2;
        count++;
        
    }
    
}

Console.WriteLine(count);