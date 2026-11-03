public interface INondestructiveSet<T> {
    public INondestructiveSet<T> Intersection(INondestructiveSet<T> other);
    public INondestructiveSet<T> Union(INondestructiveSet<T> other);
    public INondestructiveSet<T> Difference(INondestructiveSet<T> other);
    public bool Contains(T elem);
}

public class NondestructiveHashSet<T> : HashSet<T>, INondestructiveSet<T> {
    // The intersection contains all elements that are in both sets.
    private INondestructiveSet<T> IntersectImpl(INondestructiveSet<T> other) {
        // Piggyback off of HashSet<T>.IntersectWith()
        base.IntersectWith(other);
        return;
    }

    private INondestructiveSet<T> UnionImpl(INondestructiveSet<T> other) {
        // Piggyback off of HashSet<T>.UnionWith()
        base.UnionWith(other);
        return;
    }

    public new bool Contains(T elem) {
        return base.Contains(elem);
    }
   
    public INondestructiveSet<T> Intersection(INondestructiveSet<T> other) {
        // This is all *just* to clone the current hash set.
        T[] tmp = T[base.Count];
        base.CopyTo(tmp);
        var clone = (INondestructiveSet<T>) new HashSet<T>(tmp);

        
        clone.IntersectImpl(other);

        return clone;
    }

    // The union contains all elements that are in at least one of the sets.
    public INondestructiveSet<T> Union(INondestructiveSet<T> other) {
        // This is all *just* to clone the current hash set.
        T[] tmp = T[base.Count];
        base.CopyTo(tmp);
        var clone = (INondestructiveSet<T>) new HashSet<T>(tmp);

        // Piggyback off of HashSet<T>.UnionWith()
        clone.UnionImpl(other);

        return clone;
    }

    // The difference contains all elements from one set that are not in another set.
    public INondestructiveSet<T> Difference(INondestructiveSet<T> other) {
        // All of this just to loop over ourselves.
        // I hate C#
        T[] tmp = T[base.Count];
        base.CopyTo(tmp);

        var result = new INondestructiveSet<T>();
        
        foreach (T elem in tmp) {
            if (!other.Contains(elem)) {
                result.Add(elem);
            } 
        }

        return result;
    }

    /*
        returns true if and only if the NondestructiveSet<T> argument it
        receives has no elements in common with itself.
    */
    public bool IsDisjoint(INondestructiveSet<T> other) {
        // All of this just to loop over ourselves.
        // I hate C#
        T[] tmp = T[base.Count];
        base.CopyTo(tmp);

        foreach (T elem in tmp) {
            if (other.Contains(elem)) {
                return false;
            }
        }

        return true;
    }

    /*
        returns true if and only if all elements in its parameter 
        (of type NondestructiveSet<T>) exist in itself
    */
    public bool IsSubset(INondestructiveSet<T> other) {
        // All of this just to loop over ourselves.
        // I hate C#
        T[] tmp = T[base.Count];
        base.CopyTo(tmp);

        foreach (T elem in tmp) {
            if (!other.Contains(elem)) {
                return false;
            }
        }

        return true;
    }
}

public class Program {
    public static void Main(string[] args) {
        
    }
}