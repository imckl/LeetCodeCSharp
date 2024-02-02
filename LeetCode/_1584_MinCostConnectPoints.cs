namespace LeetCode;

public class _1584_MinCostConnectPoints
{
    // readonly record struct PointWithDistance(int Distance, int X, int Y);
    //
    // // public int MinCostConnectPoints(int[][] points)
    // // {
    // //     // var pointsWithDistance = new List<(int distance, int[] point)>();
    // //     //
    // //     // var n = points.Length;
    // //     //
    // //     // for (var i = 0; i < n; i++)
    // //     // {
    // //     //     for (var j = i + 1; j < n; j++)
    // //     //     {
    // //     //         var pointWithDistance = new PointWithDistance(
    // //     //             CalcDistance(points[i], points[j]), points[j][0], points[j][1]);
    // //     //     }
    // //     // }
    // //
    // //     // if (points.Length == 1)
    // //     // {
    // //     //     return 0;
    // //     // }
    // //     //
    // //     // var ans = 0;
    // //
    // //     // var farthestPoint = points.Select(point =>
    // //     //     {
    // //     //         var distance = CalcDistance(point, new[] { 0, 0 });
    // //     //         return (distance, point);
    // //     //     })
    // //     //     .MaxBy(x => x.distance)
    // //     //     .point ?? throw new NullReferenceException();
    // //     //
    // //     // points = points.Select(point =>
    // //     //     {
    // //     //         var distance = CalcDistance(point, farthestPoint);
    // //     //         return (distance, point);
    // //     //     })
    // //     //     .OrderBy(x => x.distance)
    // //     //     .Select(x => x.point)
    // //     //     .ToArray();
    // //
    // //     // points = points.Select(point =>
    // //     //     {
    // //     //         var distance = CalcDistance(point, new[] { 0, 0 });
    // //     //         return (distance, point);
    // //     //     })
    // //     //     .OrderBy(x => x.distance)
    // //     //     .Select(x => x.point)
    // //     //     .ToArray();
    // //
    // //     // Array.Sort(points, (a, b) => a[0] < b[0] ? -1 : a[0] == b[0] ? 0 : 1);
    // //     // var newPoints = points.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
    // //
    // //     for (var i = 1; i < points.Length; i++)
    // //     {
    // //         var distance = int.MaxValue;
    // //
    // //         for (var j = 0; j < i; j++)
    // //         {
    // //             var curr = CalcDistance(points[i], points[j]);
    // //             distance = Math.Min(curr, distance);
    // //         }
    // //
    // //         ans += distance;
    // //     }
    // //
    // //     return ans;
    // // }
    //
    // public int MinCostConnectPoints(int[][] points)
    // {
    //     var ans = 0;
    //
    //     var n = points.Length;
    // }
    //
    // int CalcDistance(int[] pointA, int[] pointB) =>
    //     Math.Abs(pointA[0] - pointB[0]) + Math.Abs(pointA[1] - pointB[1]);
}
