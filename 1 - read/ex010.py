def z(a, b):
    c = 0
    for d in range(len(a)):
        if b == a[d]:
            c += 1
    return c

def function(a):
    b = 0
    for c in range(len(a)):
        if z(a, a[c]) > 1:
            b += 1
    return b