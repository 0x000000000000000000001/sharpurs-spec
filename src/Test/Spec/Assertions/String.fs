let _startsWith (subs: obj) = box (fun (str: obj) -> box ((unbox<string> str).StartsWith(unbox<string> subs)))

let _endsWith (subs: obj) = box (fun (str: obj) -> box ((unbox<string> str).EndsWith(unbox<string> subs)))
