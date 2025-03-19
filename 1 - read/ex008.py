def z(a, b, c, d):
    return a * d * d + b * d + c

def function(a, b, c, d, e):
    f = 100000000
    g = d
    while g <= e:
        h = z(g)
        if h < f:
            f = h
        g += 1

function(1, 0, 0, -1, 1)
function(1, -1, -1, 0, 2)
function(0, 5, -6, 0, 4)