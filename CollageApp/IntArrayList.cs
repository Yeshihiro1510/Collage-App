namespace CollageApp;

public class IntArrayList
{
    private const int defaultCapacity = 2;
    private int[] _buffer;
    
    public IntArrayList()
    {
        _buffer = new int[defaultCapacity];
        Console.WriteLine($"Initialized with {defaultCapacity} capacity");
    }

    public IntArrayList(int capacity)
    {
        _buffer = new int[capacity];
        Console.WriteLine($"Initialized with {capacity} capacity");
    }
    
    public int Count
    {
        get
        {
            int count = 0;
            foreach (var item in _buffer)
            {
                if (item != 0)
                    count++;
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
        var targetIndex = GetLastIndex() + 1;
        if (targetIndex == Capacity)
        {
            Console.WriteLine($"Expanding from {_buffer.Length} to {_buffer.Length * 2}");
            var buffer = new int[_buffer.Length * 2];
            Array.Copy(_buffer, buffer, Math.Min(_buffer.Length, buffer.Length));
            _buffer = buffer;
        }

        _buffer[targetIndex] = obj;
        Console.WriteLine($"Pushed {obj} at {targetIndex}");
    }

    public void PopBack()
    {
        if (Count < 1) return;
        var lastIndex = GetLastIndex();
        var result = _buffer[lastIndex];
        _buffer[lastIndex] = 0;
        Console.WriteLine($"Popped {result} from {lastIndex}");
    }

    public bool TryInsert(int index, int value)
    {
        if (index > Capacity || index < 0) return false;
        _buffer[index] = value;
        Console.WriteLine($"Inserted {value} at {index}");
        return true;
    }

    public bool TryErase(int index)
    {
        if (index > Capacity || index < 0 || _buffer[index] == 0) return false;
        Console.WriteLine($"Erased {_buffer[index]} from {index}");
        _buffer[index] = 0;
        return true;
    }

    public bool TryGetAt(int index, out int? result)
    {
        result = null;
        if (index > Capacity || index < 0 || _buffer[index] == 0) return false;
        result = _buffer[index];
        return true;
    }

    public int? Find(int? value)
    {
        return _buffer.First(v => v == value);
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
        for (var i = 0; i < _buffer.Length; i++)
        {
            _buffer[i] = 0;
        }
    }

    private int GetLastIndex()
    {
        var last = -1;
        for (var i = 0; i < _buffer.Length; i++)
        {
            if (_buffer[i] != 0) last = i;
        }

        return last;
    }
}