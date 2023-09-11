namespace LeetCode;

public class _0008_MyAtoi
{
    // 题设主要考察有限状态机, 没有限定只能使用int
    // read all input
    public int MyAtoi(string s)
    {
        var automaton = new Automaton();

        foreach (var c in s)
        {
            automaton.Run(c);
        }

        return (int)automaton.Result;
    }

    class Automaton
    {
        enum State
        {
            Start,
            Signed,
            InNumber,
            End
        }

        public long Result;

        const long MaxInt = int.MaxValue;
        const long MinInt = int.MinValue;

        int   _sign  = 1;
        State _state = State.Start;

        /**
         *              ' '     +/-     number      other
         * Start        Start   Signed  InNumber    End
         * Signed       End     End     InNumber    End
         * InNumber     End     End     InNumber    End
         * End          End     End     End         End
         */
        readonly Dictionary<State, State[]> _stateTable = new()
        {
            { State.Start, new[] { State.Start, State.Signed, State.InNumber, State.End } },
            { State.Signed, new[] { State.End, State.End, State.InNumber, State.End } },
            { State.InNumber, new[] { State.End, State.End, State.InNumber, State.End } },
            { State.End, new[] { State.End, State.End, State.End, State.End } }
        };

        public void Run(char c)
        {
            _state = _stateTable[_state][GetStateCol(c)];

            switch (_state)
            {
                case State.InNumber:
                {
                    Result = Result * 10 + _sign * (c - '0');

                    if (Result > MaxInt)
                    {
                        Result = MaxInt;
                    }
                    else if (Result < MinInt)
                    {
                        Result = MinInt;
                    }

                    break;
                }
                case State.Signed:
                {
                    if (c == '-')
                    {
                        _sign = -1;
                    }

                    break;
                }
                case State.Start: break;
                case State.End:   break;
                default:          throw new ArgumentException();
            }
        }

        int GetStateCol(char c) => c switch
        {
            ' '                                                                => 0,
            '+' or '-'                                                         => 1,
            '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9' => 2,
            _                                                                  => 3
        };
    }
}

class _0008_MyAtoi_2
{
    enum State
    {
        ClearPrefixWhiteSpace,
        AppendDigit,
        FinishAssembly
    }

    enum Action
    {
        RemoveWhiteSpace,
        AppendSign,
        AppendDigit,
    }

    readonly List<char>      _chars      = new();
    readonly HashSet<Action> _actionsSet = new();

    readonly char[] _signs  = { '+', '-' };
    readonly char[] _digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    readonly Dictionary<char, int> _numsByChars = new()
    {
        { '0', 0 },
        { '1', 1 },
        { '2', 2 },
        { '3', 3 },
        { '4', 4 },
        { '5', 5 },
        { '6', 6 },
        { '7', 7 },
        { '8', 8 },
        { '9', 9 }
    };

    public int MyAtoi(string s)
    {
        var state = State.ClearPrefixWhiteSpace;

        foreach (var c in s)
        {
            state = Run(c, state);

            if (state == State.FinishAssembly)
            {
                break;
            }
        }

        if (!_actionsSet.Contains(Action.AppendDigit))
        {
            return 0;
        }

        return ParseListToInt(_chars);
    }

    State Run(char c, State state)
    {
        switch (state)
        {
            case State.ClearPrefixWhiteSpace:
                if (c == ' ')
                {
                    _actionsSet.Add(Action.RemoveWhiteSpace);
                    return State.ClearPrefixWhiteSpace;
                }

                if (_signs.Contains(c))
                {
                    _chars.Add(c);
                    _actionsSet.Add(Action.AppendSign);
                    return State.AppendDigit;
                }

                if (_digits.Contains(c))
                {
                    _chars.Add(c);
                    _actionsSet.Add(Action.AppendDigit);
                    return State.AppendDigit;
                }

                return State.FinishAssembly;
            case State.AppendDigit:
                if (_digits.Contains(c))
                {
                    _chars.Add(c);
                    _actionsSet.Add(Action.AppendDigit);
                    return State.AppendDigit;
                }

                return State.FinishAssembly;
            default:
                throw new ArgumentException();
        }
    }

    // 返回 int.MinValue, int.MaxValue 的判断条件的证明参考 _0007_Reverse
    int ParseListToInt(List<char> chars)
    {
        var isNegative = false;

        switch (chars[0])
        {
            case '-':
                isNegative = true;
                _chars.RemoveAt(0);
                break;
            case '+':
                _chars.RemoveAt(0);
                break;
        }

        var len = chars.Count;

        while (len > 0 && chars[0] == '0')
        {
            chars.RemoveAt(0);
            len--;
        }

        if (len == 0)
        {
            return 0;
        }

        var flag   = isNegative ? -1 : 1;
        var result = flag * _numsByChars[chars[0]];

        chars.RemoveAt(0);

        while (chars.Count > 0)
        {
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && _numsByChars[chars[0]] > 8))
            {
                return int.MinValue;
            }

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && _numsByChars[chars[0]] > 7))
            {
                return int.MaxValue;
            }

            result = result * 10 + flag * _numsByChars[chars[0]];

            chars.RemoveAt(0);
        }

        return result;
    }
}
