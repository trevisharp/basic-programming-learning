def function(a, b):
    for c in range(len(a)):
        d = a[c]
        if d > b:
            return c
    return -1

function([1, 2, 3], 2)
function([3, 3, 3], 3)
function([1, -2, 4, 8], 0)