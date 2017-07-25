public static void RemoveAll<TKey,TValue>(this Dictionary<TKey,TValue> dicttionary, Func<KeyValuePair<TKey,TValue>,bool> condition)
{
    foreach (var current in dictionary.Where(condition).ToList() ) {
        dictionary.Remove(current.Key);
    }
}
