func function(a []int) (int, int) {
    b := 0
    c := 0

    for _, d := range a {
        if d % 2 == 0 {
            b++
        } else {
            c++
        }
    }

    return b, c
}

function([1, 2, 3])
function([1, 3, 5])
function([2, 4, 6, 8])