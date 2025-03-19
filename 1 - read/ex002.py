def function(a):
    b = []
    for c in range(len(a) - 2):
        b.append(a[c] + 2 * a[c + 1] + a[c + 2])
    return b

function([5, 6, 12])
function([4])
function([1, 1, 1, 1, 1])
function(2)