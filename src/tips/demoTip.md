---
title: Cache value of Count/Length for data structures
instead-of: 'For (... ; i < array.Count; …)'
try: 'Int count = array.Count;
For (... ; i < count ; …)'
because: 'C# doesn’t know if you edited the array, it’ll fetch the number from the array. Caching out the length/count is faster.'
difficulty: 0
---