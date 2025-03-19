def function(a, b):
    for c in range(len(b)):
        d = False
        for e in range(len(a)):
            if b[c] == a[e]:
                d = True
                break
        if not d:
            return False
    return True

function(4, 4)
function([1], [1])
function([1, 2], [1, 2, 3])
function([1, 4], [1, 2, 3, 4])