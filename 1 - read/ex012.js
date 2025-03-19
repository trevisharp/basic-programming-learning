function func(a, b) {
    let c = a.length;
    let d = b.length;

    for (let e = 0; e <= c - d; e++) {
        let f = true;
        for (let g = 0; g < d; g++) {
            if (a[e + g] !== b[g]) {
                f = false;
                break;
            }
        }

        if (f) {
            return e;
        }
    }

    return -1;
}

func("Oi", "Oi")
func("Ola", "a")
func("Ol", "Ola")
func("Ola", "Oi")