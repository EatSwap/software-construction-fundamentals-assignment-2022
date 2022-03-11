namespace LinkedListForEach;

using System.Collections;

public class Node<T> {
	public Node<T>? Next { get; set; }
	public T Data { get; set; }

	public Node(T t) {
		Data = t;
		Next = null;
	}
}

public class GenericList<T> : IEnumerable<T> {
	private Node<T>? head;
	
	private Node<T>? tail;
	
	public GenericList() {
		tail = head = null;
	}

	public Node<T> Head {
		get => head;
	}

	public void Add(T t) {
		Node<T> n = new Node<T>(t);
		if (tail == null) {
			head = tail = n;
		} else {
			tail.Next = n;
			tail = n;
		}
	}
	
	public IEnumerator<T> GetEnumerator() {
		Node<T>? ptr = head;
		while (ptr != null) {
			yield return ptr.Data;
			ptr = ptr.Next;
		}
	}
	
	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public void ForEach(Action<T> func) {
		foreach (var t in this) {
			func(t);
		}
	}
}
