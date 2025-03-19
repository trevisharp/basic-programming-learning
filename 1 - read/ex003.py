def function(a, b):
    c = 0
    for d in range(a):
        for e in range(b):
            if d == e:
                c += 1
    return c

function(0, 0)
function(4, 2)
function(10, 10)