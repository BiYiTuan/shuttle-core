#if NET35FULL || NET40FULL
using System;
using System.Collections;
using System.Collections.Generic;

namespace Shuttle.Core.Infrastructure
{
	public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
	{
		private readonly IDictionary<TKey, TValue> dictionary;

		public ReadOnlyDictionary()
		{
			dictionary = new Dictionary<TKey, TValue>();
		}

		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			this.dictionary = dictionary;
		}

		public void Add(TKey key, TValue value)
		{
			throw new NotSupportedException("This dictionary is read-only");
		}

		public bool ContainsKey(TKey key)
		{
			return dictionary.ContainsKey(key);
		}

		public ICollection<TKey> Keys
		{
			get { return dictionary.Keys; }
		}

		public bool Remove(TKey key)
		{
			throw new NotSupportedException("This dictionary is read-only");
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return dictionary.TryGetValue(key, out value);
		}

		public ICollection<TValue> Values
		{
			get { return dictionary.Values; }
		}

		public TValue this[TKey key]
		{
			get { return dictionary[key]; }
			set { throw new NotSupportedException("This dictionary is read-only"); }
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("This dictionary is read-only");
		}

		public void Clear()
		{
			throw new NotSupportedException("This dictionary is read-only");
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return dictionary.Contains(item);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			dictionary.CopyTo(array, arrayIndex);
		}

		public int Count
		{
			get { return dictionary.Count; }
		}

		public bool IsReadOnly
		{
			get { return true; }
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("This dictionary is read-only");
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return dictionary.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (dictionary as IEnumerable).GetEnumerator();
		}
	}
}
#endif