int z(int[] a, int b)
{
    var c = 0;
    for (var d = 0; d < a.Length; d++)
    {
        if (a[d] == b)
            c++;
    }
    return c;
}

void function(int[] a)
{
    var b = 0;
    var c = 0;
    for (var d = 0; d < a.Length; d++)
    {
        var e = z(a, a[d]);
        if (e > c)
        {
            c = e;
            b = a[d];
        }
    }
    return b;
}

function([1, 2, 3])
function([2, 1, 1, 1])
function([1, 2, 1])
function([1, 2, 1, 2])