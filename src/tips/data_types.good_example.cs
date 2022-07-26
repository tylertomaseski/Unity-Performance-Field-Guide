//
// EXAMPLE 1
//an optimized string-key dictionary from GDX

static StringKeyDictionary$lt:object$gt: lookupDictionary = ...;

public string ID;

void Awake() {
    lookupDictionary.AddWithExpandCheck(ID, this);
}

...

static void SomeFunc(string ID) {
    var obj;
    TryGetValue(ID, out obj);
    ...   
}

//
// EXAMPLE 2
// alternate and even better, sparse-set from  GDX

static SparseSet sparseSet = ...;
static object[] instances = ..;

private int sparseIndex;
private int denseIndex;

void Awake() {
    sparseSet.AddWithExpandCheck$lt:object$gt:(this, ref instances, out sparseIndex, out denseIndex);
}

...

static void SomeFunc(int sparseIndex) {
    var obj;
    int denseIndex = sparseSet.GetDenseIndexUnchecked(int sparseIndex);
    int index = sparseSet.DenseArray[denseIndex];
    var obj = instances[index];
    ...   
}