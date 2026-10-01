using CollageApp;

var array = new IntArrayList();

array.PushBack(GetRandomNum());
array.PushBack(GetRandomNum());
array.PushBack(GetRandomNum());

array.TryInsert(1, GetRandomNum());

array.TryErase(1);

array.TryGetAt(1, out var value);
Console.WriteLine($"Item in 1 is {value}\n");

array.PopBack();

array.Clear();

return;

int GetRandomNum() => Random.Shared.Next(100);