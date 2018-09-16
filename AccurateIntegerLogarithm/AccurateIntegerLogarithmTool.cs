using System.Text;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AccurateIntegerLogarithm {
  public class AccurateIntegerLogarithmTool {
    static Dictionary<uint, AccurateIntegerLogarithmTool> _lookupTables = new Dictionary<uint, AccurateIntegerLogarithmTool>();

    struct Node {
      public ulong input;
      public uint output;
    }

    public AccurateIntegerLogarithmTool(int @base) : this((uint)@base) {
          if (@base < 0 ) {
            throw new ArgumentException("base must be > 1");
          }
    }
    public AccurateIntegerLogarithmTool(uint @base) {
      if (@base <= 1 ) {
        throw new ArgumentException("base must be > 1");
      }

      _base = @base;

      var reference = this;
      if (!_lookupTables.TryGetValue(@base, out reference)) {
        // generate sorted list of all the logarithms 
        var tmp = new List<Node>();
        unchecked { 
          for (ulong c = _base, oldc = 0, i = 1; c > oldc; oldc = c, c *= _base, i++) {
            tmp.Add(new Node { input = c, output = (uint)i });
          }
        }

        var last = tmp.Last();
        MaxInput = last.input;
        MaxOutput = last.output;

        _lookup = new Node[nextPowerOf2(tmp.Count)*2];
        Build(tmp, tmp.Count / 2, 0, tmp.Count, 0);

        lock (_lookupTables) {
          if (!_lookupTables.ContainsKey(@base)) {
            _lookupTables[@base] = this;
          }
        }
      } else {
        MaxInput = reference.MaxInput;
        MaxOutput = reference.MaxOutput;
        _lookup = reference._lookup;
      }
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public uint Log(long value) {
      if (value < _base) { return 0; }

      return DoLog((ulong)value);
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public uint Log(ulong value) {
      if (value < (uint)_base) { return 0; }

      return DoLog((ulong)value);      
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    uint DoLog(ulong value) {
      int i = 0;
      int mini=0;
      while (true) {
        if (i >= _lookup.Length || _lookup[i].output == 0) {
          return _lookup[mini].output;
        }
        if (_lookup[i].input > value) { i = i*2+1; }
        else { mini = i; i = i*2+2; }
      }
    }

    void Build(List<Node> source, int sc, int smin, int smax, int dc) {
      if (sc < smin || sc >= smax) { return; }

      _lookup[dc] = source[sc];

      if (smin >= smax) { return; }

      Build(source, sc - (1 + sc - smin)/2, smin, sc, dc*2 + 1);
      Build(source, sc + (smax - sc)/2, sc+1, smax, dc*2 + 2);
    }

    static int nextPowerOf2(int n)
    {
      var val = 1;
      while (n > val) {
        val *= 2;
      }
      return val;
    }

    public override string ToString() {
      var res = new StringBuilder();
      res.Append("LogLookupTable<");
      res.Append(_base);
      res.Append(">(");
      var prefix = string.Empty;
      for (int i = 0; i < _lookup.Length; i++) {
        res.Append(prefix);
        res.Append("[");
        res.Append("index=" + i + ",input=");
        res.Append(_lookup[i].input.ToString());
        res.Append(",output=");
        res.Append(_lookup[i].output.ToString());
        res.Append("]");
        prefix = ",";
      }
      return res.ToString();
    }

    Node [] _lookup;
    uint _base;
    public ulong MaxInput;
    public uint MaxOutput;
  }
}
