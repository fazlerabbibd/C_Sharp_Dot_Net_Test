
public static class DictionaryExtensions
{

    public static TValue myFunction<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue dval = default(TValue))
    {
        return dict.TryGetValue(key, out TValue value) ? value : dval;
    }

}
