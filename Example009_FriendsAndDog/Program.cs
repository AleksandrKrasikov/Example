int FirstFriendsSpeed = 1;
int SecondFriendsSpeed = 2;
int DogSpeed = 5;
int count = 0;
int Distance = 10000;
int time = 0;
int Friend = 2;
while(Distance >10)
{
    if (Friend == 1)
    {
        time = Distance / (FirstFriendsSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        time = Distance / (SecondFriendsSpeed + DogSpeed);
        Friend = 1;
    }
    Distance = Distance - ((FirstFriendsSpeed + SecondFriendsSpeed) * time);
    count = count + 1;
}
Console.WriteLine(count);