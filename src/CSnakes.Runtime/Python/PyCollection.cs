﻿using System.Collections;

namespace CSnakes.Runtime.Python;

internal class PyCollection<TItem> : IReadOnlyList<TItem>
{
    public PyCollection(PyObject listObject)
    {
        throw new NotImplementedException();
    }

    public TItem this[int index] => throw new NotImplementedException();

    public int Count => throw new NotImplementedException();

    public IEnumerator<TItem> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
