def function(a, b):
    c = 0
    d = 0
    e = []
    while c < len(a) and d < len(b):
        if a[c] < b[d]:
            e.append(a[c])
            c += 1
        else:
            e.append[b[d]]
            d += 1
    
    while c < len(a):
        e.append(a[c])
        c += 1
    
    while d < len(b):
        e.append(b[d])
        d += 1
    
    return e

function([1, 2], [4, 5])
function([1, 4], [2, 3, 100])
function([2, 4, 6, 8], [3, 4])