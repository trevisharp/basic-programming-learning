double z(int a[], int b) {
    double c = 0;
    for (int i = 0; i < b; i++) {
        c += a[i];
    }
    return c / b;
}

double function(int a[], int b) {
    double c = z(a, b);
    double d = 0;
    
    for (int i = 0; i < b; i++) {
        d += pow(a[i] - c, 2);
    }
    
    return d / b;
}

function([1])
function([1, 2, 3])
function([4, 4, 4, 100])