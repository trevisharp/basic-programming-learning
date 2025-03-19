fn z(a: u32) -> bool {
    if a <= 1 {
        return false;
    }
    for c in 2..a {
        if a % c == 0 {
            return false;
        }
    }
    true
}

fn function(a: Vec<u32>) -> u32 {
    let mut b = 0;
    for &c in a.iter() {
        if z(c) {
            b += 1;
        }
    }
    b
}

function([2])
function([2, 3, 4])
function([3, 4, 5, 6])