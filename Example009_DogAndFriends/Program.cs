Console.Clear();

double speed1 = 1;
double speed2= 2;
double speedDog = 5;
double maxDistance = 1000;
int count = 1;
double minDistance = 3;
double speedAllFriends = speed1 + speed2;
double speed1andDog = speed1 + speedDog;
double speed2andDog = speed2 + speedDog;

while(maxDistance > minDistance)
{
    if(count % 2 == 0)
    {
        maxDistance = maxDistance - maxDistance / speed1andDog*speedAllFriends;
        count++;
    }
    else
    {
        maxDistance = maxDistance - maxDistance / speed2andDog*speedAllFriends;
        count++;
    }
    Console.WriteLine($"Растояние между друзьями {maxDistance} метров!");
}
Console.WriteLine($"Собака пробежала {count} раз между друзьями!");
