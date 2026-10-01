namespace CollageApp;

public class IntArrayList
{
    public const int DefaultCapacity = 2;

    private int[] _buffer;

    public IntArrayList()
    {
        _buffer = new int[DefaultCapacity];
        Console.WriteLine($"Initialized with {DefaultCapacity} capacity\n");
    }

    public IntArrayList(int capacity)
    {
        _buffer = new int[capacity];
        Console.WriteLine($"Initialized with {capacity} capacity\n");
    }

    public int Count
    {
        get
        {
            var count = 0;
            foreach (var item in _buffer)
            {
                if (item != 0) count++;
            }

            return count;
        }
    }
    public int Capacity => _buffer.Length;

    public int this[int index]
    {
        get => _buffer[index];
        set => _buffer[index] = value;
    }

    public void PushBack(int obj)
    {
        var targetIndex = GetLastItemIndex() + 1;
        CheckAndExpandCapacity(targetIndex);
        _buffer[targetIndex] = obj;
        Console.WriteLine($"Pushed {obj} to {targetIndex}");
        Console.WriteLine($"Count: {Count}\n");
    }

    public void PopBack()
    {
        if (Count < 1) return;
        var lastIndex = GetLastItemIndex();
        var result = _buffer[lastIndex];
        _buffer[lastIndex] = 0;
        Console.WriteLine($"Popped {result} from {lastIndex}");
        Console.WriteLine($"Count: {Count}\n");
    }

    public bool TryInsert(int index, int value)
    {
        if (index < 0) return false;

        if (index > Capacity)
        {
            CheckAndExpandCapacity(index);
        }

        if (_buffer[index] != 0)
        {
            var firstFreeIndex = GetLastItemIndex() + 1;
            CheckAndExpandCapacity(firstFreeIndex);
            for (var i = firstFreeIndex; i > index; i--)
            {
                _buffer[i] = _buffer[i - 1];
            }
        }

        _buffer[index] = value;
        for (var i = 0; i < index; i++)
        {
            Console.WriteLine(_buffer[i]);
        }

        Console.WriteLine("> " + value);
        for (var i = index + 1; i < Capacity; i++)
        {
            Console.WriteLine("v " + _buffer[i]);
        }

        Console.WriteLine();

        return true;
    }

    public bool TryErase(int index)
    {
        if (index > Capacity || index < 0 || _buffer[index] == 0) return false;

        _buffer[index] = 0;

        for (var i = index; i < GetLastItemIndex() ; i++)
        {
            _buffer[i] = _buffer[i + 1];
        }

        for (var i = 0; i < index; i++)
        {
            Console.WriteLine(_buffer[i]);
        }

        Console.WriteLine("-");
        for (var i = index; i < Capacity; i++)
        {
            Console.WriteLine("^ " + _buffer[i]);
        }

        Console.WriteLine();

        return true;
    }

    public bool TryGetAt(int index, out int result)
    {
        result = 0;
        if (index > Capacity || index < 0 || _buffer[index] == 0) return false;
        result = _buffer[index];

        return true;
    }

    public int Find(int value)
    {
        for (var i = 0; i < _buffer.Length; i++)
        {
            var obj = _buffer[i];
            if (obj == value) return i;
        }

        return -1;
    }

    public bool TryForceCapacity(int newCapacity)
    {
        if (newCapacity < 0) return false;

        Console.WriteLine($"Forcing capacity from {Capacity} to {newCapacity}");
        var buffer = new int[newCapacity];
        Array.Copy(_buffer, buffer, Math.Min(_buffer.Length, buffer.Length));
        _buffer = buffer;

        return true;
    }

    public void Clear()
    {
        _buffer = new int[DefaultCapacity];
        Console.WriteLine($"Cleared, capacity: {DefaultCapacity}, count: {Count}\n");
    }

    private int GetLastItemIndex()
    {
        var last = -1;
        for (var i = 0; i < _buffer.Length; i++)
        {
            if (_buffer[i] != 0) last = i;
        }

        return last;
    }

    private void CheckAndExpandCapacity(int targetIndex)
    {
        while (targetIndex >= Capacity)
        {
            TryForceCapacity(Capacity * 2);
        }
    }
}