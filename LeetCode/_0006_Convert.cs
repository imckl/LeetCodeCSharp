using System.Text;

namespace LeetCode;

public class _0006_Convert
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }

        var resultBuilder = new StringBuilder();
        // var result = "";

        var len = s.Length;

        {
            var step = (numRows - 1) * 2;
            var i    = 0;
            while (i < len)
            {
                // result += s[i];
                resultBuilder.Append(s[i]);

                if (i + step > len)
                {
                    break;
                }

                i += step;
            }
        }

        for (var n = 1; n < numRows - 1; n++)
        {
            var evenStep = (numRows - 1 - n) * 2;
            var oddStep  = n                 * 2;

            var i     = n;
            var count = 0;
            while (i < len)
            {
                // result += s[i];
                resultBuilder.Append(s[i]);

                var step = count % 2 == 0 ? evenStep : oddStep;

                if (i + step > len)
                {
                    break;
                }

                i += step;
                count++;
            }
        }

        {
            var step = (numRows - 1) * 2;
            var i    = numRows - 1;
            while (i < len)
            {
                // result += s[i];
                resultBuilder.Append(s[i]);

                if (i + step > len)
                {
                    break;
                }

                i += step;
            }
        }

        // return result;
        return resultBuilder.ToString();
    }
}
