var array = new object[15];
for (var i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(2) switch
    {
        0 => Random.Shared.Next(-100, 100),
        1 => Random.Shared.NextSingle() * 200f - 100f,
        // 2 => string.Empty,
        _ => throw new ArgumentOutOfRangeException()
    };
}

Console.WriteLine(ArraySum(array));

return;

float ArraySum(object[] array)
{
    var sum = 0f;
    
    foreach (var obj in array)
    {
        // Console.WriteLine(obj.GetType());
        if (obj is not (int or float)) continue;
        var value = Convert.ToSingle(obj);
        sum += value;
    }

    return sum;
}