def function(a, b):
    if len(a) != len(b):
        return "error"
    
    c = 0
    d = 0
    e = len(a)
    for f in range(e):
        if a[f] > b[f]:
            c += 1
        
        if b[f] < a[f]:
            d += 1
    
    return (c, d)

function([1, 2, 3], [2, 3])
function([1, 2, 3], [3, 2, 1])
function([3, 3, 3], [2, 2, 2])