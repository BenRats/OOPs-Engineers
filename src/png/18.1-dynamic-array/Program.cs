using System.Text;

public interface IDynArray<T> {
    public void Append(T elem);
    public void Insert(int idx, T elem);
    public void Remove(int idx);
    public void Set(int idx, T elem);
    public T Get(int idx);
    public int GetCurrentCapacity();
}

public class DynArray<T> : IDynArray<T> {
    private T?[] data = new T[0];
    private int currentCapacity = 0;
    private int maxCapacity = 0;

    private void EnlargeArray() {
        // Doubles the size of the array and updates the fields to match
        // This array sucks because it only ever grows and never shrinks.
        int newCapacity = maxCapacity * 2;
        if (newCapacity == maxCapacity) {
            // maxCapacity can be set to 0, in which case 0 * 2 is still 0!
            newCapacity = (maxCapacity + 1) * 2;
        }
        T[] newArray = new T[newCapacity];
        for (int i = 0; i < this.data.Length; i++) {
            // Copy elems from prev array over to new one.
            newArray[i] = this.data[i];
        }

        this.currentCapacity = this.data.Length;
        this.maxCapacity = newCapacity;
        this.data = newArray;
    }
    
    public void Append(T elem) {
        if (currentCapacity + 1 > maxCapacity) {
            this.EnlargeArray();
        }
        this.currentCapacity += 1;
        this.data[currentCapacity - 1] = elem;
    }
    
    public void Insert(int idx, T elem) {
        // I'm not sure how to implement this, sorry.
        if (idx > this.maxCapacity) {
            // Figure out how much to enlarge the array.
            // 
            // Enlarge one more time to be safe always
            // Hey, I didn't say this was an efficient dynamic array lol
            int howMuchToEnlarge = (idx / this.maxCapacity) + 1;
            for (int i = 0; i < howMuchToEnlarge; i++) {
                this.EnlargeArray();
            }
        }
        this.data[idx] = elem;
    }
    
    public void Remove(int idx) {
        this.data[idx] = default(T);
    }
    
    public void Set(int idx, T elem) {
        this.data[idx] = elem;
    }
    
    public T Get(int idx) {
        return this.data[idx];
    }

    public int GetCurrentCapacity() {
        return this.currentCapacity;
    }

    public override string ToString() {
        StringBuilder result = new StringBuilder("(");
        for (int i = 0; i < this.data.Length; i++) {
            var elem = this.data[i];
            if (elem == null) {
                result.Append("null");
            } else {
                result.Append(elem.ToString());
            }

            if (i < this.data.Length) {
                result.Append(", ");
            }
        }
        result.Append(")");
        return result.ToString();
    }
}

public class Program {
    public static void Main(string[] args) {
        IDynArray<int> arr = new DynArray<int>();
        Console.WriteLine(arr);
        for (int i = 0; i < 20; i++) {
            arr.Append(i);
            Console.WriteLine(arr);
        }
        Console.WriteLine("");

        Random rand = new Random();
        Console.WriteLine("Remove elements:");
        Console.WriteLine(arr);
        for (int i=19 ; i>=0 ; i--) {
            arr.Remove(rand.Next(arr.GetCurrentCapacity()));
            Console.WriteLine(arr);
        }
    } 
}