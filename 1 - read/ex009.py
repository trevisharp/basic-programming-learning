def z(a, b):
    c = 1
    for d in range(b):
        c *= a
    return c

def y(a):
    b = 1
    for i in range(a + 1):
        b *= i
    return b

def function(a, b, c):
    return z(a, b) / y(c)

function(0, 0, 0)
function(2, 2, 2)
function(3, 2, 3)